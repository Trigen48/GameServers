using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class SendMailC2S
	{

		[ProtoMember(1)]
		public string receiver{ get; set; }

		[ProtoMember(2)]
		public string title{ get; set; }

		[ProtoMember(3)]
		public string body{ get; set; }

		[ProtoMember(4)]
		public int moneytopay{ get; set; }

		[ProtoMember(5)]
		public int recvmoney{ get; set; }

		[ProtoMember(6)]
		public Attachments items{ get; set; }

		[ProtoMember(7)]
		public int senderlevel{ get; set; }


		internal SendMailC2S()
		{
			this.receiver ="";
			this.title ="";
			this.body ="";
			this.moneytopay = 0;
			this.recvmoney = 0;
			this.items = new Attachments();
			this.senderlevel = 0;
		}

	}

}
