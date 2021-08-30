using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLine1V1OppInfoResp
	{

		[ProtoMember(1)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public string opponent{ get; set; }

		[ProtoMember(3)]
		public OfflineCharInfo oppInfo{ get; set; }


		internal OffLine1V1OppInfoResp()
		{
			this.ret = 0;
			this.opponent ="";
			this.oppInfo = new OfflineCharInfo();
		}

	}

}
