using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Variable
	{

		[ProtoMember(1)]
		public int key{ get; set; }

		[ProtoMember(2)]
		public int value{ get; set; }

		[ProtoMember(3)]
		public int lasttime{ get; set; }


		internal Variable()
		{
			this.key = 0;
			this.value = 0;
			this.lasttime = 0;
		}

	}

}
