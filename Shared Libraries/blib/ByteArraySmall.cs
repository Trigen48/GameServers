using System;
using System.Text;
using System.IO;

namespace System
{
    /// <summary>
    /// A byte array stream. addepted from action script ByteArray. ByteOrder= BigEndian
    /// </summary>
    public class ByteArraySmall
    {
        private MemoryStream m;

        public ByteArraySmall()
        {
            m = new MemoryStream();
            //  isread = false;
        }

        public ByteArraySmall(byte[] data)
        {
            m = new MemoryStream(data);
        }
               
        public ByteArraySmall(byte[] data,int lens)
        {
            m = new MemoryStream(data,0,lens);
        }

        public ByteArraySmall(String File)
        {
            if (!System.IO.File.Exists(File))
                err("File does not exist: " + File);
            m = new MemoryStream(System.IO.File.ReadAllBytes(File));
        }

        private void err(string msg)
        {
            throw new Exception(msg);
        }

        private int ByteToInt()
        {
            uint t = 0;

            t = ((uint)m.ReadByte());
            t |= ((uint)m.ReadByte()) << 8;
            t |= ((uint)m.ReadByte()) << 16;
            t |= ((uint)m.ReadByte()) << 24;
            return (int)t;
        }
        private int ByteToShort()
        {
            uint t = 0;
            t = ((uint)m.ReadByte());
            t |= ((uint)m.ReadByte()) << 8;

            return (int)t;
        }
        private string ByteToString()
        {
            int len = ReadShort();
            byte[] tmp = new byte[len];
            m.Read(tmp, 0, len);
            return Encoding.UTF8.GetString(tmp, 0, len);
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
            m.WriteByte((byte)(num & 0x000000ff));   
            m.WriteByte((byte)((num & 0x0000ff00) >> 8));   
            m.WriteByte((byte)((num & 0x00ff0000) >> 16));
            m.WriteByte((byte)((num & 0xff000000) >> 24));
        }

        public void WriteFile(String Filename)
        {
            if (!System.IO.File.Exists(Filename))
                err("File does not exist: " + Filename);// throw new Exception();
            WriteBytes(System.IO.File.ReadAllBytes(Filename));
        }

        public void WriteShort(int num)
        {
            m.WriteByte((byte)(num & 0x000000ff));
            m.WriteByte((byte)((num & 0x0000ff00) >> 8));
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

        public byte[] GetByteArraySmall()
        {
            return m.ToArray();
        }

        public void PackArray(int cmd)
        {
            byte[] c = GetByteArraySmall();

            m.Close();
            m = new MemoryStream();

            //ByteArray a = new ByteArraySmall();
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
            return (Length() == Position());
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
