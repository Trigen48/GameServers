using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace gateway
{
    class Program
    {
        private static object serverLock = new object();

        private static int port;
        private static Socket serverSocket;
        private static int MaxConnectionAccept = 20;
        private static int BuffSize = 8192;//1024;///3;
        internal static bool islog = false;

        private class ConnectionInfo
        {
            public Socket Socket;
            public byte[] Buffer;
            //public bool flash;
            public bool CutConnection;

        }

        private static List<ConnectionInfo> connections = new List<ConnectionInfo>();

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
            WriteLine("Starting gateway ... ");
            try
            {
                SetupServerSocket();
                for (int i = 0; i < MaxConnectionAccept; i++)
                    serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), serverSocket);
                WriteLine("Gateway started...");
            }
            catch (Exception e)
            {
                WriteLine("Fail.");
                WriteLine(e);
                log.Save(e);
            }

        }

        private static void AcceptCallback(IAsyncResult result)
        {
            // WriteLine("Connection accepted!");
            ConnectionInfo connection = new ConnectionInfo();
            try
            {
                // Finish Accept
                Socket s = (Socket)result.AsyncState;
                // if (s == null) return;
                connection.Socket = s.EndAccept(result);
                connection.Socket.Blocking = false;
                connection.Buffer = new byte[BuffSize];
                lock (connections) connections.Add(connection);



                connection.Socket.BeginReceive(connection.Buffer, 0,
                    connection.Buffer.Length, SocketFlags.None,
                    new AsyncCallback(ReceiveCallback), connection);


            }
            catch (SocketException exc)
            {
                CloseConnection(connection);
                WriteLine("Socket exception: " + exc.SocketErrorCode);
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
                WriteLine("Exception Accept: " + exc);
                log.Save(exc);
            }



        }

        private static void ReceiveCallback(IAsyncResult result)
        {
            ConnectionInfo connection = (ConnectionInfo)result.AsyncState;
            try
            {
                int bytesRead = connection.Socket.EndReceive(result);

                if (0 != bytesRead)
                {
                    lock (serverLock)
                    {
                        try
                        {
                            if (bytesRead == 23 && connection.Buffer[0] == '<')
                            {
                                WriteLineLog("Received flash policy request");
                                WriteLineLog("Sending Flash Security Policy File");
                                connection.Socket.Send(FlashPolicy.FlashPolicyFile);
                                CloseConnection(connection);
                                return;
                            }
                            else
                            {
                                byte[] temp = Commands.Parse(connection.Buffer, out connection.CutConnection);

                                if (temp != null)
                                {
                                    connection.Socket.Send(temp);
                                }
                                else
                                {
                                    throw new Exception();
                                }

                                if (connection.CutConnection == true)
                                {
                                    CloseConnection(connection);
                                    return;
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            WriteLine(ex.Message);
                            log.Save(ex);
                            CloseConnection(connection);
                            return;
                        }


                    }


                    connection.Socket.BeginReceive(connection.Buffer, 0,
                        connection.Buffer.Length, SocketFlags.None,
                        new AsyncCallback(ReceiveCallback), connection);
                }
                else CloseConnection(connection);
            }
            catch (SocketException ex)
            {
                CloseConnection(connection);
                log.Save(ex);
            }
            catch (Exception ex)
            {
                CloseConnection(connection);
                log.Save(ex);
            }
        }

        private static void CloseConnection(ConnectionInfo ci)
        {
            try
            {
                ci.Socket.Close();
                //ci.con.Close();
                WriteLineLog("Connection Closed");
            }
            catch (Exception ex)
            {
                WriteLine(ex);

            }

            try
            {
                lock (connections) connections.Remove(ci);
            }
            catch
            {
            }
            //   WriteLine("Connection Closed..");
        }

        static void Main(string[] arg)
        {
            SystemCulture.SetCulture();
            WriteLine("==============Pockie Saints loader server=============");
            WriteLine("====                                              ====");
            WriteLine("====      \" exit \" to exit.                         ====");
            WriteLine("====      \" del \" to drop all connections.         ====");
            WriteLine("====      \" clr \" to clear all text.               ====");
            WriteLine("====                                              ====");
            WriteLine("======================================================");
            WriteLine("");
            string line = "";

            if (System.IO.File.Exists("config/loader.cfg"))
            {
                config.ConfigLoader cf = new config.ConfigLoader();

                cf.Load("config/loader.cfg");

                cf.GetString(ref line, "gatewayport");

                ServerLists.InitConfig(cf);

                cf.Clear();
                cf.Close();
                cf = null;
            }

            if (line == "")
            {
                if (arg.Length == 1)
                {
                    line = arg[0];
                }
                else
                {
                    WriteLine("Login server");
                    Write("Please enter port number: ");
                    line = Console.ReadLine();
                }
            }
            //WriteLine();
            WriteLine("");
            bool portReady = false;

            while (line != "exit")
            {
                if (!portReady)
                {
                    try
                    {
                        port = int.Parse(line);
                        if (port > short.MaxValue || port < 2)
                        {
                            WriteLine("Invalid port number.");
                            Write("Please enter port number: ");
                        }
                        else
                        {
                            FlashPolicy.InitFlashData();
                            ServerLists.InitServerList();
                            Start();
                            portReady = true;

                        }
                    }
                    catch
                    {
                        WriteLine("Invalid port number.");
                        Write("Please enter port number: ");
                    }
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

            Write("Closing gateway.....");

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
            WriteLine("Closed All connections!");
        }

        internal static void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

        internal static void Write(object o)
        {
            Console.Write(o);
        }


        internal static void WriteLineLog(object o)
        {
            if (islog) { Write("Log: "); WriteLine(o); }
        }

        internal static void WriteLog(object o)
        {
            if (islog) { Write("Log: "); Write(o); }
        }

    }
}
