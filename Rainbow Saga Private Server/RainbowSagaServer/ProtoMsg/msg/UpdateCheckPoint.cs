using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdateCheckPoint
	{

		[ProtoMember(1)]
		public int sn{ get; set; }


		internal UpdateCheckPoint()
		{
			this.sn = 0;
		}

	}

}
