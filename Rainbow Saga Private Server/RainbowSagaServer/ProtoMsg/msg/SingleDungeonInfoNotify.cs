using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SingleDungeonInfoNotify
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public uint waitTime{ get; set; }

		[ProtoMember(3)]
		public uint leftTime{ get; set; }

		[ProtoMember(4)]
		public uint firstPrepare{ get; set; }


		internal SingleDungeonInfoNotify()
		{
			this.op = 0;
			this.waitTime = 0;
			this.leftTime = 0;
			this.firstPrepare = 0;
		}

	}

}
