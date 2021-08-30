using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    internal static class StarMapCfg
    {
        public class StarMapItem
        {

            public int[] comabt { get; set; }
            public byte level { get; set; }
            public int gold { get; set; }
            public int trial { get; set; }
            public int timeneeded { get; set; }

        }

        internal static StarMapItem[][][] maps;

        internal static void Load()
        {
            maps = JsonLib.LoadFile<StarMapItem[][][]>("system/starmap.json");
        }


        internal static int GetFastCost(int t)
        {
            return (int)Math.Ceiling(1.25d * ((double)t / 300d));
        }
    }
}
