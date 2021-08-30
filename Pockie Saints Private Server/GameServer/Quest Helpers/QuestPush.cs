using System;
using System.Collections.Generic;

namespace GameServer
{
	internal static class QuestPush
	{
		public static byte P100003(ConnectionInfo c)
		{

			if(!c.Player.bag.CanBagAdd(1)) return 3;

			switch(c.Player.role.career)
			{
				case 1:
					c.Player.bag.AddBagItem(1010001,1,2);
					break;
				case 2:
					c.Player.bag.AddBagItem(1010002,1,2);
					break;
				case 3:
					c.Player.bag.AddBagItem(1010003,1,2);
					break;
			}

			return 1;
		}

		public static byte P100005(ConnectionInfo c)
		{

			switch(c.Player.role.career)
			{
				case 1:
					 c.Player.skill.AddSkill(101101);
					break;
				case 2:
					 c.Player.skill.AddSkill(201101);
					break;
				case 3:
					 c.Player.skill.AddSkill(301101);
					break;
			}
			//c.Player.skill.Save(c);
			GameServer.Command.SkillController.SendSkillRefresh(c);

			return 1;
		}

	}
}
