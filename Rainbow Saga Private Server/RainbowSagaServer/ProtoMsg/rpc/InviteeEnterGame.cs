using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class InviteeEnterGame
	{

		[ProtoMember(1, IsRequired=true)]
		public Invitee invitee{ get; set; }


		internal InviteeEnterGame()
		{
			this.invitee = new Invitee();
		}

	}

}
