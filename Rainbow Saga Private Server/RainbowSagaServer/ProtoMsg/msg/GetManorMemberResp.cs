using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetManorMemberResp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public List<FamilyManorMember> members{ get; set; }


		internal GetManorMemberResp()
		{
			this.op = 0;
			this.members = new List<FamilyManorMember>();
		}

	}

}
