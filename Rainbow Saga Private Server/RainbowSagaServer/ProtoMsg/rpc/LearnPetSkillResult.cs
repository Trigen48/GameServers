using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class LearnPetSkillResult
	{

		[ProtoMember(1)]
		public ulong petId{ get; set; }

		[ProtoMember(2)]
		public int skillId{ get; set; }

		[ProtoMember(3)]
		public int skillLevel{ get; set; }

		[ProtoMember(4)]
		public int result{ get; set; }


		internal LearnPetSkillResult()
		{
			this.petId = 0;
			this.skillId = 0;
			this.skillLevel = 0;
			this.result = 0;
		}

	}

}
