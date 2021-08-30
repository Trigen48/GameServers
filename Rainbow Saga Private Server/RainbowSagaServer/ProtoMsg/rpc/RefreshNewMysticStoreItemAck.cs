using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class RefreshNewMysticStoreItemAck
	{

		[ProtoMember(1)]
		public int tabnumber{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int purlefttimes{ get; set; }

		[ProtoMember(4)]
		public int nextreftime{ get; set; }

		[ProtoMember(5)]
		public int treasurelefttimes{ get; set; }

		[ProtoMember(6)]
		public int extremevaluelefttimes{ get; set; }

		[ProtoMember(7)]
		public List<NewMysticStoreItem> items{ get; set; }


		internal RefreshNewMysticStoreItemAck()
		{
			this.tabnumber = 0;
			this.result = 0;
			this.purlefttimes = 0;
			this.nextreftime = 0;
			this.treasurelefttimes = 0;
			this.extremevaluelefttimes = 0;
			this.items = new List<NewMysticStoreItem>();
		}

	}

}
