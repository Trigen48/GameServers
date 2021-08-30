using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C12
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 12001:
					Command.SceneController.c12001(c);
					break;

				case 12002:
					Command.SceneController.c12002(c);
					break;

				case 12003:
					Command.SceneController.c12003(c);
					break;

				case 12004:
					Command.SceneController.c12004(c);
					break;

				case 12005:
					Command.SceneController.c12005(c);
					break;

				case 12006:
					Command.SceneController.c12006(c);
					break;

				case 12007:
					Command.SceneController.c12007(c);
					break;

				case 12008:
					Command.SceneController.c12008(c);
					break;

				case 12009:
					Command.SceneController.c12009(c);
					break;

				case 12010:
					Command.SceneController.c12010(c);
					break;

				case 12011:
					Command.SceneController.c12011(c);
					break;

				case 12012:
					Command.SceneController.c12012(c);
					break;

				case 12013:
					Command.SceneController.c12013(c);
					break;

				case 12014:
					Command.SceneController.c12014(c);
					break;

				case 12015:
					Command.SceneController.c12015(c);
					break;

				case 12016:
					Command.SceneController.c12016(c);
					break;

				case 12017:
					Command.SceneController.c12017(c);
					break;

				case 12018:
					Command.SceneController.c12018(c);
					break;

				case 12019:
					Command.SceneController.c12019(c);
					break;

				case 12020:
					Command.SceneController.c12020(c);
					break;

				case 12021:
					Command.SceneController.c12021(c);
					break;

				case 12022:
					Command.SceneController.c12022(c);
					break;

				case 12023:
					Command.SceneController.c12023(c);
					break;

				case 12030:
					Command.SceneController.c12030(c);
					break;

				case 12031:
					Command.InsController.c12031(c);
					break;

				case 12050:
					Command.SceneController.c12050(c);
					break;

				case 12051:
					Command.VipController.c12051(c);
					break;

				case 12080:
					Command.SceneController.c12080(c);
					break;

				case 12081:
					Command.SceneController.c12081(c);
					break;

				case 12082:
					Command.SceneController.c12082(c);
					break;

				case 12083:
					Command.SceneController.c12083(c);
					break;

				case 12084:
					Command.SceneController.c12084(c);
					break;

				/*case 12085:
					Command.PlayerInfoController.c12085(c);
					break;*/

				case 12086:
					Command.SceneController.c12086(c);
					break;

			}
			
		}

	}
}
