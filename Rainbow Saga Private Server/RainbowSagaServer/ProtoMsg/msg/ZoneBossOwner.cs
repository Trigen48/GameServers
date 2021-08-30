using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ZoneBossOwner
	{

		[ProtoMember(1)]
		public int charId{ get; set; }

		[ProtoMember(2)]
		public int killed{ get; set; }


		internal ZoneBossOwner()
		{
			this.charId = 0;
			this.killed = 0;
		}

	}

}
