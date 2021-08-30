using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class QueryItemsResult
	{

		[ProtoMember(1)]
		public int items{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int subtype{ get; set; }

		[ProtoMember(4)]
		public int op{ get; set; }


		internal QueryItemsResult()
		{
			this.items = 0;
			this.type = 0;
			this.subtype = 0;
			this.op = 0;
		}

	}

}
