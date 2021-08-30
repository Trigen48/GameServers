using System;

using System.Collections.Generic;

namespace GameServer.Command
{

	internal static class CollectController
	{

		internal static void c28001(ConnectionInfo c)
		{
			
            //Program.Write(">Command invoked: " +"CollectController 28001");

            int id = c.ar.ReadInt();
          //  int mapid=c.Player.charz.map_id;


            int ix = c.currentScene.GetMonster(id);


            if (ix != -1)
            {
                if (c.currentScene.CanCollect(id))
                {
                    c.currentScene.StartCollect(id, c);
                    c.ot.WriteByte(1);
                }
                else
                {
                    c.ot.WriteByte(2);
                    c.Player.quest.collectid = 0;
                }
            }
            else
            {
                c.ot.WriteByte(3);
                c.Player.quest.collectid = 0;
            }



            c.ot.PackArray(28001);
		}

		internal static void c28002(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"CollectController 28002");
			     
           // int mapid=c.Player.charz.map_id;

            if (c.currentScene.StopCollect(c))
            {
                c.ot.WriteByte(1);
            }
            else
            {
                c.ot.WriteByte(2);
            }
                
            c.Player.quest.collectid = -1;
            c.ot.PackArray(28002);
		}

        internal static void c28003(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"CollectController 28003");
            byte[] rep = null;
           // int mapid = c.Player.charz.map_id;
            byte r = 0;
            if (c.currentScene.CompleteCollect(c))
            {
                if (c.currentScene.ChestData.ContainsKey(c.Player.quest.collectid))
                {

                    if (c.Player.bag.CanBagAdd((byte)(c.currentScene.ChestData[c.Player.quest.collectid].Length)))
                    {
                        int[][] h = c.currentScene.ChestData[c.Player.quest.collectid];

                        h = World.DropFix.FixDrop(h, c.Player.role.level);

                        c.ar = new ByteArray();
                        c.ar.WriteShort(h.Length);

                        for (byte i = 0; i < h.Length; i++)
                        {
                            c.Player.bag.AddBagItem(h[i][0], (byte)h[i][1], (byte)h[i][2]);

                            c.ar.WriteInt(h[i][0]);
                            c.ar.WriteShort(h[i][1]);
                        }
                        c.ar.WriteShort(0);
                        c.ar.PackArray(28013);

                        rep = c.ar.GetByteArray();
                        c.ar.Close();
                        //c.Player.bag.Save();

                        // c.Socket.Send(rep);
                        c.currentScene.RemoveCollect(c.Player.quest.collectid);
                        c.ot.WriteByte(1);
                    }
                    else
                    {
                        c.ot.WriteByte(3);
                    }
                }
                else
                {

                    int ix = c.currentScene.GetMonster(c.Player.quest.collectid);
                    int mx = c.currentScene.Monsters[ix].monster_id;
                    if (c.Player.quest.Collects.ContainsKey(mx))
                    {
                        List<int> completes = new List<int>();

                        for (int x = 0; x < c.Player.quest.Collects[mx].Count; x++)
                        {
                            int qid = c.Player.quest.Collects[mx][x];

                            Tasks.TaskItem t = c.Player.quest.Qlist[qid][mx];

                            t.f_now_count++;
                            c.Player.quest.Qlist[qid][mx] = t;

                            t = new Tasks.TaskItem();
                            if (c.Player.quest.TaskComplete(qid))
                            {
                                completes.Add(qid);
                            }
                        }

                        for (int x = 0; x < completes.Count; x++)
                        {

                            foreach (int tid in c.Player.quest.Qlist[completes[x]].Keys)
                            {
                                Tasks.TaskItem t = c.Player.quest.Qlist[completes[x]][tid];

                                if (c.Player.quest.Collects[tid].Count == 1)
                                {
                                    c.Player.quest.Collects[tid].Clear();
                                    c.Player.quest.Collects.Remove(tid);
                                }
                                else
                                {
                                    c.Player.quest.Collects[tid].Remove(completes[x]);
                                }

                            }

                            c.Player.quest.Qlist[completes[x]].Clear();
                            Tasks.QuestPack p = c.Player.quest.questPack[completes[x]];
                            
                            c.Player.quest.questPack.Remove(completes[x]);

                            c.Player.quest.AddTaskComplete(completes[x], p.TaskID, 1, 1, p.SceneID);
                            p = null;

                        }
                        completes.Clear();
                        c.Player.quest.Save();
                        r = 1;
                    }

                    c.currentScene.RemoveCollect(c.Player.quest.collectid);

                    c.ot.WriteByte(1);
                }

            }

            else
            {
                c.ot.WriteByte(4);
            }
            c.Player.quest.collectid = -1;
            c.ot.PackArray(28003);

            if (rep != null)
            {
                c.ot.WriteBytes(rep);
                rep = null;
            }
            if (r == 1)
            {
                c.ot.WriteShort(4);
                c.ot.WriteShort(30006);
                SceneController.UpdateNPC(c);
            }
        }

		internal static void c28013(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"CollectController 28013");
		}

	}
}
