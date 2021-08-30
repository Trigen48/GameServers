using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UsePillResp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int sType{ get; set; }

		[ProtoMember(3)]
		public List<PropPill> pillInfo{ get; set; }


		internal UsePillResp()
		{
			this.op = 0;
			this.sType = 0;
			this.pillInfo = new List<PropPill>();
		}

	}

}
