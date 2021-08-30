using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetMopupInfoAck
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int dgnid{ get; set; }

		[ProtoMember(3)]
		public int difficulty{ get; set; }

		[ProtoMember(4)]
		public int times{ get; set; }

		[ProtoMember(5)]
		public int finishtimes{ get; set; }

		[ProtoMember(6)]
		public int timeleft{ get; set; }

		[ProtoMember(7)]
		public int maxtimes{ get; set; }

		[ProtoMember(8)]
		public int needItemId{ get; set; }


		internal GetMopupInfoAck()
		{
			this.result = 0;
			this.dgnid = 0;
			this.difficulty = 0;
			this.times = 0;
			this.finishtimes = 0;
			this.timeleft = 0;
			this.maxtimes = 0;
			this.needItemId = 0;
		}

	}

}
