using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class VipExtraInfo
	{

		[ProtoMember(1)]
		public int wheelLeftTimes{ get; set; }

		[ProtoMember(2)]
		public List<GiftCell> vipExtraGifts{ get; set; }

		[ProtoMember(3)]
		public int timeStamp{ get; set; }


		internal VipExtraInfo()
		{
			this.wheelLeftTimes = 0;
			this.vipExtraGifts = new List<GiftCell>();
			this.timeStamp = 0;
		}

	}

}
