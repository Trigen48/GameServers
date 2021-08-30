using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetChargeRewardAck
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int ret{ get; set; }

		[ProtoMember(3)]
		public List<ChargeRewardInfo> chargeInfo{ get; set; }


		internal GetChargeRewardAck()
		{
			this.op = 0;
			this.ret = 0;
			this.chargeInfo = new List<ChargeRewardInfo>();
		}

	}

}
