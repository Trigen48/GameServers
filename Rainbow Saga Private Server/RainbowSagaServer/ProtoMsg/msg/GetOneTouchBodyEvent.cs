using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetOneTouchBodyEvent
	{

		[ProtoMember(1)]
		public int bodyid{ get; set; }


		internal GetOneTouchBodyEvent()
		{
			this.bodyid = 0;
		}

	}

}
