using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ExplorationInfo
	{

		[ProtoMember(1)]
		public ExplorationData data{ get; set; }

		[ProtoMember(2)]
		public ExplorationLog log{ get; set; }


		internal ExplorationInfo()
		{
			this.data = new ExplorationData();
			this.log = new ExplorationLog();
		}

	}

}
