using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetRankDescript
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int charid{ get; set; }

		[ProtoMember(3)]
		public int rank{ get; set; }

		[ProtoMember(4)]
		public Pet bPet{ get; set; }


		internal PetRankDescript()
		{
			this.charname ="";
			this.charid = 0;
			this.rank = 0;
			this.bPet = new Pet();
		}

	}

}
