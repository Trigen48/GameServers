using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorMemberInfoSync
	{

		[ProtoMember(1)]
		public MentorMemberInfo info{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }


		internal MentorMemberInfoSync()
		{
			this.info = new MentorMemberInfo();
			this.type = 0;
		}

	}

}
