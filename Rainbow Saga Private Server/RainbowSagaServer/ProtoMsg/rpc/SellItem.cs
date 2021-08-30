using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SellItem
	{

		[ProtoMember(1)]
		public int pkg{ get; set; }

		[ProtoMember(2)]
		public int sid{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }


		internal SellItem()
		{
			this.pkg = 0;
			this.sid = 0;
			this.num = 0;
		}

	}

}
