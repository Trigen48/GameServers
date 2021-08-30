#define Con1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    static class ConsoleCode
    {

        public static void PassCommand(string line)
        {
           /* if (line.StartsWith("create role"))
            {
                string[] c = line.Split(new char[] { ',' });

                if (c == 5)
                {
                    try
                    {
                    }
                    catch
                    {
                    }

                }
            }*/
            if (line == "del")
            {
                Program.CloseAll();
            }
            else if (line.Replace(" ", "").StartsWith("del,"))
            {
                string[] sp = line.Replace(" ", "").Split(",".ToCharArray());
                int ii = int.Parse(sp[1]);

                RoleControl rl=Players.GetPlayer(ii);
                if (rl != null)
                    Program.CloseConnection(rl.cc);
            }
            else if (line.Replace(" ", "").StartsWith("backup,"))
            {
                string[] sp = line.Replace(" ", "").Split(",".ToCharArray());
                int ii = int.Parse(sp[1]);
                RoleControl.Backup(ii);
            }
            else if (line.Replace(" ", "").StartsWith("restore,"))
            {
                string[] sp = line.Replace(" ", "").Split(",".ToCharArray());
                int ii = int.Parse(sp[1]);
                RoleControl.Restore(ii);
            }
            else if (line.Replace(" ", "").StartsWith("reset,"))
            {
                string[] sp = line.Replace(" ", "").Split(",".ToCharArray());
                int ii = int.Parse(sp[1]);
                RoleControl.Reset(ii);
            }
            else if (line=="backup-all")
            {
                string[] sp = line.Replace(" ", "").Split(",".ToCharArray());

                lock (accounts.AccountHandler.locks)
                {
                    for (int ii = 1; ii < accounts.AccountHandler.roles; ii++)
                    {
                        RoleControl.Backup(ii);
                    }
                }
            }
            else if (line == "reset-all")
            {
                string[] sp = line.Replace(" ", "").Split(",".ToCharArray());

                lock (accounts.AccountHandler.locks)
                {
                    for (int ii = 1; ii < accounts.AccountHandler.roles; ii++)
                    {
                        RoleControl.Reset(ii);
                    }
                }
            }
            else if (line == "restore-all")
            {
                string[] sp = line.Replace(" ", "").Split(",".ToCharArray());

                lock (accounts.AccountHandler.locks)
                {
                    for (int ii = 1; ii < accounts.AccountHandler.roles; ii++)
                    {
                        RoleControl.Restore(ii);
                    }
                }
            }
            else if (line == "clr")
            {
                Console.Clear();
            }
            else if (line == "reloadshop")
            {
                ShopHelper.ReloadShop();
            }
            else if (line == "updaterank")
            {
                if (proc.threads.tRanks.IsAlive && proc.threads.tRanks.ThreadState == System.Threading.ThreadState.WaitSleepJoin)
                {
                    proc.threads.tRanks.Interrupt();
                  //  proc.threads.tRanks.Resume();
                }
            }
            else if (line == "players")
            {

#if Con1
                lock (Program.conns)
                {
                    Console.WriteLine(); Console.WriteLine();
                    Console.WriteLine("             Online Players                   ");
                    Console.WriteLine("----------------------------------------------");

                    ConnectionInfo[] vals = null;

                    lock (Program.conns)
                    {
                        vals = new ConnectionInfo[Program.conns.Count];
                        Program.conns.Values.CopyTo(vals, 0);
                    }


                    try
                    {
                        for (int x = 0; x < vals.Length; x++)
                        {
                            Console.WriteLine("++\t" + vals[x].rlid.ToString() + "\t:\t" + vals[x].Player.role.name);
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Save(ex);
                    }
                }
#else
                        lock (connections)
                        {
                            Console.WriteLine(); Console.WriteLine();
                            Console.WriteLine("             Online Players                   ");
                            Console.WriteLine("----------------------------------------------");

                            try
                            {
                                for (int x = 0; x < connections.Count; x++)
                                {
                                    Console.WriteLine("++\t" + connections[x].rlid.ToString() + "\t:\t" + Players.GetPlayer(connections[x]).charz.name);
                                }
                            }
                            catch
                            {
                            }
                        }
#endif

            }
            else if (line == "?")
            {
                Program.Write();
                Program.Write("Command Help");
                Program.Write();
                Program.Write("clr                  -   Clear Sreen");
                Program.Write("del                  -   Remove active connections");
                Program.Write("en [true / false]   -   Enable command logs");
                Program.Write("delp                 -   Delete all player folders and factions");
                Program.Write("ext                  -   Close game server.");
            }
            else if (line.StartsWith("en "))
            {
                try
                {
                    Program.islog = bool.Parse(line.Replace("en", " ").Replace(" ", ""));
                }
                catch
                {
                    Program.Write("Error changing error log detail");
                }
            }
            else if (line.StartsWith("notice"))
            {
                string[] cmd = line.Split(new char[] { ',' });

                try
                {
                    switch (cmd.Length)
                    {
                        case 1:
                            World.Banner.Broad();
                            break;

                        case 2:
                            World.Banner.SetBroadCast(cmd[1]);
                            break;

                        case 3:
                            World.Banner.SetBroadCast(cmd[1], int.Parse(cmd[2].Trim()));
                            break;

                        case 4:
                            World.Banner.SetBroadCast(cmd[1], int.Parse(cmd[2].Trim()), int.Parse(cmd[3].Trim()));
                            break;
                    }

                    World.Banner.Build();
                    World.chat.SendWorldMsg(ref World.Banner.Broadcast, 0);

                }
                catch (Exception ex)
                {
                    log.Save(ex);
                }

            }
            else if (line.StartsWith("radio"))
            {
                string[] cmd = line.Split(new char[] { ',' });

                try
                {
                    switch (cmd.Length)
                    {
                        case 1:
                            World.Banner.broadcast("Brave warrior, fight for evolution", 3);
                            break;

                        case 2:
                            World.Banner.broadcast(cmd[1].Trim(), 3);
                            break;

                    }
                }
                catch
                {
                }

            }
            else if (line.StartsWith("enlog "))
            {
                try
                {
                    log.enlog = bool.Parse(line.Replace("enlog", " ").Replace(" ", ""));
                }
                catch
                {
                    Program.Write("Error changing error log file save");
                }
            }
            else if (line == "delp")
            {
                Program.CloseAll();
                System.Threading.Thread.Sleep(100);
                Program.CloseAll();
                System.Threading.Thread.Sleep(100);

                try
                {

                    if (System.IO.Directory.Exists(Game.PlayerDir))
                    {
                        System.IO.Directory.Delete(Game.PlayerDir, true);
                        Game.InitDirs();
                    }
                }
                catch (Exception ex)
                {
                    log.Save(ex);
                    Program.Write("Failed to delete player folder");
                }

                /*try
                {

                    lock (Gameplay.PlayerNames.stats)
                    {
                        Gameplay.PlayerNames.Reset();
                        Gameplay.PlayerNames.Save();
                    }

                }
                catch (Exception ex)
                {
                    log.Save(ex);
                    Program.Write("Failed to delete factions folder!");
                }*/

                try
                {

                  /*  if (System.IO.Directory.Exists(Guilds.guilddir))
                    {
                        System.IO.Directory.Delete(Guilds.guilddir, true);
                        // Game.CreateDir(Guilds.guilddir);
                    }

                    Guilds.Reset();
                    Guilds.init();*/
                }
                catch (Exception ex)
                {
                    log.Save(ex);
                    Program.Write("Failed to delete GuildFile!");
                }

                try
                {

                    string[] files = System.IO.Directory.GetFiles(Game.LoginDir);
                    ByteArray ar;
                    foreach (string f in files)
                    {
                        try
                        {
                            ar = new ByteArray(f);
                            if (ar.Length() == 14)
                            {
                                string uid = ar.ReadString();
                                ar.Clear();
                                ar.WriteString(uid);
                                ar.WriteInt(0);
                                ar.SaveFile(f);

                            }
                            ar.Close();
                            ar = null;
                        }
                        catch (Exception ex)
                        {
                            log.Save(ex);
                        }

                    }
                }
                catch
                {
                }

                GameServer.accounts.AccountHandler.Reset();
            }
            else if (line.StartsWith("gm"))
            {
                if (line.Contains(","))
                {
                    try
                    {
                        int idd = int.Parse(line.Replace(" ", "").Split(",".ToCharArray())[1]);
                        if (Players.MaxPlayer > idd && idd > 0)
                            Command.ChatController.gm = idd;
                    }
                    catch
                    {

                    }
                }
                else
                    Command.ChatController.gm = 1;
            }
            else if (line.StartsWith("zone"))
            {
                try
                {
                    Command.LoginController.TimeZoneValue = byte.Parse(line.Split(",".ToCharArray())[1]);
                }
                catch
                {
                }
            }
            else if (line.StartsWith("code"))
            {
                string[] comm = line.Split(",".ToCharArray());

                if (comm.Length < 2) return;
                string code = "";
                lock (Gameplay.SpecialCodes.codes)
                {
                    switch (comm[1])
                    {
                        case "add":
                            if (comm.Length != 4) return;

                            code = comm[2].ToLower().Replace(" ", "");

                            if (Gameplay.SpecialCodes.codes.ContainsKey(code))
                                return;

                            int i = int.Parse(comm[3].Replace(" ", ""));

                            Gameplay.SpecialCodes.codes.Add(code, i);
                            Gameplay.SpecialCodes.Save();

                            break;

                        case "del":
                            if (comm.Length != 3) return;
                            code = comm[2].ToLower().Replace(" ", "");

                            if (!Gameplay.SpecialCodes.codes.ContainsKey(code))
                                return;

                            Gameplay.SpecialCodes.codes.Remove(code);
                            Gameplay.SpecialCodes.Save();
                            break;

                        case "clear":
                            if (comm.Length != 2) return;
                            Gameplay.SpecialCodes.codes.Clear();
                            Gameplay.SpecialCodes.Save();
                            break;

                        case "reload":
                            if (comm.Length != 2) return;
                            Gameplay.SpecialCodes.codes.Clear();
                            Gameplay.SpecialCodes.Load();
                            break;

                    }
                }
            }
            else if (line.StartsWith("run"))
            {
                try
                {
                    string[] ex = line.Split(",".ToCharArray());


                    string file = ex[2];
                    file = "manual_script/" + file + ".txt";
                    if (System.IO.File.Exists(file))
                    {
                        string[] lines = System.IO.File.ReadAllLines(file);

                        for (byte i = 0; i < lines.Length; i++)
                        {
                            hidden.Codec.Command(lines[i].Replace("{p}", ex[1]));

                        }
                    }
                }
                catch
                {
                    Program.Write("Invalid script or script not found!");
                }
            }
            else
            {
                hidden.Codec.Command(line);
            }

        }
    }
}
