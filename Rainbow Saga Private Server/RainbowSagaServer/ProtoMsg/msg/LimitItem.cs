using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LimitItem
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int count{ get; set; }

		[ProtoMember(3)]
		public int lastBuyTime{ get; set; }


		internal LimitItem()
		{
			this.id = 0;
			this.count = 0;
			this.lastBuyTime = 0;
		}

	}

}
