using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CarReward
	{

		[ProtoMember(1)]
		public List<RewardItem> item{ get; set; }

		[ProtoMember(2)]
		public int money{ get; set; }

		[ProtoMember(3)]
		public int exp{ get; set; }


		internal CarReward()
		{
			this.item = new List<RewardItem>();
			this.money = 0;
			this.exp = 0;
		}

	}

}
