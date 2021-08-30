using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DgnActiveInfo
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int active{ get; set; }


		internal DgnActiveInfo()
		{
			this.dgnid = 0;
			this.active = 0;
		}

	}

}
