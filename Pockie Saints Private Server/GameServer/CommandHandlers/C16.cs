using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C16
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 16010:
					Command.MountController.c16010(c);
					break;

				case 16011:
					Command.MountController.c16011(c);
					break;

				case 16013:
					Command.MountController.c16013(c);
					break;

				case 16014:
					Command.MountController.c16014(c);
					break;

				case 16016:
					Command.MountController.c16016(c);
					break;

				case 16017:
					Command.MountController.c16017(c);
					break;

				case 16018:
					Command.MountController.c16018(c);
					break;

				case 16019:
					Command.MountController.c16019(c);
					break;

				case 16020:
					Command.MountController.c16020(c);
					break;

			}
			
		}

	}
}
