using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyWorldBossRankList
	{

		[ProtoMember(1)]
		public int totalhp{ get; set; }

		[ProtoMember(2)]
		public WorldBossRank myrank{ get; set; }

		[ProtoMember(3)]
		public List<WorldBossRank> infos{ get; set; }


		internal NotifyWorldBossRankList()
		{
			this.totalhp = 0;
			this.myrank = new WorldBossRank();
			this.infos = new List<WorldBossRank>();
		}

	}

}
