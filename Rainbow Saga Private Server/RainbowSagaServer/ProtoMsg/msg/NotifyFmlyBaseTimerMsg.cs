using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyFmlyBaseTimerMsg
	{

		[ProtoMember(1)]
		public int fmlyAct{ get; set; }

		[ProtoMember(2)]
		public int timerStatus{ get; set; }

		[ProtoMember(3)]
		public uint duration{ get; set; }


		internal NotifyFmlyBaseTimerMsg()
		{
			this.fmlyAct = 0;
			this.timerStatus = 0;
			this.duration = 0;
		}

	}

}
