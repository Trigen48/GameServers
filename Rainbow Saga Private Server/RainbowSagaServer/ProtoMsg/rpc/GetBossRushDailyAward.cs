using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetBossRushDailyAward
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal GetBossRushDailyAward()
		{
			this.ret = 0;
		}

	}

}
