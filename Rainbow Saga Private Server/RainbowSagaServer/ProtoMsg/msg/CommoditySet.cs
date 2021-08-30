using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CommoditySet
	{

		[ProtoMember(1, IsRequired=true)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public string name{ get; set; }

		[ProtoMember(3)]
		public string desc{ get; set; }

		[ProtoMember(4)]
		public string info{ get; set; }

		[ProtoMember(5)]
		public int gender{ get; set; }

		[ProtoMember(6)]
		public int recommend{ get; set; }

		[ProtoMember(7)]
		public int subRt{ get; set; }

		[ProtoMember(8)]
		public int sortSubRt{ get; set; }

		[ProtoMember(9)]
		public int flag{ get; set; }

		[ProtoMember(10)]
		public int sortIndex{ get; set; }

		[ProtoMember(11)]
		public int startTime{ get; set; }

		[ProtoMember(12)]
		public int endTime{ get; set; }

		[ProtoMember(13)]
		public int itemid1{ get; set; }

		[ProtoMember(14)]
		public int itemid2{ get; set; }

		[ProtoMember(15)]
		public int itemid3{ get; set; }

		[ProtoMember(16)]
		public int itemid4{ get; set; }

		[ProtoMember(17)]
		public int itemid5{ get; set; }

		[ProtoMember(18)]
		public int itemid6{ get; set; }


		internal CommoditySet()
		{
			this.id = 0;
			this.name ="";
			this.desc ="";
			this.info ="";
			this.gender = 0;
			this.recommend = 0;
			this.subRt = 0;
			this.sortSubRt = 0;
			this.flag = 0;
			this.sortIndex = 0;
			this.startTime = 0;
			this.endTime = 0;
			this.itemid1 = 0;
			this.itemid2 = 0;
			this.itemid3 = 0;
			this.itemid4 = 0;
			this.itemid5 = 0;
			this.itemid6 = 0;
		}

	}

}
