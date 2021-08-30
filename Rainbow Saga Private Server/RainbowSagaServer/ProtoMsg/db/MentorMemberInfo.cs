using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorMemberInfo
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int profession{ get; set; }

		[ProtoMember(3)]
		public int level{ get; set; }

		[ProtoMember(4)]
		public int exp{ get; set; }

		[ProtoMember(5)]
		public int logouttime{ get; set; }

		[ProtoMember(6)]
		public MentorReward reward{ get; set; }

		[ProtoMember(7)]
		public int guided{ get; set; }


		internal MentorMemberInfo()
		{
			this.charname ="";
			this.profession = 0;
			this.level = 0;
			this.exp = 0;
			this.logouttime = 0;
			this.reward = new MentorReward();
			this.guided = 0;
		}

	}

}
