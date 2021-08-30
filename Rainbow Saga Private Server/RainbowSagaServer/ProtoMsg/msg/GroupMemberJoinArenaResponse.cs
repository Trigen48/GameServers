using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GroupMemberJoinArenaResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int charId{ get; set; }


		internal GroupMemberJoinArenaResponse()
		{
			this.result = 0;
			this.charId = 0;
		}

	}

}
