using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MailBrief
	{

		[ProtoMember(1)]
		public long mailid{ get; set; }

		[ProtoMember(2)]
		public string sender{ get; set; }

		[ProtoMember(3)]
		public int type{ get; set; }

		[ProtoMember(4)]
		public int status{ get; set; }

		[ProtoMember(5)]
		public string title{ get; set; }

		[ProtoMember(6)]
		public int sentdate{ get; set; }

		[ProtoMember(7)]
		public int senderlevel{ get; set; }


		internal MailBrief()
		{
			this.mailid = 0;
			this.sender ="";
			this.type = 0;
			this.status = 0;
			this.title ="";
			this.sentdate = 0;
			this.senderlevel = 0;
		}

	}

}
