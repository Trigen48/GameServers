using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class LevelGiftInfo
	{

		[ProtoMember(1)]
		public List<LevelGiftUnit> info{ get; set; }


		internal LevelGiftInfo()
		{
			this.info = new List<LevelGiftUnit>();
		}

	}

}
