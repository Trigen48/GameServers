using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyList
	{

		[ProtoMember(1)]
		public string familyname{ get; set; }

		[ProtoMember(2)]
		public string leadername{ get; set; }

		[ProtoMember(3)]
		public int page{ get; set; }


		internal GetFamilyList()
		{
			this.familyname ="";
			this.leadername ="";
			this.page = 0;
		}

	}

}
