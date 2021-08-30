using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ActivityGetInfo
	{

		[ProtoMember(1)]
		public List<ActivityUpdateData> info{ get; set; }


		internal ActivityGetInfo()
		{
			this.info = new List<ActivityUpdateData>();
		}

	}

}
