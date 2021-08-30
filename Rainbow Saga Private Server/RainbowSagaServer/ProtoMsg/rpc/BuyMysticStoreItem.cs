using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class BuyMysticStoreItem
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }


		internal BuyMysticStoreItem()
		{
			this.itemid = 0;
			this.type = 0;
		}

	}

}
