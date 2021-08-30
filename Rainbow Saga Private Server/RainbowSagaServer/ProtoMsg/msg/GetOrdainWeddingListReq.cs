using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetOrdainWeddingListReq
	{

		[ProtoMember(1)]
		public int unuse{ get; set; }


		internal GetOrdainWeddingListReq()
		{
			this.unuse = 0;
		}

	}

}
