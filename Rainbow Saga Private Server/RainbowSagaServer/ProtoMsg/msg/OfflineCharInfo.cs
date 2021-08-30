using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OfflineCharInfo
	{

		[ProtoMember(1)]
		public uint rank{ get; set; }

		[ProtoMember(2)]
		public uint charid{ get; set; }

		[ProtoMember(3)]
		public string charname{ get; set; }

		[ProtoMember(4)]
		public int gender{ get; set; }

		[ProtoMember(5)]
		public int level{ get; set; }

		[ProtoMember(6)]
		public int profession{ get; set; }

		[ProtoMember(7)]
		public int hair{ get; set; }

		[ProtoMember(8)]
		public int face{ get; set; }

		[ProtoMember(9)]
		public int skinType{ get; set; }

		[ProtoMember(10)]
		public int pvpDmgInc{ get; set; }

		[ProtoMember(11)]
		public int pvpDmgDec{ get; set; }

		[ProtoMember(12)]
		public OffLineProp bOffLineProp{ get; set; }

		[ProtoMember(13)]
		public EquipmentInventory bEquipon{ get; set; }

		[ProtoMember(14)]
		public OffLineRecords bRecord{ get; set; }

		[ProtoMember(15)]
		public int vipLevel{ get; set; }

		[ProtoMember(16)]
		public int pveDmgInc{ get; set; }

		[ProtoMember(17)]
		public int pveDmgDec{ get; set; }


		internal OfflineCharInfo()
		{
			this.rank = 0;
			this.charid = 0;
			this.charname ="";
			this.gender = 0;
			this.level = 0;
			this.profession = 0;
			this.hair = 0;
			this.face = 0;
			this.skinType = 0;
			this.pvpDmgInc = 0;
			this.pvpDmgDec = 0;
			this.bOffLineProp = new OffLineProp();
			this.bEquipon = new EquipmentInventory();
			this.bRecord = new OffLineRecords();
			this.vipLevel = 0;
			this.pveDmgInc = 0;
			this.pveDmgDec = 0;
		}

	}

}
