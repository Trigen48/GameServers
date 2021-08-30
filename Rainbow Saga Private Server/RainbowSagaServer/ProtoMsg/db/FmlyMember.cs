using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyMember
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }

		[ProtoMember(3)]
		public int profession{ get; set; }

		[ProtoMember(4)]
		public int position{ get; set; }

		[ProtoMember(5)]
		public int contriToday{ get; set; }

		[ProtoMember(10)]
		public int contriTime{ get; set; }

		[ProtoMember(6)]
		public int contriTotal{ get; set; }

		[ProtoMember(12)]
		public int contriCur{ get; set; }

		[ProtoMember(7)]
		public string title{ get; set; }

		[ProtoMember(8)]
		public int online{ get; set; }

		[ProtoMember(9)]
		public int forbidtalk{ get; set; }

		[ProtoMember(11)]
		public int logoutTime{ get; set; }

		[ProtoMember(13)]
		public int joinTime{ get; set; }

		[ProtoMember(14)]
		public AllBodyTouchTimesInfo allBodyTouchTimesInfo{ get; set; }

		[ProtoMember(15)]
		public FmlyMemberManor manor{ get; set; }


		internal FmlyMember()
		{
			this.charname ="";
			this.level = 0;
			this.profession = 0;
			this.position = 0;
			this.contriToday = 0;
			this.contriTime = 0;
			this.contriTotal = 0;
			this.contriCur = 0;
			this.title ="";
			this.online = 0;
			this.forbidtalk = 0;
			this.logoutTime = 0;
			this.joinTime = 0;
			this.allBodyTouchTimesInfo = new AllBodyTouchTimesInfo();
			this.manor = new FmlyMemberManor();
		}

	}

}
