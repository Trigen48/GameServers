using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C27
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 27001:
					Command.TranController.c27001(c);
					break;

				case 27002:
					Command.TranController.c27002(c);
					break;

				case 27003:
					Command.TranController.c27003(c);
					break;

				case 27004:
					Command.TranController.c27004(c);
					break;

				case 27005:
					Command.TranController.c27005(c);
					break;

				case 27006:
					Command.TranController.c27006(c);
					break;

				case 27007:
					Command.TranController.c27007(c);
					break;

				case 27008:
					Command.TranController.c27008(c);
					break;

				case 27011:
					Command.TranController.c27011(c);
					break;

				case 27012:
					Command.TranController.c27012(c);
					break;

				case 27013:
					Command.TranController.c27013(c);
					break;

				case 27021:
					Command.MarketController.c27021(c);
					break;

				case 27022:
					Command.MarketController.c27022(c);
					break;

				case 27023:
					Command.MarketController.c27023(c);
					break;

				case 27024:
					Command.MarketController.c27024(c);
					break;

				case 27025:
					Command.MarketController.c27025(c);
					break;

				case 27026:
					Command.MarketController.c27026(c);
					break;

				case 27027:
					Command.MarketController.c27027(c);
					break;

				case 27028:
					Command.MarketController.c27028(c);
					break;

				case 27029:
					Command.TransmuteController.c27029(c);
					break;

				case 27030:
					Command.ExchangeController.c27030(c);
					break;

			}
			
		}

	}
}
