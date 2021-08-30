using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C34
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 34001:
					Command.NobilityController.c34001(c);
					break;

				case 34002:
					Command.NobilityController.c34002(c);
					break;

			}
			
		}

	}
}
