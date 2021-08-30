using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CdKeyOp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int status{ get; set; }

		[ProtoMember(3)]
		public string code{ get; set; }


		internal CdKeyOp()
		{
			this.op = 0;
			this.status = 0;
			this.code ="";
		}

	}

}
