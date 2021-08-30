using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MountLevelUp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }

		[ProtoMember(3)]
		public int exp{ get; set; }

		[ProtoMember(4)]
		public int critNum{ get; set; }

		[ProtoMember(5)]
		public int num{ get; set; }

		[ProtoMember(6)]
		public int gainExp{ get; set; }


		internal MountLevelUp()
		{
			this.op = 0;
			this.level = 0;
			this.exp = 0;
			this.critNum = 0;
			this.num = 0;
			this.gainExp = 0;
		}

	}

}
