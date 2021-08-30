using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C39
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 39001:
					Command.PlayerInfoController.c39001(c);
					break;

				case 39002:
					Command.PlayerInfoController.c39002(c);
					break;

				case 39003:
					Command.PlayerInfoController.c39003(c);
					break;

			}
			
		}

	}
}
