using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FmlyPet
	{

		[ProtoMember(1)]
		public int times{ get; set; }

		[ProtoMember(2)]
		public int updatetime{ get; set; }

		[ProtoMember(3)]
		public ulong lastjointime{ get; set; }


		internal FmlyPet()
		{
			this.times = 0;
			this.updatetime = 0;
			this.lastjointime = 0;
		}

	}

}
