using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GodshipInfo
	{

		[ProtoMember(1)]
		public int priesthoodBonus{ get; set; }

		[ProtoMember(2)]
		public int priesthoodLevel{ get; set; }

		[ProtoMember(3)]
		public int godship1Level{ get; set; }

		[ProtoMember(4)]
		public int godship2Level{ get; set; }

		[ProtoMember(5)]
		public int godship3Level{ get; set; }

		[ProtoMember(6)]
		public int godship4Level{ get; set; }

		[ProtoMember(7)]
		public int godship5Level{ get; set; }

		[ProtoMember(8)]
		public int godship6Level{ get; set; }

		[ProtoMember(9)]
		public int godship7Level{ get; set; }

		[ProtoMember(10)]
		public int godship8Level{ get; set; }

		[ProtoMember(11)]
		public int godship1Exp{ get; set; }

		[ProtoMember(12)]
		public int godship2Exp{ get; set; }

		[ProtoMember(13)]
		public int godship3Exp{ get; set; }

		[ProtoMember(14)]
		public int godship4Exp{ get; set; }

		[ProtoMember(15)]
		public int godship5Exp{ get; set; }

		[ProtoMember(16)]
		public int godship6Exp{ get; set; }

		[ProtoMember(17)]
		public int godship7Exp{ get; set; }

		[ProtoMember(18)]
		public int godship8Exp{ get; set; }


		internal GodshipInfo()
		{
			this.priesthoodBonus = 0;
			this.priesthoodLevel = 0;
			this.godship1Level = 0;
			this.godship2Level = 0;
			this.godship3Level = 0;
			this.godship4Level = 0;
			this.godship5Level = 0;
			this.godship6Level = 0;
			this.godship7Level = 0;
			this.godship8Level = 0;
			this.godship1Exp = 0;
			this.godship2Exp = 0;
			this.godship3Exp = 0;
			this.godship4Exp = 0;
			this.godship5Exp = 0;
			this.godship6Exp = 0;
			this.godship7Exp = 0;
			this.godship8Exp = 0;
		}

	}

}
