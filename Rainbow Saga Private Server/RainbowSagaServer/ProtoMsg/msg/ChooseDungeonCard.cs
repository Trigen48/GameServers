using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ChooseDungeonCard
	{

		[ProtoMember(1)]
		public int dgninstanceid{ get; set; }

		[ProtoMember(2)]
		public int index{ get; set; }


		internal ChooseDungeonCard()
		{
			this.dgninstanceid = 0;
			this.index = 0;
		}

	}

}
