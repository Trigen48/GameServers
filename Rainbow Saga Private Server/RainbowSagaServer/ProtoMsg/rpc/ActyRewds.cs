using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ActyRewds
	{

		[ProtoMember(1)]
		public List<ActyRewdUnit> uints{ get; set; }

		[ProtoMember(2)]
		public uint values{ get; set; }


		internal ActyRewds()
		{
			this.uints = new List<ActyRewdUnit>();
			this.values = 0;
		}

	}

}
