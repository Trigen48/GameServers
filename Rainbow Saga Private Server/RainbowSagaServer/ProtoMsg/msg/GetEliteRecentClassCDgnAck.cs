using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetEliteRecentClassCDgnAck
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }


		internal GetEliteRecentClassCDgnAck()
		{
			this.dgnid = 0;
		}

	}

}
