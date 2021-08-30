using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DungeonCardList
	{

		[ProtoMember(1)]
		public int dgninstanceid{ get; set; }

		[ProtoMember(2)]
		public int itemids{ get; set; }


		internal DungeonCardList()
		{
			this.dgninstanceid = 0;
			this.itemids = 0;
		}

	}

}
