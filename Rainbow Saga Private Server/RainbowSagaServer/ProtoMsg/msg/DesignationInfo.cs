using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DesignationInfo
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int timestamp{ get; set; }

		[ProtoMember(3)]
		public int status{ get; set; }

		[ProtoMember(4)]
		public int num1{ get; set; }

		[ProtoMember(5)]
		public int num2{ get; set; }

		[ProtoMember(6)]
		public int num3{ get; set; }

		[ProtoMember(7)]
		public int num4{ get; set; }

		[ProtoMember(8)]
		public int hide{ get; set; }


		internal DesignationInfo()
		{
			this.id = 0;
			this.timestamp = 0;
			this.status = 0;
			this.num1 = 0;
			this.num2 = 0;
			this.num3 = 0;
			this.num4 = 0;
			this.hide = 0;
		}

	}

}
