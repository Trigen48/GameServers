using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SingleMopupEndNotify
	{

		[ProtoMember(1)]
		public int number{ get; set; }

		[ProtoMember(2)]
		public int exp{ get; set; }

		[ProtoMember(3)]
		public List<Item> items{ get; set; }

		[ProtoMember(4)]
		public int consumeEnergy{ get; set; }

		[ProtoMember(5)]
		public int consumeMoney{ get; set; }

		[ProtoMember(6)]
		public int money{ get; set; }

		[ProtoMember(7)]
		public int dgnid{ get; set; }

		[ProtoMember(8)]
		public int quartz{ get; set; }

		[ProtoMember(9)]
		public int needItemId{ get; set; }


		internal SingleMopupEndNotify()
		{
			this.number = 0;
			this.exp = 0;
			this.items = new List<Item>();
			this.consumeEnergy = 0;
			this.consumeMoney = 0;
			this.money = 0;
			this.dgnid = 0;
			this.quartz = 0;
			this.needItemId = 0;
		}

	}

}
