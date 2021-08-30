using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class StoreItem
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int packageType{ get; set; }

		[ProtoMember(3)]
		public int slotId{ get; set; }

		[ProtoMember(4)]
		public int num{ get; set; }

		[ProtoMember(5)]
		public int storeSlotId{ get; set; }


		internal StoreItem()
		{
			this.type = 0;
			this.packageType = 0;
			this.slotId = 0;
			this.num = 0;
			this.storeSlotId = 0;
		}

	}

}
