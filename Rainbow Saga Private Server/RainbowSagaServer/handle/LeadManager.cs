using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;


namespace RainbowServer.Handler
{

	internal static class LeadManager
	{

        internal static void LeadSetMarkMessageRequestID(ConnectionInfo c)
        {
           // Console.WriteLine("LeadManager.LeadSetMarkMessageRequestID");
            SaveNewGuidMark req = new SaveNewGuidMark();
            Serial.Decrypt(c, ref req);

            Console.WriteLine("Leadid -> "+req.markId.ToString());
           // req.markId

            SaveNewGuidMarkResult res = new SaveNewGuidMarkResult();

            res.result = req.markId;

            Serial.EncoderC(c, res);
            c.cmd.Add(new RequestItem(Proto.MessageConsts.LeadSetMarkMessageResponseID, c.m.ToArray()));
            res = null;
            //  req = Serializer.Deserialize<SaveNewGuidMark>(new System.IO.MemoryStream((byte[])c.ar));
            // SaveNewGuidMarkResult res = new SaveNewGuidMarkResult();


        }


	}

}
