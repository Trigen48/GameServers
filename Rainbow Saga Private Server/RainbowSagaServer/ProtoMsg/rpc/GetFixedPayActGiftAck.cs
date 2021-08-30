using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetFixedPayActGiftAck
	{

		[ProtoMember(1)]
		public uint result{ get; set; }


		internal GetFixedPayActGiftAck()
		{
			this.result = 0;
		}

	}

}
