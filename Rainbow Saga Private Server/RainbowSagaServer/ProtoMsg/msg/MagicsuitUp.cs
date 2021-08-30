using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MagicsuitUp
	{

		[ProtoMember(1)]
		public int star{ get; set; }

		[ProtoMember(2)]
		public int curBless{ get; set; }


		internal MagicsuitUp()
		{
			this.star = 0;
			this.curBless = 0;
		}

	}

}
