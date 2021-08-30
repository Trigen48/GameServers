using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;
namespace GameServer.Events
{
    
    internal static class Happy
    {


        internal class HappyItem
        {
            public int Item{get;set;}
            public byte Count{get;set;}

            public HappyItem()
            {
            }

            public HappyItem(int id,byte count)
            {
                Item=id;
                Count=count;
            }

        }

        internal class HappyItems
        {
            public List<HappyItem> Items { get; set; }

            public HappyItems()
            {
                Items = new List<HappyItem>();
            }

        }

        internal static List<HappyItem> MainList;
        internal static List<HappyItems> SecondList;


        [ProtoContract]
        internal class HappyEventItem
        {
            [ProtoMember(1)]
            public int Date { get; set; }

            [ProtoMember(2)]
            public byte DayID { get; set; }

            [ProtoMember(3)]
            public int UserID { get; set; }
            [ProtoMember(4)]
            public string UserName { get; set; }


            public HappyEventItem()
            {
                UserName = "";
            }


        }

        [ProtoContract]
        internal class HappyEvent
        {
            [ProtoMember(1)]
            public byte dayCount { get; set; }

            [ProtoMember(2)]
            public List<HappyEventItem> HappyEvents { get; set; }

            public HappyEvent()
            {
                HappyEvents = new List<HappyEventItem>();
            }

            public void Create()
            {
                dayCount = 1;
                for (byte x = 0; x < 8; x++)
                {
                   
                    HappyEvents.Add(new HappyEventItem());
                    HappyEvents[x].DayID = x;

                    if(x!=0)
                    HappyEvents[x].Date = (int)DateUtil.GetNextDaysZone(x-1, Rankings.Hour, Rankings.Min, Rankings.Sec);

                }

            }

        }

       // internal static string player="";
        internal static string HappyFile = "";
        internal static HappyEvent happy;

        public static void CreateMainList()
        {

            MainList = new List<HappyItem>();

            MainList.Add(new HappyItem(0, 0));
            MainList.Add(new HappyItem(1010039, 1));
            MainList.Add(new HappyItem(1032033, 1));
            MainList.Add(new HappyItem(1020063, 1));
            MainList.Add(new HappyItem(1025063, 1));
            MainList.Add(new HappyItem(1022063, 1));
            MainList.Add(new HappyItem(1021063, 1));
            MainList.Add(new HappyItem(1024063, 1));

            SecondList = new List<HappyItems>();

            for (int x = 0; x < 8; x++)
            {
                SecondList.Add(new HappyItems());
            }

            //[],[],[]
            SecondList[1].Items.Add(new HappyItem(9020014, 1));
            SecondList[1].Items.Add(new HappyItem(8030002, 2));
            SecondList[1].Items.Add(new HappyItem(3012006, 20));


            //[],[],[]
            SecondList[2].Items.Add(new HappyItem(2231012, 20));
            SecondList[2].Items.Add(new HappyItem(9020008, 20));
            SecondList[2].Items.Add(new HappyItem(3012006, 20));


            //[],[],[]
            SecondList[3].Items.Add(new HappyItem(3270001, 1));
            SecondList[3].Items.Add(new HappyItem(3012007, 10));
            SecondList[3].Items.Add(new HappyItem(6040078, 30));


            //[],[],[]
            SecondList[4].Items.Add(new HappyItem(1117003, 4));
            SecondList[4].Items.Add(new HappyItem(6040001, 4));
            SecondList[4].Items.Add(new HappyItem(1211001, 8));


            //[],[],[]
            SecondList[5].Items.Add(new HappyItem(1210006, 1));
            SecondList[5].Items.Add(new HappyItem(9020011, 5));
            SecondList[5].Items.Add(new HappyItem(1110002, 10));


            //[],[],[]
            SecondList[6].Items.Add(new HappyItem(2231009, 8));
            SecondList[6].Items.Add(new HappyItem(9020008, 50));
            SecondList[6].Items.Add(new HappyItem(3012007, 40));


            //[],[],[]
            SecondList[7].Items.Add(new HappyItem(1117004, 3));
            SecondList[7].Items.Add(new HappyItem(3320002, 40));
            SecondList[7].Items.Add(new HappyItem(1214002, 10));

        }

        public static void Init()
        {
            HappyFile = Game.PlayerDir + "happy.evt";

            CreateMainList();
            happy = new HappyEvent();

            if (System.IO.File.Exists(HappyFile))
            {
                ByteC.LoadProto(HappyFile, ref happy);
            }
            else
            {
                happy.Create();
                Save();
            }

        }

        public static void Create()
        {
        }

        public static void Save()
        {
            lock (happy)
            {
                ByteC.SaveProto(HappyFile, happy);
            }
        }

        public static byte Condition(ConnectionInfo c, byte day)
        {
            if (happy.dayCount > 8) return 0;

            byte claimed=0;
            if (c.Player.happy.Claimed[day] == 0)
            {
                claimed = 1;
            }
            else
            {
                return 0;
            }

            if (day > happy.dayCount)
            {
                return 0;
            }
            else
            {

                switch (day)
                {
                    case 1:
                        if (c.Player.role.level < 30)
                        {
                            return 0;
                        }
                        break;
                    case 2:
                        claimed = 0;
                        break;
                    case 3:
                        if (c.Player.pet.GetPet().level < 30)
                        {
                            return 0;
                        }
                        break;
                    case 4:
                        claimed = 0;
                        break;
                    case 5:
                        claimed = 0;
                        break;
                    case 6:
                        claimed = 0;
                        break;
                    case 7:
                        if (c.Player.combat.CombatPower() < 10000)
                        {
                            return 0;
                        }
                        break;
                }

            }


            return claimed;
        }

        public static byte Condition2(ConnectionInfo c, byte day)
        {

            if (happy.dayCount > 8) return 0;



            if (happy.HappyEvents[day].UserID == c.rlid && c.Player.happy.MainClaimed[day] == 0)
                return 1;

            return 0;
        }

        public static void UpdateHappy()
        {

            lock (happy)
            {

                if (happy.dayCount < 9)
                    //happy.dayCount++;

                    switch (happy.dayCount)
                    {
                        case 1:

                           /* if (Rankings.ranks.Level.Count != 0)
                            {
                                happy.HappyEvents[1].UserID = Rankings.ranks.Level[0].RoleID;
                                happy.HappyEvents[1].UserName = Rankings.TempRank[happy.HappyEvents[1].UserID].name;
                            }*/

                            break;


                    }

                Save();


            }

        }
    }
}
