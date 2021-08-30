using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ChargeGifts
	{

		[ProtoMember(1)]
		public List<ChargeGift> chargeGift{ get; set; }


		internal ChargeGifts()
		{
			this.chargeGift = new List<ChargeGift>();
		}

	}

}
