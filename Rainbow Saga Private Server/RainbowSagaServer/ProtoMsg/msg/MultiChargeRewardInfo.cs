using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MultiChargeRewardInfo
	{

		[ProtoMember(1)]
		public int startTime{ get; set; }

		[ProtoMember(2)]
		public int endTime{ get; set; }

		[ProtoMember(3)]
		public int giftId{ get; set; }

		[ProtoMember(4)]
		public int canGetCount{ get; set; }

		[ProtoMember(5)]
		public int gotCount{ get; set; }

		[ProtoMember(6)]
		public int crystal{ get; set; }


		internal MultiChargeRewardInfo()
		{
			this.startTime = 0;
			this.endTime = 0;
			this.giftId = 0;
			this.canGetCount = 0;
			this.gotCount = 0;
			this.crystal = 0;
		}

	}

}
