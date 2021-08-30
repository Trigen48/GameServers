/*using System;
using System.Text;
using System.IO;

namespace System
{
    /// <summary>
    /// A byte array stream. addepted from action script ByteCommand. ByteOrder= BigEndian
    /// </summary>
    /// 
    public class ByteArray
    {
        private MemoryStream m;
        private int index=0;
        

        public ByteArray()
        {
            m = new MemoryStream();
            
        }

        public ByteArray(bool v)
        {
            m = new MemoryStream();
            this.WriteInt(0); // Write length and command short 
            index = -1;
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
            m = new MemoryStream(System.IO.File.ReadAllBytes(File));
        }

        private void err(string msg)
        {
            throw new Exception(msg);

        }

        private byte[] IntToByte(int num)
        {
            byte[] bytes = new byte[4];

            bytes[3] = (byte)(num & 0x000000ff);
            bytes[2] = (byte)((num & 0x0000ff00) >> 8);
            bytes[1] = (byte)((num & 0x00ff0000) >> 16);
            bytes[0] = (byte)((num & 0xff000000) >> 24);
            return bytes;
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
            return Encoding.ASCII.GetString(tmp, 0, len);
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
            WriteBytes(System.IO.File.ReadAllBytes(Filename));
        }

        public void WriteShort(int num)
        {
            m.WriteByte((byte)((num & 0x0000ff00) >> 8));
            m.WriteByte((byte)(num & 0x000000ff));
        }

        public void WriteString(String text)
        {
            if (text == null)
            {
                WriteShort(0);
                return;
            }
            int len = text.Length;
            WriteShort(len);
            byte[] val = Encoding.ASCII.GetBytes(text);
            m.Write(val, 0, len);
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
            if (index == -1) index = 0;
            m.Position = index;
            int len = (int)m.Length - index;

            WriteShort(len);
            WriteShort(cmd);


            m.Position = m.Length;



        }

        public void NewCmd()
        {

            if (index == -1)
            {
                index = 0;
                return;
            }
  
            m.Seek(m.Length, 0);
           // m.Position = m.Length;

            index = (int)m.Length;
            WriteInt(0);

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



    }
}
*/