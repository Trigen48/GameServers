using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public static class SkillHelper
    {
        public static Dictionary<int, int> Skills;

        public static void Init()
        {
            Skills = new Dictionary<int, int>();
            ByteArray ar = new ByteArray("system/SkillPort.bin");
            int c = ar.ReadInt();
            for (int x = 0; x < c; x++)
            {
                int i1, i2;
                i1 = ar.ReadInt();
                i2 = ar.ReadInt();
                if (!Skills.ContainsKey(i1))
                    Skills.Add(i1, i2);
            }

            ar.Close();
        }

    }


    public class Skill
    {
        // const string file = "skills";
        ConnectionInfo c;
       
        public class SkillItem
        {
            [ContentProto("skillid")]
            public int skill_id { get; set; }

            [ContentProto("skilllvl")]
            public byte skill_level { get; set; }

            [ContentProto("skilltime")]
            public int skill_time { get; set; }

            [ContentProto("skilluse")]
            public short SkillUseTime { get; set; }

            [ContentProto("skilltpe")]
            public byte Type { get; set; }

            /*[ProtoMember(6)]
            public int[][] SkillData{get; set;}
            */
            public SkillItem()
            {
            }

            public SkillItem(int Skill_Id, byte Skill_Level, int Skill_Time)
            {
                skill_id = Skill_Id;
                skill_level = Skill_Level;
                skill_time = Skill_Time;

                //SkillData = null;
                Type = 0;
                SkillUseTime = 20;
            }

            //skilluse, skilltype
            public SkillItem(int Skill_Id, byte Skill_Level, int Skill_Time,short Skill_Use,byte Skill_Type)
            {
                skill_id = Skill_Id;
                skill_level = Skill_Level;
                skill_time = Skill_Time;

                //SkillData = null;
                Type = Skill_Type;
                SkillUseTime = Skill_Use;
            }

            public int GetSkillTime()
            {
                int left = (int)(skill_time - DateUtil.GetDateInt());

                if (left < 0)
                    return 0;
                else
                    return left;

            }
        }


        public List<SkillItem> skills;
        public int Time;

        public Skill(ConnectionInfo cc)
        {
            c = cc;
            skills = new List<SkillItem>();
        }

        public bool SkillRequire(int id, byte level)
        {
            int ix = skills.FindIndex(
                delegate(SkillItem itm)
                {
                    return itm.skill_id == id && itm.skill_level >= level;
                });

            return ix != -1;
        }

        public int SkillIndex(int id)
        {
            int ix = skills.FindIndex(
                delegate(SkillItem itm)
                {
                    return itm.skill_id == id;
                });
            return ix;
        }

        public bool SkillExists(int id)
        {
            return SkillIndex(id) != -1;
        }

        public bool SkillActive(int id)
        {
            int ix = SkillIndex(id);

            if (skills[ix].skill_time > DateUtil.GetDateIntZone()) return true;
            return false;
        }

        public int GetDeform(byte car)
        {
            int sk = int.Parse(car.ToString() + "01118");
            if (SkillExists(sk))
            {
                if (SkillActive(sk))
                {
                    return 8050001;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public bool AddSkill(int id)
        {
            return AddSkill(id, true);
        }

        public bool AddSkill(int id, bool isnew)
        {
            SkillItem s = new SkillItem();
            if (isnew)
            {
                s.skill_id = id;
                s.skill_level = 1;
                c.con.StartCommand("INSERT INTO skill(roleid, skillid,skilltype) VALUES (?,?,?);");
                c.con.AddValue(c.rlid);
                c.con.AddValue(s.skill_id);
                c.con.AddValue(s.Type);

                if (c.con.ExecuteNoneQuery() > 0)
                {
                    skills.Add(s);
                    return true;
                }
            }
            else
            {
                int ix = SkillIndex(id);

                c.con.StartCommand("UPDATE skill SET skilllvl=skilllvl+1 WHERE skillid=? AND roleid=?");
                c.con.AddValue(id);
                c.con.AddValue(c.rlid);

                if (c.con.ExecuteNoneQuery() > 0)
                {
                    s = skills[ix];
                    s.skill_level++;
                    skills[ix] = s;
                    return true;
                }
                

            }
            return false;
        }

        public byte SkillLevel(int id)
        {

            int ix = SkillIndex(id);

            return (byte)(skills[ix].skill_level + 1);
        }

        public bool UseSkill(int id)
        {
            int ix = SkillIndex(id);
            SkillItem sk = skills[ix];

            int skilltime = (int)(sk.SkillUseTime + DateUtil.GetDateInt());


            c.con.StartCommand("UPDATE skill SET skilltime=? WHERE skillid=? AND roleid=?;");
            c.con.AddValue(skilltime);
            c.con.AddValue(id);
            c.con.AddValue(c.rlid);


            if (c.con.ExecuteNoneQuery() > 0)
            {

                sk.skill_time = skilltime;
                skills[ix] = sk;

                return true;
            }

            return false;
        }


        public bool Load()
        {
            //  ByteC.LoadProto(c.accid + file, ref inst);
            c.con.StartCommand("SELECT skillid, skilllvl, skilltime, skilluse, skilltype FROM skill WHERE roleid=?;");
            c.con.AddValue(c.rlid);

            Connector.DataReader rd = c.con.ExecuteRead();

            bool set = rd.CanRead;
            if (rd.CanRead)
            {
                while (rd.NextRow())
                {
                    SkillItem sk = new SkillItem(rd.ReadInt(), rd.ReadByte(), rd.ReadInt(), rd.ReadByte(), rd.ReadByte());
                    skills.Add(sk);
                }

               
            }
            rd.Close();
            return set;
        }

       /* public void Save(ConnectionInfo c)
        {
            ByteC.SaveProto(c.accid + file, this);
        }*/

       /* public static void Create(ConnectionInfo c)
        {
            ByteC.Blank(c.accid + file);
            //  System.IO.File.WriteAllBytes( + "skills", new byte[] { 0 });
        }*/
    }


}
