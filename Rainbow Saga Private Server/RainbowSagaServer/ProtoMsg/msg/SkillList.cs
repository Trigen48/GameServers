using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SkillList
	{

		[ProtoMember(1)]
		public List<Skill> skills{ get; set; }


		internal SkillList()
		{
			this.skills = new List<Skill>();
		}

	}

}
