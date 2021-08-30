using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class QueryRealNameAuth
	{

		[ProtoMember(1)]
		public uint uin{ get; set; }


		internal QueryRealNameAuth()
		{
			this.uin = 0;
		}

	}

}
