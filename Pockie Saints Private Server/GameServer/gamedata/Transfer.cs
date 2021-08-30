using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public static class Transfer
    {

        public static int[][] TransferCost;

        public static void init()
        {
            TransferCost = JsonLib.LoadFile<int[][]>("system/TransferCost.json");
        }

        public static int GetScrollCount(byte str, byte color)
        {
            if (str > 15) return 9999;
            return TransferCost[str][0] * (1 + (int)color);
        }

    }
}
