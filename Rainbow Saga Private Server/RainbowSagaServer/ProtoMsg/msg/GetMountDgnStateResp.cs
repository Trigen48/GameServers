using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetMountDgnStateResp
	{

		[ProtoMember(1)]
		public int dgnstage0{ get; set; }

		[ProtoMember(2)]
		public int dgnstage1{ get; set; }

		[ProtoMember(3)]
		public int dgnstage2{ get; set; }

		[ProtoMember(4)]
		public int dgnstage3{ get; set; }


		internal GetMountDgnStateResp()
		{
			this.dgnstage0 = 0;
			this.dgnstage1 = 0;
			this.dgnstage2 = 0;
			this.dgnstage3 = 0;
		}

	}

}
