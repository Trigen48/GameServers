using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ThreeDiabetes
	{

		[ProtoMember(1)]
		public int threeDiabetesBonus{ get; set; }

		[ProtoMember(2)]
		public ThreeDiabetesInfo gameinfo{ get; set; }


		internal ThreeDiabetes()
		{
			this.threeDiabetesBonus = 0;
			this.gameinfo = new ThreeDiabetesInfo();
		}

	}

}
