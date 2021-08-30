using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C29
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 29001:
					Command.RewardController.c29001(c);
					break;

				case 29002:
					Command.RewardController.c29002(c);
					break;

				case 29003:
					Command.RewardController.c29003(c);
					break;

				case 29004:
					Command.RewardController.c29004(c);
					break;

				case 29005:
					Command.CrossServiceBattlefieldController.c29005(c);
					break;

				case 29006:
					Command.CrossServiceBattlefieldController.c29006(c);
					break;

				case 29029:
					Command.BagController.c29029(c);
					break;

			}
			
		}

	}
}
