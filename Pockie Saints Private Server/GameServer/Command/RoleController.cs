using System;

using System.Collections;

namespace GameServer.Command
{

    internal static class RoleController
    {
        internal static void SendRoles(ConnectionInfo c)
        {

            ByteArray ar = new ByteArray();
            //c.Player.combat.Compute();
            byte[] d = null;

            ar.WriteInt(c.rlid);
            ar.WriteShort(1);
            ar.WriteShort(c.Player.role.level);
            ar.WriteInt(c.Player.role.exp);
            ar.WriteInt(c.Player.role.exp_lim);
            ar.WriteShort(c.Player.combat.str);
            ar.WriteShort(c.Player.combat.agi);
            ar.WriteShort(c.Player.combat.intl);
            ar.WriteInt(c.Player.combat.hp);
            ar.WriteInt(c.Player.combat.hp_lim);
            ar.WriteInt(c.Player.combat.mp);
            ar.WriteInt(c.Player.combat.mp_lim);
            ar.WriteInt(c.Player.combat.atk);
            ar.WriteInt(c.Player.combat.def);
            ar.WriteInt(c.Player.combat.hit);
            ar.WriteInt(c.Player.combat.dod);
            ar.WriteInt(c.Player.combat.crit);
            ar.WriteInt(c.Player.combat.fort);


            ar.WriteShort(c.Player.combat.GetSpeed(c));
            ar.WriteInt(c.Player.role.charm);
            ar.PackArray(13011);

            if (c.Player.medal.medal_lev > 0)
            {
                ar.WriteShort(13);
                ar.WriteShort(18010);
                ar.WriteInt(c.Player.medal.starsoul);
                ar.WriteByte(0);
                ar.WriteInt(0);
            }

            d = ar.GetByteArray();
            ar.Close();
            c.Player.Send(d);

            //c.currentScene.update
            d = null;
        }

        internal static void SendRoleUpgrade(ConnectionInfo c, bool isupgrade)
        {
            ByteArray ar = new ByteArray();
            byte[] d = null;
            if (isupgrade)
            {
                c.Player.combat.Compute();
                c.Player.combat.MaxHpMp();

                c.Player.combat.hp = c.Player.combat.hp_lim;
                c.Player.combat.mp = c.Player.combat.mp_lim;

                ar.WriteInt(c.Player.combat.hp);      //  a_hp);
                ar.WriteInt(c.Player.combat.mp);      //  b_mp);
                ar.WriteShort(c.Player.role.level); //  c_lev);
                ar.WriteInt(c.Player.role.exp);     //  d_exp);
                ar.WriteInt(c.Player.role.exp_lim);         //  e_exp_lim);
                ar.PackArray(13003);

                d = ar.GetByteArray();

                ar.Close();
                ar = new ByteArray();
            }
            ar.WriteInt(c.rlid);
            ar.WriteShort(1);
            ar.WriteShort(c.Player.role.level);
            ar.WriteInt(c.Player.role.exp);
            ar.WriteInt(c.Player.role.exp_lim);
            ar.WriteShort(c.Player.combat.str);
            ar.WriteShort(c.Player.combat.agi);
            ar.WriteShort(c.Player.combat.intl);
            ar.WriteInt(c.Player.combat.hp);
            ar.WriteInt(c.Player.combat.hp_lim);
            ar.WriteInt(c.Player.combat.mp);
            ar.WriteInt(c.Player.combat.mp_lim);
            ar.WriteInt(c.Player.combat.atk);
            ar.WriteInt(c.Player.combat.def);
            ar.WriteInt(c.Player.combat.hit);
            ar.WriteInt(c.Player.combat.dod);
            ar.WriteInt(c.Player.combat.crit);
            ar.WriteInt(c.Player.combat.fort);
            ar.WriteShort(c.Player.combat.GetSpeed(c));
            ar.WriteInt(c.Player.role.charm);
            ar.PackArray(13011);

            if (isupgrade)
            {
                ar.WriteBytes(d);
            }

            if (c.Player.medal.medal_lev > 0)
            {
                ar.WriteShort(13);
                ar.WriteShort(18010);
                ar.WriteInt(c.Player.medal.starsoul);
                ar.WriteByte(0);
                ar.WriteInt(0);
            }

            ar.WriteShort(5);
            ar.WriteShort(13005);
            ar.WriteByte(2);
            d = null;
            c.Player.Send(ar.GetByteArray());

            ar.Close();
            if (isupgrade) c.currentScene.UpdateLevelUp(c.Player.cc);
            //Players.GetPlayer(id).cc.currentScene.UpdateLevelUp(Players.GetPlayer(id).cc);

        }

        internal static void c13001(ConnectionInfo c)
        {

            c.Player.combat.Compute();
            c.ot.WriteInt(c.rlid);
            c.ot.WriteByte(c.Player.role.sex);
            c.ot.WriteByte(c.Player.role.level);
            c.ot.WriteByte(c.Player.role.career);
            c.ot.WriteByte(c.Player.role.faction);
            c.ot.WriteByte(c.Player.role.star);
            c.ot.WriteString(c.Player.role.name);
            c.ot.WriteInt(c.Player.combat.hp);
            c.ot.WriteInt(c.Player.combat.hp_lim);
            c.ot.WriteInt(c.Player.combat.mp);
            c.ot.WriteInt(c.Player.combat.mp_lim);
            c.ot.WriteShort(c.Player.combat.str);
            c.ot.WriteShort(c.Player.combat.agi);
            c.ot.WriteShort(c.Player.combat.intl);
            c.ot.WriteInt(c.Player.combat.atk);
            c.ot.WriteInt(c.Player.combat.def);
            c.ot.WriteInt(c.Player.combat.hit);
            c.ot.WriteInt(c.Player.combat.dod);
            c.ot.WriteInt(c.Player.combat.crit);
            c.ot.WriteInt(c.Player.combat.fort);
            c.ot.WriteShort(c.Player.guild.GuildID);
            c.ot.WriteString(c.Player.guild.GuildName);
            c.ot.WriteByte(c.Player.role.faction);
            c.ot.WriteInt(c.Player.role.weapon_id);
            c.ot.WriteInt(c.Player.role.armor_id);
            c.ot.WriteInt(c.Player.mount.mount_id);
            c.ot.WriteInt(c.Player.role.state_prestige);
            c.ot.WriteInt(c.Player.role.Trial);
            c.ot.WriteByte(c.Player.role.z5a_nobility);
            c.ot.WriteShort(c.Player.role.sin);
            c.ot.WriteInt(c.Player.role.charm);

            c.ot.WriteByte(c.Player.medal.medal_lev);
            c.ot.WriteByte(c.Player.medal.MedalTotal());
            c.ot.WriteByte(c.Player.vip.vip_level);

            c.ot.WriteShort(c.Player.role.title_id);

            c.ot.WriteInt(c.Player.pet.CurrentPet);
            c.ot.WriteInt(c.Player.pet.PetType);


            c.ot.WriteInt(c.Player.mount.mounttype);
            c.ot.WriteByte(c.Player.role.showType);
            c.ot.WriteInt(c.Player.role.mate_id);
            c.ot.WriteString(c.Player.role.mate_name);
            c.ot.WriteByte(c.Player.role.mate_faction);

            c.ot.WriteInt(c.Player.role.map_id);
            c.ot.WriteShort(c.Player.role.posx);
            c.ot.WriteShort(c.Player.role.posy);

            c.ot.WriteInt(c.Player.role.exp);
            c.ot.WriteInt(c.Player.role.exp_lim);
            c.ot.WriteByte(c.Player.role.zc_ranger);
            c.ot.WriteShort(c.Player.combat.GetSpeed(c));
            c.ot.WriteShort(c.Player.role.atk_speed);
            c.ot.WriteShort(c.Player.role.pk_mode);
            c.ot.WriteInt(c.Player.role.pk_time);

            c.ot.PackArray(13001);

            c.Player.active.lasttime = (int)DateUtil.GetDateIntZone();
            c.Player.active.Save();
            c.Player.reward.targettime = (int)DateUtil.GetDateIntZone() + c.Player.reward.remain;

            ServerTimerController.TimerEvent(c);
            c.Player.buff.IsActive = true; // Activate Buffer Checkup;
        }

        internal static void c13002(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 13002");


        }

        internal static void c13003(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 13003");


        }

        internal static void c13011(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RoleController 13011");


            c.Player.combat.Compute();
            c.ot.WriteInt(c.rlid);
            c.ot.WriteShort(1);
            c.ot.WriteShort(c.Player.role.level);
            c.ot.WriteInt(c.Player.role.exp);
            c.ot.WriteInt(c.Player.role.exp_lim);
            c.ot.WriteShort(c.Player.combat.str);
            c.ot.WriteShort(c.Player.combat.agi);
            c.ot.WriteShort(c.Player.combat.intl);
            c.ot.WriteInt(c.Player.combat.hp);
            c.ot.WriteInt(c.Player.combat.hp_lim);
            c.ot.WriteInt(c.Player.combat.mp);
            c.ot.WriteInt(c.Player.combat.mp_lim);
            c.ot.WriteInt(c.Player.combat.atk);
            c.ot.WriteInt(c.Player.combat.def);
            c.ot.WriteInt(c.Player.combat.hit);
            c.ot.WriteInt(c.Player.combat.dod);
            c.ot.WriteInt(c.Player.combat.crit);
            c.ot.WriteInt(c.Player.combat.fort);


            c.ot.WriteShort(c.Player.combat.GetSpeed(c));
            c.ot.WriteInt(c.Player.role.charm);
            c.ot.PackArray(13011);

        }

        internal static void c13012(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RoleController 13012");

            byte pk = c.ar.ReadByte();
            byte res = 2;

            if (c.Player.role.level > 24)
            {
                switch (pk)
                {
                    case 1:
                        if (c.Player.role.pk_time <= DateUtil.GetDateInt())
                        {
                            c.Player.role.pk_time = 0;
                            res = 1;


                        }
                        else
                        {
                            res = 12;
                        }
                        break;

                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:

                        if (c.Player.role.pk_mode == 1)
                            c.Player.role.pk_time = Game.PKModeTime + (int)DateUtil.GetDateInt();

                        res = 1;
                        break;
                }
            }


            if (res == 1)
            {
                c.Player.role.pk_mode = pk;
                c.Player.role.Save();
            }


            c.ot.WriteByte(res);
            c.ot.WriteInt(c.Player.role.pk_time);

            c.ot.PackArray(13012);
            if (res == 1) c.currentScene.UpdatePlayerPK(c);
        }

        internal static void c13015(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 13015");


        }

        internal static void c13020(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 13020");


        }

        internal static void c13021(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 13021");


        }

        internal static void c13022(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RoleController 13022");

            byte hp, mp;
            hp = c.ar.ReadByte();
            mp = c.ar.ReadByte();
            c.ar.Close();
            bool updateAuto = false;

            if ((c.Player.auto.hp != hp || c.Player.auto.mp != mp) && c.Player.auto.init)
            {


                if (hp != 0 && c.Player.auto.hp != hp && mp == 0)
                {
                    c.Player.auto.hp = hp;
                }
                else if (mp != 0 && c.Player.auto.mp != mp && hp == 0)
                {
                    c.Player.auto.mp = mp;
                }
                else
                {
                    c.Player.auto.hp = hp;
                    c.Player.auto.mp = mp;

                }
                c.Player.auto.Save();
                updateAuto = true;
            }


            c.ot.WriteByte(c.Player.auto.hp);
            c.ot.WriteByte(c.Player.auto.mp);
            c.ot.PackArray(13022);

            if (updateAuto)
            {
                string outs = c.Player.auto.Output();

                c.ot.WriteShort(8 + outs.Length);
                c.ot.WriteShort(13017);
                c.ot.WriteShort(1);
                c.ot.WriteString(outs);
                outs = "";
            }
        }

        internal static void c13023(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 13023");


        }

        internal static void c13024(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 13024");


        }

        internal static void c13025(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 13025");


        }

        internal static void c13027(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 13027");


        }

        internal static void GetCharPoints(ConnectionInfo c)
        {

            c.ot.WriteInt(c.Player.role.bhonor);
            c.ot.WriteInt(c.Player.role.dreamre);
            c.ot.WriteInt(c.Player.role.guildhonor);
            c.ot.WriteInt(c.Player.role.chonor);
            c.ot.PackArray(13028);

        }

        internal static void c15079(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RoleController 15079");


        }

        internal static void GetWorldLevel(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RoleController 50023");


            c.ot.WriteByte(World.World.WorldLevel);
            c.ot.PackArray(50023);
        }

    }
}
