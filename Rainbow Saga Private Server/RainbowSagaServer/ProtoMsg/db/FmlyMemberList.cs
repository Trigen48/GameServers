using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyMemberList
	{

		[ProtoMember(1)]
		public List<FmlyMember> infos{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }


		internal FmlyMemberList()
		{
			this.infos = new List<FmlyMember>();
			this.num = 0;
		}

	}

}
