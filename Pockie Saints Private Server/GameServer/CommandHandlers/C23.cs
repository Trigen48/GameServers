using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C23
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 23001:
					Command.StarTargetController.c23001(c);
					break;

				case 23002:
					Command.StarTargetController.c23002(c);
					break;

				case 23003:
					Command.StarTargetController.c23003(c);
					break;

				case 23010:
					Command.StarTargetController.c23010(c);
					break;

			}
			
		}

	}
}
