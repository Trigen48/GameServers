using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BuyLimitItemRequest
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }


		internal BuyLimitItemRequest()
		{
			this.itemid = 0;
		}

	}

}
