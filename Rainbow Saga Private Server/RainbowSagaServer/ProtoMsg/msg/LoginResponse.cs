using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LoginResponse
	{

		[ProtoMember(1, IsRequired=true)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int sessionId{ get; set; }

		[ProtoMember(3)]
		public string username{ get; set; }

		[ProtoMember(7)]
		public string freezeReason{ get; set; }

		[ProtoMember(8)]
		public int banAccount{ get; set; }


		internal LoginResponse()
		{
			this.result = 0;
			this.sessionId = 0;
			this.username ="";
			this.freezeReason ="";
			this.banAccount = 0;
		}

	}

}
