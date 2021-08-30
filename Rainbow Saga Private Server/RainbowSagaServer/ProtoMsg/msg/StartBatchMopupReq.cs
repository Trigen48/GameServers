using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class StartBatchMopupReq
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int times{ get; set; }

		[ProtoMember(3)]
		public int difficulty{ get; set; }


		internal StartBatchMopupReq()
		{
			this.dgnid = 0;
			this.times = 0;
			this.difficulty = 0;
		}

	}

}
