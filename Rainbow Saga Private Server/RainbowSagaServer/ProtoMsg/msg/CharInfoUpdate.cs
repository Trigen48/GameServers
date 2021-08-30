using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CharInfoUpdate
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }

		[ProtoMember(3)]
		public int profession{ get; set; }

		[ProtoMember(4)]
		public int online{ get; set; }


		internal CharInfoUpdate()
		{
			this.charname ="";
			this.level = 0;
			this.profession = 0;
			this.online = 0;
		}

	}

}
