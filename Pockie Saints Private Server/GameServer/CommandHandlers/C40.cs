using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C40
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				/*case 40000:
					Command.GuildController.c40000(c);
					break;*/

				case 40001:
					Command.GuildController.c40001(c);
					break;

				case 40002:
					Command.GuildController.c40002(c);
					break;

				case 40003:
					Command.GuildController.c40003(c);
					break;

				case 40004:
					Command.GuildController.c40004(c);
					break;

				case 40005:
					Command.GuildController.c40005(c);
					break;

				case 40006:
					Command.GuildController.c40006(c);
					break;

				case 40007:
					Command.GuildController.c40007(c);
					break;

				case 40008:
					Command.GuildController.c40008(c);
					break;

				case 40009:
					Command.GuildController.c40009(c);
					break;

                case 40010:
                    Command.GuildController.GetGuilds(c);
                    break;

				case 40011:
					Command.GuildController.c40011(c);
					break;

				case 40012:
					Command.GuildController.c40012(c);
					break;

				case 40013:
					Command.GuildController.c40013(c);
					break;

				case 40014:
					Command.GuildController.c40014(c);
					break;

                case 40015:
                    Command.GuildController.GuildDeclaration(c);
                    break;

                case 40016:
                    Command.GuildController.GuildAnnounce(c);
                    break;

				case 40017:
					Command.GuildController.c40017(c);
					break;

				case 40018:
					Command.GuildController.c40018(c);
					break;

				case 40019:
					Command.GuildController.c40019(c);
					break;

				case 40020:
					Command.GuildController.c40020(c);
					break;

				case 40021:
					Command.GuildController.c40021(c);
					break;

				case 40022:
					Command.GuildController.c40022(c);
					break;

				case 40023:
					Command.GuildController.c40023(c);
					break;

				case 40024:
					Command.GuildController.c40024(c);
					break;

				case 40025:
					Command.GuildController.c40025(c);
					break;

				case 40026:
					Command.GuildController.c40026(c);
					break;

				case 40027:
					Command.GuildController.c40027(c);
					break;

				case 40028:
					Command.GuildController.c40028(c);
					break;

				case 40029:
					Command.GuildController.c40029(c);
					break;

				case 40030:
					Command.GuildController.c40030(c);
					break;

				case 40031:
					Command.GuildController.c40031(c);
					break;

				case 40032:
					Command.GuildController.c40032(c);
					break;

				case 40033:
					Command.GuildController.c40033(c);
					break;

				case 40034:
					Command.GuildController.c40034(c);
					break;

				case 40035:
					Command.GuildController.c40035(c);
					break;

				case 40036:
					Command.GuildController.c40036(c);
					break;

				case 40037:
					Command.GuildController.c40037(c);
					break;

			}
			
		}

	}
}
