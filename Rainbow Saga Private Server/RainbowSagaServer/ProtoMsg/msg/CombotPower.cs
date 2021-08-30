using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CombotPower
	{

		[ProtoMember(1)]
		public uint total{ get; set; }

		[ProtoMember(2)]
		public uint native{ get; set; }

		[ProtoMember(3)]
		public uint equip{ get; set; }

		[ProtoMember(4)]
		public uint gem{ get; set; }

		[ProtoMember(5)]
		public uint pet{ get; set; }

		[ProtoMember(6)]
		public uint family{ get; set; }

		[ProtoMember(7)]
		public uint others{ get; set; }

		[ProtoMember(8)]
		public uint equipLevel{ get; set; }

		[ProtoMember(9)]
		public uint equipStrength{ get; set; }

		[ProtoMember(10)]
		public uint equipEnchant{ get; set; }

		[ProtoMember(11)]
		public uint wingLevelUp{ get; set; }

		[ProtoMember(12)]
		public uint wingCard{ get; set; }

		[ProtoMember(13)]
		public uint wing{ get; set; }

		[ProtoMember(14)]
		public uint mountLevelUp{ get; set; }

		[ProtoMember(15)]
		public uint mountBless{ get; set; }

		[ProtoMember(16)]
		public uint mountCard{ get; set; }

		[ProtoMember(17)]
		public uint mount{ get; set; }

		[ProtoMember(18)]
		public uint star{ get; set; }

		[ProtoMember(19)]
		public uint pillChar{ get; set; }

		[ProtoMember(20)]
		public uint pillWing{ get; set; }

		[ProtoMember(21)]
		public uint pillMount{ get; set; }

		[ProtoMember(22)]
		public uint designation{ get; set; }

		[ProtoMember(23)]
		public uint magicSuit{ get; set; }

		[ProtoMember(24)]
		public uint priesthood{ get; set; }

		[ProtoMember(25)]
		public uint godship{ get; set; }

		[ProtoMember(26)]
		public uint dragonsoul{ get; set; }

		[ProtoMember(27)]
		public uint marriage{ get; set; }

		[ProtoMember(28)]
		public uint petsprite{ get; set; }

		[ProtoMember(29)]
		public uint mountEquip{ get; set; }

		[ProtoMember(30)]
		public uint magicsuitup{ get; set; }


		internal CombotPower()
		{
			this.total = 0;
			this.native = 0;
			this.equip = 0;
			this.gem = 0;
			this.pet = 0;
			this.family = 0;
			this.others = 0;
			this.equipLevel = 0;
			this.equipStrength = 0;
			this.equipEnchant = 0;
			this.wingLevelUp = 0;
			this.wingCard = 0;
			this.wing = 0;
			this.mountLevelUp = 0;
			this.mountBless = 0;
			this.mountCard = 0;
			this.mount = 0;
			this.star = 0;
			this.pillChar = 0;
			this.pillWing = 0;
			this.pillMount = 0;
			this.designation = 0;
			this.magicSuit = 0;
			this.priesthood = 0;
			this.godship = 0;
			this.dragonsoul = 0;
			this.marriage = 0;
			this.petsprite = 0;
			this.mountEquip = 0;
			this.magicsuitup = 0;
		}

	}

}
