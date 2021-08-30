using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PlatStateReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }


		internal PlatStateReq()
		{
			this.op = 0;
		}

	}

}
