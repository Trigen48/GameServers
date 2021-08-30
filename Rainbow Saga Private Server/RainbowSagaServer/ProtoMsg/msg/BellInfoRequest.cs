using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BellInfoRequest
	{

		[ProtoMember(1)]
		public int bellId{ get; set; }


		internal BellInfoRequest()
		{
			this.bellId = 0;
		}

	}

}
