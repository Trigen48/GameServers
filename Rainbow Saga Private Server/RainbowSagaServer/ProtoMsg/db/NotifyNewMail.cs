using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class NotifyNewMail
	{

		[ProtoMember(1)]
		public MailBrief mail{ get; set; }

		[ProtoMember(2)]
		public int itemids{ get; set; }


		internal NotifyNewMail()
		{
			this.mail = new MailBrief();
			this.itemids = 0;
		}

	}

}
