using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Fight1v1Ack
	{

		[ProtoMember(1)]
		public string toPlayer{ get; set; }

		[ProtoMember(2)]
		public string fromPlayer{ get; set; }

		[ProtoMember(3)]
		public int ret{ get; set; }

		[ProtoMember(4)]
		public int block{ get; set; }


		internal Fight1v1Ack()
		{
			this.toPlayer ="";
			this.fromPlayer ="";
			this.ret = 0;
			this.block = 0;
		}

	}

}
