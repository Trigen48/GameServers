using System;
using System.Collections.Generic;

namespace GameServer
{
	internal static class QuestReward
	{
		public static byte R100002(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(2)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(9010006,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(9010006,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(9010006,1,2);
					break;
			}

			c.Player.bag.AddBagItem(5010063,1,2);

			return 1;
		}

		public static byte R100007(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1021001,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1021002,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1021003,1,2);
					break;
			}


			return 1;
		}

		public static byte R100009(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(2020001,5,2);

			return 1;
		}

		public static byte R100010(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(2)) return 3;


			c.Player.bag.AddBagItem(5010064,1,2);
			c.Player.bag.AddBagItem(9020005,1,2);

			return 1;
		}

		public static byte R100012(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R100013(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(2010001,5,2);

			return 1;
		}

		public static byte R100014(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(5010065,1,2);

			return 1;
		}

		public static byte R100016(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(2)) return 3;


			c.Player.bag.AddBagItem(5010066,1,2);
			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R100017(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(7010002,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(7010018,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(7010034,1,2);
					break;
			}


			return 1;
		}

		public static byte R100020(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(3330001,1,2);

			return 1;
		}

		public static byte R100026(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R110017(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(2)) return 3;


			c.Player.bag.AddBagItem(2010002,50,2);
			c.Player.bag.AddBagItem(2020002,50,2);

			return 1;
		}

		public static byte R110021(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(7010004,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(7010020,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(7010036,1,2);
					break;
			}


			return 1;
		}

		public static byte R110024(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1020007,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1020008,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1020009,1,2);
					break;
			}


			return 1;
		}

		public static byte R110025(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1023007,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1023008,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1023009,1,2);
					break;
			}


			return 1;
		}

		public static byte R110027(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1022007,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1022008,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1022009,1,2);
					break;
			}


			return 1;
		}

		public static byte R110028(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1024007,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1024008,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1024009,1,2);
					break;
			}


			return 1;
		}

		public static byte R110029(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1025007,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1025008,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1025009,1,2);
					break;
			}


			return 1;
		}

		public static byte R110032(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(8030001,1,2);

			return 1;
		}

		public static byte R110035(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(7010005,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(7010021,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(7010037,1,2);
					break;
			}


			return 1;
		}

		public static byte R110039(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(8040001,1,2);

			return 1;
		}

		public static byte R110040(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(8020001,1,2);

			return 1;
		}

		public static byte R110041(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(2)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(7010006,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(7010022,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(7010038,1,2);
					break;
			}

			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R110048(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6030001,3,2);

			return 1;
		}

		public static byte R110058(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R110059(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(1110001,3,2);

			return 1;
		}

		public static byte R110062(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(2)) return 3;


			c.Player.bag.AddBagItem(8010002,1,2);
			c.Player.bag.AddBagItem(8020002,1,2);

			return 1;
		}

		public static byte R110063(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R111001(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(2231001,1,2);

			return 1;
		}

		public static byte R111004(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(7010003,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(7010019,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(7010035,1,2);
					break;
			}


			return 1;
		}

		public static byte R111006(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1010010,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1010011,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1010012,1,2);
					break;
			}


			return 1;
		}

		public static byte R111008(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R111010(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1021007,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1021008,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1021009,1,2);
					break;
			}


			return 1;
		}

		public static byte R111012(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R111015(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(3110001,1,2);

			return 1;
		}

		public static byte R112001(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(2231001,1,2);

			return 1;
		}

		public static byte R112004(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(7010003,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(7010019,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(7010035,1,2);
					break;
			}


			return 1;
		}

		public static byte R112006(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1010010,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1010011,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1010012,1,2);
					break;
			}


			return 1;
		}

		public static byte R112008(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R112010(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1021007,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1021008,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1021009,1,2);
					break;
			}


			return 1;
		}

		public static byte R112012(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R112015(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(3110001,1,2);

			return 1;
		}

		public static byte R113001(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(2231001,1,2);

			return 1;
		}

		public static byte R113004(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(7010003,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(7010019,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(7010035,1,2);
					break;
			}


			return 1;
		}

		public static byte R113006(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1010010,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1010011,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1010012,1,2);
					break;
			}


			return 1;
		}

		public static byte R113008(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R113010(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1021007,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1021008,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1021009,1,2);
					break;
			}


			return 1;
		}

		public static byte R113012(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R113015(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(3110001,1,2);

			return 1;
		}

		public static byte R119001(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(1110001,6,2);

			return 1;
		}

		public static byte R119002(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(8010001,1,2);

			return 1;
		}

		public static byte R119004(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(2250005,1,2);

			return 1;
		}

		public static byte R119007(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1010022,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1010023,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1010024,1,2);
					break;
			}


			return 1;
		}

		public static byte R119009(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6040080,1,2);

			return 1;
		}

		public static byte R119010(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6040080,1,2);

			return 1;
		}

		public static byte R119011(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6040080,1,2);

			return 1;
		}

		public static byte R119014(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(2)) return 3;


			c.Player.bag.AddBagItem(2010003,60,2);
			c.Player.bag.AddBagItem(2020003,60,2);

			return 1;
		}

		public static byte R120027(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R120029(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(7010016,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(7010032,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(7010048,1,2);
					break;
			}


			return 1;
		}

		public static byte R120040(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(6010001,2,2);

			return 1;
		}

		public static byte R129002(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(3310003,4,2);

			return 1;
		}

		public static byte R129004(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1010073,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1010074,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1010075,1,2);
					break;
			}


			return 1;
		}

		public static byte R129016(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(8030001,2,2);

			return 1;
		}

		public static byte R130110(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(4111001,1,2);

			return 1;
		}

		public static byte R130111(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(4111001,1,2);

			return 1;
		}

		public static byte R130112(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(4111001,2,2);

			return 1;
		}

		public static byte R130114(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(4111001,2,2);

			return 1;
		}

		public static byte R130115(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(4111001,3,2);

			return 1;
		}

		public static byte R130116(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(4111001,3,2);

			return 1;
		}

		public static byte R130167(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(4111001,4,2);

			return 1;
		}

		public static byte R130189(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(4111001,4,2);

			return 1;
		}

		public static byte R130210(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;


			c.Player.bag.AddBagItem(4111001,5,2);

			return 1;
		}

	}
}
