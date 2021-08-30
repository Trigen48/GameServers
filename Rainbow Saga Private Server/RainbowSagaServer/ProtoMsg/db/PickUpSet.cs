using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class PickUpSet
	{

		[ProtoMember(1)]
		public int equipFlag{ get; set; }

		[ProtoMember(2)]
		public int equipQuality{ get; set; }

		[ProtoMember(3)]
		public int materialFlag{ get; set; }

		[ProtoMember(4)]
		public int materialQuality{ get; set; }

		[ProtoMember(5)]
		public int consumeFlag{ get; set; }

		[ProtoMember(6)]
		public int consumeQuality{ get; set; }

		[ProtoMember(7)]
		public int petEggFlag{ get; set; }

		[ProtoMember(8)]
		public int petEggQuality{ get; set; }

		[ProtoMember(9)]
		public int petItemFlag{ get; set; }

		[ProtoMember(10)]
		public int petItemQuality{ get; set; }


		internal PickUpSet()
		{
			this.equipFlag = 0;
			this.equipQuality = 0;
			this.materialFlag = 0;
			this.materialQuality = 0;
			this.consumeFlag = 0;
			this.consumeQuality = 0;
			this.petEggFlag = 0;
			this.petEggQuality = 0;
			this.petItemFlag = 0;
			this.petItemQuality = 0;
		}

	}

}
