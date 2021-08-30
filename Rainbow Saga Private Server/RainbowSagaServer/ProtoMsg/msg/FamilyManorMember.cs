using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FamilyManorMember
	{

		[ProtoMember(1)]
		public int charId{ get; set; }

		[ProtoMember(2)]
		public string charName{ get; set; }

		[ProtoMember(3)]
		public int gender{ get; set; }

		[ProtoMember(4)]
		public int position{ get; set; }

		[ProtoMember(5)]
		public int profession{ get; set; }

		[ProtoMember(6)]
		public int level{ get; set; }

		[ProtoMember(7)]
		public int combat{ get; set; }

		[ProtoMember(8)]
		public string familyName{ get; set; }

		[ProtoMember(9)]
		public int manorId{ get; set; }

		[ProtoMember(10)]
		public long familyId{ get; set; }


		internal FamilyManorMember()
		{
			this.charId = 0;
			this.charName ="";
			this.gender = 0;
			this.position = 0;
			this.profession = 0;
			this.level = 0;
			this.combat = 0;
			this.familyName ="";
			this.manorId = 0;
			this.familyId = 0;
		}

	}

}
