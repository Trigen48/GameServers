using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class XOCashUpResp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int bingo{ get; set; }

		[ProtoMember(3)]
		public XOInfo info{ get; set; }


		internal XOCashUpResp()
		{
			this.op = 0;
			this.bingo = 0;
			this.info = new XOInfo();
		}

	}

}
