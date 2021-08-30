using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DoSetNoticeInfoReq
	{

		[ProtoMember(1)]
		public uint areaId{ get; set; }

		[ProtoMember(2)]
		public int priority{ get; set; }

		[ProtoMember(3)]
		public uint disapperTime{ get; set; }

		[ProtoMember(4)]
		public string noticeContent{ get; set; }

		[ProtoMember(5)]
		public int entryMode{ get; set; }

		[ProtoMember(6)]
		public int type{ get; set; }

		[ProtoMember(7)]
		public int replace{ get; set; }


		internal DoSetNoticeInfoReq()
		{
			this.areaId = 0;
			this.priority = 0;
			this.disapperTime = 0;
			this.noticeContent ="";
			this.entryMode = 0;
			this.type = 0;
			this.replace = 0;
		}

	}

}
