using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace GameServer
{
    static class JsonLib
    {
        internal static void Blank(string file)
        {
            System.IO.File.WriteAllBytes(file, new byte[0]);
        }


        internal static string Save<t>(t inst)
        {
            int retry = 0;

        tt: ;
            try
            {
                string s=JsonConvert.SerializeObject(inst);
                return s;
            }
            catch (Exception ex)
            {
                if (retry > 3)
                {
                    //retry++;
                    log.Save(ex);

                
                    throw ex;
                }
                else
                {
                    Program.Write(ex.Message);
                    retry++;
                    System.Threading.Thread.Sleep(1000);
                    goto tt;
                }
            }
        }

        internal static void SaveFile<t>(string file, t inst)
        {

            try
            {
                System.IO.File.WriteAllText(file, Save( inst));
            }
            catch (Exception ex)
            {
                Program.Write(ex.Message);
            }

        }

        internal static t LoadFile<t>(string filename)
        {
            if (!System.IO.File.Exists(filename))
            {
                throw new Exception("Filename: "+filename+" does not exist");
            }

            try
            {
                return Load<t>(System.IO.File.ReadAllText(filename));
            }
            catch(Exception ex)
            {
                log.Save(ex);
                throw new Exception("Failed to load file: " + filename);
            }
        }

        internal static t Load<t>(string value)
        {
            try
            {
                return JsonConvert.DeserializeObject<t>(value);
            }
            catch (Exception ex)
            {
                log.Save(ex);
                throw ex;
            }
        }

    }
}
