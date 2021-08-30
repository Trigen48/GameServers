using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyLog
	{

		[ProtoMember(1)]
		public List<FmlyLogInfo> infos{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }

		[ProtoMember(3)]
		public FmlyNews news{ get; set; }


		internal FmlyLog()
		{
			this.infos = new List<FmlyLogInfo>();
			this.num = 0;
			this.news = new FmlyNews();
		}

	}

}
