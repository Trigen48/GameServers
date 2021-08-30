using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BeadsRankListResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int version{ get; set; }

		[ProtoMember(3)]
		public List<BeadsRankElement> beadsList{ get; set; }

		[ProtoMember(4)]
		public BeadsRankElement self{ get; set; }

		[ProtoMember(5)]
		public List<ActivityRankAward> award1{ get; set; }

		[ProtoMember(6)]
		public List<ActivityRankAward> award2{ get; set; }

		[ProtoMember(7)]
		public List<ActivityRankAward> award3{ get; set; }

		[ProtoMember(8)]
		public List<ActivityRankAward> award4{ get; set; }


		internal BeadsRankListResponse()
		{
			this.result = 0;
			this.version = 0;
			this.beadsList = new List<BeadsRankElement>();
			this.self = new BeadsRankElement();
			this.award1 = new List<ActivityRankAward>();
			this.award2 = new List<ActivityRankAward>();
			this.award3 = new List<ActivityRankAward>();
			this.award4 = new List<ActivityRankAward>();
		}

	}

}
