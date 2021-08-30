using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UsePillReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int itemId{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }


		internal UsePillReq()
		{
			this.op = 0;
			this.itemId = 0;
			this.num = 0;
		}

	}

}
