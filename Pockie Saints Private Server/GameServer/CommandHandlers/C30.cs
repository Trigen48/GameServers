using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C30
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 30000:
					Command.TaskController.c30000(c);
					break;

				case 30003:
					Command.TaskController.c30003(c);
					break;

				case 30004:
					Command.TaskController.c30004(c);
					break;

				case 30005:
					Command.TaskController.c30005(c);
					break;

				case 30006:
					Command.TaskController.c30006(c);
					break;

				case 30008:
					Command.TaskController.c30008(c);
					break;

				case 30010:
					Command.GuideController.c30010(c);
					break;

				case 30012:
					Command.GuideController.c30012(c);
					break;

				case 30013:
					Command.TaskController.c30013(c);
					break;

				case 30014:
					Command.TaskController.c30014(c);
					break;

				case 30015:
					Command.InsController.c30015(c);
					break;

			}
			
		}

	}
}
