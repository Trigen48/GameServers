using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetActyItem
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int value{ get; set; }


		internal GetActyItem()
		{
			this.itemid = 0;
			this.value = 0;
		}

	}

}
