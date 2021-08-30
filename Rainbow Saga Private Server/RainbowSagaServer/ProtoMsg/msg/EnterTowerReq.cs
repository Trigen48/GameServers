using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterTowerReq
	{

		[ProtoMember(1)]
		public int floor{ get; set; }


		internal EnterTowerReq()
		{
			this.floor = 0;
		}

	}

}
