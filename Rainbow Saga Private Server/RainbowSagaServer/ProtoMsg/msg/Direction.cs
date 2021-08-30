using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Direction
	{

		[ProtoMember(1)]
		public int dir{ get; set; }


		internal Direction()
		{
			this.dir = 0;
		}

	}

}
