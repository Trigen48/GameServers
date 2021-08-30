using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FamilyManorDungeonInform
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public long familyId{ get; set; }

		[ProtoMember(3)]
		public int familyPetLv{ get; set; }

		[ProtoMember(4)]
		public List<FamilyManorTowerInfo> towerInfos{ get; set; }

		[ProtoMember(5)]
		public int lifes{ get; set; }

		[ProtoMember(6)]
		public uint srcPlayerId{ get; set; }

		[ProtoMember(7)]
		public uint destPlayerId{ get; set; }

		[ProtoMember(8)]
		public uint serialKills{ get; set; }

		[ProtoMember(9)]
		public uint fastKills{ get; set; }

		[ProtoMember(10)]
		public uint totalKills{ get; set; }

		[ProtoMember(11)]
		public int assaulterNum{ get; set; }

		[ProtoMember(12)]
		public int defenderNum{ get; set; }

		[ProtoMember(13)]
		public int familyPetHp{ get; set; }

		[ProtoMember(14)]
		public int familyPetMaxHp{ get; set; }

		[ProtoMember(20)]
		public int activityTime{ get; set; }

		[ProtoMember(21)]
		public int serverTime{ get; set; }

		[ProtoMember(22)]
		public int activityDuration{ get; set; }

		[ProtoMember(23)]
		public int manorId{ get; set; }

		[ProtoMember(24)]
		public string familyName{ get; set; }


		internal FamilyManorDungeonInform()
		{
			this.op = 0;
			this.familyId = 0;
			this.familyPetLv = 0;
			this.towerInfos = new List<FamilyManorTowerInfo>();
			this.lifes = 0;
			this.srcPlayerId = 0;
			this.destPlayerId = 0;
			this.serialKills = 0;
			this.fastKills = 0;
			this.totalKills = 0;
			this.assaulterNum = 0;
			this.defenderNum = 0;
			this.familyPetHp = 0;
			this.familyPetMaxHp = 0;
			this.activityTime = 0;
			this.serverTime = 0;
			this.activityDuration = 0;
			this.manorId = 0;
			this.familyName ="";
		}

	}

}
