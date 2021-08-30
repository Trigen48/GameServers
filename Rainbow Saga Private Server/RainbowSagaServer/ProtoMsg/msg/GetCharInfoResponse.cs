using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.game;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetCharInfoResponse
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public int profession{ get; set; }

		[ProtoMember(3)]
		public string charName{ get; set; }

		[ProtoMember(4)]
		public int fashionEquiponPreDisplay{ get; set; }

		[ProtoMember(5)]
		public int skinType{ get; set; }

		[ProtoMember(6)]
		public int hair{ get; set; }

		[ProtoMember(7)]
		public int face{ get; set; }

		[ProtoMember(8)]
		public EquipmentInventory equipons{ get; set; }

		[ProtoMember(9)]
		public UnitProperties props{ get; set; }

		[ProtoMember(10)]
		public int hp{ get; set; }

		[ProtoMember(11)]
		public int mp{ get; set; }

		[ProtoMember(12)]
		public int gender{ get; set; }

		[ProtoMember(13)]
		public int result{ get; set; }

		[ProtoMember(14)]
		public string selfCharName{ get; set; }

		[ProtoMember(15)]
		public int vipLevel{ get; set; }

		[ProtoMember(16)]
		public string familyName{ get; set; }

		[ProtoMember(17)]
		public string coupleName{ get; set; }

		[ProtoMember(18)]
		public int rebornNum{ get; set; }


		internal GetCharInfoResponse()
		{
			this.level = 0;
			this.profession = 0;
			this.charName ="";
			this.fashionEquiponPreDisplay = 0;
			this.skinType = 0;
			this.hair = 0;
			this.face = 0;
			this.equipons = new EquipmentInventory();
			this.props = new UnitProperties();
			this.hp = 0;
			this.mp = 0;
			this.gender = 0;
			this.result = 0;
			this.selfCharName ="";
			this.vipLevel = 0;
			this.familyName ="";
			this.coupleName ="";
			this.rebornNum = 0;
		}

	}

}
