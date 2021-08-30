using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class BackwardBossRushLevel
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal BackwardBossRushLevel()
		{
			this.ret = 0;
		}

	}

}
