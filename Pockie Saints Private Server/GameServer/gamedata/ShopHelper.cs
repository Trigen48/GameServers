using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    internal static class ShopHelper
    {

        public class ShopItem
        {
            public int type, cost, time;
            public byte costtype, limit;
            public int origprice;
            public bool deduct = false;
            public ShopItem()
            {
                type = 0;
                cost = 0;
                time = 0;
                costtype = 0;
                limit = 0;

            }
            public ShopItem(int Type, int Cost, int Time, Byte CostType, Byte Limit)
            {
                type = Type;
                cost = Cost;
                time = Time;
                costtype = CostType;
                limit = Limit;
                origprice = 0;
            }
            public ShopItem(int Type, int Cost, int Time, Byte CostType, Byte Limit, int OrigPrice)
            {
                type = Type;
                cost = Cost;
                time = Time;
                costtype = CostType;
                limit = Limit;
                origprice = OrigPrice;
                deduct = true;
            }

            public ShopItem Clone()
            {
                return new ShopItem(type, cost, time, costtype, limit, origprice);
            }
        }

        public class RandomItem : ShopItem
        {
            public int mincost = 0, maxcost = 0;
            public bool Rare = false;
            public int chance = 100;

            public RandomItem()
            {
                type = 0;
                cost = 0;
                time = 0;
                costtype = 0;
                limit = 0;

            }
            public RandomItem(int Type, int Cost, int Time, Byte CostType, Byte Limit)
            {
                type = Type;
                cost = Cost;
                time = Time;
                costtype = CostType;
                limit = Limit;
                origprice = 0;
            }
            public RandomItem(int Type, int Cost, int Time, Byte CostType, Byte Limit, int OrigPrice)
            {
                type = Type;
                cost = Cost;
                time = Time;
                costtype = CostType;
                limit = Limit;
                origprice = OrigPrice;
                deduct = true;
            }

            public RandomItem(int Type, int Cost, int Time, Byte CostType, Byte Limit, int OrigPrice, int Min, int Max)
            {
                type = Type;
                cost = Cost;
                time = Time;
                costtype = CostType;
                limit = Limit;
                origprice = OrigPrice;
                deduct = true;

                mincost = Min;
                maxcost = Max;
            }

            public RandomItem(int Type, int Cost, int Time, Byte CostType, Byte Limit, int OrigPrice, int Min, int Max, int Chances)
            {
                type = Type;
                cost = Cost;
                time = Time;
                costtype = CostType;
                limit = Limit;
                origprice = OrigPrice;
                deduct = true;

                mincost = Min;
                maxcost = Max;

                chance = Chances;
                Rare = true;
            }

        }

        public static Dictionary<int, List<ShopItem>> shops = new Dictionary<int, List<ShopItem>>();
        public static RandomItem[] DailyShopRandoms;

        public static ShopItem[] DayShop;
        public static int Time;
        public static byte day;
        public static int[] RandomShop;

        internal static void init()
        {
          //  ByteArray ar;//= new ByteArray(shopstring);

            RandomShop = new int[] { 1 };
            DayShop = new ShopItem[3];

            shops = JsonLib.LoadFile<Dictionary<int, List<ShopItem>>>("system/worldshop.json");

            InitDailyShop();

            Connector.MySqlConnector con = DatabaseInfo.GetConnection();


            //object lastshopcount = con.ExecuteScalar();
            Connector.DataReader rd = con.ExecuteRead("SELECT COUNT(*) FROM DailyShop LIMIT 1;");

            if (!rd.CanRead || !rd.NextRow() || rd.ReadInt()==0)//tem.IO.File.Exists(ShopFile))
            {


                rd.Close();
                // DateTime l = da
                //d.AddHours(Command.LoginController.zone);
                //ar = new ByteArray();

                day = (byte)DateUtil.GetZoneDate().Day;
                Time = (int)DateUtil.GetNextDays(3, 0, 0, 0);

                DayShop = new ShopItem[3];
                DayShop[0] = new ShopItem(3010032, 1000, 0, 3, 99, 1200);//
                DayShop[1] = new ShopItem(3110002, 500, 0, 3, 99, 888);//Spectral Tiger
                DayShop[2] = new ShopItem(9010007, 112, 0, 3, 99, 148);// Superb Gift Pack

                //  CreateRandomDaily();


                SaveNewDayShop();
            }
            else
            {
                rd.Close();
                con.StartCommand("SELECT dayshopid,dayint,dayshopdata FROM DailyShop WHERE dayshopid>=? ORDER BY dayshopid LIMIT 1;");
                con.AddValue((int)DateUtil.GetDateInt());

                rd = con.ExecuteRead();
                bool change = false;

                if (rd.CanRead && rd.NextRow())
                {

                    Time = rd.ReadInt();
                    day = rd.ReadByte();
                    DayShop = JsonLib.Load<ShopItem[]>(rd.ReadString());

                    change = CanChange();
                }
                else
                {
                    change = true;
                }

                if (change)
                {
                    ChangeDailyShop();
                }



            }
      
            BuildDailyShop();

        }

        internal static void InitDailyShop()
        {
            DailyShopRandoms = JsonLib.LoadFile<RandomItem[]>("system/dailyshop.json");
        }

        internal static void BuildDailyShop()
        {

            lock (shops)
            {
                lock (DayShop)
                {
                    if (!shops.ContainsKey(10))
                        shops.Add(10, new List<ShopItem>());

                    if (shops[10].Count != 0)
                        shops[10].Clear();

                    shops[10].AddRange(DayShop);
                }
            }

        }

        internal static void ChangeDailyShop()
        {
            lock (DayShop)
            {
                day = (byte)DateUtil.GetZoneDate().Day;
                Time = (int)DateUtil.GetTodayInt(23, 59, 59);
                CreateRandomDaily();


                SaveNewDayShop();
            }
        }

        internal static void CreateRandomDaily()
        {

            ShuffleList<ShopItem> sh = new ShuffleList<ShopItem>();
            Chance ch = new Chance();

            foreach (RandomItem r in DailyShopRandoms)
            {

                if (r.Rare)
                {
                    if (!ch.MediumChance(r.chance)) continue;
                }

                ShopItem si = r.Clone();

                si.cost = ch.rand.Next(r.mincost, r.maxcost);

                sh.Add(si);
            }

            sh.ShuffleInplace();
            sh.ShuffleShift();
            sh.ShuffleInplace();


            DayShop = new ShopItem[]
                {
                    sh.PopRandom().Clone(),
                    sh.PopRandom().Clone(),
                    sh.PopRandom().Clone()
                };
            sh.Clear();
            sh = null;


        }

        internal static void SaveDayShop()
        {

            Connector.MySqlConnector con = DatabaseInfo.GetConnection();

            con.StartCommand("UPDATE DailyShop SET dayint=?,dayshopdata=? WHERE dayshopid=? ;");


            con.AddValue(day);
            con.AddValue(JsonLib.Save(DayShop));
            con.AddValue(Time);

            if (con.ExecuteNoneQuery() < 1)
            {
                throw new Exception("Could not update daily shop");
            }
        }



        internal static void SaveNewDayShop()
        {

            Connector.MySqlConnector con = DatabaseInfo.GetConnection();

            con.StartCommand("INSERT INTO DailyShop(dayshopid,dayint,dayshopdata) VALUES(?,?,?);");

            con.AddValue(Time);
            con.AddValue(day);

            con.AddValue(JsonLib.Save(DayShop));

            if (con.ExecuteNoneQuery() < 1)
            {
                throw new Exception("Could not save new daily shop");
            }
        }

        internal static void GetShop(ConnectionInfo c, int id)
        {

            if (shops != null && shops.ContainsKey(id))
            {
                c.ot.WriteShort(shops[id].Count);
                for (int i = 0; i < shops[id].Count; i++)
                {
                    c.ot.WriteInt(shops[id][i].type);
                    c.ot.WriteByte(shops[id][i].costtype);
                    c.ot.WriteInt(shops[id][i].cost);
                    c.ot.WriteByte(shops[id][i].limit);
                    c.ot.WriteInt(shops[id][i].time);
                }

            }
            else
            {
                Program.Write("Shop ID> " + id.ToString() + " does not exist");
                c.ot.WriteShort(0);
            }


        }

        internal static void ReloadShop()
        {
            lock (shops)
            {
                shops.Clear();
                init();
            }
        }

        public static int GetCost(int id)
        {

            try
            {
                return gamedata.GameItems.dic[id].sell_price;
            }
            catch (Exception ex)
            {
                log.Save(ex);
            }

            return 10;
        }

        public static bool CanChange()
        {
            return Time < DateUtil.GetDateIntZone() && day != DateUtil.GetZoneDate().Day;
        }

        public static void Change()
        {

        }


    }
}
