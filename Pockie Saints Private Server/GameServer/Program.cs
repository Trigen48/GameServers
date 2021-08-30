#define IsDebug1
#define Con1
#define Linux2

#define Socket12

using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace GameServer
{
    class Program
    {

        private static object serverLock = new object();
        internal static bool islog = false;
        internal static int port;
        private static Socket serverSocket;
        private static int MaxConnectionAccept = 10;
        internal static int SendRetry = 2;
        internal static int SendTimeout = 100;
        internal const int BufferSize = 8192;//*2;1024;//

#if Con1
        private static long NextConID = 1;
        internal static Dictionary<long, ConnectionInfo> conns = new Dictionary<long, ConnectionInfo>();
#else
        internal static List<ConnectionInfo> connections =
            new List<ConnectionInfo>();
#endif

        private static void SetupServerSocket()
        {
            IPEndPoint myEndpoint = new IPEndPoint(IPAddress.Any, port);


            // Create the socket, bind it, and start listening
            serverSocket = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Blocking = false;

            serverSocket.Bind(myEndpoint);
            serverSocket.Listen((int)SocketOptionName.MaxConnections);
        }

        public static void Start()
        {
            Console.Write("Starting TCP server... ");
            try
            {
                SetupServerSocket();
                for (int i = 0; i < MaxConnectionAccept; i++)
                    serverSocket.BeginAccept(
                        new AsyncCallback(AcceptCallback), serverSocket);
            }
            catch (Exception e)
            {
                Program.Write("Fail.");
                Program.Write(e);
            }
            Console.WriteLine("Done. Listening.");
        }

        private static void AcceptCallback(IAsyncResult result)
        {
            // Program.Write("Connection accepted!");
            ConnectionInfo connection = new ConnectionInfo();
            try
            {


                Socket s = (Socket)result.AsyncState;
                connection.Socket = s.EndAccept(result);
                connection.Socket.Blocking = false;


                connection.Buffer = new byte[BufferSize];
                connection.Socket.ReceiveBufferSize = BufferSize;
                connection.Socket.SendBufferSize = BufferSize;


#if Con1
                lock (conns)
                {
                    if (NextConID == long.MaxValue)
                        NextConID = 0;

                    while (conns.ContainsKey(NextConID))
                    {
                        Interlocked.Increment(ref NextConID);
                        //NextConID++;
                    }

                    connection.ConnID = NextConID;
                    conns.Add(NextConID, connection);
                    NextConID++;
                }
#else
                lock (connections)
                {
                    connections.Add(connection);
                }
#endif

                connection.Socket.BeginReceive(connection.Buffer, 0,
                    BufferSize, SocketFlags.None,
                    new AsyncCallback(ReceiveCallback), connection);



                serverSocket.BeginAccept(new AsyncCallback(AcceptCallback),
                    result.AsyncState);


            }
            catch (SocketException exc)
            {
                CloseConnection(connection);
                log.Save(exc);

            }
            catch (Exception exc)
            {
                CloseConnection(connection);
                log.Save(exc);
            }
        }
       
        private static void ReceiveCallback(IAsyncResult result)
        {
            ConnectionInfo connection = (ConnectionInfo)result.AsyncState;
#if IsDebug
           try
           {
#endif
            
            int bytesRead = 0;


            try
            {

                bytesRead = connection.Socket.EndReceive(result);
            }
            catch
            {
                // Disconnect
                CloseConnection(connection);
                return;
            }


            if (0 != bytesRead)
            {
                /*lock (serverLock)
                {*/
                //System.IO.File.WriteAllBytes("bin.bin", connection.Buffer);
#if Linux1
                if (bytesRead == 23 && connection.Buffer[0] == '<')
                {
                    connection.Socket.Send(FlashPolicy.FlashPolicyFile);
                    CloseConnection(connection);
                    return;
                }
                else
                {
#endif
                    connection.rot.Clear();
                    connection.cmds = ByteTool.GetCommands(connection.Buffer, bytesRead);
                    for (int x = 0; x < connection.cmds.Length; x++)
                    {

                        byte[] temp = Commands.Parse(connection.cmds[x], connection);

                        if (connection.CutConnection == true)
                        {
                            CloseConnection(connection);
                            temp = null;
                            return;
                        }

                        if (temp == null || temp.Length == 0) continue;

                        connection.rot.WriteBytes(temp);
                        connection.ot.Close();
                        temp = null;
                    }

                    connection.cmds = null;
                    connection.rot.Flush();


                    #region Send Data
                    int retry = 0;

                retrysend: ;
                    lock (connection.SendBlock)
                    {

                        try
                        {
                            if(connection.Socket!=null && connection.Socket.Connected)
                            connection.Socket.Send(connection.rot.GetByteArray(), SocketFlags.None);
                        }
                        catch (SocketException sockex)
                        {
                            //long ix = 0x80004005;
                            if (sockex.ToString().Contains("A non-blocking socket operation could not be completed immediately"))
                            {
                                if (retry < SendRetry)
                                {
                                    System.Threading.Thread.Sleep(SendTimeout);
                                    retry++;
                                    goto retrysend;

                                }
                            }

                            log.Save(sockex);
                            CloseConnection(connection);
                            return;
                        }


                    }

                    #endregion

                    connection.rot.Close();


                    /*}*/
                    if (connection.Socket != null && connection.Socket.Connected)
                    connection.Socket.BeginReceive(connection.Buffer, 0,
                        BufferSize, SocketFlags.None,
                        new AsyncCallback(ReceiveCallback), connection);
#if Linux1
                }
#endif
            }
            else
            {
                CloseConnection(connection);
                return;
            }



#if IsDebug
            }
            catch (SocketException eex)
            {
               log.Save(eex);
                CloseConnection(connection);
            }
            catch (Exception ex)
            {
                log.Save(ex);
                CloseConnection(connection);
            }
#endif

        }

        public static void CloseConnection(ConnectionInfo ci)
        {
#if IsDebug
            try
            {
#endif
            if (ci == null || ci.closing)
                return;

            ci.closing = true;

            if (ci.Socket != null && ci.Socket.Connected)
                ci.Socket.Close();

            if (ci.Player != null && ci.rlid != 0)
            {
               if(ci.currentScene!=null)
                    ci.currentScene.RemovePlayer(ci);

                ci.Player.SetOffline();


                ci.Player.role.Save();
                World.Banner.AnnounceLogin(ci, 0);

                //System.Threading.Thread.Sleep(00);
                Players.RemoveRole(ci.Player);


                ci.Player = null;
                ci.rlid = 0;
            }
#if IsDebug
            }
            catch (Exception ex)
            {
                log.Save(ex);
            }

#endif
#if IsDebug
            try
            {
#endif
#if Con1
            lock (conns)
            {
                conns.Remove(ci.ConnID);
            }

#else
                lock (connections)
                {
                    connections.Remove(ci);
                }
#endif
            ci = null;
            //Program.Write("Connection Closed..");
#if IsDebug
            }
            catch (Exception ex)
            {
                log.Save(ex);
            }
#endif
        }

        internal static void CloseAll()
        {
#if Con1
            lock (conns)
            {
                try
                {
                    ConnectionInfo[] vals = new ConnectionInfo[conns.Count];
                    conns.Values.CopyTo(vals, 0);

                    foreach (ConnectionInfo c in vals)
                    {
                        CloseConnection(c);
                    }

                    vals = null;
                    conns.Clear();
                }
                catch (Exception ex)
                {
                    log.Save(ex);
                }

            }
#else
            lock (connections)
            {
                for (int i = connections.Count - 1; i >= 0; i--)
                {
                    try
                    {
                        CloseConnection(connections[i]);
                    }
                    catch
                    {
                    }
                }
            }
#endif
        }

        static void Main()
        {

            SystemCulture.SetCulture();
            ConfigLoad.GetDatabase();
            ConfigLoad.GetConfig();

            Program.Write("===============Pockie Saints game server==============");
            Program.Write("====                                              ====");
            Program.Write("====      \" ext \" to exit.                        ====");
            Program.Write("====      \" del \" to drop all connections.        ====");
            Program.Write("====      \" clr \" to clear all text.              ====");
            Program.Write("====                                              ====");
            Program.Write("======================================================");
            Program.Write(); Program.Write();

            string line = "";
            bool portReady = false;
            if (port > short.MaxValue || port < 2)
            {
                Console.Write("Please enter port number: ");
                line = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Running from port: " + port.ToString());
                Loads.Load();
                Start();
                portReady = true;
            }



            while (line != "ext")
            {
                if (!portReady)
                {
                    try
                    {
                        port = int.Parse(line);
                        if (port > short.MaxValue || port < 2)
                        {
                            Program.Write("Invalid port number.");
                            Console.Write("Please enter port number: ");
                        }
                        else
                        {
                            Loads.Load();
                            Start();
                            portReady = true;

                        }
                    }
                    catch (Exception exx)
                    {
                        Program.Write(exx.Message);
                        log.Save(exx);
                        Console.Write("Please enter port number: ");
                    }
                }
                else
                {
                    try
                    {
                        ConsoleCode.PassCommand(line);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid command inputs");
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("Shutting down server... ");

            CloseAll();

            Console.WriteLine("Killing threads");
            proc.threads.StopAll();

            Program.Write("Server terminated..");
            Thread.Sleep(500);


        }

        internal static void Write(object v)
        {
#if IsDebug1
            Console.WriteLine(v);
#endif
        }

        internal static void Write()
        {
#if IsDebug1
            Console.WriteLine();
#endif
        }


    }
}
