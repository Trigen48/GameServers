using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UseItem
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }


		internal UseItem()
		{
			this.itemid = 0;
			this.num = 0;
		}

	}

}
