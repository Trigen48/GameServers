using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DesignationOp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int id{ get; set; }

		[ProtoMember(4)]
		public int level{ get; set; }

		[ProtoMember(5)]
		public int statusBefore{ get; set; }

		[ProtoMember(6)]
		public int statusNow{ get; set; }

		[ProtoMember(7)]
		public int timestamp{ get; set; }

		[ProtoMember(8)]
		public int num1{ get; set; }

		[ProtoMember(9)]
		public int num2{ get; set; }

		[ProtoMember(10)]
		public int num3{ get; set; }

		[ProtoMember(11)]
		public int num4{ get; set; }

		[ProtoMember(12)]
		public int serverTime{ get; set; }

		[ProtoMember(13)]
		public Designation infoBefore{ get; set; }

		[ProtoMember(14)]
		public Designation infoNow{ get; set; }

		[ProtoMember(15)]
		public int hide{ get; set; }


		internal DesignationOp()
		{
			this.op = 0;
			this.result = 0;
			this.id = 0;
			this.level = 0;
			this.statusBefore = 0;
			this.statusNow = 0;
			this.timestamp = 0;
			this.num1 = 0;
			this.num2 = 0;
			this.num3 = 0;
			this.num4 = 0;
			this.serverTime = 0;
			this.infoBefore = new Designation();
			this.infoNow = new Designation();
			this.hide = 0;
		}

	}

}
