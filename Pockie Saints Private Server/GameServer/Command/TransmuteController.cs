using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class TransmuteController
	{
        internal static void c27029(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "TransmuteController 27029");

            int itemType = c.ar.ReadInt();
            byte ItemNum = c.ar.ReadByte();
            byte UseBind = c.ar.ReadByte();
            byte Catagory = c.ar.ReadByte();

            byte res = 2;


            if (SynthHelper.Synth[Catagory].ContainsKey(itemType))
            {
                res = 0;
                byte bind = 1;
                if (UseBind == 1)
                {
                    #region SynthAny

                    for (byte x = 0; x < SynthHelper.Synth[Catagory][itemType].Items.Length; x++)
                    {
                        if (SynthHelper.Synth[Catagory][itemType].Items[x].num * ItemNum > c.Player.bag.GetTypeCount(SynthHelper.Synth[Catagory][itemType].Items[x].ID))
                        {
                            res = 2;
                            break;
                        }

                    }

                    if (res != 2)
                    {

                        if (c.Player.bag.CanBagAdd(c.Player.bag.GetSplitCount(SynthHelper.Synth[Catagory][itemType].id, ItemNum)))
                        {

                            if (c.Player.bag.TotalGold() >= SynthHelper.Synth[Catagory][itemType].cost * ItemNum)
                            {

                                c.Player.bag.UseAllGold(SynthHelper.Synth[Catagory][itemType].cost * ItemNum);

                                c.ot.WriteByte(0);
                                c.ot.WriteInt(c.Player.bag.gold);
                                c.ot.WriteInt(c.Player.bag.bgold);
                                c.ot.WriteInt(0);

                                for (byte x = 0; x < SynthHelper.Synth[Catagory][itemType].Items.Length; x++)
                                {
                                    int count = (SynthHelper.Synth[Catagory][itemType].Items[x].num * ItemNum);
                                    int id = SynthHelper.Synth[Catagory][itemType].Items[x].ID;
                                    byte q = c.Player.bag.UseTypeBind(id, count);
                                    if (q == 2 && bind == 1) bind = 2;
                                }

                                c.Player.bag.AddBagItem(itemType, ItemNum, bind);
                                c.Player.bag.Save();

                            }
                            else
                            {
                                c.ot.WriteByte(1);
                                c.ot.WriteInt(c.Player.bag.gold);
                                c.ot.WriteInt(c.Player.bag.bgold);
                                c.ot.WriteInt(0);
                            }

                        }
                        else
                        {
                            c.ot.WriteByte(3);
                            c.ot.WriteInt(c.Player.bag.gold);
                            c.ot.WriteInt(c.Player.bag.bgold);
                            c.ot.WriteInt(0);
                        }

                    }
                    else
                    {
                        c.ot.WriteByte(2);
                        c.ot.WriteInt(c.Player.bag.gold);
                        c.ot.WriteInt(c.Player.bag.bgold);
                        c.ot.WriteInt(0);
                    }
                    #endregion
                }
                else
                {
                    #region use unbound
                    for (byte x = 0; x < SynthHelper.Synth[Catagory][itemType].Items.Length; x++)
                    {
                        if (SynthHelper.Synth[Catagory][itemType].Items[x].num * ItemNum > c.Player.bag.GetTypeCount(SynthHelper.Synth[Catagory][itemType].Items[x].ID, 1, 4))
                        {
                            res = 2;
                            break;
                        }

                    }

                    if (res != 2)
                    {

                        if (c.Player.bag.CanBagAdd(c.Player.bag.GetSplitCount(SynthHelper.Synth[Catagory][itemType].id, ItemNum)))
                        {

                            if (c.Player.bag.TotalGold() >= SynthHelper.Synth[Catagory][itemType].cost * ItemNum)
                            {

                                c.Player.bag.UseAllGold(SynthHelper.Synth[Catagory][itemType].cost * ItemNum);

                                c.ot.WriteByte(0);
                                c.ot.WriteInt(c.Player.bag.gold);
                                c.ot.WriteInt(c.Player.bag.bgold);
                                c.ot.WriteInt(0);
         
                                for (byte x = 0; x < SynthHelper.Synth[Catagory][itemType].Items.Length; x++)
                                {
                                    int count = (byte)(SynthHelper.Synth[Catagory][itemType].Items[x].num * ItemNum);
                                    int id = SynthHelper.Synth[Catagory][itemType].Items[x].ID;
                                    byte q = c.Player.bag.UseTypeBind(id, count, 1);
                                    if (q == 2 && bind == 1) bind = 2;
                                }

                                c.Player.bag.AddBagItem(itemType, ItemNum, bind);
                                c.Player.bag.Save();

                            }
                            else
                            {
                                c.ot.WriteByte(1);
                                c.ot.WriteInt(c.Player.bag.gold);
                                c.ot.WriteInt(c.Player.bag.bgold);
                                c.ot.WriteInt(0);
                            }

                        }
                        else
                        {
                            c.ot.WriteByte(3);
                            c.ot.WriteInt(c.Player.bag.gold);
                            c.ot.WriteInt(c.Player.bag.bgold);
                            c.ot.WriteInt(0);
                        }

                    }
                    else
                    {
                        c.ot.WriteByte(2);
                        c.ot.WriteInt(c.Player.bag.gold);
                        c.ot.WriteInt(c.Player.bag.bgold);
                        c.ot.WriteInt(0);
                    }
               
                    #endregion
                }

            }
            else
            {
                c.ot.WriteByte(2);
                c.ot.WriteInt(c.Player.bag.gold);
                c.ot.WriteInt(c.Player.bag.bgold);
                c.ot.WriteInt(0);
            }

            c.ot.PackArray(27029);
        }

	}
}
