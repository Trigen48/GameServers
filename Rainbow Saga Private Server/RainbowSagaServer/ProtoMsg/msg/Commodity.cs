using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Commodity
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public string name{ get; set; }

		[ProtoMember(3)]
		public string desc{ get; set; }

		[ProtoMember(4)]
		public int category{ get; set; }

		[ProtoMember(5)]
		public int sortIndex{ get; set; }

		[ProtoMember(6)]
		public int subType{ get; set; }

		[ProtoMember(7)]
		public int sortSub{ get; set; }

		[ProtoMember(8)]
		public int recommend{ get; set; }

		[ProtoMember(9)]
		public int subRt{ get; set; }

		[ProtoMember(10)]
		public int sortSubRt{ get; set; }

		[ProtoMember(11)]
		public int gender{ get; set; }

		[ProtoMember(12)]
		public int consumeType{ get; set; }

		[ProtoMember(13)]
		public int consumeWay{ get; set; }

		[ProtoMember(14)]
		public int itemFlag{ get; set; }

		[ProtoMember(15)]
		public int visible{ get; set; }

		[ProtoMember(16)]
		public int lqTime{ get; set; }

		[ProtoMember(17)]
		public int lq{ get; set; }

		[ProtoMember(20)]
		public int status{ get; set; }

		[ProtoMember(21)]
		public int startTime{ get; set; }

		[ProtoMember(22)]
		public int endTime{ get; set; }

		[ProtoMember(29)]
		public int discount{ get; set; }

		[ProtoMember(30)]
		public int baseP{ get; set; }

		[ProtoMember(32)]
		public int monthP{ get; set; }

		[ProtoMember(31)]
		public int perpetualP{ get; set; }

		[ProtoMember(38)]
		public int spType{ get; set; }

		[ProtoMember(39)]
		public int lv1{ get; set; }

		[ProtoMember(40)]
		public int lv2{ get; set; }

		[ProtoMember(41)]
		public int lv3{ get; set; }

		[ProtoMember(42)]
		public int lv4{ get; set; }

		[ProtoMember(43)]
		public int lv5{ get; set; }

		[ProtoMember(44)]
		public int lv6{ get; set; }

		[ProtoMember(45)]
		public int lv7{ get; set; }

		[ProtoMember(46)]
		public int lv8{ get; set; }


		internal Commodity()
		{
			this.id = 0;
			this.name ="";
			this.desc ="";
			this.category = 0;
			this.sortIndex = 0;
			this.subType = 0;
			this.sortSub = 0;
			this.recommend = 0;
			this.subRt = 0;
			this.sortSubRt = 0;
			this.gender = 0;
			this.consumeType = 0;
			this.consumeWay = 0;
			this.itemFlag = 0;
			this.visible = 0;
			this.lqTime = 0;
			this.lq = 0;
			this.status = 0;
			this.startTime = 0;
			this.endTime = 0;
			this.discount = 0;
			this.baseP = 0;
			this.monthP = 0;
			this.perpetualP = 0;
			this.spType = 0;
			this.lv1 = 0;
			this.lv2 = 0;
			this.lv3 = 0;
			this.lv4 = 0;
			this.lv5 = 0;
			this.lv6 = 0;
			this.lv7 = 0;
			this.lv8 = 0;
		}

	}

}
