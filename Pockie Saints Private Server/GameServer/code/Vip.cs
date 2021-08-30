using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public class Vip
    {

        #region Vip Calcs
        internal static int[] vips = new int[] { 0, 100, 500, 1000, 2000, 5000, 10000, 30000, 50000, 100000, 200000, 400000, 800000, 1500000, 2800000, 4500000 };
        internal static byte[] exps = new byte[] { 0, 0, 0, 0, 0, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 };

        internal static int[] VipPackBoundGold = new int[] { 0, 5000, 10000, 15000, 20000, 40000, 60000, 80000, 100000, 120000, 150000, 200000, 300000, 400000, 500000, 600000 };
        internal static int[] VipPackBountCrystal = new int[] { 0, 10, 15, 20, 25, 30, 35, 40, 45, 50, 60, 70, 80, 90, 100, 110 };


        public static void Init()
        {
            viprewards = new VipRewardItem[15];
            byte i;
            for (i = 0; i < 15; i++) viprewards[i].items = new List<int[]>();

            // viprewards[i].items.Add(new int[]{});

            i = 0;
            viprewards[i].gold = 10000;
            viprewards[i].items.Add(new int[] { 9020008, 10 });

            i++;
            viprewards[i].gold = 50000;
            viprewards[i].items.Add(new int[] { 9020008, 20 });
            viprewards[i].items.Add(new int[] { 3320001, 10 });

            i++;
            viprewards[i].gold = 100000;
            viprewards[i].items.Add(new int[] { 9020008, 40 });
            viprewards[i].items.Add(new int[] { 3320001, 20 });
            viprewards[i].items.Add(new int[] { 1117004, 1 });


            i++;
            viprewards[i].gold = 200000;
            viprewards[i].items.Add(new int[] { 9020008, 80 });
            viprewards[i].items.Add(new int[] { 3320002, 20 });
            viprewards[i].items.Add(new int[] { 1117004, 2 });

            i++;
            viprewards[i].gold = 500000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 21 });
            viprewards[i].items.Add(new int[] { 3320002, 30 });
            viprewards[i].items.Add(new int[] { 1117005, 1 });
            viprewards[i].items.Add(new int[] { 1114020, 1 });

            i++;
            viprewards[i].gold = 1000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 61 });
            viprewards[i].items.Add(new int[] { 3320002, 40 });
            viprewards[i].items.Add(new int[] { 1117005, 2 });
            viprewards[i].items.Add(new int[] { 1114028, 1 });

            i++;
            viprewards[i].gold = 2000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 2 });
            viprewards[i].items.Add(new int[] { 3320002, 50 });
            viprewards[i].items.Add(new int[] { 1117006, 1 });
            viprewards[i].items.Add(new int[] { 1114036, 1 });

            i++;
            viprewards[i].gold = 3000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 52 });
            viprewards[i].items.Add(new int[] { 3320003, 40 });
            viprewards[i].items.Add(new int[] { 1117006, 2 });
            viprewards[i].items.Add(new int[] { 1114035, 1 });

            i++;
            viprewards[i].gold = 4000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 3 });
            viprewards[i].items.Add(new int[] { 3320003, 50 });
            viprewards[i].items.Add(new int[] { 1117007, 1 });
            viprewards[i].items.Add(new int[] { 1114043, 1 });

            i++;
            viprewards[i].gold = 5000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 4 });
            viprewards[i].items.Add(new int[] { 3320003, 60 });
            viprewards[i].items.Add(new int[] { 1117007, 2 });
            viprewards[i].items.Add(new int[] { 1114051, 1 });

            i++;
            viprewards[i].gold = 7000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 5 });
            viprewards[i].items.Add(new int[] { 3320004, 50 });
            viprewards[i].items.Add(new int[] { 1117007, 3 });
            viprewards[i].items.Add(new int[] { 1114057, 1 });

            i++;
            viprewards[i].gold = 10000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 6 });
            viprewards[i].items.Add(new int[] { 3320004, 60 });
            viprewards[i].items.Add(new int[] { 1117007, 4 });
            viprewards[i].items.Add(new int[] { 1114060, 1 });

            i++;
            viprewards[i].gold = 15000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 7 });
            viprewards[i].items.Add(new int[] { 3320004, 70 });
            viprewards[i].items.Add(new int[] { 1117007, 6 });
            viprewards[i].items.Add(new int[] { 1040017, 1 });

            i++;
            viprewards[i].gold = 20000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 8 });
            viprewards[i].items.Add(new int[] { 3320004, 80 });
            viprewards[i].items.Add(new int[] { 1117007, 8 });
            viprewards[i].items.Add(new int[] { 1114062, 1 });

            i++;
            viprewards[i].gold = 25000000;
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 99 });
            viprewards[i].items.Add(new int[] { 9020008, 9 });
            viprewards[i].items.Add(new int[] { 3320004, 90 });
            viprewards[i].items.Add(new int[] { 1117007, 10 });
            viprewards[i].items.Add(new int[] { 1114059, 1 });


        }


        //const string file = "vip";

        public struct VipRewardItem
        {
            public int gold;
            public List<int[]> items;

        }

        public static VipRewardItem[] viprewards;
        #endregion

        [ContentProto("viplvl")]
        public byte vip_level { get; set; }

        [ContentProto("vipexp")]
        public int crystal { get; set; }

        [ContentProto("vipexpire")]
        public int time { get; set; }

        [ContentProto("vippack")]
        public byte claimpack { get; set; }

        [ContentProto("vipbuff")]
        public byte claimbuff { get; set; }

        /* [ProtoMember(6)]
         public byte packday { get; set; }

         [ProtoMember(7)]
         public byte buffday { get; set; }*/

        [ContentProto("vipclaim")]
        public byte[] claimstack { get; set; }

        ConnectionInfo c;


        public Vip(ConnectionInfo cc)
        {
            c = cc;
        }



        public void AllocateVip(int crystals)
        {

            for (byte i = 0; i < vips.Length; i++)
            {
                if (crystal < vips[i])
                {
                    vip_level = i;
                    break;
                }
            }

            crystal += crystals;
            time = 0;
        }

        public void AllocateTrial(byte level)
        {

            vip_level = level;
            time = (int)DateUtil.GetDaysIntZone(7);
        }

        /*   public void Check(ConnectionInfo c)
           {

               if (claimbuff == 0 || claimpack == 0)
               {
                   if (c.Player.active.day != DateUtil.GetZoneDate().Day) claimpack = 0;
                   if (c.Player.active.day != DateUtil.GetZoneDate().Day) claimbuff = 0;
                   Save(c);
               }


           }
           */


        public bool RunCheck(ConnectionInfo c)
        {

            if (time != 0)
            {
                if (time < DateUtil.GetDateIntZone())
                {
                    time = 0;
                    vip_level = GetVip();
                    Save();
                }
            }

            if (crystal != 0)
            {


                if (c.Player.quest.Qlist.ContainsKey(129004))
                {
                    ByteArray b = new ByteArray();
                    c.Player.quest.RemoveQtask(129004);
                    c.Player.quest.AddTaskComplete(129004, 502034, 1, 1, 502);
                   // c.Player.quest.Save();


                    b.WriteShort(4);
                    b.WriteShort(30006);



                    c.Player.Send(b.GetByteArray());
                    b.Close();
                }

            }

            if (crystal < vips[1]) return false;


            byte iv = GetVip();

            if (iv != vip_level)
            {
                time = 0;


                vip_level = iv;

                Save();
                return true;
            }


            return false;
        }

        public byte GetVip()
        {
            for (byte i = 0; i < vips.Length; i++)
            {
                if (crystal > vips[i])
                {
                    continue;
                }
                return (byte)(i);
            }

            return 0;
        }

        public void GetClaims(ConnectionInfo c)
        {

            for (byte i = 0; i < 15; i++)
            {

                if (claimstack[i] == 1)
                {
                    c.ot.WriteByte(1);
                }
                else
                {
                    if (crystal < vips[i + 1])
                    {
                        c.ot.WriteByte(1);
                    }
                    else
                    {
                        c.ot.WriteByte(0);
                    }
                }


            }


        }

        public bool CanClaim(byte id)
        {
            if (claimstack[id - 1] == 0 && crystal >= vips[id])
            {

                return true;
            }


            return false;
        }

        public byte ClaimVipPack(ConnectionInfo c)
        {

            c.Player.bag.bgold += VipPackBoundGold[vip_level];
            c.Player.bag.bcrystal += VipPackBountCrystal[vip_level];
            c.Player.bag.Save();

            return 1;
        }

        public byte[] UpdateHoroscope(ConnectionInfo c)
        {
            if (vip_level > 3 && vip_level < 11)
            {
                c.Player.horoscope.trys += vip_level;
            }
            else if (vip_level > 10)
            {
                c.Player.horoscope.trys = 99;
            }
            c.Player.horoscope.Save();

            ByteArray ot = new ByteArray();
            ot.WriteByte(1);
            ot.WriteByte(c.Player.horoscope.trys);
            ot.WriteByte(c.Player.horoscope.type1);
            ot.WriteByte(c.Player.horoscope.star1);
            ot.WriteShort(c.Player.horoscope.bonus1);
            ot.WriteByte(c.Player.horoscope.type2);
            ot.WriteByte(c.Player.horoscope.star2);
            ot.WriteShort(c.Player.horoscope.bonus2);
            ot.WriteByte(c.Player.horoscope.type3);
            ot.WriteByte(c.Player.horoscope.star3);
            ot.WriteShort(c.Player.horoscope.bonus3);
            ot.WriteByte(c.Player.horoscope.luck);
            ot.PackArray(17001);

            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            return d;
        }

        public bool Load()
        {
            c.con.StartCommand("SELECT viplvl,vipexp,vipexpire,vippack,vipbuff,vipclaim FROM vip WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);
            return ContentResolver.DoDeserialize<Vip>(this, c.con);
        }

        public bool Save()
        {
            c.con.StartCommand("UPDATE vip SET ? WHERE roleid=?;");
            c.con.AddValue(ContentResolver.DoSerializeUpdate<Vip>(this), true);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO vip(roleid,viplvl,vipexp) VALUES(?,?,?);");
            c.con.AddValue(roleid);
            c.con.AddValue(Game.StartVip);
            c.con.AddValue(Vip.vips[Game.StartVip]);
            return c.con.ExecuteNoneQuery() > 0;
        }

    }


}
