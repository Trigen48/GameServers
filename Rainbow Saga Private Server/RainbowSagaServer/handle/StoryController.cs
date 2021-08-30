using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;

namespace RainbowServer.Handler
{

	internal static class StoryController
	{

		internal static void GetStoryProgressID(ConnectionInfo c)
		{
			Console.WriteLine("StoryController.GetStoryProgressID");

            /*GetStoryProgress req = new GetStoryProgress();

            Serial.Decrypt(c, ref req);

            SetStoryProgress res = new SetStoryProgress();
            res.storyid = 50000007;

            Serial.Add(Proto.MessageConsts.SetStoryProgressID, res, ref c);*/

            
		}

		internal static void GetHiddenStoryObjectsID(ConnectionInfo c)
		{
			Console.WriteLine("StoryController.GetHiddenStoryObjectsID");
			
           /* GetHiddenStoryObjects req= new GetHiddenStoryObjects();
            Serial.Decrypt(c, ref req);

            GetHiddenStoryObjectsAck res = new GetHiddenStoryObjectsAck();

            //res.


            Serial.Add(Proto.MessageConsts.GetHiddenStoryObjectsAckID, res, ref c);*/
		}

		internal static void SetStoryProgressID(ConnectionInfo c)
		{
			Console.WriteLine("StoryController.SetStoryProgressID");
			
			
		}

		internal static void EnterStoryModeID(ConnectionInfo c)
		{
			Console.WriteLine("StoryController.EnterStoryModeID");
			
			
		}

		internal static void ExitStoryModeID(ConnectionInfo c)
		{
			Console.WriteLine("StoryController.ExitStoryModeID");
			
			
		}

		internal static void SetStoryMobStatusID(ConnectionInfo c)
		{
			Console.WriteLine("StoryController.SetStoryMobStatusID");
			
			
		}


	}

}
