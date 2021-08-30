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
	internal class AstrologyRpcAck
	{

		[ProtoMember(1)]
		public AstrologyRpc rpc{ get; set; }

		[ProtoMember(2)]
		public int ack{ get; set; }

		[ProtoMember(3)]
		public AstrologyData data{ get; set; }


		internal AstrologyRpcAck()
		{
			this.rpc = new AstrologyRpc();
			this.ack = 0;
			this.data = new AstrologyData();
		}

	}

}
