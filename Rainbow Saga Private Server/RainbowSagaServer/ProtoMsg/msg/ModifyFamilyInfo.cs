using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ModifyFamilyInfo
	{

		[ProtoMember(1, IsRequired=true)]
		public string info{ get; set; }


		internal ModifyFamilyInfo()
		{
			this.info ="";
		}

	}

}
