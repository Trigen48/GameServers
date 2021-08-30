using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ChargeGift
	{

		[ProtoMember(1)]
		public int index{ get; set; }

		[ProtoMember(2)]
		public int gained{ get; set; }


		internal ChargeGift()
		{
			this.index = 0;
			this.gained = 0;
		}

	}

}
