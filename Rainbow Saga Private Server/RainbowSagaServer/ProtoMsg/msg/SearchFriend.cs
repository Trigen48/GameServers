using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SearchFriend
	{

		[ProtoMember(1)]
		public string keyword{ get; set; }

		[ProtoMember(2)]
		public int page{ get; set; }


		internal SearchFriend()
		{
			this.keyword ="";
			this.page = 0;
		}

	}

}
