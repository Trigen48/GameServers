using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class BattlefieldController
	{

		internal static void c26001(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26001");

            int d=(int)DateUtil.GetDateIntZone() ;

            byte a_state = 1;
            byte b_num = 0;
            int c_sign_time = Gameplay.BattleFieldConfig.RegTime - DateUtil.ZoneDeduct; 
            int d_start_time = Gameplay.BattleFieldConfig.BattleTime - DateUtil.ZoneDeduct;
            int e_end_time = Gameplay.BattleFieldConfig.BattleEndTime - DateUtil.ZoneDeduct;


            byte f_lv = Gameplay.BattleFieldConfig.GetRangeLevel(c.Player.role.level);

            byte g_my_state =0;
            byte h_line = 0;

            int regt = Gameplay.BattleFieldConfig.RegTime;



            if (d > Gameplay.BattleFieldConfig.RegTime && d < Gameplay.BattleFieldConfig.BattleEndTime)
            {

                if (d < Gameplay.BattleFieldConfig.BattleTime)
                {
                    a_state = 2;

                    if (Gameplay.BattleFieldConfig.GetStatus(c))
                    {
                        g_my_state = 1;
                    }
                    else
                    {
                        g_my_state = 0;
                    }

                }
                else
                {
                    a_state = 6;
                    if (Gameplay.BattleFieldConfig.GetStatus(c))
                    {
                        g_my_state = 1;
                    }
                }
            }

          /*  if (regt < d && regt + 3300 > d && Gameplay.BattleFieldConfig.GetStatus(c.rlid))
            {
                a_state = 2;
                c_sign_time = regt;
                d_start_time = (int)DateUtil.GetTodayInt(13, 0, 0);
                int b = (int)DateUtil.GetTodayInt(13, 0, 0) - (int)DateUtil.GetDateInt();
                e_end_time = b;

            }*/



           c.ot.WriteByte(a_state);
           c.ot.WriteByte(b_num);
           c.ot.WriteInt(c_sign_time);
           c.ot.WriteInt(d_start_time);
           c.ot.WriteInt(e_end_time);
           c.ot.WriteByte(f_lv);
           c.ot.WriteByte(g_my_state);
           c.ot.WriteByte(h_line);
           c.ot.PackArray(26001);


           if (a_state == 2 && g_my_state == 0)
           {
               c.ot.WriteShort(5);
               c.ot.WriteShort(26012);
               c.ot.WriteByte(1);

           }

          /* Console.Write(DateUtil.GetDateFromInt(Gameplay.BattleFieldConfig.RegTime));
           Console.WriteLine("  {0}", Gameplay.BattleFieldConfig.RegTime);
           Console.Write(DateUtil.GetDateFromInt(Gameplay.BattleFieldConfig.BattleTime));
           Console.WriteLine("  {0}", Gameplay.BattleFieldConfig.BattleTime);
           Console.Write(DateUtil.GetDateFromInt(Gameplay.BattleFieldConfig.BattleEndTime));
           Console.WriteLine("  {0}", Gameplay.BattleFieldConfig.BattleEndTime);
           Console.Write(DateUtil.GetDateFromInt(d));
           Console.WriteLine("  {0}", d);
           Console.WriteLine();*/
			
		}

		internal static void c26002(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26002");
			
			
		}

		internal static void c26003(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26003");
			
			
		}

		internal static void c26004(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26004");
			
			
		}

		internal static void c26011(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26011");
			
			
		}

		internal static void c26012(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26012");
			
			
		}

		internal static void c26013(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26013");
			
			
		}

		internal static void c26014(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26014");
			
			
		}

		internal static void c26015(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26015");
			
			
		}

		internal static void c26016(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26016");
			
			
		}

		internal static void c26017(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26017");
			
			
		}

		internal static void c26018(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26018");
			
			
		}

		internal static void c26019(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26019");
			
			
		}

		internal static void c26020(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26020");
			
			
		}

		internal static void c26021(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26021");
			
			
		}

		internal static void c26101(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BattlefieldController 26101");
			
			
		}

	}
}
