using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class RpcAck
	{

		[ProtoMember(1)]
		public string name{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(20)]
		public byte[]  message{ get; set; }


		internal RpcAck()
		{
			this.name ="";
			this.result = 0;
			this.message = null;
		}

	}

}
