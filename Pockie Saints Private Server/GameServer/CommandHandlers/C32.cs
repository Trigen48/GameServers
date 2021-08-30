using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C32
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 32000:
					Command.DialogController.c32000(c);
					break;

			}
			
		}

	}
}
