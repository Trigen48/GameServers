using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ActivityData
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public List<ActivityQuestChain> quests{ get; set; }

		[ProtoMember(3)]
		public int exp{ get; set; }

		[ProtoMember(4)]
		public int money{ get; set; }

		[ProtoMember(5)]
		public int item{ get; set; }

		[ProtoMember(6)]
		public int ver{ get; set; }

		[ProtoMember(7)]
		public int num{ get; set; }


		internal ActivityData()
		{
			this.id = 0;
			this.quests = new List<ActivityQuestChain>();
			this.exp = 0;
			this.money = 0;
			this.item = 0;
			this.ver = 0;
			this.num = 0;
		}

	}

}
