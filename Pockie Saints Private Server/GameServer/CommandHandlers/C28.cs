using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C28
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 28001:
					Command.CollectController.c28001(c);
					break;

				case 28002:
					Command.CollectController.c28002(c);
					break;

				case 28003:
					Command.CollectController.c28003(c);
					break;

				case 28013:
					Command.CollectController.c28013(c);
					break;

			}
			
		}

	}
}
