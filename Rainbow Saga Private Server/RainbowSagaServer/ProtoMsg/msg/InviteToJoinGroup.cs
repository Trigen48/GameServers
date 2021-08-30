using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class InviteToJoinGroup
	{

		[ProtoMember(1, IsRequired=true)]
		public string destname{ get; set; }


		internal InviteToJoinGroup()
		{
			this.destname ="";
		}

	}

}
