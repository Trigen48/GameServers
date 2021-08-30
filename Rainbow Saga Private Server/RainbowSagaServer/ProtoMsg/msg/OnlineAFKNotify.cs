using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OnlineAFKNotify
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int exp{ get; set; }

		[ProtoMember(3)]
		public int energy{ get; set; }

		[ProtoMember(4)]
		public int leftTime{ get; set; }


		internal OnlineAFKNotify()
		{
			this.op = 0;
			this.exp = 0;
			this.energy = 0;
			this.leftTime = 0;
		}

	}

}
