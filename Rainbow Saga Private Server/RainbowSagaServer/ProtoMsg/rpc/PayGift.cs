using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PayGift
	{

		[ProtoMember(1)]
		public int giftid{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int type{ get; set; }


		internal PayGift()
		{
			this.giftid = 0;
			this.result = 0;
			this.type = 0;
		}

	}

}
