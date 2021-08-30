using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
namespace FarLib
{
    public class FarItem
    {
        public int offset, size;
        public bool compressed;

        public FarItem()
        {
        }

        public FarItem(int Offset, int Size, bool Compressed)
        {
            offset = Offset;
            size = Size;
            compressed = Compressed;
        }
    }

    public class FarItemAdvance : FarItem
    {
        public string FileName = "";

        public FarItemAdvance()
        {
        }

        public FarItemAdvance(string filename)
        {
            FileName = filename;
        }

        public FarItemAdvance(int Offset, int Size, bool Compressed)
        {
            offset = Offset;
            size = Size;
            compressed = Compressed;
        }

        public FarItem ToFar()
        {

            FarItem itm = new FarItem();

            itm.compressed = compressed;
            itm.offset = offset;
            itm.size = size;

            return itm;

        }

    }

    public class Far
    {
        ByteArraySmall rd;


        private int vMajor;
        private int vMinor;
        private int tableSize;
        public Dictionary<string, FarItem> dict;
        public bool isFree;
        public const int VMAJOR = 0;
        public const int VMINOR = 1;

        public Far()
        {
            dict = new Dictionary<string, FarItem>();
            isFree = true;
            rd = new ByteArraySmall();
        }

        public void Clear()
        {
            dict.Clear();

            if (rd != null)
                rd.Clear();
            isFree = true;
        }

        public void Load(string data)
        {
            rd = new ByteArraySmall(data);
            _Load();
        }

        public void Load(byte[] data)
        {
            rd = new ByteArraySmall(data);
            _Load();
        }

        private void _Load()
        {
            if (!ReadHeader())
            {
                rd.Close();
                throw new Exception("File is not FAR formatted");
            }

            ReadTable();
        }

        private bool ReadHeader()
        {

            if (rd.ReadByte() == 70 && rd.ReadByte() == 65 && rd.ReadByte() == 82)
            {
                vMajor = rd.ReadByte();
                vMinor = rd.ReadByte();

                if (this.vMajor > VMAJOR)
                {
                    rd.Close();
                    throw new Exception("Unsupported archive version (v." + this.vMajor.ToString() + "." + this.vMinor.ToString() + ")");
                }

                this.tableSize = rd.ReadInt();
                return true;
            }

            return false;
        }

        private void ReadTable()
        {

            try
            {
                int NameRead = rd.ReadInt();
                byte[] data;
                int size;
                int offset;
                bool compressed;

                string name = "";
                while (NameRead != 0)
                {
                    data = rd.ReadBytes(NameRead);
                    offset = rd.ReadInt();
                    size = rd.ReadInt();
                    compressed = rd.ReadByte() != 0;
                    name = Encoding.UTF8.GetString(data);

                    dict.Add(name, new FarItem(offset, size, compressed));

                    NameRead = rd.ReadInt();
                }

                data = null;
            }
            catch
            {
                throw new Exception("Invalid Far Table!");
            }



            //this.gotTable = true;
            return;
        }

        public int Count()
        {
            return dict.Count;
        }

        public void ExtractAll(string directory)
        {
            byte[] data;
            foreach (string key in dict.Keys)
            {
                data = GetData(key);

                string dir = key;
                if (!System.IO.Directory.Exists(directory))
                    System.IO.Directory.CreateDirectory(directory);
                if (dir.Contains("/"))
                {
                    string d = dir.Substring(0, dir.LastIndexOf('\\'));

                    if (!System.IO.Directory.Exists(directory + d))
                        System.IO.Directory.CreateDirectory(directory + d);
                }
                System.IO.File.WriteAllBytes(directory + dir, data);
            }
        }

        public void Extract(string file, string directory)
        {
            byte[] data = GetData(file);
            if (data != null)
            {

                string dir = file;
                if (!System.IO.Directory.Exists(directory))
                {
                    System.IO.Directory.CreateDirectory(directory);
                }


                if (dir.Contains("/"))
                {
                    dir = dir.Replace('/', '\\');

                    string d = dir.Substring(0, dir.LastIndexOf('\\'));

                    if (!System.IO.Directory.Exists(directory + d))
                    {
                        System.IO.Directory.CreateDirectory(directory + d);
                    }
                }

                System.IO.File.WriteAllBytes(directory + dir, data);
            }
        }


        public void CreateNew()
        {
            Clear();
        }

        public void Add(string filee)
        {

            string file = filee.Replace("\\", "/");
            if (!System.IO.File.Exists(file))
            {
                throw new Exception(file + " not found!");
            }

            string[] sp = file.Split("/".ToCharArray());
            string fileN = sp[sp.Length - 1];


            dict.Add(fileN, new FarItemAdvance(file));
        }

        public void AddDir(string Dir)
        {
            AddDir(Dir, "");
        }

        public void AddDir(string Dir, string BaseDir)
        {
            string Base = BaseDir;

            string d = Dir.Replace("\\", "/");
            if (!d.EndsWith("/"))
            {
                d += "/";

            }
            if (!Base.EndsWith("/") && Base != "")
            {
                Base += "/";
            }

            if (!System.IO.Directory.Exists(d))
            {
                throw new Exception(d + " not found");
            }


            string[] Splits;

            ///////////////// Files
            Splits = System.IO.Directory.GetFiles(Dir, "*.*");
            foreach (string file in Splits)
            {
                string f = Base + file.Remove(0, d.Length);
                dict.Add(f, new FarItemAdvance(file));
            }

            ///////////////////// Directories
            Splits = System.IO.Directory.GetDirectories(Dir);
            foreach (string dir in Splits)
            {
                string dd = dir.Remove(0, d.Length);
                AddDir(dir, Base + dd);
            }

        }

        public void Build(string filename)
        {
            Build(filename, false);
        }

        public void Build(string filename, bool load)
        {
            try
            {

                ByteArraySmall Table = new ByteArraySmall();
                ByteArraySmall RawData = new ByteArraySmall();

                rd.WriteBytes(new byte[] { 70, 65, 82, (byte)vMajor, (byte)vMinor });

                int offset = 0;

                string[] keys = new string[dict.Count];

                dict.Keys.CopyTo(keys, 0);


                foreach (string k in keys)
                {
                    string final;

                    final = ((FarItemAdvance)dict[k]).FileName;

                    FarItem itm = new FarItem();


                    itm.offset = offset;
                    itm.compressed = k.ToLower().EndsWith(".xml");


                    byte[] data = System.IO.File.ReadAllBytes(final);
                    if (itm.compressed)
                    {
                        System.IO.MemoryStream mem = new System.IO.MemoryStream();
                        ZLibNet.ZLibStream sm = new ZLibNet.ZLibStream(mem, ZLibNet.CompressionMode.Compress, ZLibNet.CompressionLevel.BestCompression);

                        sm.Write(data, 0, data.Length);
                        sm.Flush();
                        RawData.WriteBytes(mem.ToArray());
                        itm.size = (int)mem.Length;
                        sm.Close();
                        sm = null;
                        data = null;
                        mem.Close();
                    }
                    else
                    {
                        RawData.WriteBytes(data);
                        itm.size = data.Length;
                    }

                    data = null;
                    offset += itm.size;

                    dict[k] = itm;

                    byte[] names = Encoding.UTF8.GetBytes(k);
                    Table.WriteInt(names.Length);
                    Table.WriteBytes(names);
                    Table.WriteInt(dict[k].offset);
                    Table.WriteInt(dict[k].size);
                    Table.WriteByte(dict[k].compressed ? 1 : 0);
                }

                Table.WriteInt(0);
                rd.WriteInt(Table.Length());

                int tot = Table.Length() + rd.Length();
                Table.Clear();

                foreach (string k in keys)
                {
                    byte[] names = Encoding.UTF8.GetBytes(k);
                    Table.WriteInt(names.Length);
                    Table.WriteBytes(names);
                    Table.WriteInt(dict[k].offset + tot);
                    Table.WriteInt(dict[k].size);
                    Table.WriteByte(dict[k].compressed ? 1 : 0);
                }
                Table.WriteInt(0);

                rd.WriteBytes(Table.GetByteArraySmall());
                Table.Close();

                rd.WriteBytes(RawData.GetByteArraySmall());
                RawData.Close();

                rd.SaveFile(filename);
                rd.Close();
                rd = null;
                dict.Clear();

                // After clearing stuff reload new file
                if (load)
                    Load(filename);
            }
            catch
            {
                throw new Exception("Error Creating far archive!");
            }

        }

        public byte[] GetData(string file)
        {
            if (dict.ContainsKey(file))
            {
                rd.Seek(dict[file].offset);

                byte[] data = rd.ReadBytes(dict[file].size);

                #region Decompress
                if (dict[file].compressed)
                {
                    ZLibNet.ZLibStream df = new ZLibNet.ZLibStream(new System.IO.MemoryStream(data), ZLibNet.CompressionMode.Decompress);

                    //ZLibDll.
                    System.IO.MemoryStream st = new System.IO.MemoryStream();
                    long tot = df.TotalOut;

                    df.CopyTo(st);

                    st.Flush();

                    data = st.ToArray();
                    st.Close();
                    df.Close();
                }
                #endregion

                return data;
            }

            return null;
        }

        public byte[] this[string key]
        {
            get
            {
                return GetData(key);
            }

        }

        public int GetFileSize(string filename)
        {

            if (dict.ContainsKey(filename))
                return dict[filename].size;

            return -1;
        }

        public unsafe byte* ToBytePointer(byte[] data)
        {
            IntPtr p = Marshal.AllocHGlobal(data.Length);
            byte* s = (byte*)p;
            for (int x = 0; x < data.Length; x++)
            {
                s[x] = data[x];
            }
            return s;
        }


    }
}
