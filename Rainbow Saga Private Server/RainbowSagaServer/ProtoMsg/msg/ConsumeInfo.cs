using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ConsumeInfo
	{

		[ProtoMember(1)]
		public int consume{ get; set; }

		[ProtoMember(2)]
		public ulong startTime{ get; set; }


		internal ConsumeInfo()
		{
			this.consume = 0;
			this.startTime = 0;
		}

	}

}
