using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FetchMailAttachment
	{

		[ProtoMember(1)]
		public long mailid{ get; set; }


		internal FetchMailAttachment()
		{
			this.mailid = 0;
		}

	}

}
