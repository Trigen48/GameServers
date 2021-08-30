using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C24
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 24000:
					Command.TeamController.c24000(c);
					break;

				case 24001:
					Command.TeamController.c24001(c);
					break;

				case 24002:
					Command.TeamController.c24002(c);
					break;

				case 24003:
					Command.TeamController.c24003(c);
					break;

				case 24004:
					Command.TeamController.c24004(c);
					break;

				case 24005:
					Command.TeamController.c24005(c);
					break;

				case 24006:
					Command.TeamController.c24006(c);
					break;

				case 24007:
					Command.TeamController.c24007(c);
					break;

				case 24008:
					Command.TeamController.c24008(c);
					break;

				case 24009:
					Command.TeamController.c24009(c);
					break;

				case 24010:
					Command.TeamController.c24010(c);
					break;

				case 24011:
					Command.TeamController.c24011(c);
					break;

				case 24012:
					Command.TeamController.c24012(c);
					break;

				case 24013:
					Command.TeamController.c24013(c);
					break;

				case 24014:
					Command.TeamController.c24014(c);
					break;

				case 24015:
					Command.TeamController.c24015(c);
					break;

				case 24016:
					Command.TeamController.c24016(c);
					break;

				case 24017:
					Command.TeamController.c24017(c);
					break;

				case 24030:
					Command.InsController.c24030(c);
					break;

				case 24031:
					Command.TeamController.c24031(c);
					break;

				case 24032:
					Command.TeamController.c24032(c);
					break;

				case 24033:
					Command.TeamController.c24033(c);
					break;

				case 24034:
					Command.TeamController.c24034(c);
					break;

			}
			
		}

	}
}
