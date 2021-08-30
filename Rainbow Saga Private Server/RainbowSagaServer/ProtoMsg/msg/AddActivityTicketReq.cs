using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AddActivityTicketReq
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public uint count{ get; set; }


		internal AddActivityTicketReq()
		{
			this.dgnid = 0;
			this.count = 0;
		}

	}

}
