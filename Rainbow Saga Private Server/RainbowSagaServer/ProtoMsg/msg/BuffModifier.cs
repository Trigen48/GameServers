using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BuffModifier
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int amount{ get; set; }

		[ProtoMember(3)]
		public int flag{ get; set; }

		[ProtoMember(4)]
		public int interval{ get; set; }


		internal BuffModifier()
		{
			this.type = 0;
			this.amount = 0;
			this.flag = 0;
			this.interval = 0;
		}

	}

}
