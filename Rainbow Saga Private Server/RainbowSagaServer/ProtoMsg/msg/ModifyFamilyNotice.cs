using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ModifyFamilyNotice
	{

		[ProtoMember(1, IsRequired=true)]
		public string notice{ get; set; }


		internal ModifyFamilyNotice()
		{
			this.notice ="";
		}

	}

}
