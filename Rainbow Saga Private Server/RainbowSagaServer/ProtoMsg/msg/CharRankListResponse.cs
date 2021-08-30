using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CharRankListResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int version{ get; set; }

		[ProtoMember(4)]
		public List<RankElement> charList{ get; set; }

		[ProtoMember(5)]
		public RankElement selfInfo{ get; set; }

		[ProtoMember(6)]
		public int selfRank{ get; set; }

		[ProtoMember(7)]
		public int page{ get; set; }

		[ProtoMember(8)]
		public RankElement prevChampion{ get; set; }

		[ProtoMember(9)]
		public int awardItem{ get; set; }

		[ProtoMember(10)]
		public int awardItem2{ get; set; }


		internal CharRankListResponse()
		{
			this.result = 0;
			this.type = 0;
			this.version = 0;
			this.charList = new List<RankElement>();
			this.selfInfo = new RankElement();
			this.selfRank = 0;
			this.page = 0;
			this.prevChampion = new RankElement();
			this.awardItem = 0;
			this.awardItem2 = 0;
		}

	}

}
