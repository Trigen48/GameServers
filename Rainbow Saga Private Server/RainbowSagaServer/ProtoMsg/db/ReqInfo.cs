using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ReqInfo
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int reqtime{ get; set; }

		[ProtoMember(3)]
		public int level{ get; set; }

		[ProtoMember(4)]
		public int profession{ get; set; }


		internal ReqInfo()
		{
			this.charname ="";
			this.reqtime = 0;
			this.level = 0;
			this.profession = 0;
		}

	}

}
