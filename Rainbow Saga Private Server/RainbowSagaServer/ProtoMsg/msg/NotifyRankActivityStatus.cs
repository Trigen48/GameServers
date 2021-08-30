using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyRankActivityStatus
	{

		[ProtoMember(1)]
		public int status{ get; set; }


		internal NotifyRankActivityStatus()
		{
			this.status = 0;
		}

	}

}
