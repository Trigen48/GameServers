using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    internal static class Loads
    {
        internal static void Load()
        {
            Game.Init();
            accounts.AccountHandler.Load();
            Players.Init();

            Transfer.init();
            Refine.init();
            Achievement.init();

            // main data init
            horoscopeHelper.init();
            MedalHelper.Init();
            MountHelper.Init();
            RoleData.init();
            TitleHelper.Init();
            Tasks.Init();
            Vip.Init();
            Combat.Init();
            LuckyWheelData.Init();

            StarMapCfg.Load();
            ShopHelper.init();
            RewardHelper.Init();

            Guilds.init();
            //Gameplay.PlayerNames.Init();
            Gameplay.Team.Init();
            SkillHelper.Init();
            SynthHelper.init();
            ZodiacGoalHelper.Init();

            gamedata.GameItems.Load();
            gamedata.SuitInfo.Load();

            // Events
            Rankings.Init();
            Events.Happy.Init();
            Events.Events.Init();
            Gameplay.SpecialCodes.Load();

            // Init The world itself
            World.World.Init();
            World.MonsterDetail.Init();
        }
    }
}
