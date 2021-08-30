using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetDropItem
	{

		[ProtoMember(1)]
		public Item item{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }


		internal GetDropItem()
		{
			this.item = new Item();
			this.num = 0;
		}

	}

}
