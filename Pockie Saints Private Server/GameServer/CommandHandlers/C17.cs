using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C17
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 17001:
					Command.HoroscopesController.c17001(c);
					break;

				case 17002:
					Command.HoroscopesController.c17002(c);
					break;

				case 17003:
					Command.HoroscopesController.c17003(c);
					break;

				case 17010:
					Command.HoroscopesController.c17010(c);
					break;

			}
			
		}

	}
}
