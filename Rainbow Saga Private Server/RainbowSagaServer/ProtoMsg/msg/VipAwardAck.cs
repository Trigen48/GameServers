using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class VipAwardAck
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int daily{ get; set; }

		[ProtoMember(3)]
		public int weekly{ get; set; }


		internal VipAwardAck()
		{
			this.op = 0;
			this.daily = 0;
			this.weekly = 0;
		}

	}

}
