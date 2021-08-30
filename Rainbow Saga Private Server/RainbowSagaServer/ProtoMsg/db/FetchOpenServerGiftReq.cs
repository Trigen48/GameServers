using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FetchOpenServerGiftReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }


		internal FetchOpenServerGiftReq()
		{
			this.op = 0;
		}

	}

}
