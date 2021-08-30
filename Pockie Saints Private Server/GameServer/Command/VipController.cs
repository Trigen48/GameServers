using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class VipController
	{

		internal static void c12051(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"VipController 12051");


			
		}

        internal static void c25001(ConnectionInfo c)
        {
            //  Program.Write(">Command invoked: " + "VipController 25001");
            byte a = 0;


            if (c.Player.vip.vip_level > 0)
            {
                if (c.Player.vip.claimpack == 0)
                {
                    a = c.Player.vip.ClaimVipPack(c);
                    if (a == 1)
                    {
                        c.Player.vip.claimpack = 1;
                        c.Player.vip.Save();
                    }
                }
                else
                {
                    a = 3;
                }
            }
            else
            {
                a = 2;
            }

            c.ot.WriteByte(a);
            c.ot.PackArray(25001);

  
        }

		internal static void c25002(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"VipController 25002");
			
			
		}

        internal static void c25003(ConnectionInfo c)
        {
           // c.Player.vip.Check(c);

            if (c.Player.vip.RunCheck(c))
            {
                c.ar = new ByteArray();
                c.ar.WriteByte(c.Player.vip.vip_level);
                c.ar.WriteInt(Vip.exps[c.Player.vip.vip_level]);
                c.ar.PackArray(25010);
                c.Player.Send(c.ar.GetByteArray());
                c.ar.Close();
                c.currentScene.UpdateChangeVip(c);
            }

            c.ot.WriteByte(1);
            c.ot.WriteByte(c.Player.vip.vip_level);
            c.ot.WriteInt(c.Player.vip.crystal);
            c.ot.WriteInt(c.Player.vip.time);
            c.ot.WriteByte(c.Player.vip.claimpack);
            c.ot.WriteByte(c.Player.vip.claimbuff);
            c.ot.WriteInt(Vip.exps[c.Player.vip.vip_level]);

   
            c.ot.PackArray(25003);
        }

		internal static void c25004(ConnectionInfo c)
		{
            //Program.Write(">Command invoked: " +"VipController 25004");

            c.Player.vip.GetClaims(c);
            c.ot.PackArray(25004);
		}

		internal static void c25005(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"VipController 25005");

            byte i = c.ar.ReadByte();

            if (c.Player.vip.CanClaim(i))
            {
                i--;
                if (c.Player.bag.CanBagAdd((byte)Vip.viprewards[i].items.Count))
                {

                    for (byte cx = 0; cx < Vip.viprewards[i].items.Count; cx++)
                    {
                        c.Player.bag.AddBagItem(
                            Vip.viprewards[i].items[cx][0],
                            (byte)Vip.viprewards[i].items[cx][1],
                            2);
                    }


                    c.Player.vip.claimstack[i] = 1;
                    c.ot.WriteByte(1);
                    c.Player.bag.bgold += Vip.viprewards[i].gold;
                    c.Player.bag.Save();
                    c.Player.vip.Save();
                }
                else
                {
                    c.ot.WriteByte(3);
                }
            }
            else
            {
                c.ot.WriteByte(0);
            }
            c.Player.vip.GetClaims(c);
            c.ot.PackArray(25005);
		}

		internal static void c25010(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"VipController 25010");
			
			
		}

	}
}
