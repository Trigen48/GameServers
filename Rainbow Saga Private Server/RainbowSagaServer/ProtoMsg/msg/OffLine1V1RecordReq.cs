using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLine1V1RecordReq
	{

		[ProtoMember(1)]
		public int unused{ get; set; }


		internal OffLine1V1RecordReq()
		{
			this.unused = 0;
		}

	}

}
