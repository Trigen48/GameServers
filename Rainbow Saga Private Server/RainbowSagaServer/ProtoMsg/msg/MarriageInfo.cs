using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MarriageInfo
	{

		[ProtoMember(1)]
		public int intimacy{ get; set; }

		[ProtoMember(2)]
		public int state{ get; set; }

		[ProtoMember(3)]
		public int ringLevel{ get; set; }

		[ProtoMember(4)]
		public int marriageLevel{ get; set; }

		[ProtoMember(5)]
		public int maleId{ get; set; }

		[ProtoMember(6)]
		public string maleName{ get; set; }

		[ProtoMember(7)]
		public int femaleId{ get; set; }

		[ProtoMember(8)]
		public string femaleName{ get; set; }

		[ProtoMember(9)]
		public int maleLastLogoutTime{ get; set; }

		[ProtoMember(10)]
		public int femaleLastLogoutTime{ get; set; }

		[ProtoMember(11)]
		public int marriageId{ get; set; }

		[ProtoMember(12)]
		public int applydivorcetime{ get; set; }


		internal MarriageInfo()
		{
			this.intimacy = 0;
			this.state = 0;
			this.ringLevel = 0;
			this.marriageLevel = 0;
			this.maleId = 0;
			this.maleName ="";
			this.femaleId = 0;
			this.femaleName ="";
			this.maleLastLogoutTime = 0;
			this.femaleLastLogoutTime = 0;
			this.marriageId = 0;
			this.applydivorcetime = 0;
		}

	}

}
