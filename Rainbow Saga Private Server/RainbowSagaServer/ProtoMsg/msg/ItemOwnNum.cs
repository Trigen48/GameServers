using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ItemOwnNum
	{

		[ProtoMember(2)]
		public List<ItemOwnInfo> items{ get; set; }


		internal ItemOwnNum()
		{
			this.items = new List<ItemOwnInfo>();
		}

	}

}
