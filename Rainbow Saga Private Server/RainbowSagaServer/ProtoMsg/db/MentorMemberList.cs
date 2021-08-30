using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorMemberList
	{

		[ProtoMember(1)]
		public List<MentorMemberInfo> infos{ get; set; }


		internal MentorMemberList()
		{
			this.infos = new List<MentorMemberInfo>();
		}

	}

}
