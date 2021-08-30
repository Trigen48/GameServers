using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TimeLimitDgnStart
	{

		[ProtoMember(1)]
		public int dungeonid{ get; set; }

		[ProtoMember(2)]
		public int lefttime{ get; set; }

		[ProtoMember(3)]
		public int countdown{ get; set; }


		internal TimeLimitDgnStart()
		{
			this.dungeonid = 0;
			this.lefttime = 0;
			this.countdown = 0;
		}

	}

}
