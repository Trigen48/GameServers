using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C11
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
                case 11001:
                    Command.ChatController.SendGlobalMessage(c);
                    break;

				case 11002:
					Command.ChatController.c11002(c);
					break;

				case 11003:
					Command.ChatController.c11003(c);
					break;

				case 11005:
					Command.ChatController.c11005(c);
					break;

				case 11006:
					Command.ChatController.c11006(c);
					break;

				case 11008:
					Command.ChatController.c11008(c);
					break;

				case 11009:
					Command.ChatController.c11009(c);
					break;

				case 11011:
					Command.ChatController.c11011(c);
					break;

			}
			
		}

	}
}
