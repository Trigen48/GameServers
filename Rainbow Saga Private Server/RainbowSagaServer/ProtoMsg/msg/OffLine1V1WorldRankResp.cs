using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLine1V1WorldRankResp
	{

		[ProtoMember(1)]
		public List<OfflineCharInfo> threeBest{ get; set; }

		[ProtoMember(2)]
		public List<OffLineRankElement> rankList{ get; set; }


		internal OffLine1V1WorldRankResp()
		{
			this.threeBest = new List<OfflineCharInfo>();
			this.rankList = new List<OffLineRankElement>();
		}

	}

}
