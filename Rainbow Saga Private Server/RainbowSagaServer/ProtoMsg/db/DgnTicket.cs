using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DgnTicket
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int createtime{ get; set; }

		[ProtoMember(3)]
		public int pricetype{ get; set; }

		[ProtoMember(4)]
		public int pricevalue{ get; set; }


		internal DgnTicket()
		{
			this.dgnid = 0;
			this.createtime = 0;
			this.pricetype = 0;
			this.pricevalue = 0;
		}

	}

}
