using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GrowingFund
	{

		[ProtoMember(1)]
		public int baseFund{ get; set; }

		[ProtoMember(2)]
		public int advancedFund{ get; set; }


		internal GrowingFund()
		{
			this.baseFund = 0;
			this.advancedFund = 0;
		}

	}

}
