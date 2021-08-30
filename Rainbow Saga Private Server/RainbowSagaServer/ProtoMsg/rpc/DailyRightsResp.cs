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
	internal class DailyRightsResp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public List<DailyRightsEvent> events{ get; set; }


		internal DailyRightsResp()
		{
			this.op = 0;
			this.events = new List<DailyRightsEvent>();
		}

	}

}
