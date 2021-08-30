using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateMountEquipOn
	{

		[ProtoMember(1)]
		public List<EquipOnInfo> items{ get; set; }

		[ProtoMember(5)]
		public int unused{ get; set; }


		internal UpdateMountEquipOn()
		{
			this.items = new List<EquipOnInfo>();
			this.unused = 0;
		}

	}

}
