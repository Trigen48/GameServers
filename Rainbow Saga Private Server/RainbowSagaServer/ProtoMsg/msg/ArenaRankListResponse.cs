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
	internal class ArenaRankListResponse
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int page{ get; set; }

		[ProtoMember(3)]
		public List<ArenaRankData> rankData{ get; set; }

		[ProtoMember(4)]
		public int recordNum{ get; set; }


		internal ArenaRankListResponse()
		{
			this.type = 0;
			this.page = 0;
			this.rankData = new List<ArenaRankData>();
			this.recordNum = 0;
		}

	}

}
