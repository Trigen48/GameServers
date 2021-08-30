using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class QuickAddToGrpDgnReq
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int groupType{ get; set; }


		internal QuickAddToGrpDgnReq()
		{
			this.dgnid = 0;
			this.groupType = 0;
		}

	}

}
