using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorApplyInfo
	{

		[ProtoMember(1)]
		public MentorMemberInfo info{ get; set; }

		[ProtoMember(2)]
		public int applytime{ get; set; }


		internal MentorApplyInfo()
		{
			this.info = new MentorMemberInfo();
			this.applytime = 0;
		}

	}

}
