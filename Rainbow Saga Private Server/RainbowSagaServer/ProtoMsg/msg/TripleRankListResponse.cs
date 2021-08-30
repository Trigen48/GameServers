using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TripleRankListResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int version{ get; set; }

		[ProtoMember(3)]
		public List<TripleRankElement> tripleList{ get; set; }

		[ProtoMember(4)]
		public TripleRankElement self{ get; set; }

		[ProtoMember(5)]
		public List<ActivityRankAward> award1{ get; set; }

		[ProtoMember(6)]
		public List<ActivityRankAward> award2{ get; set; }

		[ProtoMember(7)]
		public List<ActivityRankAward> award3{ get; set; }

		[ProtoMember(8)]
		public List<ActivityRankAward> award4{ get; set; }


		internal TripleRankListResponse()
		{
			this.result = 0;
			this.version = 0;
			this.tripleList = new List<TripleRankElement>();
			this.self = new TripleRankElement();
			this.award1 = new List<ActivityRankAward>();
			this.award2 = new List<ActivityRankAward>();
			this.award3 = new List<ActivityRankAward>();
			this.award4 = new List<ActivityRankAward>();
		}

	}

}
