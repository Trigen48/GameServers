using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetZoneBossInfoResp
	{

		[ProtoMember(1)]
		public List<ZoneBossInfo> infos{ get; set; }


		internal GetZoneBossInfoResp()
		{
			this.infos = new List<ZoneBossInfo>();
		}

	}

}
