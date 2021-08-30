using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorInfo
	{

		[ProtoMember(1)]
		public MentorMainInfo main{ get; set; }

		[ProtoMember(2)]
		public MentorMemberList members{ get; set; }


		internal MentorInfo()
		{
			this.main = new MentorMainInfo();
			this.members = new MentorMemberList();
		}

	}

}
