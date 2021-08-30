using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;
using RainbowServer.proto.rpc;

namespace RainbowServer.Handler
{

	internal static class LoginZoneMessageListener
	{

		internal static void GetZoneListID(ConnectionInfo c)
		{
			//Console.WriteLine("LoginZoneMessageListener.GetZoneListID");
           // Console.WriteLine("GetZoneListID-> "+c.ar.bytesAvailable.ToString());

            GetZoneList req = new GetZoneList();
            Serial.Decrypt(c, ref req);
            
            ZoneListAck res = new ZoneListAck();
            
            res.zonelist = Zones.zones;

            //16 < 2147483569
            res.areaid = 1;
            res.curWorldNum = 0;
            res.enterZoneType = req.enterZoneType;
            res.totalWorldNum = (uint)Zones.zones.Count;
            
            Serial.Add(Proto.MessageConsts.ZoneListAckID,res , ref c);

		}

        internal static void EnterZoneRequestID(ConnectionInfo c)
        {
            //Console.WriteLine("LoginZoneMessageListener.EnterZoneRequestID");
            EnterZoneRequest req = new EnterZoneRequest();
            Serial.Decrypt(c, ref req);

            Players.LoadChar(req.charid);


            EnterZoneResponse res = new EnterZoneResponse();
            c.charid = req.charid;
            res.dgnresid = 0;// (uint)(Players.player(c).scene.ToString().StartsWith("8") ? Players.player(c).scene : 0);
            res.scene = 10010103;// (uint)Players.player(c).scene;



            res.info = Players.player(c);

            res.info.profession = 3100;
            res.info.crystalhistory = 10000;
            res.info.level = 15;
            res.info.bInfo.bFixedPay.amount = 10000;
            

            Serial.Add(Proto.MessageConsts.EnterZoneResponseID, res, ref c);


        }

        internal static void RpcID(ConnectionInfo c)
        {
           // Console.WriteLine("LoginZoneMessageListener.RpcID");


            Rpc req = new Rpc();
            Serial.Decrypt(c, ref req);


            RpcAck res = new RpcAck();
            RpcCommand.ParseCommand(ref c, ref req, ref res);


            if (res.name != "")
            {
                Serial.Add(Proto.MessageConsts.RpcAckID, res, ref c);
            }
            res = null;



        }
	}

}
