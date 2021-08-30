using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C36
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 36001:
					Command.YellowDiamondController.c36001(c);
					break;

				case 36002:
					Command.YellowDiamondController.c36002(c);
					break;

				case 36003:
					Command.YellowDiamondController.c36003(c);
					break;

				case 36004:
					Command.YellowDiamondController.c36004(c);
					break;

				case 36005:
					Command.YellowDiamondController.c36005(c);
					break;

				case 36006:
					Command.YellowDiamondController.c36006(c);
					break;

			}
			
		}

	}
}
