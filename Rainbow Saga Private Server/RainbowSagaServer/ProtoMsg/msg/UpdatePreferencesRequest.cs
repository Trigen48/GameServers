using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdatePreferencesRequest
	{

		[ProtoMember(1)]
		public string group{ get; set; }

		[ProtoMember(2)]
		public List<Preference> preferences{ get; set; }


		internal UpdatePreferencesRequest()
		{
			this.group ="";
			this.preferences = new List<Preference>();
		}

	}

}
