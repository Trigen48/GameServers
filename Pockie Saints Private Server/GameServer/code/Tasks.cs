using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
//using ProtoBuf;
namespace GameServer
{
    // [ProtoContract]
    public class Tasks
    {

        //static byte[] QuestLevels;
        static string LevelQuestString;
        public static void Init()
        {
            LevelQuestString = System.IO.File.ReadAllText("world/QuestPack.json");
        }

        //[ProtoContract]
        public class TaskItem
        {
            [ContentProto("task_type")]
            public byte task_type { get; set; }

            [ContentProto("complete")]
            public byte complete { get; set; }

            [ContentProto("task_id", true)]
            public int task_id { get; set; }

            [ContentProto("e_count")]
            public short e_count { get; set; }

            [ContentProto("f_now_count")]
            public short f_now_count { get; set; }

            [ContentProto("scene_id")]
            public int scene_id { get; set; }

            [ContentProto("additional_property")]
            public String additional_property { get; set; }

            //[ContentProto("")]
            public List<int> Scenes { get; set; }

            public TaskItem()
            {
                Scenes = new List<int>();
                additional_property = "";
            }
        }

        // [ProtoContract]
        public class QuestPack
        {
            // [ProtoMember(1)]
            public int TaskID { get; set; }

            // [ProtoMember(2)]
            public int SceneID { get; set; }
            public QuestPack()
            {

            }
            public QuestPack(int task, int scene)
            {
                TaskID = task;
                SceneID = scene;
            }
        }

        //  [ProtoContract]
        public class TaskItemList
        {
            //[ProtoMember(1)]
            public Dictionary<int, TaskItem> list { get; set; }

            /*[ProtoMember(2)]
            public bool Complete { get; set; }*/

            public TaskItemList()
            {
                list = new Dictionary<int, TaskItem>();
            }

            public TaskItem this[int index]
            {
                get
                {
                    return list[index];
                }
                set
                {
                    list[index] = value;
                }
            }

            [Browsable(false)]
            public int Count
            {
                get
                {
                    return list.Count;
                }
            }

            public bool ContainsKey(int key)
            {
                return list.ContainsKey(key);
            }

            public void Add(int key, TaskItem item)
            {
                list.Add(key, item);
            }

            public bool Remove(int key)
            {
                return list.Remove(key);
            }

            [Browsable(false)]
            public Dictionary<int, TaskItem>.KeyCollection Keys
            {
                get
                {
                    return list.Keys;
                }
            }

            public void Clear()
            {
                list.Clear();
            }

        }

        //[ProtoContract]
        public class TaskLevelItem
        {
             //[ProtoMember(1)]
            public int QuestID { get; set; }

            //[ProtoMember(2)]
            public int TaskID { get; set; }

            //[ProtoMember(3)]
            public int SceneID { get; set; }

            public TaskLevelItem()
            {
            }

            public TaskLevelItem(int q, int t, int s)
            {
                QuestID = q;
                TaskID = t;
                SceneID = s;
            }
        }

        //[ProtoContract]
        public class TaskLevelList
        {
            //[ProtoMember(1)]
            public Dictionary<int, List<TaskLevelItem>> LevelQuests { get; set; }

            public TaskLevelList()
            {
                LevelQuests = new Dictionary<int, List<TaskLevelItem>>();
            }

        }


        // const string file = "Tasks";
        public int collectid = -1;
        public Dictionary<int, TaskItemList> Qlist { get; set; }
        public Dictionary<int, TaskItemList> Alist { get; set; }

        public Dictionary<int, QuestPack> questPack { get; set; }
        public Dictionary<int, List<int>> NpcList { get; set; }
        public Dictionary<int, List<int>> ANpcList { get; set; }
        public Dictionary<int, List<int>> Monsters { get; set; }
        public Dictionary<int, List<int>> Collects { get; set; }
        public TaskLevelList LevelQuest { get; set; }

        ConnectionInfo c;
        public Tasks(ConnectionInfo c)
        {
            this.c = c;
            Qlist = new Dictionary<int, TaskItemList>();
            Alist = new Dictionary<int, TaskItemList>();


            questPack = new Dictionary<int, QuestPack>();

            ANpcList = new Dictionary<int, List<int>>();
            NpcList = new Dictionary<int, List<int>>();
            Monsters = new Dictionary<int, List<int>>();
            Collects = new Dictionary<int, List<int>>();
            LevelQuest = new TaskLevelList();
            //  DailyQuests = new Dictionary<int, int>();
        }

        public bool AddTaskComplete(int QuestID, int TaskID, byte type, byte complete, int scene)
        {
            return AddTaskComplete(QuestID, TaskID, type, complete, scene, 0);
        }

        public bool AddTaskComplete(int QuestID, int TaskID, byte type, byte complete, int scene, short count)
        {
            return AddTaskComplete(QuestID, TaskID, type, complete, scene, count, TaskID);
        }

        public bool AddTaskComplete(int QuestID, int TaskID, byte type, byte complete, int scene, short count, int tasklid)
        {
            int questno = GetQuestNo(c.rlid, QuestID);

            TaskItem t = new TaskItem();

            t.task_type = type;
            t.complete = complete;
            t.task_id = TaskID;
            t.scene_id = scene;
            t.additional_property = "";
            t.e_count = count;

            bool IsNew = !Qlist.ContainsKey(QuestID);


            if (IsNew)
            {
                Qlist.Add(QuestID, new TaskItemList());
            }



            AddType(QuestID, tasklid, ref t);
            Qlist[QuestID].Add(tasklid, t);

           // Save();
          
            return true;
        }

        public bool AddTaskAccept(int QuestID, int TaskID, byte type, byte complete, int scene)
        {
            return AddTaskComplete(QuestID, TaskID, type, complete, scene, 0);
        }

        public bool AddTaskAccept(int QuestID, int TaskID, int scene)
        {
            int questno = GetQuestNo(c.rlid, QuestID);



            bool IsNew = !Alist.ContainsKey(QuestID);


            if (IsNew)
            {
                Alist.Add(QuestID, new TaskItemList());
            }


            TaskItem itm = new TaskItem();

            itm.task_type = 0;
            itm.complete = 0;
            itm.task_id = TaskID;
            itm.scene_id = scene;
            itm.additional_property = "";
            itm.e_count = 0;



            Alist[QuestID].Add(itm.task_id, itm);

            if (!ANpcList.ContainsKey(TaskID))
            {
                ANpcList.Add(TaskID, new List<int>());
            }
            ANpcList[TaskID].Add(QuestID);

          //  Save();
            return true;
        }

        public bool AddPack(int qid, int tid, int scene)
        {

            questPack.Add(qid, new QuestPack(tid, scene));
            return true;
        }

        public void RemoveQtask(int QuestID)
        {
            int npc_id = 0;

            foreach (int id in Qlist[QuestID].Keys)
            {
                npc_id = id;
            }

            if (NpcList.ContainsKey(npc_id))
            {
                NpcList[npc_id].Remove(QuestID);

                if (NpcList[npc_id].Count == 0)
                {
                    NpcList.Remove(npc_id);
                }
            }
            Qlist.Remove(QuestID);
          //  Save();
        }

        public int GetTaskID(ConnectionInfo c, int qid, int tid)
        {

            if (Qlist[qid][tid].Scenes.Count != 0)
            {
                string sc = c.Player.role.map_id.ToString();
                int id = Qlist[qid][tid].Scenes.FindIndex(delegate(int n) { return n.ToString().StartsWith(sc); });

                if (id >= 0)
                {
                    return Qlist[qid][tid].Scenes[id];
                }
            }
            return tid;
        }

        static int Translate(int type, int scene)
        {
            if (World.World.IsInstance(scene) && World.MonsterDetail.Mons.InstanceMonsters.ContainsKey(type))
            {
                return World.MonsterDetail.Mons.InstanceMonsters[type];
            }

            return type;
        }
        public bool UpdateMonster(int monstertype1, byte monsterNum, int scene)
        {


            int monstertype = Translate(monstertype1, scene);

            if (Monsters.ContainsKey(monstertype))
            {
                List<int> completes = new List<int>();

                for (int x = 0; x < Monsters[monstertype].Count; x++)
                {
                    int qid = Monsters[monstertype][x];

                    Tasks.TaskItem t = Qlist[qid][monstertype];
                    if (t.complete == 1) continue;

                    t.f_now_count += monsterNum;
                    Qlist[qid][monstertype] = t;

                    t = new Tasks.TaskItem();
                    if (TaskComplete(qid))
                    {
                        completes.Add(qid);
                    }
                }

                for (int x = 0; x < completes.Count; x++)
                {

                    foreach (int tid in Qlist[completes[x]].Keys)
                    {
                        Tasks.TaskItem t = Qlist[completes[x]][tid];

                        if (Monsters[tid].Count == 1)
                        {
                            Monsters[tid].Clear();
                            Monsters.Remove(tid);
                        }
                        else
                        {
                            Monsters[tid].Remove(completes[x]);
                        }

                    }

                    Qlist[completes[x]].Clear();

                    Tasks.QuestPack p = questPack[completes[x]];
                    questPack.Remove(completes[x]);

                    AddTaskComplete(completes[x], p.TaskID, 1, 1, p.SceneID);
                    p = null;

                }
                completes.Clear();
                completes = null;

               // Save();
                return true;
            }
            return false;
        }

        public void RemoveAtask(int QuestID)
        {
            int npc_id = 0;

            foreach (int id in Alist[QuestID].Keys)
            {
                npc_id = id;
                break;
            }


            if (ANpcList.ContainsKey(npc_id))
            {
                ANpcList[npc_id].Remove(QuestID);

                if (ANpcList[npc_id].Count == 0)
                {
                    ANpcList.Remove(npc_id);
                }
            }
            Alist.Remove(QuestID);

            //c.con.StartCommand("DELETE FROM quest WHERE questid=");
            //Save();
        }

        public byte GetStatus(int QuestID)
        {

            foreach (int id in Qlist[QuestID].Keys)
            {
                if (Qlist[QuestID][id].task_type == 1)
                    return Qlist[QuestID][id].complete;

            }

            return 2;
        }

        public bool TaskComplete(int QuestID)
        {

            int[] k = new int[Qlist[QuestID].Count];

            Qlist[QuestID].Keys.CopyTo(k, 0);

            lock (Qlist)
            {
                for (byte x = 0; x < k.Length; x++)
                {
                    int id = k[x];
                    if (Qlist[QuestID][id].e_count > Qlist[QuestID][id].f_now_count) return false;

                    TaskItem t = Qlist[QuestID][id];
                    if (t.complete == 0)
                    {
                        t.complete = 1;
                        Qlist[QuestID][id] = t;
                    }
                }

            }
            /* foreach (int id in Qlist[QuestID].Keys)
             {

             }*/
           // Save();
            return true;
        }

        private void AddType(int QuestID, int tasklid, ref TaskItem t)
        {

            switch (t.task_type)
            {
                case 1:
                    if (!NpcList.ContainsKey(t.task_id))
                    {
                        NpcList.Add(t.task_id, new List<int>());
                    }
                    NpcList[t.task_id].Add(QuestID);

                    t.additional_property = World.World.Scenez[t.scene_id].GetNPCPos(t.task_id);



                    break;

                case 2:
                    if (!Monsters.ContainsKey(tasklid))
                    {
                        Monsters.Add(tasklid, new List<int>());
                    }
                    Monsters[tasklid].Add(QuestID);

                    if (World.World.SceneFloors.ContainsKey(t.scene_id))
                        t.additional_property = World.World.NpcLink[t.scene_id];// tasklid.ToString() + "#&"+ .ToString() + "#&73#&50";

                    else
                        t.additional_property = "73#&50";
                    // t.i_additional_property = QuestID.ToString() + "#&" + t.scene_id.ToString() + "#&73#&50";

                    if (World.MonsterDetail.Mons.MonstersPacks.ContainsKey(t.task_id))
                    {
                        t.Scenes.AddRange(World.MonsterDetail.Mons.MonstersPacks[t.task_id].MonsterIDS.ToArray());
                    }
                    break;

                case 4:
                    if (!Collects.ContainsKey(tasklid))
                    {
                        Collects.Add(tasklid, new List<int>());
                    }
                    Collects[tasklid].Add(QuestID);
                    t.additional_property = tasklid.ToString() + "#&2#&0#&0";
                    break;

                case 25:
                    if (!Monsters.ContainsKey(tasklid))
                    {
                        Monsters.Add(tasklid, new List<int>());
                    }
                    Monsters[tasklid].Add(QuestID);
                    t.additional_property = tasklid.ToString() + "#&2#&0#&0";
                    if (World.MonsterDetail.Mons.MonstersPacks.ContainsKey(t.task_id))
                    {
                        t.Scenes.AddRange(World.MonsterDetail.Mons.MonstersPacks[t.task_id].MonsterIDS.ToArray());
                    }
                    break;
            }

        }

        public static byte ConvertTask(byte id)
        {

            switch (id)
            {

                case 25:
                    return 2;
            }

            return id;
        }

        public void CheckType1()
        {
            int l = c.Player.role.LastLevel;
            int cu = c.Player.role.level;


            if (LevelQuest.LevelQuests.Count == 0) return;

            for (int i = l; i <= cu; i++)
            {
                if (LevelQuest.LevelQuests.ContainsKey(i))
                {

                    foreach (TaskLevelItem itm in LevelQuest.LevelQuests[i])
                    {
                        AddTaskAccept(itm.QuestID, itm.TaskID, itm.SceneID);
                    }
                    LevelQuest.LevelQuests[i].Clear();
                    LevelQuest.LevelQuests.Remove(i);
                }
            }
            //Save();
            ByteArray ot = new ByteArray();
            ot.WriteShort(4);
            ot.WriteShort(30006);

            c.Player.Send(ot.GetByteArray());
            ot.Close();
            ot = null;

        }

        public static bool Load(ConnectionInfo c, ref Tasks ta)
        {
          // Tasks ta = this;
            //ByteC.LoadProto(c.accid + file, ref val);

            c.con.StartCommand("SELECT questdata FROM quest WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);
            Connector.DataReader rd = c.con.ExecuteRead();

            if (rd.Rows > 0 && rd.NextRow())
            {
                try
                {
                    ta = Newtonsoft.Json.JsonConvert.DeserializeObject<Tasks>(rd.ReadString());
                    ta.c = c;
                }
                catch
                {
                }
            }


            return true;

        }

        public bool Save()
        {
            c.con.StartCommand("UPDATE quest SET questdata=? WHERE roleid=?");
            try
            {
                c.con.AddValue(Newtonsoft.Json.JsonConvert.SerializeObject(this));
            }
            catch
            {
            }
            c.con.AddValue(c.rlid);


            return c.con.ExecuteNoneQuery() > 0;
        }
         

        //private static void InsertNewTask(ConnectionInfo c,int 
        public static void Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            Tasks t = new Tasks(c);
            t.AddTaskComplete(100001, 100001, 1, 1, 100);

            // t.Save();
            TaskLevelList v = new TaskLevelList();
            lock (LevelQuestString)
            {
                //ByteC.LoadProto(QuestLevels, ref v);
                v = JsonLib.Load<TaskLevelList>(LevelQuestString);// Newtonsoft.Json.JsonConvert.DeserializeObject;
            }

            t.LevelQuest = v;
            //t.TransportAmount = 3;
            //t.Save();

            //SET questdata=? WHERE roleid=?");
            c.con.StartCommand("INSERT INTO quest(roleid,questdata) VALUES(?,?);");
            c.con.AddValue(c.rlid);
            c.con.AddValue(Newtonsoft.Json.JsonConvert.SerializeObject(t));

            c.con.ExecuteNoneQuery();// > 0;
            t = null;
            //v = null;
        }

        public static void AddQuestFinance(ConnectionInfo c, int exp, int gold, int medal, int trial)
        {
            c.Player.role.exp += exp;
            c.Player.bag.bgold += gold;
            c.Player.medal.starsoul += medal;
            c.Player.role.Trial += trial;


        }

        public static int GetQuestNo(int roleid, int questid)
        {
            return (roleid * 1000000) + questid;
        }

        public static int GetQuestID(int roleid, int questno)
        {
            return questno - (roleid * 1000000);
        }

    }
}
