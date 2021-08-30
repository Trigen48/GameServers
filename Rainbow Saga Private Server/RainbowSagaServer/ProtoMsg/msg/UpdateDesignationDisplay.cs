using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdateDesignationDisplay
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public int charId{ get; set; }


		internal UpdateDesignationDisplay()
		{
			this.op = 0;
			this.id = 0;
			this.charId = 0;
		}

	}

}
