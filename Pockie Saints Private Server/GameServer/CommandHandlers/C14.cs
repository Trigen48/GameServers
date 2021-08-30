using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C14
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 14000:
					Command.FriendController.c14000(c);
					break;

				case 14001:
					Command.FriendController.c14001(c);
					break;

				case 14002:
					Command.FriendController.c14002(c);
					break;

				case 14003:
					Command.FriendController.c14003(c);
					break;

				case 14004:
					Command.FriendController.c14004(c);
					break;

				case 14005:
					Command.FriendController.c14005(c);
					break;

				case 14006:
					Command.FriendController.c14006(c);
					break;

				case 14007:
					Command.FriendController.c14007(c);
					break;

				case 14008:
					Command.FriendController.c14008(c);
					break;

				case 14009:
					Command.FriendController.c14009(c);
					break;

				case 14010:
					Command.FriendController.c14010(c);
					break;

				/*case 14011:
					Command.FriendController.c14011(c);
					break;

				case 14012:
					Command.FriendController.c14012(c);
					break;*/

				case 14013:
					Command.FriendController.c14013(c);
					break;

				case 14020:
					Command.FriendController.c14020(c);
					break;

				case 14021:
					Command.FriendController.c14021(c);
					break;

				/*case 14030:
					Command.FriendController.c14030(c);
					break;

				case 14031:
					Command.FriendController.c14031(c);
					break;*/

				case 14032:
					Command.FriendController.c14032(c);
					break;

				case 14033:
					Command.InviteFriendsController.c14033(c);
					break;

				case 14034:
					Command.InviteFriendsController.c14034(c);
					break;

				case 14035:
					Command.InviteFriendsController.c14035(c);
					break;

				case 14036:
					Command.InviteFriendsController.c14036(c);
					break;

				case 14037:
					Command.InviteFriendsController.c14037(c);
					break;

			}
			
		}

	}
}
