using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class WeddingMsg
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public string wedding{ get; set; }

		[ProtoMember(4)]
		public string charname{ get; set; }

		[ProtoMember(5)]
		public int intimacymax{ get; set; }

		[ProtoMember(6)]
		public int intimacy{ get; set; }

		[ProtoMember(7)]
		public string malename{ get; set; }

		[ProtoMember(8)]
		public string femalename{ get; set; }


		internal WeddingMsg()
		{
			this.op = 0;
			this.result = 0;
			this.wedding ="";
			this.charname ="";
			this.intimacymax = 0;
			this.intimacy = 0;
			this.malename ="";
			this.femalename ="";
		}

	}

}
