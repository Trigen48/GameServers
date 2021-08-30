using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace GameServer.World
{
    public class InstanceDialog
    {
        public byte Type;
        public string Dialog;
        public InstanceDialog()
        {
        }

        public InstanceDialog(byte type, string lvl)
        {
            Type = type;
            Dialog = lvl;
        }
    }

    public class InstanceData : IDisposable
    {
        public Dictionary<int, Scene> Floors;
        Timer tmr;
        public int StartTime = 0, RemoveTime = 0;
        public int NoPlayerTime = 0;
        public bool CanEnter = false;
        // int sceneCount=0;

        void IDisposable.Dispose()
        {
            if (tmr != null)
                tmr.Dispose();
        }

        public InstanceData()
        {
            Floors = new Dictionary<int, Scene>();
        }

        public void Add(int id, int res)
        {

        }

        public void InitScene()
        {
            //sceneCount = Floors.Count;
            if (tmr == null)
            {
                tmr = new Timer(1000);
                tmr.Elapsed += new ElapsedEventHandler(Render);
            }
            CanEnter = true;
            tmr.Start();
        }
        public bool IsActive()
        {
            return tmr.Enabled || Floors.Count != 0;
        }

        public void Destruction()
        {
            CanEnter = false;
            foreach (int keys in Floors.Keys)
            {
                ByteArray ot;
                Floors[keys].CanEnter = false;

                //lock(players)
                int[] k;//= (int[])(Floors[keys].players.ToArray().Clone());

                lock (Floors[keys].players)
                {
                    k = new int[Floors[keys].players.Count]; Floors[keys].players.Keys.CopyTo(k, 0);
                }

                for (int x = 0; x < k.Length; x++)
                {
                    RoleControl rl = Players.GetPlayer(k[x]);
                    if (rl == null || rl.role.map_id != Floors[keys].ID) continue;
                    ot = new ByteArray();


                    rl.role.posx = 34;
                    rl.role.posy = 42;
                    rl.role.map_id = 502;

                    ot.WriteInt(502);
                    ot.WriteShort(34);
                    ot.WriteShort(42);
                    ot.WriteString("");
                    ot.WriteInt(502);
                    ot.PackArray(12005);

                    rl.Send(ot.GetByteArray());

                    ot.Close();
                }

                k = null;
                Floors[keys].players.Clear();
                Floors[keys].Destroy();
            }
            Floors.Clear();
        }

        public void Render(object sender, ElapsedEventArgs e)
        {
            if (DateUtil.GetDateIntZone() >= RemoveTime)
            {
                tmr.Stop();
                Destruction();
                return;
            }


            if (NoPlayerTime != 0)
            {
                if (DateUtil.GetDateIntZone() >= NoPlayerTime)
                {
                    tmr.Stop();
                    Destruction();
                    return;
                }
            }

            #region Render Floors
            int fox = Floors.Count;
            foreach (int keys in Floors.Keys)
            {
                try
                {
                    int l = 0;

                    lock (Floors[keys].players)
                    {
                        l = Floors[keys].players.Count;
                    }

                    if (l != 0)
                        fox--;

                    Floors[keys].Render(null, null);
                }
                catch (Exception ex)
                {

                    log.Save(ex);

                    tmr.Stop();
                    Destruction();

                    return;
                }
            }
            #endregion

            #region Check for no player in instance
            if (fox != 0)
            {
                if (NoPlayerTime == 0)
                {
                    NoPlayerTime = (int)(DateUtil.GetDateIntZone() + (60 * 5));
                }
            }
            else
            {
                if (NoPlayerTime != 0)
                {
                    NoPlayerTime = 0;
                }
            }

            #endregion

        }

        public void Destroy()
        {


            if (tmr != null && tmr.Enabled == true)
                tmr.Stop();

            if (Floors != null)
            {
                foreach (int keys in Floors.Keys)
                {
                    try
                    {
                        Floors[keys].players.Clear();
                        Floors[keys].Destroy();
                        //Floors[keys] = null;  // Never midify value to this extnd or we get a force close
                    }
                    catch (Exception ex)
                    {
                        log.Save(ex);
                    }
                }
                Floors.Clear();

            }

        }
    }

}
