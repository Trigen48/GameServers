using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmyActBuyHeatReq
	{

		[ProtoMember(1)]
		public int type{ get; set; }


		internal FmyActBuyHeatReq()
		{
			this.type = 0;
		}

	}

}
