using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DoClearNoticeInfoReq
	{

		[ProtoMember(1)]
		public uint areaId{ get; set; }


		internal DoClearNoticeInfoReq()
		{
			this.areaId = 0;
		}

	}

}
