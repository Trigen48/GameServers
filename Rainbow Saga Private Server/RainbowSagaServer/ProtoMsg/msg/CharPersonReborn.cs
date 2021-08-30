using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CharPersonReborn
	{

		[ProtoMember(1)]
		public int rebornNum{ get; set; }

		[ProtoMember(2)]
		public string str{ get; set; }


		internal CharPersonReborn()
		{
			this.rebornNum = 0;
			this.str ="";
		}

	}

}
