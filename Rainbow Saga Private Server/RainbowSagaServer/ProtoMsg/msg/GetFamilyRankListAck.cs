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
	internal class GetFamilyRankListAck
	{

		[ProtoMember(1)]
		public int totalPage{ get; set; }

		[ProtoMember(2)]
		public List<FmlyBrief> list{ get; set; }

		[ProtoMember(3)]
		public int curlv{ get; set; }


		internal GetFamilyRankListAck()
		{
			this.totalPage = 0;
			this.list = new List<FmlyBrief>();
			this.curlv = 0;
		}

	}

}
