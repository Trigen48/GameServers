using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class AutoVechile
	{

		[ProtoMember(1)]
		public int auto{ get; set; }


		internal AutoVechile()
		{
			this.auto = 0;
		}

	}

}
