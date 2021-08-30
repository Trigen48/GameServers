using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class TranController
	{
       // static byte xl = 0;
        internal static void c27001(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "TranController 27001");
            int id = c.ar.ReadInt();

            c.ot.WriteInt(id);
            c.ot.WriteString(Players.GetPlayer(id).role.name);
            c.ot.PackArray(27012);

        }

		internal static void c27002(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27002");
			
			
		}

		internal static void c27003(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27003");
			
			
		}

		internal static void c27004(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27004");
			
			
		}

		internal static void c27005(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27005");
			
			
		}

		internal static void c27006(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27006");
			
			
		}

		internal static void c27007(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27007");
			
			
		}

		internal static void c27008(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27008");
			
			
		}

		internal static void c27011(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27011");
			
			
		}

		internal static void c27012(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27012");
			
			
		}

		internal static void c27013(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"TranController 27013");
			
			
		}

	}
}
