using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetNearbyGroupsReq
	{

		[ProtoMember(1, IsRequired=true)]
		public int unused{ get; set; }


		internal GetNearbyGroupsReq()
		{
			this.unused = 0;
		}

	}

}
