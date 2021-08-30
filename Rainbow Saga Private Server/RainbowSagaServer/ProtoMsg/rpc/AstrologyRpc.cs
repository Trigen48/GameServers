using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class AstrologyRpc
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int args{ get; set; }


		internal AstrologyRpc()
		{
			this.op = 0;
			this.args = 0;
		}

	}

}
