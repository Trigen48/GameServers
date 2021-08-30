using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OnlineAFK
	{

		[ProtoMember(1)]
		public int totalTime{ get; set; }

		[ProtoMember(2)]
		public int lastAvatar{ get; set; }

		[ProtoMember(3)]
		public int avatars{ get; set; }

		[ProtoMember(4)]
		public int exp{ get; set; }

		[ProtoMember(5)]
		public int energy{ get; set; }

		[ProtoMember(6)]
		public int resetTime{ get; set; }

		[ProtoMember(7)]
		public int totalOnlineTime{ get; set; }


		internal OnlineAFK()
		{
			this.totalTime = 0;
			this.lastAvatar = 0;
			this.avatars = 0;
			this.exp = 0;
			this.energy = 0;
			this.resetTime = 0;
			this.totalOnlineTime = 0;
		}

	}

}
