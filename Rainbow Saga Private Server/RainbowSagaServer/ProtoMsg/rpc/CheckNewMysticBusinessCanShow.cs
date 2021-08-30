using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class CheckNewMysticBusinessCanShow
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public int iscream{ get; set; }


		internal CheckNewMysticBusinessCanShow()
		{
			this.unused = 0;
			this.iscream = 0;
		}

	}

}
