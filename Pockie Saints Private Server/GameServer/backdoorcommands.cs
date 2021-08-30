using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace GameServer
{
    static class backdoorcommands
    {

        static UdpClient t;


        internal static void Setup()
        {
            t = new UdpClient(3425);
           //t.Client.Listen(
            t.BeginReceive(new AsyncCallback(Recieve),t);
        }

        internal static void Recieve(IAsyncResult result)
        {

            t.Send(new byte[] { 1, 0 }, 2);
        }

        internal static void CreateAccount(ByteArray ot,ByteArray ar)
        {

            string s1, s2;

            s1 = ot.ReadString();
            s2 = ot.ReadString();
            ot.Close();
           // ot = new ByteArray();

            ar.WriteByte(UserWork.CreateUser(s1, s2) == true ? 1 : 0);

        }
    }
}
