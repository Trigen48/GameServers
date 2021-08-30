using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CoMarketOp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int status{ get; set; }

		[ProtoMember(3)]
		public string source{ get; set; }

		[ProtoMember(4)]
		public string ruleId{ get; set; }


		internal CoMarketOp()
		{
			this.op = 0;
			this.status = 0;
			this.source ="";
			this.ruleId ="";
		}

	}

}
