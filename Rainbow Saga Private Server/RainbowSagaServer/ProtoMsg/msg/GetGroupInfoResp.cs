using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetGroupInfoResp
	{

		[ProtoMember(1, IsRequired=true)]
		public int id{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public GroupInfo info{ get; set; }

		[ProtoMember(3)]
		public int type{ get; set; }


		internal GetGroupInfoResp()
		{
			this.id = 0;
			this.info = new GroupInfo();
			this.type = 0;
		}

	}

}
