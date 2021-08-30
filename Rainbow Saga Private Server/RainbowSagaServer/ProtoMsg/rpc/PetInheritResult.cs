using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PetInheritResult
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public ulong sourceUuid{ get; set; }

		[ProtoMember(3)]
		public int sourceGrade{ get; set; }

		[ProtoMember(4)]
		public ulong destUuid{ get; set; }

		[ProtoMember(5)]
		public int destGrade{ get; set; }

		[ProtoMember(6)]
		public int sourceHp{ get; set; }

		[ProtoMember(7)]
		public int sourceExp{ get; set; }

		[ProtoMember(8)]
		public int destExp{ get; set; }

		[ProtoMember(9)]
		public int sourceLevel{ get; set; }

		[ProtoMember(10)]
		public int destLevel{ get; set; }

		[ProtoMember(11)]
		public int sourceBonus{ get; set; }

		[ProtoMember(12)]
		public int destBonus{ get; set; }


		internal PetInheritResult()
		{
			this.result = 0;
			this.sourceUuid = 0;
			this.sourceGrade = 0;
			this.destUuid = 0;
			this.destGrade = 0;
			this.sourceHp = 0;
			this.sourceExp = 0;
			this.destExp = 0;
			this.sourceLevel = 0;
			this.destLevel = 0;
			this.sourceBonus = 0;
			this.destBonus = 0;
		}

	}

}
