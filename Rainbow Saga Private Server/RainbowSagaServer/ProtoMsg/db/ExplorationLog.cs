using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ExplorationLog
	{

		[ProtoMember(1)]
		public string infos{ get; set; }


		internal ExplorationLog()
		{
			this.infos ="";
		}

	}

}
