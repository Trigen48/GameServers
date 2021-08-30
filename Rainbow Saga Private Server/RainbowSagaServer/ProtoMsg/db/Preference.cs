using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class Preference
	{

		[ProtoMember(1)]
		public string key{ get; set; }

		[ProtoMember(2)]
		public string value{ get; set; }


		internal Preference()
		{
			this.key ="";
			this.value ="";
		}

	}

}
