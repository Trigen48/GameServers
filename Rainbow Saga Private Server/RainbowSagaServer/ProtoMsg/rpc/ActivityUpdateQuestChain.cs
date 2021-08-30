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
	internal class ActivityUpdateQuestChain
	{

		[ProtoMember(1)]
		public int i{ get; set; }

		[ProtoMember(2)]
		public int j{ get; set; }

		[ProtoMember(3)]
		public ActivityQuestChain quest{ get; set; }


		internal ActivityUpdateQuestChain()
		{
			this.i = 0;
			this.j = 0;
			this.quest = new ActivityQuestChain();
		}

	}

}
