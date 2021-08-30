using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class ShortCutController
	{

		internal static void c13007(ConnectionInfo c)
		{
            c.ot.WriteShort(c.Player.shortcut.shortcut.Count);
            for (byte i = 0; i < c.Player.shortcut.shortcut.Count; i++)
            {
                c.ot.WriteByte(c.Player.shortcut.shortcut[i].index);
                c.ot.WriteByte(c.Player.shortcut.shortcut[i].type);
                c.ot.WriteInt(c.Player.shortcut.shortcut[i].Itemid);
            }


            c.ot.PackArray(13007);
			
		}

		internal static void c13008(ConnectionInfo c)
		{

            byte i=c.ar.ReadByte();
            byte t=c.ar.ReadByte();
            int id=c.ar.ReadInt();

            if (c.Player.shortcut.Add(i, id, t))
            { 
                c.ot.WriteByte(1);
               // c.Player.shortcut.Save(c);
            }
            else
            {
                c.ot.WriteByte(2);
            }
            c.ot.PackArray(13008);

		}

		internal static void c13009(ConnectionInfo c)
		{

            if (c.Player.shortcut.Remove(c.ar.ReadByte()))
            {
                c.ot.WriteByte(1);
                //c.Player.shortcut.Save(c);
            }
            else
            {
                c.ot.WriteByte(2);
            }
            c.ot.PackArray(13009);

		}

		internal static void c13010(ConnectionInfo c)
		{

            if (c.Player.shortcut.Swap(c.ar.ReadByte(), c.ar.ReadByte()))
            {       
                c.ot.WriteByte(1);
                //c.Player.shortcut.Save(c);
            }
            else
            {
                c.ot.WriteByte(2);
            }

            c.ot.PackArray(13010);

		}


	}
}
