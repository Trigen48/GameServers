using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LoginRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public string username{ get; set; }

		[ProtoMember(2)]
		public string password{ get; set; }

		[ProtoMember(3)]
		public int force{ get; set; }

		[ProtoMember(4)]
		public string appCustom{ get; set; }

		[ProtoMember(7)]
		public int platid{ get; set; }

		[ProtoMember(8)]
		public int createdWorldId{ get; set; }

		[ProtoMember(9)]
		public string source{ get; set; }


		internal LoginRequest()
		{
			this.username ="";
			this.password ="";
			this.force = 0;
			this.appCustom ="";
			this.platid = 0;
			this.createdWorldId = 0;
			this.source ="";
		}

	}

}
