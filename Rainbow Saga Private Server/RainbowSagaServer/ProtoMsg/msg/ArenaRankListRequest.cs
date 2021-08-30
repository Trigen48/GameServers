using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ArenaRankListRequest
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int page{ get; set; }


		internal ArenaRankListRequest()
		{
			this.type = 0;
			this.page = 0;
		}

	}

}
