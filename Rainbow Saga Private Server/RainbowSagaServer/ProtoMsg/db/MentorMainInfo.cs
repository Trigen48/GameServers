using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorMainInfo
	{

		[ProtoMember(1)]
		public long id{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }

		[ProtoMember(3)]
		public int exp{ get; set; }

		[ProtoMember(4)]
		public string notice{ get; set; }

		[ProtoMember(5)]
		public string info{ get; set; }

		[ProtoMember(6)]
		public string master{ get; set; }

		[ProtoMember(7)]
		public int masterlv{ get; set; }

		[ProtoMember(8)]
		public MentorReward reward{ get; set; }

		[ProtoMember(9)]
		public int memberover{ get; set; }

		[ProtoMember(10)]
		public MentorGuide mentorguide{ get; set; }

		[ProtoMember(11)]
		public int online{ get; set; }


		internal MentorMainInfo()
		{
			this.id = 0;
			this.level = 0;
			this.exp = 0;
			this.notice ="";
			this.info ="";
			this.master ="";
			this.masterlv = 0;
			this.reward = new MentorReward();
			this.memberover = 0;
			this.mentorguide = new MentorGuide();
			this.online = 0;
		}

	}

}
