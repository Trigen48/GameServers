using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetLuckyDrawDataAck
	{

		[ProtoMember(1)]
		public List<LuckyDrawItem> items{ get; set; }

		[ProtoMember(2)]
		public int times{ get; set; }


		internal GetLuckyDrawDataAck()
		{
			this.items = new List<LuckyDrawItem>();
			this.times = 0;
		}

	}

}
