using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetTimeLimitDgnListAck
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public List<TimeLimitDungeon> list{ get; set; }


		internal GetTimeLimitDgnListAck()
		{
			this.unused = 0;
			this.list = new List<TimeLimitDungeon>();
		}

	}

}
