using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class HaveExistedDungeonRet
	{

		[ProtoMember(1)]
		public int dungeonid{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int ret{ get; set; }

		[ProtoMember(4)]
		public int single{ get; set; }


		internal HaveExistedDungeonRet()
		{
			this.dungeonid = 0;
			this.type = 0;
			this.ret = 0;
			this.single = 0;
		}

	}

}
