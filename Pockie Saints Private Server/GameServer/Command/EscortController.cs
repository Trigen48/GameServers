using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class EscortController
	{

		internal static void c31000(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"EscortController 31000");
			
			
		}

		internal static void c31001(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"EscortController 31001");

            c.ot.WriteByte(1);
            c.ot.WriteByte(c.Player.escort.escortQuality);
            c.ot.WriteByte(c.Player.escort.freeNum);
            c.ot.WriteByte(c.Player.escort.accNum);
            c.ot.WriteInt(c.Player.escort.time);
            c.ot.PackArray(31001);

		}

		internal static void c31002(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"EscortController 31002");
			// Change Quality
			
		}

		internal static void c31003(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"EscortController 31003");
			// Get Escort Task
			
		}

		internal static void c31004(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"EscortController 31004");
			// Send for help
			
		}

		internal static void c31005(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"EscortController 31005");
			// Complete Escort
			
		}

		internal static void c31010(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"EscortController 31010");
			// you were robbed
			
		}

	}
}
