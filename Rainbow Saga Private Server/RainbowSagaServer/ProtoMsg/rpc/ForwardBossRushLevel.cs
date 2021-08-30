using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ForwardBossRushLevel
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal ForwardBossRushLevel()
		{
			this.ret = 0;
		}

	}

}
