using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class MeditationController
	{

		internal static void c33001(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"MeditationController 33001");

            c.ot.WriteShort(5);
            c.ot.WriteShort(33001);
            c.ot.WriteByte(1);

            c.Player.role.rest = 1;
            c.currentScene.UpdateMeditate(c, 1);
		}

		internal static void c33002(ConnectionInfo c)
		{
			
          //  Program.Write(">Command invoked: " +"MeditationController 33002");
           
            c.ot.WriteShort(5);
            c.ot.WriteShort(33002);
            c.ot.WriteByte(1);
            c.Player.role.rest = 2;

            c.currentScene.UpdateMeditate(c, 2);
		}

	}
}
