using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;


namespace RainbowServer.Handler
{

    internal static class PacketSender
    {

        internal static void SyncActionID(ConnectionInfo c)
        {
            //Console.WriteLine("PacketSender.SyncActionID");

            SyncAction req = new SyncAction();
            Serial.Decrypt(c, ref req);


            //req.
            Players.Get(c).player.xpos = req.foothold;
            Players.Get(c).player.ypos = req.vy;


        }

        internal static void SyncPetActionID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.SyncPetActionID");


        }

        internal static void SkillStartID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.SkillStartID");


        }

        internal static void OperateReactorID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.OperateReactorID");


        }

        internal static void ChangeSceneRequestID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.ChangeSceneRequestID");


        }

        internal static void TeleportRequestID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.TeleportRequestID");


        }

        internal static void ChangeSceneAckID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.ChangeSceneAckID");


        }

        internal static void EnterZoneAckID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.EnterZoneAckID");
            EnterZoneAck req = new EnterZoneAck();

            Serial.Decrypt(c, ref req);

            // DungeonPlayerInfo p = new DungeonPlayerInfo();

             UpdatePlayerProperty prop = new UpdatePlayerProperty();
             prop.final = Players.Get(c).props;
            
             prop.final.walkSpeed = 200;
             prop.final.maxHp = 600;
             prop.final.maxMp = 300;
             prop.final.hpIncrease = 10;
             prop.final.hpIncrRate = 20;
             prop.final.maxHpRate = 30;

             prop.final.walkSpeed = 200;
             prop.native.walkSpeed = 200;
             prop.flag = 1;


            // 
             Serial.Add(Proto.MessageConsts.UpdatePlayerPropertyID, prop, ref c);

            SyncAck res = new SyncAck();

            res.dead.deathState = 0;
            res.direction.dir = 0;
            res.speed.walk = 180;
            res.speed.fly = 180;

            res.unitId = c.charid;
            res.unitType = 3;
            res.eventType = 18;



            Serial.Add(Proto.MessageConsts.SyncAckID, res, ref c);


            ReplicaInform rp = new ReplicaInform();
            rp.sceneId = 10010103;
            MobReplicaInfo mb = new MobReplicaInfo();
            mb.hp = 5;
            mb.maxHp = 5;
            mb.walkSpeed = 60;
            mb.unitId = 10010001;
            mb.gid = 10010001;
            mb.familyId = 10010001;
            mb.spawn = 10010001;
            mb.propId = 10010001;
            mb.x = 533;
            mb.y = 867;

            //533;
                // 867;

            rp.appear.mobs.Add(mb);

            // PlayerReplicaInfo pl = new PlayerReplicaInfo();
            //  pl.speed
            Serial.Add(Proto.MessageConsts.ReplicaInformID, rp, ref c);
        }

        internal static void SwitchZoneRequestID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.SwitchZoneRequestID");


        }

        internal static void PetJoinBattleRequestID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.PetJoinBattleRequestID");


        }

        internal static void PetDismissRequestID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.PetDismissRequestID");


        }

        internal static void PetRespawnRequestID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.PetRespawnRequestID");


        }

        internal static void PetListRequestID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.PetListRequestID");


        }

        internal static void ValidateCharNameRequestID(ConnectionInfo c)
        {
            Console.WriteLine("PacketSender.ValidateCharNameRequestID");


        }


    }

}
