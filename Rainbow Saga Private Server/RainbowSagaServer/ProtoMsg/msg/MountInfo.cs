using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MountInfo
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public int exp{ get; set; }

		[ProtoMember(3)]
		public int quality{ get; set; }

		[ProtoMember(4)]
		public int qualityExp{ get; set; }

		[ProtoMember(5)]
		public int lastTime{ get; set; }

		[ProtoMember(6)]
		public int mountList{ get; set; }

		[ProtoMember(7)]
		public int vechileId{ get; set; }

		[ProtoMember(8)]
		public int vechileState{ get; set; }

		[ProtoMember(9)]
		public int autoVechile{ get; set; }

		[ProtoMember(10)]
		public EquipmentInventory equipon{ get; set; }


		internal MountInfo()
		{
			this.level = 0;
			this.exp = 0;
			this.quality = 0;
			this.qualityExp = 0;
			this.lastTime = 0;
			this.mountList = 0;
			this.vechileId = 0;
			this.vechileState = 0;
			this.autoVechile = 0;
			this.equipon = new EquipmentInventory();
		}

	}

}
