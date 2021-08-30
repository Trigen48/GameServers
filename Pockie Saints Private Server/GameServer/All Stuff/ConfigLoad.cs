using System;

namespace GameServer
{
    static class ConfigLoad
    {


        internal static void GetDatabase()
        {
            const string confFile = "config/database.cfg";

            if (!System.IO.File.Exists(confFile))
                return;

            config.ConfigLoader conf = new config.ConfigLoader(confFile);

            
            conf.GetString(ref DatabaseInfo.Server, "server");
            conf.GetString(ref DatabaseInfo.database, "database");
            conf.GetString(ref DatabaseInfo.User, "user");
            conf.GetString(ref DatabaseInfo.Password, "password");
            conf.Close();
            conf = null;

        }
        internal static void GetConfig()
        {
        const string confFile = "config/game.cfg";
            if (!System.IO.File.Exists(confFile))
                return;

            config.ConfigLoader conf = new config.ConfigLoader(confFile);


            string player_dir = "";
            string web = "";


            // Get Configuration Settings
            conf.GetShort(ref Command.LoginController.TimeZoneValue, "time-zone");
            conf.GetInt(ref Players.MaxPlayer, "max-players");
            conf.GetInt(ref Program.port, "server-port");
            DateUtil.Zone = Command.LoginController.TimeZoneValue;

            conf.GetBool(ref World.World.EnableRunCheck, "enable-player-check");

            conf.GetInt(ref Program.SendRetry, "send-retry");
            conf.GetInt(ref Program.SendTimeout, "send-retry-time");

            conf.GetBool(ref log.enlog, "enable-log-save");

            conf.GetString(ref player_dir, "player-dir");

            conf.GetTimes(ref World.Beach.Times, "beach-times");
            conf.GetInt(ref World.Beach.Duration, "beach-duration");

            conf.GetInt(ref World.Beach.chestSpawnRate, "beach-chest-spawn-rate");
            World.Beach.NextSpawnRate = World.Beach.chestSpawnRate + 3; // Add three seconds fwait for next chests

            conf.GetBool(ref World.World.BackUpTimeEnable, "backup-time-enabled");
            conf.GetTime(ref World.World.BackUpTime, "backup-time");

            conf.GetBool(ref World.World.RankUpdateTimeEnable, "rank-update-time-enabled");
            conf.GetTime(ref World.World.RankUpdateTime, "rank-update-time");


            conf.GetTime(ref Gameplay.BattleFieldConfig.BattleFieldRegTime, "battle-reg-time");
            conf.GetTime(ref Gameplay.BattleFieldConfig.BattleFieldTime, "battle-time");
            conf.GetInt(ref Gameplay.BattleFieldConfig.Duration, "battle-duration");
            Gameplay.BattleFieldConfig.ResetBattleField();

            conf.GetByte(ref Game.StartLevel, "start-level");
            conf.GetInt(ref Game.Gold, "start-gold");
            conf.GetInt(ref Game.BGold, "start-bound-gold");
            conf.GetInt(ref Game.BCrystal, "start-bound-crystal");
            conf.GetInt(ref Game.Crystal, "start-crystal");

            conf.GetInt(ref Game.StartScene, "start-scene");
            conf.GetByte(ref Game.StartX, "start-x");
            conf.GetByte(ref Game.StartY, "start-y");

            conf.GetByte(ref Game.StartVip, "start-vip");
            conf.GetString(ref web, "server-web");

            conf.GetInt(ref Game.PKModeTime, "pk-mode-time");


            conf.GetInt(ref Scene.MonsterPatrolTimeOut, "Monster-Patrol-Timeout");

            #region Check Game Directory
            if (player_dir == "")
                player_dir = Game.mainDir;


        Recheck: ;
            if (!System.IO.Directory.Exists(player_dir))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(player_dir);
                }
                catch
                {
                    if (player_dir == Game.mainDir)
                        throw new Exception("Could not create game dir!");

                    player_dir = Game.mainDir;
                    goto Recheck;

                }
            }

            if (player_dir != "")
            {
                if (!player_dir.EndsWith("/"))
                    player_dir += "/";
            }


            if (web != "" && System.IO.Directory.Exists(web))
            {
                try
                {
                    System.IO.File.WriteAllText(web + "AccountDir.php", player_dir);
                }
                catch (Exception ex)
                {
                    log.Save(ex);
                }
            }
            Game.mainDir = player_dir;
            #endregion

            conf.Close();
            conf = null;

            DateUtil.init(); // Init for timezone
        }
    }
}
