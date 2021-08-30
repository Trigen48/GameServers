using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C42
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 42000:
					Command.GamingController.c42000(c);
					break;

				case 42001:
					Command.GamingController.c42001(c);
					break;

			}
			
		}

	}
}
