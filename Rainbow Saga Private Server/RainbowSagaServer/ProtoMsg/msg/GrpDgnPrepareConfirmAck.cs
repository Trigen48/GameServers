using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GrpDgnPrepareConfirmAck
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int seqid{ get; set; }

		[ProtoMember(3)]
		public int ready{ get; set; }


		internal GrpDgnPrepareConfirmAck()
		{
			this.dgnid = 0;
			this.seqid = 0;
			this.ready = 0;
		}

	}

}
