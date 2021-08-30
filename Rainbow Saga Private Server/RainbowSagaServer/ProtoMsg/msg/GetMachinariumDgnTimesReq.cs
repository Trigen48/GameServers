using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetMachinariumDgnTimesReq
	{

		[ProtoMember(1, IsRequired=true)]
		public int unused{ get; set; }


		internal GetMachinariumDgnTimesReq()
		{
			this.unused = 0;
		}

	}

}
