using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnableCharResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int charid{ get; set; }


		internal EnableCharResponse()
		{
			this.result = 0;
			this.charid = 0;
		}

	}

}
