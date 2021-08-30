using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class Run
	{

		[ProtoMember(1)]
		public string cmd{ get; set; }


		internal Run()
		{
			this.cmd ="";
		}

	}

}
