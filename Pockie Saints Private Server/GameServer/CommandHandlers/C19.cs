using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class C19
	{

		internal static void CommandParse(ConnectionInfo c, int cmd)
		{
			
			switch(cmd)
			{
				case 19001:
					Command.MailController.c19001(c);
					break;

				case 19002:
					Command.MailController.c19002(c);
					break;

				case 19003:
					Command.MailController.c19003(c);
					break;

				case 19004:
					Command.MailController.c19004(c);
					break;

				case 19005:
					Command.MailController.c19005(c);
					break;

				case 19006:
					Command.MailController.c19006(c);
					break;

				case 19010:
					Command.MailController.c19010(c);
					break;

			}
			
		}

	}
}
