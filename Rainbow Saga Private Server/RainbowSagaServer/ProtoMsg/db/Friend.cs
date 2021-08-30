using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class Friend
	{

		[ProtoMember(1)]
		public string peername{ get; set; }

		[ProtoMember(2)]
		public int createtime{ get; set; }

		[ProtoMember(3)]
		public int friendship{ get; set; }

		[ProtoMember(4)]
		public int chattime{ get; set; }

		[ProtoMember(5)]
		public int level{ get; set; }

		[ProtoMember(6)]
		public int profession{ get; set; }

		[ProtoMember(7)]
		public int online{ get; set; }

		[ProtoMember(8)]
		public int gender{ get; set; }

		[ProtoMember(9)]
		public int tencentBlue{ get; set; }


		internal Friend()
		{
			this.peername ="";
			this.createtime = 0;
			this.friendship = 0;
			this.chattime = 0;
			this.level = 0;
			this.profession = 0;
			this.online = 0;
			this.gender = 0;
			this.tencentBlue = 0;
		}

	}

}
