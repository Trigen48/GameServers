using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SetPartyBlessingData
	{

		[ProtoMember(1)]
		public PartyBlessingData data{ get; set; }

		[ProtoMember(2)]
		public int rewards{ get; set; }


		internal SetPartyBlessingData()
		{
			this.data = new PartyBlessingData();
			this.rewards = 0;
		}

	}

}
