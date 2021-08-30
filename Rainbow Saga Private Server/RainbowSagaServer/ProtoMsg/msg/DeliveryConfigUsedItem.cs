using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DeliveryConfigUsedItem
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int rate{ get; set; }

		[ProtoMember(3)]
		public int mincount{ get; set; }

		[ProtoMember(4)]
		public List<RewardItem> rewards{ get; set; }


		internal DeliveryConfigUsedItem()
		{
			this.id = 0;
			this.rate = 0;
			this.mincount = 0;
			this.rewards = new List<RewardItem>();
		}

	}

}
