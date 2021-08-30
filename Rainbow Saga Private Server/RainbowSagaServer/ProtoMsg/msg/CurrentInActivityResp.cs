using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CurrentInActivityResp
	{

		[ProtoMember(1)]
		public int resp{ get; set; }


		internal CurrentInActivityResp()
		{
			this.resp = 0;
		}

	}

}
