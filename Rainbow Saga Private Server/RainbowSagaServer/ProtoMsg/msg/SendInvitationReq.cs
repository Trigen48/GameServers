using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SendInvitationReq
	{

		[ProtoMember(1)]
		public string inviteeList{ get; set; }


		internal SendInvitationReq()
		{
			this.inviteeList ="";
		}

	}

}
