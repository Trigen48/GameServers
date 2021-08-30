using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SeabedDetail
	{

		[ProtoMember(1)]
		public SeabedGrop group1{ get; set; }

		[ProtoMember(2)]
		public SeabedGrop group2{ get; set; }

		[ProtoMember(3)]
		public SeabedOtherInfo info{ get; set; }


		internal SeabedDetail()
		{
			this.group1 = new SeabedGrop();
			this.group2 = new SeabedGrop();
			this.info = new SeabedOtherInfo();
		}

	}

}
