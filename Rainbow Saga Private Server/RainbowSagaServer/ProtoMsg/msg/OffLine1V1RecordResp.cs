using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLine1V1RecordResp
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public List<OffLine1V1Record> recordList{ get; set; }


		internal OffLine1V1RecordResp()
		{
			this.result = 0;
			this.recordList = new List<OffLine1V1Record>();
		}

	}

}
