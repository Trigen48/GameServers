using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GrowingFundOp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int fundType{ get; set; }

		[ProtoMember(3)]
		public int fundIndex{ get; set; }

		[ProtoMember(4)]
		public int baseFundStates{ get; set; }

		[ProtoMember(5)]
		public int advancedFundStates{ get; set; }


		internal GrowingFundOp()
		{
			this.op = 0;
			this.fundType = 0;
			this.fundIndex = 0;
			this.baseFundStates = 0;
			this.advancedFundStates = 0;
		}

	}

}
