using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class TimeLimitDgnInDB
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int timesToday{ get; set; }

		[ProtoMember(3)]
		public int timesTodayUpdateTime{ get; set; }

		[ProtoMember(4)]
		public int totalTimes{ get; set; }

		[ProtoMember(5)]
		public int totalTimesUpdateTime{ get; set; }

		[ProtoMember(6)]
		public int haveAward{ get; set; }


		internal TimeLimitDgnInDB()
		{
			this.dgnid = 0;
			this.timesToday = 0;
			this.timesTodayUpdateTime = 0;
			this.totalTimes = 0;
			this.totalTimesUpdateTime = 0;
			this.haveAward = 0;
		}

	}

}
