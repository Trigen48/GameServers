using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TripleInfo
	{

		[ProtoMember(1)]
		public int score{ get; set; }

		[ProtoMember(2)]
		public ulong startTime{ get; set; }


		internal TripleInfo()
		{
			this.score = 0;
			this.startTime = 0;
		}

	}

}
