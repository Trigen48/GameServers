using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TimeLimitDgnSucc
	{

		[ProtoMember(1)]
		public int dungeonid{ get; set; }

		[ProtoMember(2)]
		public int timeUsed{ get; set; }

		[ProtoMember(3)]
		public List<TimeLimitAwardItem> awards{ get; set; }


		internal TimeLimitDgnSucc()
		{
			this.dungeonid = 0;
			this.timeUsed = 0;
			this.awards = new List<TimeLimitAwardItem>();
		}

	}

}
