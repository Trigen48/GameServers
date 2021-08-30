using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;

namespace RainbowServer.Handler
{

	internal static class FriendController
	{

		internal static void SearchFriendID(ConnectionInfo c)
		{
			Console.WriteLine("FriendController.SearchFriendID");
			
			
		}

		internal static void AddFriendID(ConnectionInfo c)
		{
			Console.WriteLine("FriendController.AddFriendID");
			
			
		}

		internal static void AddFriendAckID(ConnectionInfo c)
		{
			Console.WriteLine("FriendController.AddFriendAckID");
			
			
		}

		internal static void GetFriendListID(ConnectionInfo c)
		{
			//Console.WriteLine("FriendController.GetFriendListID");
            c.ar = null;

            GetFriendListAck res = new GetFriendListAck();
            res = Players.Get(c).friends.friends;

            Serial.Add(Proto.MessageConsts.GetFriendListAckID, res, ref c);
			
		}

		internal static void GetTempFriendListID(ConnectionInfo c)
		{
			//Console.WriteLine("FriendController.GetTempFriendListID");

            c.ar = null;

            GetTempFriendListAck res = new GetTempFriendListAck();
            res = Players.Get(c).friends.friendst;

            Serial.Add(Proto.MessageConsts.GetTempFriendListID, res, ref c);
		}

		internal static void GetBlackListID(ConnectionInfo c)
		{
			//Console.WriteLine("FriendController.GetBlackListID");

            c.ar = null;

            GetBlackListAck res = new GetBlackListAck();
            res = Players.Get(c).friends.friendsb;

            Serial.Add(Proto.MessageConsts.GetBlackListAckID, res, ref c);
		}

		internal static void GetReqListID(ConnectionInfo c)
		{
			//Console.WriteLine("FriendController.GetReqListID");
            GetReqListAck res = new GetReqListAck();


            res = Players.Get(c).friends.friendsr;

            Serial.Add(Proto.MessageConsts.GetReqListAckID, res, ref c);
		}

		internal static void AddToBlacklistID(ConnectionInfo c)
		{
			Console.WriteLine("FriendController.AddToBlacklistID");
			
			
		}

		internal static void DelFriendID(ConnectionInfo c)
		{
			Console.WriteLine("FriendController.DelFriendID");
			
			
		}

		internal static void DelFromBlacklistID(ConnectionInfo c)
		{
			Console.WriteLine("FriendController.DelFromBlacklistID");
			
			
		}

		internal static void DelTempFriendID(ConnectionInfo c)
		{
			Console.WriteLine("FriendController.DelTempFriendID");
			
			
		}


	}

}
