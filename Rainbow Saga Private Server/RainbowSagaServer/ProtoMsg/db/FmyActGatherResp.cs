using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmyActGatherResp
	{

		[ProtoMember(1)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public FmyActGetInfoResp info{ get; set; }


		internal FmyActGatherResp()
		{
			this.ret = 0;
			this.type = 0;
			this.info = new FmyActGetInfoResp();
		}

	}

}
