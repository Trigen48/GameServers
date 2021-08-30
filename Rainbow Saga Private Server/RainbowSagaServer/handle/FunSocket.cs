using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;

namespace RainbowServer.Handler
{

	internal static class FunSocket
	{

		internal static void EncryptInfoRequestID(ConnectionInfo c)
		{
			//Console.WriteLine("FunSocket.EncryptInfoRequestID");

            EncryptInfoRequest req = new EncryptInfoRequest();
            Serial.Decrypt(c, ref req);
            c.ar = null;

            EncryptInfoResponse res = new EncryptInfoResponse();
            res.type = Serial.___unnamed_1;
            res.maxLen = (uint)Serial.___unnamed_2;
            res.secretKey = (uint)Serial.___unnamed_3;


            Serial.AddE(Proto.MessageConsts.EncryptInfoResponseID, res,ref c);

		}


	}

}
