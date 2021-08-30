using System;
using System.Collections.Generic;
using System.Text;
namespace GameServer
{

    public class Horoscope
    {

        ConnectionInfo c;
        //const string file = "Horoscope";

        [ContentProto("tries")]
        public byte trys { get; set; }

        [ContentProto("type1")]
        public byte type1 { get; set; }

        [ContentProto("star1")]
        public byte star1 { get; set; }

        [ContentProto("bonus1")]
        public short bonus1 { get; set; }

        [ContentProto("type2")]
        public byte type2 { get; set; }

        [ContentProto("star2")]
        public byte star2 { get; set; }

        [ContentProto("bonus2")]
        public short bonus2 { get; set; }

        [ContentProto("type3")]
        public byte type3 { get; set; }

        [ContentProto("star3")]
        public byte star3 { get; set; }

        [ContentProto("bonus3")]
        public short bonus3 { get; set; }

        [ContentProto("luck")]
        public byte luck { get; set; }


        public double wluck = 0, charexp = 0, petexp = 0, teamexp = 0;

        public Horoscope(ConnectionInfo cc)
        {
            c = cc;
        }

        public void CalculatePower(ConnectionInfo c)
        {
            wluck = 0;
            charexp = 0;
            petexp = 0;
            teamexp = 0;
            DoLecture(c, type1, bonus1);
            DoLecture(c, type2, bonus2);
            DoLecture(c, type3, bonus3);
        }

        private void DoLecture(ConnectionInfo c, byte id, short bonus)
        {
            switch (id - 1)
            {
                case 0:
                    wluck = (double)bonus / 100D;
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    charexp = (double)bonus / 100D;
                    break;
                case 4:
                    teamexp = (double)bonus / 100D;
                    break;
                case 5:
                    petexp = (double)bonus / 100D;
                    break;
                case 6:
                    c.Player.combat.atk += (int)((double)c.Player.combat.atk * (double)(bonus / 100D));
                    break;
                case 7:
                    c.Player.combat.def += (int)((double)c.Player.combat.def * (double)(bonus / 100D));
                    break;
                case 8:
                    c.Player.combat.hp_lim += (int)((double)c.Player.combat.hp * (double)(bonus / 100D));
                    break;
                case 9:
                    c.Player.combat.mp_lim += (int)((double)c.Player.combat.mp * (double)(bonus / 100D));
                    break;
                case 10:
                    c.Player.combat.hit += (int)((double)c.Player.combat.hit * (double)(bonus / 100D));
                    break;
                case 11:
                    c.Player.combat.dod += (int)((double)c.Player.combat.dod * (double)(bonus / 100D));
                    break;
                case 12:
                    c.Player.combat.crit += (int)((double)c.Player.combat.crit * (double)(bonus / 100D));
                    break;
                case 13:
                    c.Player.combat.fort += (int)((double)c.Player.combat.fort * (double)(bonus / 100D));
                    break;
                case 14:
                    c.Player.combat.atk += bonus;
                    break;
                case 15:
                    c.Player.combat.def += bonus;
                    break;
                case 16:
                    c.Player.combat.hp_lim += bonus;
                    break;
                case 17:
                    c.Player.combat.mp_lim += bonus;
                    break;
                case 18:
                    c.Player.combat.hit += bonus;
                    break;
                case 19:
                    c.Player.combat.dod += bonus;
                    break;
                case 20:
                    c.Player.combat.crit += bonus;
                    break;
                case 21:
                    c.Player.combat.fort += bonus;
                    break;

            }
        }

        public bool Load()
        {  
            //bool set = false;

            c.con.StartCommand("SELECT tries, type1, star1, bonus1, type2, star2, bonus2, type3, star3, bonus3, luck FROM horoscope WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);

            return ContentResolver.DoDeserialize<Horoscope>(this, c.con);
            /*Connector.DataReader rd = c.con.ExecuteRead();


            if (rd.CanRead && rd.NextRow())
            {
                trys = rd.ReadByte();

                set = true;
            }
            rd.Close();



            return set;*/
        }

        public bool Save()
        {

            //ByteC.SaveProto(c.accid + file, this);
            c.con.StartCommand("UPDATE horoscope SET tries=?,type1=?,star1=?,bonus1=?,type2=?,star2=?,bonus2=?,type3=?,star3=?,bonus3=?,luck=? WHERE roleid=?;");

            c.con.AddValue(trys);
            c.con.AddValue(type1);
            c.con.AddValue(star1);
            c.con.AddValue(bonus1);
            c.con.AddValue(type2);
            c.con.AddValue(star2);
            c.con.AddValue(bonus2);
            c.con.AddValue(type3);
            c.con.AddValue(star3);
            c.con.AddValue(bonus3);
            c.con.AddValue(luck);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool Insert(int rlid)
        {
            //ByteC.SaveProto(c.accid + file, this);
            c.con.StartCommand("INSERT INTO horoscope(roleid, tries, type1, star1, bonus1, type2, star2, bonus2, type3, star3, bonus3, luck) VALUES (?,?,?,?,?,?,?,?,?,?,?,?);");
            c.con.AddValue(rlid);
            c.con.AddValue(trys);
            c.con.AddValue(type1);
            c.con.AddValue(star1);
            c.con.AddValue(bonus1);
            c.con.AddValue(type2);
            c.con.AddValue(star2);
            c.con.AddValue(bonus2);
            c.con.AddValue(type3);
            c.con.AddValue(star3);
            c.con.AddValue(bonus3);
            c.con.AddValue(luck);
            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            Horoscope n = new Horoscope(c);

            n.GenerateHoroscope();
            n.trys = 3;
            bool result = n.Insert(roleid);
            n = null;
            return result;
        }

        public void GenerateHoroscope()
        {
            //////////////////////////////////////////////////////////////////////////////////

            ShuffleList<byte> types = new ShuffleList<byte>(), stars = new ShuffleList<byte>();
            types.AddRange(horoscopeHelper.values);
            stars.AddRange(horoscopeHelper.stars);

            types.ShuffleInplace();
            stars.ShuffleInplace();

            type1 = (byte)(types.Pop() + 1);//(byte)Randoms.Next(1, 22);
            star1 = (byte)(stars.Pop() + 1);//(byte)Randoms.Next(1, 5);
            bonus1 = horoscopeHelper.value[type1 - 1][star1 - 1];

            ///////////////////////////////////////////////////////////////////////////
            types.ShuffleInplace();
            stars.ShuffleInplace();

            type2 = (byte)(types.Pop() + 1);//(byte)Randoms.Next(1, 22);
            star2 = (byte)(stars.Pop() + 1);//(byte)Randoms.Next(1, 5);
            bonus2 = horoscopeHelper.value[type2 - 1][star2 - 1];

            ////////////////////////////////////////////////////
            types.ShuffleInplace();
            stars.ShuffleInplace();

            type3 = (byte)(types.Pop() + 1);//(byte)Randoms.Next(1, 22);
            star3 = (byte)(stars.Pop() + 1);//(byte)Randoms.Next(1, 5);
            bonus3 = horoscopeHelper.value[type3 - 1][star3 - 1];

            //////////////////////////////////////////////////////////////////////////

            luck = 4;
            //Save(c);

            stars.Clear();
            types.Clear();
            stars = null;
            types = null;
        }
    }

}
