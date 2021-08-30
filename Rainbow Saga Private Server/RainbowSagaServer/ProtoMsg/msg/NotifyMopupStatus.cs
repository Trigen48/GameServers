using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyMopupStatus
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int status{ get; set; }


		internal NotifyMopupStatus()
		{
			this.dgnid = 0;
			this.status = 0;
		}

	}

}
