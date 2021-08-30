using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetReqListAck
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public List<ReqInfo> reqlist{ get; set; }


		internal GetReqListAck()
		{
			this.unused = 0;
			this.reqlist = new List<ReqInfo>();
		}

	}

}
