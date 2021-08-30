using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmyActGetInfoReq
	{

		[ProtoMember(1)]
		public int unused{ get; set; }


		internal FmyActGetInfoReq()
		{
			this.unused = 0;
		}

	}

}
