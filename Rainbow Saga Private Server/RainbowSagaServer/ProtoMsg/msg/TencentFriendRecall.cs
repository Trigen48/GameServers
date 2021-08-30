using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TencentFriendRecall
	{

		[ProtoMember(1)]
		public int state{ get; set; }


		internal TencentFriendRecall()
		{
			this.state = 0;
		}

	}

}
