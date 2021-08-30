using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFinishDgnIdsAck
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public int dgnids{ get; set; }


		internal GetFinishDgnIdsAck()
		{
			this.unused = 0;
			this.dgnids = 0;
		}

	}

}
