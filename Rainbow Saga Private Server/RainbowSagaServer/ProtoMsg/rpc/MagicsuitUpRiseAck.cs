using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MagicsuitUpRiseAck
	{

		[ProtoMember(1)]
		public int exp{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }


		internal MagicsuitUpRiseAck()
		{
			this.exp = 0;
			this.level = 0;
		}

	}

}
