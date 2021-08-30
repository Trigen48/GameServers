using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetLoopQuestRewards
	{

		[ProtoMember(1)]
		public int loop{ get; set; }

		[ProtoMember(2)]
		public int exp{ get; set; }

		[ProtoMember(3)]
		public int money{ get; set; }

		[ProtoMember(4)]
		public int items{ get; set; }


		internal GetLoopQuestRewards()
		{
			this.loop = 0;
			this.exp = 0;
			this.money = 0;
			this.items = 0;
		}

	}

}
