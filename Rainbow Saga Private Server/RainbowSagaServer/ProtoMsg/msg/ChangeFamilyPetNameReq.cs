using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ChangeFamilyPetNameReq
	{

		[ProtoMember(1)]
		public string newName{ get; set; }


		internal ChangeFamilyPetNameReq()
		{
			this.newName ="";
		}

	}

}
