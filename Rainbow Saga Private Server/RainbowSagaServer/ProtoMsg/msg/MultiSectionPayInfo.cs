using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MultiSectionPayInfo
	{

		[ProtoMember(1)]
		public uint index{ get; set; }

		[ProtoMember(2)]
		public uint confAmount{ get; set; }

		[ProtoMember(3)]
		public uint giftid{ get; set; }

		[ProtoMember(4)]
		public uint status{ get; set; }


		internal MultiSectionPayInfo()
		{
			this.index = 0;
			this.confAmount = 0;
			this.giftid = 0;
			this.status = 0;
		}

	}

}
