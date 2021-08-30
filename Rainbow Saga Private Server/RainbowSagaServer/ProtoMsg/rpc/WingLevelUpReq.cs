using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class WingLevelUpReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }


		internal WingLevelUpReq()
		{
			this.op = 0;
		}

	}

}
