using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetStoryProgressAck
	{

		[ProtoMember(2)]
		public int unused{ get; set; }

		[ProtoMember(1)]
		public int storyids{ get; set; }


		internal GetStoryProgressAck()
		{
			this.unused = 0;
			this.storyids = 0;
		}

	}

}
