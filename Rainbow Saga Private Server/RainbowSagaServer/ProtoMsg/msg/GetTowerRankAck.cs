using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetTowerRankAck
	{

		[ProtoMember(1)]
		public int myrank{ get; set; }

		[ProtoMember(2)]
		public List<TowerRankInfo> infos{ get; set; }


		internal GetTowerRankAck()
		{
			this.myrank = 0;
			this.infos = new List<TowerRankInfo>();
		}

	}

}
