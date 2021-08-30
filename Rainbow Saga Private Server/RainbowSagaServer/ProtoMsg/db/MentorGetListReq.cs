using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorGetListReq
	{

		[ProtoMember(1)]
		public int page{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public string master{ get; set; }

		[ProtoMember(4)]
		public int online{ get; set; }


		internal MentorGetListReq()
		{
			this.page = 0;
			this.type = 0;
			this.master ="";
			this.online = 0;
		}

	}

}
