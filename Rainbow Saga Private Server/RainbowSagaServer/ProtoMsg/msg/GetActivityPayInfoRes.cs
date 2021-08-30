using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetActivityPayInfoRes
	{

		[ProtoMember(1)]
		public uint uin{ get; set; }

		[ProtoMember(2)]
		public uint opt{ get; set; }


		internal GetActivityPayInfoRes()
		{
			this.uin = 0;
			this.opt = 0;
		}

	}

}
