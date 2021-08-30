using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetReqList
	{

		[ProtoMember(1)]
		public int reserved{ get; set; }


		internal GetReqList()
		{
			this.reserved = 0;
		}

	}

}
