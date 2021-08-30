using System;
using System.Data.SqlClient;
using System.Collections;

namespace GameServer.Command
{

	internal static class GatewayController
	{

		internal static void c60000(ConnectionInfo c)
		{
			Console.WriteLine(">Command invoked: " +"GatewayController 60000");
			
			
		}

		internal static void c60001(ConnectionInfo c)
		{
			Console.WriteLine(">Command invoked: " +"GatewayController 60001");
			
			
		}

	}
}
