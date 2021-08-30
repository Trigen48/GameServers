using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public class PrizeItem
    {
        public int itemType { get; set; }
        public byte type { get; set; }
        public byte count { get; set; }

        public PrizeItem()
        {
            itemType = 0;
            type = 0;
            count = 0;
        }
        public PrizeItem(int itemType,byte type,byte count)
        {
            this.itemType = itemType;
            this.type = type;
            this.count = count;
        }
    }
        
    public class PrizeRole
    {

        public int roleId { get; set; }
        public string name { get; set; }
        public byte faction { get; set; }

        public List<PrizeItem> items { get; set; }

        public PrizeRole(int roleId,string name,byte faction)
        {
            this.roleId = roleId;
            this.name = name;
            this.faction = faction;
            items = new List<PrizeItem>();
        }

        public PrizeRole()
        {
        }
    }

    

    public static class LuckyWheelData
    {
        public static int[] items;
        static object ids;

        /*
        public static int[] prizes = new int[12];// { 3010038, 9020010, 1040011, 1215003, 1040004, 6040164, 6040155, 3320002, 9010091, 3012008, 6040153, 2230004 };
        public static byte[] quant = new byte[12];// { 1, 1, 1, 1, 1, 1, 2, 5, 1, 5, 4, 5 };
        */

        public struct LuckyWheelItems
        {
            public int index;
            public int itemid;
            public byte count;
            public int chance;

            public LuckyWheelItems(int index,int itemid,byte count,int chance)
            {
                this.index = index;
                this.itemid=itemid;
                this.count=count;
                this.chance = chance;
            }
        }

        public static List<LuckyWheelItems> litem;

        public static void Init()
        {
            litem = new List<LuckyWheelItems>();
            litem = JsonLib.LoadFile<List<LuckyWheelItems>>("system/luckywheel.json");// new List<LuckyWheelItems>();

            litem.Sort((x, y) => x.index.CompareTo(y.index));


            ids = new ShuffleList<int>();

           // config.ConfigLoader loader = new config.ConfigLoader("config/luckWheel.cfg");

            bool LoadOld = false;

            if (litem != null && litem.Count == 12)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (litem[i].index != i)
                    {
                        LoadOld = true;
                        break;
                    }
                }
            }
            else
            {
                if (litem != null)
                {
                    litem.Clear();
                }
                else
                {
                    litem = new List<LuckyWheelItems>();
                }
            }


            if (LoadOld)
            {
                litem.Add(new LuckyWheelItems(0, 3010038, 1, 71)); //pirate captin
                litem.Add(new LuckyWheelItems(1, 9020010, 1, 5)); //Lv.2 Gem Bag
                litem.Add(new LuckyWheelItems(2, 1040011, 1, 1)); //Virgo
                litem.Add(new LuckyWheelItems(3, 1215003, 1, 4)); //Orange Refining Stone
                litem.Add(new LuckyWheelItems(4, 1040004, 1, 71)); //Aries
                litem.Add(new LuckyWheelItems(5, 6040164, 1, 1)); //Orange Costume Piece
                litem.Add(new LuckyWheelItems(6, 6040155, 2, 3)); //Lucky Wheel
                litem.Add(new LuckyWheelItems(7, 3320002, 5, 15)); //Fusion Potion B
                litem.Add(new LuckyWheelItems(8, 9010091, 1, 52)); //Enhance Pack B
                litem.Add(new LuckyWheelItems(9, 3012008, 5, 13)); //Adv. Upgrade Core
                litem.Add(new LuckyWheelItems(10, 6040153, 4, 76)); //Pet Skill Refresh Scroll
                litem.Add(new LuckyWheelItems(11, 2230004, 5, 14)); //Large Gold Card
            }


            //CreatePrizePool();

            for (byte x = 0; x < 12; x++)
            {
                FillItems(litem[x].itemid, litem[x].chance);
            }

            ((ShuffleList<int>)ids).ShuffleShift();
            ((ShuffleList<int>)ids).ShuffleInplace();
            ((ShuffleList<int>)ids).ShuffleShift();
            ((ShuffleList<int>)ids).ShuffleInplace();
            //((ShuffleList<int>)ids).ShuffleShift();

            items = ((ShuffleList<int>)ids).ToArray();
            ids = null;

            ///   LuckItems = new int[] { 3010038, 1040011, 1040004, 6040164, 9010091 };
        }

        public static byte PrizeToClock(int id)
        {

            for (byte i = 0; i < 12; i++)
            {
                if (litem[i].itemid == id) return i;
            }

            return 0;
        }

        public static void FillItems(int id, int quantity)
        {
            if (quantity < 1) return;

            for (int i = 0; i < quantity; i++)
            {
                ((List<int>)ids).Add(id);
            }
        }
    }


}
