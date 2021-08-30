using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetMopupConsumeInfoAck
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int times{ get; set; }

		[ProtoMember(3)]
		public int difficulty{ get; set; }

		[ProtoMember(4)]
		public int needEnergy{ get; set; }

		[ProtoMember(5)]
		public int currentEnergy{ get; set; }

		[ProtoMember(6)]
		public int needMoney{ get; set; }

		[ProtoMember(7)]
		public int needTime{ get; set; }

		[ProtoMember(8)]
		public int maxTimes{ get; set; }

		[ProtoMember(9)]
		public int needItemId{ get; set; }


		internal GetMopupConsumeInfoAck()
		{
			this.dgnid = 0;
			this.times = 0;
			this.difficulty = 0;
			this.needEnergy = 0;
			this.currentEnergy = 0;
			this.needMoney = 0;
			this.needTime = 0;
			this.maxTimes = 0;
			this.needItemId = 0;
		}

	}

}
