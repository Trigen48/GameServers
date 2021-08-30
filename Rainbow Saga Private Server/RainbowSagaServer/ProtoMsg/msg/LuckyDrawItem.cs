using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LuckyDrawItem
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int itemid{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }


		internal LuckyDrawItem()
		{
			this.type = 0;
			this.itemid = 0;
			this.num = 0;
		}

	}

}
