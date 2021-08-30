using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class BuyMysticStoreItemAck
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }


		internal BuyMysticStoreItemAck()
		{
			this.itemid = 0;
			this.result = 0;
		}

	}

}
