using System;

using System.Collections;
using GameServer.World;

namespace GameServer.Command
{

	internal static class SpaController
	{

        internal static void c38000(ConnectionInfo c)
        {

            int time = Beach.GetNextTime()-(DateUtil.ZoneDeduct);
            c.ot.WriteInt(time);
            c.ot.WriteInt(time + (Beach.Duration));
            c.ot.WriteShort((c.Player.vip.vip_level != 0 ? 15 : 10));
            c.ot.PackArray(38000);

        }

		internal static void c38001(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SpaController 38001");
			
			
		}

		internal static void c38002(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SpaController 38002");
			
			
		}

		internal static void c38003(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SpaController 38003");
			
			
		}

	}
}
