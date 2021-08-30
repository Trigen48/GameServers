
using System;
using System.Collections.Generic;
using System.Text;


namespace GameServer
{

    internal static class horoscopeHelper
    {

        internal static short[][] value;

        internal static object axe;
        internal static byte[] values;
        internal static byte[] stars;

        internal static void init()
        {

            CreateValues();


            axe= new ShuffleList<byte>();

            for (byte i = 0; i < 22; i++)
            {
                AddItem(i);
            }

            ((ShuffleList<byte>)axe).Remove(1);
            ((ShuffleList<byte>)axe).Remove(2);
           // ((ShuffleList<byte>)axe).Remove();*/


            ((ShuffleList<byte>)axe).ShuffleShift();
            ((ShuffleList<byte>)axe).ShuffleInplace();
            ((ShuffleList<byte>)axe).ShuffleShift();

            values = ((ShuffleList<byte>)axe).ToArray();

            ((ShuffleList<byte>)axe).Clear();
 

            AddItem(4, 2);
            AddItem(1, 6);
            AddItem(2, 4);
            AddItem(0, 8);
            AddItem(3, 3);


            ((ShuffleList<byte>)axe).ShuffleShift();
            ((ShuffleList<byte>)axe).ShuffleInplace();
            ((ShuffleList<byte>)axe).ShuffleShift();
            stars = ((ShuffleList<byte>)axe).ToArray();

            ((ShuffleList<byte>)axe).Clear();
            axe = null;
        }

        internal static void AddItem(byte id)
        {
            ((ShuffleList<byte>)axe).Add(id,true);
        }

        internal static void AddItem(byte id, byte quantity)
        {

            for (byte i = 0; i < quantity; i++)
            {
                ((ShuffleList<byte>)axe).Add(id,true);
            }

        }

        internal static void CreateValues()
        {
            short[] com = new short[] { 4, 8, 12, 16, 20 };
            // int vl = 20;
            value = new short[22][];

            //FORGE<1
            value[0] = new short[] { 1, 2, 3, 4, 5 };

            //PET TALENT<2
            value[1] = new short[] { 1, 2, 3, 4, 5 };

            //PET QUALITY<3
            value[2] = com;

            //char exp<4
            value[3] = com;

            //TEAM EXP<5
            value[4] = com;

            //PET EXP<6
            value[5] = com;

            //ATK<7
            value[6] = com;

            //DEF<8
            value[7] = com;

            //HP<9
            value[8] = com;

            //MP<10
            value[9] = com;

            //HIT<11
            value[10] = com;

            //DOD<12
            value[11]= com;

            //CRIT<13
            value[12] = com;

            //FORT<14
            value[13] = com;

            //ATK<15
            value[14] = new short[] { 100, 150, 400, 600, 800 };

            //DEF<16
            value[15] = new short[] { 200, 350, 600, 900, 1200 };

            //HP<17
            value[16] = new short[] { 400, 550, 750, 950, 1400 };

            //MP<18
            value[17] = new short[] { 100, 150, 200, 250, 350 };

            //HIT<19
            value[18] = new short[] { 20, 50, 80, 120, 250 };

            //DOD<20
            value[19] = value[18];

            //CRIT<21
            value[20] = value[18];

            //FORT<22
            value[21] = value[18];


        }


    }

 }