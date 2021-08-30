using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C13
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 13001:
					Command.RoleController.c13001(c);
					break;

				case 13002:
					Command.RoleController.c13002(c);
					break;

				case 13003:
					Command.RoleController.c13003(c);
					break;

				case 13004:
					Command.PhaseController.c13004(c);
					break;

				/*case 13005:
					Command.BagController.c13005(c);
					break;*/

				case 13006:
					Command.SkillController.c13006(c);
					break;

				case 13007:
					Command.ShortCutController.c13007(c);
					break;

				case 13008:
					Command.ShortCutController.c13008(c);
					break;

				case 13009:
					Command.ShortCutController.c13009(c);
					break;

				case 13010:
					Command.GuideController.c13010(c);
					break;

				case 13011:
					Command.RoleController.c13011(c);
					break;

				case 13012:
					Command.RoleController.c13012(c);
					break;

				case 13013:
					Command.SceneController.c13013(c);
					break;

				case 13014:
					Command.SceneController.c13014(c);
					break;

				case 13015:
					Command.RoleController.c13015(c);
					break;

				case 13016:
					Command.SceneController.c13016(c);
					break;

				case 13017:
					Command.AutoFightController.c13017(c);
					break;

				case 13018:
					Command.AutoFightController.c13018(c);
					break;

				case 13019:
					Command.SceneController.c13019(c);
					break;

				case 13020:
					Command.RoleController.c13020(c);
					break;

				case 13021:
					Command.RoleController.c13021(c);
					break;

				case 13022:
					Command.RoleController.c13022(c);
					break;

				case 13023:
					Command.RoleController.c13023(c);
					break;

				case 13024:
					Command.RoleController.c13024(c);
					break;

				case 13025:
					Command.RoleController.c13025(c);
					break;

				case 13026:
					Command.FigureController.c13026(c);
					break;

				case 13027:
					Command.RoleController.c13027(c);
					break;

                case 13028:
                    Command.RoleController.GetCharPoints(c);
                    break;

			}
			
		}

	}
}
