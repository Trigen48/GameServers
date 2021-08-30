using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetDgnInfoOfAreaMapReq
	{

		[ProtoMember(1)]
		public int dgnids{ get; set; }

		[ProtoMember(2)]
		public int areaid{ get; set; }


		internal GetDgnInfoOfAreaMapReq()
		{
			this.dgnids = 0;
			this.areaid = 0;
		}

	}

}
