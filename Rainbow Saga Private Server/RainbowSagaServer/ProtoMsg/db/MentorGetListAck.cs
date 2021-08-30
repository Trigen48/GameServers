using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorGetListAck
	{

		[ProtoMember(1)]
		public List<MentorInfo> list{ get; set; }

		[ProtoMember(2)]
		public int totalpage{ get; set; }


		internal MentorGetListAck()
		{
			this.list = new List<MentorInfo>();
			this.totalpage = 0;
		}

	}

}
