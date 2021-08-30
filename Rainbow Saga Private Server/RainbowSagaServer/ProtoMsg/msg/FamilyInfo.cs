using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FamilyInfo
	{

		[ProtoMember(1)]
		public int fmlyLv{ get; set; }

		[ProtoMember(2)]
		public int fmlySkillLv{ get; set; }

		[ProtoMember(3)]
		public string fmlyName{ get; set; }


		internal FamilyInfo()
		{
			this.fmlyLv = 0;
			this.fmlySkillLv = 0;
			this.fmlyName ="";
		}

	}

}
