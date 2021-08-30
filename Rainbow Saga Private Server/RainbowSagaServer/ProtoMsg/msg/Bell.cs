using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Bell
	{

		[ProtoMember(1)]
		public List<BellInfo> infos{ get; set; }


		internal Bell()
		{
			this.infos = new List<BellInfo>();
		}

	}

}
