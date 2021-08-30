using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ActivityQuestChain
	{

		[ProtoMember(1)]
		public int i{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }

		[ProtoMember(3)]
		public int exp{ get; set; }

		[ProtoMember(4)]
		public int money{ get; set; }

		[ProtoMember(5)]
		public int item{ get; set; }


		internal ActivityQuestChain()
		{
			this.i = 0;
			this.num = 0;
			this.exp = 0;
			this.money = 0;
			this.item = 0;
		}

	}

}
