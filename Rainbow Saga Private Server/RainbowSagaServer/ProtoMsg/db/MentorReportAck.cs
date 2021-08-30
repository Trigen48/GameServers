using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorReportAck
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public MentorReward reward{ get; set; }


		internal MentorReportAck()
		{
			this.charname ="";
			this.reward = new MentorReward();
		}

	}

}
