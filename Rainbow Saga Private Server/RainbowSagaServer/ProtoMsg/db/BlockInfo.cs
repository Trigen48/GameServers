using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class BlockInfo
	{

		[ProtoMember(1)]
		public string peername{ get; set; }

		[ProtoMember(5)]
		public int level{ get; set; }

		[ProtoMember(6)]
		public int profession{ get; set; }

		[ProtoMember(7)]
		public int online{ get; set; }

		[ProtoMember(8)]
		public int gender{ get; set; }


		internal BlockInfo()
		{
			this.peername ="";
			this.level = 0;
			this.profession = 0;
			this.online = 0;
			this.gender = 0;
		}

	}

}
