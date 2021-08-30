using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class GatewayController
	{

		internal static void c60000(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GatewayController 60000");
			
			
		}

		internal static void c60001(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GatewayController 60001");
			
			
		}

	}
}
