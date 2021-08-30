using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyOnlineHourToClient
	{

		[ProtoMember(1, IsRequired=true)]
		public int hour{ get; set; }

		[ProtoMember(2)]
		public int prompt{ get; set; }


		internal NotifyOnlineHourToClient()
		{
			this.hour = 0;
			this.prompt = 0;
		}

	}

}
