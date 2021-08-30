using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FetchNewServerGiftResp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int ret{ get; set; }


		internal FetchNewServerGiftResp()
		{
			this.op = 0;
			this.ret = 0;
		}

	}

}
