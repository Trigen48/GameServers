using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DartLogReq
	{

		[ProtoMember(1)]
		public int unused{ get; set; }


		internal DartLogReq()
		{
			this.unused = 0;
		}

	}

}
