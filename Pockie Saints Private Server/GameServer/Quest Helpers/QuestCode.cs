using System;
using System.Collections.Generic;

namespace GameServer
{
    internal static class QuestCode
    {
        public static byte Q100001(ConnectionInfo c, int QuestID)
        {
            //Ask Star Sage Halmir what to do next.
            if (QuestCommand.CanQuest(c, 1)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 26, 1000, 0, 13);

            c.Player.quest.AddTaskAccept(100002, 100001, 100);
            return res;
        }
        public static byte A100001(ConnectionInfo c, int QuestID)
        {
            //Ask Star Sage Halmir what to do next.
            if (QuestCommand.CanQuest(c, 1)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100001, 100001, 1, 1, 100);
            return res;
        }
        public static byte Q100002(ConnectionInfo c, int QuestID)
        {
            //Find Star Protector Stone, get a gift box from him.
            if (QuestCommand.CanQuest(c, 2)) return 3;
            byte res = 1;

            res = QuestReward.R100002(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 110, 1000, 0, 16);

            c.Player.quest.AddTaskAccept(100003, 100002, 100);
            return res;
        }
        public static byte A100002(ConnectionInfo c, int QuestID)
        {
            //Find Star Protector Stone, get a gift box from him.
            if (QuestCommand.CanQuest(c, 2)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100002, 100002, 1, 1, 100);
            return res;
        }
        public static byte Q100003(ConnectionInfo c, int QuestID)
        {
            //Equip weapon, then go to see Star Warrior Sophie.
            if (QuestCommand.CanQuest(c, 3)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 322, 1000, 0, 19);

            c.Player.quest.AddTaskAccept(100005, 100003, 100);
            return res;
        }
        public static byte A100003(ConnectionInfo c, int QuestID)
        {
            //Equip weapon, then go to see Star Warrior Sophie.
            if (QuestCommand.CanQuest(c, 3)) return 3;
            byte res = 1;

            res = QuestPush.P100003(c);
            if (res != 1) return res;


            c.Player.quest.AddTaskComplete(100003, 100003, 1, 1, 100);
            return res;
        }
        public static byte Q100005(ConnectionInfo c, int QuestID)
        {
            //Learn skill, then look for Zodiac Instructor Darcy.
            if (QuestCommand.CanQuest(c, 4)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 722, 1100, 0, 22);

            c.Player.quest.AddTaskAccept(100007, 100004, 100);
            return res;
        }
        public static byte A100005(ConnectionInfo c, int QuestID)
        {
            //Learn skill, then look for Zodiac Instructor Darcy.
            if (QuestCommand.CanQuest(c, 4)) return 3;
            byte res = 1;

            res = QuestPush.P100005(c);
            if (res != 1) return res;


            c.Player.quest.AddTaskComplete(100005, 100004, 1, 1, 100);
            return res;
        }
        public static byte Q100007(ConnectionInfo c, int QuestID)
        {
            //Ask Virgo Kerry for a cloth.
            if (QuestCommand.CanQuest(c, 5)) return 3;
            byte res = 1;

            res = QuestReward.R100007(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 846, 700, 0, 16);

            c.Player.quest.AddTaskAccept(100009, 100005, 100);
            return res;
        }
        public static byte A100007(ConnectionInfo c, int QuestID)
        {
            //Ask Virgo Kerry for a cloth.
            if (QuestCommand.CanQuest(c, 5)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100007, 100005, 1, 1, 100);
            return res;
        }
        public static byte Q100009(ConnectionInfo c, int QuestID)
        {
            //Find Zodiac Priest Moville outside of Zodiac Academy and finish his requirement.
            if (QuestCommand.CanQuest(c, 5)) return 3;
            byte res = 1;

            res = QuestReward.R100009(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 524, 400, 0, 9);

            c.Player.quest.AddTaskAccept(100010, 101001, 100);
            return res;
        }
        public static byte A100009(ConnectionInfo c, int QuestID)
        {
            //Find Zodiac Priest Moville outside of Zodiac Academy and finish his requirement.
            if (QuestCommand.CanQuest(c, 5)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100009, 101001, 1, 1, 100);
            return res;
        }
        public static byte Q100010(ConnectionInfo c, int QuestID)
        {
            //Kill Beedas at the outside of Zodiac Academy and then report to Zodiac Priest Moville.
            if (QuestCommand.CanQuest(c, 6)) return 3;
            byte res = 1;

            res = QuestReward.R100010(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 2326, 1000, 0, 28);

            c.Player.quest.AddTaskAccept(100012, 101001, 100);
            return res;
        }
        public static byte A100010(ConnectionInfo c, int QuestID)
        {
            //Kill Beedas at the outside of Zodiac Academy and then report to Zodiac Priest Moville.
            if (QuestCommand.CanQuest(c, 6)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100010, 101001, 2, 0, 100, 1, 101001);
            c.Player.quest.AddPack(100010, 101001, 100);
            return res;
        }
        public static byte Q100012(ConnectionInfo c, int QuestID)
        {
            //Ask Zodiac Priest Lily for the opportunity of getting next proof.
            if (QuestCommand.CanQuest(c, 7)) return 3;
            byte res = 1;

            res = QuestReward.R100012(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 690, 350, 0, 9);

            c.Player.quest.AddTaskAccept(100013, 101002, 100);
            return res;
        }
        public static byte A100012(ConnectionInfo c, int QuestID)
        {
            //Ask Zodiac Priest Lily for the opportunity of getting next proof.
            if (QuestCommand.CanQuest(c, 7)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100012, 101002, 1, 1, 100);
            return res;
        }
        public static byte Q100013(ConnectionInfo c, int QuestID)
        {
            //Kill 1 Vampire Bat outside of Zodiac Academy and then report to Zodiac Priest Lily.
            if (QuestCommand.CanQuest(c, 7)) return 3;
            byte res = 1;

            res = QuestReward.R100013(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 1343, 350, 0, 10);

            c.Player.quest.AddTaskAccept(100014, 101002, 100);
            return res;
        }
        public static byte A100013(ConnectionInfo c, int QuestID)
        {
            //Kill 1 Vampire Bat outside of Zodiac Academy and then report to Zodiac Priest Lily.
            if (QuestCommand.CanQuest(c, 7)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100013, 101002, 2, 0, 100, 1, 101002);
            c.Player.quest.AddPack(100013, 101002, 100);
            return res;
        }
        public static byte Q100014(ConnectionInfo c, int QuestID)
        {
            //Kill 1 Hiram outside of Zodiac Academy and then report to Zodiac Priest Lily.
            if (QuestCommand.CanQuest(c, 7)) return 3;
            byte res = 1;

            res = QuestReward.R100014(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 1617, 400, 0, 12);

            c.Player.quest.AddTaskAccept(100015, 101002, 100);
            return res;
        }
        public static byte A100014(ConnectionInfo c, int QuestID)
        {
            //Kill 1 Hiram outside of Zodiac Academy and then report to Zodiac Priest Lily.
            if (QuestCommand.CanQuest(c, 7)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100014, 101004, 2, 0, 100, 1, 101004);
            c.Player.quest.AddPack(100014, 101002, 100);
            return res;
        }
        public static byte Q100015(ConnectionInfo c, int QuestID)
        {
            //Get the last proof from Zodiac Officiant Roger, and match constellations.
            if (QuestCommand.CanQuest(c, 8)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 944, 250, 0, 8);

            c.Player.quest.AddTaskAccept(100016, 101003, 100);
            return res;
        }
        public static byte A100015(ConnectionInfo c, int QuestID)
        {
            //Get the last proof from Zodiac Officiant Roger, and match constellations.
            if (QuestCommand.CanQuest(c, 8)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100015, 101003, 1, 1, 100);
            return res;
        }
        public static byte Q100016(ConnectionInfo c, int QuestID)
        {
            //Kill 1 Treant outside of Zodiac Academy, then report to Zodiac Officiant Roger.
            if (QuestCommand.CanQuest(c, 8)) return 3;
            byte res = 1;

            res = QuestReward.R100016(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 2613, 250, 0, 8);

            c.Player.quest.AddTaskAccept(100017, 101003, 100);
            return res;
        }
        public static byte A100016(ConnectionInfo c, int QuestID)
        {
            //Kill 1 Treant outside of Zodiac Academy, then report to Zodiac Officiant Roger.
            if (QuestCommand.CanQuest(c, 8)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100016, 101003, 2, 0, 100, 1, 101003);
            c.Player.quest.AddPack(100016, 101003, 100);
            return res;
        }
        public static byte Q100017(ConnectionInfo c, int QuestID)
        {
            //Learn new skill with the guidance of Zodiac Instructor Barral.
            if (QuestCommand.CanQuest(c, 8)) return 3;
            byte res = 1;

            res = QuestReward.R100017(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 1845, 500, 0, 18);

            c.Player.quest.AddTaskAccept(100020, 100006, 100);
            return res;
        }
        public static byte A100017(ConnectionInfo c, int QuestID)
        {
            //Learn new skill with the guidance of Zodiac Instructor Barral.
            if (QuestCommand.CanQuest(c, 8)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100017, 100006, 1, 1, 100);
            return res;
        }
        public static byte Q100020(ConnectionInfo c, int QuestID)
        {
            //Ask Star Warlock Ekland to activate the Zodiac Medal.
            if (QuestCommand.CanQuest(c, 9)) return 3;
            byte res = 1;

            res = QuestReward.R100020(c);
            if (res != 1) return res;

            // Here we remove the start achievements items> after completing the glory academy training!
            // Vital Fix
            c.Player.bag.RemoveByType(5010063);
            c.Player.bag.RemoveByType(5010064);
            c.Player.bag.RemoveByType(5010065);
            c.Player.bag.RemoveByType(5010066);

            Tasks.AddQuestFinance(c, 7642, 1100, 0, 37);
            c.Player.quest.AddTaskAccept(100026, 100009, 100);
            c.Player.title.Add(1031, 0);

           // c.Player.title.Save(c);
            ByteArray ar = new ByteArray();

            ar.WriteShort(7);
            ar.WriteShort(39003);
            ar.WriteShort(1031);
            ar.WriteByte(1);
            c.Player.Send(ar.GetByteArray());
            ar.Close();
            return res;
        }
        public static byte A100020(ConnectionInfo c, int QuestID)
        {
            //Ask Star Warlock Ekland to activate the Zodiac Medal.
            if (QuestCommand.CanQuest(c, 9)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100020, 100009, 1, 1, 100);
            return res;
        }
        public static byte Q100023(ConnectionInfo c, int QuestID)
        {
            //Go go Empire Capital, Contact Oracle.
            if (QuestCommand.CanQuest(c, 10)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2532, 400, 0, 16);

            c.Player.quest.AddTaskAccept(111001, 301009, 301);
            return res;
        }
        public static byte A100023(ConnectionInfo c, int QuestID)
        {
            //Go go Empire Capital, Contact Oracle.
            if (QuestCommand.CanQuest(c, 10)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100023, 301009, 1, 1, 301);
            return res;
        }
        public static byte Q100024(ConnectionInfo c, int QuestID)
        {
            //Go go Empire Capital, Contact Oracle.
            if (QuestCommand.CanQuest(c, 10)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2532, 400, 0, 16);

            c.Player.quest.AddTaskAccept(111001, 401009, 401);
            return res;
        }
        public static byte A100024(ConnectionInfo c, int QuestID)
        {
            //Go go Empire Capital, Contact Oracle.
            if (QuestCommand.CanQuest(c, 10)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100024, 401009, 1, 1, 401);
            return res;
        }
        public static byte Q100025(ConnectionInfo c, int QuestID)
        {
            //Go go Empire Capital, Contact Oracle.
            if (QuestCommand.CanQuest(c, 10)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2532, 400, 0, 16);

            c.Player.quest.AddTaskAccept(111001, 201009, 201);
            return res;
        }
        public static byte A100025(ConnectionInfo c, int QuestID)
        {
            //Go go Empire Capital, Contact Oracle.
            if (QuestCommand.CanQuest(c, 10)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100025, 201009, 1, 1, 201);
            return res;
        }
        public static byte Q100026(ConnectionInfo c, int QuestID)
        {
            //Choose a faction.
            if (QuestCommand.CanQuest(c, 10)) return 3;
            byte res = 1;

            res = QuestReward.R100026(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 7898, 600, 0, 24);

            switch (c.Player.role.faction)
            {
                case 1:
                    c.Player.quest.AddTaskAccept(100025, 100009, 100);
                    break;

                case 2:
                    c.Player.quest.AddTaskAccept(100023, 100009, 100);
                    break;

                case 3:
                    c.Player.quest.AddTaskAccept(100024, 100009, 100);
                    break;

            }
            return res;
        }
        public static byte A100026(ConnectionInfo c, int QuestID)
        {
            //Choose a faction.
            if (QuestCommand.CanQuest(c, 10)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(100026, 100009, 10, 0, 100);
            return res;
        }
        public static byte Q110016(ConnectionInfo c, int QuestID)
        {
            //Collect 1 Aquamarine Grass from Sunshine Cliff and give it to Allen.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 10782, 200, 6, 8);

            c.Player.quest.AddTaskAccept(110017, 501001, 501);
            return res;
        }
        public static byte A110016(ConnectionInfo c, int QuestID)
        {
            //Collect 1 Aquamarine Grass from Sunshine Cliff and give it to Allen.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110016, 5010038, 4, 0, 501, 1, 501101);
            c.Player.quest.AddPack(110016, 501001, 501);
            return res;
        }
        public static byte Q110017(ConnectionInfo c, int QuestID)
        {
            //Ask Cecil about how to clean the bloodstain on the secret letter.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;

            res = QuestReward.R110017(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 10258, 500, 6, 28);

            c.Player.quest.AddTaskAccept(110020, 501003, 501);
            return res;
        }
        public static byte A110017(ConnectionInfo c, int QuestID)
        {
            //Ask Cecil about how to clean the bloodstain on the secret letter.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110017, 501003, 1, 1, 501);
            return res;
        }
        public static byte Q110020(ConnectionInfo c, int QuestID)
        {
            //Tekk Allen the method of cleaning bloodstain.
            if (QuestCommand.CanQuest(c, 15)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 6475, 500, 6, 33);

            c.Player.quest.AddTaskAccept(110021, 501001, 501);
            return res;
        }
        public static byte A110020(ConnectionInfo c, int QuestID)
        {
            //Tekk Allen the method of cleaning bloodstain.
            if (QuestCommand.CanQuest(c, 15)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110020, 501001, 1, 1, 501);
            return res;
        }
        public static byte Q110021(ConnectionInfo c, int QuestID)
        {
            //Kill 4 Gold Wire Snakes at Sunshine Cliff, collect their venom and bring it back to Allen.
            if (QuestCommand.CanQuest(c, 15)) return 3;
            byte res = 1;

            res = QuestReward.R110021(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 17441, 500, 6, 33);

            c.Player.quest.AddTaskAccept(110022, 501001, 501);
            return res;
        }
        public static byte A110021(ConnectionInfo c, int QuestID)
        {
            //Kill 4 Gold Wire Snakes at Sunshine Cliff, collect their venom and bring it back to Allen.
            if (QuestCommand.CanQuest(c, 15)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110021, 501001, 2, 0, 501, 4, 501001);
            c.Player.quest.AddPack(110021, 501001, 501);
            return res;
        }
        public static byte Q110022(ConnectionInfo c, int QuestID)
        {
            //Contact Bernice and do whatever she tells you.
            if (QuestCommand.CanQuest(c, 15)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 12084, 1000, 6, 66);

            c.Player.quest.AddTaskAccept(110024, 501002, 501);
            return res;
        }
        public static byte A110022(ConnectionInfo c, int QuestID)
        {
            //Contact Bernice and do whatever she tells you.
            if (QuestCommand.CanQuest(c, 15)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110022, 501002, 1, 1, 501);
            return res;
        }
        public static byte Q110024(ConnectionInfo c, int QuestID)
        {
            //Kill 4 Troll Spiders at Sunshine Cliff, clear the way to Emma.
            if (QuestCommand.CanQuest(c, 16)) return 3;
            byte res = 1;

            res = QuestReward.R110024(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 25425, 400, 6, 40);

            c.Player.quest.AddTaskAccept(110025, 501002, 501);
            return res;
        }
        public static byte A110024(ConnectionInfo c, int QuestID)
        {
            //Kill 4 Troll Spiders at Sunshine Cliff, clear the way to Emma.
            if (QuestCommand.CanQuest(c, 16)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110024, 501002, 2, 0, 501, 4, 501002);
            c.Player.quest.AddPack(110024, 501002, 501);
            return res;
        }
        public static byte Q110025(ConnectionInfo c, int QuestID)
        {
            //Contact Sunshine Cliff\'s Emma.
            if (QuestCommand.CanQuest(c, 16)) return 3;
            byte res = 1;

            res = QuestReward.R110025(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 15951, 800, 6, 85);

            c.Player.quest.AddTaskAccept(110027, 501004, 501);
            return res;
        }
        public static byte A110025(ConnectionInfo c, int QuestID)
        {
            //Contact Sunshine Cliff\'s Emma.
            if (QuestCommand.CanQuest(c, 16)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110025, 501004, 1, 1, 501);
            return res;
        }
        public static byte Q110027(ConnectionInfo c, int QuestID)
        {
            //Collect 1 Mandela Tulip at Sunshine Cliff and give it to Emma.
            if (QuestCommand.CanQuest(c, 16)) return 3;
            byte res = 1;

            res = QuestReward.R110027(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 20772, 400, 6, 45);

            c.Player.quest.AddTaskAccept(110028, 501004, 501);
            return res;
        }
        public static byte A110027(ConnectionInfo c, int QuestID)
        {
            //Collect 1 Mandela Tulip at Sunshine Cliff and give it to Emma.
            if (QuestCommand.CanQuest(c, 16)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110027, 5010039, 4, 0, 501, 1, 501102);
            c.Player.quest.AddPack(110027, 501004, 501);
            return res;
        }
        public static byte Q110028(ConnectionInfo c, int QuestID)
        {
            //Tell Bernice the identity of the victim who\'s confirmed by Emma.
            if (QuestCommand.CanQuest(c, 16)) return 3;
            byte res = 1;

            res = QuestReward.R110028(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 9532, 400, 6, 76);

            c.Player.quest.AddTaskAccept(110029, 501002, 501);
            return res;
        }
        public static byte A110028(ConnectionInfo c, int QuestID)
        {
            //Tell Bernice the identity of the victim who\'s confirmed by Emma.
            if (QuestCommand.CanQuest(c, 16)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110028, 501002, 1, 1, 501);
            return res;
        }
        public static byte Q110029(ConnectionInfo c, int QuestID)
        {
            //Contact Sunshine Cliff\'s Barlow.
            if (QuestCommand.CanQuest(c, 17)) return 3;
            byte res = 1;

            res = QuestReward.R110029(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 12963, 400, 6, 74);

            c.Player.quest.AddTaskAccept(110030, 501005, 501);
            return res;
        }
        public static byte A110029(ConnectionInfo c, int QuestID)
        {
            //Contact Sunshine Cliff\'s Barlow.
            if (QuestCommand.CanQuest(c, 17)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110029, 501005, 1, 1, 501);
            return res;
        }
        public static byte Q110030(ConnectionInfo c, int QuestID)
        {
            //Capture 4 Forest Bears at Sunshine Cliff, bring them back to Barlow.
            if (QuestCommand.CanQuest(c, 17)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 55779, 800, 6, 150);

            c.Player.quest.AddTaskAccept(110032, 501005, 501);
            return res;
        }
        public static byte A110030(ConnectionInfo c, int QuestID)
        {
            //Capture 4 Forest Bears at Sunshine Cliff, bring them back to Barlow.
            if (QuestCommand.CanQuest(c, 17)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110030, 501004, 2, 0, 501, 4, 501004);
            c.Player.quest.AddPack(110030, 501005, 501);
            return res;
        }
        public static byte Q110032(ConnectionInfo c, int QuestID)
        {
            //Collect 1 Phosphate Rock from Sunshine Cliff, bring it back to Barlow to make Phosphate Powder.
            if (QuestCommand.CanQuest(c, 17)) return 3;
            byte res = 1;

            res = QuestReward.R110032(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 37454, 400, 8, 75);

            c.Player.quest.AddTaskAccept(110033, 501005, 501);
            return res;
        }
        public static byte A110032(ConnectionInfo c, int QuestID)
        {
            //Collect 1 Phosphate Rock from Sunshine Cliff, bring it back to Barlow to make Phosphate Powder.
            if (QuestCommand.CanQuest(c, 17)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110032, 5010040, 4, 0, 501, 1, 501103);
            c.Player.quest.AddPack(110032, 501005, 501);
            return res;
        }
        public static byte Q110033(ConnectionInfo c, int QuestID)
        {
            //Go to Sunshine Cliff, contact Janet.
            if (QuestCommand.CanQuest(c, 17)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 9404, 400, 8, 75);

            c.Player.quest.AddTaskAccept(110035, 501006, 501);
            return res;
        }
        public static byte A110033(ConnectionInfo c, int QuestID)
        {
            //Go to Sunshine Cliff, contact Janet.
            if (QuestCommand.CanQuest(c, 17)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110033, 501006, 1, 1, 501);
            return res;
        }
        public static byte Q110035(ConnectionInfo c, int QuestID)
        {
            //Collect 1 Death Flower from Sunshine Cliff and give it to Janet.
            if (QuestCommand.CanQuest(c, 18)) return 3;
            byte res = 1;

            res = QuestReward.R110035(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 60326, 800, 8, 202);

            c.Player.quest.AddTaskAccept(110036, 501006, 501);
            return res;
        }
        public static byte A110035(ConnectionInfo c, int QuestID)
        {
            //Collect 1 Death Flower from Sunshine Cliff and give it to Janet.
            if (QuestCommand.CanQuest(c, 18)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110035, 5010041, 4, 0, 501, 1, 501104);
            c.Player.quest.AddPack(110035, 501006, 501);
            return res;
        }
        public static byte Q110036(ConnectionInfo c, int QuestID)
        {
            //Visit awakening Donald.
            if (QuestCommand.CanQuest(c, 18)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 59055, 800, 8, 208);

            c.Player.quest.AddTaskAccept(110038, 501007, 501);
            return res;
        }
        public static byte A110036(ConnectionInfo c, int QuestID)
        {
            //Visit awakening Donald.
            if (QuestCommand.CanQuest(c, 18)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110036, 501007, 1, 1, 501);
            return res;
        }
        public static byte Q110038(ConnectionInfo c, int QuestID)
        {
            //Capture 4 Thunderhawk from Sunshine Cliff, bring them back to Donald.
            if (QuestCommand.CanQuest(c, 18)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 49099, 400, 8, 104);

            c.Player.quest.AddTaskAccept(110039, 501007, 501);
            return res;
        }
        public static byte A110038(ConnectionInfo c, int QuestID)
        {
            //Capture 4 Thunderhawk from Sunshine Cliff, bring them back to Donald.
            if (QuestCommand.CanQuest(c, 18)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110038, 501003, 2, 0, 501, 4, 501003);
            c.Player.quest.AddPack(110038, 501007, 501);
            return res;
        }
        public static byte Q110039(ConnectionInfo c, int QuestID)
        {
            //Ask Janet to help you extract information from Thunderhawk\'s eyes.
            if (QuestCommand.CanQuest(c, 19)) return 3;
            byte res = 1;

            res = QuestReward.R110039(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 30136, 500, 8, 169);

            c.Player.quest.AddTaskAccept(110040, 501006, 501);
            return res;
        }
        public static byte A110039(ConnectionInfo c, int QuestID)
        {
            //Ask Janet to help you extract information from Thunderhawk\'s eyes.
            if (QuestCommand.CanQuest(c, 19)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110039, 501006, 1, 1, 501);
            return res;
        }
        public static byte Q110040(ConnectionInfo c, int QuestID)
        {
            //Tell Donald the analysis made by Janet, let him make the final decision.
            if (QuestCommand.CanQuest(c, 19)) return 3;
            byte res = 1;

            res = QuestReward.R110040(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 33441, 500, 8, 169);

            c.Player.quest.AddTaskAccept(110041, 501007, 501);
            return res;
        }
        public static byte A110040(ConnectionInfo c, int QuestID)
        {
            //Tell Donald the analysis made by Janet, let him make the final decision.
            if (QuestCommand.CanQuest(c, 19)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110040, 501007, 1, 1, 501);
            return res;
        }
        public static byte Q110041(ConnectionInfo c, int QuestID)
        {
            //Defeat Alva at Sunshine Cliff and report to Donald.
            if (QuestCommand.CanQuest(c, 19)) return 3;
            byte res = 1;

            res = QuestReward.R110041(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 100880, 500, 5, 170);

            c.Player.quest.AddTaskAccept(119007, 501007, 501);
            return res;
        }
        public static byte A110041(ConnectionInfo c, int QuestID)
        {
            //Defeat Alva at Sunshine Cliff and report to Donald.
            if (QuestCommand.CanQuest(c, 19)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110041, 501005, 2, 0, 501, 1, 501005);
            c.Player.quest.AddPack(110041, 501007, 501);
            return res;
        }
        public static byte Q110045(ConnectionInfo c, int QuestID)
        {
            //Ask Edith about the information collected.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 28030, 250, 20, 115);

            c.Player.quest.AddTaskAccept(110048, 502034, 502);
            return res;
        }
        public static byte A110045(ConnectionInfo c, int QuestID)
        {
            //Ask Edith about the information collected.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110045, 502034, 1, 1, 502);
            return res;
        }
        public static byte Q110048(ConnectionInfo c, int QuestID)
        {
            //Capture 5 Rubble Rat in Rubble Wasteland, bring them back to Edith.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;

            res = QuestReward.R110048(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 202545, 200, 10, 122);

            c.Player.quest.AddTaskAccept(110049, 502034, 502);
            return res;
        }
        public static byte A110048(ConnectionInfo c, int QuestID)
        {
            //Capture 5 Rubble Rat in Rubble Wasteland, bring them back to Edith.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110048, 503010, 2, 0, 503, 5, 503010);
            c.Player.quest.AddPack(110048, 502034, 502);
            return res;
        }
        public static byte Q110049(ConnectionInfo c, int QuestID)
        {
            //Bring the paper and ask Herbert what information he has gathered.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 36751, 200, 20, 110);

            c.Player.quest.AddTaskAccept(110050, 502036, 502);
            return res;
        }
        public static byte A110049(ConnectionInfo c, int QuestID)
        {
            //Bring the paper and ask Herbert what information he has gathered.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110049, 502036, 1, 1, 502);
            return res;
        }
        public static byte Q110050(ConnectionInfo c, int QuestID)
        {
            //Ask Joshua for the other half o the information.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 40008, 200, 20, 110);

            c.Player.quest.AddTaskAccept(110051, 502037, 502);
            return res;
        }
        public static byte A110050(ConnectionInfo c, int QuestID)
        {
            //Ask Joshua for the other half o the information.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110050, 502037, 1, 1, 502);
            return res;
        }
        public static byte Q110051(ConnectionInfo c, int QuestID)
        {
            //Tell Edith the information collected by Herbert and Joshua.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 41597, 200, 20, 110);

            c.Player.quest.AddTaskAccept(110058, 502034, 502);
            return res;
        }
        public static byte A110051(ConnectionInfo c, int QuestID)
        {
            //Tell Edith the information collected by Herbert and Joshua.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110051, 502034, 1, 1, 502);
            return res;
        }
        public static byte Q110058(ConnectionInfo c, int QuestID)
        {
            //Ask Leonard for the information he has gathered.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;

            res = QuestReward.R110058(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 56571, 200, 20, 110);

            c.Player.quest.AddTaskAccept(110059, 502040, 503);
            return res;
        }
        public static byte A110058(ConnectionInfo c, int QuestID)
        {
            //Ask Leonard for the information he has gathered.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110058, 502040, 1, 1, 503);
            return res;
        }
        public static byte Q110059(ConnectionInfo c, int QuestID)
        {
            //Capture 8 Mottle Snakes in Rubble Wasteland and bring them back to Leonard.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;

            res = QuestReward.R110059(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 238546, 200, 20, 110);

            c.Player.quest.AddTaskAccept(110060, 502040, 503);
            return res;
        }
        public static byte A110059(ConnectionInfo c, int QuestID)
        {
            //Capture 8 Mottle Snakes in Rubble Wasteland and bring them back to Leonard.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110059, 503011, 2, 0, 503, 8, 503011);
            c.Player.quest.AddPack(110059, 502040, 503);
            return res;
        }
        public static byte Q110060(ConnectionInfo c, int QuestID)
        {
            //Ask Moore for the other half of the information.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 33413, 150, 22, 92);

            c.Player.quest.AddTaskAccept(110061, 502042, 503);
            return res;
        }
        public static byte A110060(ConnectionInfo c, int QuestID)
        {
            //Ask Moore for the other half of the information.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110060, 502042, 1, 1, 503);
            return res;
        }
        public static byte Q110061(ConnectionInfo c, int QuestID)
        {
            //Listen to Moore tell how he lost the information.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 37915, 150, 22, 92);

            c.Player.quest.AddTaskAccept(110062, 502042, 503);
            return res;
        }
        public static byte A110061(ConnectionInfo c, int QuestID)
        {
            //Listen to Moore tell how he lost the information.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110061, 502042, 1, 1, 503);
            return res;
        }
        public static byte Q110062(ConnectionInfo c, int QuestID)
        {
            //Catch Erica in Rubble Wasteland, get the lost half of information and take it to Moore.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;

            res = QuestReward.R110062(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 187415, 150, 22, 92);

            c.Player.quest.AddTaskAccept(110063, 502042, 503);
            return res;
        }
        public static byte A110062(ConnectionInfo c, int QuestID)
        {
            //Catch Erica in Rubble Wasteland, get the lost half of information and take it to Moore.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110062, 5010009, 25, 0, 503, 1, 503009);
            c.Player.quest.AddPack(110062, 502042, 503);
            return res;
        }
        public static byte Q110063(ConnectionInfo c, int QuestID)
        {
            //Bring the information collected by Leonard and Moore to Edith.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;

            res = QuestReward.R110063(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 33633, 150, 22, 92);

            c.Player.quest.AddTaskAccept(120027, 502034, 502);
            return res;
        }
        public static byte A110063(ConnectionInfo c, int QuestID)
        {
            //Bring the information collected by Leonard and Moore to Edith.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110063, 502034, 1, 1, 502);
            return res;
        }
        public static byte Q110064(ConnectionInfo c, int QuestID)
        {
            //Find Jason in Lune Oasis, tell him Edith\'s instructions.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 70274, 200, 22, 170);

            c.Player.quest.AddTaskAccept(119020, 502035, 504);
            return res;
        }
        public static byte A110064(ConnectionInfo c, int QuestID)
        {
            //Find Jason in Lune Oasis, tell him Edith\'s instructions.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110064, 502035, 1, 1, 504);
            return res;
        }
        public static byte Q110089(ConnectionInfo c, int QuestID)
        {
            //Contact Lune Oasis\'s Aldrich.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 15786, 400, 34, 400);

            c.Player.quest.AddTaskAccept(110090, 504005, 504);
            return res;
        }
        public static byte A110089(ConnectionInfo c, int QuestID)
        {
            //Contact Lune Oasis\'s Aldrich.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110089, 504005, 1, 1, 504);
            return res;
        }
        public static byte Q110090(ConnectionInfo c, int QuestID)
        {
            //Find Andy according to Aldrich\'s instruction, follow Andy\'s instruction.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 62629, 400, 35, 490);

            c.Player.quest.AddTaskAccept(110091, 504006, 504);
            return res;
        }
        public static byte A110090(ConnectionInfo c, int QuestID)
        {
            //Find Andy according to Aldrich\'s instruction, follow Andy\'s instruction.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110090, 504006, 1, 1, 504);
            return res;
        }
        public static byte Q110091(ConnectionInfo c, int QuestID)
        {
            //Ask Benedict for the investigation report.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 68611, 800, 69, 890);

            c.Player.quest.AddTaskAccept(110092, 504007, 504);
            return res;
        }
        public static byte A110091(ConnectionInfo c, int QuestID)
        {
            //Ask Benedict for the investigation report.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110091, 504007, 1, 1, 504);
            return res;
        }
        public static byte Q110092(ConnectionInfo c, int QuestID)
        {
            //Bring Benedict\'s magic paper to Andy.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 77641, 800, 69, 891);

            c.Player.quest.AddTaskAccept(110093, 504006, 504);
            return res;
        }
        public static byte A110092(ConnectionInfo c, int QuestID)
        {
            //Bring Benedict\'s magic paper to Andy.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110092, 504006, 1, 1, 504);
            return res;
        }
        public static byte Q110093(ConnectionInfo c, int QuestID)
        {
            //Kill 15 Toothy Gerbils in Darksand Land and then report to Andy.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 188298, 1200, 69, 891);

            c.Player.quest.AddTaskAccept(110094, 504006, 504);
            return res;
        }
        public static byte A110093(ConnectionInfo c, int QuestID)
        {
            //Kill 15 Toothy Gerbils in Darksand Land and then report to Andy.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110093, 505001, 2, 0, 505, 15, 505001);
            c.Player.quest.AddPack(110093, 504006, 504);
            return res;
        }
        public static byte Q110094(ConnectionInfo c, int QuestID)
        {
            //Collect 4 Darkthorn Cactus in Darksand Land and bring them back to Edwina.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 212178, 1100, 69, 1114);

            c.Player.quest.AddTaskAccept(110095, 504012, 504);
            return res;
        }
        public static byte A110094(ConnectionInfo c, int QuestID)
        {
            //Collect 4 Darkthorn Cactus in Darksand Land and bring them back to Edwina.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110094, 5010050, 4, 0, 505, 4, 505101);
            c.Player.quest.AddPack(110094, 504012, 504);
            return res;
        }
        public static byte Q110095(ConnectionInfo c, int QuestID)
        {
            //Help Edwina to ask Andy when can they get normal water supply again.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 97227, 1000, 69, 1114);

            c.Player.quest.AddTaskAccept(110096, 504006, 504);
            return res;
        }
        public static byte A110095(ConnectionInfo c, int QuestID)
        {
            //Help Edwina to ask Andy when can they get normal water supply again.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110095, 504006, 1, 1, 504);
            return res;
        }
        public static byte Q110096(ConnectionInfo c, int QuestID)
        {
            //Find Chester, help Andy ask about Chester\'s findings.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 103782, 1100, 69, 1114);

            c.Player.quest.AddTaskAccept(110097, 504009, 504);
            return res;
        }
        public static byte A110096(ConnectionInfo c, int QuestID)
        {
            //Find Chester, help Andy ask about Chester\'s findings.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110096, 504009, 1, 1, 504);
            return res;
        }
        public static byte Q110097(ConnectionInfo c, int QuestID)
        {
            //Bring Chester\'s investigation report to Andy.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 100134, 1200, 72, 1114);

            c.Player.quest.AddTaskAccept(110098, 504006, 504);
            return res;
        }
        public static byte A110097(ConnectionInfo c, int QuestID)
        {
            //Bring Chester\'s investigation report to Andy.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110097, 504006, 1, 1, 504);
            return res;
        }
        public static byte Q110098(ConnectionInfo c, int QuestID)
        {
            //Capture 20 Rattlesnakes in Darksand Land and bring them back to Andy.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 197525, 1800, 0, 1800);

            c.Player.quest.AddTaskAccept(110099, 504006, 504);
            return res;
        }
        public static byte A110098(ConnectionInfo c, int QuestID)
        {
            //Capture 20 Rattlesnakes in Darksand Land and bring them back to Andy.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110098, 505003, 2, 0, 505, 20, 505003);
            c.Player.quest.AddPack(110098, 504006, 504);
            return res;
        }
        public static byte Q110099(ConnectionInfo c, int QuestID)
        {
            //Follow Andy\'s instruction to find Claude, asking him about how to increase the number of Rattlesnakes.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 132223, 1800, 0, 1800);

            c.Player.quest.AddTaskAccept(110100, 504010, 504);
            return res;
        }
        public static byte A110099(ConnectionInfo c, int QuestID)
        {
            //Follow Andy\'s instruction to find Claude, asking him about how to increase the number of Rattlesnakes.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110099, 504010, 1, 1, 504);
            return res;
        }
        public static byte Q110100(ConnectionInfo c, int QuestID)
        {
            //Capture 20 Dire Wolves in Darksand Land and bring them back to Claude.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 286749, 1800, 0, 1800);

            c.Player.quest.AddTaskAccept(110101, 504010, 504);
            return res;
        }
        public static byte A110100(ConnectionInfo c, int QuestID)
        {
            //Capture 20 Dire Wolves in Darksand Land and bring them back to Claude.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110100, 505004, 2, 0, 505, 20, 505004);
            c.Player.quest.AddPack(110100, 504010, 504);
            return res;
        }
        public static byte Q110101(ConnectionInfo c, int QuestID)
        {
            //Go to Darksand Land, talk to Claude\'s student Nelson.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 199879, 2100, 0, 2132);

            c.Player.quest.AddTaskAccept(110102, 505001, 505);
            return res;
        }
        public static byte A110101(ConnectionInfo c, int QuestID)
        {
            //Go to Darksand Land, talk to Claude\'s student Nelson.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110101, 505001, 1, 1, 505);
            return res;
        }
        public static byte Q110102(ConnectionInfo c, int QuestID)
        {
            //Collect 4 Buckthorn Grasses from Darksand Land and take them to Nelson.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 324671, 2100, 0, 2132);

            c.Player.quest.AddTaskAccept(110103, 505001, 505);
            return res;
        }
        public static byte A110102(ConnectionInfo c, int QuestID)
        {
            //Collect 4 Buckthorn Grasses from Darksand Land and take them to Nelson.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110102, 5010051, 4, 0, 505, 4, 505102);
            c.Player.quest.AddPack(110102, 505001, 505);
            return res;
        }
        public static byte Q110103(ConnectionInfo c, int QuestID)
        {
            //According to Nelson\'s request, ask Willa for some hairs.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 196951, 2100, 0, 2132);

            c.Player.quest.AddTaskAccept(110104, 505006, 505);
            return res;
        }
        public static byte A110103(ConnectionInfo c, int QuestID)
        {
            //According to Nelson\'s request, ask Willa for some hairs.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110103, 505006, 1, 1, 505);
            return res;
        }
        public static byte Q110104(ConnectionInfo c, int QuestID)
        {
            //Kill Swantony in Darksand, seize back Willa\'s ring.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 407415, 2500, 0, 2479);

            c.Player.quest.AddTaskAccept(110105, 505001, 505);
            return res;
        }
        public static byte A110104(ConnectionInfo c, int QuestID)
        {
            //Kill Swantony in Darksand, seize back Willa\'s ring.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110104, 5010012, 25, 0, 505, 1, 505008);
            c.Player.quest.AddPack(110104, 505001, 505);
            return res;
        }
        public static byte Q110105(ConnectionInfo c, int QuestID)
        {
            //Give Willa the ring and ask her for some hairs again.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 197412, 2500, 0, 2479);

            c.Player.quest.AddTaskAccept(110106, 505006, 505);
            return res;
        }
        public static byte A110105(ConnectionInfo c, int QuestID)
        {
            //Give Willa the ring and ask her for some hairs again.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110105, 505006, 1, 1, 505);
            return res;
        }
        public static byte Q110106(ConnectionInfo c, int QuestID)
        {
            //Bring Willa\'s hair back to Nelson.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 222424, 2500, 0, 2479);

            c.Player.quest.AddTaskAccept(110107, 505001, 505);
            return res;
        }
        public static byte A110106(ConnectionInfo c, int QuestID)
        {
            //Bring Willa\'s hair back to Nelson.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110106, 505001, 1, 1, 505);
            return res;
        }
        public static byte Q110107(ConnectionInfo c, int QuestID)
        {
            //Give Claude materials collected by Nelson.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 287147, 2800, 0, 2843);

            c.Player.quest.AddTaskAccept(110108, 504010, 504);
            return res;
        }
        public static byte A110107(ConnectionInfo c, int QuestID)
        {
            //Give Claude materials collected by Nelson.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110107, 504010, 1, 1, 504);
            return res;
        }
        public static byte Q110108(ConnectionInfo c, int QuestID)
        {
            //Capture 35 Toothy Gerbils from Darksand Land and bring them back to Claude.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 455055, 2800, 0, 2843);

            c.Player.quest.AddTaskAccept(110109, 504010, 504);
            return res;
        }
        public static byte A110108(ConnectionInfo c, int QuestID)
        {
            //Capture 35 Toothy Gerbils from Darksand Land and bring them back to Claude.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110108, 505001, 2, 0, 505, 35, 505001);
            c.Player.quest.AddPack(110108, 504010, 504);
            return res;
        }
        public static byte Q110109(ConnectionInfo c, int QuestID)
        {
            //Bring the woman from the Darksand Land to Andy.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 190374, 2900, 0, 2845);

            c.Player.quest.AddTaskAccept(110110, 504006, 504);
            return res;
        }
        public static byte A110109(ConnectionInfo c, int QuestID)
        {
            //Bring the woman from the Darksand Land to Andy.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110109, 504006, 1, 1, 504);
            return res;
        }
        public static byte Q110110(ConnectionInfo c, int QuestID)
        {
            //As Andy asked, Tell Ingrid to heal the mysterious woman as soon as possible.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 212313, 2400, 0, 2418);

            c.Player.quest.AddTaskAccept(110111, 504015, 504);
            return res;
        }
        public static byte A110110(ConnectionInfo c, int QuestID)
        {
            //As Andy asked, Tell Ingrid to heal the mysterious woman as soon as possible.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110110, 504015, 1, 1, 504);
            return res;
        }
        public static byte Q110111(ConnectionInfo c, int QuestID)
        {
            //Ask Darksand Land\'s Miles for some Styptic.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 209477, 2400, 0, 2418);

            c.Player.quest.AddTaskAccept(110112, 505005, 505);
            return res;
        }
        public static byte A110111(ConnectionInfo c, int QuestID)
        {
            //Ask Darksand Land\'s Miles for some Styptic.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110111, 505005, 1, 1, 505);
            return res;
        }
        public static byte Q110112(ConnectionInfo c, int QuestID)
        {
            //Collect 4 Buckthorn Flowers in Darksand Land and take them to Miles.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 384964, 2500, 0, 2419);

            c.Player.quest.AddTaskAccept(110113, 505005, 505);
            return res;
        }
        public static byte A110112(ConnectionInfo c, int QuestID)
        {
            //Collect 4 Buckthorn Flowers in Darksand Land and take them to Miles.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110112, 5010052, 4, 0, 505, 4, 505103);
            c.Player.quest.AddPack(110112, 505005, 505);
            return res;
        }
        public static byte Q110113(ConnectionInfo c, int QuestID)
        {
            //Give Ingrid the Styptic made by Miles.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 229464, 2400, 0, 2419);

            c.Player.quest.AddTaskAccept(110114, 504015, 504);
            return res;
        }
        public static byte A110113(ConnectionInfo c, int QuestID)
        {
            //Give Ingrid the Styptic made by Miles.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110113, 504015, 1, 1, 504);
            return res;
        }
        public static byte Q110114(ConnectionInfo c, int QuestID)
        {
            //Help Colin to ask Cornell for Benson\'s whereabouts.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 223971, 2500, 0, 2717);

            c.Player.quest.AddTaskAccept(110115, 504014, 504);
            return res;
        }
        public static byte A110114(ConnectionInfo c, int QuestID)
        {
            //Help Colin to ask Cornell for Benson\'s whereabouts.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110114, 504014, 1, 1, 504);
            return res;
        }
        public static byte Q110115(ConnectionInfo c, int QuestID)
        {
            //Tell Andy about Benson\'s missing and the lost data.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 254103, 3000, 0, 2717);

            c.Player.quest.AddTaskAccept(110116, 504006, 504);
            return res;
        }
        public static byte A110115(ConnectionInfo c, int QuestID)
        {
            //Tell Andy about Benson\'s missing and the lost data.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110115, 504006, 1, 1, 504);
            return res;
        }
        public static byte Q110116(ConnectionInfo c, int QuestID)
        {
            //Find Esther, let her to get the mysterious woman\'s testimony.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 236117, 2500, 0, 2717);

            c.Player.quest.AddTaskAccept(110117, 504013, 504);
            return res;
        }
        public static byte A110116(ConnectionInfo c, int QuestID)
        {
            //Find Esther, let her to get the mysterious woman\'s testimony.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110116, 504013, 1, 1, 504);
            return res;
        }
        public static byte Q110117(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Bactrian Camels in Darksand Land and take them to Esther.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 422637, 3000, 0, 2717);

            c.Player.quest.AddTaskAccept(110118, 504013, 504);
            return res;
        }
        public static byte A110117(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Bactrian Camels in Darksand Land and take them to Esther.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110117, 505002, 2, 0, 505, 35, 505002);
            c.Player.quest.AddPack(110117, 504013, 504);
            return res;
        }
        public static byte Q110118(ConnectionInfo c, int QuestID)
        {
            //Find Lyle in Darksand Land, tell him Andy\'s instructions.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 341080, 4000, 0, 4037);

            c.Player.quest.AddTaskAccept(110119, 505002, 505);
            return res;
        }
        public static byte A110118(ConnectionInfo c, int QuestID)
        {
            //Find Lyle in Darksand Land, tell him Andy\'s instructions.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110118, 505002, 1, 1, 505);
            return res;
        }
        public static byte Q110119(ConnectionInfo c, int QuestID)
        {
            //Ask Julian to think some ways to find Benson.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 339924, 4000, 0, 4037);

            c.Player.quest.AddTaskAccept(110120, 505003, 505);
            return res;
        }
        public static byte A110119(ConnectionInfo c, int QuestID)
        {
            //Ask Julian to think some ways to find Benson.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110119, 505003, 1, 1, 505);
            return res;
        }
        public static byte Q110120(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Trade Wind Foxes in Darksand Land and take them back to Julian.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 551965, 4200, 0, 4038);

            c.Player.quest.AddTaskAccept(110121, 505003, 505);
            return res;
        }
        public static byte A110120(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Trade Wind Foxes in Darksand Land and take them back to Julian.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110120, 505005, 2, 0, 505, 35, 505005);
            c.Player.quest.AddPack(110120, 505003, 505);
            return res;
        }
        public static byte Q110121(ConnectionInfo c, int QuestID)
        {
            //Arrest Benson in Darksand Land and take him to Lyle.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 594161, 3000, 0, 3351);

            c.Player.quest.AddTaskAccept(110122, 505002, 505);
            return res;
        }
        public static byte A110121(ConnectionInfo c, int QuestID)
        {
            //Arrest Benson in Darksand Land and take him to Lyle.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110121, 505009, 2, 0, 505, 1, 505009);
            c.Player.quest.AddPack(110121, 505002, 505);
            return res;
        }
        public static byte Q110122(ConnectionInfo c, int QuestID)
        {
            //Ask Ogden about the origin of the badge.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 247617, 3500, 0, 3352);

            c.Player.quest.AddTaskAccept(110123, 505004, 505);
            return res;
        }
        public static byte A110122(ConnectionInfo c, int QuestID)
        {
            //Ask Ogden about the origin of the badge.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110122, 505004, 1, 1, 505);
            return res;
        }
        public static byte Q110123(ConnectionInfo c, int QuestID)
        {
            //Report to Andy about how to deal with Benson.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 222439, 3200, 0, 3351);

            c.Player.quest.AddTaskAccept(110124, 504006, 504);
            return res;
        }
        public static byte A110123(ConnectionInfo c, int QuestID)
        {
            //Report to Andy about how to deal with Benson.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110123, 504006, 1, 1, 504);
            return res;
        }
        public static byte Q110124(ConnectionInfo c, int QuestID)
        {
            //Go to Tramp Camp, contact Duke.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 258897, 3500, 0, 3352);

            c.Player.quest.AddTaskAccept(110125, 506006, 506);
            return res;
        }
        public static byte A110124(ConnectionInfo c, int QuestID)
        {
            //Go to Tramp Camp, contact Duke.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110124, 506006, 1, 1, 506);
            return res;
        }
        public static byte Q110125(ConnectionInfo c, int QuestID)
        {
            //Go to see Edgar, ask to join the tramp guild.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 363739, 5000, 0, 4916);

            c.Player.quest.AddTaskAccept(110126, 506007, 506);
            return res;
        }
        public static byte A110125(ConnectionInfo c, int QuestID)
        {
            //Go to see Edgar, ask to join the tramp guild.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110125, 506007, 1, 1, 506);
            return res;
        }
        public static byte Q110126(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Phantom Monkeys from Vine Rainforest and take them to Edgar.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 647338, 4800, 0, 4916);

            c.Player.quest.AddTaskAccept(110127, 506007, 506);
            return res;
        }
        public static byte A110126(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Phantom Monkeys from Vine Rainforest and take them to Edgar.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110126, 507004, 2, 0, 507, 40, 507004);
            c.Player.quest.AddPack(110126, 506007, 506);
            return res;
        }
        public static byte Q110127(ConnectionInfo c, int QuestID)
        {
            //Register at Hoare and accept his test.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 394572, 5000, 0, 4917);

            c.Player.quest.AddTaskAccept(110128, 506008, 506);
            return res;
        }
        public static byte A110127(ConnectionInfo c, int QuestID)
        {
            //Register at Hoare and accept his test.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110127, 506008, 1, 1, 506);
            return res;
        }
        public static byte Q110128(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Man-eating Trees in Vine Rainforest and report to Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 671267, 4000, 0, 4035);

            c.Player.quest.AddTaskAccept(110129, 506008, 506);
            return res;
        }
        public static byte A110128(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Man-eating Trees in Vine Rainforest and report to Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110128, 507003, 2, 0, 507, 40, 507003);
            c.Player.quest.AddPack(110128, 506008, 506);
            return res;
        }
        public static byte Q110129(ConnectionInfo c, int QuestID)
        {
            //Follow Hoare\'s instruction to meet Ansel.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 284160, 4100, 0, 4035);

            c.Player.quest.AddTaskAccept(110130, 506005, 506);
            return res;
        }
        public static byte A110129(ConnectionInfo c, int QuestID)
        {
            //Follow Hoare\'s instruction to meet Ansel.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110129, 506005, 1, 1, 506);
            return res;
        }
        public static byte Q110130(ConnectionInfo c, int QuestID)
        {
            //Tell Duke Ansel\'s requirement for the alliance.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 243767, 4000, 0, 4036);

            c.Player.quest.AddTaskAccept(110131, 506006, 506);
            return res;
        }
        public static byte A110130(ConnectionInfo c, int QuestID)
        {
            //Tell Duke Ansel\'s requirement for the alliance.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110130, 506006, 1, 1, 506);
            return res;
        }
        public static byte Q110131(ConnectionInfo c, int QuestID)
        {
            //Tell Ansel Duke\'s reply.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 279676, 4000, 0, 4036);

            c.Player.quest.AddTaskAccept(110132, 506005, 506);
            return res;
        }
        public static byte A110131(ConnectionInfo c, int QuestID)
        {
            //Tell Ansel Duke\'s reply.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110131, 506005, 1, 1, 506);
            return res;
        }
        public static byte Q110132(ConnectionInfo c, int QuestID)
        {
            //Find Monlisa, ask her to brew one Vow Potion.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 417336, 5500, 0, 5862);

            c.Player.quest.AddTaskAccept(110133, 506011, 506);
            return res;
        }
        public static byte A110132(ConnectionInfo c, int QuestID)
        {
            //Find Monlisa, ask her to brew one Vow Potion.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110132, 506011, 1, 1, 506);
            return res;
        }
        public static byte Q110133(ConnectionInfo c, int QuestID)
        {
            //Collect 5 Delusion Herbs in Vine Rainforest and give them to Monlisa.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 702303, 6000, 0, 5862);

            c.Player.quest.AddTaskAccept(110134, 506011, 506);
            return res;
        }
        public static byte A110133(ConnectionInfo c, int QuestID)
        {
            //Collect 5 Delusion Herbs in Vine Rainforest and give them to Monlisa.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110133, 5010055, 4, 0, 507, 5, 507101);
            c.Player.quest.AddPack(110133, 506011, 506);
            return res;
        }
        public static byte Q110134(ConnectionInfo c, int QuestID)
        {
            //Take Vow Potion to Ansel and drink it in front of him.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 421346, 6000, 0, 5863);

            c.Player.quest.AddTaskAccept(110135, 506005, 506);
            return res;
        }
        public static byte A110134(ConnectionInfo c, int QuestID)
        {
            //Take Vow Potion to Ansel and drink it in front of him.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110134, 506005, 1, 1, 506);
            return res;
        }
        public static byte Q110135(ConnectionInfo c, int QuestID)
        {
            //Ask Elder Levi to make one Eye of Truth.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 393971, 6000, 0, 6360);

            c.Player.quest.AddTaskAccept(110136, 506010, 506);
            return res;
        }
        public static byte A110135(ConnectionInfo c, int QuestID)
        {
            //Ask Elder Levi to make one Eye of Truth.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110135, 506010, 1, 1, 506);
            return res;
        }
        public static byte Q110136(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Wraith Spiders in Vine Rainforest, take their eyes to Levi.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 826416, 7000, 0, 6360);

            c.Player.quest.AddTaskAccept(110137, 506010, 506);
            return res;
        }
        public static byte A110136(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Wraith Spiders in Vine Rainforest, take their eyes to Levi.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110136, 5010018, 25, 0, 507, 40, 507005);
            c.Player.quest.AddPack(110136, 506010, 506);
            return res;
        }
        public static byte Q110137(ConnectionInfo c, int QuestID)
        {
            //Find Ansel, see what request he has.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 369724, 6000, 0, 6361);

            c.Player.quest.AddTaskAccept(110138, 506005, 506);
            return res;
        }
        public static byte A110137(ConnectionInfo c, int QuestID)
        {
            //Find Ansel, see what request he has.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110137, 506005, 1, 1, 506);
            return res;
        }
        public static byte Q110138(ConnectionInfo c, int QuestID)
        {
            //Ask Joyce for Tramp\'s headscarf.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 357146, 7000, 0, 6875);

            c.Player.quest.AddTaskAccept(110139, 506009, 506);
            return res;
        }
        public static byte A110138(ConnectionInfo c, int QuestID)
        {
            //Ask Joyce for Tramp\'s headscarf.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110138, 506009, 1, 1, 506);
            return res;
        }
        public static byte Q110139(ConnectionInfo c, int QuestID)
        {
            //Kill Baird in Vine Rainforest, take back the stolen Tramp\'s headscarf.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 897317, 7000, 0, 6875);

            c.Player.quest.AddTaskAccept(110140, 506009, 506);
            return res;
        }
        public static byte A110139(ConnectionInfo c, int QuestID)
        {
            //Kill Baird in Vine Rainforest, take back the stolen Tramp\'s headscarf.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110139, 507006, 2, 0, 507, 1, 507006);
            c.Player.quest.AddPack(110139, 506009, 506);
            return res;
        }
        public static byte Q110140(ConnectionInfo c, int QuestID)
        {
            //Take Tramp\'s headscarf and report to Ansel.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 369916, 6600, 0, 6875);

            c.Player.quest.AddTaskAccept(110141, 506005, 506);
            return res;
        }
        public static byte A110140(ConnectionInfo c, int QuestID)
        {
            //Take Tramp\'s headscarf and report to Ansel.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110140, 506005, 1, 1, 506);
            return res;
        }
        public static byte Q110141(ConnectionInfo c, int QuestID)
        {
            //Ask Monlisa to make one Mystic Potion.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 439417, 7000, 0, 7406);

            c.Player.quest.AddTaskAccept(110142, 506011, 506);
            return res;
        }
        public static byte A110141(ConnectionInfo c, int QuestID)
        {
            //Ask Monlisa to make one Mystic Potion.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110141, 506011, 1, 1, 506);
            return res;
        }
        public static byte Q110142(ConnectionInfo c, int QuestID)
        {
            //Collect 5 Vampire Vines in Vine Rainforest and tale them back to Monlisa.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 822590, 7500, 0, 7406);

            c.Player.quest.AddTaskAccept(110143, 506011, 506);
            return res;
        }
        public static byte A110142(ConnectionInfo c, int QuestID)
        {
            //Collect 5 Vampire Vines in Vine Rainforest and tale them back to Monlisa.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110142, 5010056, 4, 0, 507, 5, 507102);
            c.Player.quest.AddPack(110142, 506011, 506);
            return res;
        }
        public static byte Q110143(ConnectionInfo c, int QuestID)
        {
            //Listen to Ansel talk about the use of Mystic Potion.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 379421, 8000, 0, 7406);

            c.Player.quest.AddTaskAccept(110144, 506005, 506);
            return res;
        }
        public static byte A110143(ConnectionInfo c, int QuestID)
        {
            //Listen to Ansel talk about the use of Mystic Potion.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110143, 506005, 1, 1, 506);
            return res;
        }
        public static byte Q110144(ConnectionInfo c, int QuestID)
        {
            //Find Jerome in Vine Rainforest, capture Archer with him.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 337733, 8000, 0, 7954);

            c.Player.quest.AddTaskAccept(110145, 507001, 507);
            return res;
        }
        public static byte A110144(ConnectionInfo c, int QuestID)
        {
            //Find Jerome in Vine Rainforest, capture Archer with him.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110144, 507001, 1, 1, 507);
            return res;
        }
        public static byte Q110145(ConnectionInfo c, int QuestID)
        {
            //Ask Kyle if he can remove the giant stone which blocks the way.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 426812, 8000, 0, 7954);

            c.Player.quest.AddTaskAccept(110146, 507002, 507);
            return res;
        }
        public static byte A110145(ConnectionInfo c, int QuestID)
        {
            //Ask Kyle if he can remove the giant stone which blocks the way.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110145, 507002, 1, 1, 507);
            return res;
        }
        public static byte Q110146(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Giant Jaw Ants in Vine Rainforest and take them to Kyle.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 874865, 8000, 0, 7954);

            c.Player.quest.AddTaskAccept(110147, 507002, 507);
            return res;
        }
        public static byte A110146(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Giant Jaw Ants in Vine Rainforest and take them to Kyle.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110146, 507001, 2, 0, 507, 45, 507001);
            c.Player.quest.AddPack(110146, 507002, 507);
            return res;
        }
        public static byte Q110147(ConnectionInfo c, int QuestID)
        {
            //Ask Thera if she can find out the disappeared trace.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 407369, 8000, 0, 8518);

            c.Player.quest.AddTaskAccept(110148, 507005, 507);
            return res;
        }
        public static byte A110147(ConnectionInfo c, int QuestID)
        {
            //Ask Thera if she can find out the disappeared trace.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110147, 507005, 1, 1, 507);
            return res;
        }
        public static byte Q110148(ConnectionInfo c, int QuestID)
        {
            //Ask Winnie to make some Revealing Potion.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 449278, 8500, 0, 8518);

            c.Player.quest.AddTaskAccept(110149, 507006, 507);
            return res;
        }
        public static byte A110148(ConnectionInfo c, int QuestID)
        {
            //Ask Winnie to make some Revealing Potion.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110148, 507006, 1, 1, 507);
            return res;
        }
        public static byte Q110149(ConnectionInfo c, int QuestID)
        {
            //Collect 5 Luminous Grasses in Vine Rainforest and take them back to Winnie.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 759342, 9000, 0, 8520);

            c.Player.quest.AddTaskAccept(110150, 507006, 507);
            return res;
        }
        public static byte A110149(ConnectionInfo c, int QuestID)
        {
            //Collect 5 Luminous Grasses in Vine Rainforest and take them back to Winnie.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110149, 5010057, 4, 0, 507, 5, 507103);
            c.Player.quest.AddPack(110149, 507006, 507);
            return res;
        }
        public static byte Q110150(ConnectionInfo c, int QuestID)
        {
            //Catch Archer in Vine Rainforest and take him to Jerome.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 819437, 9000, 0, 9100);

            c.Player.quest.AddTaskAccept(110151, 507001, 507);
            return res;
        }
        public static byte A110150(ConnectionInfo c, int QuestID)
        {
            //Catch Archer in Vine Rainforest and take him to Jerome.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110150, 507007, 2, 0, 507, 1, 507007);
            c.Player.quest.AddPack(110150, 507001, 507);
            return res;
        }
        public static byte Q110151(ConnectionInfo c, int QuestID)
        {
            //Take Archer to Tramp Camp\'s Ansel.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 374102, 9500, 0, 9100);

            c.Player.quest.AddTaskAccept(110152, 506005, 506);
            return res;
        }
        public static byte A110151(ConnectionInfo c, int QuestID)
        {
            //Take Archer to Tramp Camp\'s Ansel.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110151, 506005, 1, 1, 506);
            return res;
        }
        public static byte Q110152(ConnectionInfo c, int QuestID)
        {
            //Take Archer to Morris.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 375299, 9000, 0, 9100);

            c.Player.quest.AddTaskAccept(110153, 506013, 506);
            return res;
        }
        public static byte A110152(ConnectionInfo c, int QuestID)
        {
            //Take Archer to Morris.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110152, 506013, 1, 1, 506);
            return res;
        }
        public static byte Q110153(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Mud Monsters in Vine Rainforest and take them to Morris.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 855001, 7000, 0, 7273);

            c.Player.quest.AddTaskAccept(110154, 506013, 506);
            return res;
        }
        public static byte A110153(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Mud Monsters in Vine Rainforest and take them to Morris.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110153, 507002, 2, 0, 507, 45, 507002);
            c.Player.quest.AddPack(110153, 506013, 506);
            return res;
        }
        public static byte Q110154(ConnectionInfo c, int QuestID)
        {
            //Take Archer from Morris to Ansel.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 212347, 8000, 0, 7273);

            c.Player.quest.AddTaskAccept(110155, 506005, 506);
            return res;
        }
        public static byte A110154(ConnectionInfo c, int QuestID)
        {
            //Take Archer from Morris to Ansel.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110154, 506005, 1, 1, 506);
            return res;
        }
        public static byte Q110155(ConnectionInfo c, int QuestID)
        {
            //Tell Duke that Archer was poisoned to death.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 249836, 7000, 0, 7274);

            c.Player.quest.AddTaskAccept(110156, 506006, 506);
            return res;
        }
        public static byte A110155(ConnectionInfo c, int QuestID)
        {
            //Tell Duke that Archer was poisoned to death.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110155, 506006, 1, 1, 506);
            return res;
        }
        public static byte Q110156(ConnectionInfo c, int QuestID)
        {
            //Go to Pearl Village, meet Colby dispatched by Duke.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 279481, 7000, 0, 7275);

            c.Player.quest.AddTaskAccept(110157, 508006, 508);
            return res;
        }
        public static byte A110156(ConnectionInfo c, int QuestID)
        {
            //Go to Pearl Village, meet Colby dispatched by Duke.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110156, 508006, 1, 1, 508);
            return res;
        }
        public static byte Q110157(ConnectionInfo c, int QuestID)
        {
            //Visit Ashbur, ask him about where to find the Blade.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 412985, 7500, 0, 7000);

            c.Player.quest.AddTaskAccept(110158, 508005, 508);
            return res;
        }
        public static byte A110157(ConnectionInfo c, int QuestID)
        {
            //Visit Ashbur, ask him about where to find the Blade.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110157, 508005, 1, 1, 508);
            return res;
        }
        public static byte Q110158(ConnectionInfo c, int QuestID)
        {
            //Tell Mabel about what the Village Head said.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 402371, 7000, 0, 7000);

            c.Player.quest.AddTaskAccept(110159, 508013, 508);
            return res;
        }
        public static byte A110158(ConnectionInfo c, int QuestID)
        {
            //Tell Mabel about what the Village Head said.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110158, 508013, 1, 1, 508);
            return res;
        }
        public static byte Q110159(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Venom Monsters in Redcloud Marsh and then go back and tell Mabel.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 917144, 7500, 0, 7000);

            c.Player.quest.AddTaskAccept(110160, 508013, 508);
            return res;
        }
        public static byte A110159(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Venom Monsters in Redcloud Marsh and then go back and tell Mabel.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110159, 509001, 2, 0, 509, 50, 509001);
            c.Player.quest.AddPack(110159, 508013, 508);
            return res;
        }
        public static byte Q110160(ConnectionInfo c, int QuestID)
        {
            //Take the red material to Raymond, ask him to analyze its component.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 443178, 7000, 0, 7500);

            c.Player.quest.AddTaskAccept(110161, 508011, 508);
            return res;
        }
        public static byte A110160(ConnectionInfo c, int QuestID)
        {
            //Take the red material to Raymond, ask him to analyze its component.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110160, 508011, 1, 1, 508);
            return res;
        }
        public static byte Q110161(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Venom Monsters in Redcloud Marsh, collect the red materials for Raymond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 975024, 8000, 0, 7500);

            c.Player.quest.AddTaskAccept(110162, 508011, 508);
            return res;
        }
        public static byte A110161(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Venom Monsters in Redcloud Marsh, collect the red materials for Raymond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110161, 509001, 2, 0, 509, 50, 509001);
            c.Player.quest.AddPack(110161, 508011, 508);
            return res;
        }
        public static byte Q110162(ConnectionInfo c, int QuestID)
        {
            //Tell Mabel about Raymond\'s finding.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 457119, 8500, 0, 7500);

            c.Player.quest.AddTaskAccept(110163, 508013, 508);
            return res;
        }
        public static byte A110162(ConnectionInfo c, int QuestID)
        {
            //Tell Mabel about Raymond\'s finding.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110162, 508013, 1, 1, 508);
            return res;
        }
        public static byte Q110163(ConnectionInfo c, int QuestID)
        {
            //Find Vermal in Redcloud Marsh, ask him if anything unusual has happened.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 467778, 7500, 0, 7700);

            c.Player.quest.AddTaskAccept(110164, 509002, 509);
            return res;
        }
        public static byte A110163(ConnectionInfo c, int QuestID)
        {
            //Find Vermal in Redcloud Marsh, ask him if anything unusual has happened.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110163, 509002, 1, 1, 509);
            return res;
        }
        public static byte Q110164(ConnectionInfo c, int QuestID)
        {
            //Give Simona the data collected by Vermal, ask here to make a comprehensive analysis.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 453131, 7000, 0, 7700);

            c.Player.quest.AddTaskAccept(110165, 509005, 509);
            return res;
        }
        public static byte A110164(ConnectionInfo c, int QuestID)
        {
            //Give Simona the data collected by Vermal, ask here to make a comprehensive analysis.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110164, 509005, 1, 1, 509);
            return res;
        }
        public static byte Q110165(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Short-wing Rats in Redcloud Marsh and take them to Simona.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1104387, 8000, 0, 7700);

            c.Player.quest.AddTaskAccept(110166, 509005, 509);
            return res;
        }
        public static byte A110165(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Short-wing Rats in Redcloud Marsh and take them to Simona.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110165, 509002, 2, 0, 509, 50, 509002);
            c.Player.quest.AddPack(110165, 509005, 509);
            return res;
        }
        public static byte Q110166(ConnectionInfo c, int QuestID)
        {
            //Ask Raymond about the solution.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 422330, 8500, 0, 7650);

            c.Player.quest.AddTaskAccept(110167, 508011, 508);
            return res;
        }
        public static byte A110166(ConnectionInfo c, int QuestID)
        {
            //Ask Raymond about the solution.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110166, 508011, 1, 1, 508);
            return res;
        }
        public static byte Q110167(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Medusa in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1128465, 8500, 0, 7650);

            c.Player.quest.AddTaskAccept(110168, 508011, 508);
            return res;
        }
        public static byte A110167(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Medusa in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110167, 509003, 2, 0, 509, 50, 509003);
            c.Player.quest.AddPack(110167, 508011, 508);
            return res;
        }
        public static byte Q110168(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Fluorescent Herbs in Redcloud Marsh and take them to Raymond.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 631798, 8000, 0, 7650);

            c.Player.quest.AddTaskAccept(110169, 508011, 508);
            return res;
        }
        public static byte A110168(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Fluorescent Herbs in Redcloud Marsh and take them to Raymond.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110168, 5010067, 4, 0, 509, 6, 509101);
            c.Player.quest.AddPack(110168, 508011, 508);
            return res;
        }
        public static byte Q110169(ConnectionInfo c, int QuestID)
        {
            //Take Simona\'s analysis report to Vermal.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 567415, 9000, 0, 7850);

            c.Player.quest.AddTaskAccept(110170, 509002, 509);
            return res;
        }
        public static byte A110169(ConnectionInfo c, int QuestID)
        {
            //Take Simona\'s analysis report to Vermal.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110169, 509002, 1, 1, 509);
            return res;
        }
        public static byte Q110170(ConnectionInfo c, int QuestID)
        {
            //Take Simona\'s analysis report to Mabel.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 620070, 8500, 0, 7850);

            c.Player.quest.AddTaskAccept(110171, 508013, 508);
            return res;
        }
        public static byte A110170(ConnectionInfo c, int QuestID)
        {
            //Take Simona\'s analysis report to Mabel.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110170, 508013, 1, 1, 508);
            return res;
        }
        public static byte Q110171(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Mugger Crocodiles in Redcloud Marsh and then to to tell Mabel.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1159895, 7500, 0, 7850);

            c.Player.quest.AddTaskAccept(110172, 508013, 508);
            return res;
        }
        public static byte A110171(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Mugger Crocodiles in Redcloud Marsh and then to to tell Mabel.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110171, 509004, 2, 0, 509, 50, 509004);
            c.Player.quest.AddPack(110171, 508013, 508);
            return res;
        }
        public static byte Q110172(ConnectionInfo c, int QuestID)
        {
            //Defeat Olive in Redcloud Marsh and then to to tell Mabel.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1374685, 8000, 0, 7700);

            c.Player.quest.AddTaskAccept(110173, 508013, 508);
            return res;
        }
        public static byte A110172(ConnectionInfo c, int QuestID)
        {
            //Defeat Olive in Redcloud Marsh and then to to tell Mabel.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110172, 509006, 2, 0, 509, 1, 509006);
            c.Player.quest.AddPack(110172, 508013, 508);
            return res;
        }
        public static byte Q110173(ConnectionInfo c, int QuestID)
        {
            //Take the mysterious woman back to village, ask village head Ashbur if he can find out any clues.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 579416, 8500, 0, 7700);

            c.Player.quest.AddTaskAccept(110174, 508005, 508);
            return res;
        }
        public static byte A110173(ConnectionInfo c, int QuestID)
        {
            //Take the mysterious woman back to village, ask village head Ashbur if he can find out any clues.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110173, 508005, 1, 1, 508);
            return res;
        }
        public static byte Q110174(ConnectionInfo c, int QuestID)
        {
            //Ask Olive about the whereabout of the village head\'s son.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 565724, 8500, 0, 7700);

            c.Player.quest.AddTaskAccept(110175, 508014, 508);
            return res;
        }
        public static byte A110174(ConnectionInfo c, int QuestID)
        {
            //Ask Olive about the whereabout of the village head\'s son.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110174, 508014, 1, 1, 508);
            return res;
        }
        public static byte Q110175(ConnectionInfo c, int QuestID)
        {
            //Take Olive to Nicolas for treatment.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 606069, 7500, 0, 7900);

            c.Player.quest.AddTaskAccept(110176, 508009, 508);
            return res;
        }
        public static byte A110175(ConnectionInfo c, int QuestID)
        {
            //Take Olive to Nicolas for treatment.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110175, 508009, 1, 1, 508);
            return res;
        }
        public static byte Q110176(ConnectionInfo c, int QuestID)
        {
            //Catch 55 Medusa in Redcloud Marsh and take them to Nicolas.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1497462, 8000, 0, 7900);

            c.Player.quest.AddTaskAccept(110177, 508009, 508);
            return res;
        }
        public static byte A110176(ConnectionInfo c, int QuestID)
        {
            //Catch 55 Medusa in Redcloud Marsh and take them to Nicolas.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110176, 509003, 2, 0, 509, 55, 509003);
            c.Player.quest.AddPack(110176, 508009, 508);
            return res;
        }
        public static byte Q110177(ConnectionInfo c, int QuestID)
        {
            //Talk with Olive.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 596565, 8000, 0, 7900);

            c.Player.quest.AddTaskAccept(110178, 508014, 508);
            return res;
        }
        public static byte A110177(ConnectionInfo c, int QuestID)
        {
            //Talk with Olive.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110177, 508014, 1, 1, 508);
            return res;
        }
        public static byte Q110178(ConnectionInfo c, int QuestID)
        {
            //Ask Raymond to extract some nectar from Rotten Flower.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 716943, 8500, 0, 7950);

            c.Player.quest.AddTaskAccept(110179, 508011, 508);
            return res;
        }
        public static byte A110178(ConnectionInfo c, int QuestID)
        {
            //Ask Raymond to extract some nectar from Rotten Flower.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110178, 508011, 1, 1, 508);
            return res;
        }
        public static byte Q110179(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Rotten Flowers in Redcloud Marsh and take them to Raymond.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1357785, 9000, 0, 7950);

            c.Player.quest.AddTaskAccept(110180, 508011, 508);
            return res;
        }
        public static byte A110179(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Rotten Flowers in Redcloud Marsh and take them to Raymond.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110179, 5010068, 4, 0, 509, 6, 509102);
            c.Player.quest.AddPack(110179, 508011, 508);
            return res;
        }
        public static byte Q110180(ConnectionInfo c, int QuestID)
        {
            //Take the Rotten Flower to Olive.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 813633, 9500, 0, 7950);

            c.Player.quest.AddTaskAccept(110181, 508014, 508);
            return res;
        }
        public static byte A110180(ConnectionInfo c, int QuestID)
        {
            //Take the Rotten Flower to Olive.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110180, 508014, 1, 1, 508);
            return res;
        }
        public static byte Q110181(ConnectionInfo c, int QuestID)
        {
            //Ask Olive about the whereabouts of the murderer.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 674129, 9000, 0, 7750);

            c.Player.quest.AddTaskAccept(110182, 508014, 508);
            return res;
        }
        public static byte A110181(ConnectionInfo c, int QuestID)
        {
            //Ask Olive about the whereabouts of the murderer.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110181, 508014, 1, 1, 508);
            return res;
        }
        public static byte Q110182(ConnectionInfo c, int QuestID)
        {
            //Go to Redcloud Marsh, ask Blair to help to find out the mark Olive left.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 720713, 8500, 0, 7750);

            c.Player.quest.AddTaskAccept(110183, 509004, 509);
            return res;
        }
        public static byte A110182(ConnectionInfo c, int QuestID)
        {
            //Go to Redcloud Marsh, ask Blair to help to find out the mark Olive left.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110182, 509004, 1, 1, 509);
            return res;
        }
        public static byte Q110183(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Carrions in Redcloud Marsh and then tell Blair.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1689946, 8000, 0, 7750);

            c.Player.quest.AddTaskAccept(110184, 509004, 509);
            return res;
        }
        public static byte A110183(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Carrions in Redcloud Marsh and then tell Blair.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110183, 509005, 2, 0, 509, 55, 509005);
            c.Player.quest.AddPack(110183, 509004, 509);
            return res;
        }
        public static byte Q110184(ConnectionInfo c, int QuestID)
        {
            //Destroy Giant Carrion in Redcloud Marsh, take back the box and then tell Blair.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1437846, 8500, 0, 6850);

            c.Player.quest.AddTaskAccept(110185, 509004, 509);
            return res;
        }
        public static byte A110184(ConnectionInfo c, int QuestID)
        {
            //Destroy Giant Carrion in Redcloud Marsh, take back the box and then tell Blair.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110184, 509007, 2, 0, 509, 1, 509007);
            c.Player.quest.AddPack(110184, 509004, 509);
            return res;
        }
        public static byte Q110185(ConnectionInfo c, int QuestID)
        {
            //Go to Pearl Village, take the box to Colby.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 416412, 7500, 0, 6850);

            c.Player.quest.AddTaskAccept(110186, 508006, 508);
            return res;
        }
        public static byte A110185(ConnectionInfo c, int QuestID)
        {
            //Go to Pearl Village, take the box to Colby.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110185, 508006, 1, 1, 508);
            return res;
        }
        public static byte Q110186(ConnectionInfo c, int QuestID)
        {
            //Take the box to Gregory to identify.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 496337, 7000, 0, 6850);

            c.Player.quest.AddTaskAccept(110187, 508007, 508);
            return res;
        }
        public static byte A110186(ConnectionInfo c, int QuestID)
        {
            //Take the box to Gregory to identify.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110186, 508007, 1, 1, 508);
            return res;
        }
        public static byte Q110187(ConnectionInfo c, int QuestID)
        {
            //Find Colby, let him make the final decision.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 439979, 8500, 0, 6850);

            c.Player.quest.AddTaskAccept(110188, 508006, 508);
            return res;
        }
        public static byte A110187(ConnectionInfo c, int QuestID)
        {
            //Find Colby, let him make the final decision.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110187, 508006, 1, 1, 508);
            return res;
        }
        public static byte Q110188(ConnectionInfo c, int QuestID)
        {
            //Go to the Lost City to meet Mario.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 498971, 9000, 0, 6850);

            c.Player.quest.AddTaskAccept(110189, 508006, 508);
            return res;
        }
        public static byte A110188(ConnectionInfo c, int QuestID)
        {
            //Go to the Lost City to meet Mario.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110188, 508006, 1, 1, 508);
            return res;
        }
        public static byte Q110189(ConnectionInfo c, int QuestID)
        {
            //Find Amos, ask him about the progress of excavation.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1167600, 8500, 0, 7250);

            c.Player.quest.AddTaskAccept(110190, 510007, 510);
            return res;
        }
        public static byte A110189(ConnectionInfo c, int QuestID)
        {
            //Find Amos, ask him about the progress of excavation.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110189, 510007, 1, 1, 510);
            return res;
        }
        public static byte Q110190(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Darkwind Wolves in Darkwind Canyon and bring them back to Amos.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1167600, 9000, 0, 7250);

            c.Player.quest.AddTaskAccept(110191, 510007, 510);
            return res;
        }
        public static byte A110190(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Darkwind Wolves in Darkwind Canyon and bring them back to Amos.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110190, 511001, 2, 0, 511, 60, 511001);
            c.Player.quest.AddPack(110190, 510007, 510);
            return res;
        }
        public static byte Q110191(ConnectionInfo c, int QuestID)
        {
            //Tell Veronica about Amos\' request.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1167600, 8000, 0, 7250);

            c.Player.quest.AddTaskAccept(110192, 510014, 510);
            return res;
        }
        public static byte A110191(ConnectionInfo c, int QuestID)
        {
            //Tell Veronica about Amos\' request.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110191, 510014, 1, 1, 510);
            return res;
        }
        public static byte Q110192(ConnectionInfo c, int QuestID)
        {
            //Take Haemin extracted by Veronica to Amos.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1241574, 8500, 0, 7000);

            c.Player.quest.AddTaskAccept(110193, 510007, 510);
            return res;
        }
        public static byte A110192(ConnectionInfo c, int QuestID)
        {
            //Take Haemin extracted by Veronica to Amos.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110192, 510007, 1, 1, 510);
            return res;
        }
        public static byte Q110193(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Darkwind Hunters in Darkwind Canyon and bring them back to Amos.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1241574, 9500, 0, 7000);

            c.Player.quest.AddTaskAccept(110194, 510007, 510);
            return res;
        }
        public static byte A110193(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Darkwind Hunters in Darkwind Canyon and bring them back to Amos.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110193, 511003, 2, 0, 511, 60, 511003);
            c.Player.quest.AddPack(110193, 510007, 510);
            return res;
        }
        public static byte Q110194(ConnectionInfo c, int QuestID)
        {
            //See Veronica, tell her Amos\' requirement and promise.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1241574, 9000, 0, 7000);

            c.Player.quest.AddTaskAccept(110195, 510014, 510);
            return res;
        }
        public static byte A110194(ConnectionInfo c, int QuestID)
        {
            //See Veronica, tell her Amos\' requirement and promise.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110194, 510014, 1, 1, 510);
            return res;
        }
        public static byte Q110195(ConnectionInfo c, int QuestID)
        {
            //Take Haemin extracted by Veronica to Amos.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 988869, 9700, 0, 6900);

            c.Player.quest.AddTaskAccept(110196, 510007, 510);
            return res;
        }
        public static byte A110195(ConnectionInfo c, int QuestID)
        {
            //Take Haemin extracted by Veronica to Amos.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110195, 510007, 1, 1, 510);
            return res;
        }
        public static byte Q110196(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Amos.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 988869, 9200, 0, 6900);

            c.Player.quest.AddTaskAccept(110197, 510007, 510);
            return res;
        }
        public static byte A110196(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Amos.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110196, 511005, 2, 0, 511, 60, 511005);
            c.Player.quest.AddPack(110196, 510007, 510);
            return res;
        }
        public static byte Q110197(ConnectionInfo c, int QuestID)
        {
            //See Jeffrey, ask him to come to Amos and discuss the reason of Lost City\'s decline.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 988869, 9500, 0, 6900);

            c.Player.quest.AddTaskAccept(110198, 510008, 510);
            return res;
        }
        public static byte A110197(ConnectionInfo c, int QuestID)
        {
            //See Jeffrey, ask him to come to Amos and discuss the reason of Lost City\'s decline.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110197, 510008, 1, 1, 510);
            return res;
        }
        public static byte Q110198(ConnectionInfo c, int QuestID)
        {
            //Ask Mario about the negligence of duty.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 988869, 9500, 0, 6900);

            c.Player.quest.AddTaskAccept(110199, 510005, 510);
            return res;
        }
        public static byte A110198(ConnectionInfo c, int QuestID)
        {
            //Ask Mario about the negligence of duty.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110198, 510005, 1, 1, 510);
            return res;
        }
        public static byte Q110199(ConnectionInfo c, int QuestID)
        {
            //Ask Omar to save Amos as soon as possible.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1398411, 9000, 0, 7350);

            c.Player.quest.AddTaskAccept(110200, 510009, 510);
            return res;
        }
        public static byte A110199(ConnectionInfo c, int QuestID)
        {
            //Ask Omar to save Amos as soon as possible.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110199, 510009, 1, 1, 510);
            return res;
        }
        public static byte Q110200(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Cruor Grasses in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1398411, 9500, 0, 7350);

            c.Player.quest.AddTaskAccept(110201, 510009, 510);
            return res;
        }
        public static byte A110200(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Cruor Grasses in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110200, 5010070, 4, 0, 511, 6, 511101);
            c.Player.quest.AddPack(110200, 510009, 510);
            return res;
        }
        public static byte Q110201(ConnectionInfo c, int QuestID)
        {
            //Ask Veronica to make purer Antidotes.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1398411, 9800, 0, 7350);

            c.Player.quest.AddTaskAccept(110202, 510014, 510);
            return res;
        }
        public static byte A110201(ConnectionInfo c, int QuestID)
        {
            //Ask Veronica to make purer Antidotes.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110201, 510014, 1, 1, 510);
            return res;
        }
        public static byte Q110202(ConnectionInfo c, int QuestID)
        {
            //See Omar, give him Veronica\'s Antidotes.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1481374, 9800, 0, 7200);

            c.Player.quest.AddTaskAccept(110203, 510009, 510);
            return res;
        }
        public static byte A110202(ConnectionInfo c, int QuestID)
        {
            //See Omar, give him Veronica\'s Antidotes.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110202, 510009, 1, 1, 510);
            return res;
        }
        public static byte Q110203(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1481374, 9750, 0, 7200);

            c.Player.quest.AddTaskAccept(110204, 510009, 510);
            return res;
        }
        public static byte A110203(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110203, 511005, 2, 0, 511, 60, 511005);
            c.Player.quest.AddPack(110203, 510009, 510);
            return res;
        }
        public static byte Q110204(ConnectionInfo c, int QuestID)
        {
            //Bring Alger the list of materials needed for holding Soul Ritual.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1481374, 9750, 0, 7200);

            c.Player.quest.AddTaskAccept(110205, 510006, 510);
            return res;
        }
        public static byte A110204(ConnectionInfo c, int QuestID)
        {
            //Bring Alger the list of materials needed for holding Soul Ritual.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110204, 510006, 1, 1, 510);
            return res;
        }
        public static byte Q110205(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Alger.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1567475, 9900, 0, 7500);

            c.Player.quest.AddTaskAccept(110206, 510006, 510);
            return res;
        }
        public static byte A110205(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Alger.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110205, 511001, 2, 0, 511, 65, 511001);
            c.Player.quest.AddPack(110205, 510006, 510);
            return res;
        }
        public static byte Q110206(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Alger.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1567475, 9900, 0, 7500);

            c.Player.quest.AddTaskAccept(110207, 510006, 510);
            return res;
        }
        public static byte A110206(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Alger.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110206, 511003, 2, 0, 511, 65, 511003);
            c.Player.quest.AddPack(110206, 510006, 510);
            return res;
        }
        public static byte Q110207(ConnectionInfo c, int QuestID)
        {
            //Catch 25 Canyon Eagles, 25 Stone Lizards, 25 Canyon Centaurs in Darkwind Canyon and bring them back to Alger.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1567475, 9500, 0, 7500);

            c.Player.quest.AddTaskAccept(110208, 510006, 510);
            return res;
        }
        public static byte A110207(ConnectionInfo c, int QuestID)
        {
            //Catch 25 Canyon Eagles, 25 Stone Lizards, 25 Canyon Centaurs in Darkwind Canyon and bring them back to Alger.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110207, 511002, 2, 0, 511, 25, 511002);
            c.Player.quest.AddTaskComplete(110207, 511004, 2, 0, 511, 25, 511004);
            c.Player.quest.AddTaskComplete(110207, 511005, 2, 0, 511, 25, 511005);
            c.Player.quest.AddPack(110207, 510006, 510);
            return res;
        }
        public static byte Q110208(ConnectionInfo c, int QuestID)
        {
            //Bring materials collected by Alger to Omar.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 994039, 9500, 0, 7300);

            c.Player.quest.AddTaskAccept(110209, 510009, 510);
            return res;
        }
        public static byte A110208(ConnectionInfo c, int QuestID)
        {
            //Bring materials collected by Alger to Omar.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110208, 510009, 1, 1, 510);
            return res;
        }
        public static byte Q110209(ConnectionInfo c, int QuestID)
        {
            //Ask Amos about the assassination.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 994039, 9500, 0, 7300);

            c.Player.quest.AddTaskAccept(110210, 510007, 510);
            return res;
        }
        public static byte A110209(ConnectionInfo c, int QuestID)
        {
            //Ask Amos about the assassination.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110209, 510007, 1, 1, 510);
            return res;
        }
        public static byte Q110210(ConnectionInfo c, int QuestID)
        {
            //Ask Theodore to catch the assassin.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 994039, 9650, 0, 7300);

            c.Player.quest.AddTaskAccept(110211, 510011, 510);
            return res;
        }
        public static byte A110210(ConnectionInfo c, int QuestID)
        {
            //Ask Theodore to catch the assassin.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110210, 510011, 1, 1, 510);
            return res;
        }
        public static byte Q110211(ConnectionInfo c, int QuestID)
        {
            //Find Angelo in Darkwind Canyon, asking him to catch the assassin as soon as possible.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 994039, 9650, 0, 7300);

            c.Player.quest.AddTaskAccept(110212, 511001, 511);
            return res;
        }
        public static byte A110211(ConnectionInfo c, int QuestID)
        {
            //Find Angelo in Darkwind Canyon, asking him to catch the assassin as soon as possible.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110211, 511001, 1, 1, 511);
            return res;
        }
        public static byte Q110212(ConnectionInfo c, int QuestID)
        {
            //Kill 1 Shadow Assassin in Darkwind Canyon and bring him back to Angelo.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 994039, 9650, 0, 7300);

            c.Player.quest.AddTaskAccept(110213, 511001, 511);
            return res;
        }
        public static byte A110212(ConnectionInfo c, int QuestID)
        {
            //Kill 1 Shadow Assassin in Darkwind Canyon and bring him back to Angelo.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110212, 511007, 2, 0, 511, 1, 511007);
            c.Player.quest.AddPack(110212, 511001, 511);
            return res;
        }
        public static byte Q110213(ConnectionInfo c, int QuestID)
        {
            //Ask Tiffany how to restore Amos\' memory.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1749214, 9400, 0, 7400);

            c.Player.quest.AddTaskAccept(110214, 510013, 510);
            return res;
        }
        public static byte A110213(ConnectionInfo c, int QuestID)
        {
            //Ask Tiffany how to restore Amos\' memory.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110213, 510013, 1, 1, 510);
            return res;
        }
        public static byte Q110214(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Hyacinth from Darkwind Canyon and bring them back to Tiffany.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1749214, 9400, 0, 7400);

            c.Player.quest.AddTaskAccept(110215, 510013, 510);
            return res;
        }
        public static byte A110214(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Hyacinth from Darkwind Canyon and bring them back to Tiffany.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110214, 5010071, 4, 0, 511, 6, 511102);
            c.Player.quest.AddPack(110214, 510013, 510);
            return res;
        }
        public static byte Q110215(ConnectionInfo c, int QuestID)
        {
            //Bring the Potion of Time made by Tiffany to Amos.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1749214, 9400, 0, 7400);

            c.Player.quest.AddTaskAccept(110216, 510007, 510);
            return res;
        }
        public static byte A110215(ConnectionInfo c, int QuestID)
        {
            //Bring the Potion of Time made by Tiffany to Amos.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110215, 510007, 1, 1, 510);
            return res;
        }
        public static byte Q110216(ConnectionInfo c, int QuestID)
        {
            //Tell Mario what Amos has found, ask him to report that to the capital.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1844976, 9800, 0, 7450);

            c.Player.quest.AddTaskAccept(110217, 510005, 510);
            return res;
        }
        public static byte A110216(ConnectionInfo c, int QuestID)
        {
            //Tell Mario what Amos has found, ask him to report that to the capital.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110216, 510005, 1, 1, 510);
            return res;
        }
        public static byte Q110217(ConnectionInfo c, int QuestID)
        {
            //Find Stanley, ask him to summon the souls of the dead assassin.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1844976, 9800, 0, 7450);

            c.Player.quest.AddTaskAccept(110218, 510012, 510);
            return res;
        }
        public static byte A110217(ConnectionInfo c, int QuestID)
        {
            //Find Stanley, ask him to summon the souls of the dead assassin.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110217, 510012, 1, 1, 510);
            return res;
        }
        public static byte Q110218(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Canyon Centaurs in Darkwind Canyon and bring them back to Stanley.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1844976, 9800, 0, 7450);

            c.Player.quest.AddTaskAccept(110219, 510012, 510);
            return res;
        }
        public static byte A110218(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Canyon Centaurs in Darkwind Canyon and bring them back to Stanley.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110218, 511005, 2, 0, 511, 65, 511005);
            c.Player.quest.AddPack(110218, 510012, 510);
            return res;
        }
        public static byte Q110219(ConnectionInfo c, int QuestID)
        {
            //Tell Mario about Stanley\'s finding.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1944075, 9900, 0, 7650);

            c.Player.quest.AddTaskAccept(110220, 510005, 510);
            return res;
        }
        public static byte A110219(ConnectionInfo c, int QuestID)
        {
            //Tell Mario about Stanley\'s finding.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110219, 510005, 1, 1, 510);
            return res;
        }
        public static byte Q110220(ConnectionInfo c, int QuestID)
        {
            //Catch 3 Head Centaurs in Darkwind Canyon and bring them back to Mario.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1944075, 9900, 0, 7650);

            c.Player.quest.AddTaskAccept(110221, 510005, 510);
            return res;
        }
        public static byte A110220(ConnectionInfo c, int QuestID)
        {
            //Catch 3 Head Centaurs in Darkwind Canyon and bring them back to Mario.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110220, 511006, 2, 0, 511, 3, 511006);
            c.Player.quest.AddPack(110220, 510005, 510);
            return res;
        }
        public static byte Q110221(ConnectionInfo c, int QuestID)
        {
            //Enter Dark Castle, contact Burnell.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1944075, 9900, 0, 7500);

            c.Player.quest.AddTaskAccept(110222, 510005, 510);
            return res;
        }
        public static byte A110221(ConnectionInfo c, int QuestID)
        {
            //Enter Dark Castle, contact Burnell.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110221, 510005, 1, 1, 510);
            return res;
        }
        public static byte Q110222(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman about the dagger.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2046567, 10000, 0, 7500);

            c.Player.quest.AddTaskAccept(110223, 512008, 512);
            return res;
        }
        public static byte A110222(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman about the dagger.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110222, 512008, 1, 1, 512);
            return res;
        }
        public static byte Q110223(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Bears in Foggy Forest and then tell Jabman.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2046567, 10000, 0, 7500);

            c.Player.quest.AddTaskAccept(110224, 512008, 512);
            return res;
        }
        public static byte A110223(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Bears in Foggy Forest and then tell Jabman.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110223, 513003, 2, 0, 513, 70, 513003);
            c.Player.quest.AddPack(110223, 512008, 512);
            return res;
        }
        public static byte Q110224(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Vampires in Foggy Forest and then tell Jabman.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2046567, 10000, 0, 7500);

            c.Player.quest.AddTaskAccept(110225, 512008, 512);
            return res;
        }
        public static byte A110224(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Vampires in Foggy Forest and then tell Jabman.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110224, 513001, 2, 0, 513, 70, 513001);
            c.Player.quest.AddPack(110224, 512008, 512);
            return res;
        }
        public static byte Q110225(ConnectionInfo c, int QuestID)
        {
            //Find Claymond, ask him what usual things have happened recently.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2152507, 10500, 0, 7600);

            c.Player.quest.AddTaskAccept(110226, 512009, 512);
            return res;
        }
        public static byte A110225(ConnectionInfo c, int QuestID)
        {
            //Find Claymond, ask him what usual things have happened recently.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110225, 512009, 1, 1, 512);
            return res;
        }
        public static byte Q110226(ConnectionInfo c, int QuestID)
        {
            //Find Xaviera, asking her to try to find some Light of Life.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2152507, 10500, 0, 7600);

            c.Player.quest.AddTaskAccept(110227, 512013, 512);
            return res;
        }
        public static byte A110226(ConnectionInfo c, int QuestID)
        {
            //Find Xaviera, asking her to try to find some Light of Life.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110226, 512013, 1, 1, 512);
            return res;
        }
        public static byte Q110227(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Berserk Warriors in Foggy Forest and then find Xaviera.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2152507, 10500, 0, 7600);

            c.Player.quest.AddTaskAccept(110228, 512013, 512);
            return res;
        }
        public static byte A110227(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Berserk Warriors in Foggy Forest and then find Xaviera.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110227, 513004, 2, 0, 513, 70, 513004);
            c.Player.quest.AddPack(110227, 512013, 512);
            return res;
        }
        public static byte Q110228(ConnectionInfo c, int QuestID)
        {
            //Find Hiddrick, asking him where the World Tree\'s seed is.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2261952, 10650, 0, 7700);

            c.Player.quest.AddTaskAccept(110229, 512007, 512);
            return res;
        }
        public static byte A110228(ConnectionInfo c, int QuestID)
        {
            //Find Hiddrick, asking him where the World Tree\'s seed is.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110228, 512007, 1, 1, 512);
            return res;
        }
        public static byte Q110229(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman for Tree of Life\'s seed.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2261952, 10650, 0, 7700);

            c.Player.quest.AddTaskAccept(110230, 512008, 512);
            return res;
        }
        public static byte A110229(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman for Tree of Life\'s seed.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110229, 512008, 1, 1, 512);
            return res;
        }
        public static byte Q110230(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Dawn Elves in Foggy Forest and then find Jabman.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2261952, 10650, 0, 7700);

            c.Player.quest.AddTaskAccept(110231, 512008, 512);
            return res;
        }
        public static byte A110230(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Dawn Elves in Foggy Forest and then find Jabman.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110230, 513005, 2, 0, 513, 70, 513005);
            c.Player.quest.AddPack(110230, 512008, 512);
            return res;
        }
        public static byte Q110231(ConnectionInfo c, int QuestID)
        {
            //Bring the Light of Life to Claymond.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1781218, 10880, 0, 7750);

            c.Player.quest.AddTaskAccept(110232, 512009, 512);
            return res;
        }
        public static byte A110231(ConnectionInfo c, int QuestID)
        {
            //Bring the Light of Life to Claymond.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110231, 512009, 1, 1, 512);
            return res;
        }
        public static byte Q110232(ConnectionInfo c, int QuestID)
        {
            //Ask Cyril about the history of Dark Castle.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1781218, 10880, 0, 7750);

            c.Player.quest.AddTaskAccept(110233, 512010, 512);
            return res;
        }
        public static byte A110232(ConnectionInfo c, int QuestID)
        {
            //Ask Cyril about the history of Dark Castle.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110232, 512010, 1, 1, 512);
            return res;
        }
        public static byte Q110233(ConnectionInfo c, int QuestID)
        {
            //Find Zelene, listen to him talk about what happened next.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1781218, 10880, 0, 7750);

            c.Player.quest.AddTaskAccept(110234, 512012, 512);
            return res;
        }
        public static byte A110233(ConnectionInfo c, int QuestID)
        {
            //Find Zelene, listen to him talk about what happened next.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110233, 512012, 1, 1, 512);
            return res;
        }
        public static byte Q110234(ConnectionInfo c, int QuestID)
        {
            //Find Claymond, listen to him talk about what happened next.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1781218, 10880, 0, 7750);

            c.Player.quest.AddTaskAccept(110235, 512009, 512);
            return res;
        }
        public static byte A110234(ConnectionInfo c, int QuestID)
        {
            //Find Claymond, listen to him talk about what happened next.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110234, 512009, 1, 1, 512);
            return res;
        }
        public static byte Q110235(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Berserk Warriors in Foggy Forest, then go back and tell Claymond.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2491580, 10500, 0, 7670);

            c.Player.quest.AddTaskAccept(110236, 512009, 512);
            return res;
        }
        public static byte A110235(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Berserk Warriors in Foggy Forest, then go back and tell Claymond.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110235, 513004, 2, 0, 513, 70, 513004);
            c.Player.quest.AddPack(110235, 512009, 512);
            return res;
        }
        public static byte Q110236(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Dawn Elves in Foggy Forest, then go back and tell Claymond.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2491580, 10500, 0, 7670);

            c.Player.quest.AddTaskAccept(110237, 512009, 512);
            return res;
        }
        public static byte A110236(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Dawn Elves in Foggy Forest, then go back and tell Claymond.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110236, 513005, 2, 0, 513, 70, 513005);
            c.Player.quest.AddPack(110236, 512009, 512);
            return res;
        }
        public static byte Q110237(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Foggy Roses in Foggy Forest and bring them back to Claymond.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2491580, 10500, 0, 7670);

            c.Player.quest.AddTaskAccept(110238, 512009, 512);
            return res;
        }
        public static byte A110237(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Foggy Roses in Foggy Forest and bring them back to Claymond.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110237, 5010072, 4, 0, 513, 6, 513101);
            c.Player.quest.AddPack(110237, 512009, 512);
            return res;
        }
        public static byte Q110238(ConnectionInfo c, int QuestID)
        {
            //Tell Cesar about Claymond\'s instructions.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2611875, 11000, 0, 7770);

            c.Player.quest.AddTaskAccept(110239, 512006, 512);
            return res;
        }
        public static byte A110238(ConnectionInfo c, int QuestID)
        {
            //Tell Cesar about Claymond\'s instructions.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110238, 512006, 1, 1, 512);
            return res;
        }
        public static byte Q110239(ConnectionInfo c, int QuestID)
        {
            //Ask Yuna who\'s been to Seal Room recently.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2611875, 11000, 0, 7770);

            c.Player.quest.AddTaskAccept(110240, 512014, 512);
            return res;
        }
        public static byte A110239(ConnectionInfo c, int QuestID)
        {
            //Ask Yuna who\'s been to Seal Room recently.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110239, 512014, 1, 1, 512);
            return res;
        }
        public static byte Q110240(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Foggy Spiders in Foggy Forest and bring them back to Yuna.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2611875, 11000, 0, 7770);

            c.Player.quest.AddTaskAccept(110241, 512014, 512);
            return res;
        }
        public static byte A110240(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Foggy Spiders in Foggy Forest and bring them back to Yuna.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110240, 513002, 2, 0, 513, 75, 513002);
            c.Player.quest.AddPack(110240, 512014, 512);
            return res;
        }
        public static byte Q110241(ConnectionInfo c, int QuestID)
        {
            //Find Dark in Foggy Forest and ask him about Riel\'s trend.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2735899, 11500, 0, 7800);

            c.Player.quest.AddTaskAccept(110242, 513003, 513);
            return res;
        }
        public static byte A110241(ConnectionInfo c, int QuestID)
        {
            //Find Dark in Foggy Forest and ask him about Riel\'s trend.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110241, 513003, 1, 1, 513);
            return res;
        }
        public static byte Q110242(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Dawn Elves in Foggy Forest and bring them back to Dark.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2735899, 11500, 0, 7800);

            c.Player.quest.AddTaskAccept(110243, 513003, 513);
            return res;
        }
        public static byte A110242(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Dawn Elves in Foggy Forest and bring them back to Dark.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110242, 513005, 2, 0, 513, 75, 513005);
            c.Player.quest.AddPack(110242, 513003, 513);
            return res;
        }
        public static byte Q110243(ConnectionInfo c, int QuestID)
        {
            //Tell Dark Castle\'s Claymond the information Dark has learnt.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2735899, 11500, 0, 7800);

            c.Player.quest.AddTaskAccept(110244, 512009, 512);
            return res;
        }
        public static byte A110243(ConnectionInfo c, int QuestID)
        {
            //Tell Dark Castle\'s Claymond the information Dark has learnt.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110243, 512009, 1, 1, 512);
            return res;
        }
        public static byte Q110244(ConnectionInfo c, int QuestID)
        {
            //Go to Foggy Forest Wind Rider Rita， Blade of Light。
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2863707, 11650, 0, 7830);

            c.Player.quest.AddTaskAccept(110245, 512009, 512);
            return res;
        }
        public static byte A110244(ConnectionInfo c, int QuestID)
        {
            //Go to Foggy Forest Wind Rider Rita， Blade of Light。
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110244, 513007, 2, 0, 513, 1, 513007);
            c.Player.quest.AddPack(110244, 512009, 512);
            return res;
        }
        public static byte Q110245(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman if there\'s any remedy.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2863707, 11650, 0, 7830);

            c.Player.quest.AddTaskAccept(110246, 512008, 512);
            return res;
        }
        public static byte A110245(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman if there\'s any remedy.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110245, 512008, 1, 1, 512);
            return res;
        }
        public static byte Q110246(ConnectionInfo c, int QuestID)
        {
            //Find Candice, tell her Jabman\'s demand.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2863707, 11650, 0, 7830);

            c.Player.quest.AddTaskAccept(110247, 513005, 513);
            return res;
        }
        public static byte A110246(ConnectionInfo c, int QuestID)
        {
            //Find Candice, tell her Jabman\'s demand.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110246, 513005, 1, 1, 513);
            return res;
        }
        public static byte Q110247(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Blood Mosses in Foggy Forest and bring them back to Candice.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2995356, 11880, 0, 7850);

            c.Player.quest.AddTaskAccept(110248, 513005, 513);
            return res;
        }
        public static byte A110247(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Blood Mosses in Foggy Forest and bring them back to Candice.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110247, 5010073, 4, 0, 513, 6, 513102);
            c.Player.quest.AddPack(110247, 513005, 513);
            return res;
        }
        public static byte Q110248(ConnectionInfo c, int QuestID)
        {
            //Bring Deadsoul Potion mae by Candice to Parker.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2995356, 11880, 0, 7850);

            c.Player.quest.AddTaskAccept(110249, 513002, 513);
            return res;
        }
        public static byte A110248(ConnectionInfo c, int QuestID)
        {
            //Bring Deadsoul Potion mae by Candice to Parker.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110248, 513002, 1, 1, 513);
            return res;
        }
        public static byte Q110249(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Berserk Warriors in Foggy Forest and bring them back to Parker.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2995356, 11880, 0, 7850);

            c.Player.quest.AddTaskAccept(110250, 513002, 513);
            return res;
        }
        public static byte A110249(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Berserk Warriors in Foggy Forest and bring them back to Parker.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110249, 513004, 2, 0, 513, 75, 513004);
            c.Player.quest.AddPack(110249, 513002, 513);
            return res;
        }
        public static byte Q110250(ConnectionInfo c, int QuestID)
        {
            //Bring the Chaos Crystal extracted by Candice to Jabman.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2348176, 12000, 0, 7900);

            c.Player.quest.AddTaskAccept(110251, 512008, 512);
            return res;
        }
        public static byte A110250(ConnectionInfo c, int QuestID)
        {
            //Bring the Chaos Crystal extracted by Candice to Jabman.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110250, 512008, 1, 1, 512);
            return res;
        }
        public static byte Q110251(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks in Foggy Forest and then tell Jabman.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2348176, 12000, 0, 7900);

            c.Player.quest.AddTaskAccept(110252, 512008, 512);
            return res;
        }
        public static byte A110251(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks in Foggy Forest and then tell Jabman.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110251, 513006, 2, 0, 513, 5, 513006);
            c.Player.quest.AddPack(110251, 512008, 512);
            return res;
        }
        public static byte Q110252(ConnectionInfo c, int QuestID)
        {
            //Find Burnell, tell him about Jabman\'s words.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2348176, 12000, 0, 7900);

            c.Player.quest.AddTaskAccept(110253, 512005, 512);
            return res;
        }
        public static byte A110252(ConnectionInfo c, int QuestID)
        {
            //Find Burnell, tell him about Jabman\'s words.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110252, 512005, 1, 1, 512);
            return res;
        }
        public static byte Q110253(ConnectionInfo c, int QuestID)
        {
            //Go to Henan Mountain, contact Burnell.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2348176, 12000, 0, 7900);

            c.Player.quest.AddTaskAccept(110254, 514005, 514);
            return res;
        }
        public static byte A110253(ConnectionInfo c, int QuestID)
        {
            //Go to Henan Mountain, contact Burnell.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110253, 514005, 1, 1, 514);
            return res;
        }
        public static byte Q110254(ConnectionInfo c, int QuestID)
        {
            //Ask Herman about what to do next for Harold.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3270400, 12500, 0, 7900);

            c.Player.quest.AddTaskAccept(110255, 514006, 514);
            return res;
        }
        public static byte A110254(ConnectionInfo c, int QuestID)
        {
            //Ask Herman about what to do next for Harold.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110254, 514006, 1, 1, 514);
            return res;
        }
        public static byte Q110255(ConnectionInfo c, int QuestID)
        {
            //Find Sigrid and ask him to save the unconscious advance agent.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3270400, 12500, 0, 7900);

            c.Player.quest.AddTaskAccept(110256, 514013, 514);
            return res;
        }
        public static byte A110255(ConnectionInfo c, int QuestID)
        {
            //Find Sigrid and ask him to save the unconscious advance agent.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110255, 514013, 1, 1, 514);
            return res;
        }
        public static byte Q110256(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Carefree Beasts in the Henan Mountainside, and bring them to Sigrid.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3270400, 12500, 0, 7900);

            c.Player.quest.AddTaskAccept(110257, 514013, 514);
            return res;
        }
        public static byte A110256(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Carefree Beasts in the Henan Mountainside, and bring them to Sigrid.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110256, 515004, 2, 0, 515, 80, 515004);
            c.Player.quest.AddPack(110256, 514013, 514);
            return res;
        }
        public static byte Q110257(ConnectionInfo c, int QuestID)
        {
            //Find Jeremy and ask him about the way to remove the Blessing Mark of Lord of Oracle
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3413907, 13000, 0, 8000);

            c.Player.quest.AddTaskAccept(110258, 514009, 514);
            return res;
        }
        public static byte A110257(ConnectionInfo c, int QuestID)
        {
            //Find Jeremy and ask him about the way to remove the Blessing Mark of Lord of Oracle
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110257, 514009, 1, 1, 514);
            return res;
        }
        public static byte Q110258(ConnectionInfo c, int QuestID)
        {
            //Tell Sigrid Jeremy\'s words.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3413907, 13000, 0, 8000);

            c.Player.quest.AddTaskAccept(110259, 514013, 514);
            return res;
        }
        public static byte A110258(ConnectionInfo c, int QuestID)
        {
            //Tell Sigrid Jeremy\'s words.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110258, 514013, 1, 1, 514);
            return res;
        }
        public static byte Q110259(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Despair Herbs on the Henan Mountainside and give them to Sigrid.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3413907, 13000, 0, 8000);

            c.Player.quest.AddTaskAccept(110260, 514013, 514);
            return res;
        }
        public static byte A110259(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Despair Herbs on the Henan Mountainside and give them to Sigrid.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110259, 5010074, 4, 0, 515, 6, 515101);
            c.Player.quest.AddPack(110259, 514013, 514);
            return res;
        }
        public static byte Q110260(ConnectionInfo c, int QuestID)
        {
            //Bring the advance agent that saved by Sigrid to Herman.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3561478, 12850, 0, 8100);

            c.Player.quest.AddTaskAccept(110261, 514006, 514);
            return res;
        }
        public static byte A110260(ConnectionInfo c, int QuestID)
        {
            //Bring the advance agent that saved by Sigrid to Herman.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110260, 514006, 1, 1, 514);
            return res;
        }
        public static byte Q110261(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Spirit Dragons on the Henan Mountainside, and bring them to Herman.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3561478, 12850, 0, 8100);

            c.Player.quest.AddTaskAccept(110262, 514006, 514);
            return res;
        }
        public static byte A110261(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Spirit Dragons on the Henan Mountainside, and bring them to Herman.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110261, 515001, 2, 0, 515, 80, 515001);
            c.Player.quest.AddPack(110261, 514006, 514);
            return res;
        }
        public static byte Q110262(ConnectionInfo c, int QuestID)
        {
            //Find Kelly and ask her to break the Circle of Memory Sealing.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3561478, 12582, 0, 8100);

            c.Player.quest.AddTaskAccept(110263, 514011, 514);
            return res;
        }
        public static byte A110262(ConnectionInfo c, int QuestID)
        {
            //Find Kelly and ask her to break the Circle of Memory Sealing.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110262, 514011, 1, 1, 514);
            return res;
        }
        public static byte Q110263(ConnectionInfo c, int QuestID)
        {
            //Find Sigrid and ask her for a Imaging Restore Potion.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3713171, 13500, 0, 8500);

            c.Player.quest.AddTaskAccept(110264, 514013, 514);
            return res;
        }
        public static byte A110263(ConnectionInfo c, int QuestID)
        {
            //Find Sigrid and ask her for a Imaging Restore Potion.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110263, 514013, 1, 1, 514);
            return res;
        }
        public static byte Q110264(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Spirit Dragons on the Henan Mountainside, and bring them to Sigrid.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3713171, 13500, 0, 8500);

            c.Player.quest.AddTaskAccept(110265, 514013, 514);
            return res;
        }
        public static byte A110264(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Spirit Dragons on the Henan Mountainside, and bring them to Sigrid.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110264, 515001, 2, 0, 515, 80, 515001);
            c.Player.quest.AddPack(110264, 514013, 514);
            return res;
        }
        public static byte Q110265(ConnectionInfo c, int QuestID)
        {
            //Find Renee and ask her to refine the Magic Elements in the Spirit Dragons.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 3713171, 12950, 0, 8500);

            c.Player.quest.AddTaskAccept(110266, 514014, 514);
            return res;
        }
        public static byte A110265(ConnectionInfo c, int QuestID)
        {
            //Find Renee and ask her to refine the Magic Elements in the Spirit Dragons.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110265, 514014, 1, 1, 514);
            return res;
        }
        public static byte Q110266(ConnectionInfo c, int QuestID)
        {
            //Give the refined Magic Elements to Sigrid.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2901780, 12950, 0, 8100);

            c.Player.quest.AddTaskAccept(110267, 514013, 514);
            return res;
        }
        public static byte A110266(ConnectionInfo c, int QuestID)
        {
            //Give the refined Magic Elements to Sigrid.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110266, 514013, 1, 1, 514);
            return res;
        }
        public static byte Q110267(ConnectionInfo c, int QuestID)
        {
            //Find Eunice and ask her about the way of increasing the density of the Magic Elements.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2901780, 12950, 0, 8100);

            c.Player.quest.AddTaskAccept(110268, 515005, 515);
            return res;
        }
        public static byte A110267(ConnectionInfo c, int QuestID)
        {
            //Find Eunice and ask her about the way of increasing the density of the Magic Elements.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110267, 515005, 1, 1, 515);
            return res;
        }
        public static byte Q110268(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Silver Mines on the Henan Mountainside and give them to Eunice.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2901780, 12950, 0, 8100);

            c.Player.quest.AddTaskAccept(110269, 515005, 515);
            return res;
        }
        public static byte A110268(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Silver Mines on the Henan Mountainside and give them to Eunice.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110268, 5010075, 4, 0, 515, 6, 515102);
            c.Player.quest.AddPack(110268, 515005, 515);
            return res;
        }
        public static byte Q110269(ConnectionInfo c, int QuestID)
        {
            //Give the refined Silver Mine to Sigrid.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2901780, 13550, 0, 8150);

            c.Player.quest.AddTaskAccept(110270, 514013, 514);
            return res;
        }
        public static byte A110269(ConnectionInfo c, int QuestID)
        {
            //Give the refined Silver Mine to Sigrid.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110269, 514013, 1, 1, 514);
            return res;
        }
        public static byte Q110270(ConnectionInfo c, int QuestID)
        {
            //Give the configured Imaging Restore Potion to Sigrid.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4029141, 13560, 0, 8150);

            c.Player.quest.AddTaskAccept(110271, 514011, 514);
            return res;
        }
        public static byte A110270(ConnectionInfo c, int QuestID)
        {
            //Give the configured Imaging Restore Potion to Sigrid.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110270, 514011, 1, 1, 514);
            return res;
        }
        public static byte Q110271(ConnectionInfo c, int QuestID)
        {
            //Kill 85 Lost Acolytes on the Henan Mountainside then go back and tell tell Kelly.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4029141, 14150, 0, 8150);

            c.Player.quest.AddTaskAccept(110272, 514011, 514);
            return res;
        }
        public static byte A110271(ConnectionInfo c, int QuestID)
        {
            //Kill 85 Lost Acolytes on the Henan Mountainside then go back and tell tell Kelly.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110271, 515002, 2, 0, 515, 85, 515002);
            c.Player.quest.AddPack(110271, 514011, 514);
            return res;
        }
        public static byte Q110272(ConnectionInfo c, int QuestID)
        {
            //Tell Herman Kelly\'s discovery.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4029141, 13450, 0, 8150);

            c.Player.quest.AddTaskAccept(110273, 514006, 514);
            return res;
        }
        public static byte A110272(ConnectionInfo c, int QuestID)
        {
            //Tell Herman Kelly\'s discovery.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110272, 514006, 1, 1, 514);
            return res;
        }
        public static byte Q110273(ConnectionInfo c, int QuestID)
        {
            //Tell Mitchell Herman\'s request.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4193532, 14550, 0, 8000);

            c.Player.quest.AddTaskAccept(110274, 515003, 515);
            return res;
        }
        public static byte A110273(ConnectionInfo c, int QuestID)
        {
            //Tell Mitchell Herman\'s request.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110273, 515003, 1, 1, 515);
            return res;
        }
        public static byte Q110274(ConnectionInfo c, int QuestID)
        {
            //Tell Eunice Mitchell\'s request.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4193532, 14550, 0, 8000);

            c.Player.quest.AddTaskAccept(110275, 515005, 515);
            return res;
        }
        public static byte A110274(ConnectionInfo c, int QuestID)
        {
            //Tell Eunice Mitchell\'s request.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110274, 515005, 1, 1, 515);
            return res;
        }
        public static byte Q110275(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Carefree Beasts and 50 Bubble Beasts on Henan Mountainside and bring them to Eunice.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4193532, 14800, 0, 8000);

            c.Player.quest.AddTaskAccept(110276, 515005, 515);
            return res;
        }
        public static byte A110275(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Carefree Beasts and 50 Bubble Beasts on Henan Mountainside and bring them to Eunice.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110275, 515004, 2, 0, 515, 50, 515004);
            c.Player.quest.AddTaskComplete(110275, 515005, 2, 0, 515, 50, 515005);
            c.Player.quest.AddPack(110275, 515005, 515);
            return res;
        }
        public static byte Q110276(ConnectionInfo c, int QuestID)
        {
            //Tell Mitchell Eunice\'s discovery.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4362267, 14800, 0, 8200);

            c.Player.quest.AddTaskAccept(110277, 515003, 515);
            return res;
        }
        public static byte A110276(ConnectionInfo c, int QuestID)
        {
            //Tell Mitchell Eunice\'s discovery.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110276, 515003, 1, 1, 515);
            return res;
        }
        public static byte Q110277(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Bubble Beasts on Henan Mountainside and bring them to Mitchell.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4362267, 14800, 0, 8200);

            c.Player.quest.AddTaskAccept(110278, 515003, 515);
            return res;
        }
        public static byte A110277(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Bubble Beasts on Henan Mountainside and bring them to Mitchell.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110277, 515005, 2, 0, 515, 85, 515005);
            c.Player.quest.AddPack(110277, 515003, 515);
            return res;
        }
        public static byte Q110278(ConnectionInfo c, int QuestID)
        {
            //Give the Track Potion made by Mitchell to Herman.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4362267, 14200, 0, 8300);

            c.Player.quest.AddTaskAccept(110279, 514006, 514);
            return res;
        }
        public static byte A110278(ConnectionInfo c, int QuestID)
        {
            //Give the Track Potion made by Mitchell to Herman.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110278, 514006, 1, 1, 514);
            return res;
        }
        public static byte Q110279(ConnectionInfo c, int QuestID)
        {
            //Defeat the Guarder Sissi on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4535402, 14200, 0, 8300);

            c.Player.quest.AddTaskAccept(110280, 514006, 514);
            return res;
        }
        public static byte A110279(ConnectionInfo c, int QuestID)
        {
            //Defeat the Guarder Sissi on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110279, 514006, 1, 1, 514);
            return res;
        }
        public static byte Q110280(ConnectionInfo c, int QuestID)
        {
            //Ask Jared about the way to defeat Guarder Sissi for Herman.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4535402, 14200, 0, 8300);

            c.Player.quest.AddTaskAccept(110281, 514008, 514);
            return res;
        }
        public static byte A110280(ConnectionInfo c, int QuestID)
        {
            //Ask Jared about the way to defeat Guarder Sissi for Herman.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110280, 514008, 1, 1, 514);
            return res;
        }
        public static byte Q110281(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Skyish Beasts and 50 Dark Carefree Beast on the Henan Mountainside then bring them to Jared.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4535402, 14600, 0, 8450);

            c.Player.quest.AddTaskAccept(110282, 514008, 514);
            return res;
        }
        public static byte A110281(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Skyish Beasts and 50 Dark Carefree Beast on the Henan Mountainside then bring them to Jared.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110281, 515003, 2, 0, 515, 50, 515003);
            c.Player.quest.AddTaskComplete(110281, 515006, 2, 0, 515, 50, 515006);
            c.Player.quest.AddPack(110281, 514008, 514);
            return res;
        }
        public static byte Q110282(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Guarder Sissi on the Henan Mountainside then go back and tell Jared.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4712995, 14600, 0, 8450);

            c.Player.quest.AddTaskAccept(110283, 514008, 514);
            return res;
        }
        public static byte A110282(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Guarder Sissi on the Henan Mountainside then go back and tell Jared.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110282, 515007, 2, 0, 515, 10, 515007);
            c.Player.quest.AddPack(110282, 514008, 514);
            return res;
        }
        public static byte Q110283(ConnectionInfo c, int QuestID)
        {
            //Tell Herman Jared\'s suggestion.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4712995, 15000, 0, 8500);

            c.Player.quest.AddTaskAccept(110284, 514006, 514);
            return res;
        }
        public static byte A110283(ConnectionInfo c, int QuestID)
        {
            //Tell Herman Jared\'s suggestion.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110283, 514006, 1, 1, 514);
            return res;
        }
        public static byte Q110284(ConnectionInfo c, int QuestID)
        {
            //Go to Peak of the World and contact Herman.
            if (QuestCommand.CanQuest(c, 90)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 4712995, 15000, 0, 8500);
            return res;
        }
        public static byte A110284(ConnectionInfo c, int QuestID)
        {
            //Go to Peak of the World and contact Herman.
            if (QuestCommand.CanQuest(c, 90)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(110284, 514006, 1, 1, 514);
            return res;
        }
        public static byte Q111001(ConnectionInfo c, int QuestID)
        {
            //Find Old Blacksmith, get the gift from the Old Blacksmith.
            if (QuestCommand.CanQuest(c, 11)) return 3;
            byte res = 1;

            res = QuestReward.R111001(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 13826, 1000, 0, 41);

            c.Player.quest.AddTaskAccept(111004, 301016, 301);
            return res;
        }
        public static byte A111001(ConnectionInfo c, int QuestID)
        {
            //Find Old Blacksmith, get the gift from the Old Blacksmith.
            if (QuestCommand.CanQuest(c, 11)) return 3;
            byte res = 1;
            switch (c.Player.role.faction)
            {
                case 1:
                    c.Player.quest.AddTaskComplete(113001, 201016, 1, 1, 201);
                    break;

                case 2:
                    c.Player.quest.AddTaskComplete(111001, 301016, 1, 1, 301);
                    break;
                case 3:
                    c.Player.quest.AddTaskComplete(112001, 401016, 1, 1, 401);
                    break;
            }
            return res;
        }
        public static byte Q111004(ConnectionInfo c, int QuestID)
        {
            //Learn new skill from Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R111004(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 4940, 300, 0, 12);

            c.Player.quest.AddTaskAccept(111006, 301012, 301);
            return res;
        }
        public static byte A111004(ConnectionInfo c, int QuestID)
        {
            //Learn new skill from Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(111004, 301012, 1, 1, 301);
            return res;
        }
        public static byte Q111006(ConnectionInfo c, int QuestID)
        {
            //Get a better weapon from the Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R111006(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 4766, 350, 0, 12);

            c.Player.quest.AddTaskAccept(111008, 301012, 301);
            return res;
        }
        public static byte A111006(ConnectionInfo c, int QuestID)
        {
            //Get a better weapon from the Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(111006, 301012, 1, 1, 301);
            return res;
        }
        public static byte Q111008(ConnectionInfo c, int QuestID)
        {
            //Ask Grocer for some Teleport Scrolls.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R111008(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 5059, 300, 0, 15);

            c.Player.quest.AddTaskAccept(111010, 301018, 301);
            return res;
        }
        public static byte A111008(ConnectionInfo c, int QuestID)
        {
            //Ask Grocer for some Teleport Scrolls.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(111008, 301018, 1, 1, 301);
            return res;
        }
        public static byte Q111010(ConnectionInfo c, int QuestID)
        {
            //Get a better magic cloth from the Tailor.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R111010(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 3125, 150, 0, 7);

            c.Player.quest.AddTaskAccept(111011, 301024, 301);
            return res;
        }
        public static byte A111010(ConnectionInfo c, int QuestID)
        {
            //Get a better magic cloth from the Tailor.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(111010, 301024, 1, 1, 301);
            return res;
        }
        public static byte Q111011(ConnectionInfo c, int QuestID)
        {
            //Go to see the Stargazer and get to know your horoscopes.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 6336, 300, 0, 15);

            c.Player.quest.AddTaskAccept(111012, 301010, 301);
            return res;
        }
        public static byte A111011(ConnectionInfo c, int QuestID)
        {
            //Go to see the Stargazer and get to know your horoscopes.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(111011, 301010, 1, 1, 301);
            return res;
        }
        public static byte Q111012(ConnectionInfo c, int QuestID)
        {
            //See the Preparatory Officer, let him arrange the following things.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;

            res = QuestReward.R111012(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 16346, 700, 0, 34);

            c.Player.quest.AddTaskAccept(111015, 301011, 301);
            return res;
        }
        public static byte A111012(ConnectionInfo c, int QuestID)
        {
            //See the Preparatory Officer, let him arrange the following things.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(111012, 301011, 1, 1, 301);
            return res;
        }
        public static byte Q111015(ConnectionInfo c, int QuestID)
        {
            //Go to Sunshine Cliff, meet Allen.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;

            res = QuestReward.R111015(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 8222, 300, 6, 16);

            c.Player.quest.AddTaskAccept(110016, 501001, 501);
            return res;
        }
        public static byte A111015(ConnectionInfo c, int QuestID)
        {
            //Go to Sunshine Cliff, meet Allen.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(111015, 501001, 1, 1, 501);
            return res;
        }
        public static byte Q111044(ConnectionInfo c, int QuestID)
        {
            //Go to the City of Genesis and contact Grover.
            if (QuestCommand.CanQuest(c, 20)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 38867, 500, 49, 110);

            c.Player.quest.AddTaskAccept(119005, 502033, 502);
            return res;
        }
        public static byte A111044(ConnectionInfo c, int QuestID)
        {
            //Go to the City of Genesis and contact Grover.
            if (QuestCommand.CanQuest(c, 20)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(111044, 502033, 1, 1, 502);
            return res;
        }
        public static byte Q112001(ConnectionInfo c, int QuestID)
        {
            //Find Old Blacksmith, get the gift from the Old Blacksmith.
            if (QuestCommand.CanQuest(c, 11)) return 3;
            byte res = 1;

            res = QuestReward.R112001(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 13826, 1000, 0, 41);

            c.Player.quest.AddTaskAccept(112004, 401016, 401);
            return res;
        }
        public static byte A112001(ConnectionInfo c, int QuestID)
        {
            //Find Old Blacksmith, get the gift from the Old Blacksmith.
            if (QuestCommand.CanQuest(c, 11)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(112001, 401016, 1, 1, 401);
            return res;
        }
        public static byte Q112004(ConnectionInfo c, int QuestID)
        {
            //Learn new skill from Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R112004(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 4940, 300, 0, 12);

            c.Player.quest.AddTaskAccept(112006, 401012, 401);
            return res;
        }
        public static byte A112004(ConnectionInfo c, int QuestID)
        {
            //Learn new skill from Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(112004, 401012, 1, 1, 401);
            return res;
        }
        public static byte Q112006(ConnectionInfo c, int QuestID)
        {
            //Get a better weapon from the Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R112006(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 4766, 350, 0, 12);

            c.Player.quest.AddTaskAccept(112008, 401012, 401);
            return res;
        }
        public static byte A112006(ConnectionInfo c, int QuestID)
        {
            //Get a better weapon from the Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(112006, 401012, 1, 1, 401);
            return res;
        }
        public static byte Q112008(ConnectionInfo c, int QuestID)
        {
            //Ask Grocer for some Teleport Scrolls.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R112008(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 5059, 300, 0, 15);

            c.Player.quest.AddTaskAccept(112010, 401018, 401);
            return res;
        }
        public static byte A112008(ConnectionInfo c, int QuestID)
        {
            //Ask Grocer for some Teleport Scrolls.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(112008, 401018, 1, 1, 401);
            return res;
        }
        public static byte Q112010(ConnectionInfo c, int QuestID)
        {
            //Get a better magic cloth from the Tailor.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R112010(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 3125, 150, 0, 7);

            c.Player.quest.AddTaskAccept(112011, 401024, 401);
            return res;
        }
        public static byte A112010(ConnectionInfo c, int QuestID)
        {
            //Get a better magic cloth from the Tailor.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(112010, 401024, 1, 1, 401);
            return res;
        }
        public static byte Q112011(ConnectionInfo c, int QuestID)
        {
            //Go to see the Stargazer and get to know your horoscopes.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 6336, 300, 0, 15);

            c.Player.quest.AddTaskAccept(112012, 401010, 401);
            return res;
        }
        public static byte A112011(ConnectionInfo c, int QuestID)
        {
            //Go to see the Stargazer and get to know your horoscopes.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(112011, 401010, 1, 1, 401);
            return res;
        }
        public static byte Q112012(ConnectionInfo c, int QuestID)
        {
            //See the Preparatory Officer, let him arrange the following things.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;

            res = QuestReward.R112012(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 16346, 700, 0, 34);

            c.Player.quest.AddTaskAccept(112015, 401011, 401);
            return res;
        }
        public static byte A112012(ConnectionInfo c, int QuestID)
        {
            //See the Preparatory Officer, let him arrange the following things.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(112012, 401011, 1, 1, 401);
            return res;
        }
        public static byte Q112015(ConnectionInfo c, int QuestID)
        {
            //Go to Sunshine Cliff, meet Allen.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;

            res = QuestReward.R112015(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 8222, 300, 6, 16);

            c.Player.quest.AddTaskAccept(110016, 501001, 501);
            return res;
        }
        public static byte A112015(ConnectionInfo c, int QuestID)
        {
            //Go to Sunshine Cliff, meet Allen.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(112015, 501001, 1, 1, 501);
            return res;
        }
        public static byte Q113001(ConnectionInfo c, int QuestID)
        {
            //Find Old Blacksmith, get the gift from the Old Blacksmith.
            if (QuestCommand.CanQuest(c, 11)) return 3;
            byte res = 1;

            res = QuestReward.R113001(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 13826, 1000, 0, 41);

            c.Player.quest.AddTaskAccept(113004, 201016, 201);
            return res;
        }
        public static byte A113001(ConnectionInfo c, int QuestID)
        {
            //Find Old Blacksmith, get the gift from the Old Blacksmith.
            if (QuestCommand.CanQuest(c, 11)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(113001, 201016, 1, 1, 201);
            return res;
        }
        public static byte Q113004(ConnectionInfo c, int QuestID)
        {
            //Learn new skill from Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R113004(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 4940, 300, 0, 12);

            c.Player.quest.AddTaskAccept(113006, 201012, 201);
            return res;
        }
        public static byte A113004(ConnectionInfo c, int QuestID)
        {
            //Learn new skill from Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(113004, 201012, 1, 1, 201);
            return res;
        }
        public static byte Q113006(ConnectionInfo c, int QuestID)
        {
            //Get a better weapon from the Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R113006(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 4766, 350, 0, 12);

            c.Player.quest.AddTaskAccept(113008, 201012, 201);
            return res;
        }
        public static byte A113006(ConnectionInfo c, int QuestID)
        {
            //Get a better weapon from the Warrior Leader.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(113006, 201012, 1, 1, 201);
            return res;
        }
        public static byte Q113008(ConnectionInfo c, int QuestID)
        {
            //Ask Grocer for some Teleport Scrolls.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R113008(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 5059, 300, 0, 15);

            c.Player.quest.AddTaskAccept(113010, 201018, 201);
            return res;
        }
        public static byte A113008(ConnectionInfo c, int QuestID)
        {
            //Ask Grocer for some Teleport Scrolls.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(113008, 201018, 1, 1, 201);
            return res;
        }
        public static byte Q113010(ConnectionInfo c, int QuestID)
        {
            //Get a better magic cloth from the Tailor.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;

            res = QuestReward.R113010(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 3125, 150, 0, 7);

            c.Player.quest.AddTaskAccept(113011, 201024, 201);
            return res;
        }
        public static byte A113010(ConnectionInfo c, int QuestID)
        {
            //Get a better magic cloth from the Tailor.
            if (QuestCommand.CanQuest(c, 12)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(113010, 201024, 1, 1, 201);
            return res;
        }
        public static byte Q113011(ConnectionInfo c, int QuestID)
        {
            //Go to see the Stargazer and get to know your horoscopes.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 6336, 300, 0, 15);

            c.Player.quest.AddTaskAccept(113012, 201010, 201);
            return res;
        }
        public static byte A113011(ConnectionInfo c, int QuestID)
        {
            //Go to see the Stargazer and get to know your horoscopes.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(113011, 201010, 1, 1, 201);
            return res;
        }
        public static byte Q113012(ConnectionInfo c, int QuestID)
        {
            //See the Preparatory Officer, let him arrange the following things.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;

            res = QuestReward.R113012(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 16346, 700, 0, 34);

            c.Player.quest.AddTaskAccept(113015, 201011, 201);
            return res;
        }
        public static byte A113012(ConnectionInfo c, int QuestID)
        {
            //See the Preparatory Officer, let him arrange the following things.
            if (QuestCommand.CanQuest(c, 13)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(113012, 201011, 1, 1, 201);
            return res;
        }
        public static byte Q113015(ConnectionInfo c, int QuestID)
        {
            //Go to Sunshine Cliff, meet Allen.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;

            res = QuestReward.R113015(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 8222, 300, 6, 16);

            c.Player.quest.AddTaskAccept(110016, 501001, 501);
            return res;
        }
        public static byte A113015(ConnectionInfo c, int QuestID)
        {
            //Go to Sunshine Cliff, meet Allen.
            if (QuestCommand.CanQuest(c, 14)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(113015, 501001, 1, 1, 501);
            return res;
        }
        public static byte Q119001(ConnectionInfo c, int QuestID)
        {
            //Ask Ernest for the weapon Grover has prepared.
            if (QuestCommand.CanQuest(c, 20)) return 3;
            byte res = 1;

            res = QuestReward.R119001(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 125554, 1000, 25, 402);

            c.Player.quest.AddTaskAccept(119006, 502009, 502);
            return res;
        }
        public static byte A119001(ConnectionInfo c, int QuestID)
        {
            //Ask Ernest for the weapon Grover has prepared.
            if (QuestCommand.CanQuest(c, 20)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119001, 502009, 1, 1, 502);
            return res;
        }
        public static byte Q119002(ConnectionInfo c, int QuestID)
        {
            //Ask Larry about the whole thing.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;

            res = QuestReward.R119002(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 58946, 100, 10, 60);

            c.Player.quest.AddTaskAccept(119003, 502011, 502);
            return res;
        }
        public static byte A119002(ConnectionInfo c, int QuestID)
        {
            //Ask Larry about the whole thing.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119002, 502011, 1, 1, 502);
            return res;
        }
        public static byte Q119003(ConnectionInfo c, int QuestID)
        {
            //Kill Mentor Quentin at Dawn Pier, then tell this news to Jeff.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 27612, 50, 5, 40);

            c.Player.quest.AddTaskAccept(119004, 502015, 502);
            return res;
        }
        public static byte A119003(ConnectionInfo c, int QuestID)
        {
            //Kill Mentor Quentin at Dawn Pier, then tell this news to Jeff.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119003, 601010, 2, 0, 601, 1, 601010);
            c.Player.quest.AddPack(119003, 502015, 502);
            return res;
        }
        public static byte Q119004(ConnectionInfo c, int QuestID)
        {
            //Get VIP Trial Card from Larry.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;

            res = QuestReward.R119004(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 20300, 250, 20, 115);

            c.Player.quest.AddTaskAccept(110045, 502011, 502);
            return res;
        }
        public static byte A119004(ConnectionInfo c, int QuestID)
        {
            //Get VIP Trial Card from Larry.
            if (QuestCommand.CanQuest(c, 21)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119004, 502011, 1, 1, 502);
            return res;
        }
        public static byte Q119005(ConnectionInfo c, int QuestID)
        {
            //Try zodiac transformation under Grover\'s guidance.
            if (QuestCommand.CanQuest(c, 20)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 35746, 500, 3, 110);

            c.Player.quest.AddTaskAccept(119001, 502033, 502);
            return res;
        }
        public static byte A119005(ConnectionInfo c, int QuestID)
        {
            //Try zodiac transformation under Grover\'s guidance.
            if (QuestCommand.CanQuest(c, 20)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119005, 502033, 1, 1, 502);
            return res;
        }
        public static byte Q119006(ConnectionInfo c, int QuestID)
        {
            //Find Goya and finish her request.
            if (QuestCommand.CanQuest(c, 20)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 73043, 550, 10, 400);



            c.Player.quest.AddTaskAccept(119002, 502023, 502);

            c.Player.quest.AddTaskAccept(129004, 502034, 502);
            return res;
        }
        public static byte A119006(ConnectionInfo c, int QuestID)
        {
            //Find Goya and finish her request.
            if (QuestCommand.CanQuest(c, 20)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119006, 502023, 1, 1, 502);
            return res;
        }
        public static byte Q119007(ConnectionInfo c, int QuestID)
        {
            //Tell Spendo about Donald\'s news.
            if (QuestCommand.CanQuest(c, 19)) return 3;
            byte res = 1;

            res = QuestReward.R119007(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 79583, 500, 2, 170);

            c.Player.quest.AddTaskAccept(111044, 501008, 501);
            return res;
        }
        public static byte A119007(ConnectionInfo c, int QuestID)
        {
            //Tell Spendo about Donald\'s news.
            if (QuestCommand.CanQuest(c, 19)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119007, 501008, 1, 1, 501);
            return res;
        }
        public static byte Q119009(ConnectionInfo c, int QuestID)
        {
            //Synthesize one Armor Shred with Magic Seed, then go to see Herbert.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;

            res = QuestReward.R119009(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 61020, 150, 19, 264);

            c.Player.quest.AddTaskAccept(119012, 502036, 502);
            return res;
        }
        public static byte A119009(ConnectionInfo c, int QuestID)
        {
            //Synthesize one Armor Shred with Magic Seed, then go to see Herbert.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119009, 502036, 1, 1, 502);
            return res;
        }
        public static byte Q119010(ConnectionInfo c, int QuestID)
        {
            //Synthesize one Ice Enchant with Magic Seed, then go to see Herbert.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;

            res = QuestReward.R119010(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 61020, 150, 19, 264);

            c.Player.quest.AddTaskAccept(119012, 502036, 502);
            return res;
        }
        public static byte A119010(ConnectionInfo c, int QuestID)
        {
            //Synthesize one Ice Enchant with Magic Seed, then go to see Herbert.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119010, 502036, 1, 1, 502);
            return res;
        }
        public static byte Q119011(ConnectionInfo c, int QuestID)
        {
            //Synthesize one Death Inspire with Magic Seed, then go to see Herbert.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;

            res = QuestReward.R119011(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 61020, 150, 19, 264);

            c.Player.quest.AddTaskAccept(119012, 502036, 502);
            return res;
        }
        public static byte A119011(ConnectionInfo c, int QuestID)
        {
            //Synthesize one Death Inspire with Magic Seed, then go to see Herbert.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119011, 502036, 1, 1, 502);
            return res;
        }
        public static byte Q119012(ConnectionInfo c, int QuestID)
        {
            //Find Feig, buy one HP Potion B and talk to him.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 199653, 550, 76, 974);

            c.Player.quest.AddTaskAccept(119013, 502031, 502);
            return res;
        }
        public static byte A119012(ConnectionInfo c, int QuestID)
        {
            //Find Feig, buy one HP Potion B and talk to him.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;

            return res;
        }
        public static byte Q119013(ConnectionInfo c, int QuestID)
        {
            //Enter Sky City, kill 4 Cloud Elves, then go to see Beryl.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 356123, 600, 76, 974);

            c.Player.quest.AddTaskAccept(119014, 502016, 502);
            return res;
        }
        public static byte A119013(ConnectionInfo c, int QuestID)
        {
            //Enter Sky City, kill 4 Cloud Elves, then go to see Beryl.
            if (QuestCommand.CanQuest(c, 26)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119013, 800028, 2, 0, 602, 4, 800028);
            c.Player.quest.AddPack(119013, 502016, 502);
            return res;
        }
        public static byte Q119014(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, find Morton and listen to his instructions.
            if (QuestCommand.CanQuest(c, 27)) return 3;
            byte res = 1;

            res = QuestReward.R119014(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 191768, 500, 25, 600);

            c.Player.quest.AddTaskAccept(129016, 502048, 502);
            return res;
        }
        public static byte A119014(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, find Morton and listen to his instructions.
            if (QuestCommand.CanQuest(c, 27)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119014, 502048, 1, 1, 502);
            return res;
        }
        public static byte Q119016(ConnectionInfo c, int QuestID)
        {
            //Find Edith, ask her how to make money.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152016, 500, 35, 600);

            c.Player.quest.AddTaskAccept(119017, 502034, 502);
            return res;
        }
        public static byte A119016(ConnectionInfo c, int QuestID)
        {
            //Find Edith, ask her how to make money.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119016, 502034, 1, 1, 502);
            return res;
        }
        public static byte Q119017(ConnectionInfo c, int QuestID)
        {
            //Complete Escort Supplies once, then go to see Edith.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 616321, 1900, 125, 2300);

            c.Player.quest.AddTaskAccept(119018, 502034, 502);
            return res;
        }
        public static byte A119017(ConnectionInfo c, int QuestID)
        {
            //Complete Escort Supplies once, then go to see Edith.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;

            return res;
        }
        public static byte Q119018(ConnectionInfo c, int QuestID)
        {
            //Enter Dragon Cave, kill 5 Bronze Drakes, and then find Quenton.
            if (QuestCommand.CanQuest(c, 29)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 584394, 2200, 270, 240);

            c.Player.quest.AddTaskAccept(129019, 502014, 502);
            return res;
        }
        public static byte A119018(ConnectionInfo c, int QuestID)
        {
            //Enter Dragon Cave, kill 5 Bronze Drakes, and then find Quenton.
            if (QuestCommand.CanQuest(c, 29)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119018, 800001, 2, 0, 633, 5, 800001);
            c.Player.quest.AddPack(119018, 502014, 502);
            return res;
        }
        public static byte Q119020(ConnectionInfo c, int QuestID)
        {
            //Collect 2 Dusk Dew in Lune Oasis, and then find Pine.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 48106, 1450, 16, 200);

            c.Player.quest.AddTaskAccept(119021, 503001, 504);
            return res;
        }
        public static byte A119020(ConnectionInfo c, int QuestID)
        {
            //Collect 2 Dusk Dew in Lune Oasis, and then find Pine.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119020, 5010045, 4, 0, 504, 2, 503102);
            c.Player.quest.AddPack(119020, 503001, 504);
            return res;
        }
        public static byte Q119021(ConnectionInfo c, int QuestID)
        {
            //Kill 8 Moonlight Beasts in Lune Oasis, then find Ralph.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 48005, 1450, 16, 200);

            c.Player.quest.AddTaskAccept(119022, 503002, 504);
            return res;
        }
        public static byte A119021(ConnectionInfo c, int QuestID)
        {
            //Kill 8 Moonlight Beasts in Lune Oasis, then find Ralph.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119021, 503001, 2, 0, 504, 8, 503001);
            c.Player.quest.AddPack(119021, 503002, 504);
            return res;
        }
        public static byte Q119022(ConnectionInfo c, int QuestID)
        {
            //Kill 8 Gangtooth Spiders in Lune Oasis, then find Gemma.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 48198, 1450, 16, 200);

            c.Player.quest.AddTaskAccept(119023, 503005, 504);
            return res;
        }
        public static byte A119022(ConnectionInfo c, int QuestID)
        {
            //Kill 8 Gangtooth Spiders in Lune Oasis, then find Gemma.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119022, 503002, 2, 0, 504, 8, 503002);
            c.Player.quest.AddPack(119022, 503005, 504);
            return res;
        }
        public static byte Q119023(ConnectionInfo c, int QuestID)
        {
            //Kill 8 Desert Lizards in Lune Oasis, then find Claude.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 48226, 1450, 16, 200);

            c.Player.quest.AddTaskAccept(119024, 504010, 504);
            return res;
        }
        public static byte A119023(ConnectionInfo c, int QuestID)
        {
            //Kill 8 Desert Lizards in Lune Oasis, then find Claude.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119023, 503003, 2, 0, 504, 8, 503003);
            c.Player.quest.AddPack(119023, 504010, 504);
            return res;
        }
        public static byte Q119024(ConnectionInfo c, int QuestID)
        {
            //Kill 8 Desert Arks in Lune Oasis, then find Claude.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 48317, 1450, 16, 200);

            c.Player.quest.AddTaskAccept(119025, 503003, 504);
            return res;
        }
        public static byte A119024(ConnectionInfo c, int QuestID)
        {
            //Kill 8 Desert Arks in Lune Oasis, then find Claude.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119024, 503004, 2, 0, 504, 8, 503004);
            c.Player.quest.AddPack(119024, 503003, 504);
            return res;
        }
        public static byte Q119025(ConnectionInfo c, int QuestID)
        {
            //Find Jason in Lune Oasis, listen to his command.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 48941, 1450, 16, 200);
            c.Player.quest.AddTaskAccept(119008 + c.Player.role.career, 502035, 504);
            return res;
        }
        public static byte A119025(ConnectionInfo c, int QuestID)
        {
            //Find Jason in Lune Oasis, listen to his command.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(119025, 502035, 1, 1, 504);
            return res;
        }
        public static byte Q120004(ConnectionInfo c, int QuestID)
        {
            //Add 1 friend and find Leonard to finish the quest.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 500, 100, 0, 0);
            return res;
        }
        public static byte A120004(ConnectionInfo c, int QuestID)
        {
            //Add 1 friend and find Leonard to finish the quest.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            return res;
        }
        public static byte Q120022(ConnectionInfo c, int QuestID)
        {
            //Join a guild and find Edith to complete the task.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1000, 100, 0, 100);
            return res;
        }
        public static byte A120022(ConnectionInfo c, int QuestID)
        {
            //Join a guild and find Edith to complete the task.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            return res;
        }
        public static byte Q120027(ConnectionInfo c, int QuestID)
        {
            //Ask Cleveland how to take a leave successfully.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;

            res = QuestReward.R120027(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 41746, 100, 0, 92);

            c.Player.quest.AddTaskAccept(120028, 503008, 503);
            return res;
        }
        public static byte A120027(ConnectionInfo c, int QuestID)
        {
            //Ask Cleveland how to take a leave successfully.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120027, 503008, 1, 1, 503);
            return res;
        }
        public static byte Q120028(ConnectionInfo c, int QuestID)
        {
            //Persuade Curtis to agree the work shift with Edith.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 50004, 100, 0, 92);

            c.Player.quest.AddTaskAccept(120029, 503009, 503);
            return res;
        }
        public static byte A120028(ConnectionInfo c, int QuestID)
        {
            //Persuade Curtis to agree the work shift with Edith.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120028, 503009, 1, 1, 503);
            return res;
        }
        public static byte Q120029(ConnectionInfo c, int QuestID)
        {
            //Catch 8 Fire Bats at Rubble Wasteland and take them back to Curtis.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;

            res = QuestReward.R120029(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 125874, 200, 0, 92);

            c.Player.quest.AddTaskAccept(120030, 503009, 503);
            return res;
        }
        public static byte A120029(ConnectionInfo c, int QuestID)
        {
            //Catch 8 Fire Bats at Rubble Wasteland and take them back to Curtis.
            if (QuestCommand.CanQuest(c, 23)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120029, 503005, 2, 0, 503, 8, 503005);
            c.Player.quest.AddPack(120029, 503009, 503);
            return res;
        }
        public static byte Q120030(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Stone Ants at Rubble Wasteland and then tell Curtis.
            if (QuestCommand.CanQuest(c, 24)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 254171, 1000, 26, 725);

            c.Player.quest.AddTaskAccept(120031, 503009, 503);
            return res;
        }
        public static byte A120030(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Stone Ants at Rubble Wasteland and then tell Curtis.
            if (QuestCommand.CanQuest(c, 24)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120030, 503012, 2, 0, 503, 5, 503012);
            c.Player.quest.AddPack(120030, 503009, 503);
            return res;
        }
        public static byte Q120031(ConnectionInfo c, int QuestID)
        {
            //Take Dulcie the weapon enhanced by Curtis.
            if (QuestCommand.CanQuest(c, 24)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 51117, 1000, 26, 725);

            c.Player.quest.AddTaskAccept(120035, 503010, 503);
            return res;
        }
        public static byte A120031(ConnectionInfo c, int QuestID)
        {
            //Take Dulcie the weapon enhanced by Curtis.
            if (QuestCommand.CanQuest(c, 24)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120031, 503010, 1, 1, 503);
            return res;
        }
        public static byte Q120035(ConnectionInfo c, int QuestID)
        {
            //Kill 8 The Decayed at Rubble Wasteland and then tell Dulcie.
            if (QuestCommand.CanQuest(c, 24)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 246919, 1000, 26, 725);

            c.Player.quest.AddTaskAccept(120036, 503010, 503);
            return res;
        }
        public static byte A120035(ConnectionInfo c, int QuestID)
        {
            //Kill 8 The Decayed at Rubble Wasteland and then tell Dulcie.
            if (QuestCommand.CanQuest(c, 24)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120035, 503006, 2, 0, 503, 8, 503006);
            c.Player.quest.AddPack(120035, 503010, 503);
            return res;
        }
        public static byte Q120036(ConnectionInfo c, int QuestID)
        {
            //Go to see Elroy, ask the reason of Treant\'s attack for Dulcie.
            if (QuestCommand.CanQuest(c, 24)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 128694, 2000, 54, 1450);

            c.Player.quest.AddTaskAccept(120037, 503011, 503);
            return res;
        }
        public static byte A120036(ConnectionInfo c, int QuestID)
        {
            //Go to see Elroy, ask the reason of Treant\'s attack for Dulcie.
            if (QuestCommand.CanQuest(c, 24)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120036, 503011, 1, 1, 503);
            return res;
        }
        public static byte Q120037(ConnectionInfo c, int QuestID)
        {
            //Catch 5 Wind Weasels at Rubble Wasteland and take back to Moore.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 62517, 100, 0, 170);

            c.Player.quest.AddTaskAccept(120038, 503011, 503);
            return res;
        }
        public static byte A120037(ConnectionInfo c, int QuestID)
        {
            //Catch 5 Wind Weasels at Rubble Wasteland and take back to Moore.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120037, 503013, 2, 0, 503, 5, 503013);
            c.Player.quest.AddPack(120037, 503011, 503);
            return res;
        }
        public static byte Q120038(ConnectionInfo c, int QuestID)
        {
            //Help Elroy to find Magee and find out if there\'s some way to restore the magic array on the sword.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 51379, 150, 0, 170);

            c.Player.quest.AddTaskAccept(120039, 503012, 503);
            return res;
        }
        public static byte A120038(ConnectionInfo c, int QuestID)
        {
            //Help Elroy to find Magee and find out if there\'s some way to restore the magic array on the sword.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120038, 503012, 1, 1, 503);
            return res;
        }
        public static byte Q120039(ConnectionInfo c, int QuestID)
        {
            //Catch 5 Tarantulas at Rubble Wasteland and take back to Ralph.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 56527, 100, 0, 170);

            c.Player.quest.AddTaskAccept(120040, 503012, 503);
            return res;
        }
        public static byte A120039(ConnectionInfo c, int QuestID)
        {
            //Catch 5 Tarantulas at Rubble Wasteland and take back to Ralph.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120039, 503014, 2, 0, 503, 5, 503014);
            c.Player.quest.AddPack(120039, 503012, 503);
            return res;
        }
        public static byte Q120040(ConnectionInfo c, int QuestID)
        {
            //Take the sword enchanted by Magee to Beryl.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            res = QuestReward.R120040(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 50794, 150, 0, 170);

            c.Player.quest.AddTaskAccept(129001, 502016, 502);
            return res;
        }
        public static byte A120040(ConnectionInfo c, int QuestID)
        {
            //Take the sword enchanted by Magee to Beryl.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120040, 502016, 1, 1, 502);
            return res;
        }
        public static byte Q120058(ConnectionInfo c, int QuestID)
        {
            //Kill 15 Toothy Gerbil at Darksand Land and report to Andy.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 68934, 1200, 0, 1425);
            return res;
        }
        public static byte A120058(ConnectionInfo c, int QuestID)
        {
            //Kill 15 Toothy Gerbil at Darksand Land and report to Andy.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120058, 505001, 2, 0, 505, 15, 505001);
            c.Player.quest.AddPack(120058, 504006, 504);
            return res;
        }
        public static byte Q120059(ConnectionInfo c, int QuestID)
        {
            //Ask Ingrid how to heal rheumatism for Colin.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 48908, 1100, 0, 1425);

            c.Player.quest.AddTaskAccept(120060, 504015, 504);
            return res;
        }
        public static byte A120059(ConnectionInfo c, int QuestID)
        {
            //Ask Ingrid how to heal rheumatism for Colin.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120059, 504015, 1, 1, 504);
            return res;
        }
        public static byte Q120060(ConnectionInfo c, int QuestID)
        {
            //Catch 30 Toxic Scorpions at Darksand Land and take back to Ingrid.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 59143, 1250, 0, 1425);
            return res;
        }
        public static byte A120060(ConnectionInfo c, int QuestID)
        {
            //Catch 30 Toxic Scorpions at Darksand Land and take back to Ingrid.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120060, 505006, 2, 0, 505, 15, 505006);
            c.Player.quest.AddPack(120060, 504015, 504);
            return res;
        }
        public static byte Q120061(ConnectionInfo c, int QuestID)
        {
            //Ask Benedict about how to get food.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 39716, 1500, 0, 1782);

            c.Player.quest.AddTaskAccept(120062, 504007, 504);
            return res;
        }
        public static byte A120061(ConnectionInfo c, int QuestID)
        {
            //Ask Benedict about how to get food.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120061, 504007, 1, 1, 504);
            return res;
        }
        public static byte Q120062(ConnectionInfo c, int QuestID)
        {
            //Tell Andy Benedict\'s suggestion.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 42422, 1500, 0, 1782);

            c.Player.quest.AddTaskAccept(120063, 504006, 504);
            return res;
        }
        public static byte A120062(ConnectionInfo c, int QuestID)
        {
            //Tell Andy Benedict\'s suggestion.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120062, 504006, 1, 1, 504);
            return res;
        }
        public static byte Q120063(ConnectionInfo c, int QuestID)
        {
            //Catch 20 Toothy Gerbils at Darksand Land and take them back to Andy.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 137857, 1500, 0, 1783);
            return res;
        }
        public static byte A120063(ConnectionInfo c, int QuestID)
        {
            //Catch 20 Toothy Gerbils at Darksand Land and take them back to Andy.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120063, 505001, 2, 0, 505, 20, 505001);
            c.Player.quest.AddPack(120063, 504006, 504);
            return res;
        }
        public static byte Q120064(ConnectionInfo c, int QuestID)
        {
            //Ask Claude to detoxify for Chester\'s wife.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 30049, 1080, 0, 1296);

            c.Player.quest.AddTaskAccept(120065, 504010, 504);
            return res;
        }
        public static byte A120064(ConnectionInfo c, int QuestID)
        {
            //Ask Claude to detoxify for Chester\'s wife.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120064, 504010, 1, 1, 504);
            return res;
        }
        public static byte Q120065(ConnectionInfo c, int QuestID)
        {
            //Catch 20 Toxic Scorpions at Darksand Land, take them to Claude to make antidotes.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 125970, 1080, 0, 1296);

            c.Player.quest.AddTaskAccept(120066, 504010, 504);
            return res;
        }
        public static byte A120065(ConnectionInfo c, int QuestID)
        {
            //Catch 20 Toxic Scorpions at Darksand Land, take them to Claude to make antidotes.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120065, 505006, 2, 0, 505, 20, 505006);
            c.Player.quest.AddPack(120065, 504010, 504);
            return res;
        }
        public static byte Q120066(ConnectionInfo c, int QuestID)
        {
            //Take Claude\'s antidotes to Chester.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 27981, 1080, 0, 1296);
            return res;
        }
        public static byte A120066(ConnectionInfo c, int QuestID)
        {
            //Take Claude\'s antidotes to Chester.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120066, 504009, 1, 1, 504);
            return res;
        }
        public static byte Q120067(ConnectionInfo c, int QuestID)
        {
            //Ask Claude about salary increase.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 39859, 1080, 0, 1296);

            c.Player.quest.AddTaskAccept(120068, 504010, 504);
            return res;
        }
        public static byte A120067(ConnectionInfo c, int QuestID)
        {
            //Ask Claude about salary increase.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120067, 504010, 1, 1, 504);
            return res;
        }
        public static byte Q120068(ConnectionInfo c, int QuestID)
        {
            //Tell Nelson Claude\'s promise.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 40354, 1080, 0, 1296);
            return res;
        }
        public static byte A120068(ConnectionInfo c, int QuestID)
        {
            //Tell Nelson Claude\'s promise.
            if (QuestCommand.CanQuest(c, 32)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120068, 505001, 1, 1, 505);
            return res;
        }
        public static byte Q120069(ConnectionInfo c, int QuestID)
        {
            //Ask Colin to derust weapon.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 55845, 2100, 0, 2557);

            c.Player.quest.AddTaskAccept(120070, 504011, 504);
            return res;
        }
        public static byte A120069(ConnectionInfo c, int QuestID)
        {
            //Ask Colin to derust weapon.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120069, 504011, 1, 1, 504);
            return res;
        }
        public static byte Q120070(ConnectionInfo c, int QuestID)
        {
            //Collect 4 Darksand Essence at Darksand Land and take back to Colin.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 194162, 2100, 0, 2558);

            c.Player.quest.AddTaskAccept(120071, 504011, 504);
            return res;
        }
        public static byte A120070(ConnectionInfo c, int QuestID)
        {
            //Collect 4 Darksand Essence at Darksand Land and take back to Colin.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120070, 5010053, 4, 0, 505, 4, 505104);
            c.Player.quest.AddPack(120070, 504011, 504);
            return res;
        }
        public static byte Q120071(ConnectionInfo c, int QuestID)
        {
            //Take the weapon reforged by Colin to Esther.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 59208, 2100, 0, 2558);
            return res;
        }
        public static byte A120071(ConnectionInfo c, int QuestID)
        {
            //Take the weapon reforged by Colin to Esther.
            if (QuestCommand.CanQuest(c, 33)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120071, 504013, 1, 1, 504);
            return res;
        }
        public static byte Q120072(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Dire Wolves at Darksand Land and report to Andy.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 104963, 1850, 0, 2231);
            return res;
        }
        public static byte A120072(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Dire Wolves at Darksand Land and report to Andy.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120072, 505004, 2, 0, 505, 30, 505004);
            c.Player.quest.AddPack(120072, 504006, 504);
            return res;
        }
        public static byte Q120073(ConnectionInfo c, int QuestID)
        {
            //Ask Claude how to let Rattlesnakes quiet down at night
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 64238, 1850, 0, 2231);

            c.Player.quest.AddTaskAccept(120074, 504010, 504);
            return res;
        }
        public static byte A120073(ConnectionInfo c, int QuestID)
        {
            //Ask Claude how to let Rattlesnakes quiet down at night
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120073, 504010, 1, 1, 504);
            return res;
        }
        public static byte Q120074(ConnectionInfo c, int QuestID)
        {
            //Tell Lyle Claude\'s method.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 67862, 1850, 0, 2231);

            c.Player.quest.AddTaskAccept(120075, 505002, 505);
            return res;
        }
        public static byte A120074(ConnectionInfo c, int QuestID)
        {
            //Tell Lyle Claude\'s method.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120074, 505002, 1, 1, 505);
            return res;
        }
        public static byte Q120075(ConnectionInfo c, int QuestID)
        {
            //Catch 30 Toothy Gerbils at Darksand Land and take them back to Lyle.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117473, 1850, 0, 2232);
            return res;
        }
        public static byte A120075(ConnectionInfo c, int QuestID)
        {
            //Catch 30 Toothy Gerbils at Darksand Land and take them back to Lyle.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120075, 505001, 2, 0, 505, 30, 505001);
            c.Player.quest.AddPack(120075, 505002, 505);
            return res;
        }
        public static byte Q120076(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Toxic Scorpions at Darksand Land and take them back to Julian.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 132256, 2500, 0, 3412);

            c.Player.quest.AddTaskAccept(120077, 505003, 505);
            return res;
        }
        public static byte A120076(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Toxic Scorpions at Darksand Land and take them back to Julian.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120076, 505006, 2, 0, 505, 35, 505006);
            c.Player.quest.AddPack(120076, 505003, 505);
            return res;
        }
        public static byte Q120077(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Dire Wolves at Darksand Land and take them back to Julian.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 133256, 3000, 0, 3412);

            c.Player.quest.AddTaskAccept(120078, 505003, 505);
            return res;
        }
        public static byte A120077(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Dire Wolves at Darksand Land and take them back to Julian.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120077, 505004, 2, 0, 505, 35, 505004);
            c.Player.quest.AddPack(120077, 505003, 505);
            return res;
        }
        public static byte Q120078(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Bactrian Camels at Darksand Land and take them back to Julian.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 134164, 3000, 0, 3413);
            return res;
        }
        public static byte A120078(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Bactrian Camels at Darksand Land and take them back to Julian.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120078, 505002, 2, 0, 505, 35, 505002);
            c.Player.quest.AddPack(120078, 505003, 505);
            return res;
        }
        public static byte Q120079(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Bactrian Camels at Darksand Land and take them back to Andy.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 187496, 3200, 0, 3870);
            return res;
        }
        public static byte A120079(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Bactrian Camels at Darksand Land and take them back to Andy.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120079, 505002, 2, 0, 505, 35, 505002);
            c.Player.quest.AddPack(120079, 504006, 504);
            return res;
        }
        public static byte Q120080(ConnectionInfo c, int QuestID)
        {
            //Ask Julian how to get fuels.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 59233, 3200, 0, 3870);

            c.Player.quest.AddTaskAccept(120081, 505003, 505);
            return res;
        }
        public static byte A120080(ConnectionInfo c, int QuestID)
        {
            //Ask Julian how to get fuels.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120080, 505003, 1, 1, 505);
            return res;
        }
        public static byte Q120081(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Sand Fire Lizard at Darksand Land and take back to Julian.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 197364, 3200, 0, 3870);
            return res;
        }
        public static byte A120081(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Sand Fire Lizard at Darksand Land and take back to Julian.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120081, 505007, 2, 0, 505, 35, 505007);
            c.Player.quest.AddPack(120081, 505003, 505);
            return res;
        }
        public static byte Q120085(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Dire Wolves at Darksand Land and take them back to Nelson.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 413151, 8000, 0, 9690);

            c.Player.quest.AddTaskAccept(120086, 505001, 505);
            return res;
        }
        public static byte A120085(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Dire Wolves at Darksand Land and take them back to Nelson.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120085, 505004, 2, 0, 505, 35, 505004);
            c.Player.quest.AddPack(120085, 505001, 505);
            return res;
        }
        public static byte Q120086(ConnectionInfo c, int QuestID)
        {
            //Tell Willa that Nelson has done what she asks.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 115264, 4000, 0, 4845);
            return res;
        }
        public static byte A120086(ConnectionInfo c, int QuestID)
        {
            //Tell Willa that Nelson has done what she asks.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120086, 505006, 1, 1, 505);
            return res;
        }
        public static byte Q120087(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Trade Wind Fox at Darksand Land and take back to Cornell.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 487212, 10800, 0, 13042);
            return res;
        }
        public static byte A120087(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Trade Wind Fox at Darksand Land and take back to Cornell.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120087, 505005, 2, 0, 505, 35, 505005);
            c.Player.quest.AddPack(120087, 504014, 504);
            return res;
        }
        public static byte Q120088(ConnectionInfo c, int QuestID)
        {
            //Take Lyle and his broken arm to Ingrid.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 167792, 4500, 0, 5362);

            c.Player.quest.AddTaskAccept(120089, 504015, 504);
            return res;
        }
        public static byte A120088(ConnectionInfo c, int QuestID)
        {
            //Take Lyle and his broken arm to Ingrid.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120088, 504015, 1, 1, 504);
            return res;
        }
        public static byte Q120089(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Sand Fire Lizards at Darksand Land and take them to Ingrid.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 175341, 4500, 0, 5362);

            c.Player.quest.AddTaskAccept(120090, 504015, 504);
            return res;
        }
        public static byte A120089(ConnectionInfo c, int QuestID)
        {
            //Catch 35 Sand Fire Lizards at Darksand Land and take them to Ingrid.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120089, 505007, 2, 0, 505, 35, 505007);
            c.Player.quest.AddPack(120089, 504015, 504);
            return res;
        }
        public static byte Q120090(ConnectionInfo c, int QuestID)
        {
            //Kill 35 Toxic Scorpions at Darksand Land and report to Andy.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 223916, 4500, 0, 5363);
            return res;
        }
        public static byte A120090(ConnectionInfo c, int QuestID)
        {
            //Kill 35 Toxic Scorpions at Darksand Land and report to Andy.
            if (QuestCommand.CanQuest(c, 39)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120090, 505006, 2, 0, 505, 35, 505006);
            c.Player.quest.AddPack(120090, 504006, 504);
            return res;
        }
        public static byte Q120091(ConnectionInfo c, int QuestID)
        {
            //Ask Edgar to take out some bananas from the Inventory.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 111741, 5000, 0, 5900);

            c.Player.quest.AddTaskAccept(120092, 506007, 506);
            return res;
        }
        public static byte A120091(ConnectionInfo c, int QuestID)
        {
            //Ask Edgar to take out some bananas from the Inventory.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120091, 506007, 1, 1, 506);
            return res;
        }
        public static byte Q120092(ConnectionInfo c, int QuestID)
        {
            //Ask Joyce to get bananas before sunset.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 132816, 5000, 0, 5900);

            c.Player.quest.AddTaskAccept(120093, 506009, 506);
            return res;
        }
        public static byte A120092(ConnectionInfo c, int QuestID)
        {
            //Ask Joyce to get bananas before sunset.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120092, 506009, 1, 1, 506);
            return res;
        }
        public static byte Q120093(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Phantom Monkeys in Vine Rainforest and take back to Joyce.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 357864, 5000, 0, 5900);
            return res;
        }
        public static byte A120093(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Phantom Monkeys in Vine Rainforest and take back to Joyce.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120093, 507004, 2, 0, 507, 40, 507004);
            c.Player.quest.AddPack(120093, 506009, 506);
            return res;
        }
        public static byte Q120094(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Phantom Monkeys in Vine Rainforest and then tell Shalom.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 217183, 4000, 0, 4843);
            return res;
        }
        public static byte A120094(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Phantom Monkeys in Vine Rainforest and then tell Shalom.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120094, 507004, 2, 0, 507, 40, 507004);
            c.Player.quest.AddPack(120094, 506012, 506);
            return res;
        }
        public static byte Q120095(ConnectionInfo c, int QuestID)
        {
            //Find Leopold in Vine Rainforest and investigate the missing man with him.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 88947, 4000, 0, 4843);

            c.Player.quest.AddTaskAccept(120096, 507004, 507);
            return res;
        }
        public static byte A120095(ConnectionInfo c, int QuestID)
        {
            //Find Leopold in Vine Rainforest and investigate the missing man with him.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120095, 507004, 1, 1, 507);
            return res;
        }
        public static byte Q120096(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Man-eating Trees in Vine Rainforest and take back to Leopold.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 241966, 4000, 0, 4843);

            c.Player.quest.AddTaskAccept(120097, 507004, 507);
            return res;
        }
        public static byte A120096(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Man-eating Trees in Vine Rainforest and take back to Leopold.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120096, 507003, 2, 0, 507, 40, 507003);
            c.Player.quest.AddPack(120096, 507004, 507);
            return res;
        }
        public static byte Q120097(ConnectionInfo c, int QuestID)
        {
            //Report to Edgar the investigation result.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 85706, 4000, 0, 4843);
            return res;
        }
        public static byte A120097(ConnectionInfo c, int QuestID)
        {
            //Report to Edgar the investigation result.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120097, 506007, 1, 1, 506);
            return res;
        }
        public static byte Q120098(ConnectionInfo c, int QuestID)
        {
            //Ask Monlisa how to prevent food from mouldiness.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 159564, 6000, 0, 7035);

            c.Player.quest.AddTaskAccept(120099, 506011, 506);
            return res;
        }
        public static byte A120098(ConnectionInfo c, int QuestID)
        {
            //Ask Monlisa how to prevent food from mouldiness.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120098, 506011, 1, 1, 506);
            return res;
        }
        public static byte Q120099(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Man-eating Trees in Vine Rainforest and take back to Monlisa.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 225964, 6000, 0, 7035);
            return res;
        }
        public static byte A120099(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Man-eating Trees in Vine Rainforest and take back to Monlisa.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120099, 507003, 2, 0, 507, 40, 507003);
            c.Player.quest.AddPack(120099, 506011, 506);
            return res;
        }
        public static byte Q120100(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Wraith Spiders in Vine Rainforest and then tell Laurie.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 274894, 6000, 0, 7035);
            return res;
        }
        public static byte A120100(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Wraith Spiders in Vine Rainforest and then tell Laurie.
            if (QuestCommand.CanQuest(c, 42)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120100, 507005, 2, 0, 507, 40, 507005);
            c.Player.quest.AddPack(120100, 507003, 507);
            return res;
        }
        public static byte Q120101(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Wraith Spiders in Vine Rainforest and take back to Thera.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 431802, 6000, 0, 7632);

            c.Player.quest.AddTaskAccept(1200102, 507005, 507);
            return res;
        }
        public static byte A120101(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Wraith Spiders in Vine Rainforest and take back to Thera.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120101, 507005, 2, 0, 507, 40, 507005);
            c.Player.quest.AddPack(120101, 507005, 507);
            return res;
        }
        public static byte Q120102(ConnectionInfo c, int QuestID)
        {
            //Ask Winnie how to deal with spider\'s thread.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 119634, 6000, 0, 7632);

            c.Player.quest.AddTaskAccept(120103, 507006, 507);
            return res;
        }
        public static byte A120102(ConnectionInfo c, int QuestID)
        {
            //Ask Winnie how to deal with spider\'s thread.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120102, 507006, 1, 1, 507);
            return res;
        }
        public static byte Q120103(ConnectionInfo c, int QuestID)
        {
            //Take Wraith\'s Spider Thread to Thera.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 130040, 7000, 0, 7633);
            return res;
        }
        public static byte A120103(ConnectionInfo c, int QuestID)
        {
            //Take Wraith\'s Spider Thread to Thera.
            if (QuestCommand.CanQuest(c, 43)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120103, 507005, 1, 1, 507);
            return res;
        }
        public static byte Q120104(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Wraith Spiders in Vine Rainforest and take back to Shalom.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 394200, 6500, 0, 8250);

            c.Player.quest.AddTaskAccept(120105, 506012, 506);
            return res;
        }
        public static byte A120104(ConnectionInfo c, int QuestID)
        {
            //Catch 40 Wraith Spiders in Vine Rainforest and take back to Shalom.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120104, 507005, 2, 0, 507, 40, 507005);
            c.Player.quest.AddPack(120104, 506012, 506);
            return res;
        }
        public static byte Q120105(ConnectionInfo c, int QuestID)
        {
            //Ask Monlisa to help Shalom extract Wraith Spider\'s poison.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 144743, 7000, 0, 8250);

            c.Player.quest.AddTaskAccept(120106, 506011, 506);
            return res;
        }
        public static byte A120105(ConnectionInfo c, int QuestID)
        {
            //Ask Monlisa to help Shalom extract Wraith Spider\'s poison.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120105, 506011, 1, 1, 506);
            return res;
        }
        public static byte Q120106(ConnectionInfo c, int QuestID)
        {
            //Ask Shalom why she need to extract the poison.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 157176, 7000, 0, 8250);
            return res;
        }
        public static byte A120106(ConnectionInfo c, int QuestID)
        {
            //Ask Shalom why she need to extract the poison.
            if (QuestCommand.CanQuest(c, 44)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120106, 506012, 1, 1, 506);
            return res;
        }
        public static byte Q120107(ConnectionInfo c, int QuestID)
        {
            //Tell Joyce Hoare\'s task.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 81015, 7000, 0, 8887);

            c.Player.quest.AddTaskAccept(120108, 506009, 506);
            return res;
        }
        public static byte A120107(ConnectionInfo c, int QuestID)
        {
            //Tell Joyce Hoare\'s task.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120107, 506009, 1, 1, 506);
            return res;
        }
        public static byte Q120108(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Giant Jaw Ants in Vine Rainforest and take back to Joyce.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 304471, 7000, 0, 8887);
            return res;
        }
        public static byte A120108(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Giant Jaw Ants in Vine Rainforest and take back to Joyce.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120108, 507001, 2, 0, 507, 45, 507001);
            c.Player.quest.AddPack(120108, 506009, 506);
            return res;
        }
        public static byte Q120109(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Mud Monsters in Vine Rainforest and take back to Levi.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 317983, 8000, 0, 8888);
            return res;
        }
        public static byte A120109(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Mud Monsters in Vine Rainforest and take back to Levi.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120109, 507002, 2, 0, 507, 45, 507002);
            c.Player.quest.AddPack(120109, 506010, 506);
            return res;
        }
        public static byte Q120110(ConnectionInfo c, int QuestID)
        {
            //Ask Levi to repair the broken magic test crystal.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 110397, 7500, 0, 9545);

            c.Player.quest.AddTaskAccept(120111, 506010, 506);
            return res;
        }
        public static byte A120110(ConnectionInfo c, int QuestID)
        {
            //Ask Levi to repair the broken magic test crystal.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120110, 506010, 1, 1, 506);
            return res;
        }
        public static byte Q120111(ConnectionInfo c, int QuestID)
        {
            //Collect 5 Water Mana Spar in Vine Rainforest and take them back to Levi.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 441673, 8000, 0, 9545);

            c.Player.quest.AddTaskAccept(120112, 506010, 506);
            return res;
        }
        public static byte A120111(ConnectionInfo c, int QuestID)
        {
            //Collect 5 Water Mana Spar in Vine Rainforest and take them back to Levi.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120111, 5010058, 4, 0, 507, 5, 507104);
            c.Player.quest.AddPack(120111, 506010, 506);
            return res;
        }
        public static byte Q120112(ConnectionInfo c, int QuestID)
        {
            //Take the repaired Test Crystal to Hoare.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 150534, 8000, 0, 9545);
            return res;
        }
        public static byte A120112(ConnectionInfo c, int QuestID)
        {
            //Take the repaired Test Crystal to Hoare.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120112, 506008, 1, 1, 506);
            return res;
        }
        public static byte Q120113(ConnectionInfo c, int QuestID)
        {
            //Kill 15 Wraith Spiders, 15 Man-eating Trees, 15 Mud Monsters in Vine Rainforest and report to Ansel.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 327610, 12500, 0, 15333);
            return res;
        }
        public static byte A120113(ConnectionInfo c, int QuestID)
        {
            //Kill 15 Wraith Spiders, 15 Man-eating Trees, 15 Mud Monsters in Vine Rainforest and report to Ansel.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120113, 507005, 2, 0, 507, 15, 507005);
            c.Player.quest.AddTaskComplete(120113, 507003, 2, 0, 507, 15, 507003);
            c.Player.quest.AddTaskComplete(120113, 507002, 2, 0, 507, 15, 507002);
            c.Player.quest.AddPack(120113, 506005, 506);
            return res;
        }
        public static byte Q120114(ConnectionInfo c, int QuestID)
        {
            //Kill 45 Mud Monsters in Vine Rainforest and then tell Leopold.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 364957, 13000, 0, 15334);
            return res;
        }
        public static byte A120114(ConnectionInfo c, int QuestID)
        {
            //Kill 45 Mud Monsters in Vine Rainforest and then tell Leopold.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120114, 507002, 2, 0, 507, 45, 507002);
            c.Player.quest.AddPack(120114, 507004, 507);
            return res;
        }
        public static byte Q120115(ConnectionInfo c, int QuestID)
        {
            //Ask Monlisa how to heal rheumatism.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 121456, 9000, 0, 10920);

            c.Player.quest.AddTaskAccept(120116, 506011, 506);
            return res;
        }
        public static byte A120115(ConnectionInfo c, int QuestID)
        {
            //Ask Monlisa how to heal rheumatism.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120115, 506011, 1, 1, 506);
            return res;
        }
        public static byte Q120116(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Giant Jaw Ants in Vine Rainforest and take them to Monlisa.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 394128, 9000, 0, 10920);

            c.Player.quest.AddTaskAccept(120117, 506011, 506);
            return res;
        }
        public static byte A120116(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Giant Jaw Ants in Vine Rainforest and take them to Monlisa.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120116, 507001, 2, 0, 507, 45, 507001);
            c.Player.quest.AddPack(120116, 506011, 506);
            return res;
        }
        public static byte Q120117(ConnectionInfo c, int QuestID)
        {
            //Tell Levi Monlisa\'s treatment.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 156775, 9300, 0, 10920);
            return res;
        }
        public static byte A120117(ConnectionInfo c, int QuestID)
        {
            //Tell Levi Monlisa\'s treatment.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120117, 506010, 1, 1, 506);
            return res;
        }
        public static byte Q120118(ConnectionInfo c, int QuestID)
        {
            //Tell Levi Ansel\'s instructions.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 226411, 14000, 0, 17456);

            c.Player.quest.AddTaskAccept(120119, 506010, 506);
            return res;
        }
        public static byte A120118(ConnectionInfo c, int QuestID)
        {
            //Tell Levi Ansel\'s instructions.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120118, 506010, 1, 1, 506);
            return res;
        }
        public static byte Q120119(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Mud Monsters in Vine Rainforest and take back to Levi.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 457874, 15000, 0, 17456);
            return res;
        }
        public static byte A120119(ConnectionInfo c, int QuestID)
        {
            //Catch 45 Mud Monsters in Vine Rainforest and take back to Levi.
            if (QuestCommand.CanQuest(c, 49)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120119, 507002, 2, 0, 507, 45, 507002);
            c.Player.quest.AddPack(120119, 506010, 506);
            return res;
        }
        public static byte Q120120(ConnectionInfo c, int QuestID)
        {
            //Ask Hyman to give Weisz a good weapon to pay the debt of gratitude.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 148500, 9000, 0, 10123);

            c.Player.quest.AddTaskAccept(120121, 508008, 508);
            return res;
        }
        public static byte A120120(ConnectionInfo c, int QuestID)
        {
            //Ask Hyman to give Weisz a good weapon to pay the debt of gratitude.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120120, 508008, 1, 1, 508);
            return res;
        }
        public static byte Q120121(ConnectionInfo c, int QuestID)
        {
            //Ask Raymond how to get Curare Wood.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 148500, 9500, 0, 10123);

            c.Player.quest.AddTaskAccept(120122, 508011, 508);
            return res;
        }
        public static byte A120121(ConnectionInfo c, int QuestID)
        {
            //Ask Raymond how to get Curare Wood.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120121, 508011, 1, 1, 508);
            return res;
        }
        public static byte Q120122(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Venom Monsters in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 148500, 9000, 0, 10123);

            c.Player.quest.AddTaskAccept(120123, 508011, 508);
            return res;
        }
        public static byte A120122(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Venom Monsters in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120122, 509001, 2, 0, 509, 50, 509001);
            c.Player.quest.AddPack(120122, 508011, 508);
            return res;
        }
        public static byte Q120123(ConnectionInfo c, int QuestID)
        {
            //Take Raymond\'s Corrosion Potion to Hyman.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 148500, 9500, 0, 10723);

            c.Player.quest.AddTaskAccept(120124, 508008, 508);
            return res;
        }
        public static byte A120123(ConnectionInfo c, int QuestID)
        {
            //Take Raymond\'s Corrosion Potion to Hyman.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120123, 508008, 1, 1, 508);
            return res;
        }
        public static byte Q120124(ConnectionInfo c, int QuestID)
        {
            //Take Hyman\'s weapon to Weisz.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 148500, 9000, 0, 10723);
            return res;
        }
        public static byte A120124(ConnectionInfo c, int QuestID)
        {
            //Take Hyman\'s weapon to Weisz.
            if (QuestCommand.CanQuest(c, 50)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120124, 509001, 1, 1, 509);
            return res;
        }
        public static byte Q120125(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Venom Monsters in Redcloud Marsh and take back to Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 200928, 9500, 0, 11711);

            c.Player.quest.AddTaskAccept(120126, 508010, 508);
            return res;
        }
        public static byte A120125(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Venom Monsters in Redcloud Marsh and take back to Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120125, 509001, 2, 0, 509, 50, 509001);
            c.Player.quest.AddPack(120125, 508010, 508);
            return res;
        }
        public static byte Q120126(ConnectionInfo c, int QuestID)
        {
            //Ask Rodney to get a Venom Monster with wings.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 200928, 9500, 0, 11711);

            c.Player.quest.AddTaskAccept(120127, 508012, 508);
            return res;
        }
        public static byte A120126(ConnectionInfo c, int QuestID)
        {
            //Ask Rodney to get a Venom Monster with wings.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120126, 508012, 1, 1, 508);
            return res;
        }
        public static byte Q120127(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Short-wing Rats in Redcloud Marsh and take back to Rodney.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 200928, 9500, 0, 11711);

            c.Player.quest.AddTaskAccept(120128, 508012, 508);
            return res;
        }
        public static byte A120127(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Short-wing Rats in Redcloud Marsh and take back to Rodney.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120127, 509002, 2, 0, 509, 50, 509002);
            c.Player.quest.AddPack(120127, 508012, 508);
            return res;
        }
        public static byte Q120128(ConnectionInfo c, int QuestID)
        {
            //Take Rodney\'s Venom Monster to Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 200928, 9500, 0, 11711);
            return res;
        }
        public static byte A120128(ConnectionInfo c, int QuestID)
        {
            //Take Rodney\'s Venom Monster to Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120128, 508010, 1, 1, 508);
            return res;
        }
        public static byte Q120129(ConnectionInfo c, int QuestID)
        {
            //Tell Nicolas that Weisz has absorbed miasma in the village and ask him to solve this.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 289328, 9000, 0, 10557);

            c.Player.quest.AddTaskAccept(120130, 508009, 508);
            return res;
        }
        public static byte A120129(ConnectionInfo c, int QuestID)
        {
            //Tell Nicolas that Weisz has absorbed miasma in the village and ask him to solve this.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120129, 508009, 1, 1, 508);
            return res;
        }
        public static byte Q120130(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Medusa in Redcloud Marsh and take their eyes to Nicolas.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 289328, 9000, 0, 10557);
            return res;
        }
        public static byte A120130(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Medusa in Redcloud Marsh and take their eyes to Nicolas.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120130, 509003, 2, 0, 509, 50, 509003);
            c.Player.quest.AddPack(120130, 508009, 508);
            return res;
        }
        public static byte Q120131(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Venom Monsters in Redcloud Marsh and take back to Vermal.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 289328, 9000, 0, 10557);
            return res;
        }
        public static byte A120131(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Venom Monsters in Redcloud Marsh and take back to Vermal.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120131, 509001, 2, 0, 509, 50, 509001);
            c.Player.quest.AddPack(120131, 509002, 509);
            return res;
        }
        public static byte Q120132(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Medusa in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 311799, 9200, 0, 12952);

            c.Player.quest.AddTaskAccept(120133, 508011, 508);
            return res;
        }
        public static byte A120132(ConnectionInfo c, int QuestID)
        {
            //Catch 50 Medusa in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120132, 509003, 2, 0, 509, 50, 509003);
            c.Player.quest.AddPack(120132, 508011, 508);
            return res;
        }
        public static byte Q120133(ConnectionInfo c, int QuestID)
        {
            //Ask Simona to analyze the crystal crumble.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 311799, 9200, 0, 12952);

            c.Player.quest.AddTaskAccept(120134, 509005, 509);
            return res;
        }
        public static byte A120133(ConnectionInfo c, int QuestID)
        {
            //Ask Simona to analyze the crystal crumble.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120133, 509005, 1, 1, 509);
            return res;
        }
        public static byte Q120134(ConnectionInfo c, int QuestID)
        {
            //Tell Raymond Simona\'s analysis result.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 311799, 9200, 0, 12952);
            return res;
        }
        public static byte A120134(ConnectionInfo c, int QuestID)
        {
            //Tell Raymond Simona\'s analysis result.
            if (QuestCommand.CanQuest(c, 53)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120134, 508011, 1, 1, 508);
            return res;
        }
        public static byte Q120135(ConnectionInfo c, int QuestID)
        {
            //Tell Raymond that Serena needs a bottle of colorant.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 335340, 9150, 0, 9987);

            c.Player.quest.AddTaskAccept(120136, 508011, 508);
            return res;
        }
        public static byte A120135(ConnectionInfo c, int QuestID)
        {
            //Tell Raymond that Serena needs a bottle of colorant.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120135, 508011, 1, 1, 508);
            return res;
        }
        public static byte Q120136(ConnectionInfo c, int QuestID)
        {
            //Catch 20 Venom Monsters, 20 Medusa and 20 Mugger Crocodiles in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 335340, 9150, 0, 9987);

            c.Player.quest.AddTaskAccept(120137, 508011, 508);
            return res;
        }
        public static byte A120136(ConnectionInfo c, int QuestID)
        {
            //Catch 20 Venom Monsters, 20 Medusa and 20 Mugger Crocodiles in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120136, 509001, 2, 0, 509, 20, 509001);
            c.Player.quest.AddTaskComplete(120136, 509003, 2, 0, 509, 20, 509003);
            c.Player.quest.AddTaskComplete(120136, 509004, 2, 0, 509, 20, 509004);
            c.Player.quest.AddPack(120136, 508011, 508);
            return res;
        }
        public static byte Q120137(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Greenbell Flowers in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 335340, 9150, 0, 9987);
            return res;
        }
        public static byte A120137(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Greenbell Flowers in Redcloud Marsh and take back to Raymond.
            if (QuestCommand.CanQuest(c, 54)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120137, 5010069, 4, 0, 509, 6, 509103);
            c.Player.quest.AddPack(120137, 508011, 508);
            return res;
        }
        public static byte Q120138(ConnectionInfo c, int QuestID)
        {
            //Tell Bertram the news that his brother is murdered.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 359975, 9430, 0, 9765);

            c.Player.quest.AddTaskAccept(120139, 509003, 509);
            return res;
        }
        public static byte A120138(ConnectionInfo c, int QuestID)
        {
            //Tell Bertram the news that his brother is murdered.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120138, 509003, 1, 1, 509);
            return res;
        }
        public static byte Q120139(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Carrion in Redcloud Marsh and then tell Bertram.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 359975, 9430, 0, 9765);

            c.Player.quest.AddTaskAccept(120140, 509003, 509);
            return res;
        }
        public static byte A120139(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Carrion in Redcloud Marsh and then tell Bertram.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120139, 509005, 2, 0, 509, 55, 509005);
            c.Player.quest.AddPack(120139, 509003, 509);
            return res;
        }
        public static byte Q120140(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Giant Carrion in Redcloud Marsh and then tell Bertram.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 359975, 9430, 0, 9765);
            return res;
        }
        public static byte A120140(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Giant Carrion in Redcloud Marsh and then tell Bertram.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120140, 509007, 2, 0, 509, 5, 509007);
            c.Player.quest.AddPack(120140, 509003, 509);
            return res;
        }
        public static byte Q120141(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Carrion in Redcloud Marsh and then tell Serena.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 385728, 9500, 0, 10279);
            return res;
        }
        public static byte A120141(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Carrion in Redcloud Marsh and then tell Serena.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120141, 509005, 2, 0, 509, 55, 509005);
            c.Player.quest.AddPack(120141, 509006, 509);
            return res;
        }
        public static byte Q120142(ConnectionInfo c, int QuestID)
        {
            //Ask Rodney where to find the stones to build house.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 385728, 9500, 0, 10279);

            c.Player.quest.AddTaskAccept(120143, 508012, 508);
            return res;
        }
        public static byte A120142(ConnectionInfo c, int QuestID)
        {
            //Ask Rodney where to find the stones to build house.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120142, 508012, 1, 1, 508);
            return res;
        }
        public static byte Q120143(ConnectionInfo c, int QuestID)
        {
            //Catch 55 Short-wing Rats in Redcloud Marsh and take back to Rodney.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 385728, 9500, 0, 10279);
            return res;
        }
        public static byte A120143(ConnectionInfo c, int QuestID)
        {
            //Catch 55 Short-wing Rats in Redcloud Marsh and take back to Rodney.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120143, 509002, 2, 0, 509, 55, 509002);
            c.Player.quest.AddPack(120143, 508012, 508);
            return res;
        }
        public static byte Q120144(ConnectionInfo c, int QuestID)
        {
            //Tell Blair Osmond\'s requirement and conditions.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 412623, 9600, 0, 10456);

            c.Player.quest.AddTaskAccept(120145, 509004, 509);
            return res;
        }
        public static byte A120144(ConnectionInfo c, int QuestID)
        {
            //Tell Blair Osmond\'s requirement and conditions.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120144, 509004, 1, 1, 509);
            return res;
        }
        public static byte Q120145(ConnectionInfo c, int QuestID)
        {
            //Catch 55 Mugger Crocodiles in Redcloud Marsh and take back to Blair.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 412623, 9600, 0, 10456);

            c.Player.quest.AddTaskAccept(120146, 509004, 509);
            return res;
        }
        public static byte A120145(ConnectionInfo c, int QuestID)
        {
            //Catch 55 Mugger Crocodiles in Redcloud Marsh and take back to Blair.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120145, 509004, 2, 0, 509, 55, 509004);
            c.Player.quest.AddPack(120145, 509004, 509);
            return res;
        }
        public static byte Q120146(ConnectionInfo c, int QuestID)
        {
            //Catch 55 Short-wing Rats in Redcloud Marsh and take back to Blair.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 412623, 9600, 0, 10456);
            return res;
        }
        public static byte A120146(ConnectionInfo c, int QuestID)
        {
            //Catch 55 Short-wing Rats in Redcloud Marsh and take back to Blair.
            if (QuestCommand.CanQuest(c, 57)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120146, 509002, 2, 0, 509, 55, 509002);
            c.Player.quest.AddPack(120146, 509004, 509);
            return res;
        }
        public static byte Q120147(ConnectionInfo c, int QuestID)
        {
            //Tell Mabel Osmond\'s task and ask her to find out the truth asap.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 440684, 9700, 0, 11973);

            c.Player.quest.AddTaskAccept(120148, 508013, 508);
            return res;
        }
        public static byte A120147(ConnectionInfo c, int QuestID)
        {
            //Tell Mabel Osmond\'s task and ask her to find out the truth asap.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120147, 508013, 1, 1, 508);
            return res;
        }
        public static byte Q120148(ConnectionInfo c, int QuestID)
        {
            //Tell Osmond Mabel\'s findings.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 440684, 9700, 0, 11973);

            c.Player.quest.AddTaskAccept(120149, 508010, 508);
            return res;
        }
        public static byte A120148(ConnectionInfo c, int QuestID)
        {
            //Tell Osmond Mabel\'s findings.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120148, 508010, 1, 1, 508);
            return res;
        }
        public static byte Q120149(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Carrion in Redcloud Marsh and then tell Osmond.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 440684, 9700, 0, 11973);
            return res;
        }
        public static byte A120149(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Carrion in Redcloud Marsh and then tell Osmond.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120149, 509005, 2, 0, 509, 55, 509005);
            c.Player.quest.AddPack(120149, 508010, 508);
            return res;
        }
        public static byte Q120150(ConnectionInfo c, int QuestID)
        {
            //Help Weisz to ask Serena the materials for making quality leather bag.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 469935, 9750, 0, 13371);

            c.Player.quest.AddTaskAccept(120151, 509006, 509);
            return res;
        }
        public static byte A120150(ConnectionInfo c, int QuestID)
        {
            //Help Weisz to ask Serena the materials for making quality leather bag.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120150, 509006, 1, 1, 509);
            return res;
        }
        public static byte Q120151(ConnectionInfo c, int QuestID)
        {
            //Tell Weisz Serena\'s advice.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 469935, 9750, 0, 13371);

            c.Player.quest.AddTaskAccept(120152, 509001, 509);
            return res;
        }
        public static byte A120151(ConnectionInfo c, int QuestID)
        {
            //Tell Weisz Serena\'s advice.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120151, 509001, 1, 1, 509);
            return res;
        }
        public static byte Q120152(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Mugger Crocodiles in Redcloud Marsh and take the crocodile skin to Weisz.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 469935, 9750, 0, 13371);
            return res;
        }
        public static byte A120152(ConnectionInfo c, int QuestID)
        {
            //Kill 55 Mugger Crocodiles in Redcloud Marsh and take the crocodile skin to Weisz.
            if (QuestCommand.CanQuest(c, 59)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120152, 509004, 2, 0, 509, 55, 509004);
            c.Player.quest.AddPack(120152, 509001, 509);
            return res;
        }
        public static byte Q120153(ConnectionInfo c, int QuestID)
        {
            //Ask Angelo the where Atwood is.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 500400, 9500, 0, 10181);

            c.Player.quest.AddTaskAccept(120154, 511001, 511);
            return res;
        }
        public static byte A120153(ConnectionInfo c, int QuestID)
        {
            //Ask Angelo the where Atwood is.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120153, 511001, 1, 1, 511);
            return res;
        }
        public static byte Q120154(ConnectionInfo c, int QuestID)
        {
            //Ask Omar to make some potions that can remove petrification.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 500400, 9500, 0, 10181);

            c.Player.quest.AddTaskAccept(120155, 510009, 510);
            return res;
        }
        public static byte A120154(ConnectionInfo c, int QuestID)
        {
            //Ask Omar to make some potions that can remove petrification.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120154, 510009, 1, 1, 510);
            return res;
        }
        public static byte Q120155(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Stone Lizards in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 500400, 9500, 0, 10181);
            return res;
        }
        public static byte A120155(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Stone Lizards in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 60)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120155, 511004, 2, 0, 511, 60, 511004);
            c.Player.quest.AddPack(120155, 510009, 510);
            return res;
        }
        public static byte Q120156(ConnectionInfo c, int QuestID)
        {
            //Kill 60 Darkwind Wolves in Darkwind Canyon and then tell Bertha.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 532103, 9550, 0, 11376);

            c.Player.quest.AddTaskAccept(120157, 511005, 511);
            return res;
        }
        public static byte A120156(ConnectionInfo c, int QuestID)
        {
            //Kill 60 Darkwind Wolves in Darkwind Canyon and then tell Bertha.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120156, 511001, 2, 0, 511, 60, 511001);
            c.Player.quest.AddPack(120156, 511005, 511);
            return res;
        }
        public static byte Q120157(ConnectionInfo c, int QuestID)
        {
            //Find Morgan, ask him to identify the thing Bertha just dug out.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 532103, 9550, 0, 11376);

            c.Player.quest.AddTaskAccept(120158, 510010, 510);
            return res;
        }
        public static byte A120157(ConnectionInfo c, int QuestID)
        {
            //Find Morgan, ask him to identify the thing Bertha just dug out.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120157, 510010, 1, 1, 510);
            return res;
        }
        public static byte Q120158(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Morgan.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 532103, 9550, 0, 11376);
            return res;
        }
        public static byte A120158(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Morgan.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120158, 511005, 2, 0, 511, 60, 511005);
            c.Player.quest.AddPack(120158, 510010, 510);
            return res;
        }
        public static byte Q120159(ConnectionInfo c, int QuestID)
        {
            //Ask Atwood about being smashed.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 565068, 9575, 0, 13145);

            c.Player.quest.AddTaskAccept(120160, 511003, 511);
            return res;
        }
        public static byte A120159(ConnectionInfo c, int QuestID)
        {
            //Ask Atwood about being smashed.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120159, 511003, 1, 1, 511);
            return res;
        }
        public static byte Q120160(ConnectionInfo c, int QuestID)
        {
            //Ask Bella what kind of beast Black Dot is.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 565068, 9575, 0, 13145);

            c.Player.quest.AddTaskAccept(120161, 511006, 511);
            return res;
        }
        public static byte A120160(ConnectionInfo c, int QuestID)
        {
            //Ask Bella what kind of beast Black Dot is.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120160, 511006, 1, 1, 511);
            return res;
        }
        public static byte Q120161(ConnectionInfo c, int QuestID)
        {
            //Kill 60 Canyon Eagles in Darkwind Canyon and then tell Bella.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 565068, 9575, 0, 13145);
            return res;
        }
        public static byte A120161(ConnectionInfo c, int QuestID)
        {
            //Kill 60 Canyon Eagles in Darkwind Canyon and then tell Bella.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120161, 511002, 2, 0, 511, 60, 511002);
            c.Player.quest.AddPack(120161, 511006, 511);
            return res;
        }
        public static byte Q120162(ConnectionInfo c, int QuestID)
        {
            //Ask Angelo why Canyon Eagle attacked human.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 449490, 8895, 0, 9078);

            c.Player.quest.AddTaskAccept(120163, 511001, 511);
            return res;
        }
        public static byte A120162(ConnectionInfo c, int QuestID)
        {
            //Ask Angelo why Canyon Eagle attacked human.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120162, 511001, 1, 1, 511);
            return res;
        }
        public static byte Q120163(ConnectionInfo c, int QuestID)
        {
            //Kill 60 Canyon Centaurs in Darkwind Canyon and then tell Angelo.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 449490, 8895, 0, 9078);
            return res;
        }
        public static byte A120163(ConnectionInfo c, int QuestID)
        {
            //Kill 60 Canyon Centaurs in Darkwind Canyon and then tell Angelo.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120163, 511005, 2, 0, 511, 60, 511005);
            c.Player.quest.AddPack(120163, 511001, 511);
            return res;
        }
        public static byte Q120164(ConnectionInfo c, int QuestID)
        {
            //Ask Omar if there\'s anything that can help Jeffrey to sleep.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 449490, 8895, 0, 9078);

            c.Player.quest.AddTaskAccept(120165, 510009, 510);
            return res;
        }
        public static byte A120164(ConnectionInfo c, int QuestID)
        {
            //Ask Omar if there\'s anything that can help Jeffrey to sleep.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120164, 510009, 1, 1, 510);
            return res;
        }
        public static byte Q120165(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Stone Lizards in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 449490, 8895, 0, 9078);
            return res;
        }
        public static byte A120165(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Stone Lizards in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 63)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120165, 511004, 2, 0, 511, 60, 511004);
            c.Player.quest.AddPack(120165, 510009, 510);
            return res;
        }
        public static byte Q120166(ConnectionInfo c, int QuestID)
        {
            //Ask Bertha what kind of pact with beast she wants.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 634880, 9720, 0, 13785);

            c.Player.quest.AddTaskAccept(120167, 511005, 511);
            return res;
        }
        public static byte A120166(ConnectionInfo c, int QuestID)
        {
            //Ask Bertha what kind of pact with beast she wants.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120166, 511005, 1, 1, 511);
            return res;
        }
        public static byte Q120167(ConnectionInfo c, int QuestID)
        {
            //Tell Theodore Bertha\'s decision.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 634880, 9720, 0, 13785);

            c.Player.quest.AddTaskAccept(120168, 510011, 510);
            return res;
        }
        public static byte A120167(ConnectionInfo c, int QuestID)
        {
            //Tell Theodore Bertha\'s decision.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120167, 510011, 1, 1, 510);
            return res;
        }
        public static byte Q120168(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Darkwind Hunters in Darkwind Canyon and bring them back to Theodore.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 634880, 9720, 0, 13785);
            return res;
        }
        public static byte A120168(ConnectionInfo c, int QuestID)
        {
            //Catch 60 Darkwind Hunters in Darkwind Canyon and bring them back to Theodore.
            if (QuestCommand.CanQuest(c, 64)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120168, 511003, 2, 0, 511, 60, 511003);
            c.Player.quest.AddPack(120168, 510011, 510);
            return res;
        }
        public static byte Q120169(ConnectionInfo c, int QuestID)
        {
            //Ask Jeffrey if there\'s a way to calm down the wolves in the canyon.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 671775, 9888, 0, 12634);

            c.Player.quest.AddTaskAccept(120170, 510008, 510);
            return res;
        }
        public static byte A120169(ConnectionInfo c, int QuestID)
        {
            //Ask Jeffrey if there\'s a way to calm down the wolves in the canyon.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120169, 510008, 1, 1, 510);
            return res;
        }
        public static byte Q120170(ConnectionInfo c, int QuestID)
        {
            //Kill 65 Darkwind Wolves in Darkwind Canyon and then report to Jeffrey.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 671775, 9888, 0, 13634);

            c.Player.quest.AddTaskAccept(120171, 510008, 510);
            return res;
        }
        public static byte A120170(ConnectionInfo c, int QuestID)
        {
            //Kill 65 Darkwind Wolves in Darkwind Canyon and then report to Jeffrey.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120170, 511001, 2, 0, 511, 65, 511001);
            c.Player.quest.AddPack(120170, 510008, 510);
            return res;
        }
        public static byte Q120171(ConnectionInfo c, int QuestID)
        {
            //Tell Angelo about Jeffrey\'s warning, asking him not to confront the werewolves directly.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 671775, 9888, 0, 12634);
            return res;
        }
        public static byte A120171(ConnectionInfo c, int QuestID)
        {
            //Tell Angelo about Jeffrey\'s warning, asking him not to confront the werewolves directly.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120171, 511001, 1, 1, 511);
            return res;
        }
        public static byte Q120172(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Veronica.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 710028, 9760, 0, 11974);

            c.Player.quest.AddTaskAccept(120173, 510014, 510);
            return res;
        }
        public static byte A120172(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Veronica.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120172, 511003, 2, 0, 511, 65, 511003);
            c.Player.quest.AddPack(120172, 510014, 510);
            return res;
        }
        public static byte Q120173(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Veronica.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 710028, 9760, 0, 11974);

            c.Player.quest.AddTaskAccept(120174, 510014, 510);
            return res;
        }
        public static byte A120173(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Veronica.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120173, 511001, 2, 0, 511, 65, 511001);
            c.Player.quest.AddPack(120173, 510014, 510);
            return res;
        }
        public static byte Q120174(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Eagles in Darkwind Canyon and bring them back to Veronica.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 710028, 9760, 0, 11974);
            return res;
        }
        public static byte A120174(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Eagles in Darkwind Canyon and bring them back to Veronica.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120174, 511002, 2, 0, 511, 65, 511002);
            c.Player.quest.AddPack(120174, 510014, 510);
            return res;
        }
        public static byte Q120175(ConnectionInfo c, int QuestID)
        {
            //Ask Alger about how to deal with Canyon Centaur.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 749663, 9917, 0, 12743);

            c.Player.quest.AddTaskAccept(120176, 510006, 510);
            return res;
        }
        public static byte A120175(ConnectionInfo c, int QuestID)
        {
            //Ask Alger about how to deal with Canyon Centaur.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120175, 510006, 1, 1, 510);
            return res;
        }
        public static byte Q120176(ConnectionInfo c, int QuestID)
        {
            //Kill 3 Head Centaurs in Darkwind Canyon and then tell Alger.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 749663, 9917, 0, 12743);

            c.Player.quest.AddTaskAccept(120177, 510006, 510);
            return res;
        }
        public static byte A120176(ConnectionInfo c, int QuestID)
        {
            //Kill 3 Head Centaurs in Darkwind Canyon and then tell Alger.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120176, 511006, 2, 0, 511, 3, 511006);
            c.Player.quest.AddPack(120176, 510006, 510);
            return res;
        }
        public static byte Q120177(ConnectionInfo c, int QuestID)
        {
            //Kill 65 Canyon Centaurs in Darkwind Canyon and then tell Alger.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 749663, 9917, 0, 12743);
            return res;
        }
        public static byte A120177(ConnectionInfo c, int QuestID)
        {
            //Kill 65 Canyon Centaurs in Darkwind Canyon and then tell Alger.
            if (QuestCommand.CanQuest(c, 67)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120177, 511005, 2, 0, 511, 65, 511005);
            c.Player.quest.AddPack(120177, 510006, 510);
            return res;
        }
        public static byte Q120178(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 790704, 9897, 0, 11095);

            c.Player.quest.AddTaskAccept(120179, 510009, 510);
            return res;
        }
        public static byte A120178(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120178, 511001, 2, 0, 511, 65, 511001);
            c.Player.quest.AddPack(120178, 510009, 510);
            return res;
        }
        public static byte Q120179(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 790704, 9897, 0, 11095);

            c.Player.quest.AddTaskAccept(120180, 510009, 510);
            return res;
        }
        public static byte A120179(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120179, 511003, 2, 0, 511, 65, 511003);
            c.Player.quest.AddPack(120179, 510009, 510);
            return res;
        }
        public static byte Q120180(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Stone Lizards in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 790704, 9897, 0, 11095);
            return res;
        }
        public static byte A120180(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Stone Lizards in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120180, 511004, 2, 0, 511, 65, 511004);
            c.Player.quest.AddPack(120180, 510009, 510);
            return res;
        }
        public static byte Q120181(ConnectionInfo c, int QuestID)
        {
            //Ask Omar if there\'s a way to make a potion that contains wind element.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 833175, 10105, 0, 12306);

            c.Player.quest.AddTaskAccept(120182, 510009, 510);
            return res;
        }
        public static byte A120181(ConnectionInfo c, int QuestID)
        {
            //Ask Omar if there\'s a way to make a potion that contains wind element.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120181, 510009, 1, 1, 510);
            return res;
        }
        public static byte Q120182(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Canyon Eagles in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 833175, 10105, 0, 12306);

            c.Player.quest.AddTaskAccept(120183, 510009, 510);
            return res;
        }
        public static byte A120182(ConnectionInfo c, int QuestID)
        {
            //Catch 65 Canyon Eagles in Darkwind Canyon and bring them back to Omar.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120182, 511002, 2, 0, 511, 65, 511002);
            c.Player.quest.AddPack(120182, 510009, 510);
            return res;
        }
        public static byte Q120183(ConnectionInfo c, int QuestID)
        {
            //Bring the wind crystal stone made by Omar to Amos.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 833175, 10105, 0, 12306);
            return res;
        }
        public static byte A120183(ConnectionInfo c, int QuestID)
        {
            //Bring the wind crystal stone made by Omar to Amos.
            if (QuestCommand.CanQuest(c, 69)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120183, 510007, 1, 1, 510);
            return res;
        }
        public static byte Q120184(ConnectionInfo c, int QuestID)
        {
            //Ask Gavin whether beasts to be used in this year\'s Beast\'s Festival are ready.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 877100, 10200, 0, 12500);

            c.Player.quest.AddTaskAccept(120185, 513004, 513);
            return res;
        }
        public static byte A120184(ConnectionInfo c, int QuestID)
        {
            //Ask Gavin whether beasts to be used in this year\'s Beast\'s Festival are ready.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120184, 513004, 1, 1, 513);
            return res;
        }
        public static byte Q120185(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Vampires in Foggy Forest and bring them back to Francis.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 877100, 10200, 0, 12500);

            c.Player.quest.AddTaskAccept(120186, 513004, 513);
            return res;
        }
        public static byte A120185(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Vampires in Foggy Forest and bring them back to Francis.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120185, 513001, 2, 0, 513, 70, 513001);
            c.Player.quest.AddPack(120185, 513004, 513);
            return res;
        }
        public static byte Q120186(ConnectionInfo c, int QuestID)
        {
            //Bring the Foggy Vampire trained by Gavin to Francis.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 877100, 10200, 0, 12500);
            return res;
        }
        public static byte A120186(ConnectionInfo c, int QuestID)
        {
            //Bring the Foggy Vampire trained by Gavin to Francis.
            if (QuestCommand.CanQuest(c, 70)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120186, 513001, 1, 1, 513);
            return res;
        }
        public static byte Q120187(ConnectionInfo c, int QuestID)
        {
            //Help Cesar to ask Xaviera if she received the gift.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 922503, 10500, 0, 12850);

            c.Player.quest.AddTaskAccept(120188, 512013, 512);
            return res;
        }
        public static byte A120187(ConnectionInfo c, int QuestID)
        {
            //Help Cesar to ask Xaviera if she received the gift.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120187, 512013, 1, 1, 512);
            return res;
        }
        public static byte Q120188(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Bears in Foggy Forest and then tell Xaviera.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 922503, 10500, 0, 12850);

            c.Player.quest.AddTaskAccept(120189, 512013, 512);
            return res;
        }
        public static byte A120188(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Bears in Foggy Forest and then tell Xaviera.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120188, 513003, 2, 0, 513, 70, 513003);
            c.Player.quest.AddPack(120188, 512013, 512);
            return res;
        }
        public static byte Q120189(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Foggy Roses in Foggy Forest and bring them back to Xaviera.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 922503, 10500, 0, 12850);
            return res;
        }
        public static byte A120189(ConnectionInfo c, int QuestID)
        {
            //Collect 6 Foggy Roses in Foggy Forest and bring them back to Xaviera.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120189, 5010072, 4, 0, 513, 6, 513101);
            c.Player.quest.AddPack(120189, 512013, 512);
            return res;
        }
        public static byte Q120190(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Spiders in Foggy Forest and bring them back to Cyril.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 969408, 10380, 0, 12000);

            c.Player.quest.AddTaskAccept(120191, 512010, 512);
            return res;
        }
        public static byte A120190(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Spiders in Foggy Forest and bring them back to Cyril.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120190, 513002, 2, 0, 513, 70, 513002);
            c.Player.quest.AddPack(120190, 512010, 512);
            return res;
        }
        public static byte Q120191(ConnectionInfo c, int QuestID)
        {
            //Bring the fried spider leg made by Cyril to Claire.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 969408, 10380, 0, 12000);

            c.Player.quest.AddTaskAccept(120192, 513006, 513);
            return res;
        }
        public static byte A120191(ConnectionInfo c, int QuestID)
        {
            //Bring the fried spider leg made by Cyril to Claire.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120191, 513006, 1, 1, 513);
            return res;
        }
        public static byte Q120192(ConnectionInfo c, int QuestID)
        {
            //Catch 70 Foggy Bears in Foggy Forest and bring them back to Claire.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 969408, 10380, 0, 12000);
            return res;
        }
        public static byte A120192(ConnectionInfo c, int QuestID)
        {
            //Catch 70 Foggy Bears in Foggy Forest and bring them back to Claire.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120192, 513003, 2, 0, 513, 70, 513003);
            c.Player.quest.AddPack(120192, 513006, 513);
            return res;
        }
        public static byte Q120193(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman to make a Promotion Test for you.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1017839, 10680, 0, 12650);

            c.Player.quest.AddTaskAccept(120194, 512008, 512);
            return res;
        }
        public static byte A120193(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman to make a Promotion Test for you.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120193, 512008, 1, 1, 512);
            return res;
        }
        public static byte Q120194(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Vampires in Foggy Forest and them tell Jabman.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1017839, 10680, 0, 12650);

            c.Player.quest.AddTaskAccept(120195, 512008, 512);
            return res;
        }
        public static byte A120194(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Foggy Vampires in Foggy Forest and them tell Jabman.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120194, 513001, 2, 0, 513, 70, 513001);
            c.Player.quest.AddPack(120194, 512008, 512);
            return res;
        }
        public static byte Q120195(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks in Foggy Forest and then tell Jabman.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1017839, 10680, 0, 12650);
            return res;
        }
        public static byte A120195(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks in Foggy Forest and then tell Jabman.
            if (QuestCommand.CanQuest(c, 73)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120195, 513006, 2, 0, 513, 5, 513006);
            c.Player.quest.AddPack(120195, 512008, 512);
            return res;
        }
        public static byte Q120196(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Dawn Elves in Foggy Forest and then tell Gavin.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1067820, 11150, 0, 13500);

            c.Player.quest.AddTaskAccept(120197, 513004, 513);
            return res;
        }
        public static byte A120196(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Dawn Elves in Foggy Forest and then tell Gavin.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120196, 513005, 2, 0, 513, 70, 513005);
            c.Player.quest.AddPack(120196, 513004, 513);
            return res;
        }
        public static byte Q120197(ConnectionInfo c, int QuestID)
        {
            //Tell Dark Castle\'s Jabman about Gavin\'s finding.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1067820, 11150, 0, 13500);
            return res;
        }
        public static byte A120197(ConnectionInfo c, int QuestID)
        {
            //Tell Dark Castle\'s Jabman about Gavin\'s finding.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120197, 512008, 1, 1, 512);
            return res;
        }
        public static byte Q120198(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Berserk Warriors in Foggy Forest and then tell Teddy.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1067820, 11150, 0, 13500);
            return res;
        }
        public static byte A120198(ConnectionInfo c, int QuestID)
        {
            //Kill 70 Berserk Warriors in Foggy Forest and then tell Teddy.
            if (QuestCommand.CanQuest(c, 74)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120198, 513004, 2, 0, 513, 70, 513004);
            c.Player.quest.AddPack(120198, 512011, 512);
            return res;
        }
        public static byte Q120199(ConnectionInfo c, int QuestID)
        {
            //Go to Dark Castle and ask Inquiry how to solve the problem of too cold to sleep.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1119375, 11665, 0, 13650);

            c.Player.quest.AddTaskAccept(120200, 512012, 512);
            return res;
        }
        public static byte A120199(ConnectionInfo c, int QuestID)
        {
            //Go to Dark Castle and ask Inquiry how to solve the problem of too cold to sleep.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120199, 512012, 1, 1, 512);
            return res;
        }
        public static byte Q120200(ConnectionInfo c, int QuestID)
        {
            //Kill 75 Foggy Spiders in Foggy Forest and bring them back to Zelene.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1119375, 11665, 0, 13650);

            c.Player.quest.AddTaskAccept(120201, 512012, 512);
            return res;
        }
        public static byte A120200(ConnectionInfo c, int QuestID)
        {
            //Kill 75 Foggy Spiders in Foggy Forest and bring them back to Zelene.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120200, 513002, 2, 0, 513, 75, 513002);
            c.Player.quest.AddPack(120200, 512012, 512);
            return res;
        }
        public static byte Q120201(ConnectionInfo c, int QuestID)
        {
            //Bring the cobweb extracted by Zelene to Candice.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1119375, 11665, 0, 13650);
            return res;
        }
        public static byte A120201(ConnectionInfo c, int QuestID)
        {
            //Bring the cobweb extracted by Zelene to Candice.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120201, 513005, 1, 1, 513);
            return res;
        }
        public static byte Q120202(ConnectionInfo c, int QuestID)
        {
            //Ask Gavin for a batch of magic scrolls.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1172528, 11837, 0, 13350);

            c.Player.quest.AddTaskAccept(120203, 513004, 513);
            return res;
        }
        public static byte A120202(ConnectionInfo c, int QuestID)
        {
            //Ask Gavin for a batch of magic scrolls.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120202, 513004, 1, 1, 513);
            return res;
        }
        public static byte Q120203(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Foggy Bears in Foggy Forest and bring them back to Gavin.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1172528, 11837, 0, 13350);

            c.Player.quest.AddTaskAccept(120204, 513004, 513);
            return res;
        }
        public static byte A120203(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Foggy Bears in Foggy Forest and bring them back to Gavin.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120203, 513003, 2, 0, 513, 75, 513003);
            c.Player.quest.AddPack(120203, 513004, 513);
            return res;
        }
        public static byte Q120204(ConnectionInfo c, int QuestID)
        {
            //Bring the foggy bear fur made by Gavin to Yuna.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1172528, 11837, 0, 13350);
            return res;
        }
        public static byte A120204(ConnectionInfo c, int QuestID)
        {
            //Bring the foggy bear fur made by Gavin to Yuna.
            if (QuestCommand.CanQuest(c, 76)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120204, 512014, 1, 1, 512);
            return res;
        }
        public static byte Q120205(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Berserk Warriors in Foggy Forest and bring them back to Parker.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1227303, 11985, 0, 13785);

            c.Player.quest.AddTaskAccept(120206, 513002, 513);
            return res;
        }
        public static byte A120205(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Berserk Warriors in Foggy Forest and bring them back to Parker.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120205, 513004, 2, 0, 513, 75, 513004);
            c.Player.quest.AddPack(120205, 513002, 513);
            return res;
        }
        public static byte Q120206(ConnectionInfo c, int QuestID)
        {
            //Catch 5 Head Berserks in Foggy Forest and bring them back to Parker.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1227303, 11985, 0, 13785);

            c.Player.quest.AddTaskAccept(120207, 513002, 513);
            return res;
        }
        public static byte A120206(ConnectionInfo c, int QuestID)
        {
            //Catch 5 Head Berserks in Foggy Forest and bring them back to Parker.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120206, 513006, 2, 0, 513, 5, 513006);
            c.Player.quest.AddPack(120206, 513002, 513);
            return res;
        }
        public static byte Q120207(ConnectionInfo c, int QuestID)
        {
            //Tell Claymond about Parker\'s finding.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1227303, 11985, 0, 13785);
            return res;
        }
        public static byte A120207(ConnectionInfo c, int QuestID)
        {
            //Tell Claymond about Parker\'s finding.
            if (QuestCommand.CanQuest(c, 77)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120207, 512009, 1, 1, 512);
            return res;
        }
        public static byte Q120208(ConnectionInfo c, int QuestID)
        {
            //Tell Dark about Jabman\'s instructions.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1283724, 12500, 0, 13665);

            c.Player.quest.AddTaskAccept(120209, 513003, 513);
            return res;
        }
        public static byte A120208(ConnectionInfo c, int QuestID)
        {
            //Tell Dark about Jabman\'s instructions.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120208, 513003, 1, 1, 513);
            return res;
        }
        public static byte Q120209(ConnectionInfo c, int QuestID)
        {
            //Catch 3000 Foggy Vampires in Foggy Forest and bring them back to Dark.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1283724, 12500, 0, 13665);

            c.Player.quest.AddTaskAccept(120210, 513003, 513);
            return res;
        }
        public static byte A120209(ConnectionInfo c, int QuestID)
        {
            //Catch 3000 Foggy Vampires in Foggy Forest and bring them back to Dark.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120209, 513001, 2, 0, 513, 3000, 513001);
            c.Player.quest.AddPack(120209, 513003, 513);
            return res;
        }
        public static byte Q120210(ConnectionInfo c, int QuestID)
        {
            //Tell Jabman that Dark is training Foggy Vampire.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1283724, 12500, 0, 13665);
            return res;
        }
        public static byte A120210(ConnectionInfo c, int QuestID)
        {
            //Tell Jabman that Dark is training Foggy Vampire.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120210, 512008, 1, 1, 512);
            return res;
        }
        public static byte Q120211(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman how to break through the magic barrier.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1341815, 12800, 0, 13985);

            c.Player.quest.AddTaskAccept(120212, 512008, 512);
            return res;
        }
        public static byte A120211(ConnectionInfo c, int QuestID)
        {
            //Ask Jabman how to break through the magic barrier.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120211, 512008, 1, 1, 512);
            return res;
        }
        public static byte Q120212(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Foggy Spiders in Foggy Forest and bring them back to Jabman.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1341815, 12800, 0, 13985);

            c.Player.quest.AddTaskAccept(120213, 512008, 512);
            return res;
        }
        public static byte A120212(ConnectionInfo c, int QuestID)
        {
            //Catch 75 Foggy Spiders in Foggy Forest and bring them back to Jabman.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120212, 513002, 2, 0, 513, 75, 513002);
            c.Player.quest.AddPack(120212, 512008, 512);
            return res;
        }
        public static byte Q120213(ConnectionInfo c, int QuestID)
        {
            //Bring the Foggy Spider trained by Jabman to Gavin.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1341815, 12800, 0, 13985);
            return res;
        }
        public static byte A120213(ConnectionInfo c, int QuestID)
        {
            //Bring the Foggy Spider trained by Jabman to Gavin.
            if (QuestCommand.CanQuest(c, 79)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120213, 513004, 1, 1, 513);
            return res;
        }
        public static byte Q120214(ConnectionInfo c, int QuestID)
        {
            //Help Isaac to ask Jonas if he had any new findings.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1401600, 12500, 0, 14000);

            c.Player.quest.AddTaskAccept(120215, 514010, 514);
            return res;
        }
        public static byte A120214(ConnectionInfo c, int QuestID)
        {
            //Help Isaac to ask Jonas if he had any new findings.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120214, 514010, 1, 1, 514);
            return res;
        }
        public static byte Q120215(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Lost Acolytes on the Henan Mountainside and bring them to Jonas.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1401600, 12500, 0, 14000);

            c.Player.quest.AddTaskAccept(120216, 514010, 514);
            return res;
        }
        public static byte A120215(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Lost Acolytes on the Henan Mountainside and bring them to Jonas.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120215, 515002, 2, 0, 515, 80, 515002);
            c.Player.quest.AddPack(120215, 514010, 514);
            return res;
        }
        public static byte Q120216(ConnectionInfo c, int QuestID)
        {
            //Go to Henan Mountain and tell Isaac Jonas\'s discovery.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1401600, 12500, 0, 14000);
            return res;
        }
        public static byte A120216(ConnectionInfo c, int QuestID)
        {
            //Go to Henan Mountain and tell Isaac Jonas\'s discovery.
            if (QuestCommand.CanQuest(c, 80)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120216, 514007, 1, 1, 514);
            return res;
        }
        public static byte Q120217(ConnectionInfo c, int QuestID)
        {
            //Follow Marlon\'s order and go to Henan Mountainside to find Nate.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1463103, 12900, 0, 14100);

            c.Player.quest.AddTaskAccept(120218, 515004, 515);
            return res;
        }
        public static byte A120217(ConnectionInfo c, int QuestID)
        {
            //Follow Marlon\'s order and go to Henan Mountainside to find Nate.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120217, 515004, 1, 1, 515);
            return res;
        }
        public static byte Q120218(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Carefree Beasts on the Henan Mountainside and bring them to Nate.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1463103, 12900, 0, 14100);

            c.Player.quest.AddTaskAccept(120219, 515004, 515);
            return res;
        }
        public static byte A120218(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Carefree Beasts on the Henan Mountainside and bring them to Nate.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120218, 515004, 2, 0, 515, 80, 515004);
            c.Player.quest.AddPack(120218, 515004, 515);
            return res;
        }
        public static byte Q120219(ConnectionInfo c, int QuestID)
        {
            //Give Marlon the Carefree Beast\'s Blood that collected by Nade.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1463103, 12900, 0, 14100);
            return res;
        }
        public static byte A120219(ConnectionInfo c, int QuestID)
        {
            //Give Marlon the Carefree Beast\'s Blood that collected by Nade.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120219, 515002, 1, 1, 515);
            return res;
        }
        public static byte Q120220(ConnectionInfo c, int QuestID)
        {
            //Ask Lance about the way of making Crystal for Kim.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1526348, 13100, 0, 14200);

            c.Player.quest.AddTaskAccept(120221, 515001, 515);
            return res;
        }
        public static byte A120220(ConnectionInfo c, int QuestID)
        {
            //Ask Lance about the way of making Crystal for Kim.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120220, 515001, 1, 1, 515);
            return res;
        }
        public static byte Q120221(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Spirit Dragons on the Henan Mountainside and bring them to Lance.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1526348, 13100, 0, 14200);

            c.Player.quest.AddTaskAccept(120222, 515001, 515);
            return res;
        }
        public static byte A120221(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Spirit Dragons on the Henan Mountainside and bring them to Lance.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120221, 515001, 2, 0, 515, 80, 515001);
            c.Player.quest.AddPack(120221, 515001, 515);
            return res;
        }
        public static byte Q120222(ConnectionInfo c, int QuestID)
        {
            //Give Kim the Crystal made by Lance.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1526348, 13100, 0, 14200);
            return res;
        }
        public static byte A120222(ConnectionInfo c, int QuestID)
        {
            //Give Kim the Crystal made by Lance.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120222, 514012, 1, 1, 514);
            return res;
        }
        public static byte Q120223(ConnectionInfo c, int QuestID)
        {
            //Ask Mitchell about the way of keeping scent for Grace.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1591359, 13500, 0, 13900);

            c.Player.quest.AddTaskAccept(120224, 515003, 515);
            return res;
        }
        public static byte A120223(ConnectionInfo c, int QuestID)
        {
            //Ask Mitchell about the way of keeping scent for Grace.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120223, 515003, 1, 1, 515);
            return res;
        }
        public static byte Q120224(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Carefree Beasts on the Henan Mountainside and bring them to Mitchell.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1591359, 13500, 0, 13900);

            c.Player.quest.AddTaskAccept(120225, 515003, 515);
            return res;
        }
        public static byte A120224(ConnectionInfo c, int QuestID)
        {
            //Catch 80 Carefree Beasts on the Henan Mountainside and bring them to Mitchell.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120224, 515004, 2, 0, 515, 80, 515004);
            c.Player.quest.AddPack(120224, 515003, 515);
            return res;
        }
        public static byte Q120225(ConnectionInfo c, int QuestID)
        {
            //Give Grace the perfume made by Mitchell.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1591359, 13500, 0, 13900);

            c.Player.quest.AddTaskAccept(120226, 515006, 515);
            return res;
        }
        public static byte A120225(ConnectionInfo c, int QuestID)
        {
            //Give Grace the perfume made by Mitchell.
            if (QuestCommand.CanQuest(c, 83)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120225, 515006, 1, 1, 515);
            return res;
        }
        public static byte Q120226(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Dark Carefree Beasts on the Henan Moutainside then go back and tell Jeremy.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1658160, 13850, 0, 14500);

            c.Player.quest.AddTaskAccept(120227, 514009, 514);
            return res;
        }
        public static byte A120226(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Dark Carefree Beasts on the Henan Moutainside then go back and tell Jeremy.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120226, 515006, 2, 0, 515, 30, 515006);
            c.Player.quest.AddPack(120226, 514009, 514);
            return res;
        }
        public static byte Q120227(ConnectionInfo c, int QuestID)
        {
            //Ask Isaac about the reason why the Dark Carefree Beast went mad for Jeremy.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1658160, 13850, 0, 14500);

            c.Player.quest.AddTaskAccept(120228, 514007, 514);
            return res;
        }
        public static byte A120227(ConnectionInfo c, int QuestID)
        {
            //Ask Isaac about the reason why the Dark Carefree Beast went mad for Jeremy.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120227, 514007, 1, 1, 514);
            return res;
        }
        public static byte Q120228(ConnectionInfo c, int QuestID)
        {
            //Go to Henan Mountain and tell Jeremy Isaac\'s warning.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1658160, 13850, 0, 14500);
            return res;
        }
        public static byte A120228(ConnectionInfo c, int QuestID)
        {
            //Go to Henan Mountain and tell Jeremy Isaac\'s warning.
            if (QuestCommand.CanQuest(c, 84)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120228, 514009, 1, 1, 514);
            return res;
        }
        public static byte Q120229(ConnectionInfo c, int QuestID)
        {
            //Ask Marlon about how to repair the armor for Kelly.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1726775, 13770, 0, 13850);

            c.Player.quest.AddTaskAccept(120230, 515002, 515);
            return res;
        }
        public static byte A120229(ConnectionInfo c, int QuestID)
        {
            //Ask Marlon about how to repair the armor for Kelly.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120229, 515002, 1, 1, 515);
            return res;
        }
        public static byte Q120230(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Skyish Beasts on the Henan Mountainside and bring them to Marlon.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1726775, 13770, 0, 13850);

            c.Player.quest.AddTaskAccept(120231, 515002, 515);
            return res;
        }
        public static byte A120230(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Skyish Beasts on the Henan Mountainside and bring them to Marlon.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120230, 515003, 2, 0, 515, 85, 515003);
            c.Player.quest.AddPack(120230, 515002, 515);
            return res;
        }
        public static byte Q120231(ConnectionInfo c, int QuestID)
        {
            //Give the armor that fixed by Markon to Kelly.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1726775, 13770, 0, 13850);
            return res;
        }
        public static byte A120231(ConnectionInfo c, int QuestID)
        {
            //Give the armor that fixed by Markon to Kelly.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120231, 514011, 1, 1, 514);
            return res;
        }
        public static byte Q120232(ConnectionInfo c, int QuestID)
        {
            //Ask Jonas about the way of making magic gloves for Nate.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1797228, 14110, 0, 14620);

            c.Player.quest.AddTaskAccept(120233, 514010, 514);
            return res;
        }
        public static byte A120232(ConnectionInfo c, int QuestID)
        {
            //Ask Jonas about the way of making magic gloves for Nate.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120232, 514010, 1, 1, 514);
            return res;
        }
        public static byte Q120233(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Bubble Beasts on the Henan Mountainside and bring them to Jonas.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1797228, 14110, 0, 14620);

            c.Player.quest.AddTaskAccept(120234, 514010, 514);
            return res;
        }
        public static byte A120233(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Bubble Beasts on the Henan Mountainside and bring them to Jonas.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120233, 515005, 2, 0, 515, 85, 515005);
            c.Player.quest.AddPack(120233, 514010, 514);
            return res;
        }
        public static byte Q120234(ConnectionInfo c, int QuestID)
        {
            //Give the magic gloves that made by Jonas to Nate.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1797228, 14110, 0, 14620);
            return res;
        }
        public static byte A120234(ConnectionInfo c, int QuestID)
        {
            //Give the magic gloves that made by Jonas to Nate.
            if (QuestCommand.CanQuest(c, 86)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120234, 515004, 1, 1, 515);
            return res;
        }
        public static byte Q120235(ConnectionInfo c, int QuestID)
        {
            //Ask Jared about the way to treat red rash for Grace.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1869543, 14500, 0, 14110);

            c.Player.quest.AddTaskAccept(120236, 514008, 514);
            return res;
        }
        public static byte A120235(ConnectionInfo c, int QuestID)
        {
            //Ask Jared about the way to treat red rash for Grace.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120235, 514008, 1, 1, 514);
            return res;
        }
        public static byte Q120236(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Skyish Beasts on the Henan Mountainside and bring them to Jared.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1869543, 14500, 0, 14110);

            c.Player.quest.AddTaskAccept(120237, 514008, 514);
            return res;
        }
        public static byte A120236(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Skyish Beasts on the Henan Mountainside and bring them to Jared.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120236, 515003, 2, 0, 515, 85, 515003);
            c.Player.quest.AddPack(120236, 514008, 514);
            return res;
        }
        public static byte Q120237(ConnectionInfo c, int QuestID)
        {
            //Give Grace the perfume made by Jared.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1869543, 14500, 0, 14110);
            return res;
        }
        public static byte A120237(ConnectionInfo c, int QuestID)
        {
            //Give Grace the perfume made by Jared.
            if (QuestCommand.CanQuest(c, 87)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120237, 514014, 1, 1, 514);
            return res;
        }
        public static byte Q120238(ConnectionInfo c, int QuestID)
        {
            //Kill 85 Carefree Beasts on the Henan Mountainside then go back and report to Jeremy.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1943744, 13950, 0, 14600);

            c.Player.quest.AddTaskAccept(120239, 514009, 514);
            return res;
        }
        public static byte A120238(ConnectionInfo c, int QuestID)
        {
            //Kill 85 Carefree Beasts on the Henan Mountainside then go back and report to Jeremy.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120238, 515004, 2, 0, 515, 85, 515004);
            c.Player.quest.AddPack(120238, 514009, 514);
            return res;
        }
        public static byte Q120239(ConnectionInfo c, int QuestID)
        {
            //Kill 85 Spirit Dragons on the Henan Mountainside then go back and report to Jeremy.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1943744, 13950, 0, 14600);

            c.Player.quest.AddTaskAccept(120240, 514009, 514);
            return res;
        }
        public static byte A120239(ConnectionInfo c, int QuestID)
        {
            //Kill 85 Spirit Dragons on the Henan Mountainside then go back and report to Jeremy.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120239, 515001, 2, 0, 515, 85, 515001);
            c.Player.quest.AddPack(120239, 514009, 514);
            return res;
        }
        public static byte Q120240(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Dark Carefree Beasts on the Henan Moutainside then go back and tell Jeremy.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1943744, 13950, 0, 14600);
            return res;
        }
        public static byte A120240(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Dark Carefree Beasts on the Henan Moutainside then go back and tell Jeremy.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120240, 515006, 2, 0, 515, 30, 515006);
            c.Player.quest.AddPack(120240, 514009, 514);
            return res;
        }
        public static byte Q120241(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Spirit Dragons on the Henan Mountainside and bring them to Jared.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2019855, 14500, 0, 14900);

            c.Player.quest.AddTaskAccept(120242, 514008, 514);
            return res;
        }
        public static byte A120241(ConnectionInfo c, int QuestID)
        {
            //Catch 85 Spirit Dragons on the Henan Mountainside and bring them to Jared.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120241, 515001, 2, 0, 515, 85, 515001);
            c.Player.quest.AddPack(120241, 514008, 514);
            return res;
        }
        public static byte Q120242(ConnectionInfo c, int QuestID)
        {
            //Give Mitchell Jared\'s Dragon Scale.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2019855, 14500, 0, 14900);

            c.Player.quest.AddTaskAccept(120243, 515003, 515);
            return res;
        }
        public static byte A120242(ConnectionInfo c, int QuestID)
        {
            //Give Mitchell Jared\'s Dragon Scale.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120242, 515003, 1, 1, 515);
            return res;
        }
        public static byte Q120243(ConnectionInfo c, int QuestID)
        {
            //Give Jared the Dragon Scale Shield made by Mitchell.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2019855, 14500, 0, 14900);
            return res;
        }
        public static byte A120243(ConnectionInfo c, int QuestID)
        {
            //Give Jared the Dragon Scale Shield made by Mitchell.
            if (QuestCommand.CanQuest(c, 89)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(120243, 514008, 1, 1, 514);
            return res;
        }
        public static byte Q129001(ConnectionInfo c, int QuestID)
        {
            //Ask General Mandel the origin of Zodiac Wings.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 51234, 100, 0, 170);

            c.Player.quest.AddTaskAccept(129002, 502041, 502);
            return res;
        }
        public static byte A129001(ConnectionInfo c, int QuestID)
        {
            //Ask General Mandel the origin of Zodiac Wings.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(129001, 502041, 1, 1, 502);
            return res;
        }
        public static byte Q129002(ConnectionInfo c, int QuestID)
        {
            //Kill the man of specified constellation to get starsoul with specified attribute. When the total fusion level of the attribute constellation reaches lv.4, star wings will be unlocked.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            res = QuestReward.R129002(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 63909, 200, 100, 170);

            c.Player.quest.AddTaskAccept(129011, 502006, 502);
            return res;
        }
        public static byte A129002(ConnectionInfo c, int QuestID)
        {
            //Kill the man of specified constellation to get starsoul with specified attribute. When the total fusion level of the attribute constellation reaches lv.4, star wings will be unlocked.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            if (c.Player.medal.GetPoints() < 4)
                c.Player.quest.AddTaskComplete(129002, 502006, 13, 0, 502);
            else
                c.Player.quest.AddTaskComplete(129002, 502006, 1, 1, 502);
            return res;
        }
        public static byte Q129004(ConnectionInfo c, int QuestID)
        {
            //Top up once and get your reward from Edith.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;

            res = QuestReward.R129004(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 500, 100, 0, 0);
            return res;
        }
        public static byte A129004(ConnectionInfo c, int QuestID)
        {
            //Top up once and get your reward from Edith.
            if (QuestCommand.CanQuest(c, 22)) return 3;
            byte res = 1;

            if (c.Player.vip.crystal != 0)
                c.Player.quest.AddTaskComplete(129004, 502034, 1, 1, 502);
            else
                c.Player.quest.AddTaskComplete(129004, 502034, 18, 0, 502);
            return res;
        }
        public static byte Q129011(ConnectionInfo c, int QuestID)
        {
            //Find Edith for Charles.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1000, 100, 0, 15);

            c.Player.quest.AddTaskAccept(110064, 502034, 502);
            return res;
        }
        public static byte A129011(ConnectionInfo c, int QuestID)
        {
            //Find Edith for Charles.
            if (QuestCommand.CanQuest(c, 25)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(129011, 502034, 1, 1, 502);
            return res;
        }
        public static byte Q129016(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, upgrade your level at Stargazer Goya.
            if (QuestCommand.CanQuest(c, 27)) return 3;
            byte res = 1;

            res = QuestReward.R129016(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 190782, 500, 50, 1000);

            c.Player.quest.AddTaskAccept(129017, 502023, 502);
            return res;
        }
        public static byte A129016(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, upgrade your level at Stargazer Goya.
            if (QuestCommand.CanQuest(c, 27)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(129016, 502023, 1, 1, 502);
            return res;
        }
        public static byte Q129017(ConnectionInfo c, int QuestID)
        {
            //Enter Stargazer\'s Tower, defeat one Puppet Man·Green and one Puppet Mage·Green, then find Goya to complete the quest.
            if (QuestCommand.CanQuest(c, 27)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 185950, 500, 55, 1000);

            c.Player.quest.AddTaskAccept(119016, 502023, 502);
            return res;
        }
        public static byte A129017(ConnectionInfo c, int QuestID)
        {
            //Enter Stargazer\'s Tower, defeat one Puppet Man·Green and one Puppet Mage·Green, then find Goya to complete the quest.
            if (QuestCommand.CanQuest(c, 27)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(129017, 800012, 2, 0, 635, 1, 800012);
            c.Player.quest.AddTaskComplete(129017, 800013, 2, 0, 635, 1, 800013);
            c.Player.quest.AddPack(129017, 502023, 502);
            return res;
        }
        public static byte Q129019(ConnectionInfo c, int QuestID)
        {
            //Enter Zodiac Dream1, defeat Little Suslik*2 and Green Gulu*2, then find Jason to complete the quest.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 94795, 500, 45, 360);

            c.Player.quest.AddTaskAccept(110089, 502035, 504);
            return res;
        }
        public static byte A129019(ConnectionInfo c, int QuestID)
        {
            //Enter Zodiac Dream1, defeat Little Suslik*2 and Green Gulu*2, then find Jason to complete the quest.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(129019, 1001001, 2, 0, 1001, 2, 1001001);
            c.Player.quest.AddTaskComplete(129019, 1001002, 2, 0, 1001, 2, 1001002);
            c.Player.quest.AddPack(129019, 502035, 504);
            return res;
        }
        public static byte Q130001(ConnectionInfo c, int QuestID)
        {
            //Enter Dawn Pier, kill Meister Warlock*4, Meister Guard*4, Blade Master·Gudark*1, then report to Jeff.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A130001(ConnectionInfo c, int QuestID)
        {
            //Enter Dawn Pier, kill Meister Warlock*4, Meister Guard*4, Blade Master·Gudark*1, then report to Jeff.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130001, 601001, 2, 0, 601, 4, 601001);
            c.Player.quest.AddTaskComplete(130001, 601003, 2, 0, 601, 4, 601003);
            c.Player.quest.AddTaskComplete(130001, 601009, 2, 0, 601, 1, 601009);
            c.Player.quest.AddPack(130001, 502015, 502);
            return res;
        }
        public static byte Q130002(ConnectionInfo c, int QuestID)
        {
            //Enter Sky City, kill Sky Crocodile*6, Cloud Dragon*6, Sky Mask*6, Faux· Emohill*1, then report to Beryl.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 28125, 0, 0, 0);
            return res;
        }
        public static byte A130002(ConnectionInfo c, int QuestID)
        {
            //Enter Sky City, kill Sky Crocodile*6, Cloud Dragon*6, Sky Mask*6, Faux· Emohill*1, then report to Beryl.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130002, 800026, 2, 0, 602, 6, 800026);
            c.Player.quest.AddTaskComplete(130002, 800027, 2, 0, 602, 6, 800027);
            c.Player.quest.AddTaskComplete(130002, 800029, 2, 0, 602, 6, 800029);
            c.Player.quest.AddTaskComplete(130002, 800034, 2, 0, 602, 1, 800034);
            c.Player.quest.AddPack(130002, 502016, 502);
            return res;
        }
        public static byte Q130003(ConnectionInfo c, int QuestID)
        {
            //Go to 4 God Temple, kill 5 Priest of Fear, 5 Priest of Envy, 1 Priest of Greed, 1 Oracle of Pride, and then report to Blanche.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 34375, 0, 0, 0);
            return res;
        }
        public static byte A130003(ConnectionInfo c, int QuestID)
        {
            //Go to 4 God Temple, kill 5 Priest of Fear, 5 Priest of Envy, 1 Priest of Greed, 1 Oracle of Pride, and then report to Blanche.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130003, 800035, 2, 0, 625, 5, 800035);
            c.Player.quest.AddTaskComplete(130003, 800041, 2, 0, 626, 5, 800041);
            c.Player.quest.AddTaskComplete(130003, 800044, 2, 0, 625, 1, 800044);
            c.Player.quest.AddTaskComplete(130003, 800046, 2, 0, 626, 1, 800046);
            c.Player.quest.AddPack(130003, 502017, 502);
            return res;
        }
        public static byte Q130005(ConnectionInfo c, int QuestID)
        {
            //Go to Blade Hill, defeat 4 Sword\'s Slaves, 4 Spirit Beasts, 1 Sword!$Starry Sky, 1 Sword!$Moonlight, then report to Aubrey.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 46875, 0, 0, 0);
            return res;
        }
        public static byte A130005(ConnectionInfo c, int QuestID)
        {
            //Go to Blade Hill, defeat 4 Sword\'s Slaves, 4 Spirit Beasts, 1 Sword!$Starry Sky, 1 Sword!$Moonlight, then report to Aubrey.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130005, 800048, 2, 0, 605, 4, 800048);
            c.Player.quest.AddTaskComplete(130005, 800050, 2, 0, 605, 4, 800050);
            c.Player.quest.AddTaskComplete(130005, 800055, 2, 0, 605, 1, 800055);
            c.Player.quest.AddTaskComplete(130005, 800057, 2, 0, 605, 1, 800057);
            c.Player.quest.AddPack(130005, 502019, 502);
            return res;
        }
        public static byte Q130006(ConnectionInfo c, int QuestID)
        {
            //Go to Holy Land, defeat 5 Battle Spirit, 5 Sage Mentors, 1 Mentor!$Swift, 1 Shine\'s Father, then report to Adonis.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 53125, 0, 0, 0);
            return res;
        }
        public static byte A130006(ConnectionInfo c, int QuestID)
        {
            //Go to Holy Land, defeat 5 Battle Spirit, 5 Sage Mentors, 1 Mentor!$Swift, 1 Shine\'s Father, then report to Adonis.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130006, 800059, 2, 0, 627, 5, 800059);
            c.Player.quest.AddTaskComplete(130006, 800063, 2, 0, 628, 5, 800063);
            c.Player.quest.AddTaskComplete(130006, 800068, 2, 0, 627, 1, 800068);
            c.Player.quest.AddTaskComplete(130006, 800071, 2, 0, 628, 1, 800071);
            c.Player.quest.AddPack(130006, 502020, 502);
            return res;
        }
        public static byte Q130007(ConnectionInfo c, int QuestID)
        {
            //Go to Holy Fire Origin, defeat 5 Life Element, 5 Death Element, 1 War God\'s Image, 1 War God\'s Image, then report to Barton.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 59125, 0, 0, 0);
            return res;
        }
        public static byte A130007(ConnectionInfo c, int QuestID)
        {
            //Go to Holy Fire Origin, defeat 5 Life Element, 5 Death Element, 1 War God\'s Image, 1 War God\'s Image, then report to Barton.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130007, 800088, 2, 0, 631, 5, 800088);
            c.Player.quest.AddTaskComplete(130007, 800089, 2, 0, 631, 5, 800089);
            c.Player.quest.AddTaskComplete(130007, 800094, 2, 0, 631, 1, 800094);
            c.Player.quest.AddTaskComplete(130007, 800095, 2, 0, 631, 1, 800095);
            c.Player.quest.AddPack(130007, 502021, 502);
            return res;
        }
        public static byte Q130009(ConnectionInfo c, int QuestID)
        {
            //Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 0, 5000, 0, 0);
            return res;
        }
        public static byte A130009(ConnectionInfo c, int QuestID)
        {
            //Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130009, 301028, 1, 1, 301);
            return res;
        }
        public static byte Q130010(ConnectionInfo c, int QuestID)
        {
            //Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 0, 5000, 0, 0);
            return res;
        }
        public static byte A130010(ConnectionInfo c, int QuestID)
        {
            //Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130010, 201028, 1, 1, 201);
            return res;
        }
        public static byte Q130011(ConnectionInfo c, int QuestID)
        {
            //Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 0, 5000, 0, 0);
            return res;
        }
        public static byte A130011(ConnectionInfo c, int QuestID)
        {
            //Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
            if (QuestCommand.CanQuest(c, 28)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130011, 401028, 1, 1, 401);
            return res;
        }
        public static byte Q130022(ConnectionInfo c, int QuestID)
        {
            //Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 10000, 5000, 100, 50);
            return res;
        }
        public static byte A130022(ConnectionInfo c, int QuestID)
        {
            //Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            return res;
        }
        public static byte Q130023(ConnectionInfo c, int QuestID)
        {
            //Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 10000, 5000, 100, 50);
            return res;
        }
        public static byte A130023(ConnectionInfo c, int QuestID)
        {
            //Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            return res;
        }
        public static byte Q130024(ConnectionInfo c, int QuestID)
        {
            //Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 10000, 5000, 100, 50);
            return res;
        }
        public static byte A130024(ConnectionInfo c, int QuestID)
        {
            //Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            return res;
        }
        public static byte Q130054(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Toothy Gerbil in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 131147, 0, 0, 2942);

            c.Player.quest.AddTaskAccept(130055, 504009, 504);
            return res;
        }
        public static byte A130054(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Toothy Gerbil in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130054, 505001, 2, 0, 505, 30, 505001);
            c.Player.quest.AddPack(130054, 504009, 504);
            return res;
        }
        public static byte Q130055(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Toxic Scorpions in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 144261, 0, 0, 3236);

            c.Player.quest.AddTaskAccept(130056, 504009, 504);
            return res;
        }
        public static byte A130055(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Toxic Scorpions in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130055, 505006, 2, 0, 505, 30, 505006);
            c.Player.quest.AddPack(130055, 504009, 504);
            return res;
        }
        public static byte Q130056(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Rattlesnakes in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 157376, 0, 0, 3530);

            c.Player.quest.AddTaskAccept(130057, 504009, 504);
            return res;
        }
        public static byte A130056(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Rattlesnakes in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130056, 505003, 2, 0, 505, 30, 505003);
            c.Player.quest.AddPack(130056, 504009, 504);
            return res;
        }
        public static byte Q130057(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Swantony in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 170491, 0, 0, 3824);

            c.Player.quest.AddTaskAccept(130058, 504009, 504);
            return res;
        }
        public static byte A130057(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Swantony in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130057, 505008, 2, 0, 505, 10, 505008);
            c.Player.quest.AddPack(130057, 504009, 504);
            return res;
        }
        public static byte Q130058(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Dire Wolf in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 183605, 0, 0, 4119);

            c.Player.quest.AddTaskAccept(130059, 504009, 504);
            return res;
        }
        public static byte A130058(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Dire Wolf in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130058, 505004, 2, 0, 505, 40, 505004);
            c.Player.quest.AddPack(130058, 504009, 504);
            return res;
        }
        public static byte Q130059(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Toothy Gerbil in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 196720, 0, 0, 4413);

            c.Player.quest.AddTaskAccept(130060, 504009, 504);
            return res;
        }
        public static byte A130059(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Toothy Gerbil in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130059, 505001, 2, 0, 505, 40, 505001);
            c.Player.quest.AddPack(130059, 504009, 504);
            return res;
        }
        public static byte Q130060(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Benson in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 209835, 0, 0, 4707);

            c.Player.quest.AddTaskAccept(130061, 504009, 504);
            return res;
        }
        public static byte A130060(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Benson in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130060, 505009, 2, 0, 505, 10, 505009);
            c.Player.quest.AddPack(130060, 504009, 504);
            return res;
        }
        public static byte Q130061(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Sand Fire Lizards in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 222949, 0, 0, 5001);

            c.Player.quest.AddTaskAccept(130062, 504009, 504);
            return res;
        }
        public static byte A130061(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Sand Fire Lizards in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130061, 505007, 2, 0, 505, 50, 505007);
            c.Player.quest.AddPack(130061, 504009, 504);
            return res;
        }
        public static byte Q130062(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Trade Wind Foxes in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 236064, 0, 0, 5296);

            c.Player.quest.AddTaskAccept(130063, 504009, 504);
            return res;
        }
        public static byte A130062(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Trade Wind Foxes in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130062, 505005, 2, 0, 505, 50, 505005);
            c.Player.quest.AddPack(130062, 504009, 504);
            return res;
        }
        public static byte Q130063(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Swantony in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 249179, 0, 0, 5589);
            return res;
        }
        public static byte A130063(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Swantony in Darksand and then tell Lune Oasis\'s Chester.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130063, 505008, 2, 0, 505, 10, 505008);
            c.Player.quest.AddPack(130063, 504009, 504);
            return res;
        }
        public static byte Q130073(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Toothy Gerbil in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 47662, 2500, 0, 0);

            c.Player.quest.AddTaskAccept(130074, 505002, 505);
            return res;
        }
        public static byte A130073(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Toothy Gerbil in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130073, 505001, 2, 0, 505, 30, 505001);
            c.Player.quest.AddPack(130073, 505002, 505);
            return res;
        }
        public static byte Q130074(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Dire Wolves in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 52428, 2750, 0, 0);

            c.Player.quest.AddTaskAccept(130075, 505002, 505);
            return res;
        }
        public static byte A130074(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Dire Wolves in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130074, 505004, 2, 0, 505, 30, 505004);
            c.Player.quest.AddPack(130074, 505002, 505);
            return res;
        }
        public static byte Q130075(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 57195, 3000, 0, 0);
            return res;
        }
        public static byte A130075(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130075, 505008, 2, 0, 505, 5, 505008);
            c.Player.quest.AddTaskComplete(130075, 505009, 2, 0, 505, 5, 505009);
            c.Player.quest.AddPack(130075, 505002, 505);
            return res;
        }
        public static byte Q130076(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Toxic Scorpions in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 61961, 3250, 0, 0);

            c.Player.quest.AddTaskAccept(130077, 505002, 505);
            return res;
        }
        public static byte A130076(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Toxic Scorpions in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130076, 505006, 2, 0, 505, 40, 505006);
            c.Player.quest.AddPack(130076, 505002, 505);
            return res;
        }
        public static byte Q130077(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Bactrian Camels in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 66727, 3500, 0, 0);

            c.Player.quest.AddTaskAccept(130078, 505002, 505);
            return res;
        }
        public static byte A130077(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Bactrian Camels in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130077, 505002, 2, 0, 505, 40, 505002);
            c.Player.quest.AddPack(130077, 505002, 505);
            return res;
        }
        public static byte Q130078(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 71493, 3750, 0, 0);
            return res;
        }
        public static byte A130078(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 35)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130078, 505008, 2, 0, 505, 5, 505008);
            c.Player.quest.AddTaskComplete(130078, 505009, 2, 0, 505, 5, 505009);
            c.Player.quest.AddPack(130078, 505002, 505);
            return res;
        }
        public static byte Q130079(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Rattlesnakes in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76259, 4000, 0, 0);

            c.Player.quest.AddTaskAccept(130080, 505002, 505);
            return res;
        }
        public static byte A130079(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Rattlesnakes in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130079, 505003, 2, 0, 505, 50, 505003);
            c.Player.quest.AddPack(130079, 505002, 505);
            return res;
        }
        public static byte Q130080(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Trade Wind Fox in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 81026, 4250, 0, 0);

            c.Player.quest.AddTaskAccept(130081, 505002, 505);
            return res;
        }
        public static byte A130080(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Trade Wind Fox in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130080, 505005, 2, 0, 505, 50, 505005);
            c.Player.quest.AddPack(130080, 505002, 505);
            return res;
        }
        public static byte Q130081(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 85792, 4500, 0, 0);
            return res;
        }
        public static byte A130081(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
            if (QuestCommand.CanQuest(c, 38)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130081, 505008, 2, 0, 505, 5, 505008);
            c.Player.quest.AddTaskComplete(130081, 505009, 2, 0, 505, 5, 505009);
            c.Player.quest.AddPack(130081, 505002, 505);
            return res;
        }
        public static byte Q130082(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 249375, 0, 0, 7662);

            c.Player.quest.AddTaskAccept(130083, 506008, 506);
            return res;
        }
        public static byte A130082(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130082, 507004, 2, 0, 507, 30, 507004);
            c.Player.quest.AddPack(130082, 506008, 506);
            return res;
        }
        public static byte Q130083(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Man-eating Trees in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 274312, 0, 0, 8428);

            c.Player.quest.AddTaskAccept(130084, 506008, 506);
            return res;
        }
        public static byte A130083(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Man-eating Trees in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130083, 507003, 2, 0, 507, 30, 507003);
            c.Player.quest.AddPack(130083, 506008, 506);
            return res;
        }
        public static byte Q130084(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 299250, 0, 0, 9194);

            c.Player.quest.AddTaskAccept(130085, 506008, 506);
            return res;
        }
        public static byte A130084(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130084, 507001, 2, 0, 507, 30, 507001);
            c.Player.quest.AddPack(130084, 506008, 506);
            return res;
        }
        public static byte Q130085(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Baird in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 324187, 0, 0, 9960);

            c.Player.quest.AddTaskAccept(130086, 506008, 506);
            return res;
        }
        public static byte A130085(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Baird in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130085, 507006, 2, 0, 507, 10, 507006);
            c.Player.quest.AddPack(130085, 506008, 506);
            return res;
        }
        public static byte Q130086(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Wraith Spiders in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 349125, 0, 0, 10726);

            c.Player.quest.AddTaskAccept(130087, 506008, 506);
            return res;
        }
        public static byte A130086(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Wraith Spiders in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130086, 507005, 2, 0, 507, 40, 507005);
            c.Player.quest.AddPack(130086, 506008, 506);
            return res;
        }
        public static byte Q130087(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 374062, 0, 0, 11492);

            c.Player.quest.AddTaskAccept(130088, 506008, 506);
            return res;
        }
        public static byte A130087(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130087, 507004, 2, 0, 507, 40, 507004);
            c.Player.quest.AddPack(130087, 506008, 506);
            return res;
        }
        public static byte Q130088(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Archer in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 399000, 0, 0, 12259);

            c.Player.quest.AddTaskAccept(130089, 506008, 506);
            return res;
        }
        public static byte A130088(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Archer in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130088, 507007, 2, 0, 507, 10, 507007);
            c.Player.quest.AddPack(130088, 506008, 506);
            return res;
        }
        public static byte Q130089(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Mud Monsters in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 423937, 0, 0, 13025);

            c.Player.quest.AddTaskAccept(130090, 506008, 506);
            return res;
        }
        public static byte A130089(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Mud Monsters in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130089, 507002, 2, 0, 507, 50, 507002);
            c.Player.quest.AddPack(130089, 506008, 506);
            return res;
        }
        public static byte Q130090(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 448874, 0, 0, 13791);

            c.Player.quest.AddTaskAccept(130091, 506008, 506);
            return res;
        }
        public static byte A130090(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130090, 507001, 2, 0, 507, 50, 507001);
            c.Player.quest.AddPack(130090, 506008, 506);
            return res;
        }
        public static byte Q130091(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Baird in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 473812, 0, 0, 14557);
            return res;
        }
        public static byte A130091(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Baird in Vine Rainforest and then tell Tramp Camp\'s Hoare.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130091, 507006, 2, 0, 507, 10, 507006);
            c.Player.quest.AddPack(130091, 506008, 506);
            return res;
        }
        public static byte Q130101(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 93014, 3200, 0, 0);

            c.Player.quest.AddTaskAccept(130102, 506010, 506);
            return res;
        }
        public static byte A130101(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130101, 507004, 2, 0, 507, 30, 507004);
            c.Player.quest.AddPack(130101, 506010, 506);
            return res;
        }
        public static byte Q130102(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Wraith Spiders in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 102316, 3500, 0, 0);

            c.Player.quest.AddTaskAccept(130103, 506010, 506);
            return res;
        }
        public static byte A130102(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Wraith Spiders in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130102, 507005, 2, 0, 507, 30, 507005);
            c.Player.quest.AddPack(130102, 506010, 506);
            return res;
        }
        public static byte Q130103(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 111617, 3900, 0, 0);
            return res;
        }
        public static byte A130103(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130103, 507006, 2, 0, 507, 5, 507006);
            c.Player.quest.AddTaskComplete(130103, 507007, 2, 0, 507, 5, 507007);
            c.Player.quest.AddPack(130103, 506010, 506);
            return res;
        }
        public static byte Q130104(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Man-eating Tree in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 120918, 4200, 0, 0);

            c.Player.quest.AddTaskAccept(130105, 506010, 506);
            return res;
        }
        public static byte A130104(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Man-eating Tree in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130104, 507003, 2, 0, 507, 40, 507003);
            c.Player.quest.AddPack(130104, 506010, 506);
            return res;
        }
        public static byte Q130105(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 130220, 4500, 0, 0);

            c.Player.quest.AddTaskAccept(130106, 506010, 506);
            return res;
        }
        public static byte A130105(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130105, 507001, 2, 0, 507, 40, 507001);
            c.Player.quest.AddPack(130105, 506010, 506);
            return res;
        }
        public static byte Q130106(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 139521, 4800, 0, 0);
            return res;
        }
        public static byte A130106(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 45)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130106, 507006, 2, 0, 507, 5, 507006);
            c.Player.quest.AddTaskComplete(130106, 507007, 2, 0, 507, 5, 507007);
            c.Player.quest.AddPack(130106, 506010, 506);
            return res;
        }
        public static byte Q130107(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Mud Monsters in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 148823, 5200, 0, 0);

            c.Player.quest.AddTaskAccept(130108, 506010, 506);
            return res;
        }
        public static byte A130107(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Mud Monsters in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130107, 507002, 2, 0, 507, 50, 507002);
            c.Player.quest.AddPack(130107, 506010, 506);
            return res;
        }
        public static byte Q130108(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 158124, 5400, 0, 0);

            c.Player.quest.AddTaskAccept(130109, 506010, 506);
            return res;
        }
        public static byte A130108(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130108, 507001, 2, 0, 507, 50, 507001);
            c.Player.quest.AddPack(130108, 506010, 506);
            return res;
        }
        public static byte Q130109(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 167425, 5800, 0, 0);
            return res;
        }
        public static byte A130109(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
            if (QuestCommand.CanQuest(c, 48)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130109, 507006, 2, 0, 507, 5, 507006);
            c.Player.quest.AddTaskComplete(130109, 507007, 2, 0, 507, 5, 507007);
            c.Player.quest.AddPack(130109, 506010, 506);
            return res;
        }
        public static byte Q130110(ConnectionInfo c, int QuestID)
        {
            //Enter Dawn Pier, kill Meister Swordsman*4, Head Warlock Karl*1, Lead Guard Danton*1, then go to City of Genesis and tell Burton.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            res = QuestReward.R130110(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 25000, 4500, 0, 0);
            return res;
        }
        public static byte A130110(ConnectionInfo c, int QuestID)
        {
            //Enter Dawn Pier, kill Meister Swordsman*4, Head Warlock Karl*1, Lead Guard Danton*1, then go to City of Genesis and tell Burton.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130110, 601004, 2, 0, 601, 4, 601004);
            c.Player.quest.AddTaskComplete(130110, 601006, 2, 0, 601, 1, 601006);
            c.Player.quest.AddTaskComplete(130110, 601008, 2, 0, 601, 1, 601008);
            c.Player.quest.AddPack(130110, 502011, 502);
            return res;
        }
        public static byte Q130111(ConnectionInfo c, int QuestID)
        {
            //Enter Sky City, kill Kamaitachi*6, Cloud Elf*6, Head Sky Crocodile*1, Cloud Elf King*1, then go to City of Genesis and tell Burton.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            res = QuestReward.R130111(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 28125, 5700, 0, 0);
            return res;
        }
        public static byte A130111(ConnectionInfo c, int QuestID)
        {
            //Enter Sky City, kill Kamaitachi*6, Cloud Elf*6, Head Sky Crocodile*1, Cloud Elf King*1, then go to City of Genesis and tell Burton.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130111, 800025, 2, 0, 602, 6, 800025);
            c.Player.quest.AddTaskComplete(130111, 800028, 2, 0, 602, 6, 800028);
            c.Player.quest.AddTaskComplete(130111, 800031, 2, 0, 602, 1, 800031);
            c.Player.quest.AddTaskComplete(130111, 800033, 2, 0, 602, 1, 800033);
            c.Player.quest.AddPack(130111, 502011, 502);
            return res;
        }
        public static byte Q130112(ConnectionInfo c, int QuestID)
        {
            //Go to 4 God Temple, kill 5 Priest of Pride, 5 Bishop of Greed, 1 Oracle of Envy, 1 Oracle of Terror, then go back to the City of Genesis and tell Larry.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;

            res = QuestReward.R130112(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 34375, 6800, 0, 0);
            return res;
        }
        public static byte A130112(ConnectionInfo c, int QuestID)
        {
            //Go to 4 God Temple, kill 5 Priest of Pride, 5 Bishop of Greed, 1 Oracle of Envy, 1 Oracle of Terror, then go back to the City of Genesis and tell Larry.
            if (QuestCommand.CanQuest(c, 34)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130112, 800038, 2, 0, 626, 5, 800038);
            c.Player.quest.AddTaskComplete(130112, 800040, 2, 0, 625, 5, 800040);
            c.Player.quest.AddTaskComplete(130112, 800045, 2, 0, 626, 1, 800045);
            c.Player.quest.AddTaskComplete(130112, 800043, 2, 0, 625, 1, 800043);
            c.Player.quest.AddPack(130112, 502011, 502);
            return res;
        }
        public static byte Q130114(ConnectionInfo c, int QuestID)
        {
            //Go to Blade Hill, Defeat 4 Sword\'s Spirit, 4 Fierce Beast, 1 Scabbard!$Chaos, then go back to the City of Genesis and tell Larry.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;

            res = QuestReward.R130114(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 46875, 9000, 0, 0);
            return res;
        }
        public static byte A130114(ConnectionInfo c, int QuestID)
        {
            //Go to Blade Hill, Defeat 4 Sword\'s Spirit, 4 Fierce Beast, 1 Scabbard!$Chaos, then go back to the City of Genesis and tell Larry.
            if (QuestCommand.CanQuest(c, 40)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130114, 800049, 2, 0, 605, 4, 800049);
            c.Player.quest.AddTaskComplete(130114, 800052, 2, 0, 605, 4, 800052);
            c.Player.quest.AddTaskComplete(130114, 800058, 2, 0, 605, 1, 800058);
            c.Player.quest.AddPack(130114, 502011, 502);
            return res;
        }
        public static byte Q130115(ConnectionInfo c, int QuestID)
        {
            //Go to Holy Land, Defeat 5 Element Spirit, 5 Killer Mentors, 1 Mentor!$Fearless, then go back to the City of Genesis and tell Larry.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            res = QuestReward.R130115(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 53125, 10100, 0, 0);
            return res;
        }
        public static byte A130115(ConnectionInfo c, int QuestID)
        {
            //Go to Holy Land, Defeat 5 Element Spirit, 5 Killer Mentors, 1 Mentor!$Fearless, then go back to the City of Genesis and tell Larry.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130115, 800060, 2, 0, 627, 5, 800060);
            c.Player.quest.AddTaskComplete(130115, 800064, 2, 0, 628, 5, 800064);
            c.Player.quest.AddTaskComplete(130115, 800066, 2, 0, 627, 1, 800066);
            c.Player.quest.AddPack(130115, 502011, 502);
            return res;
        }
        public static byte Q130116(ConnectionInfo c, int QuestID)
        {
            //Go to Holy Fire Origin, defeat 5 Light Element, 5 Dark Element, 1 War God\'s Image, 1 Wisdom God\'s Image, then go back to the City of Genesis and tell Larry.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;

            res = QuestReward.R130116(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 59125, 11000, 0, 0);
            return res;
        }
        public static byte A130116(ConnectionInfo c, int QuestID)
        {
            //Go to Holy Fire Origin, defeat 5 Light Element, 5 Dark Element, 1 War God\'s Image, 1 Wisdom God\'s Image, then go back to the City of Genesis and tell Larry.
            if (QuestCommand.CanQuest(c, 52)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130116, 800086, 2, 0, 631, 5, 800086);
            c.Player.quest.AddTaskComplete(130116, 800087, 2, 0, 631, 5, 800087);
            c.Player.quest.AddTaskComplete(130116, 800092, 2, 0, 630, 1, 800092);
            c.Player.quest.AddTaskComplete(130116, 800093, 2, 0, 630, 1, 800093);
            c.Player.quest.AddPack(130116, 502011, 502);
            return res;
        }
        public static byte Q130117(ConnectionInfo c, int QuestID)
        {
            //Attack Dragon Cave and then report to Quenton.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 5000, 5000, 0, 0);
            return res;
        }
        public static byte A130117(ConnectionInfo c, int QuestID)
        {
            //Attack Dragon Cave and then report to Quenton.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130117, 800005, 2, 0, 612, 1, 800005);
            c.Player.quest.AddPack(130117, 502014, 502);
            return res;
        }
        public static byte Q130118(ConnectionInfo c, int QuestID)
        {
            //Attack Dragon Cave and then report to Quenton.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 6000, 6000, 0, 0);
            return res;
        }
        public static byte A130118(ConnectionInfo c, int QuestID)
        {
            //Attack Dragon Cave and then report to Quenton.
            if (QuestCommand.CanQuest(c, 37)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130118, 800005, 2, 0, 615, 1, 800005);
            c.Player.quest.AddPack(130118, 502014, 502);
            return res;
        }
        public static byte Q130119(ConnectionInfo c, int QuestID)
        {
            //Attack Dragon Cave and then report to Quenton.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 7000, 7000, 0, 0);
            return res;
        }
        public static byte A130119(ConnectionInfo c, int QuestID)
        {
            //Attack Dragon Cave and then report to Quenton.
            if (QuestCommand.CanQuest(c, 47)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130119, 800005, 2, 0, 618, 1, 800005);
            c.Player.quest.AddPack(130119, 502014, 502);
            return res;
        }
        public static byte Q130120(ConnectionInfo c, int QuestID)
        {
            //Complete Stargazer\'s Tower, then report to Stargazer Goya.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A130120(ConnectionInfo c, int QuestID)
        {
            //Complete Stargazer\'s Tower, then report to Stargazer Goya.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130120, 800024, 2, 0, 620, 1, 800024);
            c.Player.quest.AddPack(130120, 502023, 502);
            return res;
        }
        public static byte Q130121(ConnectionInfo c, int QuestID)
        {
            //Complete Stargazer\'s Tower, then report to Stargazer Goya.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A130121(ConnectionInfo c, int QuestID)
        {
            //Complete Stargazer\'s Tower, then report to Stargazer Goya.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130121, 800024, 2, 0, 622, 1, 800024);
            c.Player.quest.AddPack(130121, 502023, 502);
            return res;
        }
        public static byte Q130122(ConnectionInfo c, int QuestID)
        {
            //Complete Stargazer\'s Tower, then report to Stargazer Goya.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A130122(ConnectionInfo c, int QuestID)
        {
            //Complete Stargazer\'s Tower, then report to Stargazer Goya.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130122, 800024, 2, 0, 624, 1, 800024);
            c.Player.quest.AddPack(130122, 502023, 502);
            return res;
        }
        public static byte Q130123(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Venom Monsters in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 441405, 0, 0, 9194);

            c.Player.quest.AddTaskAccept(130124, 508010, 508);
            return res;
        }
        public static byte A130123(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Venom Monsters in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130123, 509001, 2, 0, 509, 30, 509001);
            c.Player.quest.AddPack(130123, 508010, 508);
            return res;
        }
        public static byte Q130124(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Short-wing Rats in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 485545, 0, 0, 10114);

            c.Player.quest.AddTaskAccept(130125, 508010, 508);
            return res;
        }
        public static byte A130124(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Short-wing Rats in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130124, 509002, 2, 0, 509, 30, 509002);
            c.Player.quest.AddPack(130124, 508010, 508);
            return res;
        }
        public static byte Q130125(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Medusa in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 529686, 0, 0, 11033);

            c.Player.quest.AddTaskAccept(130126, 508010, 508);
            return res;
        }
        public static byte A130125(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Medusa in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130125, 509003, 2, 0, 509, 30, 509003);
            c.Player.quest.AddPack(130125, 508010, 508);
            return res;
        }
        public static byte Q130126(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Olive in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 573826, 0, 0, 11952);

            c.Player.quest.AddTaskAccept(130127, 508010, 508);
            return res;
        }
        public static byte A130126(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Olive in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130126, 509006, 2, 0, 509, 10, 509006);
            c.Player.quest.AddPack(130126, 508010, 508);
            return res;
        }
        public static byte Q130127(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Short-wing Rats in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 617968, 0, 0, 12871);

            c.Player.quest.AddTaskAccept(130128, 508010, 508);
            return res;
        }
        public static byte A130127(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Short-wing Rats in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130127, 509002, 2, 0, 509, 40, 509002);
            c.Player.quest.AddPack(130127, 508010, 508);
            return res;
        }
        public static byte Q130128(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Mugger Crocodiles in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 662107, 0, 0, 13790);

            c.Player.quest.AddTaskAccept(130129, 508010, 508);
            return res;
        }
        public static byte A130128(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Mugger Crocodiles in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130128, 509004, 2, 0, 509, 40, 509004);
            c.Player.quest.AddPack(130128, 508010, 508);
            return res;
        }
        public static byte Q130129(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Giant Carrion in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 706249, 0, 0, 14711);

            c.Player.quest.AddTaskAccept(130130, 508010, 508);
            return res;
        }
        public static byte A130129(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Giant Carrion in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130129, 509007, 2, 0, 509, 10, 509007);
            c.Player.quest.AddPack(130129, 508010, 508);
            return res;
        }
        public static byte Q130130(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Carrion in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 750388, 0, 0, 15630);

            c.Player.quest.AddTaskAccept(130131, 508010, 508);
            return res;
        }
        public static byte A130130(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Carrion in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130130, 509005, 2, 0, 509, 50, 509005);
            c.Player.quest.AddPack(130130, 508010, 508);
            return res;
        }
        public static byte Q130131(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Medusa in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 794528, 0, 0, 16549);

            c.Player.quest.AddTaskAccept(130132, 508010, 508);
            return res;
        }
        public static byte A130131(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Medusa in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130131, 509003, 2, 0, 509, 50, 509003);
            c.Player.quest.AddPack(130131, 508010, 508);
            return res;
        }
        public static byte Q130132(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Olive in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 838669, 0, 0, 17468);
            return res;
        }
        public static byte A130132(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Olive in Redcloud Marsh and then tell Pearl Village\'s Osmond.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130132, 509006, 2, 0, 509, 10, 509006);
            c.Player.quest.AddPack(130132, 508010, 508);
            return res;
        }
        public static byte Q130136(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Medusa in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 164639, 3840, 0, 0);

            c.Player.quest.AddTaskAccept(130137, 509005, 509);
            return res;
        }
        public static byte A130136(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Medusa in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130136, 509003, 2, 0, 509, 30, 509003);
            c.Player.quest.AddPack(130136, 509005, 509);
            return res;
        }
        public static byte Q130137(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Mugger Crocodiles in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 181104, 4200, 0, 0);

            c.Player.quest.AddTaskAccept(130138, 509005, 509);
            return res;
        }
        public static byte A130137(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Mugger Crocodiles in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130137, 509004, 2, 0, 509, 30, 509004);
            c.Player.quest.AddPack(130137, 509005, 509);
            return res;
        }
        public static byte Q130138(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 197567, 4680, 0, 0);
            return res;
        }
        public static byte A130138(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130138, 509006, 2, 0, 509, 5, 509006);
            c.Player.quest.AddTaskComplete(130138, 509007, 2, 0, 509, 5, 509007);
            c.Player.quest.AddPack(130138, 509005, 509);
            return res;
        }
        public static byte Q130139(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Venom Monsters in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 202976, 5040, 0, 0);

            c.Player.quest.AddTaskAccept(130140, 509005, 509);
            return res;
        }
        public static byte A130139(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Venom Monsters in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130139, 509001, 2, 0, 509, 40, 509001);
            c.Player.quest.AddPack(130139, 509005, 509);
            return res;
        }
        public static byte Q130140(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Medusa in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 218591, 5400, 0, 0);

            c.Player.quest.AddTaskAccept(130141, 509005, 509);
            return res;
        }
        public static byte A130140(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Medusa in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130140, 509003, 2, 0, 509, 40, 509003);
            c.Player.quest.AddPack(130140, 509005, 509);
            return res;
        }
        public static byte Q130141(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 234204, 5760, 0, 0);
            return res;
        }
        public static byte A130141(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 55)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130141, 509006, 2, 0, 509, 5, 509006);
            c.Player.quest.AddTaskComplete(130141, 509007, 2, 0, 509, 5, 509007);
            c.Player.quest.AddPack(130141, 509005, 509);
            return res;
        }
        public static byte Q130142(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Short-wing Rats in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 241364, 6240, 0, 0);

            c.Player.quest.AddTaskAccept(130143, 509005, 509);
            return res;
        }
        public static byte A130142(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Short-wing Rats in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130142, 509002, 2, 0, 509, 50, 509002);
            c.Player.quest.AddPack(130142, 509005, 509);
            return res;
        }
        public static byte Q130143(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 256448, 6480, 0, 0);

            c.Player.quest.AddTaskAccept(130144, 509005, 509);
            return res;
        }
        public static byte A130143(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130143, 509005, 2, 0, 509, 50, 509005);
            c.Player.quest.AddPack(130143, 509005, 509);
            return res;
        }
        public static byte Q130144(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 271533, 6960, 0, 0);
            return res;
        }
        public static byte A130144(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
            if (QuestCommand.CanQuest(c, 58)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130144, 509006, 2, 0, 509, 5, 509006);
            c.Player.quest.AddTaskComplete(130144, 509007, 2, 0, 509, 5, 509007);
            c.Player.quest.AddPack(130144, 509005, 509);
            return res;
        }
        public static byte Q130145(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 694354, 0, 0, 11033);

            c.Player.quest.AddTaskAccept(130146, 511001, 511);
            return res;
        }
        public static byte A130145(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130145, 511001, 2, 0, 511, 30, 511001);
            c.Player.quest.AddPack(130145, 511001, 511);
            return res;
        }
        public static byte Q130146(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 763789, 0, 0, 12137);

            c.Player.quest.AddTaskAccept(130147, 511001, 511);
            return res;
        }
        public static byte A130146(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130146, 511003, 2, 0, 511, 30, 511003);
            c.Player.quest.AddPack(130146, 511001, 511);
            return res;
        }
        public static byte Q130147(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Canyon Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 833225, 0, 0, 13240);

            c.Player.quest.AddTaskAccept(130148, 511001, 511);
            return res;
        }
        public static byte A130147(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Canyon Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130147, 511005, 2, 0, 511, 30, 511005);
            c.Player.quest.AddPack(130147, 511001, 511);
            return res;
        }
        public static byte Q130148(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Shadow Assassins in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 902660, 0, 0, 14342);

            c.Player.quest.AddTaskAccept(130149, 511001, 511);
            return res;
        }
        public static byte A130148(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Shadow Assassins in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130148, 511007, 2, 0, 511, 10, 511007);
            c.Player.quest.AddPack(130148, 511001, 511);
            return res;
        }
        public static byte Q130149(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 972098, 0, 0, 15445);

            c.Player.quest.AddTaskAccept(130150, 511001, 511);
            return res;
        }
        public static byte A130149(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130149, 511001, 2, 0, 511, 40, 511001);
            c.Player.quest.AddPack(130149, 511001, 511);
            return res;
        }
        public static byte Q130150(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Stone Lizards in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1041531, 0, 0, 16548);

            c.Player.quest.AddTaskAccept(130151, 511001, 511);
            return res;
        }
        public static byte A130150(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Stone Lizards in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130150, 511004, 2, 0, 511, 40, 511004);
            c.Player.quest.AddPack(130150, 511001, 511);
            return res;
        }
        public static byte Q130151(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1110969, 0, 0, 17653);

            c.Player.quest.AddTaskAccept(130152, 511001, 511);
            return res;
        }
        public static byte A130151(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130151, 511006, 2, 0, 511, 10, 511006);
            c.Player.quest.AddPack(130151, 511001, 511);
            return res;
        }
        public static byte Q130152(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1180402, 0, 0, 18756);

            c.Player.quest.AddTaskAccept(130153, 511001, 511);
            return res;
        }
        public static byte A130152(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130152, 511003, 2, 0, 511, 50, 511003);
            c.Player.quest.AddPack(130152, 511001, 511);
            return res;
        }
        public static byte Q130153(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Canyon Eagles in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1249837, 0, 0, 19859);

            c.Player.quest.AddTaskAccept(130154, 511001, 511);
            return res;
        }
        public static byte A130153(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Canyon Eagles in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130153, 511002, 2, 0, 511, 50, 511002);
            c.Player.quest.AddPack(130153, 511001, 511);
            return res;
        }
        public static byte Q130154(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Shadow Assassins in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1319273, 0, 0, 20962);
            return res;
        }
        public static byte A130154(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Shadow Assassins in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130154, 511007, 2, 0, 511, 10, 511007);
            c.Player.quest.AddPack(130154, 511001, 511);
            return res;
        }
        public static byte Q130155(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 258986, 4608, 0, 0);

            c.Player.quest.AddTaskAccept(130156, 511003, 511);
            return res;
        }
        public static byte A130155(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130155, 511003, 2, 0, 511, 30, 511003);
            c.Player.quest.AddPack(130155, 511003, 511);
            return res;
        }
        public static byte Q130156(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Darkwind Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 284886, 5040, 0, 0);

            c.Player.quest.AddTaskAccept(130157, 511003, 511);
            return res;
        }
        public static byte A130156(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Darkwind Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130156, 511005, 2, 0, 511, 30, 511005);
            c.Player.quest.AddPack(130156, 511003, 511);
            return res;
        }
        public static byte Q130157(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood。
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 310783, 5616, 0, 0);
            return res;
        }
        public static byte A130157(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood。
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130157, 511007, 2, 0, 511, 5, 511007);
            c.Player.quest.AddTaskComplete(130157, 511006, 2, 0, 511, 5, 511006);
            c.Player.quest.AddPack(130157, 511003, 511);
            return res;
        }
        public static byte Q130158(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 319292, 6048, 0, 0);

            c.Player.quest.AddTaskAccept(130159, 511003, 511);
            return res;
        }
        public static byte A130158(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130158, 511001, 2, 0, 511, 40, 511001);
            c.Player.quest.AddPack(130158, 511003, 511);
            return res;
        }
        public static byte Q130159(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 343855, 6480, 0, 0);

            c.Player.quest.AddTaskAccept(130160, 511003, 511);
            return res;
        }
        public static byte A130159(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130159, 511003, 2, 0, 511, 40, 511003);
            c.Player.quest.AddPack(130159, 511003, 511);
            return res;
        }
        public static byte Q130160(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 368416, 6912, 0, 0);
            return res;
        }
        public static byte A130160(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 65)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130160, 511007, 2, 0, 511, 5, 511007);
            c.Player.quest.AddTaskComplete(130160, 511006, 2, 0, 511, 5, 511006);
            c.Player.quest.AddPack(130160, 511003, 511);
            return res;
        }
        public static byte Q130161(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Stone Lizards in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 379679, 7488, 0, 0);

            c.Player.quest.AddTaskAccept(130162, 511003, 511);
            return res;
        }
        public static byte A130161(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Stone Lizards in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130161, 511004, 2, 0, 511, 50, 511004);
            c.Player.quest.AddPack(130161, 511003, 511);
            return res;
        }
        public static byte Q130162(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Canyon Eagles in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 403407, 7776, 0, 0);

            c.Player.quest.AddTaskAccept(130163, 511003, 511);
            return res;
        }
        public static byte A130162(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Canyon Eagles in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130162, 511002, 2, 0, 511, 50, 511002);
            c.Player.quest.AddPack(130162, 511003, 511);
            return res;
        }
        public static byte Q130163(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 427136, 8352, 0, 0);
            return res;
        }
        public static byte A130163(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
            if (QuestCommand.CanQuest(c, 68)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130163, 511007, 2, 0, 511, 5, 511007);
            c.Player.quest.AddTaskComplete(130163, 511006, 2, 0, 511, 5, 511006);
            c.Player.quest.AddPack(130163, 511003, 511);
            return res;
        }
        public static byte Q130164(ConnectionInfo c, int QuestID)
        {
            //Enter Starsoul instance, kill Ghost Sage·Borg, then go to see Morton.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 100000, 500, 0, 0);
            return res;
        }
        public static byte A130164(ConnectionInfo c, int QuestID)
        {
            //Enter Starsoul instance, kill Ghost Sage·Borg, then go to see Morton.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130164, 800081, 2, 0, 604, 1, 800081);
            c.Player.quest.AddPack(130164, 502048, 502);
            return res;
        }
        public static byte Q130165(ConnectionInfo c, int QuestID)
        {
            //Enter Starsoul instance, use 5 dream points, then go to see Charles.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 100000, 500, 0, 0);
            return res;
        }
        public static byte A130165(ConnectionInfo c, int QuestID)
        {
            //Enter Starsoul instance, use 5 dream points, then go to see Charles.
            if (QuestCommand.CanQuest(c, 30)) return 3;
            byte res = 1;

            return res;
        }
        public static byte Q130166(ConnectionInfo c, int QuestID)
        {
            //Enter Pharmacy, kill 3 Mana Potion Tyro, 3 HP Potion Tyro, 1 Druggist Kein, then report to Druggist Elo.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A130166(ConnectionInfo c, int QuestID)
        {
            //Enter Pharmacy, kill 3 Mana Potion Tyro, 3 HP Potion Tyro, 1 Druggist Kein, then report to Druggist Elo.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130166, 800098, 2, 0, 3201, 3, 800098);
            c.Player.quest.AddTaskComplete(130166, 800099, 2, 0, 3201, 3, 800099);
            c.Player.quest.AddTaskComplete(130166, 800108, 2, 0, 3202, 1, 800108);
            c.Player.quest.AddPack(130166, 502049, 502);
            return res;
        }
        public static byte Q130167(ConnectionInfo c, int QuestID)
        {
            //Enter Pharmacy, kill 3 STR Potion Tyro, 3 DEF Potion Tyro, 1 Druggist Luyer, then back to City of Genesis and tell Burton.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;

            res = QuestReward.R130167(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 100000, 12500, 0, 0);
            return res;
        }
        public static byte A130167(ConnectionInfo c, int QuestID)
        {
            //Enter Pharmacy, kill 3 STR Potion Tyro, 3 DEF Potion Tyro, 1 Druggist Luyer, then back to City of Genesis and tell Burton.
            if (QuestCommand.CanQuest(c, 62)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130167, 800100, 2, 0, 3201, 3, 800100);
            c.Player.quest.AddTaskComplete(130167, 800101, 2, 0, 3201, 3, 800101);
            c.Player.quest.AddTaskComplete(130167, 800105, 2, 0, 3201, 1, 800105);
            c.Player.quest.AddPack(130167, 502011, 502);
            return res;
        }
        public static byte Q130168(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1407610, 0, 0, 14400);

            c.Player.quest.AddTaskAccept(130169, 513004, 513);
            return res;
        }
        public static byte A130168(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130168, 513003, 2, 0, 513, 30, 513003);
            c.Player.quest.AddPack(130168, 513004, 513);
            return res;
        }
        public static byte Q130169(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1407610, 0, 0, 14400);

            c.Player.quest.AddTaskAccept(130170, 513004, 513);
            return res;
        }
        public static byte A130169(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130169, 513001, 2, 0, 513, 30, 513001);
            c.Player.quest.AddPack(130169, 513004, 513);
            return res;
        }
        public static byte Q130170(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Berserk Warriors in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1477933, 0, 0, 15180);

            c.Player.quest.AddTaskAccept(130171, 513004, 513);
            return res;
        }
        public static byte A130170(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Berserk Warriors in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130170, 513004, 2, 0, 513, 30, 513004);
            c.Player.quest.AddPack(130170, 513004, 513);
            return res;
        }
        public static byte Q130171(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Head Berserks in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1477933, 0, 0, 15180);

            c.Player.quest.AddTaskAccept(130172, 513004, 513);
            return res;
        }
        public static byte A130171(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Head Berserks in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130171, 513006, 2, 0, 513, 10, 513006);
            c.Player.quest.AddPack(130171, 513004, 513);
            return res;
        }
        public static byte Q130172(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1477933, 0, 0, 15180);

            c.Player.quest.AddTaskAccept(130173, 513004, 513);
            return res;
        }
        public static byte A130172(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130172, 513003, 2, 0, 513, 40, 513003);
            c.Player.quest.AddPack(130172, 513004, 513);
            return res;
        }
        public static byte Q130173(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Foggy Spiders in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1550507, 0, 0, 16200);

            c.Player.quest.AddTaskAccept(130174, 513004, 513);
            return res;
        }
        public static byte A130173(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Foggy Spiders in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130173, 513002, 2, 0, 513, 40, 513002);
            c.Player.quest.AddPack(130173, 513004, 513);
            return res;
        }
        public static byte Q130174(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1550507, 0, 0, 16200);

            c.Player.quest.AddTaskAccept(130175, 513004, 513);
            return res;
        }
        public static byte A130174(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130174, 513007, 2, 0, 513, 10, 513007);
            c.Player.quest.AddPack(130174, 513004, 513);
            return res;
        }
        public static byte Q130175(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1550507, 0, 0, 16200);

            c.Player.quest.AddTaskAccept(130176, 513004, 513);
            return res;
        }
        public static byte A130175(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130175, 513001, 2, 0, 513, 50, 513001);
            c.Player.quest.AddPack(130175, 513004, 513);
            return res;
        }
        public static byte Q130176(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Dawn Elves in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1625367, 0, 0, 16380);

            c.Player.quest.AddTaskAccept(130177, 513004, 513);
            return res;
        }
        public static byte A130176(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Dawn Elves in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130176, 513005, 2, 0, 513, 50, 513005);
            c.Player.quest.AddPack(130176, 513004, 513);
            return res;
        }
        public static byte Q130177(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Head Berserks in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1625367, 0, 0, 16380);
            return res;
        }
        public static byte A130177(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Head Berserks in Foggy Forest and then tell Foggy Forest\'s Gavin.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130177, 513006, 2, 0, 513, 10, 513006);
            c.Player.quest.AddPack(130177, 513004, 513);
            return res;
        }
        public static byte Q130178(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1625367, 13998, 0, 0);

            c.Player.quest.AddTaskAccept(130179, 513003, 513);
            return res;
        }
        public static byte A130178(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130178, 513001, 2, 0, 513, 30, 513001);
            c.Player.quest.AddPack(130178, 513003, 513);
            return res;
        }
        public static byte Q130179(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Berserk Warriors in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1702546, 14204, 0, 0);

            c.Player.quest.AddTaskAccept(130180, 513003, 513);
            return res;
        }
        public static byte A130179(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Berserk Warriors in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130179, 513004, 2, 0, 513, 30, 513004);
            c.Player.quest.AddPack(130179, 513003, 513);
            return res;
        }
        public static byte Q130180(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1702546, 14204, 0, 0);
            return res;
        }
        public static byte A130180(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 71)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130180, 513006, 2, 0, 513, 5, 513006);
            c.Player.quest.AddTaskComplete(130180, 513007, 2, 0, 513, 5, 513007);
            c.Player.quest.AddPack(130180, 513003, 513);
            return res;
        }
        public static byte Q130181(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1702546, 14204, 0, 0);

            c.Player.quest.AddTaskAccept(130182, 513003, 513);
            return res;
        }
        public static byte A130181(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130181, 513003, 2, 0, 513, 40, 513003);
            c.Player.quest.AddPack(130181, 513003, 513);
            return res;
        }
        public static byte Q130182(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1782081, 14382, 0, 0);

            c.Player.quest.AddTaskAccept(130183, 513003, 513);
            return res;
        }
        public static byte A130182(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130182, 513001, 2, 0, 513, 40, 513001);
            c.Player.quest.AddPack(130182, 513003, 513);
            return res;
        }
        public static byte Q130183(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1782081, 14382, 0, 0);
            return res;
        }
        public static byte A130183(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 75)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130183, 513006, 2, 0, 513, 5, 513006);
            c.Player.quest.AddTaskComplete(130183, 513007, 2, 0, 513, 5, 513007);
            c.Player.quest.AddPack(130183, 513003, 513);
            return res;
        }
        public static byte Q130184(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Foggy Spiders in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1782081, 14382, 0, 0);

            c.Player.quest.AddTaskAccept(130185, 513003, 513);
            return res;
        }
        public static byte A130184(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Foggy Spiders in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130184, 513002, 2, 0, 513, 50, 513002);
            c.Player.quest.AddPack(130184, 513003, 513);
            return res;
        }
        public static byte Q130185(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Dawn Elves in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1864006, 15000, 0, 0);

            c.Player.quest.AddTaskAccept(130186, 513003, 513);
            return res;
        }
        public static byte A130185(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Dawn Elves in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130185, 513005, 2, 0, 513, 50, 513005);
            c.Player.quest.AddPack(130185, 513003, 513);
            return res;
        }
        public static byte Q130186(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1864006, 15000, 0, 0);
            return res;
        }
        public static byte A130186(ConnectionInfo c, int QuestID)
        {
            //Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
            if (QuestCommand.CanQuest(c, 78)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130186, 513006, 2, 0, 513, 5, 513006);
            c.Player.quest.AddTaskComplete(130186, 513007, 2, 0, 513, 5, 513007);
            c.Player.quest.AddPack(130186, 513003, 513);
            return res;
        }
        public static byte Q130188(ConnectionInfo c, int QuestID)
        {
            //Enter Candy Shop, kill 3 Chocolate Guards, 3 Milk Guards, 1 Tooth Decay King, then report to Alchemist Nami.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A130188(ConnectionInfo c, int QuestID)
        {
            //Enter Candy Shop, kill 3 Chocolate Guards, 3 Milk Guards, 1 Tooth Decay King, then report to Alchemist Nami.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130188, 800110, 2, 0, 3203, 3, 800110);
            c.Player.quest.AddTaskComplete(130188, 800112, 2, 0, 3203, 3, 800112);
            c.Player.quest.AddTaskComplete(130188, 800120, 2, 0, 3204, 1, 800120);
            c.Player.quest.AddPack(130188, 502050, 502);
            return res;
        }
        public static byte Q130189(ConnectionInfo c, int QuestID)
        {
            //Enter Candy Shop, kill 3 Mango Milktea Guards, 3 Strawberry Milktea Guards, 1 Biscuit Princess, then back to City of Genesis and tell Burton.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;

            res = QuestReward.R130189(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 150000, 20000, 0, 0);
            return res;
        }
        public static byte A130189(ConnectionInfo c, int QuestID)
        {
            //Enter Candy Shop, kill 3 Mango Milktea Guards, 3 Strawberry Milktea Guards, 1 Biscuit Princess, then back to City of Genesis and tell Burton.
            if (QuestCommand.CanQuest(c, 72)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130189, 800113, 2, 0, 3204, 3, 800113);
            c.Player.quest.AddTaskComplete(130189, 800115, 2, 0, 3204, 3, 800115);
            c.Player.quest.AddTaskComplete(130189, 800119, 2, 0, 3204, 1, 800119);
            c.Player.quest.AddPack(130189, 502011, 502);
            return res;
        }
        public static byte Q130190(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Spirit Dragons on the Henan Mountainside then go back and report to Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2093740, 0, 0, 15888);

            c.Player.quest.AddTaskAccept(130191, 514006, 514);
            return res;
        }
        public static byte A130190(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Spirit Dragons on the Henan Mountainside then go back and report to Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130190, 515001, 2, 0, 515, 30, 515001);
            c.Player.quest.AddPack(130190, 514006, 514);
            return res;
        }
        public static byte Q130191(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Carefree Beasts on the Henan Mountainside then go back and report to Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2182918, 0, 0, 17476);

            c.Player.quest.AddTaskAccept(130192, 514006, 514);
            return res;
        }
        public static byte A130191(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Carefree Beasts on the Henan Mountainside then go back and report to Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130191, 515004, 2, 0, 515, 30, 515004);
            c.Player.quest.AddPack(130191, 514006, 514);
            return res;
        }
        public static byte Q130192(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Lost Acolytes on the Henan Mountainside then go back and report to Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2182918, 0, 0, 19065);

            c.Player.quest.AddTaskAccept(130193, 514006, 514);
            return res;
        }
        public static byte A130192(ConnectionInfo c, int QuestID)
        {
            //Kill 30 Lost Acolytes on the Henan Mountainside then go back and report to Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130192, 515002, 2, 0, 515, 30, 515002);
            c.Player.quest.AddPack(130192, 514006, 514);
            return res;
        }
        public static byte Q130193(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Dark Carefree Beasts on the Henan Moutainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2182918, 0, 0, 20653);

            c.Player.quest.AddTaskAccept(130194, 514006, 514);
            return res;
        }
        public static byte A130193(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Dark Carefree Beasts on the Henan Moutainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130193, 515006, 2, 0, 515, 10, 515006);
            c.Player.quest.AddPack(130193, 514006, 514);
            return res;
        }
        public static byte Q130194(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Spirit Dragons on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2274551, 0, 0, 22241);

            c.Player.quest.AddTaskAccept(130195, 514006, 514);
            return res;
        }
        public static byte A130194(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Spirit Dragons on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130194, 515001, 2, 0, 515, 40, 515001);
            c.Player.quest.AddPack(130194, 514006, 514);
            return res;
        }
        public static byte Q130195(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Bubble Beasts on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2274551, 0, 0, 23830);

            c.Player.quest.AddTaskAccept(130196, 514006, 514);
            return res;
        }
        public static byte A130195(ConnectionInfo c, int QuestID)
        {
            //Kill 40 Bubble Beasts on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130195, 515005, 2, 0, 515, 40, 515005);
            c.Player.quest.AddPack(130195, 514006, 514);
            return res;
        }
        public static byte Q130196(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Guarder Sissi on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2274551, 0, 0, 25420);

            c.Player.quest.AddTaskAccept(130197, 514006, 514);
            return res;
        }
        public static byte A130196(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Guarder Sissi on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130196, 515007, 2, 0, 515, 10, 515007);
            c.Player.quest.AddPack(130196, 514006, 514);
            return res;
        }
        public static byte Q130197(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Carefree Beasts on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2368672, 0, 0, 27009);

            c.Player.quest.AddTaskAccept(130198, 514006, 514);
            return res;
        }
        public static byte A130197(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Carefree Beasts on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130197, 515004, 2, 0, 515, 50, 515004);
            c.Player.quest.AddPack(130197, 514006, 514);
            return res;
        }
        public static byte Q130198(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Skyish Beasts on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2368672, 0, 0, 28597);

            c.Player.quest.AddTaskAccept(130199, 514006, 514);
            return res;
        }
        public static byte A130198(ConnectionInfo c, int QuestID)
        {
            //Kill 50 Skyish Beasts on the Henan Mountainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130198, 515003, 2, 0, 515, 50, 515003);
            c.Player.quest.AddPack(130198, 514006, 514);
            return res;
        }
        public static byte Q130199(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Dark Carefree Beasts on the Henan Moutainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2368672, 0, 0, 30185);
            return res;
        }
        public static byte A130199(ConnectionInfo c, int QuestID)
        {
            //Kill 10 Dark Carefree Beasts on the Henan Moutainside then go back and tell Herman.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130199, 515006, 2, 0, 515, 10, 515006);
            c.Player.quest.AddPack(130199, 514006, 514);
            return res;
        }
        public static byte Q130200(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Carefree Beasts on the Henan Mountainside then go back and report to Mitchell.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2465315, 6636, 0, 0);

            c.Player.quest.AddTaskAccept(130201, 515003, 515);
            return res;
        }
        public static byte A130200(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Carefree Beasts on the Henan Mountainside then go back and report to Mitchell.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130200, 515004, 2, 0, 515, 30, 515004);
            c.Player.quest.AddPack(130200, 515003, 515);
            return res;
        }
        public static byte Q130201(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Lost Acolytes on the Henan Mountainside then go back and report to Mitchell.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2465315, 7258, 0, 0);

            c.Player.quest.AddTaskAccept(130202, 515003, 515);
            return res;
        }
        public static byte A130201(ConnectionInfo c, int QuestID)
        {
            //Defeat 30 Lost Acolytes on the Henan Mountainside then go back and report to Mitchell.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130201, 515002, 2, 0, 515, 30, 515002);
            c.Player.quest.AddPack(130201, 515003, 515);
            return res;
        }
        public static byte Q130202(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2465315, 8087, 0, 0);
            return res;
        }
        public static byte A130202(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
            if (QuestCommand.CanQuest(c, 81)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130202, 515006, 2, 0, 515, 5, 515006);
            c.Player.quest.AddTaskComplete(130202, 515007, 2, 0, 515, 5, 515007);
            c.Player.quest.AddPack(130202, 515003, 515);
            return res;
        }
        public static byte Q130203(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Spirit Dragons on the Henan Mountainside then go back and tell Mitchell.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2564512, 8709, 0, 0);

            c.Player.quest.AddTaskAccept(130204, 515003, 515);
            return res;
        }
        public static byte A130203(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Spirit Dragons on the Henan Mountainside then go back and tell Mitchell.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130203, 515001, 2, 0, 515, 40, 515001);
            c.Player.quest.AddPack(130203, 515003, 515);
            return res;
        }
        public static byte Q130204(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Carefree Beasts on the Henan Mountainside then go back and report to Mitchell.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2564512, 9331, 0, 0);

            c.Player.quest.AddTaskAccept(130205, 515003, 515);
            return res;
        }
        public static byte A130204(ConnectionInfo c, int QuestID)
        {
            //Defeat 40 Carefree Beasts on the Henan Mountainside then go back and report to Mitchell.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130204, 515004, 2, 0, 515, 40, 515004);
            c.Player.quest.AddPack(130204, 515003, 515);
            return res;
        }
        public static byte Q130205(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2564512, 9953, 0, 0);
            return res;
        }
        public static byte A130205(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
            if (QuestCommand.CanQuest(c, 85)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130205, 515006, 2, 0, 515, 5, 515006);
            c.Player.quest.AddTaskComplete(130205, 515007, 2, 0, 515, 5, 515007);
            c.Player.quest.AddPack(130205, 515003, 515);
            return res;
        }
        public static byte Q130206(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Bubble Beasts on the Henan Mountainside then go back and tell  Mitchell.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2666296, 10783, 0, 0);

            c.Player.quest.AddTaskAccept(130207, 515003, 515);
            return res;
        }
        public static byte A130206(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Bubble Beasts on the Henan Mountainside then go back and tell  Mitchell.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130206, 515005, 2, 0, 515, 50, 515005);
            c.Player.quest.AddPack(130206, 515003, 515);
            return res;
        }
        public static byte Q130207(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Skyish Beasts on the Henan Mountainside then go back and tell Mitchell
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2666296, 11197, 0, 0);

            c.Player.quest.AddTaskAccept(130208, 515003, 515);
            return res;
        }
        public static byte A130207(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Skyish Beasts on the Henan Mountainside then go back and tell Mitchell
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130207, 515003, 2, 0, 515, 50, 515003);
            c.Player.quest.AddPack(130207, 515003, 515);
            return res;
        }
        public static byte Q130208(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2666296, 12027, 0, 0);
            return res;
        }
        public static byte A130208(ConnectionInfo c, int QuestID)
        {
            //Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
            if (QuestCommand.CanQuest(c, 88)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130208, 515006, 2, 0, 515, 5, 515006);
            c.Player.quest.AddTaskComplete(130208, 515007, 2, 0, 515, 5, 515007);
            c.Player.quest.AddPack(130208, 515003, 515);
            return res;
        }
        public static byte Q130209(ConnectionInfo c, int QuestID)
        {
            //Enter the toy factory, kill 3 Raw Material Buyers, 3 Lost Secretaries and 1 Fallen Earl Charlie then report to Lord Terry .
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A130209(ConnectionInfo c, int QuestID)
        {
            //Enter the toy factory, kill 3 Raw Material Buyers, 3 Lost Secretaries and 1 Fallen Earl Charlie then report to Lord Terry .
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130209, 800122, 2, 0, 3205, 3, 800122);
            c.Player.quest.AddTaskComplete(130209, 800125, 2, 0, 3206, 3, 800125);
            c.Player.quest.AddTaskComplete(130209, 800130, 2, 0, 3206, 1, 800130);
            c.Player.quest.AddPack(130209, 502052, 502);
            return res;
        }
        public static byte Q130210(ConnectionInfo c, int QuestID)
        {
            //Enter the toy factory, kill 3 QA Inspectors, 3 Lost Guards，and 1 Dark Witch Avri, then go back to City of Genesis and report to Larry.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;

            res = QuestReward.R130210(c);
            if (res != 1) return res;

            Tasks.AddQuestFinance(c, 250000, 35000, 0, 0);
            return res;
        }
        public static byte A130210(ConnectionInfo c, int QuestID)
        {
            //Enter the toy factory, kill 3 QA Inspectors, 3 Lost Guards，and 1 Dark Witch Avri, then go back to City of Genesis and report to Larry.
            if (QuestCommand.CanQuest(c, 82)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(130210, 800124, 2, 0, 3205, 3, 800124);
            c.Player.quest.AddTaskComplete(130210, 800126, 2, 0, 3206, 3, 800126);
            c.Player.quest.AddTaskComplete(130210, 800131, 2, 0, 3206, 1, 800131);
            c.Player.quest.AddPack(130210, 502011, 502);
            return res;
        }
        public static byte Q140102(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140102(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 31)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140102, 502024, 1, 1, 502);
            return res;
        }
        public static byte Q140103(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 19636, 0, 0, 0);
            return res;
        }
        public static byte A140103(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 36)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140103, 502024, 1, 1, 502);
            return res;
        }
        public static byte Q140104(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 25469, 0, 0, 0);
            return res;
        }
        public static byte A140104(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 41)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140104, 502024, 1, 1, 502);
            return res;
        }
        public static byte Q140105(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140105(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 46)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140105, 502024, 1, 1, 502);
            return res;
        }
        public static byte Q140106(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 39409, 0, 0, 0);
            return res;
        }
        public static byte A140106(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 51)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140106, 502024, 1, 1, 502);
            return res;
        }
        public static byte Q140107(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 47515, 0, 0, 0);
            return res;
        }
        public static byte A140107(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 56)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140107, 502024, 1, 1, 502);
            return res;
        }
        public static byte Q140108(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 56378, 0, 0, 0);
            return res;
        }
        public static byte A140108(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 61)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140108, 502024, 1, 1, 502);
            return res;
        }
        public static byte Q140109(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140109(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Earl Kleist about the origin of the world.
            if (QuestCommand.CanQuest(c, 66)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140109, 502024, 1, 1, 502);
            return res;
        }
        public static byte Q140206(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 29121, 0, 0, 0);
            return res;
        }
        public static byte A140206(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140206, 502022, 1, 1, 502);
            return res;
        }
        public static byte Q140207(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 29121, 0, 0, 0);
            return res;
        }
        public static byte A140207(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140207, 301022, 1, 1, 301);
            return res;
        }
        public static byte Q140208(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 29121, 0, 0, 0);
            return res;
        }
        public static byte A140208(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140208, 401022, 1, 1, 401);
            return res;
        }
        public static byte Q140209(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 29121, 0, 0, 0);
            return res;
        }
        public static byte A140209(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140209, 201013, 1, 1, 201);
            return res;
        }
        public static byte Q140211(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 39272, 0, 0, 0);
            return res;
        }
        public static byte A140211(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140211, 502022, 1, 1, 502);
            return res;
        }
        public static byte Q140212(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 39272, 0, 0, 0);
            return res;
        }
        public static byte A140212(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140212, 301022, 1, 1, 301);
            return res;
        }
        public static byte Q140213(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 39272, 0, 0, 0);
            return res;
        }
        public static byte A140213(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140213, 401022, 1, 1, 401);
            return res;
        }
        public static byte Q140214(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 39272, 0, 0, 0);
            return res;
        }
        public static byte A140214(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140214, 201013, 1, 1, 201);
            return res;
        }
        public static byte Q140216(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 50939, 0, 0, 0);
            return res;
        }
        public static byte A140216(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140216, 502022, 1, 1, 502);
            return res;
        }
        public static byte Q140217(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 50939, 0, 0, 0);
            return res;
        }
        public static byte A140217(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140217, 301022, 1, 1, 301);
            return res;
        }
        public static byte Q140218(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 50939, 0, 0, 0);
            return res;
        }
        public static byte A140218(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140218, 401022, 1, 1, 401);
            return res;
        }
        public static byte Q140219(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 50939, 0, 0, 0);
            return res;
        }
        public static byte A140219(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140219, 201013, 1, 1, 201);
            return res;
        }
        public static byte Q140221(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 64121, 0, 0, 0);
            return res;
        }
        public static byte A140221(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140221, 502022, 1, 1, 502);
            return res;
        }
        public static byte Q140222(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 64121, 0, 0, 0);
            return res;
        }
        public static byte A140222(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140222, 301022, 1, 1, 301);
            return res;
        }
        public static byte Q140223(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 64121, 0, 0, 0);
            return res;
        }
        public static byte A140223(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140223, 401022, 1, 1, 401);
            return res;
        }
        public static byte Q140224(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 64121, 0, 0, 0);
            return res;
        }
        public static byte A140224(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140224, 201013, 1, 1, 201);
            return res;
        }
        public static byte Q140225(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 78818, 0, 0, 0);
            return res;
        }
        public static byte A140225(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140225, 502022, 1, 1, 502);
            return res;
        }
        public static byte Q140226(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 78818, 0, 0, 0);
            return res;
        }
        public static byte A140226(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140226, 301022, 1, 1, 301);
            return res;
        }
        public static byte Q140227(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 78818, 0, 0, 0);
            return res;
        }
        public static byte A140227(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140227, 401022, 1, 1, 401);
            return res;
        }
        public static byte Q140228(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 78818, 0, 0, 0);
            return res;
        }
        public static byte A140228(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140228, 201013, 1, 1, 201);
            return res;
        }
        public static byte Q140229(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140229(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140229, 502022, 1, 1, 502);
            return res;
        }
        public static byte Q140230(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140230(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140230, 301022, 1, 1, 301);
            return res;
        }
        public static byte Q140231(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140231(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140231, 401022, 1, 1, 401);
            return res;
        }
        public static byte Q140232(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140232(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140232, 201013, 1, 1, 201);
            return res;
        }
        public static byte Q140233(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 112757, 0, 0, 0);
            return res;
        }
        public static byte A140233(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140233, 502022, 1, 1, 502);
            return res;
        }
        public static byte Q140234(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 112757, 0, 0, 0);
            return res;
        }
        public static byte A140234(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140234, 301022, 1, 1, 301);
            return res;
        }
        public static byte Q140235(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 112757, 0, 0, 0);
            return res;
        }
        public static byte A140235(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140235, 401022, 1, 1, 401);
            return res;
        }
        public static byte Q140236(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 112757, 0, 0, 0);
            return res;
        }
        public static byte A140236(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140236, 201013, 1, 1, 201);
            return res;
        }
        public static byte Q140237(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140237(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask General Alston about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140237, 502022, 1, 1, 502);
            return res;
        }
        public static byte Q140238(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140238(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Haglos about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140238, 301022, 1, 1, 301);
            return res;
        }
        public static byte Q140239(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140239(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Berger about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140239, 401022, 1, 1, 401);
            return res;
        }
        public static byte Q140240(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140240(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Makhlou about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140240, 201013, 1, 1, 201);
            return res;
        }
        public static byte Q140309(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Toothy Gerbils, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140309(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Toothy Gerbils, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140309, 505001, 2, 0, 505, 50, 505001);
            c.Player.quest.AddPack(140309, 301013, 301);
            return res;
        }
        public static byte Q140310(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Bactrian Camels, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140310(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Bactrian Camels, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140310, 505002, 2, 0, 505, 50, 505002);
            c.Player.quest.AddPack(140310, 301013, 301);
            return res;
        }
        public static byte Q140311(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Rattlesnakes, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140311(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Rattlesnakes, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140311, 505003, 2, 0, 505, 50, 505003);
            c.Player.quest.AddPack(140311, 301013, 301);
            return res;
        }
        public static byte Q140312(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140312(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140312, 505004, 2, 0, 505, 50, 505004);
            c.Player.quest.AddPack(140312, 301013, 301);
            return res;
        }
        public static byte Q140313(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Trade Wind Foxes, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140313(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Trade Wind Foxes, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140313, 505005, 2, 0, 505, 50, 505005);
            c.Player.quest.AddPack(140313, 301013, 301);
            return res;
        }
        public static byte Q140314(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Toxic Scorpions, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140314(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Toxic Scorpions, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140314, 505006, 2, 0, 505, 50, 505006);
            c.Player.quest.AddPack(140314, 301013, 301);
            return res;
        }
        public static byte Q140315(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Sand Fire Lizards, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140315(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Sand Fire Lizards, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140315, 505007, 2, 0, 505, 50, 505007);
            c.Player.quest.AddPack(140315, 301013, 301);
            return res;
        }
        public static byte Q140316(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darkthorn Cactus, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140316(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darkthorn Cactus, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140316, 5010050, 4, 0, 505, 10, 505101);
            c.Player.quest.AddPack(140316, 301013, 301);
            return res;
        }
        public static byte Q140317(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Grass, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140317(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Grass, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140317, 5010051, 4, 0, 505, 10, 505102);
            c.Player.quest.AddPack(140317, 301013, 301);
            return res;
        }
        public static byte Q140318(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140318(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140318, 5010052, 4, 0, 505, 10, 505103);
            c.Player.quest.AddPack(140318, 301013, 301);
            return res;
        }
        public static byte Q140319(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darksand Essences, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 43681, 0, 0, 0);
            return res;
        }
        public static byte A140319(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darksand Essences, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140319, 5010053, 4, 0, 505, 10, 505104);
            c.Player.quest.AddPack(140319, 301013, 301);
            return res;
        }
        public static byte Q140322(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Toothy Gerbils, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140322(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Toothy Gerbils, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140322, 505001, 2, 0, 505, 60, 505001);
            c.Player.quest.AddPack(140322, 301013, 301);
            return res;
        }
        public static byte Q140323(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Bactrian Camels, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140323(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Bactrian Camels, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140323, 505002, 2, 0, 505, 60, 505002);
            c.Player.quest.AddPack(140323, 301013, 301);
            return res;
        }
        public static byte Q140324(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Rattlesnakes, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140324(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Rattlesnakes, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140324, 505003, 2, 0, 505, 60, 505003);
            c.Player.quest.AddPack(140324, 301013, 301);
            return res;
        }
        public static byte Q140325(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140325(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140325, 505004, 2, 0, 505, 60, 505004);
            c.Player.quest.AddPack(140325, 301013, 301);
            return res;
        }
        public static byte Q140326(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Trade Wind Foxes, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140326(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Trade Wind Foxes, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140326, 505005, 2, 0, 505, 60, 505005);
            c.Player.quest.AddPack(140326, 301013, 301);
            return res;
        }
        public static byte Q140327(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Toxic Scorpions, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140327(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Toxic Scorpions, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140327, 505006, 2, 0, 505, 60, 505006);
            c.Player.quest.AddPack(140327, 301013, 301);
            return res;
        }
        public static byte Q140328(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Sand Fire Lizards, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140328(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Sand Fire Lizards, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140328, 505007, 2, 0, 505, 60, 505007);
            c.Player.quest.AddPack(140328, 301013, 301);
            return res;
        }
        public static byte Q140329(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darkthorn Cactus, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140329(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darkthorn Cactus, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140329, 5010050, 4, 0, 505, 10, 505101);
            c.Player.quest.AddPack(140329, 301013, 301);
            return res;
        }
        public static byte Q140330(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Grass, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140330(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Grass, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140330, 5010051, 4, 0, 505, 10, 505102);
            c.Player.quest.AddPack(140330, 301013, 301);
            return res;
        }
        public static byte Q140331(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140331(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140331, 5010052, 4, 0, 505, 10, 505103);
            c.Player.quest.AddPack(140331, 301013, 301);
            return res;
        }
        public static byte Q140332(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darksand Essences, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58909, 0, 0, 0);
            return res;
        }
        public static byte A140332(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darksand Essences, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140332, 5010053, 4, 0, 505, 10, 505104);
            c.Player.quest.AddPack(140332, 301013, 301);
            return res;
        }
        public static byte Q140335(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Giant Jaw Ants, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76409, 0, 0, 0);
            return res;
        }
        public static byte A140335(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Giant Jaw Ants, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140335, 507001, 2, 0, 507, 70, 507001);
            c.Player.quest.AddPack(140335, 301013, 301);
            return res;
        }
        public static byte Q140336(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Mud Monsters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76409, 0, 0, 0);
            return res;
        }
        public static byte A140336(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Mud Monsters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140336, 507002, 2, 0, 507, 70, 507002);
            c.Player.quest.AddPack(140336, 301013, 301);
            return res;
        }
        public static byte Q140337(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Man-eating Trees, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76409, 0, 0, 0);
            return res;
        }
        public static byte A140337(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Man-eating Trees, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140337, 507003, 2, 0, 507, 70, 507003);
            c.Player.quest.AddPack(140337, 301013, 301);
            return res;
        }
        public static byte Q140338(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Phantom Monkeys, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76409, 0, 0, 0);
            return res;
        }
        public static byte A140338(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Phantom Monkeys, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140338, 507004, 2, 0, 507, 70, 507004);
            c.Player.quest.AddPack(140338, 301013, 301);
            return res;
        }
        public static byte Q140339(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Wraith Spiders, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76409, 0, 0, 0);
            return res;
        }
        public static byte A140339(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Wraith Spiders, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140339, 507005, 2, 0, 507, 70, 507005);
            c.Player.quest.AddPack(140339, 301013, 301);
            return res;
        }
        public static byte Q140340(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Delusion Herbs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76409, 0, 0, 0);
            return res;
        }
        public static byte A140340(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Delusion Herbs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140340, 5010055, 4, 0, 507, 10, 507101);
            c.Player.quest.AddPack(140340, 301013, 301);
            return res;
        }
        public static byte Q140341(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Vampire Vines, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76409, 0, 0, 0);
            return res;
        }
        public static byte A140341(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Vampire Vines, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140341, 5010056, 4, 0, 507, 10, 507102);
            c.Player.quest.AddPack(140341, 301013, 301);
            return res;
        }
        public static byte Q140342(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Luminous Grass, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76409, 0, 0, 0);
            return res;
        }
        public static byte A140342(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Luminous Grass, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140342, 5010057, 4, 0, 507, 10, 507103);
            c.Player.quest.AddPack(140342, 301013, 301);
            return res;
        }
        public static byte Q140343(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Water Mana Spar, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 76409, 0, 0, 0);
            return res;
        }
        public static byte A140343(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Water Mana Spar, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140343, 5010058, 4, 0, 507, 10, 507104);
            c.Player.quest.AddPack(140343, 301013, 301);
            return res;
        }
        public static byte Q140346(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Giant Jaw Ants, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 96181, 0, 0, 0);
            return res;
        }
        public static byte A140346(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Giant Jaw Ants, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140346, 507001, 2, 0, 507, 80, 507001);
            c.Player.quest.AddPack(140346, 301013, 301);
            return res;
        }
        public static byte Q140347(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Mud Monsters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 96181, 0, 0, 0);
            return res;
        }
        public static byte A140347(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Mud Monsters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140347, 507002, 2, 0, 507, 80, 507002);
            c.Player.quest.AddPack(140347, 301013, 301);
            return res;
        }
        public static byte Q140348(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Man-eating Trees, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 96181, 0, 0, 0);
            return res;
        }
        public static byte A140348(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Man-eating Trees, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140348, 507003, 2, 0, 507, 80, 507003);
            c.Player.quest.AddPack(140348, 301013, 301);
            return res;
        }
        public static byte Q140349(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Phantom Monkeys, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 96181, 0, 0, 0);
            return res;
        }
        public static byte A140349(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Phantom Monkeys, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140349, 507004, 2, 0, 507, 80, 507004);
            c.Player.quest.AddPack(140349, 301013, 301);
            return res;
        }
        public static byte Q140350(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Wraith Spiders, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 96181, 0, 0, 0);
            return res;
        }
        public static byte A140350(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Wraith Spiders, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140350, 507005, 2, 0, 507, 80, 507005);
            c.Player.quest.AddPack(140350, 301013, 301);
            return res;
        }
        public static byte Q140351(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Delusion Herbs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 96181, 0, 0, 0);
            return res;
        }
        public static byte A140351(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Delusion Herbs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140351, 5010055, 4, 0, 507, 10, 507101);
            c.Player.quest.AddPack(140351, 301013, 301);
            return res;
        }
        public static byte Q140352(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Vampire Vines, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 96181, 0, 0, 0);
            return res;
        }
        public static byte A140352(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Vampire Vines, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140352, 5010056, 4, 0, 507, 10, 507102);
            c.Player.quest.AddPack(140352, 301013, 301);
            return res;
        }
        public static byte Q140353(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Luminous Grass, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 96181, 0, 0, 0);
            return res;
        }
        public static byte A140353(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Luminous Grass, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140353, 5010057, 4, 0, 507, 10, 507103);
            c.Player.quest.AddPack(140353, 301013, 301);
            return res;
        }
        public static byte Q140354(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Water Mana Spar, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 96181, 0, 0, 0);
            return res;
        }
        public static byte A140354(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Water Mana Spar, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140354, 5010058, 4, 0, 507, 10, 507104);
            c.Player.quest.AddPack(140354, 301013, 301);
            return res;
        }
        public static byte Q140355(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Venom Monsters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 118227, 0, 0, 0);
            return res;
        }
        public static byte A140355(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Venom Monsters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140355, 509001, 2, 0, 509, 90, 509001);
            c.Player.quest.AddPack(140355, 301013, 301);
            return res;
        }
        public static byte Q140356(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 118227, 0, 0, 0);
            return res;
        }
        public static byte A140356(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140356, 509002, 2, 0, 509, 90, 509002);
            c.Player.quest.AddPack(140356, 301013, 301);
            return res;
        }
        public static byte Q140357(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Medusa, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 118227, 0, 0, 0);
            return res;
        }
        public static byte A140357(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Medusa, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140357, 509003, 2, 0, 509, 90, 509003);
            c.Player.quest.AddPack(140357, 301013, 301);
            return res;
        }
        public static byte Q140358(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Mugger Crocodiles, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 118227, 0, 0, 0);
            return res;
        }
        public static byte A140358(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Mugger Crocodiles, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140358, 509004, 2, 0, 509, 90, 509004);
            c.Player.quest.AddPack(140358, 301013, 301);
            return res;
        }
        public static byte Q140359(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Carrion, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 118227, 0, 0, 0);
            return res;
        }
        public static byte A140359(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Carrion, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140359, 509005, 2, 0, 509, 90, 509005);
            c.Player.quest.AddPack(140359, 301013, 301);
            return res;
        }
        public static byte Q140360(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Fluorescent Herbs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 118227, 0, 0, 0);
            return res;
        }
        public static byte A140360(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Fluorescent Herbs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140360, 5010067, 4, 0, 509, 10, 509101);
            c.Player.quest.AddPack(140360, 301013, 301);
            return res;
        }
        public static byte Q140361(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Rotten Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 118227, 0, 0, 0);
            return res;
        }
        public static byte A140361(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Rotten Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140361, 5010068, 4, 0, 509, 10, 509102);
            c.Player.quest.AddPack(140361, 301013, 301);
            return res;
        }
        public static byte Q140362(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Greenbell Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 118227, 0, 0, 0);
            return res;
        }
        public static byte A140362(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Greenbell Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140362, 5010069, 4, 0, 509, 10, 509103);
            c.Player.quest.AddPack(140362, 301013, 301);
            return res;
        }
        public static byte Q140363(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Venom Monsters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 142545, 0, 0, 0);
            return res;
        }
        public static byte A140363(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Venom Monsters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140363, 509001, 2, 0, 509, 100, 509001);
            c.Player.quest.AddPack(140363, 301013, 301);
            return res;
        }
        public static byte Q140364(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 142545, 0, 0, 0);
            return res;
        }
        public static byte A140364(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140364, 509002, 2, 0, 509, 100, 509002);
            c.Player.quest.AddPack(140364, 301013, 301);
            return res;
        }
        public static byte Q140365(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Medusa, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 142545, 0, 0, 0);
            return res;
        }
        public static byte A140365(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Medusa, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140365, 509003, 2, 0, 509, 100, 509003);
            c.Player.quest.AddPack(140365, 301013, 301);
            return res;
        }
        public static byte Q140366(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Mugger Crocodiles, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 142545, 0, 0, 0);
            return res;
        }
        public static byte A140366(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Mugger Crocodiles, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140366, 509004, 2, 0, 509, 100, 509004);
            c.Player.quest.AddPack(140366, 301013, 301);
            return res;
        }
        public static byte Q140367(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Carrion, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 142545, 0, 0, 0);
            return res;
        }
        public static byte A140367(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Carrion, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140367, 509005, 2, 0, 509, 100, 509005);
            c.Player.quest.AddPack(140367, 301013, 301);
            return res;
        }
        public static byte Q140368(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Fluorescent Herbs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 142545, 0, 0, 0);
            return res;
        }
        public static byte A140368(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Fluorescent Herbs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140368, 5010067, 4, 0, 509, 10, 509101);
            c.Player.quest.AddPack(140368, 301013, 301);
            return res;
        }
        public static byte Q140369(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Rotten Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 142545, 0, 0, 0);
            return res;
        }
        public static byte A140369(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Rotten Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140369, 5010068, 4, 0, 509, 10, 509102);
            c.Player.quest.AddPack(140369, 301013, 301);
            return res;
        }
        public static byte Q140370(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Greenbell Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 142545, 0, 0, 0);
            return res;
        }
        public static byte A140370(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Greenbell Flowers, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140370, 5010069, 4, 0, 509, 10, 509103);
            c.Player.quest.AddPack(140370, 301013, 301);
            return res;
        }
        public static byte Q140371(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 169136, 0, 0, 0);
            return res;
        }
        public static byte A140371(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140371, 511001, 2, 0, 511, 110, 511001);
            c.Player.quest.AddPack(140371, 301013, 301);
            return res;
        }
        public static byte Q140372(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Darkwind Hunters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 169136, 0, 0, 0);
            return res;
        }
        public static byte A140372(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Darkwind Hunters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140372, 511003, 2, 0, 511, 110, 511003);
            c.Player.quest.AddPack(140372, 301013, 301);
            return res;
        }
        public static byte Q140373(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Canyon Centaurs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 169136, 0, 0, 0);
            return res;
        }
        public static byte A140373(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Canyon Centaurs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140373, 511005, 2, 0, 511, 110, 511005);
            c.Player.quest.AddPack(140373, 301013, 301);
            return res;
        }
        public static byte Q140374(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Stone Lizards, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 169136, 0, 0, 0);
            return res;
        }
        public static byte A140374(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Stone Lizards, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140374, 511004, 2, 0, 511, 110, 511004);
            c.Player.quest.AddPack(140374, 301013, 301);
            return res;
        }
        public static byte Q140375(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Canyon Eagles, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 169136, 0, 0, 0);
            return res;
        }
        public static byte A140375(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Canyon Eagles, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140375, 511002, 2, 0, 511, 110, 511002);
            c.Player.quest.AddPack(140375, 301013, 301);
            return res;
        }
        public static byte Q140376(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Cruor Grasses, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 169136, 0, 0, 0);
            return res;
        }
        public static byte A140376(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Cruor Grasses, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140376, 5010070, 4, 0, 511, 10, 511101);
            c.Player.quest.AddPack(140376, 301013, 301);
            return res;
        }
        public static byte Q140377(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Hyacinths, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 169136, 0, 0, 0);
            return res;
        }
        public static byte A140377(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Hyacinths, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140377, 5010071, 4, 0, 511, 10, 511102);
            c.Player.quest.AddPack(140377, 301013, 301);
            return res;
        }
        public static byte Q140378(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Darkwind Wolves, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140378(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Darkwind Wolves, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140378, 511001, 2, 0, 511, 120, 511001);
            c.Player.quest.AddPack(140378, 301013, 301);
            return res;
        }
        public static byte Q140379(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Darkwind Hunters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140379(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Darkwind Hunters, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140379, 511003, 2, 0, 511, 120, 511003);
            c.Player.quest.AddPack(140379, 301013, 301);
            return res;
        }
        public static byte Q140380(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Canyon Centaurs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140380(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Canyon Centaurs, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140380, 511005, 2, 0, 511, 120, 511005);
            c.Player.quest.AddPack(140380, 301013, 301);
            return res;
        }
        public static byte Q140381(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Stone Lizards, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140381(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Stone Lizards, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140381, 511004, 2, 0, 511, 120, 511004);
            c.Player.quest.AddPack(140381, 301013, 301);
            return res;
        }
        public static byte Q140382(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Canyon Eagles, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140382(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Canyon Eagles, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140382, 511002, 2, 0, 511, 120, 511002);
            c.Player.quest.AddPack(140382, 301013, 301);
            return res;
        }
        public static byte Q140383(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Cruor Grasses, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140383(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Cruor Grasses, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140383, 5010070, 4, 0, 511, 10, 511101);
            c.Player.quest.AddPack(140383, 301013, 301);
            return res;
        }
        public static byte Q140384(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Hyacinths, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140384(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Hyacinths, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140384, 5010071, 4, 0, 511, 10, 511102);
            c.Player.quest.AddPack(140384, 301013, 301);
            return res;
        }
        public static byte Q140406(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58242, 0, 0, 0);
            return res;
        }
        public static byte A140406(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140406, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140407(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58242, 0, 0, 0);
            return res;
        }
        public static byte A140407(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140407, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140408(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58242, 0, 0, 0);
            return res;
        }
        public static byte A140408(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140408, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140409(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 58242, 0, 0, 0);
            return res;
        }
        public static byte A140409(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140409, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140411(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 78545, 0, 0, 0);
            return res;
        }
        public static byte A140411(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140411, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140412(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 78545, 0, 0, 0);
            return res;
        }
        public static byte A140412(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140412, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140413(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 78545, 0, 0, 0);
            return res;
        }
        public static byte A140413(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140413, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140414(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 78545, 0, 0, 0);
            return res;
        }
        public static byte A140414(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140414, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140416(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 101878, 0, 0, 0);
            return res;
        }
        public static byte A140416(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140416, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140417(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 101878, 0, 0, 0);
            return res;
        }
        public static byte A140417(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140417, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140418(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 101878, 0, 0, 0);
            return res;
        }
        public static byte A140418(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140418, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140419(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 101878, 0, 0, 0);
            return res;
        }
        public static byte A140419(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140419, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140421(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 128242, 0, 0, 0);
            return res;
        }
        public static byte A140421(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140421, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140422(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 128242, 0, 0, 0);
            return res;
        }
        public static byte A140422(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140422, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140423(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 128242, 0, 0, 0);
            return res;
        }
        public static byte A140423(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140423, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140424(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 128242, 0, 0, 0);
            return res;
        }
        public static byte A140424(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140424, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140425(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 157636, 0, 0, 0);
            return res;
        }
        public static byte A140425(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140425, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140426(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 157636, 0, 0, 0);
            return res;
        }
        public static byte A140426(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140426, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140427(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 157636, 0, 0, 0);
            return res;
        }
        public static byte A140427(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140427, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140428(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 157636, 0, 0, 0);
            return res;
        }
        public static byte A140428(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140428, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140429(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140429(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140429, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140430(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140430(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140430, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140431(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140431(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140431, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140432(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140432(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140432, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140433(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 225515, 0, 0, 0);
            return res;
        }
        public static byte A140433(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140433, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140434(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 225515, 0, 0, 0);
            return res;
        }
        public static byte A140434(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140434, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140435(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 225515, 0, 0, 0);
            return res;
        }
        public static byte A140435(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140435, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140436(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 225515, 0, 0, 0);
            return res;
        }
        public static byte A140436(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140436, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140437(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140437(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140437, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140438(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140438(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140438, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140439(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140439(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140439, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140440(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140440(ConnectionInfo c, int QuestID)
        {
            //Ask Scarce about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140440, 201014, 1, 1, 201);
            return res;
        }
        public static byte Q140502(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 72803, 0, 0, 0);
            return res;
        }
        public static byte A140502(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140502, 502007, 1, 1, 502);
            return res;
        }
        public static byte Q140503(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 98181, 0, 0, 0);
            return res;
        }
        public static byte A140503(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140503, 502007, 1, 1, 502);
            return res;
        }
        public static byte Q140504(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 127348, 0, 0, 0);
            return res;
        }
        public static byte A140504(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140504, 502007, 1, 1, 502);
            return res;
        }
        public static byte Q140505(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 160303, 0, 0, 0);
            return res;
        }
        public static byte A140505(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140505, 502007, 1, 1, 502);
            return res;
        }
        public static byte Q140506(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 197045, 0, 0, 0);
            return res;
        }
        public static byte A140506(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140506, 502007, 1, 1, 502);
            return res;
        }
        public static byte Q140507(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 237575, 0, 0, 0);
            return res;
        }
        public static byte A140507(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140507, 502007, 1, 1, 502);
            return res;
        }
        public static byte Q140508(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 281893, 0, 0, 0);
            return res;
        }
        public static byte A140508(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140508, 502007, 1, 1, 502);
            return res;
        }
        public static byte Q140509(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140509(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Dempsey about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140509, 502007, 1, 1, 502);
            return res;
        }
        public static byte Q140609(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Toothy Gerbils, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140609(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Toothy Gerbils, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140609, 505001, 2, 0, 505, 50, 505001);
            c.Player.quest.AddPack(140609, 401021, 401);
            return res;
        }
        public static byte Q140610(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Bactrian Camels, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140610(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Bactrian Camels, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140610, 505002, 2, 0, 505, 50, 505002);
            c.Player.quest.AddPack(140610, 401021, 401);
            return res;
        }
        public static byte Q140611(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Rattlesnakes, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140611(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Rattlesnakes, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140611, 505003, 2, 0, 505, 50, 505003);
            c.Player.quest.AddPack(140611, 401021, 401);
            return res;
        }
        public static byte Q140612(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Dire Wolves, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140612(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Dire Wolves, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140612, 505004, 2, 0, 505, 50, 505004);
            c.Player.quest.AddPack(140612, 401021, 401);
            return res;
        }
        public static byte Q140613(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Trade Wind Foxes, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140613(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Trade Wind Foxes, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140613, 505005, 2, 0, 505, 50, 505005);
            c.Player.quest.AddPack(140613, 401021, 401);
            return res;
        }
        public static byte Q140614(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Toxic Scorpions, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140614(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Toxic Scorpions, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140614, 505006, 2, 0, 505, 50, 505006);
            c.Player.quest.AddPack(140614, 401021, 401);
            return res;
        }
        public static byte Q140615(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Sand Fire Lizards, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140615(ConnectionInfo c, int QuestID)
        {
            //Defeat 50 Sand Fire Lizards, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140615, 505007, 2, 0, 505, 50, 505007);
            c.Player.quest.AddPack(140615, 401021, 401);
            return res;
        }
        public static byte Q140616(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darkthorn Cactuses, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140616(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darkthorn Cactuses, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140616, 5010050, 4, 0, 505, 10, 505101);
            c.Player.quest.AddPack(140616, 401021, 401);
            return res;
        }
        public static byte Q140617(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140617(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140617, 5010051, 4, 0, 505, 10, 505102);
            c.Player.quest.AddPack(140617, 401021, 401);
            return res;
        }
        public static byte Q140618(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140618(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140618, 5010052, 4, 0, 505, 10, 505103);
            c.Player.quest.AddPack(140618, 401021, 401);
            return res;
        }
        public static byte Q140619(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darksand Essences, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 87363, 0, 0, 0);
            return res;
        }
        public static byte A140619(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darksand Essences, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140619, 5010053, 4, 0, 505, 10, 505104);
            c.Player.quest.AddPack(140619, 401021, 401);
            return res;
        }
        public static byte Q140622(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Toothy Gerbils, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140622(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Toothy Gerbils, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140622, 505001, 2, 0, 505, 60, 505001);
            c.Player.quest.AddPack(140622, 401021, 401);
            return res;
        }
        public static byte Q140623(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Bactrian Camels, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140623(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Bactrian Camels, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140623, 505002, 2, 0, 505, 60, 505002);
            c.Player.quest.AddPack(140623, 401021, 401);
            return res;
        }
        public static byte Q140624(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Rattlesnakes, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140624(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Rattlesnakes, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140624, 505003, 2, 0, 505, 60, 505003);
            c.Player.quest.AddPack(140624, 401021, 401);
            return res;
        }
        public static byte Q140625(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Dire Wolves, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140625(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Dire Wolves, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140625, 505004, 2, 0, 505, 60, 505004);
            c.Player.quest.AddPack(140625, 401021, 401);
            return res;
        }
        public static byte Q140626(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Trade Wind Foxes, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140626(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Trade Wind Foxes, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140626, 505005, 2, 0, 505, 60, 505005);
            c.Player.quest.AddPack(140626, 401021, 401);
            return res;
        }
        public static byte Q140627(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Toxic Scorpions, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140627(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Toxic Scorpions, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140627, 505006, 2, 0, 505, 60, 505006);
            c.Player.quest.AddPack(140627, 401021, 401);
            return res;
        }
        public static byte Q140628(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Sand Fire Lizards, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140628(ConnectionInfo c, int QuestID)
        {
            //Defeat 60 Sand Fire Lizards, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140628, 505007, 2, 0, 505, 60, 505007);
            c.Player.quest.AddPack(140628, 401021, 401);
            return res;
        }
        public static byte Q140629(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darkthorn Cactuses, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140629(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darkthorn Cactuses, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140629, 5010050, 4, 0, 505, 10, 505101);
            c.Player.quest.AddPack(140629, 401021, 401);
            return res;
        }
        public static byte Q140630(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140630(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140630, 5010051, 4, 0, 505, 10, 505102);
            c.Player.quest.AddPack(140630, 401021, 401);
            return res;
        }
        public static byte Q140631(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140631(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Buckthorn Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140631, 5010052, 4, 0, 505, 10, 505103);
            c.Player.quest.AddPack(140631, 401021, 401);
            return res;
        }
        public static byte Q140632(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darksand Essences, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 117818, 0, 0, 0);
            return res;
        }
        public static byte A140632(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Darksand Essences, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140632, 5010053, 4, 0, 505, 10, 505104);
            c.Player.quest.AddPack(140632, 401021, 401);
            return res;
        }
        public static byte Q140635(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Giant Jaw Ants, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152818, 0, 0, 0);
            return res;
        }
        public static byte A140635(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Giant Jaw Ants, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140635, 507001, 2, 0, 507, 70, 507001);
            c.Player.quest.AddPack(140635, 401021, 401);
            return res;
        }
        public static byte Q140636(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Mud Monsters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152818, 0, 0, 0);
            return res;
        }
        public static byte A140636(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Mud Monsters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140636, 507002, 2, 0, 507, 70, 507002);
            c.Player.quest.AddPack(140636, 401021, 401);
            return res;
        }
        public static byte Q140637(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Man-eating Trees, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152818, 0, 0, 0);
            return res;
        }
        public static byte A140637(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Man-eating Trees, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140637, 507003, 2, 0, 507, 70, 507003);
            c.Player.quest.AddPack(140637, 401021, 401);
            return res;
        }
        public static byte Q140638(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Phantom Monkeys, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152818, 0, 0, 0);
            return res;
        }
        public static byte A140638(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Phantom Monkeys, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140638, 507004, 2, 0, 507, 70, 507004);
            c.Player.quest.AddPack(140638, 401021, 401);
            return res;
        }
        public static byte Q140639(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Wraith Spiders, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152818, 0, 0, 0);
            return res;
        }
        public static byte A140639(ConnectionInfo c, int QuestID)
        {
            //Defeat 70 Wraith Spiders, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140639, 507005, 2, 0, 507, 70, 507005);
            c.Player.quest.AddPack(140639, 401021, 401);
            return res;
        }
        public static byte Q140640(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Delusion Herbs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152818, 0, 0, 0);
            return res;
        }
        public static byte A140640(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Delusion Herbs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140640, 5010055, 4, 0, 507, 10, 507101);
            c.Player.quest.AddPack(140640, 401021, 401);
            return res;
        }
        public static byte Q140641(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Vampire Vines, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152818, 0, 0, 0);
            return res;
        }
        public static byte A140641(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Vampire Vines, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140641, 5010056, 4, 0, 507, 10, 507102);
            c.Player.quest.AddPack(140641, 401021, 401);
            return res;
        }
        public static byte Q140642(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Luminous Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152818, 0, 0, 0);
            return res;
        }
        public static byte A140642(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Luminous Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140642, 5010057, 4, 0, 507, 10, 507103);
            c.Player.quest.AddPack(140642, 401021, 401);
            return res;
        }
        public static byte Q140643(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Water Mana Spars, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 152818, 0, 0, 0);
            return res;
        }
        public static byte A140643(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Water Mana Spars, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140643, 5010058, 4, 0, 507, 10, 507104);
            c.Player.quest.AddPack(140643, 401021, 401);
            return res;
        }
        public static byte Q140646(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Giant Jaw Ants, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 192363, 0, 0, 0);
            return res;
        }
        public static byte A140646(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Giant Jaw Ants, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140646, 507001, 2, 0, 507, 80, 507001);
            c.Player.quest.AddPack(140646, 401021, 401);
            return res;
        }
        public static byte Q140647(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Mud Monsters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 192363, 0, 0, 0);
            return res;
        }
        public static byte A140647(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Mud Monsters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140647, 507002, 2, 0, 507, 80, 507002);
            c.Player.quest.AddPack(140647, 401021, 401);
            return res;
        }
        public static byte Q140648(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Man-eating Trees, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 192363, 0, 0, 0);
            return res;
        }
        public static byte A140648(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Man-eating Trees, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140648, 507003, 2, 0, 507, 80, 507003);
            c.Player.quest.AddPack(140648, 401021, 401);
            return res;
        }
        public static byte Q140649(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Phantom Monkeys, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 192363, 0, 0, 0);
            return res;
        }
        public static byte A140649(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Phantom Monkeys, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140649, 507004, 2, 0, 507, 80, 507004);
            c.Player.quest.AddPack(140649, 401021, 401);
            return res;
        }
        public static byte Q140650(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Wraith Spiders, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 192363, 0, 0, 0);
            return res;
        }
        public static byte A140650(ConnectionInfo c, int QuestID)
        {
            //Defeat 80 Wraith Spiders, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140650, 507005, 2, 0, 507, 80, 507005);
            c.Player.quest.AddPack(140650, 401021, 401);
            return res;
        }
        public static byte Q140651(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Delusion Herbs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 192363, 0, 0, 0);
            return res;
        }
        public static byte A140651(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Delusion Herbs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140651, 5010055, 4, 0, 507, 10, 507101);
            c.Player.quest.AddPack(140651, 401021, 401);
            return res;
        }
        public static byte Q140652(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Vampire Vines, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 192363, 0, 0, 0);
            return res;
        }
        public static byte A140652(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Vampire Vines, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140652, 5010056, 4, 0, 507, 10, 507102);
            c.Player.quest.AddPack(140652, 401021, 401);
            return res;
        }
        public static byte Q140653(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Luminous Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 192363, 0, 0, 0);
            return res;
        }
        public static byte A140653(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Luminous Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140653, 5010057, 4, 0, 507, 10, 507103);
            c.Player.quest.AddPack(140653, 401021, 401);
            return res;
        }
        public static byte Q140654(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Water Mana Spars, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 192363, 0, 0, 0);
            return res;
        }
        public static byte A140654(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Water Mana Spars, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140654, 5010058, 4, 0, 507, 10, 507104);
            c.Player.quest.AddPack(140654, 401021, 401);
            return res;
        }
        public static byte Q140655(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Venom Monsters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 236454, 0, 0, 0);
            return res;
        }
        public static byte A140655(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Venom Monsters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140655, 509001, 2, 0, 509, 90, 509001);
            c.Player.quest.AddPack(140655, 401021, 401);
            return res;
        }
        public static byte Q140656(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 236454, 0, 0, 0);
            return res;
        }
        public static byte A140656(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140656, 509002, 2, 0, 509, 90, 509002);
            c.Player.quest.AddPack(140656, 401021, 401);
            return res;
        }
        public static byte Q140657(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Medusa, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 236454, 0, 0, 0);
            return res;
        }
        public static byte A140657(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Medusa, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140657, 509003, 2, 0, 509, 90, 509003);
            c.Player.quest.AddPack(140657, 401021, 401);
            return res;
        }
        public static byte Q140658(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Mugger Crocodiles, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 236454, 0, 0, 0);
            return res;
        }
        public static byte A140658(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Mugger Crocodiles, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140658, 509004, 2, 0, 509, 90, 509004);
            c.Player.quest.AddPack(140658, 401021, 401);
            return res;
        }
        public static byte Q140659(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Carrions, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 236454, 0, 0, 0);
            return res;
        }
        public static byte A140659(ConnectionInfo c, int QuestID)
        {
            //Defeat 90 Carrions, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140659, 509005, 2, 0, 509, 90, 509005);
            c.Player.quest.AddPack(140659, 401021, 401);
            return res;
        }
        public static byte Q140660(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Fluorescent Herbs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 236454, 0, 0, 0);
            return res;
        }
        public static byte A140660(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Fluorescent Herbs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140660, 5010067, 4, 0, 509, 10, 509101);
            c.Player.quest.AddPack(140660, 401021, 401);
            return res;
        }
        public static byte Q140661(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Rotten Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 236454, 0, 0, 0);
            return res;
        }
        public static byte A140661(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Rotten Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140661, 5010068, 4, 0, 509, 10, 509102);
            c.Player.quest.AddPack(140661, 401021, 401);
            return res;
        }
        public static byte Q140662(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Venom Monsters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140662(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Venom Monsters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140662, 509001, 2, 0, 509, 100, 509001);
            c.Player.quest.AddPack(140662, 401021, 401);
            return res;
        }
        public static byte Q140663(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140663(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140663, 509002, 2, 0, 509, 100, 509002);
            c.Player.quest.AddPack(140663, 401021, 401);
            return res;
        }
        public static byte Q140664(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Medusa, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140664(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Medusa, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140664, 509003, 2, 0, 509, 100, 509003);
            c.Player.quest.AddPack(140664, 401021, 401);
            return res;
        }
        public static byte Q140665(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Mugger Crocodiles, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140665(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Mugger Crocodiles, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140665, 509004, 2, 0, 509, 100, 509004);
            c.Player.quest.AddPack(140665, 401021, 401);
            return res;
        }
        public static byte Q140666(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Carrions, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140666(ConnectionInfo c, int QuestID)
        {
            //Defeat 100 Carrions, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140666, 509005, 2, 0, 509, 100, 509005);
            c.Player.quest.AddPack(140666, 401021, 401);
            return res;
        }
        public static byte Q140667(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Fluorescent Herbs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140667(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Fluorescent Herbs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140667, 5010067, 4, 0, 509, 10, 509101);
            c.Player.quest.AddPack(140667, 401021, 401);
            return res;
        }
        public static byte Q140668(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Rotten Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140668(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Rotten Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140668, 5010068, 4, 0, 509, 10, 509102);
            c.Player.quest.AddPack(140668, 401021, 401);
            return res;
        }
        public static byte Q140669(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Greenbell Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140669(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Greenbell Flowers, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140669, 5010069, 4, 0, 509, 10, 509103);
            c.Player.quest.AddPack(140669, 401021, 401);
            return res;
        }
        public static byte Q140670(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Darkwind Wolves, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 338272, 0, 0, 0);
            return res;
        }
        public static byte A140670(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Darkwind Wolves, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140670, 511001, 2, 0, 511, 110, 511001);
            c.Player.quest.AddPack(140670, 401021, 401);
            return res;
        }
        public static byte Q140671(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Darkwind Hunters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 338272, 0, 0, 0);
            return res;
        }
        public static byte A140671(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Darkwind Hunters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140671, 511003, 2, 0, 511, 110, 511003);
            c.Player.quest.AddPack(140671, 401021, 401);
            return res;
        }
        public static byte Q140672(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Canyon Centaurs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 338272, 0, 0, 0);
            return res;
        }
        public static byte A140672(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Canyon Centaurs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140672, 511005, 2, 0, 511, 110, 511005);
            c.Player.quest.AddPack(140672, 401021, 401);
            return res;
        }
        public static byte Q140673(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Stone Lizards, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 338272, 0, 0, 0);
            return res;
        }
        public static byte A140673(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Stone Lizards, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140673, 511004, 2, 0, 511, 110, 511004);
            c.Player.quest.AddPack(140673, 401021, 401);
            return res;
        }
        public static byte Q140674(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Canyon Eagles, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 338272, 0, 0, 0);
            return res;
        }
        public static byte A140674(ConnectionInfo c, int QuestID)
        {
            //Defeat 110 Canyon Eagles, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140674, 511002, 2, 0, 511, 110, 511002);
            c.Player.quest.AddPack(140674, 401021, 401);
            return res;
        }
        public static byte Q140675(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Cruor Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 338272, 0, 0, 0);
            return res;
        }
        public static byte A140675(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Cruor Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140675, 5010070, 4, 0, 511, 10, 511101);
            c.Player.quest.AddPack(140675, 401021, 401);
            return res;
        }
        public static byte Q140676(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Hyacinths, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 338272, 0, 0, 0);
            return res;
        }
        public static byte A140676(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Hyacinths, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140676, 5010071, 4, 0, 511, 10, 511102);
            c.Player.quest.AddPack(140676, 401021, 401);
            return res;
        }
        public static byte Q140677(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Darkwind Wolves, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140677(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Darkwind Wolves, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140677, 511001, 2, 0, 511, 120, 511001);
            c.Player.quest.AddPack(140677, 401021, 401);
            return res;
        }
        public static byte Q140678(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Darkwind Hunters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140678(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Darkwind Hunters, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140678, 511003, 2, 0, 511, 120, 511003);
            c.Player.quest.AddPack(140678, 401021, 401);
            return res;
        }
        public static byte Q140679(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Canyon Centaurs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140679(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Canyon Centaurs, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140679, 511005, 2, 0, 511, 120, 511005);
            c.Player.quest.AddPack(140679, 401021, 401);
            return res;
        }
        public static byte Q140680(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Stone Lizards, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140680(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Stone Lizards, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140680, 511004, 2, 0, 511, 120, 511004);
            c.Player.quest.AddPack(140680, 401021, 401);
            return res;
        }
        public static byte Q140681(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Canyon Eagles, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140681(ConnectionInfo c, int QuestID)
        {
            //Defeat 120 Canyon Eagles, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140681, 511002, 2, 0, 511, 120, 511002);
            c.Player.quest.AddPack(140681, 401021, 401);
            return res;
        }
        public static byte Q140682(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Cruor Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140682(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Cruor Grasses, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140682, 5010070, 4, 0, 511, 10, 511101);
            c.Player.quest.AddPack(140682, 401021, 401);
            return res;
        }
        public static byte Q140683(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Hyacinths, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140683(ConnectionInfo c, int QuestID)
        {
            //Collect 10 Hyacinths, then go to City of Rage, ask Cliff about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140683, 5010071, 4, 0, 511, 10, 511102);
            c.Player.quest.AddPack(140683, 401021, 401);
            return res;
        }
        public static byte Q140706(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 101924, 0, 0, 0);
            return res;
        }
        public static byte A140706(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140706, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140707(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 101924, 0, 0, 0);
            return res;
        }
        public static byte A140707(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140707, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140708(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 101924, 0, 0, 0);
            return res;
        }
        public static byte A140708(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140708, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140709(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 101924, 0, 0, 0);
            return res;
        }
        public static byte A140709(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140709, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140711(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 137454, 0, 0, 0);
            return res;
        }
        public static byte A140711(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140711, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140712(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 137454, 0, 0, 0);
            return res;
        }
        public static byte A140712(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140712, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140713(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 137454, 0, 0, 0);
            return res;
        }
        public static byte A140713(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140713, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140714(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 137454, 0, 0, 0);
            return res;
        }
        public static byte A140714(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140714, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140716(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 178287, 0, 0, 0);
            return res;
        }
        public static byte A140716(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140716, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140717(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 178287, 0, 0, 0);
            return res;
        }
        public static byte A140717(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140717, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140718(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 178287, 0, 0, 0);
            return res;
        }
        public static byte A140718(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140718, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140719(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 178287, 0, 0, 0);
            return res;
        }
        public static byte A140719(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140719, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140721(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 224424, 0, 0, 0);
            return res;
        }
        public static byte A140721(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140721, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140722(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 224424, 0, 0, 0);
            return res;
        }
        public static byte A140722(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140722, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140723(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 224424, 0, 0, 0);
            return res;
        }
        public static byte A140723(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140723, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140724(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 224424, 0, 0, 0);
            return res;
        }
        public static byte A140724(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140724, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140725(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 275863, 0, 0, 0);
            return res;
        }
        public static byte A140725(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140725, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140726(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 275863, 0, 0, 0);
            return res;
        }
        public static byte A140726(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140726, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140727(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 275863, 0, 0, 0);
            return res;
        }
        public static byte A140727(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140727, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140728(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 275863, 0, 0, 0);
            return res;
        }
        public static byte A140728(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140728, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140729(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 332606, 0, 0, 0);
            return res;
        }
        public static byte A140729(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140729, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140730(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 332606, 0, 0, 0);
            return res;
        }
        public static byte A140730(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140730, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140731(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 332606, 0, 0, 0);
            return res;
        }
        public static byte A140731(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140731, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140732(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 332606, 0, 0, 0);
            return res;
        }
        public static byte A140732(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140732, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140733(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 394651, 0, 0, 0);
            return res;
        }
        public static byte A140733(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140733, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140734(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 394651, 0, 0, 0);
            return res;
        }
        public static byte A140734(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140734, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140735(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 394651, 0, 0, 0);
            return res;
        }
        public static byte A140735(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140735, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140736(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 394651, 0, 0, 0);
            return res;
        }
        public static byte A140736(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140736, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140737(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140737(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140737, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140738(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140738(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140738, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140739(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140739(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140739, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140740(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140740(ConnectionInfo c, int QuestID)
        {
            //Ask Kon about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140740, 301023, 1, 1, 301);
            return res;
        }
        public static byte Q140806(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 116484, 0, 0, 0);
            return res;
        }
        public static byte A140806(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140806, 201015, 1, 1, 201);
            return res;
        }
        public static byte Q140807(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 116484, 0, 0, 0);
            return res;
        }
        public static byte A140807(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140807, 401002, 1, 1, 401);
            return res;
        }
        public static byte Q140808(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 116484, 0, 0, 0);
            return res;
        }
        public static byte A140808(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140808, 301017, 1, 1, 301);
            return res;
        }
        public static byte Q140809(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 116484, 0, 0, 0);
            return res;
        }
        public static byte A140809(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140809, 502026, 1, 1, 502);
            return res;
        }
        public static byte Q140811(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140811(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140811, 201015, 1, 1, 201);
            return res;
        }
        public static byte Q140812(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140812(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140812, 401002, 1, 1, 401);
            return res;
        }
        public static byte Q140813(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140813(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140813, 301017, 1, 1, 301);
            return res;
        }
        public static byte Q140814(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140814(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140814, 502026, 1, 1, 502);
            return res;
        }
        public static byte Q140816(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 203757, 0, 0, 0);
            return res;
        }
        public static byte A140816(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140816, 201015, 1, 1, 201);
            return res;
        }
        public static byte Q140817(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 203757, 0, 0, 0);
            return res;
        }
        public static byte A140817(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140817, 401002, 1, 1, 401);
            return res;
        }
        public static byte Q140818(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 203757, 0, 0, 0);
            return res;
        }
        public static byte A140818(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140818, 301017, 1, 1, 301);
            return res;
        }
        public static byte Q140819(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 203757, 0, 0, 0);
            return res;
        }
        public static byte A140819(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140819, 502026, 1, 1, 502);
            return res;
        }
        public static byte Q140821(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 256484, 0, 0, 0);
            return res;
        }
        public static byte A140821(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140821, 201015, 1, 1, 201);
            return res;
        }
        public static byte Q140822(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 256484, 0, 0, 0);
            return res;
        }
        public static byte A140822(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140822, 401002, 1, 1, 401);
            return res;
        }
        public static byte Q140823(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 256484, 0, 0, 0);
            return res;
        }
        public static byte A140823(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140823, 301017, 1, 1, 301);
            return res;
        }
        public static byte Q140824(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 256484, 0, 0, 0);
            return res;
        }
        public static byte A140824(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140824, 502026, 1, 1, 502);
            return res;
        }
        public static byte Q140825(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 315272, 0, 0, 0);
            return res;
        }
        public static byte A140825(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140825, 201015, 1, 1, 201);
            return res;
        }
        public static byte Q140826(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 315272, 0, 0, 0);
            return res;
        }
        public static byte A140826(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140826, 401002, 1, 1, 401);
            return res;
        }
        public static byte Q140827(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 315272, 0, 0, 0);
            return res;
        }
        public static byte A140827(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140827, 301017, 1, 1, 301);
            return res;
        }
        public static byte Q140828(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 315272, 0, 0, 0);
            return res;
        }
        public static byte A140828(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140828, 502026, 1, 1, 502);
            return res;
        }
        public static byte Q140829(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 380121, 0, 0, 0);
            return res;
        }
        public static byte A140829(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140829, 201015, 1, 1, 201);
            return res;
        }
        public static byte Q140830(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 380121, 0, 0, 0);
            return res;
        }
        public static byte A140830(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140830, 401002, 1, 1, 401);
            return res;
        }
        public static byte Q140831(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 380121, 0, 0, 0);
            return res;
        }
        public static byte A140831(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140831, 301017, 1, 1, 301);
            return res;
        }
        public static byte Q140832(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 380121, 0, 0, 0);
            return res;
        }
        public static byte A140832(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140832, 502026, 1, 1, 502);
            return res;
        }
        public static byte Q140833(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140833(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140833, 201015, 1, 1, 201);
            return res;
        }
        public static byte Q140834(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140834(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140834, 401002, 1, 1, 401);
            return res;
        }
        public static byte Q140835(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140835(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140835, 301017, 1, 1, 301);
            return res;
        }
        public static byte Q140836(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140836(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140836, 502026, 1, 1, 502);
            return res;
        }
        public static byte Q140837(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140837(ConnectionInfo c, int QuestID)
        {
            //Go to City of Trees, ask Nana about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140837, 201015, 1, 1, 201);
            return res;
        }
        public static byte Q140838(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140838(ConnectionInfo c, int QuestID)
        {
            //Go to City of Rage, ask Amelia about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140838, 401002, 1, 1, 401);
            return res;
        }
        public static byte Q140839(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140839(ConnectionInfo c, int QuestID)
        {
            //Go to Glory City, ask Minny about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140839, 301017, 1, 1, 301);
            return res;
        }
        public static byte Q140840(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140840(ConnectionInfo c, int QuestID)
        {
            //Go to City of Genesis, ask Eugene about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140840, 502026, 1, 1, 502);
            return res;
        }
        public static byte Q140903(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Swantony, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 131045, 0, 0, 0);
            return res;
        }
        public static byte A140903(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Swantony, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140903, 505008, 2, 0, 505, 15, 505008);
            c.Player.quest.AddPack(140903, 401015, 401);
            return res;
        }
        public static byte Q140904(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Benson, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 131045, 0, 0, 0);
            return res;
        }
        public static byte A140904(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Benson, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140904, 505009, 2, 0, 505, 15, 505009);
            c.Player.quest.AddPack(140904, 401015, 401);
            return res;
        }
        public static byte Q140905(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Swantony, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 176727, 0, 0, 0);
            return res;
        }
        public static byte A140905(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Swantony, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140905, 505008, 2, 0, 505, 15, 505008);
            c.Player.quest.AddPack(140905, 401015, 401);
            return res;
        }
        public static byte Q140906(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Benson, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 176727, 0, 0, 0);
            return res;
        }
        public static byte A140906(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Benson, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140906, 505009, 2, 0, 505, 15, 505009);
            c.Player.quest.AddPack(140906, 401015, 401);
            return res;
        }
        public static byte Q140907(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Baird, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 229227, 0, 0, 0);
            return res;
        }
        public static byte A140907(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Baird, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140907, 507006, 2, 0, 507, 15, 507006);
            c.Player.quest.AddPack(140907, 401015, 401);
            return res;
        }
        public static byte Q140908(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Archer, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 229227, 0, 0, 0);
            return res;
        }
        public static byte A140908(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Archer, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140908, 507007, 2, 0, 507, 15, 507007);
            c.Player.quest.AddPack(140908, 401015, 401);
            return res;
        }
        public static byte Q140909(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Baird, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 288545, 0, 0, 0);
            return res;
        }
        public static byte A140909(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Baird, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140909, 507006, 2, 0, 507, 15, 507006);
            c.Player.quest.AddPack(140909, 401015, 401);
            return res;
        }
        public static byte Q140910(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Archer, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 288545, 0, 0, 0);
            return res;
        }
        public static byte A140910(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Archer, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140910, 507007, 2, 0, 507, 15, 507007);
            c.Player.quest.AddPack(140910, 401015, 401);
            return res;
        }
        public static byte Q140911(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Olive, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 354681, 0, 0, 0);
            return res;
        }
        public static byte A140911(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Olive, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140911, 509006, 2, 0, 509, 15, 509006);
            c.Player.quest.AddPack(140911, 401015, 401);
            return res;
        }
        public static byte Q140912(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Giant Carrion, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 354681, 0, 0, 0);
            return res;
        }
        public static byte A140912(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Giant Carrion, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140912, 509007, 2, 0, 509, 15, 509007);
            c.Player.quest.AddPack(140912, 401015, 401);
            return res;
        }
        public static byte Q140913(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Olive, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 427636, 0, 0, 0);
            return res;
        }
        public static byte A140913(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Olive, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140913, 509006, 2, 0, 509, 15, 509006);
            c.Player.quest.AddPack(140913, 401015, 401);
            return res;
        }
        public static byte Q140914(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Giant Carrion, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 427636, 0, 0, 0);
            return res;
        }
        public static byte A140914(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Giant Carrion, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140914, 509007, 2, 0, 509, 15, 509007);
            c.Player.quest.AddPack(140914, 401015, 401);
            return res;
        }
        public static byte Q140915(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Shadow Assassins, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 507409, 0, 0, 0);
            return res;
        }
        public static byte A140915(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Shadow Assassins, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140915, 511007, 2, 0, 511, 15, 511007);
            c.Player.quest.AddPack(140915, 401015, 401);
            return res;
        }
        public static byte Q140916(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Head Centaurs, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 507409, 0, 0, 0);
            return res;
        }
        public static byte A140916(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Head Centaurs, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140916, 511006, 2, 0, 511, 15, 511006);
            c.Player.quest.AddPack(140916, 401015, 401);
            return res;
        }
        public static byte Q140917(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Shadow Assassins, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140917(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Shadow Assassins, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140917, 511007, 2, 0, 511, 15, 511007);
            c.Player.quest.AddPack(140917, 401015, 401);
            return res;
        }
        public static byte Q140918(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Head Centaurs, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A140918(ConnectionInfo c, int QuestID)
        {
            //Defeat 15 Head Centaurs, then go to City of Rage, ask Marie about the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(140918, 511006, 2, 0, 511, 15, 511006);
            c.Player.quest.AddPack(140918, 401015, 401);
            return res;
        }
        public static byte Q141002(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 145606, 0, 0, 0);
            return res;
        }
        public static byte A141002(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(141002, 502028, 1, 1, 502);
            return res;
        }
        public static byte Q141003(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 196363, 0, 0, 0);
            return res;
        }
        public static byte A141003(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(141003, 502028, 1, 1, 502);
            return res;
        }
        public static byte Q141004(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 254696, 0, 0, 0);
            return res;
        }
        public static byte A141004(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(141004, 502028, 1, 1, 502);
            return res;
        }
        public static byte Q141005(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 320606, 0, 0, 0);
            return res;
        }
        public static byte A141005(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(141005, 502028, 1, 1, 502);
            return res;
        }
        public static byte Q141006(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A141006(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(141006, 502028, 1, 1, 502);
            return res;
        }
        public static byte Q141007(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 475151, 0, 0, 0);
            return res;
        }
        public static byte A141007(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(141007, 502028, 1, 1, 502);
            return res;
        }
        public static byte Q141008(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 563787, 0, 0, 0);
            return res;
        }
        public static byte A141008(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(141008, 502028, 1, 1, 502);
            return res;
        }
        public static byte Q141009(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A141009(ConnectionInfo c, int QuestID)
        {
            //Find Doreen and tell her that you\'ve known the origin of the world.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(141009, 502028, 1, 1, 502);
            return res;
        }
        public static byte Q150001(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*20 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 20835, 0, 0, 0);
            return res;
        }
        public static byte A150001(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*20 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150001, 503999, 2, 0, 504, 20, 503999);
            c.Player.quest.AddPack(150001, 503003, 504);
            return res;
        }
        public static byte Q150002(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*40 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150002(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*40 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150002, 503999, 2, 0, 504, 40, 503999);
            c.Player.quest.AddPack(150002, 503003, 504);
            return res;
        }
        public static byte Q150003(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*60 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150003(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*60 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150003, 503999, 2, 0, 504, 60, 503999);
            c.Player.quest.AddPack(150003, 503003, 504);
            return res;
        }
        public static byte Q150004(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*80 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 83335, 0, 0, 0);
            return res;
        }
        public static byte A150004(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*80 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150004, 503999, 2, 0, 504, 80, 503999);
            c.Player.quest.AddPack(150004, 503003, 504);
            return res;
        }
        public static byte Q150005(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150005(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 at Lune Oasis.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150005, 503999, 2, 0, 504, 100, 503999);
            c.Player.quest.AddPack(150005, 503003, 504);
            return res;
        }
        public static byte Q150006(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*30 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150006(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*30 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150006, 504999, 2, 0, 505, 30, 504999);
            c.Player.quest.AddPack(150006, 505001, 505);
            return res;
        }
        public static byte Q150007(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*60 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150007(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*60 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150007, 504999, 2, 0, 505, 60, 504999);
            c.Player.quest.AddPack(150007, 505001, 505);
            return res;
        }
        public static byte Q150008(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*90 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150008(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*90 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150008, 504999, 2, 0, 505, 90, 504999);
            c.Player.quest.AddPack(150008, 505001, 505);
            return res;
        }
        public static byte Q150009(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*120 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150009(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*120 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150009, 504999, 2, 0, 505, 120, 504999);
            c.Player.quest.AddPack(150009, 505001, 505);
            return res;
        }
        public static byte Q150010(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, any monster*150 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150010(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, any monster*150 at Darksand.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150010, 504999, 2, 0, 505, 150, 504999);
            c.Player.quest.AddPack(150010, 505001, 505);
            return res;
        }
        public static byte Q150011(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 53335, 0, 0, 0);
            return res;
        }
        public static byte A150011(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150011, 506999, 2, 0, 507, 50, 506999);
            c.Player.quest.AddPack(150011, 507003, 507);
            return res;
        }
        public static byte Q150012(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150012(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150012, 506999, 2, 0, 507, 100, 506999);
            c.Player.quest.AddPack(150012, 507003, 507);
            return res;
        }
        public static byte Q150013(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150013(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150013, 506999, 2, 0, 507, 150, 506999);
            c.Player.quest.AddPack(150013, 507003, 507);
            return res;
        }
        public static byte Q150014(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 213335, 0, 0, 0);
            return res;
        }
        public static byte A150014(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150014, 506999, 2, 0, 507, 200, 506999);
            c.Player.quest.AddPack(150014, 507003, 507);
            return res;
        }
        public static byte Q150015(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150015(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150015, 506999, 2, 0, 507, 250, 506999);
            c.Player.quest.AddPack(150015, 507003, 507);
            return res;
        }
        public static byte Q150016(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 83335, 0, 0, 0);
            return res;
        }
        public static byte A150016(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150016, 507999, 2, 0, 509, 50, 507999);
            c.Player.quest.AddPack(150016, 509004, 509);
            return res;
        }
        public static byte Q150017(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order,kill any monster*100 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150017(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order,kill any monster*100 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150017, 507999, 2, 0, 509, 100, 507999);
            c.Player.quest.AddPack(150017, 509004, 509);
            return res;
        }
        public static byte Q150018(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150018(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150018, 507999, 2, 0, 509, 150, 507999);
            c.Player.quest.AddPack(150018, 509004, 509);
            return res;
        }
        public static byte Q150019(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 333335, 0, 0, 0);
            return res;
        }
        public static byte A150019(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150019, 507999, 2, 0, 509, 200, 507999);
            c.Player.quest.AddPack(150019, 509004, 509);
            return res;
        }
        public static byte Q150020(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150020(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150020, 507999, 2, 0, 509, 250, 507999);
            c.Player.quest.AddPack(150020, 509004, 509);
            return res;
        }
        public static byte Q150021(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150021(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150021, 508999, 2, 0, 511, 50, 508999);
            c.Player.quest.AddPack(150021, 511001, 511);
            return res;
        }
        public static byte Q150022(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150022(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150022, 508999, 2, 0, 511, 100, 508999);
            c.Player.quest.AddPack(150022, 511001, 511);
            return res;
        }
        public static byte Q150023(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150023(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150023, 508999, 2, 0, 511, 150, 508999);
            c.Player.quest.AddPack(150023, 511001, 511);
            return res;
        }
        public static byte Q150024(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150024(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150024, 508999, 2, 0, 511, 200, 508999);
            c.Player.quest.AddPack(150024, 511001, 511);
            return res;
        }
        public static byte Q150025(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150025(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150025, 508999, 2, 0, 511, 250, 508999);
            c.Player.quest.AddPack(150025, 511001, 511);
            return res;
        }
        public static byte Q150026(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 163333, 0, 0, 0);
            return res;
        }
        public static byte A150026(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150026, 509999, 2, 0, 513, 50, 509999);
            c.Player.quest.AddPack(150026, 513003, 513);
            return res;
        }
        public static byte Q150027(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 326667, 0, 0, 0);
            return res;
        }
        public static byte A150027(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150027, 509999, 2, 0, 513, 100, 509999);
            c.Player.quest.AddPack(150027, 513003, 513);
            return res;
        }
        public static byte Q150028(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150028(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150028, 509999, 2, 0, 513, 150, 509999);
            c.Player.quest.AddPack(150028, 513003, 513);
            return res;
        }
        public static byte Q150029(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 653333, 0, 0, 0);
            return res;
        }
        public static byte A150029(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150029, 509999, 2, 0, 513, 200, 509999);
            c.Player.quest.AddPack(150029, 513003, 513);
            return res;
        }
        public static byte Q150030(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 816667, 0, 0, 0);
            return res;
        }
        public static byte A150030(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150030, 509999, 2, 0, 513, 250, 509999);
            c.Player.quest.AddPack(150030, 513003, 513);
            return res;
        }
        public static byte Q150031(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, any monster*300 at Darksand Land.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150031(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, any monster*300 at Darksand Land.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150031, 504999, 2, 0, 505, 300, 504999);
            c.Player.quest.AddPack(150031, 505001, 505);
            return res;
        }
        public static byte Q150032(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150032(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 in Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150032, 506999, 2, 0, 507, 500, 506999);
            c.Player.quest.AddPack(150032, 507003, 507);
            return res;
        }
        public static byte Q150033(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150033(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 in Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150033, 507999, 2, 0, 509, 500, 507999);
            c.Player.quest.AddPack(150033, 509004, 509);
            return res;
        }
        public static byte Q150034(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150034(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 in Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150034, 508999, 2, 0, 511, 500, 508999);
            c.Player.quest.AddPack(150034, 511001, 511);
            return res;
        }
        public static byte Q150035(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1633334, 0, 0, 0);
            return res;
        }
        public static byte A150035(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 in Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150035, 509999, 2, 0, 513, 500, 509999);
            c.Player.quest.AddPack(150035, 513003, 513);
            return res;
        }
        public static byte Q150036(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Darksand Essences from Darksand Land.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 0, 50000, 0, 0);
            return res;
        }
        public static byte A150036(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Darksand Essences from Darksand Land.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150036, 5010053, 4, 0, 505, 20, 505104);
            c.Player.quest.AddPack(150036, 505001, 505);
            return res;
        }
        public static byte Q150037(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Water Mana Spars from Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 0, 50000, 0, 0);
            return res;
        }
        public static byte A150037(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Water Mana Spars from Vine Rainforest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150037, 5010058, 4, 0, 507, 20, 507104);
            c.Player.quest.AddPack(150037, 507003, 507);
            return res;
        }
        public static byte Q150038(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Greenbell Flowers from Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 0, 50000, 0, 0);
            return res;
        }
        public static byte A150038(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Greenbell Flowers from Redcloud Marsh.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150038, 5010069, 4, 0, 509, 20, 509103);
            c.Player.quest.AddPack(150038, 509004, 509);
            return res;
        }
        public static byte Q150039(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Hyacinths from Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 0, 100000, 0, 0);
            return res;
        }
        public static byte A150039(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Hyacinths from Darkwind Canyon.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150039, 5010071, 4, 0, 511, 20, 511102);
            c.Player.quest.AddPack(150039, 511001, 511);
            return res;
        }
        public static byte Q150040(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Hyacinths from Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 0, 100000, 0, 0);
            return res;
        }
        public static byte A150040(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Hyacinths from Foggy Forest.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150040, 5010073, 4, 0, 513, 20, 513102);
            c.Player.quest.AddPack(150040, 513003, 513);
            return res;
        }
        public static byte Q150041(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 213333, 0, 0, 0);
            return res;
        }
        public static byte A150041(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*50 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150041, 510999, 2, 0, 515, 50, 510999);
            c.Player.quest.AddPack(150041, 515003, 515);
            return res;
        }
        public static byte Q150042(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 426667, 0, 0, 0);
            return res;
        }
        public static byte A150042(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*100 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150042, 510999, 2, 0, 515, 100, 510999);
            c.Player.quest.AddPack(150042, 515003, 515);
            return res;
        }
        public static byte Q150043(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            return res;
        }
        public static byte A150043(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*150 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150043, 510999, 2, 0, 515, 150, 510999);
            c.Player.quest.AddPack(150043, 515003, 515);
            return res;
        }
        public static byte Q150044(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 853333, 0, 0, 0);
            return res;
        }
        public static byte A150044(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*200 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150044, 510999, 2, 0, 515, 200, 510999);
            c.Player.quest.AddPack(150044, 515003, 515);
            return res;
        }
        public static byte Q150045(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 1066667, 0, 0, 0);
            return res;
        }
        public static byte A150045(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*250 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150045, 510999, 2, 0, 515, 250, 510999);
            c.Player.quest.AddPack(150045, 515003, 515);
            return res;
        }
        public static byte Q150046(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 2133334, 0, 0, 0);
            return res;
        }
        public static byte A150046(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, kill any monster*500 at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150046, 510999, 2, 0, 515, 500, 510999);
            c.Player.quest.AddPack(150046, 515003, 515);
            return res;
        }
        public static byte Q150047(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Despair Herbs at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;

            Tasks.AddQuestFinance(c, 0, 150000, 0, 0);
            return res;
        }
        public static byte A150047(ConnectionInfo c, int QuestID)
        {
            //Accept Zodiac Temple\'s order, collect 20 Despair Herbs at Henan Mountainside.
            if (QuestCommand.CanQuest(c, 200)) return 3;
            byte res = 1;


            c.Player.quest.AddTaskComplete(150047, 5010074, 4, 0, 515, 20, 515101);
            c.Player.quest.AddPack(150047, 515003, 515);
            return res;
        }
    }
}
