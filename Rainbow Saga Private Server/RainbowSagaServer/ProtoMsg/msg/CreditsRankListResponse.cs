using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CreditsRankListResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int version{ get; set; }

		[ProtoMember(3)]
		public List<CreditsRankElement> creditsList{ get; set; }

		[ProtoMember(4)]
		public CreditsRankElement self{ get; set; }

		[ProtoMember(5)]
		public List<ActivityRankAward> award1{ get; set; }

		[ProtoMember(6)]
		public List<ActivityRankAward> award2{ get; set; }

		[ProtoMember(7)]
		public List<ActivityRankAward> award3{ get; set; }


		internal CreditsRankListResponse()
		{
			this.result = 0;
			this.version = 0;
			this.creditsList = new List<CreditsRankElement>();
			this.self = new CreditsRankElement();
			this.award1 = new List<ActivityRankAward>();
			this.award2 = new List<ActivityRankAward>();
			this.award3 = new List<ActivityRankAward>();
		}

	}

}
