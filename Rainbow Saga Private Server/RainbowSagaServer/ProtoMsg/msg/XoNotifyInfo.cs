using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class XoNotifyInfo
	{

		[ProtoMember(1)]
		public int actStatus{ get; set; }

		[ProtoMember(2)]
		public int questStatus{ get; set; }

		[ProtoMember(3)]
		public int questionId{ get; set; }

		[ProtoMember(4)]
		public int answer{ get; set; }

		[ProtoMember(5)]
		public int swapAnswer{ get; set; }

		[ProtoMember(6)]
		public int remainTime{ get; set; }

		[ProtoMember(7)]
		public int currQuest{ get; set; }

		[ProtoMember(8)]
		public uint charId{ get; set; }


		internal XoNotifyInfo()
		{
			this.actStatus = 0;
			this.questStatus = 0;
			this.questionId = 0;
			this.answer = 0;
			this.swapAnswer = 0;
			this.remainTime = 0;
			this.currQuest = 0;
			this.charId = 0;
		}

	}

}
