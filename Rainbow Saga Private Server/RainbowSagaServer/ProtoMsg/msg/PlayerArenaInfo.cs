using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PlayerArenaInfo
	{

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int profession{ get; set; }

		[ProtoMember(4)]
		public int level{ get; set; }

		[ProtoMember(5)]
		public int combatPower{ get; set; }

		[ProtoMember(6)]
		public ArenaInfo extraInfo{ get; set; }

		[ProtoMember(7)]
		public EquipmentInventory bEquipon{ get; set; }

		[ProtoMember(8)]
		public string familyName{ get; set; }

		[ProtoMember(9)]
		public int arenaRank{ get; set; }

		[ProtoMember(10)]
		public int fashionEquiponPreDisplay{ get; set; }

		[ProtoMember(11)]
		public int maxHp{ get; set; }

		[ProtoMember(12)]
		public int maxMp{ get; set; }

		[ProtoMember(13)]
		public int serverId{ get; set; }

		[ProtoMember(14)]
		public ArenaData arenaData{ get; set; }

		[ProtoMember(15)]
		public int wingDisplay{ get; set; }


		internal PlayerArenaInfo()
		{
			this.charname ="";
			this.profession = 0;
			this.level = 0;
			this.combatPower = 0;
			this.extraInfo = new ArenaInfo();
			this.bEquipon = new EquipmentInventory();
			this.familyName ="";
			this.arenaRank = 0;
			this.fashionEquiponPreDisplay = 0;
			this.maxHp = 0;
			this.maxMp = 0;
			this.serverId = 0;
			this.arenaData = new ArenaData();
			this.wingDisplay = 0;
		}

	}

}
