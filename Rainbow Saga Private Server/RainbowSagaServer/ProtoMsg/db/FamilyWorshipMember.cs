using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FamilyWorshipMember
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int profession{ get; set; }

		[ProtoMember(4)]
		public uint combatPower{ get; set; }

		[ProtoMember(5)]
		public int gender{ get; set; }

		[ProtoMember(6)]
		public EquipmentInventory bEquipon{ get; set; }

		[ProtoMember(7)]
		public int fashionEquiponPreDisplay{ get; set; }

		[ProtoMember(8)]
		public int wingDisplay{ get; set; }

		[ProtoMember(9)]
		public int skinType{ get; set; }

		[ProtoMember(10)]
		public int face{ get; set; }

		[ProtoMember(11)]
		public int hair{ get; set; }

		[ProtoMember(12)]
		public int away{ get; set; }

		[ProtoMember(13)]
		public FamilyWorshipMoney money{ get; set; }


		internal FamilyWorshipMember()
		{
			this.charid = 0;
			this.charname ="";
			this.profession = 0;
			this.combatPower = 0;
			this.gender = 0;
			this.bEquipon = new EquipmentInventory();
			this.fashionEquiponPreDisplay = 0;
			this.wingDisplay = 0;
			this.skinType = 0;
			this.face = 0;
			this.hair = 0;
			this.away = 0;
			this.money = new FamilyWorshipMoney();
		}

	}

}
