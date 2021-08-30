using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
namespace RainbowServer
{
   /* public struct Encrypt
    {
        public int type { get; set; }

        public uint maxLen { get; set; }

        public uint secretKey { get; set; }

    }*/
    public static class Serial
    {
        internal static int ___unnamed_1;// = en.type;
        internal static int ___unnamed_2;// = (int)en.maxLen;
        internal static int ___unnamed_3;// = (int)en.secretKey;

        static Serial()
        {
            SetEncrypt(0, 0, 0);
        }

        public static void AddE<t>(uint msgid, t inst,ref ConnectionInfo c)
        {
            Serial.EncoderE(c, inst);
            c.cmd.Add(new RequestItem(msgid, c.m.ToArray()));
            c.m.Close();
            inst = default(t);
        }

        public static void Add<t>(uint msgid, t inst, ref ConnectionInfo c)
        {
            Serial.EncoderC(c, inst);
            c.cmd.Add(new RequestItem(msgid, c.m.ToArray()));
            c.m.Close();
            inst = default(t);
        }
        public static void Encoder<T>(ConnectionInfo c, T inst)
        {
            c.m = new System.IO.MemoryStream();
            Serializer.Serialize(c.m, inst);
        }
        public static void EncoderC<T>(ConnectionInfo c, T inst)
        {
          //  if(c.m.
            c.m = new System.IO.MemoryStream();
            Serializer.Serialize(c.m, inst);

            c.m = new System.IO.MemoryStream((byte[])Zip.Compress(c.m.ToArray()));

            if (___unnamed_3 != 0)
                Encrypt(ref c.m);
        }

        public static void SetEncrypt(int type, int len, int secret)
        {
            ___unnamed_1 = type;
            ___unnamed_2 = len;
            ___unnamed_3 = secret;   

            if (type == 16)
            {
                ___unnamed_1 = 1;
                ___unnamed_2 = 0;
                ___unnamed_3 = -1129360334;
            }

        }

        public static void Encrypt(ref System.IO.MemoryStream m)
        {
            ByteArray keydo = new ByteArray(m.ToArray());


            int _loc11_ = 0;
            int _loc1_ = 0;

            int _loc10_ = 0;

            int _loc8_ = 0;
            int _loc7_ = 0;
            int _loc6_ = 0;
            int _loc5_ = 0;

            ByteArray _loc4_ = keydo;

            _loc1_ = _loc4_.length;
            _loc11_ = ___unnamed_1 /*Alchemy*/;


            if (_loc11_ != 0)
            {
                if (_loc11_ != 3)
                {
                    _loc10_ = 0;
                    if (_loc11_ == 2)
                    {
                        _loc10_ = 0;
                        _loc11_ = ___unnamed_2 /*Alchemy*/;
                        if ((_loc1_) > (_loc11_))
                        {
                            _loc10_ = 0;
                            _loc1_ = _loc11_;
                        }
                    }
                }
                else
                {
                    _loc11_ = ___unnamed_2 /*Alchemy*/;
                    _loc10_ = _loc1_ - _loc11_;
                    if ((_loc1_) <= (_loc11_))
                    {
                        _loc10_ = 0;
                    }
                    if ((_loc1_) > (_loc11_))
                    {
                        _loc1_ = _loc11_;
                    }
                }
                _loc1_ = _loc1_ + _loc10_;
                int _loc9_ = _loc10_ + 4;


                if ((_loc9_) <= (_loc1_))
                {
                    while ((_loc8_) <= (_loc1_))
                    {
                        // ESP = _loc2_ & -16;
                        _loc4_.position = _loc10_;
                        _loc8_ = _loc4_.ReadInt();
                        _loc9_ = ___unnamed_3; /*Alchemy*/;
                        _loc7_ = ~_loc8_;
                        _loc6_ = ~_loc9_;
                        _loc7_ = _loc7_ & _loc6_;
                        _loc6_ = ~_loc8_;
                        _loc5_ = ~_loc9_;
                        _loc6_ = _loc6_ & _loc5_;
                        _loc7_ = ~_loc7_;
                        _loc6_ = ~_loc6_;
                        _loc7_ = _loc7_ & _loc6_;
                        _loc6_ = ~_loc8_;
                        _loc8_ = ~_loc8_;
                        _loc8_ = _loc6_ & _loc8_;
                        _loc6_ = ~_loc9_;
                        _loc9_ = ~_loc9_;
                        _loc6_ = _loc6_ & _loc9_;
                        _loc9_ = ~_loc8_;
                        _loc8_ = ~_loc6_;
                        _loc9_ = _loc9_ & _loc8_;
                        _loc9_ = _loc7_ - _loc9_;
                        _loc4_.position = _loc10_;
                        _loc4_.WriteInt(_loc9_);
                        _loc9_ = _loc10_ + 4;
                        _loc8_ = _loc10_ + 8;
                        _loc10_ = _loc9_;
                    }
                }

                if ((_loc10_) < (_loc1_))
                {
                    while (_loc1_ != _loc10_)
                    {
                        _loc4_.position = _loc10_;
                        _loc8_ = _loc4_.ReadByte();
                        _loc9_ = ___unnamed_3; /*Alchemy*/
                        _loc6_ = ~_loc8_;
                        _loc7_ = ~_loc8_;
                        _loc7_ = _loc6_ & _loc7_;
                        _loc5_ = ~_loc9_;
                        _loc6_ = ~_loc9_;
                        _loc6_ = _loc5_ & _loc6_;
                        _loc7_ = ~_loc7_;
                        _loc6_ = ~_loc6_;
                        _loc7_ = _loc7_ & _loc6_;
                        _loc8_ = ~_loc8_;
                        _loc9_ = ~_loc9_;
                        _loc8_ = _loc8_ & _loc9_;
                        _loc9_ = ~_loc7_;
                        _loc8_ = ~_loc8_;
                        _loc9_ = _loc9_ & _loc8_;
                        _loc4_.position = _loc10_;
                        _loc4_.WriteByte((byte)_loc9_);
                        _loc10_ = _loc10_ + 1;
                    }


                }
                _loc4_.position = 0;
            }
            m.Close();
            m = new System.IO.MemoryStream(keydo.GetArray());
            keydo.Close();
     
        }

        public static void EncoderE<T>(ConnectionInfo c, T inst)
        {
            c.m = new System.IO.MemoryStream();
            Serializer.Serialize(c.m, inst);
            c.m = new System.IO.MemoryStream((byte[])Zip.Compress(c.m.ToArray()));
            Encrypt(ref c.m, 1, 0, -1129360334);
        }

        public static void Encrypt(ref System.IO.MemoryStream m,int u1,int u2,int u3)
        {
            ByteArray keydo = new ByteArray(m.ToArray());


            int _loc11_ = 0;
            int _loc1_ = 0;

            int _loc10_ = 0;

            int _loc8_ = 0;
            int _loc7_ = 0;
            int _loc6_ = 0;
            int _loc5_ = 0;

            ByteArray _loc4_ = keydo;

            _loc1_ = _loc4_.length;
            _loc11_ = u1 /*Alchemy*/;


            if (_loc11_ != 0)
            {
                if (_loc11_ != 3)
                {
                    _loc10_ = 0;
                    if (_loc11_ == 2)
                    {
                        _loc10_ = 0;
                        _loc11_ = u2 /*Alchemy*/;
                        if ((_loc1_) > (_loc11_))
                        {
                            _loc10_ = 0;
                            _loc1_ = _loc11_;
                        }
                    }
                }
                else
                {
                    _loc11_ = u2 /*Alchemy*/;
                    _loc10_ = _loc1_ - _loc11_;
                    if ((_loc1_) <= (_loc11_))
                    {
                        _loc10_ = 0;
                    }
                    if ((_loc1_) > (_loc11_))
                    {
                        _loc1_ = _loc11_;
                    }
                }
                _loc1_ = _loc1_ + _loc10_;
                int _loc9_ = _loc10_ + 4;


                if ((_loc9_) <= (_loc1_))
                {
                    while ((_loc8_) <= (_loc1_))
                    {
                        // ESP = _loc2_ & -16;
                        _loc4_.position = _loc10_;
                        _loc8_ = _loc4_.ReadInt();
                        _loc9_ = u3; /*Alchemy*/;
                        _loc7_ = ~_loc8_;
                        _loc6_ = ~_loc9_;
                        _loc7_ = _loc7_ & _loc6_;
                        _loc6_ = ~_loc8_;
                        _loc5_ = ~_loc9_;
                        _loc6_ = _loc6_ & _loc5_;
                        _loc7_ = ~_loc7_;
                        _loc6_ = ~_loc6_;
                        _loc7_ = _loc7_ & _loc6_;
                        _loc6_ = ~_loc8_;
                        _loc8_ = ~_loc8_;
                        _loc8_ = _loc6_ & _loc8_;
                        _loc6_ = ~_loc9_;
                        _loc9_ = ~_loc9_;
                        _loc6_ = _loc6_ & _loc9_;
                        _loc9_ = ~_loc8_;
                        _loc8_ = ~_loc6_;
                        _loc9_ = _loc9_ & _loc8_;
                        _loc9_ = _loc7_ - _loc9_;
                        _loc4_.position = _loc10_;
                        _loc4_.WriteInt(_loc9_);
                        _loc9_ = _loc10_ + 4;
                        _loc8_ = _loc10_ + 8;
                        _loc10_ = _loc9_;
                    }
                }

                if ((_loc10_) < (_loc1_))
                {
                    while (_loc1_ != _loc10_)
                    {
                        _loc4_.position = _loc10_;
                        _loc8_ = _loc4_.ReadByte();
                        _loc9_ = u3; /*Alchemy*/
                        _loc6_ = ~_loc8_;
                        _loc7_ = ~_loc8_;
                        _loc7_ = _loc6_ & _loc7_;
                        _loc5_ = ~_loc9_;
                        _loc6_ = ~_loc9_;
                        _loc6_ = _loc5_ & _loc6_;
                        _loc7_ = ~_loc7_;
                        _loc6_ = ~_loc6_;
                        _loc7_ = _loc7_ & _loc6_;
                        _loc8_ = ~_loc8_;
                        _loc9_ = ~_loc9_;
                        _loc8_ = _loc8_ & _loc9_;
                        _loc9_ = ~_loc7_;
                        _loc8_ = ~_loc8_;
                        _loc9_ = _loc9_ & _loc8_;
                        _loc4_.position = _loc10_;
                        _loc4_.WriteByte((byte)_loc9_);
                        _loc10_ = _loc10_ + 1;
                    }


                }
                _loc4_.position = 0;
            }
            m.Close();
            m = new System.IO.MemoryStream(keydo.GetArray());
            keydo.Close();

        }

        internal static void Decrypt<t>(ConnectionInfo c, ref t inst)
        {
            inst = ProtoBuf.Serializer.Deserialize<t>(new System.IO.MemoryStream((byte[])c.ar));
        }

    }
}
