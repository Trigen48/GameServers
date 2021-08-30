#define safe

using System;
using System.Collections;
using Connector;


namespace GameServer.Command
{

    internal static class ActiveController
    {

        private static string[] ClaimCode = new string[] { "", "3", "8", "15", "25" };
        private static int[][] Prizes = new int[][]{null,
                                            new int[]{8010002,8020002,1211001},
                                            new int[]{6040009,8030003,1210004},
                                            new int[]{9020006,6040010,2230003},
                                            new int[]{9020017,1117005,1210008}
                                                       };

        private static byte[][] Quantity = new byte[][]{null,
                                            new byte[]{1,1,1},
                                            new byte[]{3,1,2},
                                            new byte[]{1,3,3},
                                            new byte[]{1,1,1}
                                                        };

        internal static void ClaimZodiac(ConnectionInfo c)
        {
            string key = c.ar.ReadString().ToLower().Replace(" ", "");
            byte res = 10;



            c.con.StartCommand("SELECT COUNT(*) FROM codevoucher WHERE codeID=? AND roleid=?");
            c.con.AddValue(key);
            c.con.AddValue(c.rlid);
            object o = c.con.ExecuteScalar();

            if (o != null && Convert.ToInt32(o) == 0)
            {
                if (Gameplay.SpecialCodes.codes.ContainsKey(key))
                {
                    if (c.Player.bag.CanBagAdd(1))
                    {

                        c.con.StartCommand("INSERT INTO codevoucher(codeid,roleid) VALUES(?,?);");
                        c.con.AddValue(key);
                        c.con.AddValue(c.rlid);
                        if (c.con.ExecuteNoneQuery() > 0)
                        {
                            c.Player.bag.AddBagItem(Gameplay.SpecialCodes.codes[key], 1, 2);
                            res = 9;
                        }
                        else
                        {
                            res = 5;
                        }
                    }
                    else
                    {
                        res = 5;
                    }

                }
                else
                {
                    res = 10;
                }
            }
            else
            {
                res = 3;
            }


            c.ot.WriteByte(res);
            c.ot.PackArray(50001);
        }

        internal static void ClaimTopup(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"ActiveController 50002");


            if (c.Player.vip.crystal < 1)
            {
                c.ot.WriteByte(2);
            }
            else
            {
                if (c.Player.active.TopupClaim == 0)
                {

                    if (c.Player.bag.CanBagAdd(1))
                    {
                        c.Player.bag.AddBagItem(9010009, 1, 2);
                        //c.Player.bag.Save();
                        c.ot.WriteByte(1);
                        c.Player.active.TopupClaim = 2;
                        c.Player.active.Save();
                    }
                    else
                    {
                        c.ot.WriteByte(5);
                    }
                }
                else
                {
                    c.ot.WriteByte(6);
                }
            }
            c.ot.PackArray(50002);
        }

        internal static byte[] TopUp(ConnectionInfo c)
        {

            ByteArray ot = new ByteArray();
            ot.WriteByte(1);
            ot.WriteInt(c.Player.vip.crystal);

            if (c.Player.vip.crystal < 1)
                ot.WriteByte(0);
            else
                ot.WriteByte(c.Player.active.TopupClaim);

            ot.PackArray(50003);

            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            return d;
        }
        internal static void CheckTopup(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"ActiveController 50003");

            c.ot.WriteByte(1);
            c.ot.WriteInt(c.Player.vip.crystal);

            if (c.Player.vip.crystal < 1)
                c.ot.WriteByte(0);
            else
                c.ot.WriteByte(c.Player.active.TopupClaim);

            c.ot.PackArray(50003);
        }

        internal static void CheckSignin(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"ActiveController 50004");

            if (c.Player.active.CheckMonth() || c.Player.active.CheckDay())
            {
                c.Player.active.Save();
            }


            c.ot.WriteByte(1);
            if (c.Player.active.CanClaimDayPack() || c.Player.active.DayClaim == 0)
            {
                c.ot.WriteByte(0);
            }
            else
            {
                c.ot.WriteByte(1);
            }



            c.ot.WriteString(c.Player.active.Signin);//"1_2_3_4");
            c.ot.WriteString(c.Player.active.Claims);//"");
            c.ot.PackArray(50004);

        }



        internal static void DoSignin(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"ActiveController 50005");

            if (c.Player.active.SignIn())
            {
                c.ot.WriteByte(1);
                //c.Player.active.Save();
            }
            else
            {
                c.ot.WriteByte(2);
            }


            c.ot.PackArray(50005);
        }

        internal static void c50006(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"ActiveController 50006");


            byte q = c.ar.ReadByte();
            byte r = 0;

            if (q == 0)
            {
                r = GetDayPrize(c);
            }
            else if (q < 5)
            {

                r = GetAcumPrize(c, q);
            }


            c.ot.WriteByte(r);
            c.ot.WriteByte(q);
            c.ot.PackArray(50006);
        }

        internal static byte GetAcumPrize(ConnectionInfo c, byte code)
        {

            if (c.Player.active.Claims.Contains(ClaimCode[code]))
                return 4;

            if (c.Player.active.Signin.Split(new char[] { '_' }).Length < int.Parse(ClaimCode[code]))
                return 3;

            if (!c.Player.bag.CanBagAdd(3))
                return 6;

            if (c.Player.bag.AddBagItem(Prizes[code][0], Quantity[code][0], 2)
                && c.Player.bag.AddBagItem(Prizes[code][1], Quantity[code][1], 2)
                && c.Player.bag.AddBagItem(Prizes[code][2], Quantity[code][2], 2))
            {
                //c.Player.active.DayClaim = 1;

                if (c.Player.active.Claims == "")
                {
                    c.Player.active.Claims = ClaimCode[code];
                }
                else
                {
                    c.Player.active.Claims += "_" + ClaimCode[code];
                }

                c.Player.active.Save();
                // c.Player.bag.Save();
                return 1;
                // c.ot.WriteByte(1);
            }
            else
            {
                return 2;
                // c.ot.WriteByte(2);
            }

            //return 0;
        }

        internal static byte GetDayPrize(ConnectionInfo c)
        {
            if (c.Player.active.DayClaim == 0)
            {

                if (c.Player.bag.CanBagAdd(1))
                {

                    if (c.Player.bag.AddBagItem(9020007, 1, 2))
                    {
                        c.Player.active.DayClaim = 1;
                        c.Player.active.Save();
                        // c.Player.bag.Save();

                        return 1;
                        // c.ot.WriteByte(1);
                    }
                    else
                    {
                        return 2;
                        // c.ot.WriteByte(2);
                    }
                }
                else
                {
                    return 6;
                    // c.ot.WriteByte(6);
                }
            }
            else
            {
                return 4;
                //  c.ot.WriteByte(4);
            }

            //  return 0;
        }


        internal static void c50007(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "ActiveController 50007");

            /*ot.WriteByte(a_result);
            ot.WriteByte(b_active);
            ot.WriteByte(c_type1);
            ot.WriteByte(d_type2);
            ot.WriteByte(e_type3);
            ot.WriteByte(f_type4);
            ot.WriteByte(g_type5);*/

            c.ot.WriteByte(1);
            c.ot.WriteByte(0);// Active points
            c.ot.WriteByte(1);
            c.ot.WriteByte(2);
            c.ot.WriteByte(3);
            c.ot.WriteByte(4);
            c.ot.WriteByte(5);


            c.ot.WriteShort(1);

            c.ot.WriteByte(1);
            c.ot.WriteShort(1);
            c.ot.WriteInt(0);
            c.ot.WriteShort(0);
            c.ot.WriteInt(0);

            c.ot.PackArray(50007);

        }

        internal static void c50008(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "ActiveController 50008");


        }

        internal static void c50009(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "ActiveController 50009");

            c.ot.WriteByte(1);

            c.ot.WriteShort(1);

            c.ot.WriteInt(625);
            c.ot.WriteByte(1);
            c.ot.WriteShort(0);

            /* c.ot.WriteInt(602);
             c.ot.WriteByte(1);
             c.ot.WriteShort(0);

             c.ot.WriteInt(603);
             c.ot.WriteByte(1);
             c.ot.WriteShort(0);*/

            c.ot.PackArray(50009);

        }

        internal static void c50010(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "ActiveController 50010");

            if (c.Player.active.CheckDay())
            {
                c.Player.active.Save();
            }


            c.ot.WriteByte(0);
            c.ot.WriteShort(15);
            c.ot.WriteInt(500);
            c.ot.WriteShort(200);
            c.ot.WriteInt(5000);

            c.ot.PackArray(50010);

            //public var a_result:Int8;
            // public var b_type:Int8;
            /*c.ar = new ByteArray();
            c.ar.WriteByte(1);
            c.ar.WriteByte(0);
            c.ar.PackArray(50008);
            c.ot.WriteBytes(c.ar.GetByteArray());
            c.ar.Close();*/
        }

        internal static void c50011(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "ActiveController 50011");


        }

        internal static void c50012(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "ActiveController 50012");


        }

    }
}
