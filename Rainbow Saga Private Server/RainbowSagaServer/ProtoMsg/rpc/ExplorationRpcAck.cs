using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ExplorationRpcAck
	{

		[ProtoMember(1)]
		public ExplorationRpc rpc{ get; set; }

		[ProtoMember(2)]
		public ExplorationInfo info{ get; set; }

		[ProtoMember(3)]
		public string curstep{ get; set; }


		internal ExplorationRpcAck()
		{
			this.rpc = new ExplorationRpc();
			this.info = new ExplorationInfo();
			this.curstep ="";
		}

	}

}
