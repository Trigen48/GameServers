using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Invitee
	{

		[ProtoMember(1, IsRequired=true)]
		public string qq{ get; set; }


		internal Invitee()
		{
			this.qq ="";
		}

	}

}
