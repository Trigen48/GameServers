using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyWorldBossDuration
	{

		[ProtoMember(1)]
		public int timeToStart{ get; set; }

		[ProtoMember(2)]
		public int duration{ get; set; }


		internal NotifyWorldBossDuration()
		{
			this.timeToStart = 0;
			this.duration = 0;
		}

	}

}
