using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public static class ZodiacGoalHelper
    {
        public struct ZodiaGoalItems
        {
            public int BoundCrystal;
            public int BoundGold;
            public int[][] Items;
        }

        public static ZodiaGoalItems[] GoalItems;

        public static void Init()
        {
            ByteArray ar = new ByteArray("system/ZodiacGoal.bin");

            byte c = ar.ReadByte(); ;

            GoalItems = new ZodiaGoalItems[c];

            for (byte x = 0; x < c; x++)
            {
                ZodiaGoalItems zd = new ZodiaGoalItems();
                zd.BoundCrystal = ar.ReadInt();
                zd.BoundGold = ar.ReadInt();

                if (ar.ReadByte() == 1)
                {
                    zd.Items = new int[1][];

                    zd.Items[0] = new int[2];
                    zd.Items[0][0] = ar.ReadInt();
                    zd.Items[0][1] = ar.ReadByte();

                }
                else
                {
                    zd.Items = new int[2][];

                    zd.Items[0] = new int[2];
                    zd.Items[0][0] = ar.ReadInt();
                    zd.Items[0][1] = ar.ReadByte();

                    zd.Items[1] = new int[2];
                    zd.Items[1][0] = ar.ReadInt();
                    zd.Items[1][1] = ar.ReadByte();
                }
                GoalItems[x] = zd;
            }


            ar.Close();
        }
    }


    public class ZodiacGoal
    {
        public static byte[] count = new byte[] { 0, 6, 15, 23, 30 };

        ConnectionInfo c;

        [ContentProto("zvalue")]
        public byte[] zodiac { get; set; }


        public ZodiacGoal(ConnectionInfo cc)
        {
            zodiac = new byte[30];
            c=cc;
        }

        public byte GetLevel()
        {
            byte lev = 1;
            byte i = 1;
            //byte j = 0;
            //bool isbreak=false;

            for (int x = 0; x < 30; x++)
            {
                if (zodiac[x] ==0)
                {
                    break;
                }

                i++;
            }


            if (i > 23)
                lev = 4;
            else if (i > 15)
                lev = 3;
            else if (i > 6)
                lev = 2;

            return lev;
        }

        public bool Load()
        {
            //ByteC.LoadProto(c.accid + file, ref inst);
            c.con.StartCommand("SELECT zvalue FROM zodiacgoal WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);

            return ContentResolver.DoDeserialize<ZodiacGoal>(this, c.con);
        }

        public bool Save()
        {
            c.con.StartCommand("UPDATE zodiacgoal SET zvalue=? WHERE roleid=?;");
            c.con.AddValue(zodiac);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create( int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO zodiacgoal(roleid) VALUES(?);");
            c.con.AddValue(roleid);

            return c.con.ExecuteNoneQuery() > 0;

        }
    }
}
