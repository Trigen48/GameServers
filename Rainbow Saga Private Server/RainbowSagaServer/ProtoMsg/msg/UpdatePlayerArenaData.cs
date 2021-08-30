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
	internal class UpdatePlayerArenaData
	{

		[ProtoMember(1)]
		public uint playerId{ get; set; }

		[ProtoMember(2)]
		public ArenaData arenaData{ get; set; }

		[ProtoMember(3)]
		public int result{ get; set; }

		[ProtoMember(4)]
		public int addHonorPoints{ get; set; }

		[ProtoMember(5)]
		public int addScore{ get; set; }


		internal UpdatePlayerArenaData()
		{
			this.playerId = 0;
			this.arenaData = new ArenaData();
			this.result = 0;
			this.addHonorPoints = 0;
			this.addScore = 0;
		}

	}

}
