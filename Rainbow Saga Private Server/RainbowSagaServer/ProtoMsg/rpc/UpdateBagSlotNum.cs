using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateBagSlotNum
	{

		[ProtoMember(1)]
		public int packageId{ get; set; }

		[ProtoMember(2)]
		public int slotNum{ get; set; }

		[ProtoMember(3)]
		public int cryStal{ get; set; }


		internal UpdateBagSlotNum()
		{
			this.packageId = 0;
			this.slotNum = 0;
			this.cryStal = 0;
		}

	}

}
