using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class QuestRpc
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int t{ get; set; }

		[ProtoMember(3)]
		public int i{ get; set; }

		[ProtoMember(4)]
		public int id{ get; set; }

		[ProtoMember(5)]
		public int a0{ get; set; }

		[ProtoMember(6)]
		public int a1{ get; set; }

		[ProtoMember(7)]
		public int a2{ get; set; }

		[ProtoMember(8)]
		public int a3{ get; set; }

		[ProtoMember(9)]
		public int gm{ get; set; }


		internal QuestRpc()
		{
			this.op = 0;
			this.t = 0;
			this.i = 0;
			this.id = 0;
			this.a0 = 0;
			this.a1 = 0;
			this.a2 = 0;
			this.a3 = 0;
			this.gm = 0;
		}

	}

}
