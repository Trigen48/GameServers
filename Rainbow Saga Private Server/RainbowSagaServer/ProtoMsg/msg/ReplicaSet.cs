using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ReplicaSet
	{

		[ProtoMember(1)]
		public List<PlayerReplicaInfo> players{ get; set; }

		[ProtoMember(2)]
		public List<MobReplicaInfo> mobs{ get; set; }

		[ProtoMember(3)]
		public List<ItemReplicaInfo> items{ get; set; }

		[ProtoMember(4)]
		public List<PetReplicaInfo> pets{ get; set; }


		internal ReplicaSet()
		{
			this.players = new List<PlayerReplicaInfo>();
			this.mobs = new List<MobReplicaInfo>();
			this.items = new List<ItemReplicaInfo>();
			this.pets = new List<PetReplicaInfo>();
		}

	}

}
