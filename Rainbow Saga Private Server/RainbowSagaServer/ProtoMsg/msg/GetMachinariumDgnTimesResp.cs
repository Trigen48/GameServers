using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetMachinariumDgnTimesResp
	{

		[ProtoMember(1)]
		public int times{ get; set; }

		[ProtoMember(2)]
		public int usedTimes{ get; set; }

		[ProtoMember(3)]
		public int buyTimes{ get; set; }


		internal GetMachinariumDgnTimesResp()
		{
			this.times = 0;
			this.usedTimes = 0;
			this.buyTimes = 0;
		}

	}

}
