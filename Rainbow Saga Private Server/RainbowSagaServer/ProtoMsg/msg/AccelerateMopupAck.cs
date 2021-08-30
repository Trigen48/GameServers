using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AccelerateMopupAck
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int dgnid{ get; set; }


		internal AccelerateMopupAck()
		{
			this.result = 0;
			this.dgnid = 0;
		}

	}

}
