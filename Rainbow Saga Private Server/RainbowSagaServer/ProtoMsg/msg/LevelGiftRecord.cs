using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LevelGiftRecord
	{

		[ProtoMember(1)]
		public int levels{ get; set; }


		internal LevelGiftRecord()
		{
			this.levels = 0;
		}

	}

}
