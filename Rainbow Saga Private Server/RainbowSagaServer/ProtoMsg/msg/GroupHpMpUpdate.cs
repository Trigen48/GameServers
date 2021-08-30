using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GroupHpMpUpdate
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public List<HpMpInfo> infos{ get; set; }


		internal GroupHpMpUpdate()
		{
			this.id = 0;
			this.infos = new List<HpMpInfo>();
		}

	}

}
