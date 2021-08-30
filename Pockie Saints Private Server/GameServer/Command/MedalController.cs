using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class MedalController
	{

		internal static void c18000(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"MedalController 18000");

            //3330001          
            byte res = 2;

            if (c.Player.medal.medal_lev == 0)
            {
                int id = c.ar.ReadInt();
                int ix = c.Player.bag.bags[4].items.FindIndex(
                    delegate(Bag.Item b)
                    {
                        return b.itemid == id;
                    });



                if (ix != -1)
                {
                    c.Player.medal.ActivateMedal();
                    c.Player.medal.SaveMedal();

                    c.Player.bag.RemoveItem(ix, 4);

                    //c.Player.bag.bags[4].items.RemoveAt(ix);
                    //c.Player.bag.Save();

                    res = 1;
                    c.Player.combat.Compute(true);
                    //c.currentScene.UpdatePlayerWing(c);
                    c.currentScene.UpdatePlayerHp(c);
                }
            }
            c.ot.WriteByte(res);
            c.ot.PackArray(18000);
		}

        internal static void c18001(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"MedalController 18001");


            c.ot.WriteByte(c.Player.medal.medal_lev);// c.cn.adp["medal_lev"]);
            c.ot.WriteInt(c.Player.medal.starsoul);//c.cn.adp["starsoul"]);
            c.ot.WriteInt(MedalHelper.MedalPower[c.Player.medal.medal_lev][0]);//c.cn.adp["starsoul_tot"]);


            for (byte i = 0; i < 4; i++)
            {
                c.ot.WriteByte(c.Player.medal.Wings[i].level);
                c.ot.WriteInt(c.Player.medal.Wings[i].WingStarSoul);
                c.ot.WriteInt(MedalHelper.WingStarSoul[c.Player.medal.Wings[i].level]);
                c.ot.WriteInt(c.Player.medal.Wings[i].fails);
            }


            c.ot.PackArray(18001);

        }

		internal static void c18002(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"MedalController 18002");
            byte res=3;
           // c.Player.combat.Compute(false);
            bool isgoal = false;
            if (c.Player.medal.starsoul >= MedalHelper.MedalPower[c.Player.medal.medal_lev][0])
            {

                c.Player.medal.starsoul = c.Player.medal.starsoul - MedalHelper.MedalPower[c.Player.medal.medal_lev][0];
                c.Player.medal.medal_lev++;
                c.Player.medal.SaveMedal();
                res = 1;
                c.Player.combat.Compute(false);
                c.currentScene.UpdatePlayerHp(c);

                if (MedalHelper.MedalSkill[c.Player.medal.medal_lev] != 0)
                {
                    int skill = MedalHelper.MedalSkill[c.Player.medal.medal_lev] + ((c.Player.role.career - 1) * 100000);

                    if (c.Player.skill.SkillExists(skill))
                    {
                        c.Player.skill.AddSkill(skill, false);
                    }
                    else
                    {
                        c.Player.skill.AddSkill(skill, true);
                    }
                    //c.Player.skill.Save(c);
                    SkillController.SendSkillRefresh(c);

                }

                if (c.Player.medal.medal_lev == 2 && c.Player.goal.zodiac[0]==0)
                {
                    isgoal = true;
                }
            }


            c.ot.WriteByte(res);
            c.ot.WriteByte(c.Player.medal.medal_lev);
            c.ot.WriteInt(c.Player.medal.starsoul = c.Player.medal.starsoul);
            c.ot.WriteInt(MedalHelper.MedalPower[c.Player.medal.medal_lev][0]);
            c.ot.PackArray(18002);

            if (isgoal)
            {
                c.Player.goal.zodiac[0] = 1;
                c.Player.goal.Save();
                StarTargetController.SendGoal(c);
            }

		}

        internal static void c18003(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "MedalController 18003");

            byte mv = c.ar.ReadByte();
            mv -= 1;
            byte res = 2;
            byte ll = c.Player.medal.getMedalLevel();
            //    System.Threading.Thread.Sleep(50+ DateTime.UtcNow.Second);
            if (c.Player.medal.Wings[mv].WingStarSoul == MedalHelper.WingStarSoul[c.Player.medal.Wings[mv].level])
            {
                if (MedalHelper.WingFusion[c.Player.medal.Wings[mv].level][0] == 0)
                {
                    res = 1;
                    c.Player.medal.TryUpgrade((byte)(mv));
                }
                else
                {
                    if (c.Player.bag.UseType(MedalHelper.WingFusion[c.Player.medal.Wings[mv].level][0], MedalHelper.WingFusion[c.Player.medal.Wings[mv].level][1]))
                    {
                        //c.Player.bag.Save();
                        if (c.Player.medal.TryUpgrade((byte)(mv)))
                        {
                            res = 1;
                        }
                        else
                        {
                            res = 0;
                        }
                    }
                    else
                    {
                        res = 5;
                    }
                }
            }
            else
            {
                res = 3;
            }
            c.ot.WriteByte(res);
            c.ot.WriteByte(mv + 1);
            c.ot.WriteByte(c.Player.medal.Wings[mv].level);
            c.ot.WriteInt(c.Player.medal.Wings[mv].WingStarSoul);
            c.ot.WriteInt(MedalHelper.WingStarSoul[c.Player.medal.Wings[mv].level]);
            c.ot.WriteInt(c.Player.medal.Wings[mv].fails);

            c.Player.medal.SaveWing(mv);
            c.ot.PackArray(18003);

            if (res == 1)
            {
                c.Player.combat.Compute(true);
                c.currentScene.UpdatePlayerWing(c);
                byte medle = c.Player.medal.getMedalLevel();
                if (medle == 2 && c.Player.goal.zodiac[1] == 0)
                {
                    c.Player.goal.zodiac[1] = 1;
                    c.Player.goal.Save();
                    StarTargetController.SendGoal(c);
                }
                if (medle > 3 && ll == medle - 1)
                    World.Banner.SysSend(c, medle.ToString() + "#&" + medle.ToString() + "#&" + c.Player.medal.MedalTotal().ToString() + "#&" + c.Player.medal.MedalTotal().ToString(), 41);
            }
        }

		internal static void c18004(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"MedalController 18004");
			
			
		}

		/*internal static void c18010(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"MedalController 18010");
			
			
		}*/

	}
}
