using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MailBody
	{

		[ProtoMember(1)]
		public long mailid{ get; set; }

		[ProtoMember(9)]
		public string body{ get; set; }

		[ProtoMember(10)]
		public int moneytopay{ get; set; }

		[ProtoMember(11)]
		public int recvmoney{ get; set; }

		[ProtoMember(13)]
		public Attachments attachments{ get; set; }

		[ProtoMember(14)]
		public Demander demander{ get; set; }

		[ProtoMember(15)]
		public int senderlevel{ get; set; }


		internal MailBody()
		{
			this.mailid = 0;
			this.body ="";
			this.moneytopay = 0;
			this.recvmoney = 0;
			this.attachments = new Attachments();
			this.demander = new Demander();
			this.senderlevel = 0;
		}

	}

}
