using System;
using System.Collections.Generic;
using System.Text;
using Connector;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace GameServer
{
    internal static class RoleData
    {

        internal static int[] CharExp;

        internal static void init()
        {
            CharExp = new int[120];

            CharExp[0] = 0;
            CharExp[1] = 26;
            CharExp[2] = 110;
            CharExp[3] = 322;
            CharExp[4] = 722;
            CharExp[5] = 1370;
            CharExp[6] = 2326;
            CharExp[7] = 3650;
            CharExp[8] = 5402;
            CharExp[9] = 7642;
            CharExp[10] = 10430;
            CharExp[11] = 13826;
            CharExp[12] = 17890;
            CharExp[13] = 22682;
            CharExp[14] = 28262;
            CharExp[15] = 36000;
            CharExp[16] = 71680;
            CharExp[17] = 115800;
            CharExp[18] = 168480;
            CharExp[19] = 231040;
            CharExp[20] = 273600;
            CharExp[21] = 350513;
            CharExp[22] = 414497;
            CharExp[23] = 509295;
            CharExp[24] = 616246;
            CharExp[25] = 656100;
            CharExp[26] = 709817;
            CharExp[27] = 759247;
            CharExp[28] = 813305;
            CharExp[29] = 862518;
            float perc = 0.02f;
            for (int x = 30; x < CharExp.Length; x++)
            {
                CharExp[x] = CharExp[x - 1] + (int)(CharExp[x - 1] * perc);
                perc += 0.02f;
                if (perc > 0.10) perc = 0.02f;
            }

        }
    }

    [Serializable]
    public class Role
    {

        ConnectionInfo c;

        public Role(ConnectionInfo cc)
        {
            c = cc;
        }

        [ContentProto("sex")]
        public byte sex { get; set; }

        [ContentProto("lvl")]
        public byte level { get; set; }

        [ContentProto("career")]
        public byte career { get; set; }

        [ContentProto("faction")]
        public byte faction { get; set; }

        [ContentProto("constellation")]
        public byte star { get; set; }

        [ContentProto("charname")]
        public String name { get; set; }

       [ContentProto("weapon_id")]
        public int weapon_id { get; set; }

        [ContentProto("armor_id")]
        public int armor_id { get; set; }

        [ContentProto("prestige")]
        public int state_prestige { get; set; }

        [ContentProto("trial")]
        public int Trial { get; set; }

        [ContentProto("nobility")]
        public byte z5a_nobility { get; set; }

        [ContentProto("sinc")]
        public short sin { get; set; }

        /// ///////////////////////////////////////////////////

        [ContentProto("charm")]
        public int charm { get; set; }

        [ContentProto("mateid")]
        public int mate_id { get; set; }


        [ContentProto("matename",true)]
        public String mate_name { get; set; }

        [ContentProto("matefaction",true)]
        public byte mate_faction { get; set; }


        /// ///////////////////////////////////////////////////////


        [ContentProto("mapid")]
        public int map_id { get; set; }

        [ContentProto("mapx")]
        public short posx { get; set; }

        [ContentProto("mapy")]
        public short posy { get; set; }

        [ContentProto("expc")]
        public int exp { get; set; }

        [ContentProto("expclim")]
        public int exp_lim { get; set; }

        [ContentProto("ranger")]
        public byte zc_ranger { get; set; }

        [ContentProto("speed")]
        public short speed { get; set; }

        [ContentProto("atkspeed")]
        public short atk_speed { get; set; }

        [ContentProto("pkmode")]
        public short pk_mode { get; set; }

        [ContentProto("pktime")]
        public int pk_time { get; set; }

        //[Content("honor")]
        public int bhonor { get; set; }

        //[ProtoMember(28)]
        public int dreamre { get; set; }

        [ContentProto("guildpoint")]
        public int guildhonor { get; set; }

        //[ProtoMember(30)]
        public int chonor { get; set; }

        ////[ProtoMember(31)](
        public byte rest { get; set; }

        //[ProtoMember(31)]
        public byte showType { get; set; }

        //[ProtoMember(32)]
        public byte LastLevel { get; set; }

        [ContentProto("isgm",true)]
        public bool IsGm { get; set; }

        [ContentProto("titleid")]
        public short title_id { get; set; }
        // public Profile info;


        /* public static void Load<t>(ConnectionInfo c, ref t val)
         {
             ByteC.LoadProto(c.accid + file, ref val);
         }*/

        public bool Save()
        {
            //log.trace.Save(Environment.StackTrace);
            c.con.StartCommand("UPDATE role SET ? WHERE roleid=?;");
            c.con.AddValue(ContentResolver.DoSerializeUpdate<Role>(this),true);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery()>0;
        }

        public bool LevelUp()
        {

            if (exp >= exp_lim)
            {
                LastLevel = level;
                level++;
                exp = exp - exp_lim;
                exp_lim = RoleData.CharExp[level];

                while (exp >= exp_lim && level < RoleData.CharExp.Length)
                {
                    level++;
                    exp = exp - exp_lim;
                    exp_lim = RoleData.CharExp[level];
                }
                if (level == RoleData.CharExp.Length) exp = 0;
                //LastLevel=


                return true;
            }

            return false;
        }

        public void SetLastLevel()
        {
            LastLevel = level;
        }

        public bool UpdateLevel()
        {
            c.con.StartCommand("UPDATE role SET lvl=?,expc=?,expclim=? WHERE roleid=?");
            c.con.AddValue(level);
            c.con.AddValue(exp);
            c.con.AddValue(exp_lim);
            c.con.AddValue(c.rlid);

            //bool loaded = ;


            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool UpdateTitle(short titleid)
        {
            c.con.StartCommand("UPDATE role SET titleid=? WHERE roleid=?;");
            c.con.AddValue(title_id);
            c.con.AddValue(c.rlid);

            bool loaded = c.con.ExecuteNoneQuery() > 0;


            if (loaded)
            {
                title_id = titleid;
            }
            return loaded;
        }

        public bool Load()
        {
            string q = "SELECT o.sex, o.lvl, o.career, o.faction, o.constellation, o.charname,o.weapon_id,o.armor_id, o.rolestatus, o.trial, o.honor, o.guildpoint, o.prestige, o.nobility, o.sinc, o.charm, o.mateid, o.Expc, o.ExpcLim, o.speed, o.ranger, o.atkspeed, o.pkmode, o.pktime, o.mapid, o.mapx, o.mapy, o.titleid, m.charname matename,m.faction matefaction,o.isgm"
                    + " FROM role o"
                    + " LEFT OUTER JOIN role m"
                    + " ON m.roleid=o.mateid"
                    + " WHERE o.roleid=? LIMIT 1;";

            c.con.StartCommand(q);
            c.con.AddValue(c.rlid);
            return ContentResolver.DoDeserialize<Role>(this, c.con);
        }

        public static int Create(ConnectionInfo c, byte career, byte sex, string name, byte constellation)
        {

           // MySqlConnector con = Game.GetConnection();
            byte level = Game.StartLevel;

            c.con.StartCommand("INSERT INTO role(career,sex,constellation,ranger,charname,regtime,accid) VALUES (?,?,?,?,?,?,?);");
            c.con.AddValue(career);
            c.con.AddValue(sex);
            c.con.AddValue(constellation);
            c.con.AddValue(career == 2 ? 6 : 1);  // attack range distance if role not mage the attack range is 1
            c.con.AddValue(name);
            c.con.AddValue(DateUtil.GetDateIntZone()); // time created
            c.con.AddValue(c.accid, true);


            if (c.con.ExecuteNoneQuery() > 0)
            {
                int rlid = (int)c.con.LastID; // get the last inserted ID
                return rlid;
            }
            return 0;


        }
    }

}
