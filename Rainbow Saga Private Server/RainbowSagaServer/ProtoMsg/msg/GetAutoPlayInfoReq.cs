using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetAutoPlayInfoReq
	{

		[ProtoMember(1)]
		public int unused{ get; set; }


		internal GetAutoPlayInfoReq()
		{
			this.unused = 0;
		}

	}

}
