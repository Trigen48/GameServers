using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterWorldBossDungeon
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }


		internal EnterWorldBossDungeon()
		{
			this.dgnid = 0;
			this.charname ="";
		}

	}

}
