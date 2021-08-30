using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LeaveGVGDgnQueueReq
	{

		[ProtoMember(1)]
		public int unused{ get; set; }


		internal LeaveGVGDgnQueueReq()
		{
			this.unused = 0;
		}

	}

}
