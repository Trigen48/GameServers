using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyNews
	{

		[ProtoMember(1)]
		public long familyid{ get; set; }


		internal GetFamilyNews()
		{
			this.familyid = 0;
		}

	}

}
