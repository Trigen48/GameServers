using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class QuestRpcAck
	{

		[ProtoMember(1)]
		public QuestRpc rpc{ get; set; }

		[ProtoMember(2)]
		public int ack{ get; set; }

		[ProtoMember(3)]
		public int a0{ get; set; }

		[ProtoMember(4)]
		public int a1{ get; set; }


		internal QuestRpcAck()
		{
			this.rpc = new QuestRpc();
			this.ack = 0;
			this.a0 = 0;
			this.a1 = 0;
		}

	}

}
