using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ArenaTeamOperate
	{

		[ProtoMember(1)]
		public int opt{ get; set; }


		internal ArenaTeamOperate()
		{
			this.opt = 0;
		}

	}

}
