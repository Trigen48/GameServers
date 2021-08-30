using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class VechantEquip
	{

		[ProtoMember(1)]
		public List<VechileEquipProp> props{ get; set; }


		internal VechantEquip()
		{
			this.props = new List<VechileEquipProp>();
		}

	}

}
