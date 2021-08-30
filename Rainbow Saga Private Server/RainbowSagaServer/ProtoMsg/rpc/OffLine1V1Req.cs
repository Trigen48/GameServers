using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class OffLine1V1Req
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int oppCharid{ get; set; }

		[ProtoMember(3)]
		public int oppRank{ get; set; }


		internal OffLine1V1Req()
		{
			this.op = 0;
			this.oppCharid = 0;
			this.oppRank = 0;
		}

	}

}
