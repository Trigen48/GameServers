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
	internal class JoinArenaPlayer
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int profession{ get; set; }

		[ProtoMember(4)]
		public int level{ get; set; }

		[ProtoMember(6)]
		public int maxHp{ get; set; }

		[ProtoMember(8)]
		public int maxMp{ get; set; }

		[ProtoMember(9)]
		public int totalScore{ get; set; }

		[ProtoMember(10)]
		public int serverId{ get; set; }

		[ProtoMember(11)]
		public ArenaData arenaData{ get; set; }

		[ProtoMember(12)]
		public int worldid{ get; set; }

		[ProtoMember(13)]
		public int doubleHonour{ get; set; }

		[ProtoMember(14)]
		public int playerCombat{ get; set; }


		internal JoinArenaPlayer()
		{
			this.charid = 0;
			this.charname ="";
			this.profession = 0;
			this.level = 0;
			this.maxHp = 0;
			this.maxMp = 0;
			this.totalScore = 0;
			this.serverId = 0;
			this.arenaData = new ArenaData();
			this.worldid = 0;
			this.doubleHonour = 0;
			this.playerCombat = 0;
		}

	}

}
