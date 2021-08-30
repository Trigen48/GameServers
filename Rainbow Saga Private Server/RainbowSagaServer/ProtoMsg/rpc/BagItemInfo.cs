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
	internal class BagItemInfo
	{

		[ProtoMember(1)]
		public int packageId{ get; set; }

		[ProtoMember(2)]
		public int slotId{ get; set; }

		[ProtoMember(3)]
		public Item item{ get; set; }

		[ProtoMember(5)]
		public int num{ get; set; }

		[ProtoMember(6)]
		public int totalId{ get; set; }

		[ProtoMember(7)]
		public int slotStatus{ get; set; }


		internal BagItemInfo()
		{
			this.packageId = 0;
			this.slotId = 0;
			this.item = new Item();
			this.num = 0;
			this.totalId = 0;
			this.slotStatus = 0;
		}

	}

}
