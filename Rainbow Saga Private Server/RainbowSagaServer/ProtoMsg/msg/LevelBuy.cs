using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LevelBuy
	{

		[ProtoMember(1)]
		public List<LevelBuyInfo> infos{ get; set; }


		internal LevelBuy()
		{
			this.infos = new List<LevelBuyInfo>();
		}

	}

}
