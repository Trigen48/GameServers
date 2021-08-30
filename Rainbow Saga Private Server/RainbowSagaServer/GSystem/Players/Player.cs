using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;
using RainbowServer.proto.game;
namespace RainbowServer
{

    internal class Charactor
    {
        static byte[] datablank = new byte[0];


        internal ConnectionInfo c;
        internal CharInfo player= new CharInfo();
        internal string Dir = "";
        internal UnitProperties props=new UnitProperties();
        internal CProto.Friends friends = new CProto.Friends();

        internal void Load(int id)
        {
            Dir = Folders.CharDir + id.ToString() + "\\";
            ByteTool.LoadProto(Dir + "profile.c", ref player);
            ByteTool.LoadProto(Dir + "unit.c", ref props);
            ByteTool.LoadProto(Dir + "friends.c", ref friends);

         //   AddItem(0);
        }

        internal void SaveMain()
        {
            lock (player)
            {
                ByteTool.SaveProto(Dir + "profile.c", ref player);
            }
        }

        internal static void CreateChar(int gender,int id,string AccName)
        {
            string Dir = Folders.CharDir + id.ToString() + "\\";
            Folders.CreateDir(Dir);


            CharInfo info = new CharInfo();

            info.accname = AccName;
            info.level = 1;
            info.charid = id;
            info.charname = "???";
            info.profession = 0;

            info.hair = 19000059;
            info.face = 19500029;

            #region Weapons Settup
            EquipmentSlot q = new EquipmentSlot();

            // Add Cap
            q.equipSlot = "Cp";
            q.equipItem.gemSlotNum = 1;
            q.equipItem.itemname = "cap1";
            q.equipItem.id = 10500010;
            q.equipItem.uuid = CharData.GetNextItem();
            info.bEquipon.equips.Add(q);

            q = new EquipmentSlot();
            q.equipSlot = "Ma";
            q.equipItem.gemSlotNum = 1;
            q.equipItem.itemname = "coat1";
            q.equipItem.id = 11500010;
            q.equipItem.uuid = CharData.GetNextItem();
            info.bEquipon.equips.Add(q);

            q = new EquipmentSlot();
            q.equipSlot = "Pn";
            q.equipItem.gemSlotNum = 1;
            q.equipItem.itemname = "pants1";
            q.equipItem.id = 12000010;
            q.equipItem.uuid = CharData.GetNextItem();
            info.bEquipon.equips.Add(q);

            q = new EquipmentSlot();
            q.equipSlot = "Gv";
            q.equipItem.gemSlotNum = 1;
            q.equipItem.itemname = "glove1";
            q.equipItem.id = 11000010;
            q.equipItem.uuid = CharData.GetNextItem();
            info.bEquipon.equips.Add(q);

            q = new EquipmentSlot();
            q.equipSlot = "So";
            q.equipItem.gemSlotNum = 1;
            q.equipItem.itemname = "shoes1";
            q.equipItem.id = 12500010;
            q.equipItem.uuid = CharData.GetNextItem();
            info.bEquipon.equips.Add(q);

            q = new EquipmentSlot();
            q.equipSlot = "Wp";
            q.equipItem.gemSlotNum = 1;
            q.equipItem.itemname = "weapon";
            q.equipItem.id = 10001000;
            q.equipItem.uuid = CharData.GetNextItem();
            info.bEquipon.equips.Add(q);
            #endregion


            info.level = 1;
            info.lastzoneid = 1;
            //info.foDisplay = 1;
            info.createdWorldId = 1;

            // Setup Bag
            info.bInfo.bConsume.slotNum = 18;
            info.bInfo.bEquip.slotNum = 18;
            info.bInfo.bGem.slotNum = 18;
            info.bInfo.bMaterial.slotNum = 18;
            info.bInfo.bHomestead.slotNum = 18;
            info.bInfo.bTask.slotNum = 18;
            info.bInfo.bStore.slotNum = 18;

            info.bInfo.bSystem.autoRevive = 1;
            info.bInfo.bSystem.vechileDisplay = 1;
            info.bInfo.bSystem.volumeSet.effectVolume = 8;
            info.bInfo.bSystem.volumeSet.musicVolume = 8;
            info.bInfo.bSystem.volumeSet.onOff = 1;
            info.bInfo.bSystem.remoteChallenge = 0;
            info.bInfo.bSystem.displaySet = 1;
            //info.bInfo.
            info.gender = gender;

            info.xpos = 3;
            info.ypos = 5;

            info.hp = 600;
            info.hpPool = 600;
            info.mp = 500;
            info.mpPool = 600;

            info.hpHealThreshold = 600;
            info.mpHealThreshold = 600;
            info.exp = 3;
            info.relivehpfactor = 200;
            info.reliveexpfactor = 300;
            info.xp = 1;

            info.energy = 30;
            info.dex = 1;
            info.con = 1;


            info.scene = 80000001;
            info.bInfo.bContinuousLogin.num = 7;


            ByteTool.SaveProto(Dir+ "profile.c",ref info);

           // info.bInfo.

            info = null;

            UnitProperties props = new UnitProperties();


            props.maxHp = 56;
            props.maxMp = 48;


            props.con = 5;
            props.str = 12;
            props.intl = 4;
            props.crtMaxRate = 150;
            props.jump = 1;
            props.combatPower = 500;


            props.walkSpeed = 300;
            props.con = 1;
            props.str = 1;
            props.mastery = 85;
            props.jump = 2;
            props.maxHp = 600;
            props.hpIncrease = 600;
            props.maxMp = 500;
            props.moneyRate = 10;
            props.combatPower = 200;
            props.dex = 5;
           
         //   props.

            /*UpdatePlayerProperty
                 l = new UpdatePlayerProperty.l();*/
            
            ByteTool.SaveProto(Dir+"unit.c", ref props);
            props = null;
            //props.thunder1;
            
            
           /* System.IO.FileStream fs = new System.IO.FileStream(, System.IO.FileMode.Create);
            Serializer.Serialize(fs, info);
            fs.Flush();
            fs.Close();
            fs = null;*/

            
            BlankFile(Dir + "friends.c");
           /* BlankFile(Dir + "friends_temp.c");
            BlankFile(Dir + "friends_black.c");
            BlankFile(Dir + "friends_require.c");*/
        }


        static void BlankFile(string file)
        {
            System.IO.File.WriteAllBytes(file, datablank);
        }
    }

    internal static class Players
    {
        internal static Charactor[] players;
        internal static int MaxPlayers=100;

        internal static Charactor Get(ConnectionInfo c)
        {
            return Get(c.charid);
        }

        internal static Charactor Get(int id)
        {
            return players[id];
        }
        internal static CharInfo player(ConnectionInfo c)
        {
            return player(c.charid);
        }
        internal static CharInfo player(int id)
        {
            return players[id].player;
        }

        internal static void init()
        {
            players = new Charactor[MaxPlayers];
        }
        internal static void LoadChar(int id)
        {

            if (players[id] == null)
            {
                lock (players)
                {
                    players[id] = new Charactor();
                    players[id].Load(id);

                }
            }
        }

        internal static QueryCharInfoResponse GetProfiles(ref QueryCharInfoRequest req, ref ConnectionInfo c)
        {
            QueryCharInfoResponse res = new QueryCharInfoResponse();


            if (req.accname == c.AccName)
            {
                string ply= Folders.CharDir+req.accname+".ply";
               
                if (System.IO.File.Exists(ply))
                {
                   // string plyi = Folders.CharDir + req.accname;
                    ByteArray ar = new ByteArray(ply);
                    if (ar.length > 1)
                    {
                        byte len = ar.ReadByte();

                        if (len > 0 && len < 4)
                        {
                            int id = 1;
                            while (len > 0)
                            {
                                id = ar;
                                CharInfo inf = new CharInfo();
                                ByteTool.LoadProto(Folders.CharDir + id.ToString() + "\\profile.c",ref inf);
                                res.infos.Add(inf);
                                len--;
                            }
                        }

                    }

                    ar.Close();
                }
            }
            else
            {
                res.result = 902;
            }

            return res;
        }

        internal static CreateCharResponse CreateChar(ref CreateCharRequest req, ref ConnectionInfo c)
        {

            CreateCharResponse res = new CreateCharResponse();


            if (c.AccName != "" && CharData.Nextid < MaxPlayers)
            {
                string ply = Folders.CharDir + c.AccName + ".ply";
                byte len = 0;
                byte[] accounts = null;
                ByteArray ar = null;
                int id = 0;
                if (System.IO.File.Exists(ply))
                {
                    // string plyi = Folders.CharDir + req.accname;
                    ar = new ByteArray(ply);

                    len = ar.ReadByte();

                    if (len > 2)
                    {
                        res.result = 1;
                        return res;
                    }
                    if (res.result == 0 && len > 0)
                    {
                        accounts = ar;
                        if (len != accounts.Length / 4)
                        {
                            res.result = 2;
                            accounts = null;
                        }

                    }
                    ar.Close();

                }

                if (res.result == 0)
                {

                    id = CharData.GetNextChar();
                    ar = new ByteArray();
                    len++;

                    ar.WriteByte(len);
                    if (accounts != null)
                        ar.WriteBytes(accounts);

                    ar.WriteInt(id);
                    ar.SaveFile(ply);
                    ar.Close();

                    accounts = null;

                    Charactor.CreateChar(req.gender,id,c.AccName);
                    res.charid = id;

                }
                ar = null;

            }
            else
            {
                res.result = 2;
            }

            return res;
        }

        internal static DisableCharResponse DeleteChar(ref DisableCharRequest req, ref ConnectionInfo c)
        {
            DisableCharResponse res = new DisableCharResponse();



            if (req.username == c.AccName)
            {
                string ply = Folders.CharDir + req.username + ".ply";

                if (System.IO.File.Exists(ply))
                {
                    List<int> chars = new List<int>();
                    // string plyi = Folders.CharDir + req.accname;
                    ByteArray ar = new ByteArray(ply);
                    byte len = ar.ReadByte();

                    if (len > 0 && len < 4)
                    {
                        int id = 1;
                        while (len > 0)
                        {
                            id = ar;
                            chars.Add(id);
                            len--;
                        }
                    }
                    ar.Close();

                    if (chars.Contains(req.charid))
                    {  
                        chars.Remove(req.charid);
                        ar = new ByteArray();
                        ar.WriteByte(chars.Count);

                        foreach (int id in chars)
                        {
                            ar.WriteInt(id);
                        }
                        ar.SaveFile(ply);
                        ar.Close();
                        ar = null;
                        chars.Clear();
                        chars = null;

                        try
                        {
                            System.IO.Directory.Delete(Folders.CharDir+req.charid.ToString()+"\\",true);
                        }
                        catch(Exception ex)
                        {
                            log.Save(ex);
                        }
                        res.charid = req.charid;
                        res.charname = req.charname;
                        
                    }
                    else
                    {
                        res.result = 6;
                    }
                }
            }
            else
            {
                res.result = 902;
            }

            return res;

        }
    }
}
