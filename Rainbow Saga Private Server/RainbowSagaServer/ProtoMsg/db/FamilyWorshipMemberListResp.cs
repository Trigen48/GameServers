using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FamilyWorshipMemberListResp
	{

		[ProtoMember(1)]
		public List<FamilyWorshipMember> list{ get; set; }


		internal FamilyWorshipMemberListResp()
		{
			this.list = new List<FamilyWorshipMember>();
		}

	}

}
