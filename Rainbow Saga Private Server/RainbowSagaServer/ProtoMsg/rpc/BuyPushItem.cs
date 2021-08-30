using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class BuyPushItem
	{

		[ProtoMember(1)]
		public int module{ get; set; }

		[ProtoMember(2)]
		public int ret{ get; set; }


		internal BuyPushItem()
		{
			this.module = 0;
			this.ret = 0;
		}

	}

}
