using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetBossRushAward
	{

		[ProtoMember(1)]
		public int awardId{ get; set; }

		[ProtoMember(2)]
		public int ret{ get; set; }


		internal GetBossRushAward()
		{
			this.awardId = 0;
			this.ret = 0;
		}

	}

}
