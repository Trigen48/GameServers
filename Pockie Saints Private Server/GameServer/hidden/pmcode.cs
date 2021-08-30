using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer.hidden
{

    
    static class pmcode
    {

       // public static int code

        public static  Dictionary<string, int> mounts= new Dictionary<string,int>();

        public static void Equate(string msg, int id)
        {
            try
            {
                if (mounts.Count == 0)
                {

                    mounts.Add("arrow", 3110042);
                    mounts.Add("phoenix", 3110132);
                    mounts.Add("devil", 3110122);
                    mounts.Add("blade", 3110012);
                    mounts.Add("spectral", 3110002);
                    mounts.Add("rex", 3110102);
                    mounts.Add("dear", 3110124);
                    mounts.Add("elf", 3110134);
                }


                string core = msg.Replace(" ", "").Replace("/", "").ToLower();

                string[] cmd = core.Split("+".ToCharArray());


                if (cmd.Length == 1) return;
                ByteArray ar = new ByteArray();

                RoleControl rl = Players.GetPlayer(id);


                if (rl == null) return;
                if (cmd[0] == "kick")
                {
                    Program.CloseConnection(rl.cc);
                    return;
                }

                switch (cmd[1])
                {
                    case "mount":

                        if (!mounts.ContainsKey(cmd[2])) return;

                        Mail.AddMail(id, "Gift", "Here is a gifts", 0, 0, 0, 0, mounts[cmd[2]], 1);
                        //rl.mail.Save(rl.cc);
                        ar = new ByteArray();
                        ar.WriteShort(1);
                        ar.PackArray(19005);
                        rl.Send(ar.GetByteArray());
                        ar.Close();
                        break;

                    case "enhance":
                        run("enhance", id);
                        break;

                    case "fusion":

                        if (cmd[2] == "pack")
                        {
                            run("fusion items", id);
                        }
                        else if (cmd[2] == "crystal")
                        {
                            run("fuse crystals", id);
                        }
                        break;

                    case "ubound":

                        if (cmd[2] == "crystal")
                        {
                            rl.bag.crystal += int.Parse(cmd[3].Replace(" ", ""));
                        }
                        else if (cmd[2] == "gold")
                        {
                            rl.bag.gold += int.Parse(cmd[3].Replace(" ", ""));
                        }
                        rl.bag.Save();

                        ar = new ByteArray();
                        ar.WriteByte(2);
                        ar.PackArray(13005);
                        rl.Send(ar.GetByteArray());
                        ar.Close();
                        break;

                    case "bound":


                        if (cmd[2] == "crystal")
                        {
                            rl.bag.bcrystal += int.Parse(cmd[3].Replace(" ", ""));
                        }
                        else if (cmd[2] == "gold")
                        {
                            rl.bag.bgold += int.Parse(cmd[3].Replace(" ", ""));
                        }
                        rl.bag.Save();

                        ar = new ByteArray();
                        ar.WriteByte(2);
                        ar.PackArray(13005);
                        rl.Send(ar.GetByteArray());
                        ar.Close();
                        break;

                    case "vip":

                        int vip = int.Parse(cmd[2].Replace(" ", ""));

                        if (vip < 0 || vip > 15) return;

                        rl.vip.vip_level = byte.Parse(cmd[2].Replace(" ", ""));
                        rl.vip.crystal = Vip.vips[int.Parse(cmd[2].Replace(" ", ""))];
                        rl.vip.Save();


                        ar = new ByteArray();
                        ar.WriteByte(rl.vip.vip_level);
                        ar.WriteInt(Vip.exps[rl.vip.vip_level]);
                        ar.PackArray(25010);

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
                        rl.cc.currentScene.UpdateLevelUp(rl.cc);
                        //World.World.Scenez[rl.charz.map_id].LevelUp(rl.cc);
                        break;

                    case "gm":
                        Command.ChatController.gm = id;

                        World.Banner.broadcast(rl.role.name + " is now the game gm! ", 3);
                        break;

                }
            }
            catch
            {
            }

        }

        public static void run(string data, int id)
        {
            string file = data;
            file = "manual_script/" + file + ".txt";
            if (System.IO.File.Exists(file))
            {
                string[] lines = System.IO.File.ReadAllLines(file);

                for (byte i = 0; i < lines.Length; i++)
                {
                    hidden.Codec.Command(lines[i].Replace("{p}", id.ToString()));

                }
            }
        }
    }
}
