using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MicroGiftReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int grid{ get; set; }


		internal MicroGiftReq()
		{
			this.op = 0;
			this.grid = 0;
		}

	}

}
