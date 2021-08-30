using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class BuffController
	{
        internal static byte[] GetBuff(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BuffController 15068");

            //int id = c.ar.ReadInt();
            

            if (c.Player != null)
            {
                ByteArray ot = new ByteArray();
                ot.WriteInt(c.rlid);
                ot.WriteShort(c.Player.buff.Buffs.Count);
                for (int i = 0; i < c.Player.buff.Buffs.Count; i++)
                {
                    ot.WriteInt(c.Player.buff.Buffs[i].Type);
                    ot.WriteInt(c.Player.buff.Buffs[i].EndTime);
                    ot.WriteInt(c.Player.buff.Buffs[i].StartTime);
                    ot.WriteInt(c.Player.buff.Buffs[i].Count);
                }
                ot.PackArray(15068);

                byte[] d = ot.GetByteArray();
                ot.Close();
                return d;
            }

            return null;
        }
		internal static void c15068(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"BuffController 15068");

            int id = c.ar.ReadInt();

            
            if (c.Player != null)
            {
                c.ot.WriteInt(id);
                c.ot.WriteShort(c.Player.buff.Buffs.Count);
                for (int i = 0; i < c.Player.buff.Buffs.Count; i++)
                {
                    c.ot.WriteInt(c.Player.buff.Buffs[i].Type);
                    c.ot.WriteInt(c.Player.buff.Buffs[i].EndTime);
                    c.ot.WriteInt(c.Player.buff.Buffs[i].StartTime);
                    c.ot.WriteInt(c.Player.buff.Buffs[i].Count);
                }
                c.ot.PackArray(15068);
            }

			
		}

		internal static void c15070(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuffController 15070");
			
			
		}

		internal static void c15071(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuffController 15071");
			
			
		}

	}
}
