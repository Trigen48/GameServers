using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyNewsAck
	{

		[ProtoMember(1)]
		public long familyid{ get; set; }

		[ProtoMember(2)]
		public FmlyNews news{ get; set; }


		internal GetFamilyNewsAck()
		{
			this.familyid = 0;
			this.news = new FmlyNews();
		}

	}

}
