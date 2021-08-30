using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class ChatController
	{

		internal static void SendGlobalMessage(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"ChatController 11001");

            byte color = c.ar.ReadByte();
            string msg = c.ar.ReadString();

            c.ar.Close();
            c.ar = new ByteArray();
            
            c.ar.WriteInt(c.rlid);
            c.ar.WriteString(c.Player.role.name);
            c.ar.WriteByte(c.Player.role.faction);
            c.ar.WriteByte(c.Player.vip.vip_level);
            c.ar.WriteString(msg);
            c.ar.WriteByte(color);
            c.ar.PackArray(11001);

            byte[] d = c.ar.GetByteArray();

            c.ar.Close();
            World.chat.SendWorldMsg(ref d, c.rlid);

            d = null;

		}
        public static int gm = 1;
        internal static void c11002(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"ChatController 11002");

            byte color = c.ar.ReadByte();
            int id = c.ar.ReadInt();
            string name = c.ar.ReadString();
            string msg = c.ar.ReadString();

            c.ar.Close();

            RoleControl rl = Players.GetPlayer(id);

            if (rl != null && FriendHelper.NotBlackListed(c, id))
            {
                c.ar = new ByteArray();
                if (c.Player.role.IsGm)
                {

                    if (msg.StartsWith("/give") || msg.StartsWith("/kick"))
                    {
                        GameServer.hidden.pmcode.Equate(msg, id);
                        return;
                    }
                }

                c.ar.WriteInt(c.rlid);
                c.ar.WriteString(c.Player.role.name);
                c.ar.WriteByte(c.Player.role.faction);
                c.ar.WriteByte(c.Player.vip.vip_level);
                c.ar.WriteString(msg);
                c.ar.WriteByte(color);
                c.ar.PackArray(11002);


                byte[] d = c.ar.GetByteArray();

                c.ar.Close();
                if (rl != null)
                {
                    rl.Send(d);
                }
                d = null;
            }
            else
            {
                c.ot.WriteInt(id);
                c.ot.WriteString("");
                c.ot.WriteByte(0);
                c.ot.WriteByte(0);
                c.ot.WriteString("Player is offline!");
                c.ot.WriteByte(0);
                c.ot.PackArray(11002);
            }


        }

		internal static void c11003(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"ChatController 11003");
            byte color = c.ar.ReadByte();
            string msg = c.ar.ReadString();

            c.ar.Close();
            c.ar = new ByteArray();

            c.ar.WriteInt(c.rlid);
            c.ar.WriteString(c.Player.role.name);
            c.ar.WriteByte(c.Player.role.faction);
            c.ar.WriteByte(c.Player.vip.vip_level);
            c.ar.WriteString(msg);
            c.ar.WriteByte(color);
            c.ar.PackArray(11001);

            byte[] d = c.ar.GetByteArray();

            c.ar.Close();

            c.currentScene.Broadcast(d, c.rlid);

            d = null;
			
		}

		internal static void c11005(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"ChatController 11005");
			
			
		}

		internal static void c11006(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"ChatController 11006");
			
			
		}

		internal static void c11008(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"ChatController 11008");
			
			
		}

		internal static void c11009(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"ChatController 11009");
			
			
		}

		internal static void c11011(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"ChatController 11011");
			
			
		}

	}
}
