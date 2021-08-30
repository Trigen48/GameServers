using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class LevelBuyOp
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }

		[ProtoMember(3)]
		public int result{ get; set; }

		[ProtoMember(4)]
		public int leftTime{ get; set; }

		[ProtoMember(5)]
		public LevelBuy levelBuy{ get; set; }


		internal LevelBuyOp()
		{
			this.type = 0;
			this.level = 0;
			this.result = 0;
			this.leftTime = 0;
			this.levelBuy = new LevelBuy();
		}

	}

}
