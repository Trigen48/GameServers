using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CreateFamilyReq
	{

		[ProtoMember(1, IsRequired=true)]
		public string name{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int useCrystal{ get; set; }


		internal CreateFamilyReq()
		{
			this.name ="";
			this.charname ="";
			this.useCrystal = 0;
		}

	}

}
