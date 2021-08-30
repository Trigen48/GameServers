using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetMyOrdainInfoReq
	{

		[ProtoMember(1)]
		public int unuse{ get; set; }


		internal GetMyOrdainInfoReq()
		{
			this.unuse = 0;
		}

	}

}
