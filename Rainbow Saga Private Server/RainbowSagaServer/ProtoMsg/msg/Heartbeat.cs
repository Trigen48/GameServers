using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Heartbeat
	{

		[ProtoMember(1)]
		public ulong timeStamp{ get; set; }


		internal Heartbeat()
		{
			this.timeStamp = 0;
		}

	}

}
