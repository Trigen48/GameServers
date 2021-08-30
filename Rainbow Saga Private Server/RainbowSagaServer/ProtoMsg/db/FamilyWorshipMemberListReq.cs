using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FamilyWorshipMemberListReq
	{

		[ProtoMember(1)]
		public int familyid{ get; set; }


		internal FamilyWorshipMemberListReq()
		{
			this.familyid = 0;
		}

	}

}
