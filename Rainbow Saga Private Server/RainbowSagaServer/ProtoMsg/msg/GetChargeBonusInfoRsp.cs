using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetChargeBonusInfoRsp
	{

		[ProtoMember(1)]
		public int charge{ get; set; }

		[ProtoMember(2)]
		public int bonus{ get; set; }

		[ProtoMember(3)]
		public int usedBonus{ get; set; }


		internal GetChargeBonusInfoRsp()
		{
			this.charge = 0;
			this.bonus = 0;
			this.usedBonus = 0;
		}

	}

}
