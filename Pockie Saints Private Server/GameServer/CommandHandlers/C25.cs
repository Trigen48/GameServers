using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C25
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 25001:
					Command.VipController.c25001(c);
					break;

				case 25002:
					Command.VipController.c25002(c);
					break;

				case 25003:
					Command.VipController.c25003(c);
					break;

				case 25004:
					Command.VipController.c25004(c);
					break;

				case 25005:
					Command.VipController.c25005(c);
					break;

				case 25010:
					Command.VipController.c25010(c);
					break;

			}
			
		}

	}
}
