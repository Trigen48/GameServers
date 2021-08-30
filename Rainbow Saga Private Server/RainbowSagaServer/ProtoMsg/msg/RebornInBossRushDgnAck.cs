using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RebornInBossRushDgnAck
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal RebornInBossRushDgnAck()
		{
			this.ret = 0;
		}

	}

}
