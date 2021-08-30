using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateBagItemProp
	{

		[ProtoMember(1)]
		public List<BagItemPropInfo> items{ get; set; }

		[ProtoMember(2)]
		public int gainType{ get; set; }


		internal UpdateBagItemProp()
		{
			this.items = new List<BagItemPropInfo>();
			this.gainType = 0;
		}

	}

}
