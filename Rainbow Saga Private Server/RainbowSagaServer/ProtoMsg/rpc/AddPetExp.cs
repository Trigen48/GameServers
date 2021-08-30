using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class AddPetExp
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int exp{ get; set; }

		[ProtoMember(3)]
		public int level{ get; set; }

		[ProtoMember(4)]
		public int addExp{ get; set; }

		[ProtoMember(5)]
		public int reason{ get; set; }

		[ProtoMember(6)]
		public int hp{ get; set; }


		internal AddPetExp()
		{
			this.uuid = 0;
			this.exp = 0;
			this.level = 0;
			this.addExp = 0;
			this.reason = 0;
			this.hp = 0;
		}

	}

}
