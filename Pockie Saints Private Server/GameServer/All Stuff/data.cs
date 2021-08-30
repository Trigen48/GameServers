using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using Connector;


namespace GameServer
{
    internal static class Players
    {
        public static int MaxPlayer = 100;
       // internal static RoleControl[] players;

        internal static List<RoleControl> roles;

        internal static void Init()
        {
           // players = new RoleControl[MaxPlayer];
            roles = new List<RoleControl>();
           
            Connector.MySqlConnector con = DatabaseInfo.GetConnection();

            // set all players to offline in case the server had crashed!!
            con.ExecuteNoneQuery("UPDATE role SET isonline=0;");

            con = null;
        }


        internal static bool RoleExists(int roleid)
        {
            int exists = -1;
            lock (roles)
            {
               exists= roles.FindIndex(delegate(RoleControl role){return role.cc.rlid==roleid;});
            }

            return exists != -1;
        }



        internal static void AddRole(RoleControl role)
        {
            lock (roles)
            {
                roles.Add(role);
            }
        }

        internal static void RemoveRole(RoleControl role)
        {
            lock (roles)
            {
                roles.Remove(role);
            }
        }
        internal static RoleControl GetPlayer(int roleid)
        {
            RoleControl rl = null;

            lock (roles)
            {
                rl = roles.Find(delegate(RoleControl role) { return role.cc.rlid == roleid; });
            }

            return rl;
        }

        
    }

    public class ConnectionInfo
    {
        public bool closing = false;
        public string accid;
        public Socket Socket;
        public byte[] Buffer;
        public bool CutConnection;
        public int rlid=-1;
        public ByteArray ar= new ByteArray(), ot=new ByteArray();
        public bool HasSlot = false;
        public ByteArray rot = new ByteArray();
        public byte[][] cmds;
        public Object SendBlock = new object();
        public long ConnID = 0;
        //public bool isgm = false;
        public MySqlConnector con = DatabaseInfo.GetConnection();
        RoleControl rl = null;

        public ConnectionInfo()
        { }

        public ConnectionInfo(int roleid)
        {
            rlid = roleid;
        }

        internal RoleControl Player
        {
            get
            {
                /*if (rlid <= Players.MaxPlayer && rlid>0)
                {
                    return Players.players[rlid];
                }*/
                return rl;
            }
            set
            {
                rl = value;
            }
        }

        internal Scene currentScene { get; set; }


        public void SwitchMap(Scene newScene)
        {

            if (currentScene != null)
                currentScene.RemovePlayer(this);

            Player.role.map_id = newScene.ID;
            currentScene = newScene;


            //newScene.AddPlayer(this);

        }

        internal static ConnectionInfo CreateInstance(int id)
        {
            ConnectionInfo c = new ConnectionInfo();
            c.rlid = id;
            return c;
        }
    }

}
