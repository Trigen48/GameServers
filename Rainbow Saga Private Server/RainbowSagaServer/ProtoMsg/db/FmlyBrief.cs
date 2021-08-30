using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyBrief
	{

		[ProtoMember(1)]
		public long id{ get; set; }

		[ProtoMember(2)]
		public string name{ get; set; }

		[ProtoMember(3)]
		public int createtime{ get; set; }

		[ProtoMember(4)]
		public int modifytime{ get; set; }

		[ProtoMember(5)]
		public string leader{ get; set; }

		[ProtoMember(6)]
		public int lvl{ get; set; }

		[ProtoMember(18)]
		public int skillLvl{ get; set; }

		[ProtoMember(19)]
		public int shopLvl{ get; set; }

		[ProtoMember(7)]
		public int exp{ get; set; }

		[ProtoMember(15)]
		public int wealth{ get; set; }

		[ProtoMember(20)]
		public int lastConsumeTime{ get; set; }

		[ProtoMember(16)]
		public int lastUpgradeTime{ get; set; }

		[ProtoMember(8)]
		public string info{ get; set; }

		[ProtoMember(9)]
		public string notice{ get; set; }

		[ProtoMember(10)]
		public int strength{ get; set; }

		[ProtoMember(11)]
		public int membercount{ get; set; }

		[ProtoMember(12)]
		public FmlyRecommend recommend{ get; set; }

		[ProtoMember(13)]
		public int mycontri{ get; set; }

		[ProtoMember(21)]
		public int upgradeCd{ get; set; }

		[ProtoMember(22)]
		public int pos{ get; set; }


		internal FmlyBrief()
		{
			this.id = 0;
			this.name ="";
			this.createtime = 0;
			this.modifytime = 0;
			this.leader ="";
			this.lvl = 0;
			this.skillLvl = 0;
			this.shopLvl = 0;
			this.exp = 0;
			this.wealth = 0;
			this.lastConsumeTime = 0;
			this.lastUpgradeTime = 0;
			this.info ="";
			this.notice ="";
			this.strength = 0;
			this.membercount = 0;
			this.recommend = new FmlyRecommend();
			this.mycontri = 0;
			this.upgradeCd = 0;
			this.pos = 0;
		}

	}

}
