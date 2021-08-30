using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetNearbyGroupsResp
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public List<GroupBrief> infos{ get; set; }


		internal GetNearbyGroupsResp()
		{
			this.unused = 0;
			this.infos = new List<GroupBrief>();
		}

	}

}
