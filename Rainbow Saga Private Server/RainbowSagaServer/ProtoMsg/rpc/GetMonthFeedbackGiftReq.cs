using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetMonthFeedbackGiftReq
	{

		[ProtoMember(1)]
		public int type{ get; set; }


		internal GetMonthFeedbackGiftReq()
		{
			this.type = 0;
		}

	}

}
