using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SendRankInfoW2C
	{

		[ProtoMember(1)]
		public int combatPowerRank{ get; set; }

		[ProtoMember(2)]
		public int petRank{ get; set; }

		[ProtoMember(3)]
		public int levelRank{ get; set; }

		[ProtoMember(4)]
		public int fortuneRank{ get; set; }

		[ProtoMember(5)]
		public uint wingCombat{ get; set; }

		[ProtoMember(6)]
		public uint mountCombat{ get; set; }

		[ProtoMember(7)]
		public uint equipGemCombat{ get; set; }

		[ProtoMember(8)]
		public uint equipCombat{ get; set; }

		[ProtoMember(9)]
		public uint starAddCombat{ get; set; }


		internal SendRankInfoW2C()
		{
			this.combatPowerRank = 0;
			this.petRank = 0;
			this.levelRank = 0;
			this.fortuneRank = 0;
			this.wingCombat = 0;
			this.mountCombat = 0;
			this.equipGemCombat = 0;
			this.equipCombat = 0;
			this.starAddCombat = 0;
		}

	}

}
