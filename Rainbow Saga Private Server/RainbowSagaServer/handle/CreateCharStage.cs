using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;


namespace RainbowServer.Handler
{

	internal static class CreateCharStage
	{

		internal static void CreateCharRequestID(ConnectionInfo c)
		{
			//Console.WriteLine("CreateCharStage.CreateCharRequestID");

            CreateCharRequest req = new CreateCharRequest();
            Serial.Decrypt(c, ref req);
            c.ar = null;

            
            CreateCharResponse res;
            res = Players.CreateChar(ref req, ref c);

            Serial.EncoderC(c, res);
            c.cmd.Add(new RequestItem(Proto.MessageConsts.CreateCharResponseID, c.m.ToArray()));
            res = null;
			
		}


	}

}
