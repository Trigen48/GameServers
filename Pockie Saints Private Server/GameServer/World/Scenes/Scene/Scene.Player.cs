using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public partial class Scene
    {
        public Dictionary<int, byte> players;

        public void AddPlayer(ConnectionInfo c)
        {
            lock (players)
                if (players.ContainsKey(c.rlid)) return;

            ByteArray ot = new ByteArray();
            c.Player.combat.Compute();

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
            ot.Close();
            ot = null;

            int[] plz = null;

            lock (players)
            {
                players.Add(c.rlid, 0);
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }

            for (int x = 0; x < plz.Length; x++)
            {
               /* if (Players.GetPlayer(plz[x]) == null) continue;

                if (rl.cc.currentScene.ID == ID) if (!Players.GetPlayer(plz[x]).Send(d)) Program.CloseConnection(Players.GetPlayer(plz[x]).cc);
                */
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;
        }

        public void RemovePlayer(ConnectionInfo c)
        {
            lock (players)
                if (!players.ContainsKey(c.rlid)) return;


            // RunCheck();
            ByteArray ot = new ByteArray();

            ot.WriteInt(c.rlid);
            ot.PackArray(12004);

            byte[] d = ot.GetByteArray();


            ot.Close();
            ot = null;
            int[] plz = null;
            lock (players)
            {
                players.Remove(c.rlid);
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

        public void UpdatePosition(ConnectionInfo c, byte s)
        {


            ByteArray ot = new ByteArray();

            ot.WriteShort(c.Player.role.posx);
            ot.WriteShort(c.Player.role.posy);
            ot.WriteInt(c.rlid);
            ot.WriteByte(s);
            ot.PackArray(12001);
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

        public virtual pos ResolvePosition(int id)
        {

            pos c = new pos(rx, ry);
            for (int x = 0; x < Exitpoint.Count; x++)
            {
                if (Exitpoint[x].scene == id)
                {
                    c.x = Exitpoint[x].x;
                    c.y = Exitpoint[x].y;
                    return c;
                }

            }

            return c;
        }

    }
}
