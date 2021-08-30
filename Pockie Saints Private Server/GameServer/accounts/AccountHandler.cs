using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer.accounts
{
    internal static class AccountHandler
    {
        public static int Items=1;
        public static int roles=1;
        public static int mails=1;
        public static object locks = new object();

        public static void Reset()
        {
            lock (locks)
            {
                roles = 1;
                Items = 1;
                mails = 1;
            }
            Save();
        }

        public static void Load()
        {

            if (System.IO.File.Exists(Game.AccountFile))
            {
                try
                {
                    ByteArray ar = new ByteArray(System.IO.File.ReadAllBytes(Game.AccountFile));
                    roles = ar.ReadInt();
                    Items = ar.ReadInt();
                    mails = ar.ReadInt();
                    ar.Close();

                }
                catch(Exception ex)
                {
                    log.Save(ex);
                    throw new Exception();
                }
            }
            else
            {

                Save();
            }
        }

        public static void Save()
        {
            try
            {
                ByteArray ar = new ByteArray();
                ar.WriteInt(roles);
                ar.WriteInt(Items);
                ar.WriteInt(mails);
                ar.SaveFile(Game.AccountFile);
                ar.Close();
            }
            catch (Exception ex)
            {
                log.Save(ex);
                throw new Exception();
            }
        }

       /* public static int NextItem()
        {
            lock (locks)
            {
                Items++;
                Save();
            }
            return Items-1;
        }

        public static int NextRole()
        {
            lock (locks)
            {
                roles++;
                Save();
            }
            return roles - 1;
        }*/

        public static int NextMail()
        {
            lock (locks)
            {
                mails++;
                Save();
            }
            return mails - 1;
        }


    }
}
