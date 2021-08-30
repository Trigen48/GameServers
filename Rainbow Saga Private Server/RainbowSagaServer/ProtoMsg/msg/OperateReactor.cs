using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OperateReactor
	{

		[ProtoMember(22)]
		public int seqno{ get; set; }

		[ProtoMember(23)]
		public string reactorName{ get; set; }


		internal OperateReactor()
		{
			this.seqno = 0;
			this.reactorName ="";
		}

	}

}
