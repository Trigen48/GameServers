using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class LevelGiftUnit
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public int giftid{ get; set; }

		[ProtoMember(3)]
		public int getitem{ get; set; }


		internal LevelGiftUnit()
		{
			this.level = 0;
			this.giftid = 0;
			this.getitem = 0;
		}

	}

}
