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
	internal class GetBlackListAck
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public List<BlockInfo> blacklist{ get; set; }


		internal GetBlackListAck()
		{
			this.unused = 0;
			this.blacklist = new List<BlockInfo>();
		}

	}

}
