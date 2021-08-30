using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ThrownItem
	{

		[ProtoMember(1)]
		public int packageId{ get; set; }

		[ProtoMember(2)]
		public int slotId{ get; set; }

		[ProtoMember(3)]
		public int x{ get; set; }

		[ProtoMember(4)]
		public int y{ get; set; }


		internal ThrownItem()
		{
			this.packageId = 0;
			this.slotId = 0;
			this.x = 0;
			this.y = 0;
		}

	}

}
