using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public static class MountHelper
    {


        public static int[] starArray;/*= new int[]{810, 2376, 3888, 5616, 7560, 9720, 12096, 14688, 17496, 20520, 23544, 
                                                  26568, 29592, 32616, 35640, 38664, 41688, 44712, 
                                                  47736, 50760, 53784, 56808, 59832, 62856, 65880, 68904, 
                                                  71928, 74952, 77976, 81000};*/
        public const int MAXLV = 30;

        public static int[] mountList;/*= new int[]{3110001, 3110002, 3110012, 3110022, 3110032, 3110042, 
                                             3110052, 3110062, 3110072, 3110082, 3110092, 3110102, 3110112, 
                                             3110122, 3110123, 3110132, 3110124};*/

        public static int[] expArray;/*= new int[]{0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 
                                                 100, 110, 120, 130, 140, 150, 160, 170, 180, 
                                                 190, 200, 400, 600, 800, 1000, 1200, 1400, 1600, 
                                                1800, 2000, 2200, 3000, 4000, 5000, 6000, 7000, 
                                                8000, 9000, 10000, 11000, 12000, 13000, 14000, 
                                                15000, 16000, 17000, 18000, 19000, 20000, 21000, 
                                                22000, 23000, 54000, 56000, 58000, 60000, 62000, 
                                                64000, 66000, 68000, 70000, 72000, 111000, 114000, 
                                                117000, 120000, 123000, 126000, 129000, 132000, 
                                                135000, 138000, 141000, 144000, 147000, 150000, 153000, 
                                                156000, 159000, 162000, 165000, 168000, 171000, 174000, 
                                                177000, 180000, 183000, 186000, 189000, 192000, 195000, 
                                                198000, 201000, 204000, 207000, 210000, 213000, 216000, 
                                                219000, 222000, 225000};*/
        public static Dictionary<int, int[]> mount_stats;

        public static void Init()
        {
            mount_stats = JsonLib.LoadFile<Dictionary<int, int[]>>("system/mount_stats.json");
            expArray = JsonLib.LoadFile<int[]>("system/mount_exp.json");
            mountList = JsonLib.LoadFile<int[]>("system/mounts.json");
            starArray = JsonLib.LoadFile<int[]>("system/mount_star_exp.json");


            /*mount_stats = new Dictionary<int, int[]>();
            mount_stats.Add(3110001, new int[] { 90 - 40, 0, 0, 500, 0, 0, 0, 0 });
            mount_stats.Add(3110002, new int[] { 250, 500, 0, 1000, 0, 0, 0, 0 });
            mount_stats.Add(3110012, new int[] { 250, 0, 1000, 1000, 0, 0, 0, 0 });
            mount_stats.Add(3110022, new int[] { 200, 0, 0, 1000, 0, 500, 0, 0 });
            mount_stats.Add(3110032, new int[] { 150, 0, 0, 500, 0, 0, 500, 0 });
            mount_stats.Add(3110042, new int[] { 150, 0, 0, 2000, 0, 0, 0, 0 });
            mount_stats.Add(3110052, new int[] { 250, 0, 0, 1500, 500, 0, 0, 0 });
            mount_stats.Add(3110062, new int[] { 250, 500, 0, 0, 0, 0, 0, 500 });
            mount_stats.Add(3110072, new int[] { 250, 0, 1000, 2000, 0, 0, 0, 0 });
            mount_stats.Add(3110082, new int[] { 250, 888, 0, 0, 0, 0, 0, 0 });
            mount_stats.Add(3110092, new int[] { 250, 500, 0, 0, 0, 0, 0, 500 });
            mount_stats.Add(3110102, new int[] { 250, 1000, 1000, 0, 0, 0, 0, 0 });
            mount_stats.Add(3110112, new int[] { 250, 1000, 0, 0, 0, 0, 0, 1000 });
            mount_stats.Add(3110122, new int[] { 350, 1000, 0, 0, 0, 0, 500, 0 });
            mount_stats.Add(3110123, new int[] { 250, 0, 1000, 1000, 0, 0, 0, 0 });
            mount_stats.Add(3110132, new int[] { 250, 800, 0, 0, 0, 300, 0, 0 });
            mount_stats.Add(3110124, new int[] { 250, 500, 1000, 0, 0, 0, 0, 0 });
            mount_stats.Add(3110133, new int[] { 255, 0, 1000, 1000, 0, 0, 0, 0 });
            mount_stats.Add(3110134, new int[] { 255, 1000, 1000, 0, 0, 0, 0, 0 });*/


            /*JsonLib.SaveFile("system/mount_stats.json", mount_stats);
            JsonLib.SaveFile("system/mount_exp.json", expArray);
            JsonLib.SaveFile("system/mounts.json", mountList);
            JsonLib.SaveFile("system/mount_star_exp.json", starArray);*/


            /**/
        }
    }

}
