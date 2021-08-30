using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GemSocketRpc
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int socketId{ get; set; }

		[ProtoMember(3)]
		public int equipId{ get; set; }

		[ProtoMember(4)]
		public int gemId{ get; set; }


		internal GemSocketRpc()
		{
			this.op = 0;
			this.socketId = 0;
			this.equipId = 0;
			this.gemId = 0;
		}

	}

}
