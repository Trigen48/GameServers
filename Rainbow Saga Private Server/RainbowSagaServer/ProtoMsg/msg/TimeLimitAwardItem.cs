using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TimeLimitAwardItem
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }


		internal TimeLimitAwardItem()
		{
			this.itemid = 0;
			this.num = 0;
		}

	}

}
