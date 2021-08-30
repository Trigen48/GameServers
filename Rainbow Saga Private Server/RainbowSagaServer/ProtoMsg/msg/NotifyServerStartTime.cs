using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyServerStartTime
	{

		[ProtoMember(1)]
		public uint time{ get; set; }


		internal NotifyServerStartTime()
		{
			this.time = 0;
		}

	}

}
