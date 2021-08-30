using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TimeLimitDungeon
	{

		[ProtoMember(1)]
		public int dungeonid{ get; set; }

		[ProtoMember(2)]
		public int timesleft{ get; set; }

		[ProtoMember(3)]
		public int requiretime{ get; set; }

		[ProtoMember(4)]
		public List<TimeLimitAwardItem> awards{ get; set; }


		internal TimeLimitDungeon()
		{
			this.dungeonid = 0;
			this.timesleft = 0;
			this.requiretime = 0;
			this.awards = new List<TimeLimitAwardItem>();
		}

	}

}
