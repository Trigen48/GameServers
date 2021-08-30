using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C21
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 21001:
					Command.SkillController.c21001(c);
					break;

				case 21002:
					Command.SkillController.c21002(c);
					break;

				case 21003:
					Command.SkillController.c21003(c);
					break;

				case 21004:
					Command.SceneController.c21004(c);
					break;

			}
			
		}

	}
}
