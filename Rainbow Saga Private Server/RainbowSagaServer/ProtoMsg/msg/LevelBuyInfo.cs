using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LevelBuyInfo
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public int timestamp{ get; set; }

		[ProtoMember(3)]
		public int bought{ get; set; }


		internal LevelBuyInfo()
		{
			this.level = 0;
			this.timestamp = 0;
			this.bought = 0;
		}

	}

}
