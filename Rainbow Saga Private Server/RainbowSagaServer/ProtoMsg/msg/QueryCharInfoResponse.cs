using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class QueryCharInfoResponse
	{

		[ProtoMember(1, IsRequired=true)]
		public int result{ get; set; }

		[ProtoMember(5)]
		public List<CharInfo> infos{ get; set; }


		internal QueryCharInfoResponse()
		{
			this.result = 0;
			this.infos = new List<CharInfo>();
		}

	}

}
