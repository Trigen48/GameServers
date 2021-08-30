using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class GetMailDetail
	{

		[ProtoMember(1)]
		public long mailid{ get; set; }


		internal GetMailDetail()
		{
			this.mailid = 0;
		}

	}

}
