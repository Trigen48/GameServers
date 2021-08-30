using System;
using System.Collections.Generic;
using System.Text;

namespace gateway
{
    static class Response
    {
        public struct state
        {
            public byte id;
            public String msg;
        }

        public static void GetError(byte state,int time,String message,ByteArray ar)
        {
            ar.WriteByte(state);
            ar.WriteInt(time);
            ar.WriteString(message);
            ar.PackArray(60002);

        }

        public static state GetState(string Account)
        {
            state s = new state();

            try
            {
                string acc="state/" + Account;
                if (System.IO.File.Exists(acc))
                {

                    ByteArray ar = new ByteArray(acc);

                    s.id = ar.ReadByte();
                    s.msg = ar.ReadString();
                    ar.Close();
                    ar = null;
                }

            }
            catch
            {
                s.id = 4;
               // return ;
            }

            return s;
        }

    }
}
