using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetFestivalReult
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int itemindex{ get; set; }


		internal GetFestivalReult()
		{
			this.result = 0;
			this.itemindex = 0;
		}

	}

}
