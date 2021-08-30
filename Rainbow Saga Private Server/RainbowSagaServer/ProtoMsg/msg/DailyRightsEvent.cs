using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DailyRightsEvent
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int timeStamp{ get; set; }

		[ProtoMember(3)]
		public int state{ get; set; }

		[ProtoMember(4)]
		public int passedDays{ get; set; }


		internal DailyRightsEvent()
		{
			this.id = 0;
			this.timeStamp = 0;
			this.state = 0;
			this.passedDays = 0;
		}

	}

}
