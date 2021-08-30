using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class PreferenceGroup
	{

		[ProtoMember(1)]
		public string name{ get; set; }

		[ProtoMember(2)]
		public List<Preference> preferences{ get; set; }


		internal PreferenceGroup()
		{
			this.name ="";
			this.preferences = new List<Preference>();
		}

	}

}
