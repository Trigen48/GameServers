using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;


namespace RainbowServer.Handler
{

	internal static class ChooseCharStage
	{

		internal static void LoginPhaseID(ConnectionInfo c)
		{
			//Console.WriteLine("ChooseCharStage.LoginPhaseID");
            LoginPhase req = new LoginPhase();
            Serial.Decrypt(c, ref req);

		}

		internal static void EnableCharRequestID(ConnectionInfo c)
		{
			Console.WriteLine("ChooseCharStage.EnableCharRequestID");
			
			
		}

		internal static void DisableCharRequestID(ConnectionInfo c)
		{
			Console.WriteLine("ChooseCharStage.DisableCharRequestID");

            DisableCharRequest req = new DisableCharRequest();
            Serial.Decrypt(c, ref req);

            DisableCharResponse res = new DisableCharResponse();
            res = Players.DeleteChar(ref req, ref c);

            Serial.Add(Proto.MessageConsts.DisableCharResponseID, res, ref c);
			
		}


	}

}
