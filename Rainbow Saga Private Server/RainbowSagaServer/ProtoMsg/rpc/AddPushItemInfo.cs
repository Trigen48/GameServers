using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class AddPushItemInfo
	{

		[ProtoMember(1)]
		public int module{ get; set; }


		internal AddPushItemInfo()
		{
			this.module = 0;
		}

	}

}
