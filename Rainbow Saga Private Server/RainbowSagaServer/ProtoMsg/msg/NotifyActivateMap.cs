using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyActivateMap
	{

		[ProtoMember(1)]
		public int mapid{ get; set; }


		internal NotifyActivateMap()
		{
			this.mapid = 0;
		}

	}

}
