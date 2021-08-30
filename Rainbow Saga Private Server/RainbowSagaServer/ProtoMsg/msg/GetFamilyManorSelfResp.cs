using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyManorSelfResp
	{

		[ProtoMember(1)]
		public long familyId{ get; set; }

		[ProtoMember(2)]
		public string familyName{ get; set; }

		[ProtoMember(3)]
		public int familyLevel{ get; set; }

		[ProtoMember(4)]
		public int familyPetLevel{ get; set; }

		[ProtoMember(5)]
		public int isLeader{ get; set; }

		[ProtoMember(6)]
		public int boxNum{ get; set; }

		[ProtoMember(7)]
		public int dailyGetted{ get; set; }

		[ProtoMember(8)]
		public int ownManorIds{ get; set; }


		internal GetFamilyManorSelfResp()
		{
			this.familyId = 0;
			this.familyName ="";
			this.familyLevel = 0;
			this.familyPetLevel = 0;
			this.isLeader = 0;
			this.boxNum = 0;
			this.dailyGetted = 0;
			this.ownManorIds = 0;
		}

	}

}
