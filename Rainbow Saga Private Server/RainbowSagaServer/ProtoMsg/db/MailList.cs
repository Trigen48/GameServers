using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MailList
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public List<MailBrief> mails{ get; set; }


		internal MailList()
		{
			this.unused = 0;
			this.mails = new List<MailBrief>();
		}

	}

}
