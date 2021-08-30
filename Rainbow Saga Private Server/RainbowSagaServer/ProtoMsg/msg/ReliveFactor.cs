using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ReliveFactor
	{

		[ProtoMember(1)]
		public int hpfactor{ get; set; }

		[ProtoMember(2)]
		public int expfactor{ get; set; }


		internal ReliveFactor()
		{
			this.hpfactor = 0;
			this.expfactor = 0;
		}

	}

}
