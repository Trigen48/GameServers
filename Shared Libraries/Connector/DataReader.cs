using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Connector
{
    public class DataReader
    {

        Dictionary<string, int> Fields;
        BindingList<object[]> DataRead;
        int c_row = -1, c_col = 0;

        public DataReader(Dictionary<string, int> fields, BindingList<object[]> input)
        {
            DataRead = input;
            Fields = fields;
        }

        public bool CanRead
        {
            get
            {
                return DataRead != null || c_row>-1;
            }
        }

        public void ResetRead()
        {
            c_row = -1;
            c_col = 0;
        }

        public int Rows
        {
            get
            {
                return DataRead.Count;
            }
        }

        public bool NextRow()
        {
            if (DataRead == null)
                return false;

            c_row += 1;
            c_col = 0;
            if (c_row >= DataRead.Count)
            {
                return false;
            }
            return true;
        }

        public object GetValue()
        {
            return GetValue(nextField());
        }

        public object GetValue(int index)
        {
            if (DataRead[c_row] == null || index<0 || index>DataRead[c_row].Length)
            {
                throw new Exception("Invalid column accessed");
            }

            return DataRead[c_row][index];
        }

        public object GetValue(string Name)
        {
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                return GetValue(Fields[n]);
            }
            return null;
        }


        int nextField()
        {
            c_col++;
            return c_col -1;
        }

        public bool ReadBool()
        {
            int index = nextField();
            return ReadBool(index);
        }

        public bool ReadBool(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadBool(index);
        }

        public bool ReadBool(int index)
        {
            object j = GetValue(index);
            return Convert.ToBoolean(j);
        }

        public int ReadInt()
        {
            int index = nextField();
            return ReadInt(index);
        }

        public int ReadInt(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadInt(index);
        }

        public int ReadInt(int index)
        {
            object j = GetValue(index);
            return Convert.ToInt32(j);
        }

        public uint ReadUInt()
        {
            int index = nextField();
            return ReadUInt(index);
        }

        public uint ReadUInt(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadUInt(index);
        }

        public uint ReadUInt(int index)
        {
            object j = GetValue(index);
            return Convert.ToUInt32(j);
        }

        public long ReadLong()
        {
            int index = nextField();
            return ReadLong(index);
        }

        public long ReadLong(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadLong(index);
        }

        public long ReadLong(int index)
        {
            object j = GetValue(index);
            return Convert.ToInt64(j);
        }

        public ulong ReadULong()
        {
            int index = nextField();
            return ReadULong(index);
        }

        public ulong ReadULong(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadULong(index);
        }
        public ulong ReadULong(int index)
        {
            object j = GetValue(index);
            return Convert.ToUInt64(j);
        }

        public byte ReadByte()
        {
            int index = nextField();
            return ReadByte(index);
        }

        public byte ReadByte(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadByte(index);
        }
        public byte ReadByte(int index)
        {
            object j = GetValue(index);
            return Convert.ToByte(j);
        }

        public sbyte ReadSByte()
        {
            int index = nextField();
            return ReadSByte(index);
        }

        public sbyte ReadSByte(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadSByte(index);
        }
        public sbyte ReadSByte(int index)
        {
            object j = GetValue(index);
            return Convert.ToSByte(j);
        }

        public decimal ReadDecimal()
        {
            int index = nextField();
            return ReadDecimal(index);
        }

        public Decimal ReadDecimal(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadDecimal(index);
        }
        public decimal ReadDecimal(int index)
        {
            object j = GetValue(index);
            return Convert.ToDecimal(j);
        }

        public float ReadFloat()
        {
            int index = nextField();
            return ReadFloat(index);
        }

        public float ReadFloat(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadFloat(index);
        }
        public float ReadFloat(int index)
        {
            object j = GetValue(index);
            return (float)Convert.ToDouble(j);
        }

        public double ReadDouble()
        {
            int index = nextField();
            return ReadDouble(index);
        }

        public double ReadDouble(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadDouble(index);
        }
        public double ReadDouble(int index)
        {
            object j = GetValue(index);
            return Convert.ToDouble(j);
        }

        public short ReadShort()
        {
            int index = nextField();
            return ReadShort(index);
        }

        public short ReadShort(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadShort(index);
        }
        public short ReadShort(int index)
        {
            object j = GetValue(index);
            return Convert.ToInt16(j);
        }

        public ushort ReadUShort()
        {
            int index = nextField();
            return ReadUShort(index);
        }

        public ushort ReadUShort(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadUShort(index);
        }
        public ushort ReadUShort(int index)
        {
            object j = GetValue(index);
            return Convert.ToUInt16(j);
        }

        public string ReadString()
        {
            int index = nextField();
            return ReadString(index);
        }

        public string ReadString(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadString(index);
        }
        public string ReadString(int index)
        {
            object j = GetValue(index);

            if (j == DBNull.Value || j == null)
            {
                return "";
            }
            return j.ToString();
        }


        public DateTime ReadDate()
        {
            int index = nextField();
            return ReadDate(index);
        }

        public DateTime ReadDate(string Name)
        {
            int index = -1;
            string n = Name.ToLower();
            if (Fields.ContainsKey(n))
            {
                index = Fields[n];
            }
            return ReadDate(index);
        }
        public DateTime ReadDate(int index)
        {
            object j = GetValue(index);
            if (j is DateTime)
            {
                return (DateTime)j;
            }
            else if (j is TimeSpan)
            {
                return (new DateTime()) + ((TimeSpan)j);
            }
            throw new Exception("Invalid date time!");
        }

 
        public void Close()
        {
            if (DataRead != null)
            {
                DataRead.Clear();
            }
        }

        public BindingList<Object[]> ToArray()
        {

            return DataRead;

        }

    }
}
