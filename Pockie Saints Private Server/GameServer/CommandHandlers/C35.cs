using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C35
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 35001:
					Command.DreamlandController.c35001(c);
					break;

				case 35002:
					Command.DreamlandController.c35002(c);
					break;

				case 35003:
					Command.DreamlandController.c35003(c);
					break;

				case 35004:
					Command.DreamlandController.c35004(c);
					break;

				case 35005:
					Command.DreamlandController.c35005(c);
					break;

				case 35006:
					Command.DreamlandController.c35006(c);
					break;

				case 35007:
					Command.DreamlandController.c35007(c);
					break;

				case 35008:
					Command.DreamlandController.c35008(c);
					break;

				case 35009:
					Command.DreamlandController.c35009(c);
					break;

				case 35010:
					Command.DreamlandController.c35010(c);
					break;

				case 35011:
					Command.DreamlandController.c35011(c);
					break;

				case 35012:
					Command.DreamlandController.c35012(c);
					break;

				case 35013:
					Command.EctypeTimeBuyController.c35013(c);
					break;

				case 35014:
					Command.EctypeTimeBuyController.c35014(c);
					break;

				case 35015:
					Command.EctypeTimeBuyController.c35015(c);
					break;

			}
			
		}

	}
}
