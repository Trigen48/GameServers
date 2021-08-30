using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C43
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				/*case 43000:
					Command.IntimacyController.c43000(c);
					break;*/

				case 43001:
					Command.IntimacyController.c43001(c);
					break;

				/*case 43002:
					Command.IntimacyController.c43002(c);
					break;*/

				case 43003:
					Command.IntimacyController.c43003(c);
					break;

				/*case 43004:
					Command.IntimacyController.c43004(c);
					break;*/

				case 43005:
					Command.IntimacyController.c43005(c);
					break;

			}
			
		}

	}
}
