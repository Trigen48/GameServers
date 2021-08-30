using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ClientErrorMsgInfo
	{

		[ProtoMember(1)]
		public int charId{ get; set; }

		[ProtoMember(2)]
		public string errorInfo{ get; set; }


		internal ClientErrorMsgInfo()
		{
			this.charId = 0;
			this.errorInfo ="";
		}

	}

}
