using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class HoroscopesController
	{

		internal static void c17001(ConnectionInfo c)
		{

            c.ot.WriteByte(1);
            c.ot.WriteByte(c.Player.horoscope.trys);
            c.ot.WriteByte(c.Player.horoscope.type1);
            c.ot.WriteByte(c.Player.horoscope.star1);
            c.ot.WriteShort(c.Player.horoscope.bonus1);
            c.ot.WriteByte(c.Player.horoscope.type2);
            c.ot.WriteByte(c.Player.horoscope.star2);
            c.ot.WriteShort(c.Player.horoscope.bonus2);
            c.ot.WriteByte(c.Player.horoscope.type3);
            c.ot.WriteByte(c.Player.horoscope.star3);
            c.ot.WriteShort(c.Player.horoscope.bonus3);
            c.ot.WriteByte(c.Player.horoscope.luck);
            c.ot.PackArray(17001);
		}

		internal static void c17002(ConnectionInfo c)
		{

            byte res = 2;

            if (c.Player.horoscope.trys > 0)
            {
                if(c.Player.horoscope.trys<99) c.Player.horoscope.trys--;
                c.Player.horoscope.GenerateHoroscope();
                c.Player.horoscope.Save();
                res = 1;
                c.Player.combat.Compute();
            }
            else if (c.Player.bag.crystal > 1)
            {
                //c.Player.horoscope.trys--;
                c.Player.bag.crystal -= 2;
                c.Player.bag.Save();
                c.Player.horoscope.GenerateHoroscope();
                c.Player.horoscope.Save();
                res = 1;
                c.Player.combat.Compute();
            }
            else
            {
                res = 2;
            }


           c.ot.WriteByte(res);
           c.ot.WriteByte(c.Player.horoscope.trys);
           c.ot.WriteByte(c.Player.horoscope.type1);
           c.ot.WriteByte(c.Player.horoscope.star1);
           c.ot.WriteShort(c.Player.horoscope.bonus1);
           c.ot.WriteByte(c.Player.horoscope.type2);
           c.ot.WriteByte(c.Player.horoscope.star2);
           c.ot.WriteShort(c.Player.horoscope.bonus2);
           c.ot.WriteByte(c.Player.horoscope.type3);
           c.ot.WriteByte(c.Player.horoscope.star3);
           c.ot.WriteShort(c.Player.horoscope.bonus3);
           c.ot.WriteByte(c.Player.horoscope.luck);
           c.ot.PackArray(17002);
           
		}

		internal static void c17003(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"HoroscopesController 17003");

            int rid = c.ar.ReadInt();
            byte b = c.ar.ReadByte();

            RoleControl rl = Players.GetPlayer(rid);
            c.ot.WriteByte(1);
            c.ot.WriteByte(rl.horoscope.trys);
            c.ot.WriteByte(rl.horoscope.type1);
            c.ot.WriteByte(rl.horoscope.star1);
            c.ot.WriteShort(rl.horoscope.bonus1);
            c.ot.WriteByte(rl.horoscope.type2);
            c.ot.WriteByte(rl.horoscope.star2);
            c.ot.WriteShort(rl.horoscope.bonus2);
            c.ot.WriteByte(rl.horoscope.type3);
            c.ot.WriteByte(rl.horoscope.star3);
            c.ot.WriteShort(rl.horoscope.bonus3);
            c.ot.WriteByte(rl.horoscope.luck);
            c.ot.PackArray(17003);
		}

		internal static void c17010(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"HoroscopesController 17010");
			
			
		}

	}
}
