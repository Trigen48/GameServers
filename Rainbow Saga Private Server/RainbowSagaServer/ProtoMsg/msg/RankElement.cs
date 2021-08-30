using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RankElement
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int money{ get; set; }

		[ProtoMember(4)]
		public int level{ get; set; }

		[ProtoMember(5)]
		public int exp{ get; set; }

		[ProtoMember(6)]
		public int levelTime{ get; set; }

		[ProtoMember(7)]
		public EquipmentInventory bEquipon{ get; set; }

		[ProtoMember(8)]
		public int hp{ get; set; }

		[ProtoMember(9)]
		public int mp{ get; set; }

		[ProtoMember(10)]
		public int str{ get; set; }

		[ProtoMember(11)]
		public int dex{ get; set; }

		[ProtoMember(12)]
		public int intl{ get; set; }

		[ProtoMember(13)]
		public int con{ get; set; }

		[ProtoMember(14)]
		public OffLineProp bOffLineProp{ get; set; }

		[ProtoMember(15)]
		public int profession{ get; set; }

		[ProtoMember(16)]
		public int fashionEquiponPreDisplay{ get; set; }

		[ProtoMember(17)]
		public int skinType{ get; set; }

		[ProtoMember(18)]
		public int hair{ get; set; }

		[ProtoMember(19)]
		public int face{ get; set; }

		[ProtoMember(20)]
		public int gender{ get; set; }

		[ProtoMember(21)]
		public int rank{ get; set; }

		[ProtoMember(22)]
		public int vipLevel{ get; set; }

		[ProtoMember(23)]
		public string familyName{ get; set; }

		[ProtoMember(24)]
		public string cpName{ get; set; }


		internal RankElement()
		{
			this.charid = 0;
			this.charname ="";
			this.money = 0;
			this.level = 0;
			this.exp = 0;
			this.levelTime = 0;
			this.bEquipon = new EquipmentInventory();
			this.hp = 0;
			this.mp = 0;
			this.str = 0;
			this.dex = 0;
			this.intl = 0;
			this.con = 0;
			this.bOffLineProp = new OffLineProp();
			this.profession = 0;
			this.fashionEquiponPreDisplay = 0;
			this.skinType = 0;
			this.hair = 0;
			this.face = 0;
			this.gender = 0;
			this.rank = 0;
			this.vipLevel = 0;
			this.familyName ="";
			this.cpName ="";
		}

	}

}
