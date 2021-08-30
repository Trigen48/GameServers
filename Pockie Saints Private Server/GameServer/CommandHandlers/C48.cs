using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C48
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 48000:
					Command.AchievementController.c48000(c);
					break;

				case 48001:
					Command.AchievementController.c48001(c);
					break;

				case 48002:
					Command.AchievementController.c48002(c);
					break;

				case 48003:
					Command.AchievementController.c48003(c);
					break;

				case 48004:
					Command.AchievementController.c48004(c);
					break;

			}
			
		}

	}
}
