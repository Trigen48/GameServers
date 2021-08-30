using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C22
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 22001:
					Command.RankController.c22001(c);
					break;

				case 22002:
					Command.RankController.c22002(c);
					break;

				case 22003:
					Command.RankController.c22003(c);
					break;

				case 22004:
					Command.RankController.c22004(c);
					break;

				case 22005:
					Command.RankController.c22005(c);
					break;

				case 22006:
					Command.RankController.c22006(c);
					break;

				case 22007:
					Command.RankController.c22007(c);
					break;

				case 22008:
					Command.RankController.c22008(c);
					break;

				case 22010:
					Command.RankController.c22010(c);
					break;

				case 22011:
					Command.RankController.c22011(c);
					break;

				case 22012:
					Command.RankController.c22012(c);
					break;

				case 22013:
					Command.RankController.c22013(c);
					break;

				case 22014:
					Command.RankController.c22014(c);
					break;

				case 22015:
					Command.RankController.c22015(c);
					break;

				case 22016:
					Command.RankController.c22016(c);
					break;

				case 22100:
					Command.CrossServiceBattlefieldController.c22100(c);
					break;

				case 22101:
					Command.CrossServiceBattlefieldController.c22101(c);
					break;

				case 22102:
					Command.CrossServiceBattlefieldController.c22102(c);
					break;

			}
			
		}

	}
}
