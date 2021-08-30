using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C38
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 38000:
					Command.SpaController.c38000(c);
					break;

				case 38001:
					Command.SpaController.c38001(c);
					break;

				case 38002:
					Command.SpaController.c38002(c);
					break;

				case 38003:
					Command.SpaController.c38003(c);
					break;

			}
			
		}

	}
}
