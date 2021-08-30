using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class SkillController
	{

        internal static void SendSkillRefresh(ConnectionInfo c)
        {
            ByteArray ar = new ByteArray();
            ByteArray x = new ByteArray();

            ar.WriteShort(c.Player.skill.skills.Count);
            for (byte i = 0; i < c.Player.skill.skills.Count; i++)
            {
                ar.WriteInt(c.Player.skill.skills[i].skill_id);
                ar.WriteByte(c.Player.skill.skills[i].skill_level);
            }
            ar.PackArray(21002);

            x.WriteBytes(ar.GetByteArray());
            ar.Close();
            ar = new ByteArray();

            ar.WriteShort(c.Player.skill.skills.Count);
            for (byte i = 0; i < c.Player.skill.skills.Count; i++)
            {
                ar.WriteInt(c.Player.skill.skills[i].skill_id);
                ar.WriteInt(c.Player.skill.skills[i].GetSkillTime());
            }
            ar.PackArray(21003);

            x.WriteBytes(ar.GetByteArray());
            ar.Close();
            c.Socket.Send(x.GetByteArray());
            x.Close();
            x = null;
            ar = null;
        }

        internal static void SendSkillCool(ConnectionInfo c)
        {

            int num = 6 + (8 * c.Player.skill.skills.Count);


            c.ot.WriteShort(num);
            c.ot.WriteShort(21003);

            c.ot.WriteShort(c.Player.skill.skills.Count);
            for (byte i = 0; i < c.Player.skill.skills.Count; i++)
            {
                c.ot.WriteInt(c.Player.skill.skills[i].skill_id);
                c.ot.WriteInt(c.Player.skill.skills[i].GetSkillTime());
            }

        }

		internal static void c13006(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SkillController 13006");
			
			
		}

/*
		internal static void c20002(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SkillController 20002");
			
			
		}

*/
/*
		internal static void c20006(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SkillController 20006");
			
			
		}

*/
        internal static void c21001(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"SkillController 21001");

            int id = c.ar.ReadInt();

            /*public var c_lv:Int8;
             * public var a_id:int;
             * public var b_code:Int8;
             * public var d_content:String;*/
            string res = "";
            byte ms = 0;
            byte lev = 0;
            

            if (!c.Player.skill.SkillExists(id))
            {
                #region Create Skill
                if (SkillHelper.Skills.ContainsKey(id) && c.Player.bag.ItemTypeExists(SkillHelper.Skills[id]))
                {
                    c.ar = new ByteArray("skillscripts/"+ id.ToString()+"_1");

                    if (c.Player.role.level >= c.ar.ReadByte())
                    {
                        int g = c.ar.ReadInt();

                        if (c.Player.bag.gold + c.Player.bag.bgold >= g)
                        {

                            bool skillq = false;

                            switch(c.ar.ReadByte())
                            {
                                case 0:
                                    skillq = true;
                                    break;

                                case 1:
                                    skillq = c.Player.skill.SkillRequire(c.ar.ReadInt(), c.ar.ReadByte());

                                    break;

                                case 2:
                                    skillq = c.Player.skill.SkillRequire(c.ar.ReadInt(), c.ar.ReadByte()) && c.Player.skill.SkillRequire(c.ar.ReadInt(), c.ar.ReadByte());
                                    break;
                            }

                            if (c.Player.medal.medal_lev >= c.ar.ReadByte())
                            {
                                if (skillq)
                                {
                                    if (c.Player.bag.bgold < g)
                                    {
                                        g = g - c.Player.bag.bgold;
                                        c.Player.bag.bgold = 0;
                                        c.Player.bag.gold -= g;
                                    }
                                    else
                                    {
                                        c.Player.bag.bgold -= g;
                                    }


                                    c.Player.bag.RemoveByType(SkillHelper.Skills[id]);
                                    c.Player.skill.AddSkill(id);
                                    c.Player.bag.Save();
                                    //c.Player.skill.Save(c);
                                    ms = 1;
                                    lev = 1;
                                    c.ar.Close();

                                }
                                else
                                {
                                    res = "Skill requirements not met!";
                                    c.ar.Close();
                                }
                            }
                            else
                            {
                                res = "Skill needs higher medal level!";
                                c.ar.Close();
                            }
                        }
                        else
                        {
                            res = "<strong>More gold is needed to learn skill!</strong>";
                            c.ar.Close();
                        }

                    }
                    else
                    {
                        res = "<strong>Level too low!!</strong>";
                        c.ar.Close();
                    }
                    
                }
                else
                {
                    res = "<u><strong>Skill book</strong></u> or Skill does not exist!";
                }
            }
                #endregion
            else
            {
                if (SkillHelper.Skills.ContainsKey(id))
                {
                    lev=c.Player.skill.SkillLevel(id);
                    if (!System.IO.File.Exists("skillscripts/" + id.ToString() + "_" + lev.ToString()))
                    {
                        res = "Skill is already on maximum or failed to upgrade!";
                        goto esc;
                    }
                    c.ar = new ByteArray("skillscripts/" + id.ToString() + "_" + lev.ToString());

                    if (c.Player.role.level >= c.ar.ReadByte())
                    {
                        int g = c.ar.ReadInt();

                        if (c.Player.bag.gold + c.Player.bag.bgold >= g)
                        {

                            bool skillq = false;

                            switch (c.ar.ReadByte())
                            {
                                case 0:
                                    skillq = true;
                                    break;

                                case 1:
                                    skillq = c.Player.skill.SkillRequire(c.ar.ReadInt(), c.ar.ReadByte());

                                    break;

                                case 2:
                                    skillq = c.Player.skill.SkillRequire(c.ar.ReadInt(), c.ar.ReadByte()) && c.Player.skill.SkillRequire(c.ar.ReadInt(), c.ar.ReadByte());
                                    break;
                            }

                            if (c.Player.medal.medal_lev >= c.ar.ReadByte())
                            {
                                if (skillq)
                                {
                                    if (c.Player.bag.bgold < g)
                                    {
                                        g = g - c.Player.bag.bgold;
                                        c.Player.bag.bgold = 0;
                                        c.Player.bag.gold -= g;
                                    }
                                    else
                                    {
                                        c.Player.bag.bgold -= g;
                                    }

                                    c.Player.skill.AddSkill(id,false);
                                    c.Player.bag.Save();
                                    //c.Player.skill.Save(c);
                                    ms = 1;
                                  //  lev = 1;
                                    c.ar.Close();
                                }
                                else
                                {
                                    res = "Skill requirements not met!";
                                    c.ar.Close();
                                }
                            }
                            else
                            {
                                res = "Skill needs higher medal level!";
                                c.ar.Close();
                            }
                        }
                        else
                        {
                            res = "<strong>More gold is needed to learn skill!</strong>";
                            c.ar.Close();
                        }

                    }
                    else
                    {
                        res = "<strong>Level too low!!</strong>";
                        c.ar.Close();
                    }

                }
                else
                {
                    res = "<u><strong>Skill book</strong></u> or Skill does not exist!";
                }
            }

        esc: ;
            c.ot.WriteInt(id);
            c.ot.WriteByte(ms);
            c.ot.WriteByte(lev);
            c.ot.WriteString(res);
            c.ot.PackArray(21001);

        }

		internal static void c21002(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SkillController 21002");

 
            c.ar.Close();

            c.ot.WriteShort(c.Player.skill.skills.Count);
            for (byte i = 0; i < c.Player.skill.skills.Count; i++)
            {
                c.ot.WriteInt(c.Player.skill.skills[i].skill_id);
                c.ot.WriteByte(c.Player.skill.skills[i].skill_level);
            }
            c.ot.PackArray(21002);

			
		}

		internal static void c21003(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SkillController 21003");

            // use skill
            c.ar.Close();

            c.ot.WriteShort(c.Player.skill.skills.Count);
            for (byte i = 0; i < c.Player.skill.skills.Count; i++)
            {
                c.ot.WriteInt(c.Player.skill.skills[i].skill_id);
                c.ot.WriteInt(c.Player.skill.skills[i].GetSkillTime());
            }
            c.ot.PackArray(21003);
		}

	}
}
