using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class RegainChange
	{

		[ProtoMember(1)]
		public RegainNum regainNum{ get; set; }


		internal RegainChange()
		{
			this.regainNum = new RegainNum();
		}

	}

}
