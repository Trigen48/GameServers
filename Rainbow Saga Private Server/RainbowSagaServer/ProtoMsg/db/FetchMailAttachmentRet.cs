using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FetchMailAttachmentRet
	{

		[ProtoMember(1)]
		public long mailid{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }


		internal FetchMailAttachmentRet()
		{
			this.mailid = 0;
			this.result = 0;
		}

	}

}
