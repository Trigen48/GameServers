using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ItemXchgCfg
	{

		[ProtoMember(1)]
		public int needItem{ get; set; }

		[ProtoMember(2)]
		public List<ItemXchgItem> itemList{ get; set; }


		internal ItemXchgCfg()
		{
			this.needItem = 0;
			this.itemList = new List<ItemXchgItem>();
		}

	}

}
