using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class VolumeSet
	{

		[ProtoMember(1)]
		public int onOff{ get; set; }

		[ProtoMember(2)]
		public int musicVolume{ get; set; }

		[ProtoMember(3)]
		public int effectVolume{ get; set; }


		internal VolumeSet()
		{
			this.onOff = 0;
			this.musicVolume = 0;
			this.effectVolume = 0;
		}

	}

}
