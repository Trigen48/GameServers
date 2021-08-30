using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpFixedPayActInfo
	{

		[ProtoMember(1)]
		public uint opt{ get; set; }

		[ProtoMember(2)]
		public uint result{ get; set; }

		[ProtoMember(3)]
		public uint startdate{ get; set; }

		[ProtoMember(4)]
		public uint enddate{ get; set; }

		[ProtoMember(5)]
		public uint giftid{ get; set; }

		[ProtoMember(6)]
		public uint confamount{ get; set; }

		[ProtoMember(7)]
		public uint payamount{ get; set; }

		[ProtoMember(8)]
		public uint gottimes{ get; set; }

		[ProtoMember(9)]
		public uint cangettimes{ get; set; }


		internal UpFixedPayActInfo()
		{
			this.opt = 0;
			this.result = 0;
			this.startdate = 0;
			this.enddate = 0;
			this.giftid = 0;
			this.confamount = 0;
			this.payamount = 0;
			this.gottimes = 0;
			this.cangettimes = 0;
		}

	}

}
