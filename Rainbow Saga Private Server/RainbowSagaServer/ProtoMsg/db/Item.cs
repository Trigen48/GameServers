using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class Item
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public string itemname{ get; set; }

		[ProtoMember(4)]
		public int quality{ get; set; }

		[ProtoMember(5)]
		public int state{ get; set; }

		[ProtoMember(7)]
		public ItemProp traitProp{ get; set; }

		[ProtoMember(8)]
		public List<ItemProp> randomProp{ get; set; }

		[ProtoMember(9)]
		public ItemProp daimonProp{ get; set; }

		[ProtoMember(10)]
		public ItemProp refineProp{ get; set; }

		[ProtoMember(19)]
		public EnchantPropsOnEquip enchantPropsOnEquip{ get; set; }

		[ProtoMember(11)]
		public int gemSlotNum{ get; set; }

		[ProtoMember(12)]
		public List<Item> gems{ get; set; }

		[ProtoMember(16)]
		public int expired{ get; set; }

		[ProtoMember(17)]
		public int remaining{ get; set; }

		[ProtoMember(18)]
		public int source{ get; set; }

		[ProtoMember(20)]
		public ItemProp refineProp0{ get; set; }

		[ProtoMember(21)]
		public int degree{ get; set; }

		[ProtoMember(22)]
		public string propstr{ get; set; }

		[ProtoMember(23)]
		public VechantEquip vechantEquip{ get; set; }


		internal Item()
		{
			this.uuid = 0;
			this.id = 0;
			this.itemname ="";
			this.quality = 0;
			this.state = 0;
			this.traitProp = new ItemProp();
			this.randomProp = new List<ItemProp>();
			this.daimonProp = new ItemProp();
			this.refineProp = new ItemProp();
			this.enchantPropsOnEquip = new EnchantPropsOnEquip();
			this.gemSlotNum = 0;
			this.gems = new List<Item>();
			this.expired = 0;
			this.remaining = 0;
			this.source = 0;
			this.refineProp0 = new ItemProp();
			this.degree = 0;
			this.propstr ="";
			this.vechantEquip = new VechantEquip();
		}

	}

}
