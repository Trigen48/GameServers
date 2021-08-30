using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Root
	{

		[ProtoMember(1)]
		public int counter{ get; set; }


		internal Root()
		{
			this.counter = 0;
		}

	}

}
