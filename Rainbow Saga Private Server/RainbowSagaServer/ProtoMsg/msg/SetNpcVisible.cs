using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SetNpcVisible
	{

		[ProtoMember(1)]
		public int visible{ get; set; }


		internal SetNpcVisible()
		{
			this.visible = 0;
		}

	}

}
