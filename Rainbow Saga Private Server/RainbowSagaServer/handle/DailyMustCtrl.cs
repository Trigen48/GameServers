using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;

namespace RainbowServer.Handler
{

	internal static class DailyMustCtrl
	{

		internal static void SetAutoPlayInfoID(ConnectionInfo c)
		{
			Console.WriteLine("DailyMustCtrl.SetAutoPlayInfoID");
			
			
		}

		internal static void ClearAutoPlayInfoID(ConnectionInfo c)
		{
			Console.WriteLine("DailyMustCtrl.ClearAutoPlayInfoID");
			
			
		}

		internal static void GetAutoPlayInfoReqID(ConnectionInfo c)
		{
			Console.WriteLine("DailyMustCtrl.GetAutoPlayInfoReqID");

            GetAutoPlayInfoReq req = new GetAutoPlayInfoReq();
            Serial.Decrypt(c, ref req);

            GetAutoPlayInfoAck res = new GetAutoPlayInfoAck();
            res.infos.Add(new AutoPlayDisplayInfo());

            res.infos[0].crystal = 5000;
            res.infos[0].param = 1;
            res.infos[0].selected = 3;
            res.infos[0].status = 1;
            res.infos[0].type = 1;

            /*UpdatePlayerProperty ress = new UpdatePlayerProperty();

            //  ress.equip = Players.players[req.charid].props;
            ress.final = Players.Get(c).props;
            ress.final.walkSpeed = 210;
            ress.final.con = 10;
            ress.final.deceleration = 1;
            ress.final.poir = 1;

            ress.flag = 1;
            Serial.Add(Proto.MessageConsts.UpdatePlayerPropertyID, ress, ref c);*/

          //  Proto.MessageConsts.SendUnitPropertyID
            Serial.Add(Proto.MessageConsts.GetAutoPlayInfoAckID, res, ref c);
		}

		internal static void GetActivityStatusReqID(ConnectionInfo c)
		{
			Console.WriteLine("DailyMustCtrl.GetActivityStatusReqID");
			
			
		}

		internal static void GetTowerMopInfoReqID(ConnectionInfo c)
		{
			Console.WriteLine("DailyMustCtrl.GetTowerMopInfoReqID");
			
			
		}


	}

}
