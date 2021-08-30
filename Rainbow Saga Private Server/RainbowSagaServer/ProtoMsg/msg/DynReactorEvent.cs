using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DynReactorEvent
	{

		[ProtoMember(1)]
		public int eventType{ get; set; }

		[ProtoMember(2)]
		public int uuid{ get; set; }

		[ProtoMember(10)]
		public int Params{ get; set; }


		internal DynReactorEvent()
		{
			this.eventType = 0;
			this.uuid = 0;
			this.Params = 0;
		}

	}

}
