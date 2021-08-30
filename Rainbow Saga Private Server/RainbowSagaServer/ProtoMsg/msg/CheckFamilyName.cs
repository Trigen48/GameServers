using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CheckFamilyName
	{

		[ProtoMember(1, IsRequired=true)]
		public string name{ get; set; }


		internal CheckFamilyName()
		{
			this.name ="";
		}

	}

}
