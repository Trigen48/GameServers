using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace RainbowServer
{

    public class ConnectionInfo
    {
        public Socket Socket;
        public byte[] Buffer;
        public bool CutConnection;
        public ByteArray ot = new ByteArray();
        public ByteArray ar = new ByteArray();
        public ByteArray final = new ByteArray();
        public System.IO.MemoryStream m;
        public uint SessionID = 121;
        public string CharDir = "", AccName = "";
        public int charid = 0;

        public List<RequestItem> cmd = new List<RequestItem>();

    }
    class Program
    {
        private static object serverLock = new object();

        private static int port;
        private static Socket serverSocket;
        //private static int MaxConnectionAccept = 10;


        private static List<ConnectionInfo> connections =
            new List<ConnectionInfo>();



        private static void SetupServerSocket()
        {
            IPEndPoint myEndpoint = new IPEndPoint(IPAddress.Any, port);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Blocking = false;
            serverSocket.Bind(myEndpoint);
            serverSocket.Listen((int)SocketOptionName.MaxConnections);
        }

        public static void Start()
        {
            Console.Write("Starting login server... ");
            /*try
            {*/
            SetupServerSocket();
            for (int i = 0; i < 10; i++)
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), serverSocket);

            /* }
             catch (Exception e)
             {
                 Console.WriteLine("Fail.");
                 Console.WriteLine(e);
                 log.Save(e);
             }*/
            Console.WriteLine("Done...");
        }

        private static void AcceptCallback(IAsyncResult result)
        {
            // Console.WriteLine("Connection accepted!");
            ConnectionInfo connection = new ConnectionInfo();
            try
            {
                // Finish Accept
                Socket s = (Socket)result.AsyncState;
                // if (s == null) return;
                connection.Socket = s.EndAccept(result);
                connection.Socket.Blocking = false;
                connection.Buffer = new byte[4096];
                connection.Socket.ReceiveBufferSize = 4096;
                connection.Socket.SendBufferSize = 4096;
                lock (connections) connections.Add(connection);

                connection.Socket.BeginReceive(connection.Buffer, 0,
                    connection.Buffer.Length, SocketFlags.None,
                    new AsyncCallback(ReceiveCallback), connection);


            }
            catch (SocketException exc)
            {
                CloseConnection(connection);
                Console.WriteLine("Socket exception: " + exc.SocketErrorCode);
                log.Save(exc);
            }

            // Start new Accept
            try
            {
                serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), result.AsyncState);
            }
            catch (Exception exc)
            {
                CloseConnection(connection);
                Console.WriteLine("Exception Accept: " + exc);
                log.Save(exc);
            }



        }

        private static void ReceiveCallback(IAsyncResult result)
        {
            ConnectionInfo connection = (ConnectionInfo)result.AsyncState;
            /*  try
              {*/
            int bytesRead = 0;

            try
            {
               bytesRead= connection.Socket.EndReceive(result);
            }
            catch
            {
                CloseConnection(connection);
                return;
            }

            if (0 != bytesRead)
            {
                lock (serverLock)
                {
                    /*  try
                      {*/
                    if (bytesRead == 23 && connection.Buffer[0] == '<')
                    {
                        connection.Socket.Send(FlashPolicy.FlashPolicyFile);
                        CloseConnection(connection);
                        return;
                    }
                    else
                    {
                        byte[] temp;
                        //  connection.final.Clear();

                        connection.final = connection.Buffer;

                        System.IO.File.WriteAllBytes(@"c:\z\data.txt", connection.Buffer);
                        // System.IO.File.

                        #region Get Foward IP Address
                        string foward = "";
                        if (connection.final.ReadUInt() == 1601660788)
                        {
                            int x = 3;
                            connection.final.position = 0;
                            while (x != 0)
                            {
                                if (connection.final.ReadByte() == '\n')
                                    x--;
                            }

                            int len = connection.final.position;
                            connection.final.position = 0;

                            byte[] code = connection.final.ReadBytes(len);

                            foward = Encoding.UTF8.GetString(code);
                        }
                        else
                        {
                            connection.final.position = 0;
                        }
                        #endregion


                        temp = connection.final.ReadBytes(bytesRead - connection.final.position);
                        connection.final.Clear();

                        Stack<RequestItem> req = new Stack<RequestItem>();
                        req = ByteTool.GetCommands(temp);

                        /* if (req.Count > 1)
                         {
                             log.Save(req.Count.ToString() + " :Commands So far");
                         }*/
                        temp = null;
                        while (req.Count != 0)
                        {
                            // connection.ot.Clear();
                            temp = Commands.Parse(connection, req.Pop());

                            if (temp != null && temp.Length != 0)
                                connection.final.WriteBytes(temp);

                            if (connection.CutConnection == true)
                            {
                                break;
                                //goto exit;
                            }
                        }

                    //exit:
                        if (req.Count != 0)
                        {
                            req.Clear();
                        }

                        connection.ar = new ByteArray(connection.Buffer, 0, bytesRead);
                        temp = connection.final.GetArray();

                        connection.final.Clear();

                        if (temp != null && temp.Length != 0)
                            connection.Socket.Send(temp);

                        if (connection.CutConnection == true)
                        {
                            CloseConnection(connection);
                            return;
                        }

                    }
                    /* }
                     catch (Exception ex)
                     {
                         Console.WriteLine(ex.Message);
                         log.Save(ex);
                         CloseConnection(connection);
                         return;
                     }*/


                }


                connection.Socket.BeginReceive(connection.Buffer, 0,
                    connection.Buffer.Length, SocketFlags.None,
                    new AsyncCallback(ReceiveCallback), connection);
            }
            else CloseConnection(connection);
            /* }
             catch (SocketException ex)
             {
                 CloseConnection(connection);
                 log.Save(ex);
             }
             catch (Exception ex)
             {
                 CloseConnection(connection);
                 log.Save(ex);
             }*/
        }

        private static void CloseConnection(ConnectionInfo ci)
        {
            try
            {

                if (ci.charid != 0 && Players.players[ci.charid] != null)
                {
                    Players.Get(ci).SaveMain();
                    Players.players[ci.charid] = null;

                }
                ci.AccName = "";
                ci.ar = null;
                ci.Buffer = null;
                ci.CharDir = "";
                ci.cmd = null;
                ci.final = null;
                ci.m = null;
                ci.ot = null;

                ci.Socket.Close();
                ci.Socket = null;


            }
            catch (Exception ex)
            {
                log.Save(ex);
            }

            try
            {
                lock (connections) connections.Remove(ci);
            }
            catch (Exception ex)
            {
                log.Save(ex);
            }
            //   Console.WriteLine("Connection Closed..");
        }

        static void Main(string[] arg)
        {
            /* Console.WriteLine("==============Pockie Saints loader server=============");
             Console.WriteLine("====                                              ====");
             Console.WriteLine("====      \" >e \" to exit.                         ====");
             Console.WriteLine("====      \" >d \" to drop all connections.         ====");
             Console.WriteLine("====      \" >c \" to clear all text.               ====");
             Console.WriteLine("====                                              ====");
             Console.WriteLine("======================================================");*/


            // Hack.Hacks();


            string line;


            if (arg.Length == 1)
            {
                line = arg[0];
                Console.WriteLine("Rainbow server");
                Console.WriteLine("Please enter port number: " + line);
            }
            else
            {
                Console.WriteLine("Rainbow server");
                Console.Write("Please enter port number: ");
                line = Console.ReadLine();
            }

            bool portReady = false;

            while (line != "exit")
            {
                if (!portReady)
                {
                    /*try
                    {*/
                    port = int.Parse(line);
                    if (port > short.MaxValue || port < 2)
                    {
                        Console.WriteLine("Invalid port number.");
                        Console.Write("Please enter port number: ");
                    }
                    else
                    {
                        FlashPolicy.InitFlashData();

                        Loads.Load();
                        Start();
                        portReady = true;
                        Console.WriteLine();
                    }
                    /*  }
                      catch
                      {
                          Console.WriteLine("Invalid port number.");
                          Console.Write("Please enter port number: ");
                      }*/
                }
                else
                {
                    if (line == "del")
                    {
                        CloseAll();
                    }
                    else if (line == "clr")
                    {
                        Console.Clear();
                    }
                }

                line = Console.ReadLine();
            }

            Console.Write("Closing server.....");

            CloseAll();

            Thread.Sleep(100);
        }

        private static void CloseAll()
        {
            lock (connections)
            {
                while (connections.Count != 0 && connections != null)
                {
                    try
                    {
                        connections[0].Socket.Close();
                    }
                    catch (Exception ex)
                    {
                        log.Save(ex);
                    }
                    connections.RemoveAt(0);
                }
            }
            Console.WriteLine("Closed All connections!");
        }

    }
}
