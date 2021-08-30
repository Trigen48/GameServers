using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RemoveSpritePet
	{

		[ProtoMember(1)]
		public ulong petUuid{ get; set; }

		[ProtoMember(2)]
		public int solt{ get; set; }

		[ProtoMember(3)]
		public int result{ get; set; }


		internal RemoveSpritePet()
		{
			this.petUuid = 0;
			this.solt = 0;
			this.result = 0;
		}

	}

}
