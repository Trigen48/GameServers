using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class BatchSellItem
	{

		[ProtoMember(1)]
		public List<SellItem> sellItems{ get; set; }

		[ProtoMember(2)]
		public int npcId{ get; set; }

		[ProtoMember(3)]
		public string npcName{ get; set; }


		internal BatchSellItem()
		{
			this.sellItems = new List<SellItem>();
			this.npcId = 0;
			this.npcName ="";
		}

	}

}
