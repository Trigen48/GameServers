using System;

using System.Collections;

namespace GameServer.Command
{

    internal static class ChangeCampController
    {

        internal static void c37000(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"ChangeCampController 37000");

            c.con.StartCommand("SELECT faction,SUM(combatpower) suma,COUNT(*) counta FROM combat,role where (faction>0 AND faction<4) AND combat.roleid=role.roleid GROUP BY faction order by suma desc,counta desc;");
            Connector.DataReader rd = c.con.ExecuteRead();



            if (rd.CanRead)
            {


                byte rnk = 1;


                int[][] factdata = new int[3][];

                for (byte i = 0; i < 3; i++)
                {
                    factdata[i] = new int[4];
                    factdata[i][0] = i+1;
                }

                while (rd.NextRow())
                {
                    byte faction = (rd.ReadByte());
                    int power = rd.ReadInt();
                    int count = rd.ReadInt();

                    if (faction > 0 && faction < 4)
                    {
                        factdata[faction - 1][0] = faction;
                        factdata[faction - 1][1] = power;
                        factdata[faction - 1][2] = rnk;
                        factdata[faction - 1][3] = count;
                    }
                    /* c.ot.WriteByte(rd.ReadByte());// camp
                     c.ot.WriteInt(rd.ReadInt());//total strength
                     c.ot.WriteByte(rnk);//rank
                     c.ot.WriteShort(rd.ReadInt());//count*/
                    rnk++;
                }

                c.ot.WriteShort(3);
                for (byte i = 0; i < 3; i++)
                {
                    c.ot.WriteByte(factdata[i][0]);// camp
                    c.ot.WriteInt(factdata[i][1]);//total strength
                    c.ot.WriteByte(factdata[i][2]);//rank
                    c.ot.WriteShort(factdata[i][3]); //count

                    /* c.ot.WriteByte(i);// camp
                     c.ot.WriteInt(Gameplay.PlayerNames.stats.Factions[i].TotalCombat);//total strength
                     c.ot.WriteByte(Gameplay.PlayerNames.stats.Factions[i].Rank);//rank
                     c.ot.WriteShort(Gameplay.PlayerNames.stats.Factions[i].players.Count); //count*/
                }


            }

            else
            {
                c.ot.WriteShort(0);
            }

            rd.Close();

            c.ot.PackArray(37000);
        }

        internal static void c37001(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"ChangeCampController 37001");


            byte nfact = c.ar.ReadByte();

            if (c.Player.role.level > 44)
            {
                
                if (c.Player.guild.GuildID == 0)
                {
                    if (nfact == c.Player.role.faction)
                    {
                        c.ot.WriteByte(7);

                    }
                    else
                    {
                        if (c.Player.bag.crystal < 400)
                        {
                            c.ot.WriteByte(5);
                            nfact = c.Player.role.faction;
                        }
                        else
                        {
                           // World.FactionData.Dereg(c.rlid, c.Player.charz.faction);
                            c.Player.role.faction = nfact;
                           // World.FactionData.RegFaction(c.rlid, c.Player.charz.faction);
                            /*lock (Gameplay.PlayerNames.stats)
                            {
                                Gameplay.PlayerNames.AddToFaction(c.rlid, nfact);
                                Gameplay.PlayerNames.Save();
                            }*/

                            c.Player.bag.crystal -= 400;
                            c.Player.bag.Save();
                            c.Player.role.Save();

                            //c.Player.mount.fact

                            c.currentScene.UpdateFaction(c);
                            c.ot.WriteByte(1);

                        }
                    }
                }
                else
                {
                    c.ot.WriteByte(3);
                }


            }
            else
            {
                c.ot.WriteByte(2);
            }

            c.ot.WriteInt(c.Player.bag.crystal);
            c.ot.WriteByte(nfact);

            c.ot.PackArray(37001);

        }

    }
}
