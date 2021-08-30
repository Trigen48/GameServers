using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class CoMarketOpRpc
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public string source{ get; set; }

		[ProtoMember(3)]
		public int status{ get; set; }


		internal CoMarketOpRpc()
		{
			this.op = 0;
			this.source ="";
			this.status = 0;
		}

	}

}
