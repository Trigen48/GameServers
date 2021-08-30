using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class AnnoumcementController
	{

		internal static void c50013(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"AnnoumcementController 50013");

           /* c.ot.WriteByte(1);
            c.ot.WriteShort(1);

            //

            c.ot.WriteString("Pet Event");//a_name);
            c.ot.WriteString("http://127.0.0.1/pockie/getpet.php");//b_url);
            c.ot.WriteString("Get your pet to level 30 and claim a new pet");//c_desc);
            c.ot.WriteInt(DateUtil.GetDateIntZone() );//d_startTime);
            c.ot.WriteInt(DateUtil.GetDaysIntZone(2));//e_endTime);
            c.ot.WriteByte(1);//f_layoutType);
            c.ot.WriteByte(0);//g_type);
            c.ot.WriteString("[{\"id\":\"1211006\",\"type\":12,\"subtype\":11,\"name\":\"Lv.9 Luck Scroll\",\"price\":1,\"price_type\":3,\"color\":3,\"num\":2},{\"id\":\"1117006\",\"type\":11,\"subtype\":17,\"name\":\"Lv.6 Refine Gem\",\"price\":1,\"price_type\":3,\"color\":2,\"num\":8},{\"id\":\"1040007\",\"type\":10,\"subtype\":40,\"name\":\"Leo\",\"price\":888,\"price_type\":3,\"color\":3,\"num\":1}]");//h_conent);
            c.ot.WriteInt(DateUtil.GetDateIntZone()+120);//i_creatTime);
            //

            c.ot.PackArray(50013);*/

            c.ot.WriteByte(1);
            c.ot.WriteShort(0);
            c.ot.PackArray(50013);

		}

		internal static void c50014(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"AnnoumcementController 50014");


            c.ot.WriteByte(1);

            lock (Events.Events.GameEvents)
            {
                c.ot.WriteShort(Events.Events.GameEvents.Count);
                foreach (Events.Events.EventItem evv in Events.Events.GameEvents)
                {
                    Events.Events.EventItem ev = Events.Events.GetEvent(c, evv);
                   c.ot.WriteString(ev.a_name);
                   c.ot.WriteInt(ev.b_startTime);
                   c.ot.WriteInt(ev.c_endTime);
                   c.ot.WriteString(ev.d_desc);
                   c.ot.WriteByte(ev.e_type);
                   c.ot.WriteInt(ev.fa_value);
                   c.ot.WriteInt(ev.fb_value);
                   c.ot.WriteInt(ev.fc_value);
                   c.ot.WriteString(ev.g_url);
                   c.ot.WriteByte(ev.h_layoutType);
                   c.ot.WriteString(ev.i_conent);
                   c.ot.WriteInt(ev.j_id);
                   c.ot.WriteInt(ev.k_creatTime);
                   c.ot.WriteByte(ev.l_limitTimes);
                }
            }

    
            c.ot.PackArray(50014);
		}

		internal static void c50015(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AnnoumcementController 50015");
			
			
		}

		internal static void c50016(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AnnoumcementController 50016");
			
			
		}

		internal static void c50017(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AnnoumcementController 50017");
			
			
		}

		internal static void c50018(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AnnoumcementController 50018");
			
			
		}

		internal static void c50019(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AnnoumcementController 50019");
			
			
		}

	}
}
