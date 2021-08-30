using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C47
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 47000:
					Command.ArenaController.c47000(c);
					break;

				case 47001:
					Command.ArenaController.c47001(c);
					break;

				case 47002:
					Command.ArenaController.c47002(c);
					break;

				case 47003:
					Command.ArenaController.c47003(c);
					break;

				case 47004:
					Command.ArenaController.c47004(c);
					break;

				case 47005:
					Command.ArenaController.c47005(c);
					break;

				case 47006:
					Command.ArenaController.c47006(c);
					break;

				case 47007:
					Command.ArenaController.c47007(c);
					break;

				case 47008:
					Command.ArenaController.c47008(c);
					break;

				case 47009:
					Command.ArenaController.c47009(c);
					break;

				case 47010:
					Command.ArenaController.c47010(c);
					break;

				case 47012:
					Command.ArenaController.c47012(c);
					break;

				case 47013:
					Command.ArenaController.c47013(c);
					break;

				case 47014:
					Command.ArenaController.c47014(c);
					break;

				case 47015:
					Command.ArenaController.c47015(c);
					break;

			}
			
		}

	}
}
