using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SeabedGrop
	{

		[ProtoMember(1)]
		public List<SeabedCharDetail> data{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }


		internal SeabedGrop()
		{
			this.data = new List<SeabedCharDetail>();
			this.num = 0;
		}

	}

}
