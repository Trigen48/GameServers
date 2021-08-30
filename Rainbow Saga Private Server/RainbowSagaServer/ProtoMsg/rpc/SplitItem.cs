using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SplitItem
	{

		[ProtoMember(1)]
		public int packageId{ get; set; }

		[ProtoMember(2)]
		public int slotId{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }


		internal SplitItem()
		{
			this.packageId = 0;
			this.slotId = 0;
			this.num = 0;
		}

	}

}
