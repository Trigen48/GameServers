using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ExplorationRpc
	{

		[ProtoMember(1)]
		public int op{ get; set; }


		internal ExplorationRpc()
		{
			this.op = 0;
		}

	}

}
