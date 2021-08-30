using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetLimitItemRemain
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int actId{ get; set; }


		internal GetLimitItemRemain()
		{
			this.type = 0;
			this.actId = 0;
		}

	}

}
