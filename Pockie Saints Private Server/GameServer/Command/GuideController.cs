using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class GuideController
	{

		internal static void c13010(ConnectionInfo c)
		{
            ShortCutController.c13010(c);
		}

		internal static void c30010(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuideController 30010");
			
			
		}

        internal static void c30012(ConnectionInfo c)
        {
            if (c.Player.role.faction == 0)
            {
                byte x = c.ar.ReadByte();

                if (x == 0)
                {
                    ShuffleList<byte> fact = new ShuffleList<byte>();

                    fact.AddRange(new byte[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 });

                    fact.ShuffleInplace();
                    fact.ShuffleInplace();

                    x = fact.PopRandom();
                    fact.Clear();
                    fact = null;

                    c.Player.bag.AddBagItem(9010052, 1, 2);
                    //c.Player.bag.Save();
                }

                c.Player.role.faction = x;
                c.Player.quest.RemoveQtask(100026);
                c.Player.quest.AddTaskComplete(100026, 100009, 1, 1, 100);
                c.Player.role.Save();
                c.Player.quest.Save();

                c.ot.WriteShort(4);
                c.ot.WriteShort(30006);
                SceneController.UpdateNPC(c);
               //c.currentScene.UpdateFaction(c);
                c.currentScene.UpdateFaction(c);
                /*lock (Gameplay.PlayerNames.stats)
                {
                    Gameplay.PlayerNames.AddToFaction(c.rlid, x);
                    Gameplay.PlayerNames.Save();
                }*/
                //World.FactionData.RegFaction(c.rlid, x);
                c.ot.WriteShort(5);
                c.ot.WriteShort(13005);
                c.ot.WriteByte(2);
            }
        }

	}
}
