using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MonthFeedbackGiftUnit
	{

		[ProtoMember(1)]
		public int actvalue{ get; set; }

		[ProtoMember(2)]
		public int giftid{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }


		internal MonthFeedbackGiftUnit()
		{
			this.actvalue = 0;
			this.giftid = 0;
			this.num = 0;
		}

	}

}
