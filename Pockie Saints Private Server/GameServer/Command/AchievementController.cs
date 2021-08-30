using System;

using System.Collections.Generic;

namespace GameServer.Command
{

	internal static class AchievementController
	{

		internal static void c48000(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AchievementController 48000");


		}

		internal static void c48001(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AchievementController 48001");
			
			
		}

		internal static void c48002(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AchievementController 48002");

            /*int sh = c.ar.ReadShort();

            List<int> items = new List<int>();

            for (int x = 0; x < sh; x++)
            {
                items.Add(c.ar.ReadInt());
            }
            */
			
		}

        internal static void c48003(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AchievementController 48003");
			
			
		}

		internal static void c48004(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"AchievementController 48004");
			
			
		}

	}
}
