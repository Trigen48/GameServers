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
	internal class Chat
	{

		[ProtoMember(1)]
		public int channel{ get; set; }

		[ProtoMember(2)]
		public string sender{ get; set; }

		[ProtoMember(3)]
		public string receiver{ get; set; }

		[ProtoMember(4)]
		public string content{ get; set; }

		[ProtoMember(5)]
		public int subtype{ get; set; }

		[ProtoMember(6)]
		public string Params{ get; set; }

		[ProtoMember(7)]
		public int time{ get; set; }

		[ProtoMember(8)]
		public int senderCharid{ get; set; }

		[ProtoMember(10)]
		public List<Item> items{ get; set; }

		[ProtoMember(11)]
		public List<Pet> pets{ get; set; }

		[ProtoMember(12)]
		public int vipLevel{ get; set; }

		[ProtoMember(13)]
		public int bubbleType{ get; set; }

		[ProtoMember(14)]
		public int tencentBlue{ get; set; }


		internal Chat()
		{
			this.channel = 0;
			this.sender ="";
			this.receiver ="";
			this.content ="";
			this.subtype = 0;
			this.Params ="";
			this.time = 0;
			this.senderCharid = 0;
			this.items = new List<Item>();
			this.pets = new List<Pet>();
			this.vipLevel = 0;
			this.bubbleType = 0;
			this.tencentBlue = 0;
		}

	}

}
