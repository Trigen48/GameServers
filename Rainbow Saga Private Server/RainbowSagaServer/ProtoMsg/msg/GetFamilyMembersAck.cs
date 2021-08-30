using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyMembersAck
	{

		[ProtoMember(1, IsRequired=true)]
		public long familyid{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public FmlyMemberList members{ get; set; }


		internal GetFamilyMembersAck()
		{
			this.familyid = 0;
			this.members = new FmlyMemberList();
		}

	}

}
