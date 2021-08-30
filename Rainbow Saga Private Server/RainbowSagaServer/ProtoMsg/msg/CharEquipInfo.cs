using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CharEquipInfo
	{

		[ProtoMember(1)]
		public uint id{ get; set; }

		[ProtoMember(2)]
		public int position{ get; set; }

		[ProtoMember(3)]
		public uint remaining{ get; set; }


		internal CharEquipInfo()
		{
			this.id = 0;
			this.position = 0;
			this.remaining = 0;
		}

	}

}
