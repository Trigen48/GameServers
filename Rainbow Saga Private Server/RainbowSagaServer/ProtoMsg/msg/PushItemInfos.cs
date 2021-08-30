using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PushItemInfos
	{

		[ProtoMember(1)]
		public List<PushItemInfo> infos{ get; set; }


		internal PushItemInfos()
		{
			this.infos = new List<PushItemInfo>();
		}

	}

}
