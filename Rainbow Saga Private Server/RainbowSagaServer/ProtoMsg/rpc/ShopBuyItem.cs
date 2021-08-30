using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ShopBuyItem
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }

		[ProtoMember(3)]
		public int type{ get; set; }


		internal ShopBuyItem()
		{
			this.id = 0;
			this.num = 0;
			this.type = 0;
		}

	}

}
