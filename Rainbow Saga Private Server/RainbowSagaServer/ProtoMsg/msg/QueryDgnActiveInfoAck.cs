using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class QueryDgnActiveInfoAck
	{

		[ProtoMember(1)]
		public List<DgnActiveInfo> infos{ get; set; }


		internal QueryDgnActiveInfoAck()
		{
			this.infos = new List<DgnActiveInfo>();
		}

	}

}
