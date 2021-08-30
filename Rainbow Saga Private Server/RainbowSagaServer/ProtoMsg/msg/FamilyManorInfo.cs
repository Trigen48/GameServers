using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FamilyManorInfo
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public long ownerFamilyId{ get; set; }

		[ProtoMember(3)]
		public int defenceNum{ get; set; }

		[ProtoMember(4)]
		public int offenceNum{ get; set; }

		[ProtoMember(5)]
		public string ownerFamilyName{ get; set; }


		internal FamilyManorInfo()
		{
			this.id = 0;
			this.ownerFamilyId = 0;
			this.defenceNum = 0;
			this.offenceNum = 0;
			this.ownerFamilyName ="";
		}

	}

}
