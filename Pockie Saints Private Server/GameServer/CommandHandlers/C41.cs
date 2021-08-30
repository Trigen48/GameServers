using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C41
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 41000:
					Command.PetController.c41000(c);
					break;

				case 41001:
					Command.PetController.c41001(c);
					break;

				case 41002:
					Command.PetController.c41002(c);
					break;

				case 41003:
					Command.PetController.c41003(c);
					break;

				case 41004:
					Command.PetController.c41004(c);
					break;

				case 41005:
					Command.PetController.c41005(c);
					break;

				case 41006:
					Command.PetController.c41006(c);
					break;

				case 41007:
					Command.PetController.c41007(c);
					break;

				case 41012:
					Command.PetController.c41012(c);
					break;

				case 41013:
					Command.PetController.c41013(c);
					break;

				case 41014:
					Command.PetController.c41014(c);
					break;

				case 41015:
					Command.PetController.c41015(c);
					break;

				case 41016:
					Command.PetController.c41016(c);
					break;

				case 41017:
					Command.PetController.c41017(c);
					break;

				case 41018:
					Command.PetController.c41018(c);
					break;

				case 41020:
					Command.PetController.c41020(c);
					break;

				case 41021:
					Command.PetController.c41021(c);
					break;

				case 41022:
					Command.PetController.c41022(c);
					break;

				case 41023:
					Command.SceneController.c41023(c);
					break;

				case 41024:
					Command.PetController.c41024(c);
					break;

				case 41025:
					Command.PetController.c41025(c);
					break;

				case 41026:
					Command.PetController.c41026(c);
					break;

				case 41027:
					Command.PetController.c41027(c);
					break;

				case 41028:
					Command.PetController.c41028(c);
					break;

				case 41029:
					Command.PetController.c41029(c);
					break;

				case 41030:
					Command.PetController.c41030(c);
					break;

				case 41031:
					Command.PetController.c41031(c);
					break;

				case 41032:
					Command.PetController.c41032(c);
					break;

				case 41033:
					Command.PetController.c41033(c);
					break;

				case 41034:
					Command.PetController.c41034(c);
					break;

			}
			
		}

	}
}
