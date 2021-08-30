using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DgnKillMobNum
	{

		[ProtoMember(1)]
		public int killmobnum{ get; set; }

		[ProtoMember(2)]
		public int totalmobnum{ get; set; }


		internal DgnKillMobNum()
		{
			this.killmobnum = 0;
			this.totalmobnum = 0;
		}

	}

}
