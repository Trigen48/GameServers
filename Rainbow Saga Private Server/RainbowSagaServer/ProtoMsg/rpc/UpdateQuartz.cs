using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateQuartz
	{

		[ProtoMember(1)]
		public int quartz{ get; set; }


		internal UpdateQuartz()
		{
			this.quartz = 0;
		}

	}

}
