using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ActivityRankAward
	{

		[ProtoMember(1)]
		public int startRank{ get; set; }

		[ProtoMember(2)]
		public int endRank{ get; set; }

		[ProtoMember(3)]
		public int awardId{ get; set; }

		[ProtoMember(4)]
		public int awardNum{ get; set; }


		internal ActivityRankAward()
		{
			this.startRank = 0;
			this.endRank = 0;
			this.awardId = 0;
			this.awardNum = 0;
		}

	}

}
