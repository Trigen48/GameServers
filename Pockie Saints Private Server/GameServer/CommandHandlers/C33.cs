using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C33
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 33001:
					Command.MeditationController.c33001(c);
					break;

				case 33002:
					Command.MeditationController.c33002(c);
					break;

				case 33010:
					Command.SceneController.c33010(c);
					break;

			}
			
		}

	}
}
