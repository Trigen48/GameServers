using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C49
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 49000:
					Command.GodHeadController.c49000(c);
					break;

				case 49001:
					Command.GodHeadController.c49001(c);
					break;

				case 49002:
					Command.GodHeadController.c49002(c);
					break;

				case 49003:
					Command.GodHeadController.c49003(c);
					break;

				case 49004:
					Command.GodHeadController.c49004(c);
					break;

				case 49006:
					Command.GodHeadController.c49006(c);
					break;

				case 49007:
					Command.GodHeadController.c49007(c);
					break;

				case 49008:
					Command.GodHeadController.c49008(c);
					break;

				case 49009:
					Command.GodHeadController.c49009(c);
					break;

			}
			
		}

	}
}
