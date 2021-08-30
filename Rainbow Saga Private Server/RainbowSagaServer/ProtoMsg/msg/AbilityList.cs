using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AbilityList
	{

		[ProtoMember(1)]
		public List<Ability> abilities{ get; set; }


		internal AbilityList()
		{
			this.abilities = new List<Ability>();
		}

	}

}
