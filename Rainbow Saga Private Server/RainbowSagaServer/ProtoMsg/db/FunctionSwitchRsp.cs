using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FunctionSwitchRsp
	{

		[ProtoMember(1)]
		public List<FunctionSwitchInfo> infos{ get; set; }

		[ProtoMember(4)]
		public int unused{ get; set; }


		internal FunctionSwitchRsp()
		{
			this.infos = new List<FunctionSwitchInfo>();
			this.unused = 0;
		}

	}

}
