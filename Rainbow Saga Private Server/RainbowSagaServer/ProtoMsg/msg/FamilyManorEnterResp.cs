using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FamilyManorEnterResp
	{

		[ProtoMember(1)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public GetFamilyManorInfoResp info{ get; set; }


		internal FamilyManorEnterResp()
		{
			this.ret = 0;
			this.info = new GetFamilyManorInfoResp();
		}

	}

}
