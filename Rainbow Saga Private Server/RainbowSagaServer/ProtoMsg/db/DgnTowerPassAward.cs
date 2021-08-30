using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DgnTowerPassAward
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public int awarded{ get; set; }


		internal DgnTowerPassAward()
		{
			this.level = 0;
			this.awarded = 0;
		}

	}

}
