using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UseNpc
	{

		[ProtoMember(1)]
		public int id{ get; set; }


		internal UseNpc()
		{
			this.id = 0;
		}

	}

}
