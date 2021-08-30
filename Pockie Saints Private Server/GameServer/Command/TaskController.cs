using System;

using System.Collections.Generic;


namespace GameServer.Command
{

    internal static class TaskController
    {

        internal static void c30000(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "TaskController 30000");
            int sceneid = c.Player.role.map_id;

            c.ot.WriteShort(c.Player.quest.Alist.Count);
            foreach (int qid in c.Player.quest.Alist.Keys)
            {
                c.ot.WriteInt(qid);
                c.ot.WriteShort(c.Player.quest.Alist[qid].Count);

                foreach (int task_id in c.Player.quest.Alist[qid].Keys)
                {

                    c.ot.WriteShort(Tasks.ConvertTask(c.Player.quest.Alist[qid][task_id].task_type));
                    c.ot.WriteShort(c.Player.quest.Alist[qid][task_id].complete);
                    c.ot.WriteInt(c.Player.quest.Alist[qid][task_id].task_id);
                    c.ot.WriteShort(c.Player.quest.Alist[qid][task_id].e_count);
                    c.ot.WriteShort(c.Player.quest.Alist[qid][task_id].f_now_count);
                    c.ot.WriteInt(c.Player.quest.Alist[qid][task_id].scene_id);
                    c.ot.WriteString(c.Player.quest.Alist[qid][task_id].additional_property);

                }

            }

            c.ot.WriteShort(c.Player.quest.Qlist.Count);
            foreach (int qid in c.Player.quest.Qlist.Keys)
            {
                c.ot.WriteInt(qid);
                c.ot.WriteShort(c.Player.quest.Qlist[qid].Count);

                foreach (int task_id in c.Player.quest.Qlist[qid].Keys)
                {

                    Tasks.TaskItem t = c.Player.quest.Qlist[qid][task_id];
                    int tid = c.Player.quest.GetTaskID(c, qid, task_id);


                    c.ot.WriteShort(Tasks.ConvertTask(t.task_type));
                    c.ot.WriteShort(t.complete);
                    c.ot.WriteInt(tid);                   //c.Player.quest.Qlist[qid][task_id].task_id);
                    c.ot.WriteShort(t.e_count);
                    c.ot.WriteShort(t.f_now_count);

                    if (tid != task_id)
                    {
                        c.ot.WriteInt(sceneid);
                        c.ot.WriteString("73#&50");
                    }
                    else
                    {
                        c.ot.WriteInt(t.scene_id);
                        c.ot.WriteString(t.additional_property);
                    }

                    //c.ot.WriteString(t.i_additional_property);

                    // c.Player.quest.Alist[qid][task_id].task_id)
                    /*  c.ot.WriteShort(Tasks.ConvertTask(c.Player.quest.Qlist[qid][task_id].quest_type));
                      c.ot.WriteShort(c.Player.quest.Qlist[qid][task_id].complete);


                      int tid = c.Player.quest.GetTaskID(c, qid, task_id);
                      c.ot.WriteInt(tid);//c.Player.quest.Qlist[qid][task_id].task_id);
                      c.ot.WriteShort(c.Player.quest.Qlist[qid][task_id].e_count);
                      c.ot.WriteShort(c.Player.quest.Qlist[qid][task_id].f_now_count);
                      c.ot.WriteInt(c.Player.quest.Qlist[qid][task_id].scene_id);


                      if (tid != task_id)

                          c.ot.WriteString(task_id.ToString() + "#73#&50");//"73#&50");
                      else
                          c.ot.WriteString(c.Player.quest.Qlist[qid][task_id].i_additional_property);*/

                }

            }

            c.ot.PackArray(30000);
        }

        internal static void c30003(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "TaskController 30003");

            int id = c.ar.ReadInt();
            byte r = 0;
            string s = "";

            if (c.Player.quest.Alist.ContainsKey(id))
            {

                r = QuestAccept.Parse(c, id);
                //s = 0;

                if (r == 1)
                {

                    c.Player.bag.Save();
                    c.Player.role.Save();
                    c.Player.medal.SaveMedal();
                    c.Player.quest.Save();
                }
                else
                {


                    if (r != 0 && r!=3)
                    {
                        s = "Quest error";
                    }
                    else
                    {
                        if (r != 3)
                        {
                            s = "Your bag may be full!";
                        }
                        else
                        {
                            s = "Level too low!";
                        }
                        
                    }

                }


            }
            else
            {
                s = "Quest does not exist";
            }

            c.ot.WriteByte(r);
            c.ot.WriteString(s);
            c.ot.PackArray(30003);


           

            if (r == 1)
            {
                c.ot.WriteShort(4);
                c.ot.WriteShort(30006);
                SceneController.UpdateNPC(c);
            }
        }

        internal static void c30004(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"TaskController 30004");

            int id = c.ar.ReadInt();
            byte r=0;
            byte s = 0;

            if (c.Player.quest.Qlist.ContainsKey(id))
            {

                s = c.Player.quest.GetStatus(id);

                if (s == 1)
                {
                    r = QuestCommand.Parse(c, id);
                    s = 0;

                    if (r == 1)
                    {
                        //c.Player.combat.Compute(true);
                        RoleController.SendRoleUpgrade(c, c.Player.role.LevelUp());
                        c.Player.bag.Save();
                        c.Player.role.Save();
                        c.Player.medal.SaveMedal();
                        c.Player.quest.Save();
                    }
                    else
                    {
                        s = r;
                    }
                }

            }
            else
            {
                s = 2;
            }

            c.ot.WriteByte(r);
            c.ot.WriteByte(s);
            c.ot.PackArray(30004);


            if (r == 1)
            {
                c.ot.WriteShort(4);
                c.ot.WriteShort(30006);
                SceneController.UpdateNPC(c);

                c.ot.WriteShort(8);
                c.ot.WriteShort(13020);
                c.ot.WriteInt(c.Player.role.Trial);
            }
        }

        internal static void c30005(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "TaskController 30005");


        }

        internal static void c30006(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "TaskController 30006");


        }

        internal static void c30008(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "TaskController 30008");


        }

        internal static void c30013(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "TaskController 30013");


        }

        internal static void c30014(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "TaskController 30014");


        }

    }
}
