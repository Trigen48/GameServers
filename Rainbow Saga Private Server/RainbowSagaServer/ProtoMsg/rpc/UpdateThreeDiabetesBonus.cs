using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateThreeDiabetesBonus
	{

		[ProtoMember(1)]
		public int threeDiabetesBonus{ get; set; }


		internal UpdateThreeDiabetesBonus()
		{
			this.threeDiabetesBonus = 0;
		}

	}

}
