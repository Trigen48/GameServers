using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class BatchBuyItem
	{

		[ProtoMember(1)]
		public List<BuyItem> buyItems{ get; set; }

		[ProtoMember(2)]
		public int npcId{ get; set; }

		[ProtoMember(3)]
		public string npcName{ get; set; }


		internal BatchBuyItem()
		{
			this.buyItems = new List<BuyItem>();
			this.npcId = 0;
			this.npcName ="";
		}

	}

}
