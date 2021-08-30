using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyMembers
	{

		[ProtoMember(1, IsRequired=true)]
		public long familyid{ get; set; }


		internal GetFamilyMembers()
		{
			this.familyid = 0;
		}

	}

}
