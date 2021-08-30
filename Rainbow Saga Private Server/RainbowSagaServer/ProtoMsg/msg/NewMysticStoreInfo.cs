using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NewMysticStoreInfo
	{

		[ProtoMember(1)]
		public int leftpurtimes{ get; set; }

		[ProtoMember(2)]
		public int nextreftime{ get; set; }

		[ProtoMember(3)]
		public int treasureleftreftimes{ get; set; }

		[ProtoMember(4)]
		public int extremeleftreftimes{ get; set; }

		[ProtoMember(5)]
		public List<NewMysticStoreItem> jewelboxitems{ get; set; }

		[ProtoMember(6)]
		public List<NewMysticStoreItem> treasureboxitems{ get; set; }

		[ProtoMember(7)]
		public List<NewMysticStoreItem> extremevalueboxitems{ get; set; }

		[ProtoMember(8)]
		public int lasttime{ get; set; }


		internal NewMysticStoreInfo()
		{
			this.leftpurtimes = 0;
			this.nextreftime = 0;
			this.treasureleftreftimes = 0;
			this.extremeleftreftimes = 0;
			this.jewelboxitems = new List<NewMysticStoreItem>();
			this.treasureboxitems = new List<NewMysticStoreItem>();
			this.extremevalueboxitems = new List<NewMysticStoreItem>();
			this.lasttime = 0;
		}

	}

}
