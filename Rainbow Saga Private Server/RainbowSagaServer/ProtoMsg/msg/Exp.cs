using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Exp
	{

		[ProtoMember(1)]
		public int exp{ get; set; }


		internal Exp()
		{
			this.exp = 0;
		}

	}

}
