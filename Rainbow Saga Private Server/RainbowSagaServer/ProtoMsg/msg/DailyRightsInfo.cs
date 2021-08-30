using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DailyRightsInfo
	{

		[ProtoMember(1)]
		public List<DailyRightsEvent> events{ get; set; }

		[ProtoMember(2)]
		public int evetNum{ get; set; }


		internal DailyRightsInfo()
		{
			this.events = new List<DailyRightsEvent>();
			this.evetNum = 0;
		}

	}

}
