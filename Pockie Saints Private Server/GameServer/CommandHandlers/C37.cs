using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C37
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 37000:
					Command.ChangeCampController.c37000(c);
					break;

				case 37001:
					Command.ChangeCampController.c37001(c);
					break;

			}
			
		}

	}
}
