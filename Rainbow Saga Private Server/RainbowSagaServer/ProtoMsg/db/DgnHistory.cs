using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DgnHistory
	{

		[ProtoMember(1)]
		public int templateid{ get; set; }

		[ProtoMember(3)]
		public List<DgnEvalution> evaluations{ get; set; }


		internal DgnHistory()
		{
			this.templateid = 0;
			this.evaluations = new List<DgnEvalution>();
		}

	}

}
