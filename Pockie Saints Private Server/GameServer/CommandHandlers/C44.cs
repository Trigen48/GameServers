using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C44
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 44000:
					Command.StarMapController.c44000(c);
					break;

				case 44001:
					Command.StarMapController.c44001(c);
					break;

				case 44002:
					Command.StarMapController.c44002(c);
					break;

				case 44003:
					Command.StarMapController.c44003(c);
					break;

				case 44004:
					Command.StarMapController.c44004(c);
					break;

				case 44005:
					Command.StarMapController.c44005(c);
					break;

				case 44006:
					Command.StarMapController.c44006(c);
					break;

			}
			
		}

	}
}
