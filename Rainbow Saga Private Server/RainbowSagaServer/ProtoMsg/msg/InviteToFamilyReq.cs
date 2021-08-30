using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class InviteToFamilyReq
	{

		[ProtoMember(1)]
		public string srcname{ get; set; }

		[ProtoMember(2)]
		public string destname{ get; set; }

		[ProtoMember(3)]
		public string familyname{ get; set; }


		internal InviteToFamilyReq()
		{
			this.srcname ="";
			this.destname ="";
			this.familyname ="";
		}

	}

}
