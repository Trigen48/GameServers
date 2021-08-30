using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class QueryDgnActiveInfoReq
	{

		[ProtoMember(1)]
		public int dgnids{ get; set; }


		internal QueryDgnActiveInfoReq()
		{
			this.dgnids = 0;
		}

	}

}
