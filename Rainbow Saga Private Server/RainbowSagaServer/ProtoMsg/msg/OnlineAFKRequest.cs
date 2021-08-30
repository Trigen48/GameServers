using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OnlineAFKRequest
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int avatarId{ get; set; }

		[ProtoMember(3)]
		public int hours{ get; set; }

		[ProtoMember(4)]
		public int price{ get; set; }

		[ProtoMember(5)]
		public int exp{ get; set; }


		internal OnlineAFKRequest()
		{
			this.op = 0;
			this.avatarId = 0;
			this.hours = 0;
			this.price = 0;
			this.exp = 0;
		}

	}

}
