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
	internal class UpdatePlayerProperty
	{

		[ProtoMember(1)]
		public UnitProperties final{ get; set; }

		[ProtoMember(2)]
		public UnitProperties native{ get; set; }

		[ProtoMember(3)]
		public UnitProperties skill{ get; set; }

		[ProtoMember(4)]
		public UnitProperties equip{ get; set; }

		[ProtoMember(8)]
		public CombotPower combotPower{ get; set; }

		[ProtoMember(5)]
		public uint mask1{ get; set; }

		[ProtoMember(6)]
		public uint mask2{ get; set; }

		[ProtoMember(7)]
		public uint flag{ get; set; }


		internal UpdatePlayerProperty()
		{
			this.final = new UnitProperties();
			this.native = new UnitProperties();
			this.skill = new UnitProperties();
			this.equip = new UnitProperties();
			this.combotPower = new CombotPower();
			this.mask1 = 0;
			this.mask2 = 0;
			this.flag = 0;
		}

	}

}
