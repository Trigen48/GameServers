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
	internal class GetFamilyListAck
	{

		[ProtoMember(1)]
		public int totalpage{ get; set; }

		[ProtoMember(2)]
		public List<FmlyBrief> list{ get; set; }


		internal GetFamilyListAck()
		{
			this.totalpage = 0;
			this.list = new List<FmlyBrief>();
		}

	}

}
