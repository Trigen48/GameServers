using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainbowServer.proto.msg;
namespace RainbowServer
{
    internal static class Accounts
    {
        internal static LoginResponse GetLogin(ref LoginRequest req)
        {

            LoginResponse res = new LoginResponse();

            string[] param = req.username.Split(new char[] { '|' });

            
            string user=Folders.UserDir + param[0]+".acc";
            if (System.IO.File.Exists(user) && param.Length>1)
            {
                req.password = param[1];
                //CProto.Account ac = new CProto.Account();
                //ByteTool.LoadProto(user, ref ac);

                ByteArray ar = new ByteArray(user);
                string pass = ar;
                res.banAccount= ar;

                if (req.password == pass && res.banAccount == 0)
                {
                    res.result = 0;
                    res.username = ar;
                }
                else
                {
                    if (res.banAccount != 0)
                    {
                        res.result = 104;
                    }
                    else
                    {
                        res.result = 101;
                    }
                }
                ar.Close();
            }
            else
            {
                res.result = 902;
            }

            return res;
        }
    }
}
