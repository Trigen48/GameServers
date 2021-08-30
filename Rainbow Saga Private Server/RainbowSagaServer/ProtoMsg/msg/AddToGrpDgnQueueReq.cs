using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AddToGrpDgnQueueReq
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }


		internal AddToGrpDgnQueueReq()
		{
			this.dgnid = 0;
		}

	}

}
