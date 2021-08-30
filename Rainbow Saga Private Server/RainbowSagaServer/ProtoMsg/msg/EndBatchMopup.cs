using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EndBatchMopup
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public int dgnid{ get; set; }


		internal EndBatchMopup()
		{
			this.unused = 0;
			this.dgnid = 0;
		}

	}

}
