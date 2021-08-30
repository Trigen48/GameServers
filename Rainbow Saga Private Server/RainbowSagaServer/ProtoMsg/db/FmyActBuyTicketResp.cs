using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmyActBuyTicketResp
	{

		[ProtoMember(1)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public FmyActGetInfoResp info{ get; set; }


		internal FmyActBuyTicketResp()
		{
			this.ret = 0;
			this.info = new FmyActGetInfoResp();
		}

	}

}
