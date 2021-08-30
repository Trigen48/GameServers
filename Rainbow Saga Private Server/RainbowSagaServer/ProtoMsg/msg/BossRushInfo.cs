using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BossRushInfo
	{

		[ProtoMember(1)]
		public int leftTimes{ get; set; }

		[ProtoMember(2)]
		public int skeletonNum{ get; set; }

		[ProtoMember(3)]
		public List<BossRushCard> cards{ get; set; }

		[ProtoMember(4)]
		public int openAwardIds{ get; set; }

		[ProtoMember(5)]
		public int dailyAwarded{ get; set; }

		[ProtoMember(6)]
		public int finalAwarded{ get; set; }

		[ProtoMember(7)]
		public int level{ get; set; }

		[ProtoMember(8)]
		public int fightCardId{ get; set; }


		internal BossRushInfo()
		{
			this.leftTimes = 0;
			this.skeletonNum = 0;
			this.cards = new List<BossRushCard>();
			this.openAwardIds = 0;
			this.dailyAwarded = 0;
			this.finalAwarded = 0;
			this.level = 0;
			this.fightCardId = 0;
		}

	}

}
