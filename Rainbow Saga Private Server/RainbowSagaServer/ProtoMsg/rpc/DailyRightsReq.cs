using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DailyRightsReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int rightId{ get; set; }


		internal DailyRightsReq()
		{
			this.op = 0;
			this.rightId = 0;
		}

	}

}
