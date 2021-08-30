using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLineRankElement
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int level{ get; set; }

		[ProtoMember(4)]
		public int rank{ get; set; }

		[ProtoMember(5)]
		public int combat{ get; set; }

		[ProtoMember(6)]
		public int profession{ get; set; }


		internal OffLineRankElement()
		{
			this.charid = 0;
			this.charname ="";
			this.level = 0;
			this.rank = 0;
			this.combat = 0;
			this.profession = 0;
		}

	}

}
