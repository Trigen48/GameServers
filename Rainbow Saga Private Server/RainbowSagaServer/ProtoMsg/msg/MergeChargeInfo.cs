using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MergeChargeInfo
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int ret{ get; set; }

		[ProtoMember(3)]
		public int giftId{ get; set; }

		[ProtoMember(4)]
		public int needCrystal{ get; set; }


		internal MergeChargeInfo()
		{
			this.type = 0;
			this.ret = 0;
			this.giftId = 0;
			this.needCrystal = 0;
		}

	}

}
