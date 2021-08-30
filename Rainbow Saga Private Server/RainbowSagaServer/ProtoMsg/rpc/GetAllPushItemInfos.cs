using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetAllPushItemInfos
	{

		[ProtoMember(1)]
		public List<PushItemInfo> infos{ get; set; }


		internal GetAllPushItemInfos()
		{
			this.infos = new List<PushItemInfo>();
		}

	}

}
