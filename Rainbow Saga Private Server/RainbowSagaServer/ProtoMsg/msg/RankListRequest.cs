using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RankListRequest
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int charid{ get; set; }

		[ProtoMember(3)]
		public int lastVersion{ get; set; }

		[ProtoMember(4)]
		public int page{ get; set; }


		internal RankListRequest()
		{
			this.type = 0;
			this.charid = 0;
			this.lastVersion = 0;
			this.page = 0;
		}

	}

}
