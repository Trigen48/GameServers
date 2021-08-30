using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C60
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 60000:
					Command.GatewayController.c60000(c);
					break;

				case 60001:
					Command.GatewayController.c60001(c);
					break;

			}
			
		}

	}
}
