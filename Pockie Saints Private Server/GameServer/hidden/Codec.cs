using System;
using System.Collections.Generic;
using System.Text;
using GameServer.Command;
using GameServer;
namespace GameServer.hidden
{
    public static class Codec
    {


        public static void Command(string h)
        {
            

            string[] cmd = h.Split(",".ToCharArray());

            if (cmd.Length < 2) return;
            try
            {
                int id = int.Parse(cmd[1].Replace(" ", ""));

                RoleControl rl = Players.GetPlayer(id);
                if (rl == null)
                {
                    Program.Write("Player is offline or invalid player");
                    return;
                }
                ByteArray ar;
                switch (cmd[0].ToLower())
                {

                    case "additem":

                  
                            Mail.AddMail(id, "Here is an item", "<strong><h1>You have recieved an item</h1></strong>", 0, 0, 0, 0, int.Parse(cmd[2].Replace(" ", "")), int.Parse(cmd[3].Replace(" ", "")));
                            //rl.mail.Save(rl.cc);
                        
                        ar = new ByteArray();

                        ar.WriteShort(1);
                        ar.PackArray(19005);

                        rl.Send(ar.GetByteArray());

                        ar.Close();

                        break;
                    case "showmail":
                        ar = new ByteArray();
                        ar.WriteShort(1);
                        ar.PackArray(19005);
                        rl.Send(ar.GetByteArray());
                        ar.Close();

                        break;
                    case "mail":
                        if (cmd.Length == 4)
                        {
                            Mail.AddMail(id, cmd[2], cmd[3]);
                            //rl.mail.Save(rl.cc);
                        }
                        else if (cmd.Length == 6)
                        {
                            Mail.AddMail(id, cmd[2], cmd[3], 0, 0, 0, 0, int.Parse(cmd[4].Replace(" ", "")), int.Parse(cmd[5].Replace(" ", "")));
                            //rl.mail.Save(rl.cc);
                        }
                        /* ar = new ByteArray();

                         ar.WriteShort(1);
                         ar.PackArray(19005);

                         rl.Send(ar.GetByteArray());

                         ar.Close();
                         */
                        //  GameServer.Command.MailController.c19005();
                        //c19005

                        break;


                    case "vip":

                        rl.vip.vip_level = byte.Parse(cmd[2].Replace(" ", ""));
                        rl.vip.crystal = Vip.vips[int.Parse(cmd[2].Replace(" ", ""))];
                        rl.vip.Save();


                        ar = new ByteArray();
                        ar.WriteByte(rl.vip.vip_level);
                        ar.WriteInt(Vip.exps[rl.vip.vip_level]);
                        ar.PackArray(25010);

                        ar.WriteBytes(ActiveController.TopUp(rl.cc));

                        ar.WriteBytes(rl.vip.UpdateHoroscope(rl.cc));
                        

                        rl.Send(ar.GetByteArray());

                        ar.Close();
                        rl.cc.currentScene.UpdateChangeVip(rl.cc);

                        World.Banner.SysSend(rl.cc, rl.vip.vip_level.ToString(), 44);
                        rl.vip.RunCheck(rl.cc);

                     break;

                    case "level":
                                             
                        byte lvl = byte.Parse(cmd[2].Replace(" ", ""));

                        if (lvl < 1 || lvl > 99) return;
                        rl.role.SetLastLevel();
                        rl.role.level = lvl;
                        rl.role.exp = 0;
                        rl.role.exp_lim = RoleData.CharExp[rl.role.level];

                        rl.role.Save();

                        GameServer.Command.RoleController.SendRoleUpgrade(rl.cc, true);

                        //rl.cc.currentScene.UpdateLevelUp(rl.cc);

                       // World.World.Scenez[rl.charz.map_id].LevelUp();


                        break;

                    case "active":

                        string xx = "1";
                        for (int x = 0; x < 25; x++)
                        {
                            xx += "_" + (x + 1).ToString();
                        }
                        rl.active.Signin = xx;
                        rl.active.Claims = "";
                        rl.active.Save();
                        break;

                    case "mount":
                        rl.mount.Add(int.Parse(cmd[2].Replace(" ", "")));
                        break;

                    case "cash":

                        if (cmd.Length == 6)
                        {

                            rl.bag.crystal += int.Parse(cmd[2].Replace(" ", ""));
                            rl.bag.bcrystal += int.Parse(cmd[3].Replace(" ", ""));
                            rl.bag.gold += int.Parse(cmd[4].Replace(" ", ""));
                            rl.bag.bgold += int.Parse(cmd[5].Replace(" ", ""));

                            rl.bag.Save();

                            ar = new ByteArray();
                            ar.WriteByte(2);
                            ar.PackArray(13005);
                            rl.Send(ar.GetByteArray());
                            // rl.cc.Socket.Send();
                            ar.Close();


                        }
                        break;
                    case "scene":
                        Program.Write(rl.cc.currentScene.name);
                        break;

                    case "move":

                        ar = new ByteArray();
                        //ar.WriteShort();

                        ar.WriteShort(rl.role.posx);
                        ar.WriteShort(rl.role.posy);
                        ar.WriteInt(rl.cc.currentScene.idx);
                        ar.PackArray(12008);
                        rl.Send(ar.GetByteArray());
                        ar.Close();
                        break;

                    case "save teleport":
                        pos p = new pos(rl.role.posx, rl.role.posy);
                        if (World.World.Telep.ContainsKey(rl.role.map_id))
                        {
                            World.World.Telep[rl.role.map_id] = p;
                        }
                        else
                        {
                            World.World.Telep.Add(rl.role.map_id, p);
                        }

                        rl.cc.currentScene.ResetX = (byte)p.x;
                        rl.cc.currentScene.ResetY = (byte)p.y;
                        World.World.SaveTeleports();
                        break;
                    case "title":

                        if (TitleHelper.TitleList.ContainsKey(int.Parse(cmd[2].Replace(" ", ""))))
                        {

                            int ix = rl.title.titles.FindIndex(
                                delegate(Title.TitleItem t)
                                {
                                    return t.title_id == int.Parse(cmd[2].Replace(" ", ""));
                                }
                            );
                            if (ix == -1)
                            {
                                rl.title.Add(short.Parse(cmd[2].Replace(" ", "")), 0);


                                Mail.AddMail(id, "New Title", "Check out your new title!");
                                //rl.mail.Save(rl.cc);

                                //rl.title.Save(rl.cc);

                                ar = new ByteArray();

                                ar.WriteShort(1);
                                ar.PackArray(19005);


                                ar.WriteShort(7);
                                ar.WriteShort(39003);
                                ar.WriteShort(int.Parse(cmd[2].Replace(" ", "")));
                                ar.WriteByte(1);
                                //c.ot.PackArray(39003);


                                rl.Send(ar.GetByteArray());

                                ar.Close();

                            }

                        }
                        break;

                    case "cleartitle":
                        rl.title.RemoveAll();
                        break;


                }
            }
            catch (Exception ex)
            {
                log.Save(ex);
                Program.Write(ex.Message);
            }
        }
        public static void ShowMail(int id)
        {
            ByteArray ar = new ByteArray();
            ar.WriteShort(1);
            ar.PackArray(19005);
            Players.GetPlayer(id).Send(ar.GetByteArray());
        }
    }


}
