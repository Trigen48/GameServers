using System;
using System.Collections.Generic;
using System.Text;
using Connector;
namespace GameServer
{
    internal static class Game
    {
        //internal static string DefaultDir = "Accounts/";
        internal static string mainDir = "accounts/";
        internal static string LoginDir;//="Accounts/uid/";
        internal static string PlayerDir;// = "Accounts/players/";
        internal static string AccountFile = "accounts";
        internal static string CharUID = "";
        internal static string BackupDir = "";

        internal static byte StartLevel = 1,StartVip=0,StartX=43,StartY=90;
        internal static int Gold=0, BGold=0,BCrystal=0, Crystal=0;
        internal static int PKModeTime = 3600;
        internal static int StartScene = 100;

        public static void Init()
        {
            LoginDir = mainDir + "uid/";
            PlayerDir = mainDir + "players/";
            AccountFile = mainDir + AccountFile;

            CharUID = PlayerDir + "charuid/";
            BackupDir = PlayerDir + "Backup/";

            InitDirs();
        }

        public static void InitDirs()
        {  
            CreateDir(LoginDir);
            CreateDir(PlayerDir);
            CreateDir(CharUID);
            CreateDir(BackupDir);
        }

        public static void CreateDir(String dir)
        {
            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }
        }


        public static MySqlConnector GetConnection()
        {
            return new MySqlConnector("127.0.0.1","saintsdb","root","");
        }
            
    }
}
