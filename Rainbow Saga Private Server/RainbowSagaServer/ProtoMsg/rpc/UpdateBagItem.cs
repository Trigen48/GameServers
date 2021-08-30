using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateBagItem
	{

		[ProtoMember(1)]
		public List<BagItemInfo> items{ get; set; }

		[ProtoMember(2)]
		public int gainType{ get; set; }


		internal UpdateBagItem()
		{
			this.items = new List<BagItemInfo>();
			this.gainType = 0;
		}

	}

}
