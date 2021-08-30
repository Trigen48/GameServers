using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PushGift
	{

		[ProtoMember(1)]
		public int giftid{ get; set; }


		internal PushGift()
		{
			this.giftid = 0;
		}

	}

}
