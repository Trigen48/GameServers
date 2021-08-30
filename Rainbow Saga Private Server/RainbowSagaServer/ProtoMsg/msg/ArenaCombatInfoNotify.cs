using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ArenaCombatInfoNotify
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public uint firstKill{ get; set; }

		[ProtoMember(3)]
		public uint firstDead{ get; set; }

		[ProtoMember(4)]
		public uint firstGather{ get; set; }

		[ProtoMember(5)]
		public List<PlayerCombatInfo> playerInfos{ get; set; }

		[ProtoMember(6)]
		public uint srcPlayerId{ get; set; }

		[ProtoMember(7)]
		public uint destPlayerId{ get; set; }

		[ProtoMember(8)]
		public uint leftTime{ get; set; }

		[ProtoMember(9)]
		public uint serialKills{ get; set; }

		[ProtoMember(10)]
		public int score{ get; set; }


		internal ArenaCombatInfoNotify()
		{
			this.op = 0;
			this.firstKill = 0;
			this.firstDead = 0;
			this.firstGather = 0;
			this.playerInfos = new List<PlayerCombatInfo>();
			this.srcPlayerId = 0;
			this.destPlayerId = 0;
			this.leftTime = 0;
			this.serialKills = 0;
			this.score = 0;
		}

	}

}
