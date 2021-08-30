using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowServer
{
    public static class CharData
    {
        public static int Nextid = 1;
        public static uint PetID=1;
        public static uint itemid=1;
        public static uint mountid=1;
        public static uint wingid=1;
       // public static 
        
        public static object Lock = new object();

        public static int GetNextChar()
        {
            lock (Lock)
            {
                Nextid++;
                Save();
                return Nextid - 1;
            }
        }

        public static uint GetNextItem()
        {
            lock (Lock)
            {
                itemid++;
                Save();
                return (uint)(itemid - 1);
            }
        }

        public static void Save()
        {
            lock (Lock)
            {
                ByteArray ar = new ByteArray();
                ar.WriteInt(Nextid);
                ar.WriteUInt(itemid);
               // ar.WriteUInt(PetID);
               // ar.WriteUInt(mountid);
                ar.SaveFile(Folders.IDBASE);
                ar.Close();
            }
        }

        public static void Load()
        {

            if (System.IO.File.Exists(Folders.IDBASE))
            {
                ByteArray ar = new ByteArray(Folders.IDBASE);

                Nextid = ar;
                itemid = ar;

                ar.Close();
            }
            else
            {
                Save();
            }

        }
    }
}
