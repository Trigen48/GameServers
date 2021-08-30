using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class HpMpInfo
	{

		[ProtoMember(1, IsRequired=true)]
		public string rolename{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int hp{ get; set; }

		[ProtoMember(3, IsRequired=true)]
		public int maxhp{ get; set; }

		[ProtoMember(4, IsRequired=true)]
		public int mp{ get; set; }

		[ProtoMember(5, IsRequired=true)]
		public int maxmp{ get; set; }


		internal HpMpInfo()
		{
			this.rolename ="";
			this.hp = 0;
			this.maxhp = 0;
			this.mp = 0;
			this.maxmp = 0;
		}

	}

}
