using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class Demander
	{

		[ProtoMember(1)]
		public string name{ get; set; }

		[ProtoMember(3)]
		public int amount{ get; set; }

		[ProtoMember(4)]
		public int senderlevel{ get; set; }


		internal Demander()
		{
			this.name ="";
			this.amount = 0;
			this.senderlevel = 0;
		}

	}

}
