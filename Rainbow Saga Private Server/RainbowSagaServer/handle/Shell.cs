using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;

namespace RainbowServer.Handler
{

	internal static class Shell
	{

		internal static void ClientErrorMsgInfoID(ConnectionInfo c)
		{
			Console.WriteLine("Shell.ClientErrorMsgInfoID");

            ClientErrorMsgInfo req = new ClientErrorMsgInfo();

            req =Serializer.Deserialize<ClientErrorMsgInfo>((new System.IO.MemoryStream((byte[])c.ar)));
            log.Save(new Exception(req.errorInfo+"\n Charid: "+req.charId.ToString()));

            c.CutConnection = true;
		}

		internal static void LoadingResStatisticsID(ConnectionInfo c)
		{
			Console.WriteLine("Shell.LoadingResStatisticsID");
			
			
		}


	}

}
