using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BuyCommodityItemResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int source{ get; set; }

		[ProtoMember(5)]
		public int itemid{ get; set; }

		[ProtoMember(6)]
		public string charname{ get; set; }

		[ProtoMember(7)]
		public int amount{ get; set; }

		[ProtoMember(8)]
		public int beforeBalance{ get; set; }

		[ProtoMember(9)]
		public int afterBalance{ get; set; }

		[ProtoMember(10)]
		public int count{ get; set; }


		internal BuyCommodityItemResponse()
		{
			this.result = 0;
			this.source = 0;
			this.itemid = 0;
			this.charname ="";
			this.amount = 0;
			this.beforeBalance = 0;
			this.afterBalance = 0;
			this.count = 0;
		}

	}

}
