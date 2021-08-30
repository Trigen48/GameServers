using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class XOCashUpReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int param{ get; set; }


		internal XOCashUpReq()
		{
			this.op = 0;
			this.param = 0;
		}

	}

}
