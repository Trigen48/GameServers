using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ChangeSceneAck
	{

		[ProtoMember(1)]
		public int result{ get; set; }


		internal ChangeSceneAck()
		{
			this.result = 0;
		}

	}

}
