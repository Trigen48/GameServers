using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public struct ExploreItem
    {
        public int type;
        public byte bind;
        public byte count;
        public ExploreItem(int Type, byte Count)
        {
            type = Type;
            count = Count;
            bind = 1;

        }
        public ExploreItem(int Type, byte Count,byte Bind)
        {
            type = Type;
            count = Count;
            bind = Bind;

        }

    }
    static class ExploreWiz
    {
        internal static int[] ExploreScroll;
        internal static ExploreItem[][] Items;
        internal static byte[][] stats;
        internal static ShuffleList<byte> Gems;

        const byte gem1 = 16, gem2 = 4, stuff =80;
        // 1 lvl 1 gem
        // 2 
        // 3
        // 4
        // 5 Items
        // 6 
        static ExploreWiz()
        {

            ByteArray ar = new ByteArray("shop/Explore.sh");

            ExploreScroll = new int[] { 6040009, 6040010, 6040011 };

            Gems = new ShuffleList<byte>();
            Gems.AddRange(new byte[] {0,0,0,1,1,1,1,2,3,4,5,6,7 });

            Items = new ExploreItem[3][];
            stats = new byte[3][];
            byte ch;
            int code;
            int len = ar.ReadShort();
            ShuffleList<byte> rule = new ShuffleList<byte>();
            for (int x = 0; x < len; x++)
            {
                code = ar.ReadInt();
                
                int len2 = ar.ReadShort();
                Items[code] = new ExploreItem[len2];

                for (int i = 0; i < len2; i++)
                {
                    ExploreItem exp = new ExploreItem();
                    exp.type = ar.ReadInt();
                    exp.bind = ar.ReadByte();
                    exp.count = ar.ReadByte();
                    ch = ar.ReadByte();

                    Items[code][i] = exp;
                    for (byte c = 0; c < ch; c++)
                    {
                        rule.Add((byte)i, true);
                    }
                    rule.ShuffleInplace();
                }
                rule.ShuffleShift();
                rule.ShuffleInplace();
                stats[code] = rule.ToArray();
                rule.Clear();
            }
            rule = null;
        }
        public static int GetGem(byte type)
        {
            byte rand= Gems.SelectRandom();
            switch(type)
            {
                case 1:
                    return 1114003 + rand;
                case 2:
                    return 1114009 + rand;
                case 3:
                    return 1114017 + rand;
                case 4:
                    return 1114025 + rand;
            }
            return 0;
        }
        public static int GetCost(byte id,byte num)
        {
            //int cost = 0;
            if(id==1)
            {
                switch(num)
                {
                    case 1:
                        return 12;
                    case 10:
                        return 110;
                    case 50:
                        return 500;
                }
            }
            else if(id==2)
            {
                switch (num)
                {
                    case 1:
                        return 24;
                    case 10:
                        return 220;
                    case 50:
                        return 1000;
                }
            }
            else if(id==3)
            {
                switch (num)
                {
                    case 1:
                        return 36;
                    case 10:
                        return 330;
                    case 50:
                        return 1500;
                }
            }
            return 0;
        }

        public static void Pop(List<ExploreItem> ex, ConnectionInfo c, byte count, int id)
        {

            c.Player.chance.extraProb.Clear();

            switch (id)
            {
                case 0:
                    CreateExplore(c,1,2);

                    break;
                case 1:
                    CreateExplore(c, 2, 3);
                    break;
                case 2:
                    CreateExplore(c, 3, 4);
                    break;
            }
            Explore(ex, c, count, id);
            c.Player.chance.extraProb.Clear();
        }

        public static void CreateExplore(ConnectionInfo c, byte gem11, byte gem22)
        {

            byte i = 0;

            for (i = 0; i < gem1; i++)
            {
                c.Player.chance.extraProb.Add(gem11);
            }

            for (i = 0; i < gem2; i++)
            {
                c.Player.chance.extraProb.Add(gem22, true);
            }

            for (i = 0; i < stuff; i++)
            {
                c.Player.chance.extraProb.Add(5, true);
            }
            c.Player.chance.extraProb.ShuffleInplace();
            c.Player.chance.extraProb.ShuffleShift();
            c.Player.chance.extraProb.ShuffleInplace();
        }

        public static void Explore(List<ExploreItem> ex, ConnectionInfo c, byte count, int id)
        {
            double perc = ((double)c.Player.explore.chances[id] * 0.6)/100.0;
            ShuffleList<byte> itt = new ShuffleList<byte>();
            itt.AddRange(stats[id]);
            itt.ShuffleInplace();

            lock (ex)
            {
                for (byte i = 0; i < count; i++)
                {
                    if (c.Player.explore.Gears[id].Count != 0 && c.Player.chance.HardChance(perc))
                    {
                        c.Player.explore.chances[id] = 0;
                        ex.Add(new ExploreItem(c.Player.explore.Gears[id].PopRandom(), 1));

                    }
                    else
                    {

                        byte ext = c.Player.chance.extraProb.SelectRandom();
                        if (ext < 5)
                        {
                            ex.Add(new ExploreItem(GetGem(ext), 1));
                        }
                        else
                        {
                            ex.Add(Items[id][itt.SelectRandom()]);
                        }
                        if (c.Player.explore.Gears[id].Count != 0)
                        {
                            c.Player.explore.chances[id] += 1;
                            perc = ((double)c.Player.explore.chances[id] * 0.6) / 100.0;
                        }
                    }

                }
            }

        }


    }
}
