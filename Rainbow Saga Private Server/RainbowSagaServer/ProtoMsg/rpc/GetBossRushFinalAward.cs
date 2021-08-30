using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetBossRushFinalAward
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal GetBossRushFinalAward()
		{
			this.ret = 0;
		}

	}

}
