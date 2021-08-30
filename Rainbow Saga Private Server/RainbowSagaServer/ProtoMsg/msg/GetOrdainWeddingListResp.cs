using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetOrdainWeddingListResp
	{

		[ProtoMember(1)]
		public List<OrdainWeddingInfo> infos{ get; set; }


		internal GetOrdainWeddingListResp()
		{
			this.infos = new List<OrdainWeddingInfo>();
		}

	}

}
