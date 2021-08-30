using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class PartyBlessingData
	{

		[ProtoMember(1)]
		public int blesstimes{ get; set; }

		[ProtoMember(2)]
		public int reward{ get; set; }


		internal PartyBlessingData()
		{
			this.blesstimes = 0;
			this.reward = 0;
		}

	}

}
