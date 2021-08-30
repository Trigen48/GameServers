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
	internal class BagItemPropInfo
	{

		[ProtoMember(1)]
		public int packageId{ get; set; }

		[ProtoMember(2)]
		public int slotId{ get; set; }

		[ProtoMember(3)]
		public Item item{ get; set; }


		internal BagItemPropInfo()
		{
			this.packageId = 0;
			this.slotId = 0;
			this.item = new Item();
		}

	}

}
