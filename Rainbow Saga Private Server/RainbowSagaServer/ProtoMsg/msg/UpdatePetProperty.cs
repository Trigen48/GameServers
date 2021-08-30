using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.game;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdatePetProperty
	{

		[ProtoMember(1)]
		public int unitId{ get; set; }

		[ProtoMember(2)]
		public UnitProperties props{ get; set; }


		internal UpdatePetProperty()
		{
			this.unitId = 0;
			this.props = new UnitProperties();
		}

	}

}
