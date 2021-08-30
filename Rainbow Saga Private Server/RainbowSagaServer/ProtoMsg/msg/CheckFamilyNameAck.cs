using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CheckFamilyNameAck
	{

		[ProtoMember(1, IsRequired=true)]
		public string name{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public long familyid{ get; set; }


		internal CheckFamilyNameAck()
		{
			this.name ="";
			this.result = 0;
			this.familyid = 0;
		}

	}

}
