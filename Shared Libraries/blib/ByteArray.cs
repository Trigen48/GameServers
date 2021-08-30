using System;
using System.Text;
using System.IO;

namespace System
{
    /// <summary>
    /// A byte array stream. addepted from action script ByteArray. ByteOrder= BigEndian
    /// </summary>
    public class ByteArray
    {
        private MemoryStream m;

        public ByteArray()
        {
            m = new MemoryStream();
            //  isread = false;
        }

        public ByteArray(byte[] data)
        {
            m = new MemoryStream(data);
        }
               
        public ByteArray(byte[] data,int lens)
        {
            m = new MemoryStream(data,0,lens);
        }

        public ByteArray(String File)
        {
            if (!System.IO.File.Exists(File))
                err("File does not exist: " + File);

            byte[] d = System.IO.File.ReadAllBytes(File);
            m = new MemoryStream(d);
        }

        //public ByteArray 

        private void err(string msg)
        {
            throw new Exception(msg);

        }

      /*  private ulong ByteToUlong()
        {
            ulong t = 0;
            t = ((ulong)m.ReadByte()) << 64;
            t |= ((ulong)m.ReadByte()) << 48;
            t |= ((ulong)m.ReadByte()) << 40;
            t |= ((ulong)m.ReadByte()) << 32;

            t |= ((ulong)m.ReadByte()) << 24;
            t |= ((ulong)m.ReadByte()) << 16;
            t |= ((ulong)m.ReadByte()) << 8;
            t |= ((byte)m.ReadByte());

            return t;
        }

        private long ByteToLong()
        {
            ulong t = ByteToUlong();


            if (t > long.MaxValue)
            {

            }
                

            return (long)t;
        }*/

        public byte Peek()
        {

            byte v=(byte)m.ReadByte();

            m.Seek(m.Position - 1, SeekOrigin.Begin);
            return v; 

        }

        private int ByteToInt()
        {
            uint t = 0;


            t = ((uint)m.ReadByte()) << 24;
            t |= ((uint)m.ReadByte()) << 16;
            t |= ((uint)m.ReadByte()) << 8;
            t |= ((uint)m.ReadByte());

            
            return (int)t;
        }
        private int ByteToShort()
        {
            uint t = 0;
            // t = ((uint)m.ReadByte()) << 24;
            // t |= ((uint)m.ReadByte()) << 16;
            t = ((uint)m.ReadByte()) << 8;
            t |= ((uint)m.ReadByte());
            return (int)t;
        }
        private string ByteToString()
        {
            int len = ReadShort();
            byte[] tmp = new byte[len];
            m.Read(tmp, 0, len);
            return Encoding.UTF8.GetString(tmp, 0, len);
        }
        private string ByteToString(int value)
        {
           // int len = ReadShort();
            byte[] tmp = new byte[value];
            m.Read(tmp, 0, value);
            return Encoding.UTF8.GetString(tmp, 0, value);
        }



        // ********************** Reading Stuff ************************
        public int ReadInt()
        {
            return ByteToInt();
        }

        public int ReadShort()
        {
            return ByteToShort();
        }

        public String ReadString()
        {
            return ByteToString();
        }

        public String ReadString(int Value)
        {
            return ByteToString(Value);
        }


        public byte[] ReadBytes(int len)
        {
            byte[] tmp = new byte[len];
            m.Read(tmp, 0, len);
            return tmp;
        }

        public byte ReadByte()
        {
            return (byte)m.ReadByte();
        }

        //***********************************************

        /// Secondary Object Write //
        public void WriteInt(object num)
        {
            WriteInt(Convert.ToInt32(num));
        }

        public void WriteShort(object num)
        {
            WriteShort(Convert.ToInt32(num));
        }

        public void WriteString(String text)
        {
            if (text == null)
            {
                WriteShort(0);
                return;
            }
            int len = text.Length;
            byte[] val = Encoding.UTF8.GetBytes(text);
            WriteShort(val.Length);

            m.Write(val, 0, val.Length);
        }


        public void WriteString(object text)
        {
            WriteString(text.ToString());
        }

        public void WriteBytes(object data)
        {
            WriteBytes((byte[])data);
        }

        public void WriteByte(object val)
        {
            m.WriteByte(Convert.ToByte( val));
        }

        /////////////////////////////////////////////

        //********************** Writing Stuff ***************************
        public void WriteInt(int num)
        {
            m.WriteByte((byte)((num & 0xff000000) >> 24));
            m.WriteByte((byte)((num & 0x00ff0000) >> 16));
            m.WriteByte((byte)((num & 0x0000ff00) >> 8));
            m.WriteByte((byte)(num & 0x000000ff));
        }

        public void WriteFile(String Filename)
        {
            if (!System.IO.File.Exists(Filename))
             err("File does not exist: " + Filename);

            WriteBytes(System.IO.File.ReadAllBytes(Filename));
        }

        public void WriteShort(int num)
        {
            m.WriteByte((byte)((num & 0x0000ff00) >> 8));
            m.WriteByte((byte)(num & 0x000000ff));
        }



        public void WriteBytes(byte[] data)
        {
            WriteBytes(data, data.Length);
        }


        public void Rest()
        {
            m.Position = 0;
        }

        public void WriteBytes(byte[] data,int lens)
        {
            m.Write(data, 0, lens);
        }

        public void WriteByte(byte val)
        {
            m.WriteByte(val);
        }

        //********************** *****************************************

        public byte[] GetByteArray()
        {
            return m.ToArray();
        }

        public void PackArray(int cmd)
        {
            byte[] c = GetByteArray();

            m.Close();
            m = new MemoryStream();

            //ByteArray a = new ByteArray();
            WriteShort(c.Length + 4);
            WriteShort(cmd);
            WriteBytes(c);
            m.Flush();

        }

        public int Length()
        {
            return (int)m.Length;
        }

        public int Position()
        {
            return (int)m.Position;
        }

        public bool Eof()
        {
            return (Length() <= Position());
        }

        public void Flush()
        {
            m.Flush();
        }

        public void Close()
        {
            m.Close();
            m = null;
        }

        public void Clear()
        {
            if(m!=null && !m.CanRead  && !m.CanWrite) m.Close();           
            m = new MemoryStream();
        }
        public void SaveFile(string file)
        {
            
            System.IO.File.WriteAllBytes(file, m.ToArray());
        }

        public void Seek(int offset)
        {
            m.Seek(offset, 0);
        }

    }
}
