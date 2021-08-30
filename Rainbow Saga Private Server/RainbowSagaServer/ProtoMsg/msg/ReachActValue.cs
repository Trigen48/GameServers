using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ReachActValue
	{

		[ProtoMember(1)]
		public int reachTime{ get; set; }


		internal ReachActValue()
		{
			this.reachTime = 0;
		}

	}

}
