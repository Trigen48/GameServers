using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class updateNewbieLoginNum
	{

		[ProtoMember(1)]
		public uint newbieLoginNum{ get; set; }


		internal updateNewbieLoginNum()
		{
			this.newbieLoginNum = 0;
		}

	}

}
