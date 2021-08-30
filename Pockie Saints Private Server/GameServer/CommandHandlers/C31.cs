using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C31
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 31000:
					Command.EscortController.c31000(c);
					break;

				case 31001:
					Command.EscortController.c31001(c);
					break;

				case 31002:
					Command.EscortController.c31002(c);
					break;

				case 31003:
					Command.EscortController.c31003(c);
					break;

				case 31004:
					Command.EscortController.c31004(c);
					break;

				case 31005:
					Command.EscortController.c31005(c);
					break;

				case 31010:
					Command.EscortController.c31010(c);
					break;

				case 31011:
					Command.SceneController.c31011(c);
					break;

			}
			
		}

	}
}
