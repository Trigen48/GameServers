using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Ability
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int lv{ get; set; }

		[ProtoMember(3)]
		public int exp{ get; set; }


		internal Ability()
		{
			this.id = 0;
			this.lv = 0;
			this.exp = 0;
		}

	}

}
