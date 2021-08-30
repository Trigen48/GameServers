using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DartLogResp
	{

		[ProtoMember(1)]
		public List<DartLogW> logs{ get; set; }


		internal DartLogResp()
		{
			this.logs = new List<DartLogW>();
		}

	}

}
