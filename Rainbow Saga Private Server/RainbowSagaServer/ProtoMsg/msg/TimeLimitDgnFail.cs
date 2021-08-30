using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TimeLimitDgnFail
	{

		[ProtoMember(1)]
		public int dungeonid{ get; set; }


		internal TimeLimitDgnFail()
		{
			this.dungeonid = 0;
		}

	}

}
