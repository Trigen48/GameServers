using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C18
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 18000:
					Command.MedalController.c18000(c);
					break;

				case 18001:
					Command.MedalController.c18001(c);
					break;

				case 18002:
					Command.MedalController.c18002(c);
					break;

				case 18003:
					Command.MedalController.c18003(c);
					break;

				case 18004:
					Command.MedalController.c18004(c);
					break;

				/*case 18010:
					Command.MedalController.c18010(c);
					break;*/

			}
			
		}

	}
}
