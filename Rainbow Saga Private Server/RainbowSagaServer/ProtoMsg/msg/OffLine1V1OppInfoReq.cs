using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLine1V1OppInfoReq
	{

		[ProtoMember(1)]
		public string opponent{ get; set; }


		internal OffLine1V1OppInfoReq()
		{
			this.opponent ="";
		}

	}

}
