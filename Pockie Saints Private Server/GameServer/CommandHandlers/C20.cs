using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C20
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 20001:
					Command.SceneController.c20001(c);
					break;

				case 20002:
					Command.SceneController.c20002(c);
					break;

				case 20003:
					Command.SceneController.c20003(c);
					break;

				case 20004:
					Command.SceneController.c20004(c);
					break;

				case 20005:
					Command.SceneController.c20005(c);
					break;

				case 20006:
					Command.SceneController.c20006(c);
					break;

				case 20007:
					Command.SceneController.c20007(c);
					break;

				case 20008:
					Command.SceneController.c20008(c);
					break;

				case 20009:
					Command.SceneController.c20009(c);
					break;

			}
			
		}

	}
}
