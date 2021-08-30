using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NewServerBenefit
	{

		[ProtoMember(1)]
		public int received{ get; set; }

		[ProtoMember(2)]
		public int serverId{ get; set; }


		internal NewServerBenefit()
		{
			this.received = 0;
			this.serverId = 0;
		}

	}

}
