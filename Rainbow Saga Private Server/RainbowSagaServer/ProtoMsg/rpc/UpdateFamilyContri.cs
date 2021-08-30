using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateFamilyContri
	{

		[ProtoMember(1)]
		public int contri{ get; set; }


		internal UpdateFamilyContri()
		{
			this.contri = 0;
		}

	}

}
