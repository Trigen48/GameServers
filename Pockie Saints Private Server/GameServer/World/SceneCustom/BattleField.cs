using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer.World
{
    public class BattleField : Scene
    {


        public static byte[][] PlayerSpawns = new byte[][]
        {
            new byte[]{},
            new byte[]{},
            new byte[]{}
        };


        public static byte[][] Towers = new byte[][]
        {    
            //red
            new byte[]{13,19},
            new byte[]{17,15},
             
            //blue
            new byte[]{49,14},
            new byte[]{53,18},

                   
            //yellow    
            new byte[]{13,66},
            new byte[]{17,70},

          
        };

        public BattleField()
        {
            CreateNew(990);
            CreateOutTowers();

        }

        public void CreateOutTowers()
        {
            MonsterTemplate mm = new MonsterTemplate();

            mm.hp_lim = 900;
            mm.mp_lim = 1;
            mm.level = 30;
            mm.name = "";
            mm.speed = 0;
            mm.resource_type = 990004;
            mm.type = 6;
            mm.expand = "";
            
            //m.monster_id = 990006;
            MonTemp.Add(990006, mm);


            for (byte i = 0; i < Towers.Length; i++)
            {

                SceneMonster m = new SceneMonster();

                m.x=Towers[i][0];
                m.y = Towers[i][1];
                m.id=i+900;
                m.monster_id = 990006;
                m.respawn = 120;
                m.hp = MonTemp[m.monster_id].hp_lim;// 900;
                m.mp = MonTemp[m.monster_id].mp_lim;
                Monsters.Add(m);
            }

        }
    }
}
