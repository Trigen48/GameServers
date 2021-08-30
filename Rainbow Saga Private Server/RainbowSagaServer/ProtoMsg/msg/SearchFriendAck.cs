using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SearchFriendAck
	{

		[ProtoMember(1)]
		public int totalpage{ get; set; }

		[ProtoMember(2)]
		public List<SearchInfo> list{ get; set; }

		[ProtoMember(3)]
		public int ret{ get; set; }


		internal SearchFriendAck()
		{
			this.totalpage = 0;
			this.list = new List<SearchInfo>();
			this.ret = 0;
		}

	}

}
