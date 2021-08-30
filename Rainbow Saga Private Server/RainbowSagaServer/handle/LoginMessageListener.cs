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

	internal static class LoginMessageListener
	{
        /*
        internal static void TuneChar(ref CharInfo b)
        {
            b.face = 19505059;
            b.hair = 19005059;
           
            b.accname = "Donking";
            b.afkOfflinetime = (int)DateUtil.GetDateIntZone();
            b.aid = 1;
            b.bindCrystal = 600;
            b.charid = 1;
            b.charname = "Donex";
            b.lastzoneid = 65535;
            b.fashionEquiponPreDisplay = 1;
            b.gender = 1;
            b.profession = 1;
            
            b.hp = 600;
            b.hpPool=600;
            b.mp = 600;
            b.mpPool = 600;
            b.level = 969;
            b.bInfo.bEquip.slotNum = 20;


            b.profession = 1;
            b.bEquipon.bFoDisplay = 3;
            b.profession = 1100;
            EquipmentSlot q = new EquipmentSlot();
            q.equipSlot = "Fn";
            q.equipItem.remaining = 0;
            q.equipItem.quality = 4;
            q.equipItem.itemname = "10001149";
            q.equipItem.id = 10001149;
            q.equipItem.uuid = 10001149;
            b.bEquipon.equips.Add(q);

            q = new EquipmentSlot();
            q.equipSlot = "Cp";
            q.equipItem.remaining = 0;
            q.equipItem.quality = 4;
            q.equipItem.itemname = "10500010";
            q.equipItem.id = 10500010;
            q.equipItem.uuid = 1;
            b.bEquipon.equips.Add(q);

            q = new EquipmentSlot();
            q.equipSlot = "Fm";
            q.equipItem.remaining = 0;
            q.equipItem.quality = 4;
            q.equipItem.itemname = "11500019";
            q.equipItem.id = 11500019;
            q.equipItem.uuid = 11500019;
            b.bEquipon.equips.Add(q);

            //b.bEquipon = null;
            b.bInfo = null;
            b.bEquipon.bFoDisplay = 0;
           
        }
        */
		internal static void QueryCharInfoRequestID(ConnectionInfo c)
		{
			//Console.WriteLine("LoginMessageListener.QueryCharInfoRequestID");

            QueryCharInfoRequest req = new QueryCharInfoRequest();
            Serial.Decrypt(c, ref req);

            QueryCharInfoResponse res;
            res = Players.GetProfiles(ref req, ref c);

            Serial.Add(Proto.MessageConsts.QueryCharInfoResponseID,res , ref c);
		}

		internal static void LoginRequestID(ConnectionInfo c)
		{
			//Console.WriteLine("LoginMessageListener.LoginRequestID");

           // GetCharInfoRequest req = new GetCharInfoRequest();

            if (c.AccName == "")
            {
                LoginRequest req = new LoginRequest();
                Serial.Decrypt(c, ref req);
                c.ar = null;

                LoginResponse res;
                res = Accounts.GetLogin(ref req);


                if (res.result != 0)
                {
                    c.CutConnection = true;
                }
                else
                {
                    c.AccName = res.username;
                    res.sessionId = (int)c.SessionID;
                }
                
                Serial.Add(Proto.MessageConsts.LoginResponseID, res, ref c);
            }
            else
            {
                Rpc reqq = new Rpc();
                Serial.Decrypt(c, ref reqq);


                RpcAck resp = new RpcAck();
                RpcCommand.ParseCommand(ref c, ref reqq, ref resp);


                if (resp.name != "")
                {
                    Serial.Add(Proto.MessageConsts.RpcAckID, resp, ref c);
                }
                resp = null;
            }
		}


	}

}
