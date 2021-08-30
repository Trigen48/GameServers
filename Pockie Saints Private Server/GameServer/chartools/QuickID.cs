using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
namespace GameServer.chartools
{
    [ProtoContract]
    public class QuickID
    {
        [ProtoMember(1)]
        public List<int> Ids { get; set; }

        public QuickID()
        {
            Ids = new List<int>();
        }

        public void Save(string file)
        {
            ByteC.SaveProto(file, this);
        }

        public static void Loader(string file, ref QuickID val)
        {
            if (!System.IO.File.Exists(file))
            {
                ByteC.Blank(file);
            }
            else
            {
                ByteC.LoadProto(file, ref val);


                if (val.Ids.Count != 0)
                {
                    List<int> Adds = new List<int>();

                    foreach (int id in val.Ids)
                    {
                        if (System.IO.Directory.Exists(Game.PlayerDir + id.ToString()))
                        {
                            Adds.Add(id);
                        }
                    }

                    if (Adds.Count != val.Ids.Count)
                    {
                        val.Ids.Clear();

                        if (Adds.Count != 0) val.Ids.AddRange(Adds.ToArray());

                        val.Save(file);
                    }
                    Adds.Clear();

                    Adds = null;


                }



            }
        }
    }
}
