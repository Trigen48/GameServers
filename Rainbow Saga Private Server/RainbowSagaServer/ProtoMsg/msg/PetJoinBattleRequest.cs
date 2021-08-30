using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetJoinBattleRequest
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }


		internal PetJoinBattleRequest()
		{
			this.uuid = 0;
		}

	}

}
