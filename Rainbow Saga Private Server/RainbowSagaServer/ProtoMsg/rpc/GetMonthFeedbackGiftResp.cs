using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetMonthFeedbackGiftResp
	{

		[ProtoMember(1)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public int giftType{ get; set; }


		internal GetMonthFeedbackGiftResp()
		{
			this.ret = 0;
			this.giftType = 0;
		}

	}

}
