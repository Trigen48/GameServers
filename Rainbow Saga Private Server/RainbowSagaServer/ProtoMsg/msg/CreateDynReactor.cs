using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CreateDynReactor
	{

		[ProtoMember(1)]
		public int uuid{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int id{ get; set; }

		[ProtoMember(4)]
		public int x{ get; set; }

		[ProtoMember(5)]
		public int y{ get; set; }

		[ProtoMember(6)]
		public int initState{ get; set; }

		[ProtoMember(10)]
		public int Params{ get; set; }


		internal CreateDynReactor()
		{
			this.uuid = 0;
			this.type = 0;
			this.id = 0;
			this.x = 0;
			this.y = 0;
			this.initState = 0;
			this.Params = 0;
		}

	}

}
