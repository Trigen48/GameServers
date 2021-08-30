#define IsDebug1

using System;
using System.Collections.Generic;
using System.Text;
using GameServer.Command;

namespace GameServer
{
    internal static class Commands
    {
        const int Header=2;
        public static byte[] Parse(byte[] data, ConnectionInfo c)
        {

            byte[] outdata = null;
#if IsDebug
            try
            {
#endif
            int cmd;
            c.ar = new ByteArray(data); // Read Command
            c.ot.Clear();// Out Command

            cmd = c.ar.ReadShort();


#if IsDebug1
            if (Program.islog)
            {
                Program.Write(""); Program.Write("*****In Command " + cmd.ToString()); Program.Write("");
            }

#endif
                     //13026
            int Cv = cmd / 1000;

            switch (Cv)
            {
                case 10:
                    C10.CommandParse(c, cmd);
                    break;

                case 11:
                    C11.CommandParse(c, cmd);
                    break;

                case 12:
                    C12.CommandParse(c, cmd);
                    break;

                case 13:
                    C13.CommandParse(c, cmd);
                    break;

                case 14:
                    C14.CommandParse(c, cmd);
                    break;

                case 15:
                    C15.CommandParse(c, cmd);
                    break;

                case 16:
                    C16.CommandParse(c, cmd);
                    break;

                case 17:
                    C17.CommandParse(c, cmd);
                    break;

                case 18:
                    C18.CommandParse(c, cmd);
                    break;

                case 19:
                    C19.CommandParse(c, cmd);
                    break;

                case 20:
                    C20.CommandParse(c, cmd);
                    break;

                case 21:
                    C21.CommandParse(c, cmd);
                    break;

                case 22:
                    C22.CommandParse(c, cmd);
                    break;

                case 23:
                    C23.CommandParse(c, cmd);
                    break;

                case 24:
                    C24.CommandParse(c, cmd);
                    break;

                case 25:
                    C25.CommandParse(c, cmd);
                    break;

                case 26:
                    C26.CommandParse(c, cmd);
                    break;

                case 27:
                    C27.CommandParse(c, cmd);
                    break;

                case 28:
                    C28.CommandParse(c, cmd);
                    break;

                case 29:
                    C29.CommandParse(c, cmd);
                    break;

                case 30:
                    C30.CommandParse(c, cmd);
                    break;

                case 31:
                    C31.CommandParse(c, cmd);
                    break;

                case 32:
                    C32.CommandParse(c, cmd);
                    break;

                case 33:
                    C33.CommandParse(c, cmd);
                    break;

                case 34:
                    C34.CommandParse(c, cmd);
                    break;

                case 35:
                    C35.CommandParse(c, cmd);
                    break;

                case 36:
                    C36.CommandParse(c, cmd);
                    break;

                case 37:
                    C37.CommandParse(c, cmd);
                    break;

                case 38:
                    C38.CommandParse(c, cmd);
                    break;

                case 39:
                    C39.CommandParse(c, cmd);
                    break;

                case 40:
                    C40.CommandParse(c, cmd);
                    break;

                case 41:
                    C41.CommandParse(c, cmd);
                    break;

                case 42:
                    C42.CommandParse(c, cmd);
                    break;

                case 43:
                    C43.CommandParse(c, cmd);
                    break;

                case 44:
                    C44.CommandParse(c, cmd);
                    break;

                case 45:
                    C45.CommandParse(c, cmd);
                    break;

                case 47:
                    C47.CommandParse(c, cmd);
                    break;

                case 48:
                    C48.CommandParse(c, cmd);
                    break;

                case 49:
                    C49.CommandParse(c, cmd);
                    break;

                case 50:
                    C50.CommandParse(c, cmd);
                    break;

                case 60:
                    C60.CommandParse(c, cmd);
                    break;

                default:
                    Program.Write("-> Rouge Command Invoked : " + cmd.ToString());
                    break;

            }
            

            try
            {

                /*if (c.Player != null && c.Player.buff.IsActive)
                {
                    if (c.Player.buff.MustUpdate(c,c.ot))
                    {
                        c.ot.WriteBytes(Command.RoleController.GetCombat(c));
                        c.currentScene.UpdatePlayerHp(c);
                    }
                }*/


                outdata = c.ot.GetByteArray();
                c.ot.Clear();
            }
            catch(Exception ex)
            {
                log.Save(ex);
            }

#if IsDebug
            
            }
            catch(Exception ex)
            {
                log.Save(ex,c);
                //Program.Write(ex.Message);
                
                c.CutConnection = true;
            }
#endif



            data = null;
            return outdata;
        }


    }
}
