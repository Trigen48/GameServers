using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ArenaRankData
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public ArenaData bArenaData{ get; set; }

		[ProtoMember(3)]
		public int type{ get; set; }

		[ProtoMember(4)]
		public int worldid{ get; set; }


		internal ArenaRankData()
		{
			this.charid = 0;
			this.bArenaData = new ArenaData();
			this.type = 0;
			this.worldid = 0;
		}

	}

}
