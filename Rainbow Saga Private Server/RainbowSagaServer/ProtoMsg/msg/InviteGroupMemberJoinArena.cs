using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class InviteGroupMemberJoinArena
	{

		[ProtoMember(1)]
		public int invitee{ get; set; }


		internal InviteGroupMemberJoinArena()
		{
			this.invitee = 0;
		}

	}

}
