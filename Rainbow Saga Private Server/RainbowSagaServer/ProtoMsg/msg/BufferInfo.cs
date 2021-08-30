using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BufferInfo
	{

		[ProtoMember(1)]
		public string code{ get; set; }

		[ProtoMember(2)]
		public string alias{ get; set; }

		[ProtoMember(3)]
		public int duration{ get; set; }

		[ProtoMember(4)]
		public int skillId{ get; set; }

		[ProtoMember(5)]
		public int skillLv{ get; set; }

		[ProtoMember(6)]
		public int positive{ get; set; }

		[ProtoMember(7)]
		public List<BuffModifier> mods{ get; set; }

		[ProtoMember(8)]
		public uint flags{ get; set; }

		[ProtoMember(9)]
		public uint expireTime{ get; set; }


		internal BufferInfo()
		{
			this.code ="";
			this.alias ="";
			this.duration = 0;
			this.skillId = 0;
			this.skillLv = 0;
			this.positive = 0;
			this.mods = new List<BuffModifier>();
			this.flags = 0;
			this.expireTime = 0;
		}

	}

}
