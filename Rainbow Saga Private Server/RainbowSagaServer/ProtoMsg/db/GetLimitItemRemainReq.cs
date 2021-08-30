using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class GetLimitItemRemainReq
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }


		internal GetLimitItemRemainReq()
		{
			this.itemid = 0;
		}

	}

}
