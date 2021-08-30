using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C10
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
                case 10000:
                    Command.LoginController.Login(c);
                    break;

                case 10002:
                    Command.LoginController.GetRoles(c);
                    break;

                case 10003:
                    Command.LoginController.CreateRole(c);
                    break;

                case 10004:
                    Command.LoginController.SelectRole(c);
                    break;

                case 10006:
                    Command.ServerTimerController.GetServerTime(c);
                    break;

				case 10009:
					Command.SceneController.c10009(c);
					break;

				case 10010:
					Command.ServerLineController.c10010(c);
					break;

				case 10011:
					Command.AntiAddictionSystemController.c10011(c);
					break;

				case 10012:
					Command.AntiAddictionSystemController.c10012(c);
					break;

			}
			
		}

	}
}
