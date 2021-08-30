using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdateAvatar
	{

		[ProtoMember(1)]
		public int updateType{ get; set; }

		[ProtoMember(2)]
		public int fashionEquiponPreDisplay{ get; set; }

		[ProtoMember(3)]
		public int skinType{ get; set; }

		[ProtoMember(4)]
		public int hair{ get; set; }

		[ProtoMember(5)]
		public int face{ get; set; }

		[ProtoMember(6)]
		public EquipmentInventory equipons{ get; set; }

		[ProtoMember(7)]
		public int charId{ get; set; }

		[ProtoMember(8)]
		public int wingDisplay{ get; set; }

		[ProtoMember(9)]
		public int foDisplay{ get; set; }

		[ProtoMember(10)]
		public int gender{ get; set; }


		internal UpdateAvatar()
		{
			this.updateType = 0;
			this.fashionEquiponPreDisplay = 0;
			this.skinType = 0;
			this.hair = 0;
			this.face = 0;
			this.equipons = new EquipmentInventory();
			this.charId = 0;
			this.wingDisplay = 0;
			this.foDisplay = 0;
			this.gender = 0;
		}

	}

}
