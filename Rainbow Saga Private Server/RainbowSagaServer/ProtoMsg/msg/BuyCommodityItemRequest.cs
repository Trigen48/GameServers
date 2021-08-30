using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BuyCommodityItemRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public int source{ get; set; }

		[ProtoMember(2)]
		public List<CommodityItem> items{ get; set; }

		[ProtoMember(3)]
		public uint amount{ get; set; }

		[ProtoMember(4)]
		public string target{ get; set; }


		internal BuyCommodityItemRequest()
		{
			this.source = 0;
			this.items = new List<CommodityItem>();
			this.amount = 0;
			this.target ="";
		}

	}

}
