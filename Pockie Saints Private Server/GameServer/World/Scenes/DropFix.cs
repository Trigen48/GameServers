using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer.World
{
    public static class DropFix
    {

        public static int[][]FixDrop(int[][] items, int level)
        {
            int[][] d = new int[items.Length][];
            for (int x = 0; x < items.Length; x++)
            {
                d[x] = new int[3];


                if (items[x][0] == 2286001)
                {

                    if (level > 79)
                    {
                        d[x][0] = 2286006;
                    }
                    else if (level < 30)
                    {
                        d[x][0] = 2286001;
                    }
                    else
                    {
                        d[x][0] = 2286001 + ((level / 10) - 3);
                    }

                }
                else
                {
                    d[x][0] = items[x][0];
                }
                d[x][1] = items[x][1];
                d[x][2] = items[x][2];
            }
            return d;
        }
    }
}
