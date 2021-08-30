using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class AddItem
	{

		[ProtoMember(1)]
		public int itemId{ get; set; }


		internal AddItem()
		{
			this.itemId = 0;
		}

	}

}
