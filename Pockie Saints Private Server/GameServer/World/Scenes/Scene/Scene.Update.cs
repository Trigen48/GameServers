using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public partial class Scene
    {

        public void Broadcast(Byte[] d)
        {

            ByteArray ot = new ByteArray();
            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            // d = null;
        }

        public void Broadcast(Byte[] d, int id)
        {
            ByteArray ot = new ByteArray();


            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                /* if (Players.GetPlayer(plz[x]) == null || rl.cc.currentScene.ID != ID || plz[x] == id) continue;

                 if (!Players.GetPlayer(plz[x]).Send(d)) Program.CloseConnection(Players.GetPlayer(plz[x]).cc);*/

                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID || plz[x] == id)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            // d = null;
        }


        public void UpdateChangeVip(ConnectionInfo c)
        {

            ByteArray ot = new ByteArray();

            ot.WriteInt(c.rlid);
            ot.WriteByte(c.Player.vip.vip_level);
            ot.PackArray(12083);
            byte[] d = ot.GetByteArray();

            ot.Close();
            ot = null;
            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count]; players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {

                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);

            }
            d = null;
        }

        public void UpdateLevelUp(ConnectionInfo c)
        {
            //Check For Latest Quest Updates
            c.Player.quest.CheckType1();

            ByteArray ot = new ByteArray();

            ot.WriteInt(c.rlid);
            ot.WriteInt(c.Player.combat.hp);
            ot.WriteInt(c.Player.combat.hp_lim);
            ot.PackArray(12009);

            ot.WriteShort(10);
            ot.WriteShort(12021);
            ot.WriteInt(c.rlid);
            ot.WriteShort(c.Player.role.level);

            byte[] d = ot.GetByteArray();

            ot.Close();
            ot = null;
            int[] plz = null;

            lock (players)
            {
                plz = new int[players.Count]; players.Keys.CopyTo(plz, 0);
            }

            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;

        }

        public void UpdatePet(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();


            ot.WriteInt(c.rlid);
            ot.WriteInt(c.Player.pet.PetType);
            ot.WriteString(c.Player.pet.PetName);
            ot.WriteShort(c.Player.pet.PetQual);
            ot.WriteShort(c.Player.pet.PetLev);
            ot.PackArray(41023);

            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;
        }

        public void UpdateGear(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();

            c.Player.combat.Compute();


            ot.WriteInt(c.rlid);
            ot.WriteInt(c.Player.combat.hp);
            ot.WriteInt(c.Player.combat.hp_lim);
            ot.WriteShort(2);

            ot.WriteInt(c.Player.role.weapon_id);
            ot.WriteShort(10);
            ot.WriteShort(0);
            ot.WriteShort(c.Player.combat.weapon_st);

            ot.WriteInt(c.Player.role.armor_id);
            ot.WriteShort(21);
            ot.WriteShort(0);
            ot.WriteShort(c.Player.combat.armor_st);


            ot.PackArray(12016);

            ot.WriteShort(9);
            ot.WriteShort(12086);
            ot.WriteInt(c.rlid);
            ot.WriteByte(c.Player.role.showType);




            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;
        }

        public void UpdateFaction(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();

            ot.WriteInt(c.rlid);
            ot.WriteByte(c.Player.role.faction);
            ot.PackArray(13019);

            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;
        }

        public void UpdateMeditate(ConnectionInfo c, byte id)
        {
            ByteArray ot = new ByteArray();

            ot.WriteShort(9);
            ot.WriteShort(33010);
            ot.WriteInt(c.rlid);
            ot.WriteByte(id);

            byte[] d = ot.GetByteArray();

            ot.Close();
            ot = null;
            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count]; players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;


        }

        public void UpdatePlayerWing(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();

            ot.WriteInt(c.rlid);
            ot.WriteInt(c.Player.combat.hp);
            ot.WriteInt(c.Player.combat.hp_lim);
            ot.PackArray(12009);

            ot.WriteShort(9);
            ot.WriteShort(12022);
            ot.WriteInt(c.rlid);
            ot.WriteByte(c.Player.medal.MedalTotal());

            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count]; players.Keys.CopyTo(plz, 0);
            }

            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;
        }

        public void UpdatePlayerPet(ConnectionInfo c)
        {
        }

        public void UpdatePlayerHp(ConnectionInfo c)
        {

            ByteArray ot = new ByteArray();


            ot.WriteInt(c.rlid);
            ot.WriteInt(c.Player.combat.hp);
            ot.WriteInt(c.Player.combat.hp_lim);
            ot.PackArray(12009);
            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;
        }

        public void UpdatePlayerPK(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();

            ot.WriteInt(c.rlid);
            ot.WriteShort(c.Player.role.pk_mode);
            ot.PackArray(13013);


            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;
        }

        public void UpdateMount(ConnectionInfo c)
        {
            ByteArray ar = new ByteArray();
            c.Player.combat.Compute();
            ar.WriteInt(c.rlid);
            ar.WriteShort(c.Player.combat.GetSpeed(c));
            ar.WriteInt(c.Player.mount.mount_id);
            ar.PackArray(12010);

            byte[] d = ar.GetByteArray();
            ar.Close();
            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count]; players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;
        }

        public void UpdateTitle(ConnectionInfo c)
        {
            ByteArray ar = new ByteArray();
            ar.WriteInt(c.rlid);
            ar.WriteShort(c.Player.role.title_id);
            ar.PackArray(12085);
            byte[] d = ar.GetByteArray();
            ar.Close();

            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                
                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;


        }

        public static void UpdateRevive(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();

            ot.WriteShort(c.Player.role.posx);
            ot.WriteShort(c.Player.role.posy);
            ot.WriteInt(c.rlid);
            ot.WriteInt(c.Player.combat.hp);
            ot.WriteInt(c.Player.combat.mp);
            ot.WriteInt(c.Player.combat.hp_lim);
            ot.WriteInt(c.Player.combat.mp_lim);
            ot.WriteByte(c.Player.role.level);
            ot.WriteByte(c.Player.role.career);
            ot.WriteString(c.Player.role.name);
            ot.WriteShort(c.Player.combat.GetSpeed(c));
            ot.WriteInt(c.Player.role.weapon_id);
            ot.WriteByte(c.Player.combat.weapon_st);
            ot.WriteInt(c.Player.role.armor_id);
            ot.WriteByte(c.Player.combat.armor_st);
            ot.WriteByte(c.Player.role.showType);
            ot.WriteInt(c.Player.mount.mount_id);
            ot.WriteInt(c.Player.combat.isFullSet);
            ot.WriteByte(c.Player.combat.allStrengthen);
            ot.WriteByte(c.Player.role.sex);
            ot.WriteByte(0);//s_isTeamLeader);
            ot.WriteByte(c.Player.role.faction);
            ot.WriteByte(c.Player.role.pk_mode);
            ot.WriteInt(c.Player.guild.GuildID);
            ot.WriteString(c.Player.guild.GuildName);
            ot.WriteByte(c.Player.role.faction);
            ot.WriteString(0);//w_team);
            ot.WriteShort(c.Player.role.sin);

            ot.WriteInt(c.Player.pet.PetType);

            ot.WriteString(c.Player.pet.PetName);//z02_petName);
            ot.WriteByte(c.Player.pet.PetQual);//z03_quality);
            ot.WriteByte(c.Player.pet.PetLev);//z04_petlev);

            ot.WriteByte(c.Player.medal.MedalTotal());//z05_medalStar);
            ot.WriteInt(c.Player.skill.GetDeform(c.Player.role.career));//z06_deform);
            ot.WriteByte(c.Player.role.star);
            ot.WriteByte(c.Player.vip.vip_level);//z08_vipLev);
            ot.WriteByte(c.Player.escort.escortState);//z09_escortState);
            ot.WriteByte(c.Player.escort.escortQuality);//z09_escortQuality);
            ot.WriteByte(c.Player.role.rest);
            ot.WriteShort(c.Player.role.title_id);
            ot.WriteString(c.Player.role.mate_name);//z13_mateName);
            ot.WriteByte(c.Player.role.mate_faction);
            ot.WriteByte(c.Player.combat.suit_level);//z15_dressStrengthen);
            ot.PackArray(12003);

            ot.WriteShort(14);
            ot.WriteShort(12010);
            ot.WriteInt(c.rlid);
            ot.WriteShort(c.Player.combat.GetSpeed(c));
            ot.WriteInt(c.Player.mount.mount_id);

            byte[] d = ot.GetByteArray();
            c.ot.WriteBytes(d);
            d = null;
        }

        public void UpdateClothStrength(ConnectionInfo c)
        {
          /*  ByteArray ot = new ByteArray();
            ot.WriteInt(c.rlid);//a_id);
            ot.WriteInt();//b_itemId);
            ot.WriteByte();//c_typeId);
            ot.WriteByte();//d_bind);
            ot.WriteByte();//e_strengthen);
            ot.WriteInt(c.Player.combat.su);//ea_suit);
            ot.WriteByte(c.Player.combat.allStrengthen);//eb_allStrengthen);
            ot.WriteInt(c.Player.combat.hp);//f_hp);
            ot.WriteInt(c.Player.combat.hp_lim);//g_hplim);*/


        }
    }
}
