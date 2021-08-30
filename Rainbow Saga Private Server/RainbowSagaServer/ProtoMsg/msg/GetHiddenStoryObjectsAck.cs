using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetHiddenStoryObjectsAck
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public string objs{ get; set; }


		internal GetHiddenStoryObjectsAck()
		{
			this.unused = 0;
			this.objs ="";
		}

	}

}
