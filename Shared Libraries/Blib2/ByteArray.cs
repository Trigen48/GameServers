using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace System
{

    public class ByteArray
    {
        private byte b1, b2, b3, b4, b5, b6, b7, b8;
        private bool isLittleEndian = true;
        private MemoryStream m=null;
        public static bool Defualt_Little_Indian = true;
        ZLibNet.ZLibStream sm=null;
        public int length
        {
            get
            {
                return (int)m.Length;
            }
        }

        public int bytesAvailable
        {
            get
            {
                return (int)(m.Length - m.Position);
            }
        }

        public int position
        {
            get
            {
                return (int)m.Position;
            }
            set
            {
                m.Position = value;
            }
        }

        public bool IS_LITTLE_ENDIAN
        {
            get
            {
                return isLittleEndian;
            }
            set
            {
                isLittleEndian = value;
                InitEndian();
            }
        }

        public ByteArray()
        {
            m = new MemoryStream();
            isLittleEndian = Defualt_Little_Indian; InitEndian();
        }


        public ByteArray(byte[] data)
        {
            m = new MemoryStream(data);
            isLittleEndian = Defualt_Little_Indian; InitEndian();
        }

        public ByteArray(byte[] data,int index)
        {
            m = new MemoryStream(data,index,data.Length-index);
            isLittleEndian = Defualt_Little_Indian;InitEndian();
        }

        public ByteArray(byte[] data, int index,int len)
        {
            m = new MemoryStream(data, index, len);
            isLittleEndian = Defualt_Little_Indian; InitEndian();
        }

        
        public ByteArray(string file)
        {
            m = new MemoryStream(System.IO.File.ReadAllBytes(file));
            isLittleEndian = Defualt_Little_Indian; InitEndian();
        }

        private void InitEndian()
        {
            if (isLittleEndian)
            {
                b1 = 0;
                b2 = 1;
                b3 = 2;
                b4 = 3;
                b5 = 4;
                b6 = 5;
                b7 = 6;
                b8 = 7;
            }
            else
            {
                b8 = 0;
                b7 = 1;
                b6 = 2;
                b5 = 3;
                b4 = 4;
                b3 = 5;
                b2 = 6;
                b1 = 7;
            }
        }

        public byte ReadByte()
        {
            return (byte)m.ReadByte();
        }

        public sbyte ReadSByte()
        {
            return (sbyte)m.ReadByte();
        }

        public unsafe short ReadShort()
        {
            short value = 0;
            byte* data = (byte*)&value;

            data[b1] = ReadByte();
            data[b2] = ReadByte();

            value = *(short*)data;
            return value;
        }

        public unsafe ushort ReadUShort()
        {
            ushort value = 0;
            byte* data = (byte*)&value;

            data[b1] = ReadByte();
            data[b2] = ReadByte();

            value = *(ushort*)data;
            return value;
        }

        public unsafe double ReadDouble()
        {
            double value = 0;
            byte* data = (byte*)&value;
            data[b1] = ReadByte();
            data[b2] = ReadByte();
            data[b3] = ReadByte();
            data[b4] = ReadByte();
            data[b5] = ReadByte();
            data[b6] = ReadByte();
            data[b7] = ReadByte();
            data[b8] = ReadByte();

            value = *(double*)data;
            return value;
        }

        public unsafe int ReadInt()
        {
            int value = 0;
            byte* data = (byte*)&value;

            data[b1] = ReadByte();
            data[b2] = ReadByte();
            data[b3] = ReadByte();
            data[b4] = ReadByte();

            value = *(int*)data;
            return value;
        }

        public unsafe uint ReadUInt()
        {
            uint value = 0;
            byte* data = (byte*)&value;
            data[b1] = ReadByte();
            data[b2] = ReadByte();
            data[b3] = ReadByte();
            data[b4] = ReadByte();
            value = *(uint*)data;
            return value;
        }

        public unsafe float ReadFloat()
        {
            float value = 0;
            byte* data = (byte*)&value;

            data[b1] = ReadByte();
            data[b2] = ReadByte();
            data[b3] = ReadByte();
            data[b4] = ReadByte();

            value = *(float*)data;
            return value;
        }

        public unsafe long ReadLong()
        {
            long value = 0;
            byte* data = (byte*)&value;
            data[b1] = ReadByte();
            data[b2] = ReadByte();
            data[b3] = ReadByte();
            data[b4] = ReadByte();
            data[b5] = ReadByte();
            data[b6] = ReadByte();
            data[b7] = ReadByte();
            data[b8] = ReadByte();

            value = *(long*)data;
            return value;
        }

        public unsafe ulong ReadULong()
        {
            ulong value = 0;
            byte* data = (byte*)&value;

            data[b1] = ReadByte();
            data[b2] = ReadByte();
            data[b3] = ReadByte();
            data[b4] = ReadByte();
            data[b5] = ReadByte();
            data[b6] = ReadByte();
            data[b7] = ReadByte();
            data[b8] = ReadByte();

            value = *(ulong*)data;
            return value;
        }

        public byte[] ReadBytes(int len)
        {
            byte[] data = new byte[len];
            m.Read(data, 0, len);
            return data;
        }

        public byte[] ReadBytes(int index,int length)
        {
            byte[] data = new byte[length];
            m.Read(data, index, length);
            return data;
        }

        public string ReadString()
        {
            ushort len = ReadUShort();
            return Encoding.UTF8.GetString(ReadBytes(len));
        }

        public void WriteByte(byte value)
        {
            m.WriteByte(value);
        }

        public unsafe void WriteShort(short value)
        {

            byte* val;
            val = (byte*)&value;
            m.WriteByte((byte)val[b1]);
            m.WriteByte((byte)val[b2]);
        }

        public unsafe void WriteUShort(ushort value)
        {

            byte* val;
            val = (byte*)&value;
            m.WriteByte((byte)val[b1]);
            m.WriteByte((byte)val[b2]);
        }

        public unsafe void WriteInt(int value)
        {
            byte* val;
            val = (byte*)&value;
            m.WriteByte(val[b1]);
            m.WriteByte(val[b2]);
            m.WriteByte(val[b3]);
            m.WriteByte(val[b4]);
        }

        public unsafe void WriteUInt(uint value)
        {
            byte* val;
            val = (byte*)&value;
            m.WriteByte(val[b1]);
            m.WriteByte(val[b2]);
            m.WriteByte(val[b3]);
            m.WriteByte(val[b4]);
        }

        public unsafe void WriteFloat(float value)
        {
            byte* val;
            val = (byte*)&value;
            m.WriteByte(val[b1]);
            m.WriteByte(val[b2]);
            m.WriteByte(val[b3]);
            m.WriteByte(val[b4]);
        }

        public unsafe void WriteLong(long value)
        {
            byte* val;
            val = (byte*)&value;

            m.WriteByte(val[b1]);
            m.WriteByte(val[b2]);
            m.WriteByte(val[b3]);
            m.WriteByte(val[b4]);
            m.WriteByte(val[b5]);
            m.WriteByte(val[b6]);
            m.WriteByte(val[b7]);
            m.WriteByte(val[b8]);
        }

        public unsafe void WriteULong(ulong value)
        {
            byte* val;
            val = (byte*)&value;

            m.WriteByte(val[b1]);
            m.WriteByte(val[b2]);
            m.WriteByte(val[b3]);
            m.WriteByte(val[b4]);
            m.WriteByte(val[b5]);
            m.WriteByte(val[b6]);
            m.WriteByte(val[b7]);
            m.WriteByte(val[b8]);
        }

        public unsafe void WriteDouble(double value)
        {
            byte* val;
            val = (byte*)&value;

            m.WriteByte(val[b1]);
            m.WriteByte(val[b2]);
            m.WriteByte(val[b3]);
            m.WriteByte(val[b4]);
            m.WriteByte(val[b5]);
            m.WriteByte(val[b6]);
            m.WriteByte(val[b7]);
            m.WriteByte(val[b8]);
        }

        public void WriteBytes(byte[] value)
        {
            WriteBytes(value, 0, value.Length);
        }

        public void WriteBytes(byte[] value, int index)
        {
            WriteBytes(value, index, value.Length-index);
        }

        public void WriteBytes(byte[] value, int index, int length)
        {
            m.Write(value, index, length);
        }

        public void WriteString(string value)
        {
            byte[] data = Encoding.UTF8.GetBytes(value);
            WriteUShort((ushort)data.Length);
            WriteBytes(data);
        }

        public void WriteByte(object value)
        {
            WriteByte(Convert.ToByte(value));
        }

        public unsafe void WriteShort(object value)
        {
            WriteShort(Convert.ToInt16(value));
        }

        public unsafe void WriteUShort(object value)
        {
            WriteUShort(Convert.ToUInt16(value));
        }

        public unsafe void WriteInt(object value)
        {
            WriteInt(Convert.ToInt32(value));
        }

        public unsafe void WriteUInt(object value)
        {
            WriteUInt(Convert.ToUInt32(value));
        }

        public unsafe void WriteFloat(object value)
        {
            WriteFloat(Convert.ToSingle(value));
        }

        public unsafe void WriteLong(object value)
        {
            WriteLong(Convert.ToInt64(value));
        }

        public unsafe void WriteULong(object value)
        {
            WriteULong(Convert.ToUInt64(value));
        }

        public unsafe void WriteDouble(object value)
        {
            WriteDouble(Convert.ToDouble(value));
        }

        public void WriteBytes(object value)
        {
            WriteBytes((byte[])value);
        }

        public void WriteBytes(object value, int index)
        {
            WriteBytes((byte[])value,index);
        }

        public void WriteBytes(object value, int index, int length)
        {
            WriteBytes((byte[])value, index, length);
        }

        public void WriteString(object value)
        {
            WriteString((string)value);
        }

        public unsafe void WriteFile(string file)
        {
            WriteBytes(System.IO.File.ReadAllBytes(file));
        }

        public byte[] GetArray()
        {
            return m.ToArray();
        }
        
        public static implicit operator ByteArray(byte[] rht)
        {
            return new ByteArray(rht);
        }

        public static implicit operator byte[](ByteArray rht)
        {
            return rht.ReadBytes(rht.bytesAvailable);
        }

        public static implicit operator int(ByteArray rht)
        {
            return rht.ReadInt();
        }

        public static implicit operator uint(ByteArray rht)
        {
            return rht.ReadUInt();
        }

        public static implicit operator short(ByteArray rht)
        {
            return rht.ReadShort();
        }

        public static implicit operator ushort(ByteArray rht)
        {
            return rht.ReadUShort();
        }
        
        public static implicit operator long(ByteArray rht)
        {
            return rht.ReadLong();
        }

        public static implicit operator ulong(ByteArray rht)
        {
            return rht.ReadULong();
        }

        public static implicit operator byte(ByteArray rht)
        {
            return rht.ReadByte();
        }

        public static implicit operator sbyte(ByteArray rht)
        {
            return (sbyte)rht.ReadByte();
        }

        public static implicit operator string(ByteArray rht)
        {
            return rht.ReadString();
        }

        public static implicit operator double(ByteArray rht)
        {
            return rht.ReadDouble();
        }

        public void Close()
        {
            m.Close();
        }

        public void Clear()
        {
            m.Close();
            m = new MemoryStream();
        }

        public void Compress()
        {
            if (length > 0)
            {
                byte[] d = m.ToArray();
                Clear();
                
                sm = new ZLibNet.ZLibStream(m, ZLibNet.CompressionMode.Compress, ZLibNet.CompressionLevel.BestCompression);
                
                sm.Write(d, 0, d.Length);
                sm.Flush();
                sm.Close();
            }
        }

        public void Decompress()
        {
            if (length > 0)
            {
                byte[] d = m.ToArray();
                Clear();

                sm = new ZLibNet.ZLibStream(m, ZLibNet.CompressionMode.Decompress);
                
                sm.CopyTo(m);
                m.Flush();
                sm.Close();
                
            }
        }

        public void SaveFile(string file)
        {
            System.IO.File.WriteAllBytes(file, m.ToArray());
        }
    }
}
