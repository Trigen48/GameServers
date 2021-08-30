using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyApplicantList
	{

		[ProtoMember(1)]
		public List<FmlyAppInfo> infos{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }


		internal FmlyApplicantList()
		{
			this.infos = new List<FmlyAppInfo>();
			this.num = 0;
		}

	}

}
