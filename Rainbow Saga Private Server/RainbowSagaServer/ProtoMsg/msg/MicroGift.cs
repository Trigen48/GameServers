using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MicroGift
	{

		[ProtoMember(1)]
		public int leftTimes{ get; set; }

		[ProtoMember(2)]
		public List<GiftGrid> grids{ get; set; }

		[ProtoMember(3)]
		public int dayTime{ get; set; }

		[ProtoMember(4)]
		public GiftGrid currBingo{ get; set; }


		internal MicroGift()
		{
			this.leftTimes = 0;
			this.grids = new List<GiftGrid>();
			this.dayTime = 0;
			this.currBingo = new GiftGrid();
		}

	}

}
