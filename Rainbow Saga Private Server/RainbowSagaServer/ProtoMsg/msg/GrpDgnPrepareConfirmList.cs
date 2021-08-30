using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GrpDgnPrepareConfirmList
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int seqid{ get; set; }

		[ProtoMember(3)]
		public List<GrpDgnPrepareConfirm> infos{ get; set; }


		internal GrpDgnPrepareConfirmList()
		{
			this.dgnid = 0;
			this.seqid = 0;
			this.infos = new List<GrpDgnPrepareConfirm>();
		}

	}

}
