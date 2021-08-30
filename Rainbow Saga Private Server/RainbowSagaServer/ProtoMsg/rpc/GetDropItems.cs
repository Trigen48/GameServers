using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetDropItems
	{

		[ProtoMember(1)]
		public List<GetDropItem> items{ get; set; }

		[ProtoMember(2)]
		public int dropId{ get; set; }


		internal GetDropItems()
		{
			this.items = new List<GetDropItem>();
			this.dropId = 0;
		}

	}

}
