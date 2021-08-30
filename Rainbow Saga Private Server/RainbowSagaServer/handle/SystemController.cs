using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;

namespace RainbowServer.Handler
{

	internal static class SystemController
	{

		internal static void GetRecentClassCDgnReqID(ConnectionInfo c)
		{
			Console.WriteLine("SystemController.GetRecentClassCDgnReqID");
			
			
		}

		internal static void GetEliteRecentClassCDgnReqID(ConnectionInfo c)
		{
			Console.WriteLine("SystemController.GetEliteRecentClassCDgnReqID");
			
			
		}

		internal static void UpdateSystemSetRequestID(ConnectionInfo c)
		{
			Console.WriteLine("SystemController.UpdateSystemSetRequestID");

            UpdateSystemSetRequest req = new UpdateSystemSetRequest();
            Serial.Decrypt(c, ref req);
           
            Players.Get(c).player.bInfo.bSystem.autoRetreat= req.autoRetreat;
            Players.Get(c).player.bInfo.bSystem.autoRevive= req.autoRevive;

            Players.Get(c).player.bInfo.bSystem.cameraShake = req.cameraShake;
            Players.Get(c).player.bInfo.bSystem.damageEffect = req.damageEffect;
            Players.Get(c).player.bInfo.bSystem.displaySet = req.displaySet;

            //volume
          //  Players.Get(c).player.bInfo.bSystem.volumeSet = req.volumeSet;
            Players.Get(c).player.bInfo.bSystem.volumeSet.effectVolume = req.volumeSet.effectVolume;
            Players.Get(c).player.bInfo.bSystem.volumeSet.musicVolume = req.volumeSet.musicVolume;
            Players.Get(c).player.bInfo.bSystem.volumeSet.onOff = req.volumeSet.onOff;

            Players.Get(c).player.bInfo.bSystem.skillEffect = req.skillEffect;
            Players.Get(c).player.bInfo.bSystem.vechileDisplay = req.vechileDisplay;
            Players.Get(c).player.bInfo.bSystem.remoteChallenge= req.remoteChallenge;
            Players.Get(c).player.bInfo.bSystem.pickUpSet = req.pickUpSet;

            Players.Get(c).SaveMain();
            req = null;
		}

		internal static void QueryRealNameAuthID(ConnectionInfo c)
		{
			Console.WriteLine("SystemController.QueryRealNameAuthID");
			
			
		}


	}

}
