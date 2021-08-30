using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PetImproveResult
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int grade{ get; set; }

		[ProtoMember(3)]
		public int result{ get; set; }

		[ProtoMember(4)]
		public int upgradeBonus{ get; set; }


		internal PetImproveResult()
		{
			this.uuid = 0;
			this.grade = 0;
			this.result = 0;
			this.upgradeBonus = 0;
		}

	}

}
