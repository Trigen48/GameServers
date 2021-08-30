using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncAllReactors
	{

		[ProtoMember(1)]
		public List<ReactorEvent> reactors{ get; set; }

		[ProtoMember(5)]
		public int unused{ get; set; }


		internal SyncAllReactors()
		{
			this.reactors = new List<ReactorEvent>();
			this.unused = 0;
		}

	}

}
