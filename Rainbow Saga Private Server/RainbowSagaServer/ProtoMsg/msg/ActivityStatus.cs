using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ActivityStatus
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int running{ get; set; }


		internal ActivityStatus()
		{
			this.type = 0;
			this.running = 0;
		}

	}

}
