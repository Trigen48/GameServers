using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DailyPayData
	{

		[ProtoMember(1)]
		public int state{ get; set; }

		[ProtoMember(2)]
		public int time{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }

		[ProtoMember(4)]
		public int step{ get; set; }


		internal DailyPayData()
		{
			this.state = 0;
			this.time = 0;
			this.num = 0;
			this.step = 0;
		}

	}

}
