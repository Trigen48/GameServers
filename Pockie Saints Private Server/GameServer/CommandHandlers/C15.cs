using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C15
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 15000:
					Command.BagController.c15000(c);
					break;

				case 15001:
					Command.InfoGoodsController.c15001(c);
					break;

                case 15010:
                    Command.BagController.GetBags(c);
                    break;

				case 15011:
					Command.PhaseController.c15011(c);
					break;

				case 15012:
					Command.BagController.c15012(c);
					break;

				case 15013:
					Command.MallController.c15013(c);
					break;

				case 15014:
					Command.BagController.c15014(c);
					break;

				case 15020:
					Command.BagController.c15020(c);
					break;

				case 15021:
					Command.BagController.c15021(c);
					break;

				case 15030:
					Command.BagController.c15030(c);
					break;

				case 15031:
					Command.BagController.c15031(c);
					break;

				case 15032:
					Command.FigureController.c15032(c);
					break;

				case 15033:
					Command.BagController.c15033(c);
					break;

				case 15034:
					Command.FigureController.c15034(c);
					break;

                case 15040:
                    Command.BagController.MoveToSlot(c);
                    break;

				case 15041:
					Command.StorageController.c15041(c);
					break;

				case 15042:
					Command.StorageController.c15042(c);
					break;

                case 15050:
                    Command.BagController.UseItem(c);
                    break;

				case 15051:
					Command.BagController.c15051(c);
					break;

                case 15052:
                    Command.BagController.Organize(c);
                    break;

				case 15053:
					Command.DropPackController.c15053(c);
					break;

				case 15060:
					Command.BuildController.c15060(c);
					break;

				case 15061:
					Command.BuildController.c15061(c);
					break;

				case 15062:
					Command.BuildController.c15062(c);
					break;

				case 15063:
					Command.BuildController.c15063(c);
					break;

				case 15064:
					Command.BuildController.c15064(c);
					break;

				case 15065:
					Command.BuildController.c15065(c);
					break;

				case 15066:
					Command.BuildController.c15066(c);
					break;

				case 15067:
					Command.BuildController.c15067(c);
					break;

				case 15068:
					Command.BuffController.c15068(c);
					break;

                case 15069:
                    Command.BagController.Dismantle(c);
                    break;

				case 15070:
					Command.BuffController.c15070(c);
					break;

				case 15071:
					Command.BuffController.c15071(c);
					break;

				case 15072:
					Command.BuildController.c15072(c);
					break;

				case 15073:
					Command.BuildController.c15073(c);
					break;

				case 15074:
					Command.BagController.c15074(c);
					break;

				case 15075:
					Command.MallController.c15075(c);
					break;

				case 15076:
					Command.MallController.c15076(c);
					break;

				case 15077:
					Command.BuildController.c15077(c);
					break;

				case 15078:
					Command.FigureController.c15078(c);
					break;

				case 15079:
					Command.RoleController.c15079(c);
					break;

				case 15080:
					Command.BuildController.c15080(c);
					break;

				case 15081:
					Command.MallController.c15081(c);
					break;

				case 15082:
					Command.WardrobeController.c15082(c);
					break;

			}
			
		}

	}
}
