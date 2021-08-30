using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C50
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
                case 50001:
                    Command.ActiveController.ClaimZodiac(c);
                    break;

                case 50002:
                    Command.ActiveController.ClaimTopup(c);
                    break;

                case 50003:
                    Command.ActiveController.CheckTopup(c);
                    break;

                case 50004:
                    Command.ActiveController.CheckSignin(c);
                    break;

                case 50005:
                    Command.ActiveController.DoSignin(c);
                    break;

				case 50006:
					Command.ActiveController.c50006(c);
					break;

				case 50007:
					Command.ActiveController.c50007(c);
					break;

				case 50008:
					Command.ActiveController.c50008(c);
					break;

				case 50009:
					Command.ActiveController.c50009(c);
					break;

				case 50010:
					Command.ActiveController.c50010(c);
					break;

				case 50011:
					Command.ActiveController.c50011(c);
					break;

				case 50012:
					Command.ActiveController.c50012(c);
					break;

				case 50013:
					Command.AnnoumcementController.c50013(c);
					break;

				case 50014:
					Command.AnnoumcementController.c50014(c);
					break;

				case 50015:
					Command.AnnoumcementController.c50015(c);
					break;

				case 50016:
					Command.AnnoumcementController.c50016(c);
					break;

				case 50017:
					Command.AnnoumcementController.c50017(c);
					break;

				case 50018:
					Command.AnnoumcementController.c50018(c);
					break;

				case 50019:
					Command.AnnoumcementController.c50019(c);
					break;

				case 50020:
					Command.HappyController.c50020(c);
					break;

				case 50021:
					Command.HappyController.c50021(c);
					break;

				case 50022:
					Command.HappyController.c50022(c);
					break;

                case 50023:
                    Command.RoleController.GetWorldLevel(c);
                    break;

                case 50025:
                    Command.LuckWheelController.GetLuckyWheelStatus(c);
                    break;

                case 50026:
                    Command.LuckWheelController.TryLuckyWheel(c);
                    break;

                case 50027:
                    Command.LuckWheelController.ClaimPrize(c);
                    break;

                case 50028:
                    Command.LuckWheelController.GetLuckyWheelPlayers(c);
                    break;

			}
			
		}

	}
}
