using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class AutoFightController
	{

		internal static void c13017(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"AutoFightController 13017");

            c.ot.WriteShort(1);
            c.ot.WriteString(c.Player.auto.Output());
            c.ot.PackArray(13017);
			
		}

		internal static void c13018(ConnectionInfo c)
		{
		//	Program.Write(">Command invoked: " +"AutoFightController 13018");
            string l = c.ar.ReadString();
            c.Player.auto.Input(l);
            c.Player.auto.Save();

            c.ot.WriteShort(1);
            c.ot.PackArray(13018);


            c.ot.WriteShort(6);
            c.ot.WriteShort(13022);
            c.ot.WriteByte(c.Player.auto.hp);
            c.ot.WriteByte(c.Player.auto.mp);
        //    c.ot.PackArray(13022);
		}

	}
}
