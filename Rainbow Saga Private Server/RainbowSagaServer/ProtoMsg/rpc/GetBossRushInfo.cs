using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetBossRushInfo
	{

		[ProtoMember(1)]
		public BossRushInfo info{ get; set; }


		internal GetBossRushInfo()
		{
			this.info = new BossRushInfo();
		}

	}

}
