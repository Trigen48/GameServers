using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class AddBossRushTimes
	{

		[ProtoMember(1)]
		public int times{ get; set; }

		[ProtoMember(2)]
		public int ret{ get; set; }


		internal AddBossRushTimes()
		{
			this.times = 0;
			this.ret = 0;
		}

	}

}
