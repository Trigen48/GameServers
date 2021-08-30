using System;
using System.Collections.Generic;
using System.Text;
namespace GameServer
{
    
    public class Active
    {
        //const string file = "Active";

        ConnectionInfo c;

        public Role Player { get; set; }

        [ContentProto("actmonth")]
        public byte Month { get; set; }

        [ContentProto("signin")]
        public string Signin { get; set; }

        [ContentProto("claims")]
        public string Claims { get; set; }

        [ContentProto("topupclaim")]
        public byte TopupClaim { get; set; }

        [ContentProto("zodiacclaim")]
        public byte BigZodiacClaim { get; set; }

        [ContentProto("actday")]
        public byte day { get; set; }

        [ContentProto("activepoint")]
        public byte activepoints { get; set; }

        //[Content("")]
        public byte[] actives { get; set; }

        [ContentProto("dayclaim")]
        public byte DayClaim { get; set; }

        [ContentProto("lastplay")]
        public int lasttime { get; set; }


        [ContentProto("isbattlefield")]
        public byte EnterBattleField { get; set; }


        public Active(ConnectionInfo con)
        {
            c = con;
        }

        public bool Load()
        {
            //ByteC.LoadProto(c.accid + file, ref val);

            c.con.StartCommand("SELECT ActMonth, SignIn, Claims, TopupClaim, ZodiacClaim, ActDay, ActivePoint, DayClaim, LastPlay, isBattleField FROM active WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);

            return ContentResolver.DoDeserialize<Active>(this, c.con);

        }

        public bool SignIn()
        {
            string m = DateUtil.GetZoneDate().Day.ToString();

            string temp = "";
            if (Signin.Trim() != "")
            {
                if (Signin.EndsWith(m)) return false;

                temp = Signin.Trim() + "_" + m;
            }
            else
            {
                temp = m;
            }



            c.con.StartCommand("UPDATE active SET SignIn=?, DayClaim=0 WHERE roleid=?");
            c.con.AddValue(temp);
            c.con.AddValue(c.rlid);


            if (c.con.ExecuteNoneQuery() > 0)
            {
                Signin = temp;
                DayClaim = 0;
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool CheckMonth()
        {
            if (DateUtil.GetZoneDate().Month != Month)
            {
                Month = (byte)DateUtil.GetZoneDate().Month;
                Signin = "";
                Claims = "";

                /*  c.con.StartCommand("UPDATE active SET ActMonth=?, SignIn='',Claims=? WHERE roleid=?");

                  c.con.AddValue(Month);
                  c.con.AddValue(c.rlid);
                  */
                return true;
            }
            return false;
        }

        public bool CheckDay()
        {

            if (day != DateUtil.GetZoneDate().Day)
            {
                DayClaim = 0;
                /*day = (byte)DateUtil.GetZoneDate().Day;

                c.con.StartCommand("UPDATE active SET ActDay=? WHERE roleid=?");

                c.con.AddValue(Month);
                c.con.AddValue(c.rlid);*/
                return true;
            }

            return false;
        }

        public bool CanClaimDayPack()
        {
            return Signin.EndsWith(DateUtil.GetZoneDate().Day.ToString()) && DayClaim == 0;
        }

        public bool Save()
        {
            //ByteC.SaveProto(c.accid + file, this);
      
            c.con.StartCommand("UPDATE active SET ActMonth=?,SignIn=?,Claims=?,TopupClaim=?,ZodiacClaim=?,ActDay=?,ActivePoint=?,DayClaim=?,LastPlay=?,isBattleField=? WHERE roleid=?");
            c.con.AddValue(Month);
            c.con.AddValue(Signin);
            c.con.AddValue(Claims);
            c.con.AddValue(TopupClaim);
            c.con.AddValue(BigZodiacClaim);
            c.con.AddValue(day);
            c.con.AddValue(activepoints);
            c.con.AddValue(DayClaim);
            c.con.AddValue(lasttime);
            c.con.AddValue(EnterBattleField);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO active(roleid,ActMonth,ActDay) VALUES(?,?,?);");
            c.con.AddValue(roleid);
            c.con.AddValue(DateUtil.GetZoneDate().Month);
            c.con.AddValue(DateUtil.GetZoneDate().Day);

            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}
