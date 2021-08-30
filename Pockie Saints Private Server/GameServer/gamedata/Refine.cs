using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
   public static class Refine
    {

       public struct RefineItem
       {
           public int RefineOut, RefineIn,Material1,Material2,Cost;
           public byte level, num1, num2;

          /* public RefineItem()
           {
           }*/

           public RefineItem(ByteArray ar)
           {

               RefineOut = ar.ReadInt();
               level = ar.ReadByte();

               RefineIn = ar.ReadInt();
               Material1=ar.ReadInt();
               Material2=ar.ReadInt();

               num1 = ar.ReadByte();
               num2 = ar.ReadByte();

               Cost=ar.ReadInt();
           }
       }
       public static Dictionary<int, RefineItem>[] Refines;

       public static void init()
       {
           Refines = JsonLib.LoadFile<Dictionary<int, RefineItem>[]>("system/refine.json");
       }

       public static byte RefineGear(ConnectionInfo c)
       {
           byte keepstr = c.ar.ReadByte();
           int RefineOut =c.ar.ReadInt();


           if (!Refines[c.Player.role.career - 1].ContainsKey(RefineOut)) return 2;

           RefineItem rf = Refines[c.Player.role.career - 1][RefineOut];
           Dictionary<int, byte> materials = new Dictionary<int, byte>();
           List<KeyValuePair<int, byte>> uses = new List<KeyValuePair<int, byte>>();
           int count= c.ar.ReadShort();
           byte bind = 1;
           Bag.Item weap = new Bag.Item();
           for (int x = 0; x < count; x++)
           {

              // int ix = 0;
               int id;
               byte num;

               id = c.ar.ReadInt();
               num = (byte)c.ar.ReadShort();

               Bag.Item itm = c.Player.bag.GetItem(c.Player.bag.GetByID(id));

               if (itm.type == 0 || num > itm.count) return 2;

               if (materials.ContainsKey(itm.type))
               {
                   materials[itm.type] += num;
               }
               else
               {
                   materials.Add(itm.type, num);
               }
               uses.Add(new KeyValuePair<int,byte>(id,num));

               if (itm.type == rf.RefineIn) weap = itm;

               if (itm.bind == 2) bind = 2;
           }

           if (rf.Material1 != 0)
           {
               if (!materials.ContainsKey(rf.Material1) || materials[rf.Material1] != rf.num1) return 2;
               materials.Remove(rf.Material1);
           }

           if (rf.Material2 != 0)
           {
               if (!materials.ContainsKey(rf.Material2) || materials[rf.Material1] != rf.num2) return 2;
               materials.Remove(rf.Material2);
           }

           if (!materials.ContainsKey(rf.RefineIn) || materials[rf.RefineIn] != 1) return 2;

           materials.Remove(rf.RefineIn);

           if (keepstr != 0)
           {
               int scroll = 1217001;
               int scrolls=Transfer.GetScrollCount(weap.str, weap.Color);
               if (!materials.ContainsKey(scroll) || materials[scroll] != scrolls) return 2;
               materials.Remove(scroll);
           }
           else
           {
               weap.str = 0;
           }

           if (c.Player.bag.TotalGold() < rf.Cost) return 1;

           if (!c.Player.bag.CanBagAdd(1)) return 3;

           if (materials.Count != 0) return 2;

           c.Player.bag.UseGold(rf.Cost);
           for (int x = 0; x < uses.Count; x++)
           {
               c.Player.bag.UseItem(uses[x].Key, uses[x].Value);
           }

           materials.Clear();
           uses.Clear();

           uses = null;
           materials = null;


           c.Player.bag.AddItemNew(rf.RefineOut, 1, bind, weap.str);
           //c.Player.Save();
           c.Player.bag.Save();
           return 0;
       }
    }
}
