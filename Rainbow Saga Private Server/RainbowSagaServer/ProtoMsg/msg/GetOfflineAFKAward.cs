using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetOfflineAFKAward
	{

		[ProtoMember(1)]
		public int type{ get; set; }


		internal GetOfflineAFKAward()
		{
			this.type = 0;
		}

	}

}
