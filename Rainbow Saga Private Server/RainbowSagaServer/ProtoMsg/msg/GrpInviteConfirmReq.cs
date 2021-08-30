using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GrpInviteConfirmReq
	{

		[ProtoMember(1, IsRequired=true)]
		public string srcname{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int groupid{ get; set; }


		internal GrpInviteConfirmReq()
		{
			this.srcname ="";
			this.groupid = 0;
		}

	}

}
