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
	internal class ActivityUpdateData
	{

		[ProtoMember(1)]
		public int i{ get; set; }

		[ProtoMember(2)]
		public ActivityData data{ get; set; }


		internal ActivityUpdateData()
		{
			this.i = 0;
			this.data = new ActivityData();
		}

	}

}
