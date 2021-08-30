using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer.Gameplay
{

    static class BattleFieldConfig
    {
       // struct

        internal static Dictionary<int,List<int>> RegBattleField;
       // internal static Dictionary<int, int> PlayersTeam;
        //internal static 


        internal static bool RegOpen=false;
        internal static int BattleTime = 0;
        internal static int RegTime = 0;
        internal static int BattleEndTime = 0;

        internal static object Regul = new object();
        internal static int NextReg=0;
      //  internal static int NextRegTime = 0;

        public static byte[] BattleFieldRegTime = new byte[] { 07, 00, 00 };
        public static byte[] BattleFieldTime = new byte[] { 08, 00, 00 };
        public static int Duration = 1800;

        static BattleFieldConfig()
        {
            RegBattleField = new Dictionary<int, List<int>>();
            RegOpen = false;
            //ResetBattleField();
            //NextRegTime = (int)DateUtil.GetTommorowInt(13, 0, 0);
        }

        internal static void ResetBattleField()
        {
            RegTime = (int)DateUtil.GetTodayInt(BattleFieldRegTime[0], BattleFieldRegTime[1], BattleFieldRegTime[2]);
            BattleTime = (int)DateUtil.GetTodayInt(BattleFieldTime[0], BattleFieldTime[1], BattleFieldTime[2]);
            BattleEndTime = BattleTime + Duration;

            int zn = (int)DateUtil.GetDateIntZone();

            if (RegTime < zn && BattleTime < zn && BattleEndTime < zn)
            {
                RegTime = (int)DateUtil.GetTommorowInt(BattleFieldRegTime[0], BattleFieldRegTime[1], BattleFieldRegTime[2]);
                BattleTime = (int)DateUtil.GetTommorowInt(BattleFieldTime[0], BattleFieldTime[1], BattleFieldTime[2]);
                BattleEndTime = BattleTime + Duration;

            }

          /*  Console.Write(DateUtil.GetDateFromInt(RegTime));
            Console.WriteLine("  {0}", RegTime);
            Console.Write(DateUtil.GetDateFromInt(BattleTime));
            Console.WriteLine("  {0}", BattleTime);
            Console.Write(DateUtil.GetDateFromInt(BattleEndTime));
            Console.WriteLine("  {0}", BattleEndTime);
            Console.Write(DateUtil.GetDateFromInt(zn));
            Console.WriteLine("  {0}", zn);
            Console.WriteLine();*/
        }

        internal static void BattleWorker()
        {
                
            ResetBattleField();

            while (true)
            {

                int t = (int)DateUtil.GetDateIntZone();
                int w = 0;

                w = (RegTime-t);

                if (w > 0)
                {
                    System.Threading.Thread.Sleep(w * 1000);
                }

                CreateReg(); 
                RegOpen = true;
                t = (int)DateUtil.GetDateIntZone();

                if (t >= RegTime && t <= BattleTime + (55*60))
                {
                    ByteArray ar = new ByteArray();
                    ar.WriteShort(5);
                    ar.WriteShort(26012);
                    ar.WriteByte(1);
                    
                    World.Banner.BroadCastEvent(ar.GetByteArray());
                    ar.Close();
                }
                else if (t >= BattleTime && t <= BattleEndTime)
                {
                    BroadcastBattle();
                }

                t = (int)DateUtil.GetDateIntZone();
                w = ((RegTime + (55 * 60)) - t);

                if (w > 0)
                    System.Threading.Thread.Sleep(w * 1000);

                BroadcastBattle();
                RegOpen = false;


                // Prepare battle scene
                for (int x = 0; x < 3; x++)
                {
                    World.BattleField bt = new World.BattleField();

                    bt.RemoveTime = BattleEndTime;
                    bt.CanEnter = false;

                    World.World.AddScene(990+x, bt);
                    bt.Start();


                }



                t = (int)DateUtil.GetDateIntZone();
                w = ((RegTime + (58 * 60)) - t);

                if (w > 0)
                    System.Threading.Thread.Sleep(w * 1000);


                t = (int)DateUtil.GetDateIntZone();
                w = ((BattleEndTime + (5 * 60)) - t);

                if (w > 0)
                    System.Threading.Thread.Sleep(w * 1000);

                // remove battle scene
                for (int x = 0; x < 3; x++)
                {
                    World.World.RemoveScene(990 + x);
                }

                ResetBattleField();

            }
        }

        public static void BroadcastBattle()
        {
            ByteArray ar = new ByteArray();
            ar.WriteShort(5);
            ar.WriteShort(26012);
            ar.WriteByte(2);

            World.Banner.BroadCastEvent(ar.GetByteArray());
            ar.Close();
        }

        public static void CreateReg()
        {
            if (RegBattleField != null)
            {
                RegBattleField.Clear();
                //PlayersTeam.Clear();
            }
            else
            {
                RegBattleField = new Dictionary<int, List<int>>();
               // PlayersTeam = new Dictionary<int, int>();
            }

            
            RegBattleField.Add(0, new List<int>());
            RegBattleField.Add(1, new List<int>());
            RegBattleField.Add(2, new List<int>());
            RegBattleField.Add(3, new List<int>());
        }

        public static void Register(int id,int level)
        {
           


        }

        public static int GetRange(int level)
        {

            if (level < 30) return 0;

            if (level < 40) return 1;

            if (level < 50) return 2;

            return 3;
        }

        public static byte GetRangeLevel(int level)
        {

            if (level < 30) return 27;

            if (level < 40) return 39;

            if (level < 50) return 49;

            return 50;
        }


        public static bool GetStatus(ConnectionInfo c)
        {
            double vb=DateUtil.GetDateIntZone();

            if ((vb < RegTime && vb > BattleEndTime))
                return false;


            int level= GetRange(c.Player.role.level);

            lock (RegBattleField[level])
            {
                return RegBattleField[level].Contains(c.rlid);
            }
            
  
        }

    }
}
