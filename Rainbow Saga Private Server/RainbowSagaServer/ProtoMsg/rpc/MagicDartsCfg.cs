using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MagicDartsCfg
	{

		[ProtoMember(1)]
		public int dartNum{ get; set; }

		[ProtoMember(2)]
		public int needCrystal{ get; set; }

		[ProtoMember(3)]
		public int pushItem{ get; set; }

		[ProtoMember(4)]
		public int poolId{ get; set; }

		[ProtoMember(5)]
		public int index{ get; set; }


		internal MagicDartsCfg()
		{
			this.dartNum = 0;
			this.needCrystal = 0;
			this.pushItem = 0;
			this.poolId = 0;
			this.index = 0;
		}

	}

}
