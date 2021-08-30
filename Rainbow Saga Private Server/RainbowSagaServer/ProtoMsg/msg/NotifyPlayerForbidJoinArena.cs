using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyPlayerForbidJoinArena
	{

		[ProtoMember(1)]
		public int state{ get; set; }

		[ProtoMember(2)]
		public int charid{ get; set; }

		[ProtoMember(3)]
		public int remainTime{ get; set; }


		internal NotifyPlayerForbidJoinArena()
		{
			this.state = 0;
			this.charid = 0;
			this.remainTime = 0;
		}

	}

}
