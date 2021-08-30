using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FixedPayActivity
	{

		[ProtoMember(1)]
		public uint amount{ get; set; }

		[ProtoMember(2)]
		public uint gotTimes{ get; set; }

		[ProtoMember(3)]
		public uint canGetTimes{ get; set; }

		[ProtoMember(4)]
		public uint startdate{ get; set; }

		[ProtoMember(5)]
		public uint enddate{ get; set; }


		internal FixedPayActivity()
		{
			this.amount = 0;
			this.gotTimes = 0;
			this.canGetTimes = 0;
			this.startdate = 0;
			this.enddate = 0;
		}

	}

}
