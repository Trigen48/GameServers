using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class PhaseController
	{

		internal static void c13004(ConnectionInfo c)
		{

            int id = c.ar.ReadInt();
            RoleControl rl = Players.GetPlayer(id);
            if (rl == null)
            {
               /* c.ot.WriteBytes(new byte[100]);
                c.ot.PackArray(13004);*/
                return;
            }

           c.ot.WriteInt(id);
           c.ot.WriteByte(rl.role.sex);
           c.ot.WriteByte(rl.role.level);
           c.ot.WriteByte(rl.role.career);
           c.ot.WriteByte(rl.role.faction);

           c.ot.WriteByte(rl.role.star);
           c.ot.WriteString(rl.role.name);
           c.ot.WriteInt(rl.combat.hp);
           c.ot.WriteInt(rl.combat.hp_lim);
           c.ot.WriteInt(rl.combat.mp);
           c.ot.WriteInt(rl.combat.mp_lim);
           c.ot.WriteShort(rl.combat.str);
           c.ot.WriteShort(rl.combat.agi);
           c.ot.WriteShort(rl.combat.intl);
           c.ot.WriteInt(rl.combat.atk);
           c.ot.WriteInt(rl.combat.def);
           c.ot.WriteInt(rl.combat.hit);
           c.ot.WriteInt(rl.combat.dod);
           c.ot.WriteInt(rl.combat.crit);
           c.ot.WriteInt(rl.combat.fort);
           c.ot.WriteShort(rl.guild.GuildID);
           c.ot.WriteString(rl.guild.GuildName);
           c.ot.WriteByte(rl.role.faction);
           c.ot.WriteInt(rl.role.weapon_id);
           c.ot.WriteInt(rl.role.armor_id);
           c.ot.WriteInt(rl.mount.mount_id);

           c.ot.WriteInt(0);//rl.charz.nprestige);
           c.ot.WriteInt(rl.role.state_prestige);
           c.ot.WriteByte(rl.role.z5a_nobility);
           c.ot.WriteShort(rl.role.sin);
           c.ot.WriteInt(rl.role.charm);

           c.ot.WriteByte(rl.medal.medal_lev);
           c.ot.WriteByte(rl.medal.MedalTotal());
           c.ot.WriteByte(rl.vip.vip_level);
           c.ot.WriteShort(rl.role.title_id);

           c.ot.WriteInt(c.Player.pet.CurrentPet);
           c.ot.WriteInt(c.Player.pet.PetType);

           c.ot.WriteInt(rl.mount.mounttype);
           c.ot.WriteByte(rl.role.showType);
           c.ot.WriteInt(rl.role.mate_id);
           c.ot.WriteString(rl.role.mate_name);
           c.ot.WriteByte(rl.role.mate_faction);

           c.ot.PackArray(13004);
            
		}

		internal static void c15011(ConnectionInfo c)
		{

            int id = c.ar.ReadInt();
            byte idx = 0;

            RoleControl rl=Players.GetPlayer(id);

            if (rl == null)
            {
                c.ot.WriteShort(2);
                c.ot.WriteInt(id);
                c.ot.WriteShort(0);
                c.ot.PackArray(15011);
                return;
            }

            c.ot.WriteShort(1);
            c.ot.WriteInt(id);
            c.ot.WriteShort(rl.bag.bags[idx].items.Count);

            for (byte i = 0; i < rl.bag.bags[idx].items.Count; i++)
            {
                c.ot.WriteInt(rl.bag.bags[idx].items[i].itemid);
                c.ot.WriteInt(rl.bag.bags[idx].items[i].type);
                c.ot.WriteShort(rl.bag.bags[idx].items[i].slot);
                c.ot.WriteShort(rl.bag.bags[idx].items[i].count);
                c.ot.WriteShort(rl.bag.bags[idx].items[i].bind);
                c.ot.WriteShort(rl.bag.bags[idx].items[i].str);
                c.ot.WriteInt(rl.bag.bags[idx].items[i].overtime);
            }

            c.ot.PackArray(15011);


		}

	}
}
