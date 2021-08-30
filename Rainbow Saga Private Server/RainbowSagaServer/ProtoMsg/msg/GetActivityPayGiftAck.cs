using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetActivityPayGiftAck
	{

		[ProtoMember(1)]
		public int opt{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }


		internal GetActivityPayGiftAck()
		{
			this.opt = 0;
			this.result = 0;
		}

	}

}
