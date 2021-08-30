using System;

using System.Collections.Generic;

namespace GameServer.Command
{

	internal static class SceneController
	{
        internal static void UpdateNPC(ConnectionInfo c)
        {

            Dictionary<int, byte> vo = new Dictionary<int, byte>();
            //int mp=c.Player.charz.map_id;


            for (int x = 0; x < c.currentScene.NPC.Count; x++)
            {
                int npcid = c.currentScene.NPC[x].a_id;
                vo.Add(npcid, 0);
                if (c.Player.quest.NpcList.ContainsKey(npcid))
                {
                    foreach (int questid in c.Player.quest.NpcList[npcid])
                    {
                        byte a = c.Player.quest.GetStatus(questid);

                        if (vo[npcid] < DialogController.Complete[a]) vo[npcid] = DialogController.Complete[a];
                    }
                    
                }

                if (c.Player.quest.ANpcList.ContainsKey(npcid))
                {
                    foreach (int questid in c.Player.quest.ANpcList[npcid])
                    {
                        byte a = 0;

                        if (vo[npcid] < DialogController.Complete[a]) vo[npcid] = DialogController.Complete[a];
                    }

                }
            }
         
            c.ar = new ByteArray();
            /*c.ot.WriteShort(6 + (vo.Count * 5));
            c.ot.WriteShort(12020);*/

            c.ar.WriteShort(vo.Count);
            foreach (int ky in vo.Keys)
            {
                c.ar.WriteInt(ky);
                c.ar.WriteByte(vo[ky]);
            }
            c.ar.PackArray(12020);
            c.ot.WriteBytes(c.ar.GetByteArray());
            c.ar.Close();
            vo.Clear();
            vo = null;

        }

        internal static byte[] GetScene(ConnectionInfo c, int map, byte x, byte y)
        {
            ByteArray ot = new ByteArray();
            int result = map;
            string msg = "";

            Scene sc = World.World.GetSceneByMap(map);

            if (sc == null)
            {
                if (map == c.Player.role.map_id)
                {

                    // Force teleportation!!!
                    result = map = 502;
                    c.Player.role.posx = 34;
                    c.Player.role.posy = 42;

                    //c.Player.role.map_id = 502;
                    c.SwitchMap(World.World.GetSceneByMap(map));

                }
                else
                {
                    result = 0;
                    msg = "Scene error or scene unavailable!";
                }
            }
            else if (!sc.CanEnter)
            {
                if (map == c.Player.role.map_id)
                {

                    result = map = 502;
                    c.Player.role.posx = 34;
                    c.Player.role.posy = 42;
                    //map = 502;

                    c.SwitchMap(World.World.GetSceneByMap(map));

                }
                else
                {
                    result = 0;
                    msg = "Scene unavailable!";
                }

            }
            else if (c.Player.role.map_id != map)
            {
                pos cs = sc.ResolvePosition(c.Player.role.map_id);
                if (cs.x != 0)
                {
                    c.Player.role.posx = (short)cs.x;
                    c.Player.role.posy = (short)cs.y;

                    result = map;
                    c.SwitchMap(sc);
                }
                else
                {
                    result = 0;
                    msg = "Scene error or scene unavailable! ";
                }
            }
            else
            {
                c.SwitchMap(sc);
            }


            c.ot.WriteInt(result);
            c.ot.WriteShort(c.Player.role.posx);
            c.ot.WriteShort(c.Player.role.posy);
            c.ot.WriteString(msg);
            c.ot.WriteInt(c.Player.role.map_id);

            c.ot.PackArray(12005);


            if (result != 0)
                c.Player.role.Save();

            byte[] d = ot.GetByteArray();
            ot.Clear();

            return d;
        }


		internal static void c10009(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 10009");

            c.Player.gameframe.width = c.ar.ReadByte();
            c.Player.gameframe.height = c.ar.ReadByte();
			
		}

		internal static void c12001(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 12001");

            int x, y, x2, y2;
            x = (short)c.ar.ReadShort();
            y = (short)c.ar.ReadShort();
            byte t = c.ar.ReadByte();

            x2 = c.Player.role.posx;
            y2 = c.Player.role.posy;
            c.Player.role.posx = (short)x;
            c.Player.role.posy = (short)y;
            if (t == 0)
            {

                try
                {

                    c.currentScene.UpdatePosition(c, 0);
                }
                catch
                {
                    c.Player.role.posx = (short)x2;
                    c.Player.role.posy = (short)y2;

                }

            }
            else
            {
                try
                {

                    c.currentScene.UpdatePosition(c, 1);
                }
                catch
                {
                    c.Player.role.posx = (short)x2;
                    c.Player.role.posy = (short)y2;

                }
            }

            c.ot.WriteShort(c.Player.role.posx);
            c.ot.WriteShort(c.Player.role.posy);
            c.ot.WriteInt(c.rlid);
            c.ot.WriteByte(t);

            c.ot.PackArray(12001);
		}

		internal static void c12002(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 12002");


            c.currentScene.AddPlayer(c);

            c.currentScene.GetSceneObjects(c.ot);
            c.ot.PackArray(12002);

            UpdateNPC(c);

            c.currentScene.GetSceneDrops(c.ot);

            // Update task
            c.ot.WriteShort(4);
            c.ot.WriteShort(30006);

           // TaskController
		}

		internal static void c12003(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12003");
			
			
		}

		internal static void c12004(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12004");
			
			
		}

        internal static void c12005(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"SceneController 12005");
            int map = c.ar.ReadInt();
            int result = map;
            string msg = "";

            if (World.World.IsInstance(map))
            {
                if (!World.World.InstanceIsCreated(c) || World.World.Instances[c.rlid].Floors.Count != 0)
                {
                    if (World.World.InstanceIsCreated(c))
                    {
                        if (World.World.Instances[c.rlid].Floors.ContainsKey(c.Player.role.map_id)
                            && World.World.Instances[c.rlid].Floors.ContainsKey(map))
                            goto next;
                    }
                    World.World.CreateInstance(map, c);
                }

                next:;

               // int last = ;

               /* if (map != c.Player.role.map_id)
                    c.currentScene.RemovePlayer(c);*/

                //c.Player.role.map_id = map; // Set Map 

                Scene sc = World.World.GetInstance(c, map);

                pos p = sc.ResolvePosition(c.Player.role.map_id);

                if (p.x == 0 && p.y == 0)
                {
                    c.Player.role.posx =sc.ResetX;
                    c.Player.role.posy = sc.ResetY;
                }
                else
                {
                    c.Player.role.posx = (byte)p.x; 
                    c.Player.role.posy = (byte)p.y;
                }

                c.SwitchMap(sc);
                //  c.currentScene.AddPlayer(c);
                //c.Player.role.Save();
            }
            else
            {

                Scene sc = World.World.GetSceneByMap(map);

                if (sc == null)
                {
                    if (map == c.Player.role.map_id)
                    {

                        // Force teleportation!!!
                        result = map = 502;
                        c.Player.role.posx = 34;
                        c.Player.role.posy = 42;

                        //c.Player.role.map_id = 502;
                        c.SwitchMap(World.World.GetSceneByMap(map));

                    }
                    else
                    {
                        result = 0;
                        msg = "Scene error or scene unavailable!";
                    }
                }
                else if (!sc.CanEnter)
                {
                    if (map == c.Player.role.map_id)
                    {

                        result = map = 502;
                        c.Player.role.posx = 34;
                        c.Player.role.posy = 42;
                        //map = 502;

                        c.SwitchMap(World.World.GetSceneByMap(map));

                    }
                    else
                    {
                        result = 0;
                        msg = "Scene unavailable!";
                    }

                }
                else if (c.Player.role.map_id != map)
                {
                    pos cs = sc.ResolvePosition(c.Player.role.map_id);
                    if (cs.x != 0)
                    {
                        c.Player.role.posx = (short)cs.x;
                        c.Player.role.posy = (short)cs.y;

                        result = map;
                        c.SwitchMap(sc);
                    }
                    else
                    {
                        result = 0;
                        msg = "Scene error or scene unavailable! ";
                    }
                }
                else
                {
                    c.SwitchMap(sc);
                }

            }



            c.ot.WriteInt(result);
            c.ot.WriteShort(c.Player.role.posx);
            c.ot.WriteShort(c.Player.role.posy);
            c.ot.WriteString(msg);
            c.ot.WriteInt(c.Player.role.map_id);

            c.ot.PackArray(12005);


            if (result != 0)
                c.Player.role.Save();

        }

		internal static void c12006(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12006");
			
			
		}

		internal static void c12007(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12007");
			
			
		}

		internal static void c12008(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12008");
			
			
		}

		internal static void c12009(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 12009");
            int i = 12009;

            int id = c.ar.ReadInt();
            /*if (id == c.rlid)
            {*/
            RoleControl rl=Players.GetPlayer(id);
                c.ot.WriteInt(id);
                c.ot.WriteInt(rl.combat.hp);
                c.ot.WriteInt(rl.combat.hp_lim);
            /*}
            else
            {
            }*/
            c.ot.PackArray(i);
			
		}

		internal static void c12010(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12010");
			
			
		}

		internal static void c12011(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12011");
			
			
		}

		internal static void c12012(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12012");
			
			
		}

		internal static void c12013(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12013");
			
			
		}

		internal static void c12014(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12014");
			
			
		}

		internal static void c12015(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12015");
			
			
		}

		internal static void c12016(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12016");
			
			
		}

		internal static void c12017(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12017");
			
			
		}

		internal static void c12018(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12018");
			
			
		}

		internal static void c12019(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12019");
			
			
		}

		internal static void c12020(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12020");
			
			
		}

		internal static void c12021(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12021");
			
			
		}

		internal static void c12022(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12022");
			
			
		}

		internal static void c12023(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12023");
			
			
		}

		internal static void c12030(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 12030");
            int ff=c.currentScene.ID;


            if(!World.World.IsInstance(ff))return;
            
            c.ot.WriteBytes(GetScene(c, 502, 0, 0));

            World.World.Instances[c.rlid].Destroy();
            World.World.Instances[c.rlid] = null;
         

		}

		internal static void c12050(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 12050");

            			
            int a_sid=c.ar.ReadInt();
			short b_x=(short)c.ar.ReadShort();
			short c_y=(short)c.ar.ReadShort();
			int d_gid=c.ar.ReadInt();


            if (d_gid != 0 && c.Player.bag.ItemTypeExists(d_gid))
            {

                if (World.World.Scenez.ContainsKey(a_sid))
                {
                    c.ot.WriteBytes(GetScene(c, a_sid, (byte)b_x, (byte)c_y));

                    if (c.Player.role.map_id == a_sid)
                    {
                        c.Player.bag.UseType(d_gid, 1);
                        //c.Player.bag.Save();
                    }


                }
                else
                {
                    c.ot.WriteString("No teleport scrolls!");
                    c.ot.PackArray(12050);
                }
            }
            else if (d_gid == 0)
            {

            }
            else
            {
                c.ot.WriteString("Cannot teleport");
                c.ot.PackArray(12050);
            }

            c.ot.WriteShort(5);
            c.ot.WriteShort(13005);
            c.ot.WriteByte(2);
		}

		internal static void c12080(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 12080");

            int i = 12080;
            c.ot.WriteBytes(System.IO.File.ReadAllBytes(i.ToString() + ".bin"));
            c.ot.PackArray(i);
		}

		internal static void c12081(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12081");
			
			
		}

		internal static void c12082(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12082");
			
			
		}

		internal static void c12083(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12083");
			
			
		}

		internal static void c12084(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12084");
			
			
		}

		internal static void c12086(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 12086");
			
			
		}

		internal static void c13013(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 13013");
			
			
		}

		internal static void c13014(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 13014");
			
			
		}

		internal static void c13016(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 13016");
			
			
		}

		internal static void c13019(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 13019");
			
			
		}

		internal static void c20001(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 20001");
            c.Player.combat.Compute();

            bool UpdateQuest = false;
            if (c.Player.skill.Time> DateUtil.GetDateIntZone())
            {
                c.ot.WriteByte(2);
                c.ot.PackArray(13008);
                return;
            }

            c.Player.skill.Time = 0;

            int id, skill;
            id = c.ar.ReadInt();
            skill = c.ar.ReadInt();
            int mid = c.currentScene.GetMonster(id);
            int sk = c.Player.skill.SkillIndex(skill);

            if (mid == -1||sk==-1) return;
            SceneMonster m = c.currentScene.Monsters[mid];

            int exp = c.currentScene.GetExp(m.monster_id);
            c.Player.combat.mp -= 10;

            c.ot.WriteInt(c.rlid);
            c.ot.WriteInt(c.Player.combat.mp); //mp left
            c.ot.WriteInt(skill);// skill used

            c.ot.WriteShort(1);// hit monster count

            int damage = c.Player.combat.MonsterDamage(c, id);

            m.hp -= damage;
            

            c.ot.WriteByte(1); // atk type
            c.ot.WriteInt(id); // monster id
            c.ot.WriteInt(damage);// damage

            if (damage == 0) 
                c.ot.WriteByte(1);
            else 
                c.ot.WriteByte(0); // if dodge

            c.ot.PackArray(20001);

            if (m.hp <= 0)
            {
                // remove monster from scene, 
                c.currentScene.MonsterRemove(c, id);

                if (c.Player.quest.UpdateMonster(m.monster_id, 1,c.Player.role.map_id))
                {
                    c.Player.quest.Save();
                    UpdateQuest = true;
                }

                if (exp != 0)
                {
                    c.Player.role.exp += exp;
                    c.Player.role.exp += (int)((double)exp * c.Player.horoscope.charexp);
                    // team exp here


                   // if(c.Player.
                    RoleController.SendRoleUpgrade(c, c.Player.role.LevelUp());
                }
            }
            else
            {
                // else justupdate the current hp instead
                mid = c.currentScene.GetMonster(id);
                if (mid == -1) return;
                lock(c.currentScene.Monsters)
                    c.currentScene.Monsters[mid]=m;

                c.ot.WriteShort(12);
                c.ot.WriteShort(12081);
                c.ot.WriteInt(id);
                c.ot.WriteInt(m.hp);
               
            }

            
            c.currentScene.Broadcast(c.ot.GetByteArray());
            c.Player.skill.UseSkill(skill);

            c.Player.skill.Time = (int)DateUtil.GetDateIntZone() + 1;
            // SkillController.SendSkillCool(c);
            c.ot.Clear();

            if (UpdateQuest)
            {
                c.ot.WriteShort(4);
                c.ot.WriteShort(30006);
                SceneController.UpdateNPC(c);
            }
		}

		internal static void c20002(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 20002");

            c.Player.combat.Compute();


            if (c.Player.skill.Time > DateUtil.GetDateIntZone())
            {
                c.ot.WriteByte(2);
                c.ot.PackArray(13008);
                return;
            }

            int id, skill;
            id = c.ar.ReadInt();
            skill = c.ar.ReadInt();

            c.Player.combat.mp -= 10;

            c.ot.WriteInt(c.rlid);
            c.ot.WriteInt(c.Player.combat.mp); //mp left
            c.ot.WriteInt(skill);// skill used

            c.ot.WriteShort(1);// hit monster count

            int damage = c.Player.combat.PlayerDamage(c, id);

            c.ot.WriteByte(2); // atk type
            c.ot.WriteInt(id); // monster id
            c.ot.WriteInt(damage);// damage
            if (damage == 0) c.ot.WriteByte(1); else c.ot.WriteByte(0); // if dodge

      RoleControl enrl= Players.GetPlayer(id);
            c.ot.PackArray(20002);

            c.ot.WriteShort(16);
            c.ot.WriteShort(12009);
            c.ot.WriteInt(id);
            c.ot.WriteInt(enrl.combat.hp);
            c.ot.WriteInt(enrl.combat.hp_lim);
            //ot.PackArray(12009);
            //can = false;

            c.currentScene.Broadcast(c.ot.GetByteArray());
           // World.World.GetScene(id).UpdatePlayerHp(Players.GetPlayer(id).cc);

            c.Player.skill.UseSkill(skill);

            c.Player.skill.Time = (int)DateUtil.GetDateIntZone() + 1;
            c.ot.Clear();

		}

		internal static void c20003(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 20003");
			
			
		}

		internal static void c20004(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"SceneController 20004");

            c.Player.combat.Compute();
            c.Player.combat.hp = (int)(c.Player.combat.hp_lim * 0.5);

            c.currentScene.UpdatePlayerHp(c);


            c.currentScene.Revive(c);
		}

		internal static void c20005(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 20005");
			
			
		}

		internal static void c20006(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 20006");
			
			
		}

		internal static void c20007(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 20007");
			
			
		}

		internal static void c20008(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 20008");
			
			
		}

		internal static void c20009(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 20009");
			
			
		}

		internal static void c21004(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 21004");
			
			
		}

		internal static void c31011(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 31011");
			
			
		}

		internal static void c33010(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 33010");
			
			
		}

		internal static void c41023(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"SceneController 41023");
			
			
		}

	}
}
