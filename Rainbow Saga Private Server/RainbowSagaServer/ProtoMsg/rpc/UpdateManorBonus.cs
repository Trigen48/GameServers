using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateManorBonus
	{

		[ProtoMember(1)]
		public int manorBonus{ get; set; }

		[ProtoMember(2)]
		public int manorBonusDaily{ get; set; }


		internal UpdateManorBonus()
		{
			this.manorBonus = 0;
			this.manorBonusDaily = 0;
		}

	}

}
