using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TimeSyncRequest
	{

		[ProtoMember(1)]
		public int sequence{ get; set; }

		[ProtoMember(2)]
		public int localTick{ get; set; }


		internal TimeSyncRequest()
		{
			this.sequence = 0;
			this.localTick = 0;
		}

	}

}
