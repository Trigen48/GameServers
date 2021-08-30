using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PlayerInitNotify
	{

		[ProtoMember(1)]
		public int maxExp{ get; set; }


		internal PlayerInitNotify()
		{
			this.maxExp = 0;
		}

	}

}
