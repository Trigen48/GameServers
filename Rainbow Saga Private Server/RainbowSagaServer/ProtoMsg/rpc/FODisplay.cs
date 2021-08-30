using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class FODisplay
	{

		[ProtoMember(1)]
		public int display{ get; set; }


		internal FODisplay()
		{
			this.display = 0;
		}

	}

}
