using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterZoneAck
	{

		[ProtoMember(1)]
		public int result{ get; set; }


		internal EnterZoneAck()
		{
			this.result = 0;
		}

	}

}
