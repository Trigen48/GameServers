using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public class RewardItem
    {

        public byte id { get; set; }


        public byte level { get; set; }


        public List<RewardItemContent> items { get; set; }

        public RewardItem()
        {
            items = new List<RewardItemContent>();
        }

        public RewardItem(byte Id, byte Level, RewardItemContent[] itemz)
        {
            level = Level;
            id = Id;
            items = new List<RewardItemContent>();
            items.AddRange(itemz);
        }

    }


    public class RewardItemContent
    {

        public int ItemId { get; set; }


        public byte count { get; set; }

        public bool isWeapon { get; set; }

        public RewardItemContent()
        {
        }

        public RewardItemContent(int id, byte co)
        {
            ItemId = id;
            count = co;
        }
        public RewardItemContent(int id, byte co, bool IsWeapon)
        {
            ItemId = id;
            count = co;
            isWeapon = IsWeapon;
        }
    }

    public static class RewardHelper
    {
        public static RewardItem[] ritems;
        public static RewardItem[] fitems;

        public static void Init()
        {
            ritems = new RewardItem[14];

            ritems[1] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(2010001, 20)
            });

            ritems[2] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(2020001, 20)
            });

            ritems[3] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(8010001, 1)
            });

            ritems[4] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(8020001, 1)
            });

            ritems[5] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(8030001, 3),
                new RewardItemContent(1030006, 1)
            });

            ritems[6] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(6010001, 15),
                new RewardItemContent(8010001, 1),
                new RewardItemContent(8020001, 1)
            });

            ritems[7] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(3011001, 1)
            });

            ritems[8] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(2230001, 2)
            });

            ritems[9] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(2231012, 1),
                new RewardItemContent(2230001, 3)
            });

            ritems[10] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(2231012, 1),
                new RewardItemContent(2230001, 4)
            });

            ritems[11] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(2231012, 1),
                new RewardItemContent(2230001, 5)
            });

            ritems[12] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(3012006, 5),
                new RewardItemContent(3018001, 2)
            });

            ritems[13] = new RewardItem(0, 1, new RewardItemContent[]
            {
                new RewardItemContent(3012006, 5),
                new RewardItemContent(3011001, 2),
                new RewardItemContent(2231012, 2)
            });



            fitems = new RewardItem[11];


            fitems[1] = (new RewardItem(1, 6, new RewardItemContent[] {
					new RewardItemContent(1024000, 1,true), 
					new RewardItemContent(3012006, 4), 
					new RewardItemContent(8040001, 1)}));


            fitems[2] = (new RewardItem(2, 11, new RewardItemContent[] {
					new RewardItemContent(2260001, 1), 
					new RewardItemContent(6010001, 5)}));


            fitems[3] = (new RewardItem(3, 13, new RewardItemContent[] {
					new RewardItemContent(6010001, 5),
					new RewardItemContent(2230001, 1), 
					new RewardItemContent(8030001, 1)}));

            fitems[4] = (new RewardItem(4, 14, new RewardItemContent[] {
					new RewardItemContent(8030001, 1), 
					new RewardItemContent(2230001, 1), 
					new RewardItemContent(8040001, 1)}));

            fitems[5] = (new RewardItem(5, 20, new RewardItemContent[] {
					new RewardItemContent(8010001, 1), 
					new RewardItemContent(8020001, 1), 
					new RewardItemContent(2230001, 1)}));

            fitems[6] = (new RewardItem(6, 27, new RewardItemContent[] {
					new RewardItemContent(9020008, 10), 
					new RewardItemContent(8030001, 1), 
					new RewardItemContent(8040001, 1)}));

            fitems[7] = (new RewardItem(7, 28, new RewardItemContent[] {
					new RewardItemContent(9020008, 15), 
					new RewardItemContent(2230001, 1)}));

            fitems[8] = (new RewardItem(8, 29, new RewardItemContent[] {
					new RewardItemContent(9020008, 20), 
					new RewardItemContent(8030001, 1), 
					new RewardItemContent(8040001, 1)}));

            fitems[9] = (new RewardItem(9, 30, new RewardItemContent[] {
					new RewardItemContent(9020008, 25), 
					new RewardItemContent(8030001, 1)}));

            fitems[10] = (new RewardItem(10, 31, new RewardItemContent[] {
					new RewardItemContent(1020036, 1,true), 
					new RewardItemContent(1110001, 3), 
					new RewardItemContent(2230001, 1), 
					new RewardItemContent(8030001, 1)}));

        }

        public static int GetTime(byte phase)
        {
            switch (phase)
            {
                case 1:
                    return 30;

                case 2:
                    return 60;

                case 3:
                    return 120;

                case 4:
                    return 180;

                case 5:
                    return 300;

                case 6:
                    return 480;

                case 7:
                    return 120;

                case 8:
                    return 300;

                case 9:
                    return 1200;

                case 10:
                    return 2400;

                case 11:
                    return 3600;

                case 12:
                    return 7200;

                case 13:
                    return 14400;


                default:
                    return 0;
            }
        }

        public static byte Count(byte phase)
        {
            return (byte)ritems[phase].items.Count;
        }

        public static void Claim(ConnectionInfo c, byte phase)
        {
            //c.Player.pa

            if (phase == 5)
            {
                c.Player.bag.AddBagItem(ritems[phase].items[0].ItemId, ritems[phase].items[0].count, 2);
                c.Player.bag.AddBagItem(ritems[phase].items[1].ItemId + c.Player.role.career, (byte)ritems[phase].items[1].count, 2);
            }
            else
            {
                for (byte i = 0; i < Count(phase); i++)
                {
                    c.Player.bag.AddBagItem(ritems[phase].items[i].ItemId, ritems[phase].items[i].count, 2);
                }
            }
            //c.Player.bag.Save();
        }
    }


    public class Reward
    {
        //const string file = "reward";
        ConnectionInfo c;
        //public List<RewardItem> StartReward { get; set; }  
        [ContentProto("rewardphase")]
        public byte rewardphase { get; set; }

        [ContentProto("remain")]
        public int remain { get; set; }

        [ContentProto("phase")]
        public byte phase { get; set; }

        //[ProtoMember(4)]
        public int targettime = 0;//{ get; set; }

        public Reward(ConnectionInfo cc)
        {
            c = cc;
        }
        public bool Load()
        {
            //ByteC.LoadProto(c.accid + file, ref r);
            c.con.StartCommand("SELECT rewardphase,phase,remain FROM reward WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);
            return ContentResolver.DoDeserialize<Reward>(this, c.con);
        }

        public bool Save()
        {
            //ByteC.SaveProto(c.accid + file, this);
            c.con.StartCommand("UPDATE reward SET rewardphase=?,phase=?, remain=? WHERE roleid=?;");
            c.con.AddValue(rewardphase);
            c.con.AddValue(phase);
            c.con.AddValue(remain);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO reward(roleid) VALUES(?);");
            c.con.AddValue(roleid);
            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}
