using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AddToGrpDgnQueueAck
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }


		internal AddToGrpDgnQueueAck()
		{
			this.dgnid = 0;
			this.result = 0;
		}

	}

}
