using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BellInfoResponse
	{

		[ProtoMember(1)]
		public int bellId{ get; set; }

		[ProtoMember(2)]
		public int ringCount{ get; set; }


		internal BellInfoResponse()
		{
			this.bellId = 0;
			this.ringCount = 0;
		}

	}

}
