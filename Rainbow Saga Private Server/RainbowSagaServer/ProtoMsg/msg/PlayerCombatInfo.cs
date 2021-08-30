using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PlayerCombatInfo
	{

		[ProtoMember(1)]
		public uint playerId{ get; set; }

		[ProtoMember(2)]
		public uint connected{ get; set; }

		[ProtoMember(3)]
		public uint killNum{ get; set; }

		[ProtoMember(4)]
		public uint deadNum{ get; set; }

		[ProtoMember(5)]
		public uint gatherNum{ get; set; }

		[ProtoMember(6)]
		public uint score{ get; set; }

		[ProtoMember(7)]
		public uint honour{ get; set; }

		[ProtoMember(8)]
		public uint totalScore{ get; set; }

		[ProtoMember(9)]
		public uint isMvp{ get; set; }

		[ProtoMember(10)]
		public int result{ get; set; }

		[ProtoMember(11)]
		public int maxHp{ get; set; }

		[ProtoMember(12)]
		public int maxMp{ get; set; }

		[ProtoMember(13)]
		public int priesthoodBonus{ get; set; }


		internal PlayerCombatInfo()
		{
			this.playerId = 0;
			this.connected = 0;
			this.killNum = 0;
			this.deadNum = 0;
			this.gatherNum = 0;
			this.score = 0;
			this.honour = 0;
			this.totalScore = 0;
			this.isMvp = 0;
			this.result = 0;
			this.maxHp = 0;
			this.maxMp = 0;
			this.priesthoodBonus = 0;
		}

	}

}
