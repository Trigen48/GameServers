using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MultiGift
	{

		[ProtoMember(1)]
		public int itemId{ get; set; }

		[ProtoMember(2)]
		public int index{ get; set; }

		[ProtoMember(3)]
		public int ret{ get; set; }


		internal MultiGift()
		{
			this.itemId = 0;
			this.index = 0;
			this.ret = 0;
		}

	}

}
