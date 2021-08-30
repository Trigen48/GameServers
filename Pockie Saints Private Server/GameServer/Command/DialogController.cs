using System;

using System.Collections;

namespace GameServer.Command
{
    
	internal static class DialogController
	{
        internal static byte[] Complete = new byte[] {1,3,1,1 };
		internal static void c32000(ConnectionInfo c)
		{
		//	Program.Write(">Command invoked: " +"DialogController 32000");
			

            int id=c.ar.ReadInt();

            c.ot.WriteInt(id);
            bool k1, k2;

            k1=c.Player.quest.NpcList.ContainsKey(id);
            k2=c.Player.quest.ANpcList.ContainsKey(id);

            if ( k1||k2 )
            {
                int co = 0;
                if (k1) co += c.Player.quest.NpcList[id].Count;

                if (k2)co += c.Player.quest.ANpcList[id].Count;
 
                c.ot.WriteShort(co);

                if (k1)
                {
                    foreach (int ky in c.Player.quest.NpcList[id])
                    {
                        c.ot.WriteInt(ky);
                        c.ot.WriteByte(Complete[c.Player.quest.Qlist[ky][id].complete]);
                    }
                }

                if (k2)
                {
                    foreach (int ky in c.Player.quest.ANpcList[id])
                    {
                        c.ot.WriteInt(ky);
                        c.ot.WriteByte(Complete[c.Player.quest.Alist[ky][id].complete]);
                    }
                }

            }
            else
            {
                c.ot.WriteShort(0);
            
            }



            if (World.World.InstanceDialogs.ContainsKey(id))
            {
                c.ot.WriteShort(World.World.InstanceDialogs[id].Length);

                for (byte i = 0; i < World.World.InstanceDialogs[id].Length; i++)
                {
                    c.ot.WriteShort(World.World.InstanceDialogs[id][i].Type);
                    c.ot.WriteString(World.World.InstanceDialogs[id][i].Dialog);
                }
            }
            else
            {
                c.ot.WriteShort(0);
            }

            c.ot.PackArray(32000);

			
		}

	}
}
