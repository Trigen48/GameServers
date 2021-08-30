using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetGroupInfoReq
	{

		[ProtoMember(1, IsRequired=true)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }


		internal GetGroupInfoReq()
		{
			this.id = 0;
			this.type = 0;
		}

	}

}
