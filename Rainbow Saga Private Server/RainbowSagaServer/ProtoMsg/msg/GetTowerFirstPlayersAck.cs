using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetTowerFirstPlayersAck
	{

		[ProtoMember(1)]
		public string players{ get; set; }


		internal GetTowerFirstPlayersAck()
		{
			this.players ="";
		}

	}

}
