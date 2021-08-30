using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C26
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 26001:
					Command.BattlefieldController.c26001(c);
					break;

				case 26002:
					Command.BattlefieldController.c26002(c);
					break;

				case 26003:
					Command.BattlefieldController.c26003(c);
					break;

				case 26004:
					Command.BattlefieldController.c26004(c);
					break;

				case 26011:
					Command.BattlefieldController.c26011(c);
					break;

				case 26012:
					Command.BattlefieldController.c26012(c);
					break;

				case 26013:
					Command.BattlefieldController.c26013(c);
					break;

				case 26014:
					Command.BattlefieldController.c26014(c);
					break;

				case 26015:
					Command.BattlefieldController.c26015(c);
					break;

				case 26016:
					Command.BattlefieldController.c26016(c);
					break;

				case 26017:
					Command.BattlefieldController.c26017(c);
					break;

				case 26018:
					Command.BattlefieldController.c26018(c);
					break;

				case 26019:
					Command.BattlefieldController.c26019(c);
					break;

				case 26020:
					Command.BattlefieldController.c26020(c);
					break;

				case 26021:
					Command.BattlefieldController.c26021(c);
					break;

				case 26101:
					Command.BattlefieldController.c26101(c);
					break;

				case 26201:
					Command.StarBattlefieldController.c26201(c);
					break;

				case 26202:
					Command.StarBattlefieldController.c26202(c);
					break;

				case 26301:
					Command.GuildWarController.c26301(c);
					break;

				case 26302:
					Command.GuildWarController.c26302(c);
					break;

				case 26303:
					Command.GuildWarController.c26303(c);
					break;

				case 26304:
					Command.GuildWarController.c26304(c);
					break;

				case 26305:
					Command.GuildWarController.c26305(c);
					break;

				case 26306:
					Command.GuildWarController.c26306(c);
					break;

				case 26307:
					Command.GuildWarController.c26307(c);
					break;

				case 26308:
					Command.GuildWarController.c26308(c);
					break;

				case 26309:
					Command.GuildWarController.c26309(c);
					break;

				case 26310:
					Command.GuildWarController.c26310(c);
					break;

				case 26311:
					Command.GuildWarController.c26311(c);
					break;

				case 26400:
					Command.CrossServiceBattlefieldController.c26400(c);
					break;

				case 26401:
					Command.CrossServiceBattlefieldController.c26401(c);
					break;

				case 26402:
					Command.CrossServiceBattlefieldController.c26402(c);
					break;

				case 26403:
					Command.CrossServiceBattlefieldController.c26403(c);
					break;

				case 26404:
					Command.CrossServiceBattlefieldController.c26404(c);
					break;

				case 26405:
					Command.CrossServiceBattlefieldController.c26405(c);
					break;

				case 26410:
					Command.CrossServiceBattlefieldController.c26410(c);
					break;

				case 26411:
					Command.CrossServiceBattlefieldController.c26411(c);
					break;

				case 26412:
					Command.CrossServiceBattlefieldController.c26412(c);
					break;

				case 26413:
					Command.CrossServiceBattlefieldController.c26413(c);
					break;

				case 26414:
					Command.CrossServiceBattlefieldController.c26414(c);
					break;

				case 26415:
					Command.CrossServiceBattlefieldController.c26415(c);
					break;

				case 26416:
					Command.CrossServiceBattlefieldController.c26416(c);
					break;

				case 26417:
					Command.CrossServiceBattlefieldController.c26417(c);
					break;

				case 26500:
					Command.GuildBattleController.c26500(c);
					break;

				case 26501:
					Command.GuildBattleController.c26501(c);
					break;

				case 26502:
					Command.GuildBattleController.c26502(c);
					break;

				case 26504:
					Command.GuildBattleController.c26504(c);
					break;

				case 26505:
					Command.GuildBattleController.c26505(c);
					break;

				case 26506:
					Command.GuildBattleController.c26506(c);
					break;

				case 26507:
					Command.GuildBattleController.c26507(c);
					break;

				case 26508:
					Command.GuildBattleController.c26508(c);
					break;

				case 26509:
					Command.GuildBattleController.c26509(c);
					break;

				case 26510:
					Command.GuildBattleController.c26510(c);
					break;

				case 26511:
					Command.GuildBattleController.c26511(c);
					break;

				case 26512:
					Command.GuildBattleController.c26512(c);
					break;

			}
			
		}

	}
}
