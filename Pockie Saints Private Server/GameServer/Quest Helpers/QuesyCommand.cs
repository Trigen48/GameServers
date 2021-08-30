using System;
using System.Collections.Generic;

namespace GameServer
{
	internal static class QuestCommand
	{
		internal static bool CanQuest(ConnectionInfo c, byte req_level)
		{
			return Players.players[c.rlid].charz.level < req_level;
		}

		internal static byte Parse(ConnectionInfo c,int QuestID)
		{
			switch(QuestID)
			{
				case 100001:
					//Ask Star Sage Halmir what to do next.
					if(CanQuest(c,1)) break;
					return QuestCode.Q100001(c,QuestID);
				case 100002:
					//Find Star Protector Stone, get a gift box from him.
					if(CanQuest(c,2)) break;
					return QuestCode.Q100002(c,QuestID);
				case 100003:
					//Equip weapon, then go to see Star Warrior Sophie.
					if(CanQuest(c,3)) break;
					return QuestCode.Q100003(c,QuestID);
				case 100005:
					//Learn skill, then look for Zodiac Instructor Darcy.
					if(CanQuest(c,4)) break;
					return QuestCode.Q100005(c,QuestID);
				case 100007:
					//Ask Virgo Kerry for a cloth.
					if(CanQuest(c,5)) break;
					return QuestCode.Q100007(c,QuestID);
				case 100009:
					//Find Zodiac Priest Moville outside of Zodiac Academy and finish his requirement.
					if(CanQuest(c,5)) break;
					return QuestCode.Q100009(c,QuestID);
				case 100010:
					//Kill Beedas at the outside of Zodiac Academy and then report to Zodiac Priest Moville.
					if(CanQuest(c,6)) break;
					return QuestCode.Q100010(c,QuestID);
				case 100012:
					//Ask Zodiac Priest Lily for the opportunity of getting next proof.
					if(CanQuest(c,7)) break;
					return QuestCode.Q100012(c,QuestID);
				case 100013:
					//Kill 1 Vampire Bat outside of Zodiac Academy and then report to Zodiac Priest Lily.
					if(CanQuest(c,7)) break;
					return QuestCode.Q100013(c,QuestID);
				case 100014:
					//Kill 1 Hiram outside of Zodiac Academy and then report to Zodiac Priest Lily.
					if(CanQuest(c,7)) break;
					return QuestCode.Q100014(c,QuestID);
				case 100015:
					//Get the last proof from Zodiac Officiant Roger, and match constellations.
					if(CanQuest(c,8)) break;
					return QuestCode.Q100015(c,QuestID);
				case 100016:
					//Kill 1 Treant outside of Zodiac Academy, then report to Zodiac Officiant Roger.
					if(CanQuest(c,8)) break;
					return QuestCode.Q100016(c,QuestID);
				case 100017:
					//Learn new skill with the guidance of Zodiac Instructor Barral.
					if(CanQuest(c,8)) break;
					return QuestCode.Q100017(c,QuestID);
				case 100020:
					//Ask Star Warlock Ekland to activate the Zodiac Medal.
					if(CanQuest(c,9)) break;
					return QuestCode.Q100020(c,QuestID);
				case 100023:
					//Go go Empire Capital, Contact Oracle.
					if(CanQuest(c,10)) break;
					return QuestCode.Q100023(c,QuestID);
				case 100024:
					//Go go Empire Capital, Contact Oracle.
					if(CanQuest(c,10)) break;
					return QuestCode.Q100024(c,QuestID);
				case 100025:
					//Go go Empire Capital, Contact Oracle.
					if(CanQuest(c,10)) break;
					return QuestCode.Q100025(c,QuestID);
				case 100026:
					//Choose a faction.
					if(CanQuest(c,10)) break;
					return QuestCode.Q100026(c,QuestID);
				case 110016:
					//Collect 1 Aquamarine Grass from Sunshine Cliff and give it to Allen.
					if(CanQuest(c,14)) break;
					return QuestCode.Q110016(c,QuestID);
				case 110017:
					//Ask Cecil about how to clean the bloodstain on the secret letter.
					if(CanQuest(c,14)) break;
					return QuestCode.Q110017(c,QuestID);
				case 110020:
					//Tekk Allen the method of cleaning bloodstain.
					if(CanQuest(c,15)) break;
					return QuestCode.Q110020(c,QuestID);
				case 110021:
					//Kill 4 Gold Wire Snakes at Sunshine Cliff, collect their venom and bring it back to Allen.
					if(CanQuest(c,15)) break;
					return QuestCode.Q110021(c,QuestID);
				case 110022:
					//Contact Bernice and do whatever she tells you.
					if(CanQuest(c,15)) break;
					return QuestCode.Q110022(c,QuestID);
				case 110024:
					//Kill 4 Troll Spiders at Sunshine Cliff, clear the way to Emma.
					if(CanQuest(c,16)) break;
					return QuestCode.Q110024(c,QuestID);
				case 110025:
					//Contact Sunshine Cliff\'s Emma.
					if(CanQuest(c,16)) break;
					return QuestCode.Q110025(c,QuestID);
				case 110027:
					//Collect 1 Mandela Tulip at Sunshine Cliff and give it to Emma.
					if(CanQuest(c,16)) break;
					return QuestCode.Q110027(c,QuestID);
				case 110028:
					//Tell Bernice the identity of the victim who\'s confirmed by Emma.
					if(CanQuest(c,16)) break;
					return QuestCode.Q110028(c,QuestID);
				case 110029:
					//Contact Sunshine Cliff\'s Barlow.
					if(CanQuest(c,17)) break;
					return QuestCode.Q110029(c,QuestID);
				case 110030:
					//Capture 4 Forest Bears at Sunshine Cliff, bring them back to Barlow.
					if(CanQuest(c,17)) break;
					return QuestCode.Q110030(c,QuestID);
				case 110032:
					//Collect 1 Phosphate Rock from Sunshine Cliff, bring it back to Barlow to make Phosphate Powder.
					if(CanQuest(c,17)) break;
					return QuestCode.Q110032(c,QuestID);
				case 110033:
					//Go to Sunshine Cliff, contact Janet.
					if(CanQuest(c,17)) break;
					return QuestCode.Q110033(c,QuestID);
				case 110035:
					//Collect 1 Death Flower from Sunshine Cliff and give it to Janet.
					if(CanQuest(c,18)) break;
					return QuestCode.Q110035(c,QuestID);
				case 110036:
					//Visit awakening Donald.
					if(CanQuest(c,18)) break;
					return QuestCode.Q110036(c,QuestID);
				case 110038:
					//Capture 4 Thunderhawk from Sunshine Cliff, bring them back to Donald.
					if(CanQuest(c,18)) break;
					return QuestCode.Q110038(c,QuestID);
				case 110039:
					//Ask Janet to help you extract information from Thunderhawk\'s eyes.
					if(CanQuest(c,19)) break;
					return QuestCode.Q110039(c,QuestID);
				case 110040:
					//Tell Donald the analysis made by Janet, let him make the final decision.
					if(CanQuest(c,19)) break;
					return QuestCode.Q110040(c,QuestID);
				case 110041:
					//Defeat Alva at Sunshine Cliff and report to Donald.
					if(CanQuest(c,19)) break;
					return QuestCode.Q110041(c,QuestID);
				case 110045:
					//Ask Edith about the information collected.
					if(CanQuest(c,21)) break;
					return QuestCode.Q110045(c,QuestID);
				case 110048:
					//Capture 5 Rubble Rat in Rubble Wasteland, bring them back to Edith.
					if(CanQuest(c,21)) break;
					return QuestCode.Q110048(c,QuestID);
				case 110049:
					//Bring the paper and ask Herbert what information he has gathered.
					if(CanQuest(c,22)) break;
					return QuestCode.Q110049(c,QuestID);
				case 110050:
					//Ask Joshua for the other half o the information.
					if(CanQuest(c,22)) break;
					return QuestCode.Q110050(c,QuestID);
				case 110051:
					//Tell Edith the information collected by Herbert and Joshua.
					if(CanQuest(c,22)) break;
					return QuestCode.Q110051(c,QuestID);
				case 110058:
					//Ask Leonard for the information he has gathered.
					if(CanQuest(c,22)) break;
					return QuestCode.Q110058(c,QuestID);
				case 110059:
					//Capture 8 Mottle Snakes in Rubble Wasteland and bring them back to Leonard.
					if(CanQuest(c,22)) break;
					return QuestCode.Q110059(c,QuestID);
				case 110060:
					//Ask Moore for the other half of the information.
					if(CanQuest(c,23)) break;
					return QuestCode.Q110060(c,QuestID);
				case 110061:
					//Listen to Moore tell how he lost the information.
					if(CanQuest(c,23)) break;
					return QuestCode.Q110061(c,QuestID);
				case 110062:
					//Catch Erica in Rubble Wasteland, get the lost half of information and take it to Moore.
					if(CanQuest(c,23)) break;
					return QuestCode.Q110062(c,QuestID);
				case 110063:
					//Bring the information collected by Leonard and Moore to Edith.
					if(CanQuest(c,23)) break;
					return QuestCode.Q110063(c,QuestID);
				case 110064:
					//Find Jason in Lune Oasis, tell him Edith\'s instructions.
					if(CanQuest(c,25)) break;
					return QuestCode.Q110064(c,QuestID);
				case 110089:
					//Contact Lune Oasis\'s Aldrich.
					if(CanQuest(c,30)) break;
					return QuestCode.Q110089(c,QuestID);
				case 110090:
					//Find Andy according to Aldrich\'s instruction, follow Andy\'s instruction.
					if(CanQuest(c,30)) break;
					return QuestCode.Q110090(c,QuestID);
				case 110091:
					//Ask Benedict for the investigation report.
					if(CanQuest(c,30)) break;
					return QuestCode.Q110091(c,QuestID);
				case 110092:
					//Bring Benedict\'s magic paper to Andy.
					if(CanQuest(c,30)) break;
					return QuestCode.Q110092(c,QuestID);
				case 110093:
					//Kill 15 Toothy Gerbils in Darksand Land and then report to Andy.
					if(CanQuest(c,30)) break;
					return QuestCode.Q110093(c,QuestID);
				case 110094:
					//Collect 4 Darkthorn Cactus in Darksand Land and bring them back to Edwina.
					if(CanQuest(c,31)) break;
					return QuestCode.Q110094(c,QuestID);
				case 110095:
					//Help Edwina to ask Andy when can they get normal water supply again.
					if(CanQuest(c,31)) break;
					return QuestCode.Q110095(c,QuestID);
				case 110096:
					//Find Chester, help Andy ask about Chester\'s findings.
					if(CanQuest(c,31)) break;
					return QuestCode.Q110096(c,QuestID);
				case 110097:
					//Bring Chester\'s investigation report to Andy.
					if(CanQuest(c,31)) break;
					return QuestCode.Q110097(c,QuestID);
				case 110098:
					//Capture 20 Rattlesnakes in Darksand Land and bring them back to Andy.
					if(CanQuest(c,32)) break;
					return QuestCode.Q110098(c,QuestID);
				case 110099:
					//Follow Andy\'s instruction to find Claude, asking him about how to increase the number of Rattlesnakes.
					if(CanQuest(c,32)) break;
					return QuestCode.Q110099(c,QuestID);
				case 110100:
					//Capture 20 Dire Wolves in Darksand Land and bring them back to Claude.
					if(CanQuest(c,32)) break;
					return QuestCode.Q110100(c,QuestID);
				case 110101:
					//Go to Darksand Land, talk to Claude\'s student Nelson.
					if(CanQuest(c,33)) break;
					return QuestCode.Q110101(c,QuestID);
				case 110102:
					//Collect 4 Buckthorn Grasses from Darksand Land and take them to Nelson.
					if(CanQuest(c,33)) break;
					return QuestCode.Q110102(c,QuestID);
				case 110103:
					//According to Nelson\'s request, ask Willa for some hairs.
					if(CanQuest(c,33)) break;
					return QuestCode.Q110103(c,QuestID);
				case 110104:
					//Kill Swantony in Darksand, seize back Willa\'s ring.
					if(CanQuest(c,34)) break;
					return QuestCode.Q110104(c,QuestID);
				case 110105:
					//Give Willa the ring and ask her for some hairs again.
					if(CanQuest(c,34)) break;
					return QuestCode.Q110105(c,QuestID);
				case 110106:
					//Bring Willa\'s hair back to Nelson.
					if(CanQuest(c,34)) break;
					return QuestCode.Q110106(c,QuestID);
				case 110107:
					//Give Claude materials collected by Nelson.
					if(CanQuest(c,35)) break;
					return QuestCode.Q110107(c,QuestID);
				case 110108:
					//Capture 35 Toothy Gerbils from Darksand Land and bring them back to Claude.
					if(CanQuest(c,35)) break;
					return QuestCode.Q110108(c,QuestID);
				case 110109:
					//Bring the woman from the Darksand Land to Andy.
					if(CanQuest(c,35)) break;
					return QuestCode.Q110109(c,QuestID);
				case 110110:
					//As Andy asked, Tell Ingrid to heal the mysterious woman as soon as possible.
					if(CanQuest(c,36)) break;
					return QuestCode.Q110110(c,QuestID);
				case 110111:
					//Ask Darksand Land\'s Miles for some Styptic.
					if(CanQuest(c,36)) break;
					return QuestCode.Q110111(c,QuestID);
				case 110112:
					//Collect 4 Buckthorn Flowers in Darksand Land and take them to Miles.
					if(CanQuest(c,36)) break;
					return QuestCode.Q110112(c,QuestID);
				case 110113:
					//Give Ingrid the Styptic made by Miles.
					if(CanQuest(c,36)) break;
					return QuestCode.Q110113(c,QuestID);
				case 110114:
					//Help Colin to ask Cornell for Benson\'s whereabouts.
					if(CanQuest(c,37)) break;
					return QuestCode.Q110114(c,QuestID);
				case 110115:
					//Tell Andy about Benson\'s missing and the lost data.
					if(CanQuest(c,37)) break;
					return QuestCode.Q110115(c,QuestID);
				case 110116:
					//Find Esther, let her to get the mysterious woman\'s testimony.
					if(CanQuest(c,37)) break;
					return QuestCode.Q110116(c,QuestID);
				case 110117:
					//Catch 35 Bactrian Camels in Darksand Land and take them to Esther.
					if(CanQuest(c,37)) break;
					return QuestCode.Q110117(c,QuestID);
				case 110118:
					//Find Lyle in Darksand Land, tell him Andy\'s instructions.
					if(CanQuest(c,38)) break;
					return QuestCode.Q110118(c,QuestID);
				case 110119:
					//Ask Julian to think some ways to find Benson.
					if(CanQuest(c,38)) break;
					return QuestCode.Q110119(c,QuestID);
				case 110120:
					//Catch 35 Trade Wind Foxes in Darksand Land and take them back to Julian.
					if(CanQuest(c,38)) break;
					return QuestCode.Q110120(c,QuestID);
				case 110121:
					//Arrest Benson in Darksand Land and take him to Lyle.
					if(CanQuest(c,39)) break;
					return QuestCode.Q110121(c,QuestID);
				case 110122:
					//Ask Ogden about the origin of the badge.
					if(CanQuest(c,39)) break;
					return QuestCode.Q110122(c,QuestID);
				case 110123:
					//Report to Andy about how to deal with Benson.
					if(CanQuest(c,39)) break;
					return QuestCode.Q110123(c,QuestID);
				case 110124:
					//Go to Tramp Camp, contact Duke.
					if(CanQuest(c,40)) break;
					return QuestCode.Q110124(c,QuestID);
				case 110125:
					//Go to see Edgar, ask to join the tramp guild.
					if(CanQuest(c,40)) break;
					return QuestCode.Q110125(c,QuestID);
				case 110126:
					//Catch 40 Phantom Monkeys from Vine Rainforest and take them to Edgar.
					if(CanQuest(c,40)) break;
					return QuestCode.Q110126(c,QuestID);
				case 110127:
					//Register at Hoare and accept his test.
					if(CanQuest(c,40)) break;
					return QuestCode.Q110127(c,QuestID);
				case 110128:
					//Kill 40 Man-eating Trees in Vine Rainforest and report to Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q110128(c,QuestID);
				case 110129:
					//Follow Hoare\'s instruction to meet Ansel.
					if(CanQuest(c,41)) break;
					return QuestCode.Q110129(c,QuestID);
				case 110130:
					//Tell Duke Ansel\'s requirement for the alliance.
					if(CanQuest(c,41)) break;
					return QuestCode.Q110130(c,QuestID);
				case 110131:
					//Tell Ansel Duke\'s reply.
					if(CanQuest(c,41)) break;
					return QuestCode.Q110131(c,QuestID);
				case 110132:
					//Find Monlisa, ask her to brew one Vow Potion.
					if(CanQuest(c,42)) break;
					return QuestCode.Q110132(c,QuestID);
				case 110133:
					//Collect 5 Delusion Herbs in Vine Rainforest and give them to Monlisa.
					if(CanQuest(c,42)) break;
					return QuestCode.Q110133(c,QuestID);
				case 110134:
					//Take Vow Potion to Ansel and drink it in front of him.
					if(CanQuest(c,42)) break;
					return QuestCode.Q110134(c,QuestID);
				case 110135:
					//Ask Elder Levi to make one Eye of Truth.
					if(CanQuest(c,43)) break;
					return QuestCode.Q110135(c,QuestID);
				case 110136:
					//Kill 40 Wraith Spiders in Vine Rainforest, take their eyes to Levi.
					if(CanQuest(c,43)) break;
					return QuestCode.Q110136(c,QuestID);
				case 110137:
					//Find Ansel, see what request he has.
					if(CanQuest(c,43)) break;
					return QuestCode.Q110137(c,QuestID);
				case 110138:
					//Ask Joyce for Tramp\'s headscarf.
					if(CanQuest(c,44)) break;
					return QuestCode.Q110138(c,QuestID);
				case 110139:
					//Kill Baird in Vine Rainforest, take back the stolen Tramp\'s headscarf.
					if(CanQuest(c,44)) break;
					return QuestCode.Q110139(c,QuestID);
				case 110140:
					//Take Tramp\'s headscarf and report to Ansel.
					if(CanQuest(c,44)) break;
					return QuestCode.Q110140(c,QuestID);
				case 110141:
					//Ask Monlisa to make one Mystic Potion.
					if(CanQuest(c,45)) break;
					return QuestCode.Q110141(c,QuestID);
				case 110142:
					//Collect 5 Vampire Vines in Vine Rainforest and tale them back to Monlisa.
					if(CanQuest(c,45)) break;
					return QuestCode.Q110142(c,QuestID);
				case 110143:
					//Listen to Ansel talk about the use of Mystic Potion.
					if(CanQuest(c,45)) break;
					return QuestCode.Q110143(c,QuestID);
				case 110144:
					//Find Jerome in Vine Rainforest, capture Archer with him.
					if(CanQuest(c,46)) break;
					return QuestCode.Q110144(c,QuestID);
				case 110145:
					//Ask Kyle if he can remove the giant stone which blocks the way.
					if(CanQuest(c,46)) break;
					return QuestCode.Q110145(c,QuestID);
				case 110146:
					//Catch 45 Giant Jaw Ants in Vine Rainforest and take them to Kyle.
					if(CanQuest(c,46)) break;
					return QuestCode.Q110146(c,QuestID);
				case 110147:
					//Ask Thera if she can find out the disappeared trace.
					if(CanQuest(c,47)) break;
					return QuestCode.Q110147(c,QuestID);
				case 110148:
					//Ask Winnie to make some Revealing Potion.
					if(CanQuest(c,47)) break;
					return QuestCode.Q110148(c,QuestID);
				case 110149:
					//Collect 5 Luminous Grasses in Vine Rainforest and take them back to Winnie.
					if(CanQuest(c,47)) break;
					return QuestCode.Q110149(c,QuestID);
				case 110150:
					//Catch Archer in Vine Rainforest and take him to Jerome.
					if(CanQuest(c,48)) break;
					return QuestCode.Q110150(c,QuestID);
				case 110151:
					//Take Archer to Tramp Camp\'s Ansel.
					if(CanQuest(c,48)) break;
					return QuestCode.Q110151(c,QuestID);
				case 110152:
					//Take Archer to Morris.
					if(CanQuest(c,48)) break;
					return QuestCode.Q110152(c,QuestID);
				case 110153:
					//Catch 45 Mud Monsters in Vine Rainforest and take them to Morris.
					if(CanQuest(c,49)) break;
					return QuestCode.Q110153(c,QuestID);
				case 110154:
					//Take Archer from Morris to Ansel.
					if(CanQuest(c,49)) break;
					return QuestCode.Q110154(c,QuestID);
				case 110155:
					//Tell Duke that Archer was poisoned to death.
					if(CanQuest(c,49)) break;
					return QuestCode.Q110155(c,QuestID);
				case 110156:
					//Go to Pearl Village, meet Colby dispatched by Duke.
					if(CanQuest(c,50)) break;
					return QuestCode.Q110156(c,QuestID);
				case 110157:
					//Visit Ashbur, ask him about where to find the Blade.
					if(CanQuest(c,50)) break;
					return QuestCode.Q110157(c,QuestID);
				case 110158:
					//Tell Mabel about what the Village Head said.
					if(CanQuest(c,50)) break;
					return QuestCode.Q110158(c,QuestID);
				case 110159:
					//Kill 50 Venom Monsters in Redcloud Marsh and then go back and tell Mabel.
					if(CanQuest(c,50)) break;
					return QuestCode.Q110159(c,QuestID);
				case 110160:
					//Take the red material to Raymond, ask him to analyze its component.
					if(CanQuest(c,51)) break;
					return QuestCode.Q110160(c,QuestID);
				case 110161:
					//Kill 50 Venom Monsters in Redcloud Marsh, collect the red materials for Raymond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q110161(c,QuestID);
				case 110162:
					//Tell Mabel about Raymond\'s finding.
					if(CanQuest(c,51)) break;
					return QuestCode.Q110162(c,QuestID);
				case 110163:
					//Find Vermal in Redcloud Marsh, ask him if anything unusual has happened.
					if(CanQuest(c,52)) break;
					return QuestCode.Q110163(c,QuestID);
				case 110164:
					//Give Simona the data collected by Vermal, ask here to make a comprehensive analysis.
					if(CanQuest(c,52)) break;
					return QuestCode.Q110164(c,QuestID);
				case 110165:
					//Catch 50 Short-wing Rats in Redcloud Marsh and take them to Simona.
					if(CanQuest(c,52)) break;
					return QuestCode.Q110165(c,QuestID);
				case 110166:
					//Ask Raymond about the solution.
					if(CanQuest(c,53)) break;
					return QuestCode.Q110166(c,QuestID);
				case 110167:
					//Catch 50 Medusa in Redcloud Marsh and take back to Raymond.
					if(CanQuest(c,53)) break;
					return QuestCode.Q110167(c,QuestID);
				case 110168:
					//Collect 6 Fluorescent Herbs in Redcloud Marsh and take them to Raymond.
					if(CanQuest(c,53)) break;
					return QuestCode.Q110168(c,QuestID);
				case 110169:
					//Take Simona\'s analysis report to Vermal.
					if(CanQuest(c,54)) break;
					return QuestCode.Q110169(c,QuestID);
				case 110170:
					//Take Simona\'s analysis report to Mabel.
					if(CanQuest(c,54)) break;
					return QuestCode.Q110170(c,QuestID);
				case 110171:
					//Kill 50 Mugger Crocodiles in Redcloud Marsh and then to to tell Mabel.
					if(CanQuest(c,54)) break;
					return QuestCode.Q110171(c,QuestID);
				case 110172:
					//Defeat Olive in Redcloud Marsh and then to to tell Mabel.
					if(CanQuest(c,55)) break;
					return QuestCode.Q110172(c,QuestID);
				case 110173:
					//Take the mysterious woman back to village, ask village head Ashbur if he can find out any clues.
					if(CanQuest(c,55)) break;
					return QuestCode.Q110173(c,QuestID);
				case 110174:
					//Ask Olive about the whereabout of the village head\'s son.
					if(CanQuest(c,55)) break;
					return QuestCode.Q110174(c,QuestID);
				case 110175:
					//Take Olive to Nicolas for treatment.
					if(CanQuest(c,56)) break;
					return QuestCode.Q110175(c,QuestID);
				case 110176:
					//Catch 55 Medusa in Redcloud Marsh and take them to Nicolas.
					if(CanQuest(c,56)) break;
					return QuestCode.Q110176(c,QuestID);
				case 110177:
					//Talk with Olive.
					if(CanQuest(c,56)) break;
					return QuestCode.Q110177(c,QuestID);
				case 110178:
					//Ask Raymond to extract some nectar from Rotten Flower.
					if(CanQuest(c,57)) break;
					return QuestCode.Q110178(c,QuestID);
				case 110179:
					//Collect 6 Rotten Flowers in Redcloud Marsh and take them to Raymond.
					if(CanQuest(c,57)) break;
					return QuestCode.Q110179(c,QuestID);
				case 110180:
					//Take the Rotten Flower to Olive.
					if(CanQuest(c,57)) break;
					return QuestCode.Q110180(c,QuestID);
				case 110181:
					//Ask Olive about the whereabouts of the murderer.
					if(CanQuest(c,58)) break;
					return QuestCode.Q110181(c,QuestID);
				case 110182:
					//Go to Redcloud Marsh, ask Blair to help to find out the mark Olive left.
					if(CanQuest(c,58)) break;
					return QuestCode.Q110182(c,QuestID);
				case 110183:
					//Kill 55 Carrions in Redcloud Marsh and then tell Blair.
					if(CanQuest(c,58)) break;
					return QuestCode.Q110183(c,QuestID);
				case 110184:
					//Destroy Giant Carrion in Redcloud Marsh, take back the box and then tell Blair.
					if(CanQuest(c,59)) break;
					return QuestCode.Q110184(c,QuestID);
				case 110185:
					//Go to Pearl Village, take the box to Colby.
					if(CanQuest(c,59)) break;
					return QuestCode.Q110185(c,QuestID);
				case 110186:
					//Take the box to Gregory to identify.
					if(CanQuest(c,59)) break;
					return QuestCode.Q110186(c,QuestID);
				case 110187:
					//Find Colby, let him make the final decision.
					if(CanQuest(c,59)) break;
					return QuestCode.Q110187(c,QuestID);
				case 110188:
					//Go to the Lost City to meet Mario.
					if(CanQuest(c,60)) break;
					return QuestCode.Q110188(c,QuestID);
				case 110189:
					//Find Amos, ask him about the progress of excavation.
					if(CanQuest(c,60)) break;
					return QuestCode.Q110189(c,QuestID);
				case 110190:
					//Catch 60 Darkwind Wolves in Darkwind Canyon and bring them back to Amos.
					if(CanQuest(c,60)) break;
					return QuestCode.Q110190(c,QuestID);
				case 110191:
					//Tell Veronica about Amos\' request.
					if(CanQuest(c,60)) break;
					return QuestCode.Q110191(c,QuestID);
				case 110192:
					//Take Haemin extracted by Veronica to Amos.
					if(CanQuest(c,61)) break;
					return QuestCode.Q110192(c,QuestID);
				case 110193:
					//Catch 60 Darkwind Hunters in Darkwind Canyon and bring them back to Amos.
					if(CanQuest(c,61)) break;
					return QuestCode.Q110193(c,QuestID);
				case 110194:
					//See Veronica, tell her Amos\' requirement and promise.
					if(CanQuest(c,61)) break;
					return QuestCode.Q110194(c,QuestID);
				case 110195:
					//Take Haemin extracted by Veronica to Amos.
					if(CanQuest(c,62)) break;
					return QuestCode.Q110195(c,QuestID);
				case 110196:
					//Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Amos.
					if(CanQuest(c,62)) break;
					return QuestCode.Q110196(c,QuestID);
				case 110197:
					//See Jeffrey, ask him to come to Amos and discuss the reason of Lost City\'s decline.
					if(CanQuest(c,62)) break;
					return QuestCode.Q110197(c,QuestID);
				case 110198:
					//Ask Mario about the negligence of duty.
					if(CanQuest(c,62)) break;
					return QuestCode.Q110198(c,QuestID);
				case 110199:
					//Ask Omar to save Amos as soon as possible.
					if(CanQuest(c,63)) break;
					return QuestCode.Q110199(c,QuestID);
				case 110200:
					//Collect 6 Cruor Grasses in Darkwind Canyon and bring them back to Omar.
					if(CanQuest(c,63)) break;
					return QuestCode.Q110200(c,QuestID);
				case 110201:
					//Ask Veronica to make purer Antidotes.
					if(CanQuest(c,63)) break;
					return QuestCode.Q110201(c,QuestID);
				case 110202:
					//See Omar, give him Veronica\'s Antidotes.
					if(CanQuest(c,64)) break;
					return QuestCode.Q110202(c,QuestID);
				case 110203:
					//Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Omar.
					if(CanQuest(c,64)) break;
					return QuestCode.Q110203(c,QuestID);
				case 110204:
					//Bring Alger the list of materials needed for holding Soul Ritual.
					if(CanQuest(c,64)) break;
					return QuestCode.Q110204(c,QuestID);
				case 110205:
					//Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Alger.
					if(CanQuest(c,65)) break;
					return QuestCode.Q110205(c,QuestID);
				case 110206:
					//Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Alger.
					if(CanQuest(c,65)) break;
					return QuestCode.Q110206(c,QuestID);
				case 110207:
					//Catch 25 Canyon Eagles, 25 Stone Lizards, 25 Canyon Centaurs in Darkwind Canyon and bring them back to Alger.
					if(CanQuest(c,65)) break;
					return QuestCode.Q110207(c,QuestID);
				case 110208:
					//Bring materials collected by Alger to Omar.
					if(CanQuest(c,66)) break;
					return QuestCode.Q110208(c,QuestID);
				case 110209:
					//Ask Amos about the assassination.
					if(CanQuest(c,66)) break;
					return QuestCode.Q110209(c,QuestID);
				case 110210:
					//Ask Theodore to catch the assassin.
					if(CanQuest(c,66)) break;
					return QuestCode.Q110210(c,QuestID);
				case 110211:
					//Find Angelo in Darkwind Canyon, asking him to catch the assassin as soon as possible.
					if(CanQuest(c,66)) break;
					return QuestCode.Q110211(c,QuestID);
				case 110212:
					//Kill 1 Shadow Assassin in Darkwind Canyon and bring him back to Angelo.
					if(CanQuest(c,66)) break;
					return QuestCode.Q110212(c,QuestID);
				case 110213:
					//Ask Tiffany how to restore Amos\' memory.
					if(CanQuest(c,67)) break;
					return QuestCode.Q110213(c,QuestID);
				case 110214:
					//Collect 6 Hyacinth from Darkwind Canyon and bring them back to Tiffany.
					if(CanQuest(c,67)) break;
					return QuestCode.Q110214(c,QuestID);
				case 110215:
					//Bring the Potion of Time made by Tiffany to Amos.
					if(CanQuest(c,67)) break;
					return QuestCode.Q110215(c,QuestID);
				case 110216:
					//Tell Mario what Amos has found, ask him to report that to the capital.
					if(CanQuest(c,68)) break;
					return QuestCode.Q110216(c,QuestID);
				case 110217:
					//Find Stanley, ask him to summon the souls of the dead assassin.
					if(CanQuest(c,68)) break;
					return QuestCode.Q110217(c,QuestID);
				case 110218:
					//Catch 65 Canyon Centaurs in Darkwind Canyon and bring them back to Stanley.
					if(CanQuest(c,68)) break;
					return QuestCode.Q110218(c,QuestID);
				case 110219:
					//Tell Mario about Stanley\'s finding.
					if(CanQuest(c,69)) break;
					return QuestCode.Q110219(c,QuestID);
				case 110220:
					//Catch 3 Head Centaurs in Darkwind Canyon and bring them back to Mario.
					if(CanQuest(c,69)) break;
					return QuestCode.Q110220(c,QuestID);
				case 110221:
					//Enter Dark Castle, contact Burnell.
					if(CanQuest(c,70)) break;
					return QuestCode.Q110221(c,QuestID);
				case 110222:
					//Ask Jabman about the dagger.
					if(CanQuest(c,70)) break;
					return QuestCode.Q110222(c,QuestID);
				case 110223:
					//Kill 70 Foggy Bears in Foggy Forest and then tell Jabman.
					if(CanQuest(c,70)) break;
					return QuestCode.Q110223(c,QuestID);
				case 110224:
					//Kill 70 Foggy Vampires in Foggy Forest and then tell Jabman.
					if(CanQuest(c,70)) break;
					return QuestCode.Q110224(c,QuestID);
				case 110225:
					//Find Claymond, ask him what usual things have happened recently.
					if(CanQuest(c,71)) break;
					return QuestCode.Q110225(c,QuestID);
				case 110226:
					//Find Xaviera, asking her to try to find some Light of Life.
					if(CanQuest(c,71)) break;
					return QuestCode.Q110226(c,QuestID);
				case 110227:
					//Kill 70 Berserk Warriors in Foggy Forest and then find Xaviera.
					if(CanQuest(c,71)) break;
					return QuestCode.Q110227(c,QuestID);
				case 110228:
					//Find Hiddrick, asking him where the World Tree\'s seed is.
					if(CanQuest(c,72)) break;
					return QuestCode.Q110228(c,QuestID);
				case 110229:
					//Ask Jabman for Tree of Life\'s seed.
					if(CanQuest(c,72)) break;
					return QuestCode.Q110229(c,QuestID);
				case 110230:
					//Kill 70 Dawn Elves in Foggy Forest and then find Jabman.
					if(CanQuest(c,72)) break;
					return QuestCode.Q110230(c,QuestID);
				case 110231:
					//Bring the Light of Life to Claymond.
					if(CanQuest(c,73)) break;
					return QuestCode.Q110231(c,QuestID);
				case 110232:
					//Ask Cyril about the history of Dark Castle.
					if(CanQuest(c,73)) break;
					return QuestCode.Q110232(c,QuestID);
				case 110233:
					//Find Zelene, listen to him talk about what happened next.
					if(CanQuest(c,73)) break;
					return QuestCode.Q110233(c,QuestID);
				case 110234:
					//Find Claymond, listen to him talk about what happened next.
					if(CanQuest(c,73)) break;
					return QuestCode.Q110234(c,QuestID);
				case 110235:
					//Kill 70 Berserk Warriors in Foggy Forest, then go back and tell Claymond.
					if(CanQuest(c,74)) break;
					return QuestCode.Q110235(c,QuestID);
				case 110236:
					//Kill 70 Dawn Elves in Foggy Forest, then go back and tell Claymond.
					if(CanQuest(c,74)) break;
					return QuestCode.Q110236(c,QuestID);
				case 110237:
					//Collect 6 Foggy Roses in Foggy Forest and bring them back to Claymond.
					if(CanQuest(c,74)) break;
					return QuestCode.Q110237(c,QuestID);
				case 110238:
					//Tell Cesar about Claymond\'s instructions.
					if(CanQuest(c,75)) break;
					return QuestCode.Q110238(c,QuestID);
				case 110239:
					//Ask Yuna who\'s been to Seal Room recently.
					if(CanQuest(c,75)) break;
					return QuestCode.Q110239(c,QuestID);
				case 110240:
					//Catch 75 Foggy Spiders in Foggy Forest and bring them back to Yuna.
					if(CanQuest(c,75)) break;
					return QuestCode.Q110240(c,QuestID);
				case 110241:
					//Find Dark in Foggy Forest and ask him about Riel\'s trend.
					if(CanQuest(c,76)) break;
					return QuestCode.Q110241(c,QuestID);
				case 110242:
					//Catch 75 Dawn Elves in Foggy Forest and bring them back to Dark.
					if(CanQuest(c,76)) break;
					return QuestCode.Q110242(c,QuestID);
				case 110243:
					//Tell Dark Castle\'s Claymond the information Dark has learnt.
					if(CanQuest(c,76)) break;
					return QuestCode.Q110243(c,QuestID);
				case 110244:
					//Go to Foggy Forest Wind Rider Rita， Blade of Light。
					if(CanQuest(c,77)) break;
					return QuestCode.Q110244(c,QuestID);
				case 110245:
					//Ask Jabman if there\'s any remedy.
					if(CanQuest(c,77)) break;
					return QuestCode.Q110245(c,QuestID);
				case 110246:
					//Find Candice, tell her Jabman\'s demand.
					if(CanQuest(c,77)) break;
					return QuestCode.Q110246(c,QuestID);
				case 110247:
					//Collect 6 Blood Mosses in Foggy Forest and bring them back to Candice.
					if(CanQuest(c,78)) break;
					return QuestCode.Q110247(c,QuestID);
				case 110248:
					//Bring Deadsoul Potion mae by Candice to Parker.
					if(CanQuest(c,78)) break;
					return QuestCode.Q110248(c,QuestID);
				case 110249:
					//Catch 75 Berserk Warriors in Foggy Forest and bring them back to Parker.
					if(CanQuest(c,78)) break;
					return QuestCode.Q110249(c,QuestID);
				case 110250:
					//Bring the Chaos Crystal extracted by Candice to Jabman.
					if(CanQuest(c,79)) break;
					return QuestCode.Q110250(c,QuestID);
				case 110251:
					//Kill 5 Head Berserks in Foggy Forest and then tell Jabman.
					if(CanQuest(c,79)) break;
					return QuestCode.Q110251(c,QuestID);
				case 110252:
					//Find Burnell, tell him about Jabman\'s words.
					if(CanQuest(c,79)) break;
					return QuestCode.Q110252(c,QuestID);
				case 110253:
					//Go to Henan Mountain, contact Burnell.
					if(CanQuest(c,80)) break;
					return QuestCode.Q110253(c,QuestID);
				case 110254:
					//Ask Herman about what to do next for Harold.
					if(CanQuest(c,80)) break;
					return QuestCode.Q110254(c,QuestID);
				case 110255:
					//Find Sigrid and ask him to save the unconscious advance agent.
					if(CanQuest(c,80)) break;
					return QuestCode.Q110255(c,QuestID);
				case 110256:
					//Catch 80 Carefree Beasts in the Henan Mountainside, and bring them to Sigrid.
					if(CanQuest(c,80)) break;
					return QuestCode.Q110256(c,QuestID);
				case 110257:
					//Find Jeremy and ask him about the way to remove the Blessing Mark of Lord of Oracle
					if(CanQuest(c,81)) break;
					return QuestCode.Q110257(c,QuestID);
				case 110258:
					//Tell Sigrid Jeremy\'s words.
					if(CanQuest(c,81)) break;
					return QuestCode.Q110258(c,QuestID);
				case 110259:
					//Collect 6 Despair Herbs on the Henan Mountainside and give them to Sigrid.
					if(CanQuest(c,81)) break;
					return QuestCode.Q110259(c,QuestID);
				case 110260:
					//Bring the advance agent that saved by Sigrid to Herman.
					if(CanQuest(c,82)) break;
					return QuestCode.Q110260(c,QuestID);
				case 110261:
					//Catch 80 Spirit Dragons on the Henan Mountainside, and bring them to Herman.
					if(CanQuest(c,82)) break;
					return QuestCode.Q110261(c,QuestID);
				case 110262:
					//Find Kelly and ask her to break the Circle of Memory Sealing.
					if(CanQuest(c,82)) break;
					return QuestCode.Q110262(c,QuestID);
				case 110263:
					//Find Sigrid and ask her for a Imaging Restore Potion.
					if(CanQuest(c,83)) break;
					return QuestCode.Q110263(c,QuestID);
				case 110264:
					//Catch 80 Spirit Dragons on the Henan Mountainside, and bring them to Sigrid.
					if(CanQuest(c,83)) break;
					return QuestCode.Q110264(c,QuestID);
				case 110265:
					//Find Renee and ask her to refine the Magic Elements in the Spirit Dragons.
					if(CanQuest(c,83)) break;
					return QuestCode.Q110265(c,QuestID);
				case 110266:
					//Give the refined Magic Elements to Sigrid.
					if(CanQuest(c,84)) break;
					return QuestCode.Q110266(c,QuestID);
				case 110267:
					//Find Eunice and ask her about the way of increasing the density of the Magic Elements.
					if(CanQuest(c,84)) break;
					return QuestCode.Q110267(c,QuestID);
				case 110268:
					//Collect 6 Silver Mines on the Henan Mountainside and give them to Eunice.
					if(CanQuest(c,84)) break;
					return QuestCode.Q110268(c,QuestID);
				case 110269:
					//Give the refined Silver Mine to Sigrid.
					if(CanQuest(c,84)) break;
					return QuestCode.Q110269(c,QuestID);
				case 110270:
					//Give the configured Imaging Restore Potion to Sigrid.
					if(CanQuest(c,85)) break;
					return QuestCode.Q110270(c,QuestID);
				case 110271:
					//Kill 85 Lost Acolytes on the Henan Mountainside then go back and tell tell Kelly.
					if(CanQuest(c,85)) break;
					return QuestCode.Q110271(c,QuestID);
				case 110272:
					//Tell Herman Kelly\'s discovery.
					if(CanQuest(c,85)) break;
					return QuestCode.Q110272(c,QuestID);
				case 110273:
					//Tell Mitchell Herman\'s request.
					if(CanQuest(c,86)) break;
					return QuestCode.Q110273(c,QuestID);
				case 110274:
					//Tell Eunice Mitchell\'s request.
					if(CanQuest(c,86)) break;
					return QuestCode.Q110274(c,QuestID);
				case 110275:
					//Catch 50 Carefree Beasts and 50 Bubble Beasts on Henan Mountainside and bring them to Eunice.
					if(CanQuest(c,86)) break;
					return QuestCode.Q110275(c,QuestID);
				case 110276:
					//Tell Mitchell Eunice\'s discovery.
					if(CanQuest(c,87)) break;
					return QuestCode.Q110276(c,QuestID);
				case 110277:
					//Catch 85 Bubble Beasts on Henan Mountainside and bring them to Mitchell.
					if(CanQuest(c,87)) break;
					return QuestCode.Q110277(c,QuestID);
				case 110278:
					//Give the Track Potion made by Mitchell to Herman.
					if(CanQuest(c,87)) break;
					return QuestCode.Q110278(c,QuestID);
				case 110279:
					//Defeat the Guarder Sissi on the Henan Mountainside then go back and tell Herman.
					if(CanQuest(c,88)) break;
					return QuestCode.Q110279(c,QuestID);
				case 110280:
					//Ask Jared about the way to defeat Guarder Sissi for Herman.
					if(CanQuest(c,88)) break;
					return QuestCode.Q110280(c,QuestID);
				case 110281:
					//Catch 50 Skyish Beasts and 50 Dark Carefree Beast on the Henan Mountainside then bring them to Jared.
					if(CanQuest(c,88)) break;
					return QuestCode.Q110281(c,QuestID);
				case 110282:
					//Kill 10 Guarder Sissi on the Henan Mountainside then go back and tell Jared.
					if(CanQuest(c,89)) break;
					return QuestCode.Q110282(c,QuestID);
				case 110283:
					//Tell Herman Jared\'s suggestion.
					if(CanQuest(c,89)) break;
					return QuestCode.Q110283(c,QuestID);
				case 110284:
					//Go to Peak of the World and contact Herman.
					if(CanQuest(c,90)) break;
					return QuestCode.Q110284(c,QuestID);
				case 111001:
					//Find Old Blacksmith, get the gift from the Old Blacksmith.
					if(CanQuest(c,11)) break;
					return QuestCode.Q111001(c,QuestID);
				case 111004:
					//Learn new skill from Warrior Leader.
					if(CanQuest(c,12)) break;
					return QuestCode.Q111004(c,QuestID);
				case 111006:
					//Get a better weapon from the Warrior Leader.
					if(CanQuest(c,12)) break;
					return QuestCode.Q111006(c,QuestID);
				case 111008:
					//Ask Grocer for some Teleport Scrolls.
					if(CanQuest(c,12)) break;
					return QuestCode.Q111008(c,QuestID);
				case 111010:
					//Get a better magic cloth from the Tailor.
					if(CanQuest(c,12)) break;
					return QuestCode.Q111010(c,QuestID);
				case 111011:
					//Go to see the Stargazer and get to know your horoscopes.
					if(CanQuest(c,13)) break;
					return QuestCode.Q111011(c,QuestID);
				case 111012:
					//See the Preparatory Officer, let him arrange the following things.
					if(CanQuest(c,13)) break;
					return QuestCode.Q111012(c,QuestID);
				case 111015:
					//Go to Sunshine Cliff, meet Allen.
					if(CanQuest(c,14)) break;
					return QuestCode.Q111015(c,QuestID);
				case 111044:
					//Go to the City of Genesis and contact Grover.
					if(CanQuest(c,20)) break;
					return QuestCode.Q111044(c,QuestID);
				case 112001:
					//Find Old Blacksmith, get the gift from the Old Blacksmith.
					if(CanQuest(c,11)) break;
					return QuestCode.Q112001(c,QuestID);
				case 112004:
					//Learn new skill from Warrior Leader.
					if(CanQuest(c,12)) break;
					return QuestCode.Q112004(c,QuestID);
				case 112006:
					//Get a better weapon from the Warrior Leader.
					if(CanQuest(c,12)) break;
					return QuestCode.Q112006(c,QuestID);
				case 112008:
					//Ask Grocer for some Teleport Scrolls.
					if(CanQuest(c,12)) break;
					return QuestCode.Q112008(c,QuestID);
				case 112010:
					//Get a better magic cloth from the Tailor.
					if(CanQuest(c,12)) break;
					return QuestCode.Q112010(c,QuestID);
				case 112011:
					//Go to see the Stargazer and get to know your horoscopes.
					if(CanQuest(c,13)) break;
					return QuestCode.Q112011(c,QuestID);
				case 112012:
					//See the Preparatory Officer, let him arrange the following things.
					if(CanQuest(c,13)) break;
					return QuestCode.Q112012(c,QuestID);
				case 112015:
					//Go to Sunshine Cliff, meet Allen.
					if(CanQuest(c,14)) break;
					return QuestCode.Q112015(c,QuestID);
				case 113001:
					//Find Old Blacksmith, get the gift from the Old Blacksmith.
					if(CanQuest(c,11)) break;
					return QuestCode.Q113001(c,QuestID);
				case 113004:
					//Learn new skill from Warrior Leader.
					if(CanQuest(c,12)) break;
					return QuestCode.Q113004(c,QuestID);
				case 113006:
					//Get a better weapon from the Warrior Leader.
					if(CanQuest(c,12)) break;
					return QuestCode.Q113006(c,QuestID);
				case 113008:
					//Ask Grocer for some Teleport Scrolls.
					if(CanQuest(c,12)) break;
					return QuestCode.Q113008(c,QuestID);
				case 113010:
					//Get a better magic cloth from the Tailor.
					if(CanQuest(c,12)) break;
					return QuestCode.Q113010(c,QuestID);
				case 113011:
					//Go to see the Stargazer and get to know your horoscopes.
					if(CanQuest(c,13)) break;
					return QuestCode.Q113011(c,QuestID);
				case 113012:
					//See the Preparatory Officer, let him arrange the following things.
					if(CanQuest(c,13)) break;
					return QuestCode.Q113012(c,QuestID);
				case 113015:
					//Go to Sunshine Cliff, meet Allen.
					if(CanQuest(c,14)) break;
					return QuestCode.Q113015(c,QuestID);
				case 119001:
					//Ask Ernest for the weapon Grover has prepared.
					if(CanQuest(c,20)) break;
					return QuestCode.Q119001(c,QuestID);
				case 119002:
					//Ask Larry about the whole thing.
					if(CanQuest(c,21)) break;
					return QuestCode.Q119002(c,QuestID);
				case 119003:
					//Kill Mentor Quentin at Dawn Pier, then tell this news to Jeff.
					if(CanQuest(c,21)) break;
					return QuestCode.Q119003(c,QuestID);
				case 119004:
					//Get VIP Trial Card from Larry.
					if(CanQuest(c,21)) break;
					return QuestCode.Q119004(c,QuestID);
				case 119005:
					//Try zodiac transformation under Grover\'s guidance.
					if(CanQuest(c,20)) break;
					return QuestCode.Q119005(c,QuestID);
				case 119006:
					//Find Goya and finish her request.
					if(CanQuest(c,20)) break;
					return QuestCode.Q119006(c,QuestID);
				case 119007:
					//Tell Spendo about Donald\'s news.
					if(CanQuest(c,19)) break;
					return QuestCode.Q119007(c,QuestID);
				case 119009:
					//Synthesize one Armor Shred with Magic Seed, then go to see Herbert.
					if(CanQuest(c,26)) break;
					return QuestCode.Q119009(c,QuestID);
				case 119010:
					//Synthesize one Ice Enchant with Magic Seed, then go to see Herbert.
					if(CanQuest(c,26)) break;
					return QuestCode.Q119010(c,QuestID);
				case 119011:
					//Synthesize one Death Inspire with Magic Seed, then go to see Herbert.
					if(CanQuest(c,26)) break;
					return QuestCode.Q119011(c,QuestID);
				case 119012:
					//Find Feig, buy one HP Potion B and talk to him.
					if(CanQuest(c,26)) break;
					return QuestCode.Q119012(c,QuestID);
				case 119013:
					//Enter Sky City, kill 4 Cloud Elves, then go to see Beryl.
					if(CanQuest(c,26)) break;
					return QuestCode.Q119013(c,QuestID);
				case 119014:
					//Go to City of Genesis, find Morton and listen to his instructions.
					if(CanQuest(c,27)) break;
					return QuestCode.Q119014(c,QuestID);
				case 119016:
					//Find Edith, ask her how to make money.
					if(CanQuest(c,28)) break;
					return QuestCode.Q119016(c,QuestID);
				case 119017:
					//Complete Escort Supplies once, then go to see Edith.
					if(CanQuest(c,28)) break;
					return QuestCode.Q119017(c,QuestID);
				case 119018:
					//Enter Dragon Cave, kill 5 Bronze Drakes, and then find Quenton.
					if(CanQuest(c,29)) break;
					return QuestCode.Q119018(c,QuestID);
				case 119020:
					//Collect 2 Dusk Dew in Lune Oasis, and then find Pine.
					if(CanQuest(c,25)) break;
					return QuestCode.Q119020(c,QuestID);
				case 119021:
					//Kill 8 Moonlight Beasts in Lune Oasis, then find Ralph.
					if(CanQuest(c,25)) break;
					return QuestCode.Q119021(c,QuestID);
				case 119022:
					//Kill 8 Gangtooth Spiders in Lune Oasis, then find Gemma.
					if(CanQuest(c,25)) break;
					return QuestCode.Q119022(c,QuestID);
				case 119023:
					//Kill 8 Desert Lizards in Lune Oasis, then find Claude.
					if(CanQuest(c,25)) break;
					return QuestCode.Q119023(c,QuestID);
				case 119024:
					//Kill 8 Desert Arks in Lune Oasis, then find Claude.
					if(CanQuest(c,25)) break;
					return QuestCode.Q119024(c,QuestID);
				case 119025:
					//Find Jason in Lune Oasis, listen to his command.
					if(CanQuest(c,25)) break;
					return QuestCode.Q119025(c,QuestID);
				case 120004:
					//Add 1 friend and find Leonard to finish the quest.
					if(CanQuest(c,31)) break;
					return QuestCode.Q120004(c,QuestID);
				case 120022:
					//Join a guild and find Edith to complete the task.
					if(CanQuest(c,30)) break;
					return QuestCode.Q120022(c,QuestID);
				case 120027:
					//Ask Cleveland how to take a leave successfully.
					if(CanQuest(c,23)) break;
					return QuestCode.Q120027(c,QuestID);
				case 120028:
					//Persuade Curtis to agree the work shift with Edith.
					if(CanQuest(c,23)) break;
					return QuestCode.Q120028(c,QuestID);
				case 120029:
					//Catch 8 Fire Bats at Rubble Wasteland and take them back to Curtis.
					if(CanQuest(c,23)) break;
					return QuestCode.Q120029(c,QuestID);
				case 120030:
					//Kill 5 Stone Ants at Rubble Wasteland and then tell Curtis.
					if(CanQuest(c,24)) break;
					return QuestCode.Q120030(c,QuestID);
				case 120031:
					//Take Dulcie the weapon enhanced by Curtis.
					if(CanQuest(c,24)) break;
					return QuestCode.Q120031(c,QuestID);
				case 120035:
					//Kill 8 The Decayed at Rubble Wasteland and then tell Dulcie.
					if(CanQuest(c,24)) break;
					return QuestCode.Q120035(c,QuestID);
				case 120036:
					//Go to see Elroy, ask the reason of Treant\'s attack for Dulcie.
					if(CanQuest(c,24)) break;
					return QuestCode.Q120036(c,QuestID);
				case 120037:
					//Catch 5 Wind Weasels at Rubble Wasteland and take back to Moore.
					if(CanQuest(c,25)) break;
					return QuestCode.Q120037(c,QuestID);
				case 120038:
					//Help Elroy to find Magee and find out if there\'s some way to restore the magic array on the sword.
					if(CanQuest(c,25)) break;
					return QuestCode.Q120038(c,QuestID);
				case 120039:
					//Catch 5 Tarantulas at Rubble Wasteland and take back to Ralph.
					if(CanQuest(c,25)) break;
					return QuestCode.Q120039(c,QuestID);
				case 120040:
					//Take the sword enchanted by Magee to Beryl.
					if(CanQuest(c,25)) break;
					return QuestCode.Q120040(c,QuestID);
				case 120058:
					//Kill 15 Toothy Gerbil at Darksand Land and report to Andy.
					if(CanQuest(c,30)) break;
					return QuestCode.Q120058(c,QuestID);
				case 120059:
					//Ask Ingrid how to heal rheumatism for Colin.
					if(CanQuest(c,30)) break;
					return QuestCode.Q120059(c,QuestID);
				case 120060:
					//Catch 30 Toxic Scorpions at Darksand Land and take back to Ingrid.
					if(CanQuest(c,30)) break;
					return QuestCode.Q120060(c,QuestID);
				case 120061:
					//Ask Benedict about how to get food.
					if(CanQuest(c,31)) break;
					return QuestCode.Q120061(c,QuestID);
				case 120062:
					//Tell Andy Benedict\'s suggestion.
					if(CanQuest(c,31)) break;
					return QuestCode.Q120062(c,QuestID);
				case 120063:
					//Catch 20 Toothy Gerbils at Darksand Land and take them back to Andy.
					if(CanQuest(c,31)) break;
					return QuestCode.Q120063(c,QuestID);
				case 120064:
					//Ask Claude to detoxify for Chester\'s wife.
					if(CanQuest(c,32)) break;
					return QuestCode.Q120064(c,QuestID);
				case 120065:
					//Catch 20 Toxic Scorpions at Darksand Land, take them to Claude to make antidotes.
					if(CanQuest(c,32)) break;
					return QuestCode.Q120065(c,QuestID);
				case 120066:
					//Take Claude\'s antidotes to Chester.
					if(CanQuest(c,32)) break;
					return QuestCode.Q120066(c,QuestID);
				case 120067:
					//Ask Claude about salary increase.
					if(CanQuest(c,32)) break;
					return QuestCode.Q120067(c,QuestID);
				case 120068:
					//Tell Nelson Claude\'s promise.
					if(CanQuest(c,32)) break;
					return QuestCode.Q120068(c,QuestID);
				case 120069:
					//Ask Colin to derust weapon.
					if(CanQuest(c,33)) break;
					return QuestCode.Q120069(c,QuestID);
				case 120070:
					//Collect 4 Darksand Essence at Darksand Land and take back to Colin.
					if(CanQuest(c,33)) break;
					return QuestCode.Q120070(c,QuestID);
				case 120071:
					//Take the weapon reforged by Colin to Esther.
					if(CanQuest(c,33)) break;
					return QuestCode.Q120071(c,QuestID);
				case 120072:
					//Kill 30 Dire Wolves at Darksand Land and report to Andy.
					if(CanQuest(c,34)) break;
					return QuestCode.Q120072(c,QuestID);
				case 120073:
					//Ask Claude how to let Rattlesnakes quiet down at night
					if(CanQuest(c,34)) break;
					return QuestCode.Q120073(c,QuestID);
				case 120074:
					//Tell Lyle Claude\'s method.
					if(CanQuest(c,34)) break;
					return QuestCode.Q120074(c,QuestID);
				case 120075:
					//Catch 30 Toothy Gerbils at Darksand Land and take them back to Lyle.
					if(CanQuest(c,34)) break;
					return QuestCode.Q120075(c,QuestID);
				case 120076:
					//Catch 35 Toxic Scorpions at Darksand Land and take them back to Julian.
					if(CanQuest(c,35)) break;
					return QuestCode.Q120076(c,QuestID);
				case 120077:
					//Catch 35 Dire Wolves at Darksand Land and take them back to Julian.
					if(CanQuest(c,35)) break;
					return QuestCode.Q120077(c,QuestID);
				case 120078:
					//Catch 35 Bactrian Camels at Darksand Land and take them back to Julian.
					if(CanQuest(c,35)) break;
					return QuestCode.Q120078(c,QuestID);
				case 120079:
					//Catch 35 Bactrian Camels at Darksand Land and take them back to Andy.
					if(CanQuest(c,36)) break;
					return QuestCode.Q120079(c,QuestID);
				case 120080:
					//Ask Julian how to get fuels.
					if(CanQuest(c,36)) break;
					return QuestCode.Q120080(c,QuestID);
				case 120081:
					//Catch 35 Sand Fire Lizard at Darksand Land and take back to Julian.
					if(CanQuest(c,36)) break;
					return QuestCode.Q120081(c,QuestID);
				case 120085:
					//Catch 35 Dire Wolves at Darksand Land and take them back to Nelson.
					if(CanQuest(c,38)) break;
					return QuestCode.Q120085(c,QuestID);
				case 120086:
					//Tell Willa that Nelson has done what she asks.
					if(CanQuest(c,38)) break;
					return QuestCode.Q120086(c,QuestID);
				case 120087:
					//Catch 35 Trade Wind Fox at Darksand Land and take back to Cornell.
					if(CanQuest(c,37)) break;
					return QuestCode.Q120087(c,QuestID);
				case 120088:
					//Take Lyle and his broken arm to Ingrid.
					if(CanQuest(c,39)) break;
					return QuestCode.Q120088(c,QuestID);
				case 120089:
					//Catch 35 Sand Fire Lizards at Darksand Land and take them to Ingrid.
					if(CanQuest(c,39)) break;
					return QuestCode.Q120089(c,QuestID);
				case 120090:
					//Kill 35 Toxic Scorpions at Darksand Land and report to Andy.
					if(CanQuest(c,39)) break;
					return QuestCode.Q120090(c,QuestID);
				case 120091:
					//Ask Edgar to take out some bananas from the Inventory.
					if(CanQuest(c,40)) break;
					return QuestCode.Q120091(c,QuestID);
				case 120092:
					//Ask Joyce to get bananas before sunset.
					if(CanQuest(c,40)) break;
					return QuestCode.Q120092(c,QuestID);
				case 120093:
					//Catch 40 Phantom Monkeys in Vine Rainforest and take back to Joyce.
					if(CanQuest(c,40)) break;
					return QuestCode.Q120093(c,QuestID);
				case 120094:
					//Catch 40 Phantom Monkeys in Vine Rainforest and then tell Shalom.
					if(CanQuest(c,41)) break;
					return QuestCode.Q120094(c,QuestID);
				case 120095:
					//Find Leopold in Vine Rainforest and investigate the missing man with him.
					if(CanQuest(c,41)) break;
					return QuestCode.Q120095(c,QuestID);
				case 120096:
					//Catch 40 Man-eating Trees in Vine Rainforest and take back to Leopold.
					if(CanQuest(c,41)) break;
					return QuestCode.Q120096(c,QuestID);
				case 120097:
					//Report to Edgar the investigation result.
					if(CanQuest(c,41)) break;
					return QuestCode.Q120097(c,QuestID);
				case 120098:
					//Ask Monlisa how to prevent food from mouldiness.
					if(CanQuest(c,42)) break;
					return QuestCode.Q120098(c,QuestID);
				case 120099:
					//Catch 40 Man-eating Trees in Vine Rainforest and take back to Monlisa.
					if(CanQuest(c,42)) break;
					return QuestCode.Q120099(c,QuestID);
				case 120100:
					//Kill 40 Wraith Spiders in Vine Rainforest and then tell Laurie.
					if(CanQuest(c,42)) break;
					return QuestCode.Q120100(c,QuestID);
				case 120101:
					//Catch 40 Wraith Spiders in Vine Rainforest and take back to Thera.
					if(CanQuest(c,43)) break;
					return QuestCode.Q120101(c,QuestID);
				case 120102:
					//Ask Winnie how to deal with spider\'s thread.
					if(CanQuest(c,43)) break;
					return QuestCode.Q120102(c,QuestID);
				case 120103:
					//Take Wraith\'s Spider Thread to Thera.
					if(CanQuest(c,43)) break;
					return QuestCode.Q120103(c,QuestID);
				case 120104:
					//Catch 40 Wraith Spiders in Vine Rainforest and take back to Shalom.
					if(CanQuest(c,44)) break;
					return QuestCode.Q120104(c,QuestID);
				case 120105:
					//Ask Monlisa to help Shalom extract Wraith Spider\'s poison.
					if(CanQuest(c,44)) break;
					return QuestCode.Q120105(c,QuestID);
				case 120106:
					//Ask Shalom why she need to extract the poison.
					if(CanQuest(c,44)) break;
					return QuestCode.Q120106(c,QuestID);
				case 120107:
					//Tell Joyce Hoare\'s task.
					if(CanQuest(c,45)) break;
					return QuestCode.Q120107(c,QuestID);
				case 120108:
					//Catch 45 Giant Jaw Ants in Vine Rainforest and take back to Joyce.
					if(CanQuest(c,45)) break;
					return QuestCode.Q120108(c,QuestID);
				case 120109:
					//Catch 45 Mud Monsters in Vine Rainforest and take back to Levi.
					if(CanQuest(c,45)) break;
					return QuestCode.Q120109(c,QuestID);
				case 120110:
					//Ask Levi to repair the broken magic test crystal.
					if(CanQuest(c,46)) break;
					return QuestCode.Q120110(c,QuestID);
				case 120111:
					//Collect 5 Water Mana Spar in Vine Rainforest and take them back to Levi.
					if(CanQuest(c,46)) break;
					return QuestCode.Q120111(c,QuestID);
				case 120112:
					//Take the repaired Test Crystal to Hoare.
					if(CanQuest(c,46)) break;
					return QuestCode.Q120112(c,QuestID);
				case 120113:
					//Kill 15 Wraith Spiders, 15 Man-eating Trees, 15 Mud Monsters in Vine Rainforest and report to Ansel.
					if(CanQuest(c,47)) break;
					return QuestCode.Q120113(c,QuestID);
				case 120114:
					//Kill 45 Mud Monsters in Vine Rainforest and then tell Leopold.
					if(CanQuest(c,47)) break;
					return QuestCode.Q120114(c,QuestID);
				case 120115:
					//Ask Monlisa how to heal rheumatism.
					if(CanQuest(c,48)) break;
					return QuestCode.Q120115(c,QuestID);
				case 120116:
					//Catch 45 Giant Jaw Ants in Vine Rainforest and take them to Monlisa.
					if(CanQuest(c,48)) break;
					return QuestCode.Q120116(c,QuestID);
				case 120117:
					//Tell Levi Monlisa\'s treatment.
					if(CanQuest(c,48)) break;
					return QuestCode.Q120117(c,QuestID);
				case 120118:
					//Tell Levi Ansel\'s instructions.
					if(CanQuest(c,49)) break;
					return QuestCode.Q120118(c,QuestID);
				case 120119:
					//Catch 45 Mud Monsters in Vine Rainforest and take back to Levi.
					if(CanQuest(c,49)) break;
					return QuestCode.Q120119(c,QuestID);
				case 120120:
					//Ask Hyman to give Weisz a good weapon to pay the debt of gratitude.
					if(CanQuest(c,50)) break;
					return QuestCode.Q120120(c,QuestID);
				case 120121:
					//Ask Raymond how to get Curare Wood.
					if(CanQuest(c,50)) break;
					return QuestCode.Q120121(c,QuestID);
				case 120122:
					//Catch 50 Venom Monsters in Redcloud Marsh and take back to Raymond.
					if(CanQuest(c,50)) break;
					return QuestCode.Q120122(c,QuestID);
				case 120123:
					//Take Raymond\'s Corrosion Potion to Hyman.
					if(CanQuest(c,50)) break;
					return QuestCode.Q120123(c,QuestID);
				case 120124:
					//Take Hyman\'s weapon to Weisz.
					if(CanQuest(c,50)) break;
					return QuestCode.Q120124(c,QuestID);
				case 120125:
					//Catch 50 Venom Monsters in Redcloud Marsh and take back to Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q120125(c,QuestID);
				case 120126:
					//Ask Rodney to get a Venom Monster with wings.
					if(CanQuest(c,51)) break;
					return QuestCode.Q120126(c,QuestID);
				case 120127:
					//Catch 50 Short-wing Rats in Redcloud Marsh and take back to Rodney.
					if(CanQuest(c,51)) break;
					return QuestCode.Q120127(c,QuestID);
				case 120128:
					//Take Rodney\'s Venom Monster to Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q120128(c,QuestID);
				case 120129:
					//Tell Nicolas that Weisz has absorbed miasma in the village and ask him to solve this.
					if(CanQuest(c,52)) break;
					return QuestCode.Q120129(c,QuestID);
				case 120130:
					//Kill 50 Medusa in Redcloud Marsh and take their eyes to Nicolas.
					if(CanQuest(c,52)) break;
					return QuestCode.Q120130(c,QuestID);
				case 120131:
					//Catch 50 Venom Monsters in Redcloud Marsh and take back to Vermal.
					if(CanQuest(c,52)) break;
					return QuestCode.Q120131(c,QuestID);
				case 120132:
					//Catch 50 Medusa in Redcloud Marsh and take back to Raymond.
					if(CanQuest(c,53)) break;
					return QuestCode.Q120132(c,QuestID);
				case 120133:
					//Ask Simona to analyze the crystal crumble.
					if(CanQuest(c,53)) break;
					return QuestCode.Q120133(c,QuestID);
				case 120134:
					//Tell Raymond Simona\'s analysis result.
					if(CanQuest(c,53)) break;
					return QuestCode.Q120134(c,QuestID);
				case 120135:
					//Tell Raymond that Serena needs a bottle of colorant.
					if(CanQuest(c,54)) break;
					return QuestCode.Q120135(c,QuestID);
				case 120136:
					//Catch 20 Venom Monsters, 20 Medusa and 20 Mugger Crocodiles in Redcloud Marsh and take back to Raymond.
					if(CanQuest(c,54)) break;
					return QuestCode.Q120136(c,QuestID);
				case 120137:
					//Collect 6 Greenbell Flowers in Redcloud Marsh and take back to Raymond.
					if(CanQuest(c,54)) break;
					return QuestCode.Q120137(c,QuestID);
				case 120138:
					//Tell Bertram the news that his brother is murdered.
					if(CanQuest(c,55)) break;
					return QuestCode.Q120138(c,QuestID);
				case 120139:
					//Kill 55 Carrion in Redcloud Marsh and then tell Bertram.
					if(CanQuest(c,55)) break;
					return QuestCode.Q120139(c,QuestID);
				case 120140:
					//Kill 5 Giant Carrion in Redcloud Marsh and then tell Bertram.
					if(CanQuest(c,55)) break;
					return QuestCode.Q120140(c,QuestID);
				case 120141:
					//Kill 55 Carrion in Redcloud Marsh and then tell Serena.
					if(CanQuest(c,56)) break;
					return QuestCode.Q120141(c,QuestID);
				case 120142:
					//Ask Rodney where to find the stones to build house.
					if(CanQuest(c,56)) break;
					return QuestCode.Q120142(c,QuestID);
				case 120143:
					//Catch 55 Short-wing Rats in Redcloud Marsh and take back to Rodney.
					if(CanQuest(c,56)) break;
					return QuestCode.Q120143(c,QuestID);
				case 120144:
					//Tell Blair Osmond\'s requirement and conditions.
					if(CanQuest(c,57)) break;
					return QuestCode.Q120144(c,QuestID);
				case 120145:
					//Catch 55 Mugger Crocodiles in Redcloud Marsh and take back to Blair.
					if(CanQuest(c,57)) break;
					return QuestCode.Q120145(c,QuestID);
				case 120146:
					//Catch 55 Short-wing Rats in Redcloud Marsh and take back to Blair.
					if(CanQuest(c,57)) break;
					return QuestCode.Q120146(c,QuestID);
				case 120147:
					//Tell Mabel Osmond\'s task and ask her to find out the truth asap.
					if(CanQuest(c,58)) break;
					return QuestCode.Q120147(c,QuestID);
				case 120148:
					//Tell Osmond Mabel\'s findings.
					if(CanQuest(c,58)) break;
					return QuestCode.Q120148(c,QuestID);
				case 120149:
					//Kill 55 Carrion in Redcloud Marsh and then tell Osmond.
					if(CanQuest(c,58)) break;
					return QuestCode.Q120149(c,QuestID);
				case 120150:
					//Help Weisz to ask Serena the materials for making quality leather bag.
					if(CanQuest(c,59)) break;
					return QuestCode.Q120150(c,QuestID);
				case 120151:
					//Tell Weisz Serena\'s advice.
					if(CanQuest(c,59)) break;
					return QuestCode.Q120151(c,QuestID);
				case 120152:
					//Kill 55 Mugger Crocodiles in Redcloud Marsh and take the crocodile skin to Weisz.
					if(CanQuest(c,59)) break;
					return QuestCode.Q120152(c,QuestID);
				case 120153:
					//Ask Angelo the where Atwood is.
					if(CanQuest(c,60)) break;
					return QuestCode.Q120153(c,QuestID);
				case 120154:
					//Ask Omar to make some potions that can remove petrification.
					if(CanQuest(c,60)) break;
					return QuestCode.Q120154(c,QuestID);
				case 120155:
					//Catch 60 Stone Lizards in Darkwind Canyon and bring them back to Omar.
					if(CanQuest(c,60)) break;
					return QuestCode.Q120155(c,QuestID);
				case 120156:
					//Kill 60 Darkwind Wolves in Darkwind Canyon and then tell Bertha.
					if(CanQuest(c,61)) break;
					return QuestCode.Q120156(c,QuestID);
				case 120157:
					//Find Morgan, ask him to identify the thing Bertha just dug out.
					if(CanQuest(c,61)) break;
					return QuestCode.Q120157(c,QuestID);
				case 120158:
					//Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Morgan.
					if(CanQuest(c,61)) break;
					return QuestCode.Q120158(c,QuestID);
				case 120159:
					//Ask Atwood about being smashed.
					if(CanQuest(c,62)) break;
					return QuestCode.Q120159(c,QuestID);
				case 120160:
					//Ask Bella what kind of beast Black Dot is.
					if(CanQuest(c,62)) break;
					return QuestCode.Q120160(c,QuestID);
				case 120161:
					//Kill 60 Canyon Eagles in Darkwind Canyon and then tell Bella.
					if(CanQuest(c,62)) break;
					return QuestCode.Q120161(c,QuestID);
				case 120162:
					//Ask Angelo why Canyon Eagle attacked human.
					if(CanQuest(c,63)) break;
					return QuestCode.Q120162(c,QuestID);
				case 120163:
					//Kill 60 Canyon Centaurs in Darkwind Canyon and then tell Angelo.
					if(CanQuest(c,63)) break;
					return QuestCode.Q120163(c,QuestID);
				case 120164:
					//Ask Omar if there\'s anything that can help Jeffrey to sleep.
					if(CanQuest(c,63)) break;
					return QuestCode.Q120164(c,QuestID);
				case 120165:
					//Catch 60 Stone Lizards in Darkwind Canyon and bring them back to Omar.
					if(CanQuest(c,63)) break;
					return QuestCode.Q120165(c,QuestID);
				case 120166:
					//Ask Bertha what kind of pact with beast she wants.
					if(CanQuest(c,64)) break;
					return QuestCode.Q120166(c,QuestID);
				case 120167:
					//Tell Theodore Bertha\'s decision.
					if(CanQuest(c,64)) break;
					return QuestCode.Q120167(c,QuestID);
				case 120168:
					//Catch 60 Darkwind Hunters in Darkwind Canyon and bring them back to Theodore.
					if(CanQuest(c,64)) break;
					return QuestCode.Q120168(c,QuestID);
				case 120169:
					//Ask Jeffrey if there\'s a way to calm down the wolves in the canyon.
					if(CanQuest(c,65)) break;
					return QuestCode.Q120169(c,QuestID);
				case 120170:
					//Kill 65 Darkwind Wolves in Darkwind Canyon and then report to Jeffrey.
					if(CanQuest(c,65)) break;
					return QuestCode.Q120170(c,QuestID);
				case 120171:
					//Tell Angelo about Jeffrey\'s warning, asking him not to confront the werewolves directly.
					if(CanQuest(c,65)) break;
					return QuestCode.Q120171(c,QuestID);
				case 120172:
					//Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Veronica.
					if(CanQuest(c,66)) break;
					return QuestCode.Q120172(c,QuestID);
				case 120173:
					//Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Veronica.
					if(CanQuest(c,66)) break;
					return QuestCode.Q120173(c,QuestID);
				case 120174:
					//Catch 65 Darkwind Eagles in Darkwind Canyon and bring them back to Veronica.
					if(CanQuest(c,66)) break;
					return QuestCode.Q120174(c,QuestID);
				case 120175:
					//Ask Alger about how to deal with Canyon Centaur.
					if(CanQuest(c,67)) break;
					return QuestCode.Q120175(c,QuestID);
				case 120176:
					//Kill 3 Head Centaurs in Darkwind Canyon and then tell Alger.
					if(CanQuest(c,67)) break;
					return QuestCode.Q120176(c,QuestID);
				case 120177:
					//Kill 65 Canyon Centaurs in Darkwind Canyon and then tell Alger.
					if(CanQuest(c,67)) break;
					return QuestCode.Q120177(c,QuestID);
				case 120178:
					//Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Omar.
					if(CanQuest(c,68)) break;
					return QuestCode.Q120178(c,QuestID);
				case 120179:
					//Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Omar.
					if(CanQuest(c,68)) break;
					return QuestCode.Q120179(c,QuestID);
				case 120180:
					//Catch 65 Stone Lizards in Darkwind Canyon and bring them back to Omar.
					if(CanQuest(c,68)) break;
					return QuestCode.Q120180(c,QuestID);
				case 120181:
					//Ask Omar if there\'s a way to make a potion that contains wind element.
					if(CanQuest(c,69)) break;
					return QuestCode.Q120181(c,QuestID);
				case 120182:
					//Catch 65 Canyon Eagles in Darkwind Canyon and bring them back to Omar.
					if(CanQuest(c,69)) break;
					return QuestCode.Q120182(c,QuestID);
				case 120183:
					//Bring the wind crystal stone made by Omar to Amos.
					if(CanQuest(c,69)) break;
					return QuestCode.Q120183(c,QuestID);
				case 120184:
					//Ask Gavin whether beasts to be used in this year\'s Beast\'s Festival are ready.
					if(CanQuest(c,70)) break;
					return QuestCode.Q120184(c,QuestID);
				case 120185:
					//Kill 70 Foggy Vampires in Foggy Forest and bring them back to Francis.
					if(CanQuest(c,70)) break;
					return QuestCode.Q120185(c,QuestID);
				case 120186:
					//Bring the Foggy Vampire trained by Gavin to Francis.
					if(CanQuest(c,70)) break;
					return QuestCode.Q120186(c,QuestID);
				case 120187:
					//Help Cesar to ask Xaviera if she received the gift.
					if(CanQuest(c,71)) break;
					return QuestCode.Q120187(c,QuestID);
				case 120188:
					//Kill 70 Foggy Bears in Foggy Forest and then tell Xaviera.
					if(CanQuest(c,71)) break;
					return QuestCode.Q120188(c,QuestID);
				case 120189:
					//Collect 6 Foggy Roses in Foggy Forest and bring them back to Xaviera.
					if(CanQuest(c,71)) break;
					return QuestCode.Q120189(c,QuestID);
				case 120190:
					//Kill 70 Foggy Spiders in Foggy Forest and bring them back to Cyril.
					if(CanQuest(c,72)) break;
					return QuestCode.Q120190(c,QuestID);
				case 120191:
					//Bring the fried spider leg made by Cyril to Claire.
					if(CanQuest(c,72)) break;
					return QuestCode.Q120191(c,QuestID);
				case 120192:
					//Catch 70 Foggy Bears in Foggy Forest and bring them back to Claire.
					if(CanQuest(c,72)) break;
					return QuestCode.Q120192(c,QuestID);
				case 120193:
					//Ask Jabman to make a Promotion Test for you.
					if(CanQuest(c,73)) break;
					return QuestCode.Q120193(c,QuestID);
				case 120194:
					//Kill 70 Foggy Vampires in Foggy Forest and them tell Jabman.
					if(CanQuest(c,73)) break;
					return QuestCode.Q120194(c,QuestID);
				case 120195:
					//Kill 5 Head Berserks in Foggy Forest and then tell Jabman.
					if(CanQuest(c,73)) break;
					return QuestCode.Q120195(c,QuestID);
				case 120196:
					//Kill 70 Dawn Elves in Foggy Forest and then tell Gavin.
					if(CanQuest(c,74)) break;
					return QuestCode.Q120196(c,QuestID);
				case 120197:
					//Tell Dark Castle\'s Jabman about Gavin\'s finding.
					if(CanQuest(c,74)) break;
					return QuestCode.Q120197(c,QuestID);
				case 120198:
					//Kill 70 Berserk Warriors in Foggy Forest and then tell Teddy.
					if(CanQuest(c,74)) break;
					return QuestCode.Q120198(c,QuestID);
				case 120199:
					//Go to Dark Castle and ask Inquiry how to solve the problem of too cold to sleep.
					if(CanQuest(c,75)) break;
					return QuestCode.Q120199(c,QuestID);
				case 120200:
					//Kill 75 Foggy Spiders in Foggy Forest and bring them back to Zelene.
					if(CanQuest(c,75)) break;
					return QuestCode.Q120200(c,QuestID);
				case 120201:
					//Bring the cobweb extracted by Zelene to Candice.
					if(CanQuest(c,75)) break;
					return QuestCode.Q120201(c,QuestID);
				case 120202:
					//Ask Gavin for a batch of magic scrolls.
					if(CanQuest(c,76)) break;
					return QuestCode.Q120202(c,QuestID);
				case 120203:
					//Catch 75 Foggy Bears in Foggy Forest and bring them back to Gavin.
					if(CanQuest(c,76)) break;
					return QuestCode.Q120203(c,QuestID);
				case 120204:
					//Bring the foggy bear fur made by Gavin to Yuna.
					if(CanQuest(c,76)) break;
					return QuestCode.Q120204(c,QuestID);
				case 120205:
					//Catch 75 Berserk Warriors in Foggy Forest and bring them back to Parker.
					if(CanQuest(c,77)) break;
					return QuestCode.Q120205(c,QuestID);
				case 120206:
					//Catch 5 Head Berserks in Foggy Forest and bring them back to Parker.
					if(CanQuest(c,77)) break;
					return QuestCode.Q120206(c,QuestID);
				case 120207:
					//Tell Claymond about Parker\'s finding.
					if(CanQuest(c,77)) break;
					return QuestCode.Q120207(c,QuestID);
				case 120208:
					//Tell Dark about Jabman\'s instructions.
					if(CanQuest(c,78)) break;
					return QuestCode.Q120208(c,QuestID);
				case 120209:
					//Catch 3000 Foggy Vampires in Foggy Forest and bring them back to Dark.
					if(CanQuest(c,78)) break;
					return QuestCode.Q120209(c,QuestID);
				case 120210:
					//Tell Jabman that Dark is training Foggy Vampire.
					if(CanQuest(c,78)) break;
					return QuestCode.Q120210(c,QuestID);
				case 120211:
					//Ask Jabman how to break through the magic barrier.
					if(CanQuest(c,79)) break;
					return QuestCode.Q120211(c,QuestID);
				case 120212:
					//Catch 75 Foggy Spiders in Foggy Forest and bring them back to Jabman.
					if(CanQuest(c,79)) break;
					return QuestCode.Q120212(c,QuestID);
				case 120213:
					//Bring the Foggy Spider trained by Jabman to Gavin.
					if(CanQuest(c,79)) break;
					return QuestCode.Q120213(c,QuestID);
				case 120214:
					//Help Isaac to ask Jonas if he had any new findings.
					if(CanQuest(c,80)) break;
					return QuestCode.Q120214(c,QuestID);
				case 120215:
					//Catch 80 Lost Acolytes on the Henan Mountainside and bring them to Jonas.
					if(CanQuest(c,80)) break;
					return QuestCode.Q120215(c,QuestID);
				case 120216:
					//Go to Henan Mountain and tell Isaac Jonas\'s discovery.
					if(CanQuest(c,80)) break;
					return QuestCode.Q120216(c,QuestID);
				case 120217:
					//Follow Marlon\'s order and go to Henan Mountainside to find Nate.
					if(CanQuest(c,81)) break;
					return QuestCode.Q120217(c,QuestID);
				case 120218:
					//Catch 80 Carefree Beasts on the Henan Mountainside and bring them to Nate.
					if(CanQuest(c,81)) break;
					return QuestCode.Q120218(c,QuestID);
				case 120219:
					//Give Marlon the Carefree Beast\'s Blood that collected by Nade.
					if(CanQuest(c,81)) break;
					return QuestCode.Q120219(c,QuestID);
				case 120220:
					//Ask Lance about the way of making Crystal for Kim.
					if(CanQuest(c,82)) break;
					return QuestCode.Q120220(c,QuestID);
				case 120221:
					//Catch 80 Spirit Dragons on the Henan Mountainside and bring them to Lance.
					if(CanQuest(c,82)) break;
					return QuestCode.Q120221(c,QuestID);
				case 120222:
					//Give Kim the Crystal made by Lance.
					if(CanQuest(c,82)) break;
					return QuestCode.Q120222(c,QuestID);
				case 120223:
					//Ask Mitchell about the way of keeping scent for Grace.
					if(CanQuest(c,83)) break;
					return QuestCode.Q120223(c,QuestID);
				case 120224:
					//Catch 80 Carefree Beasts on the Henan Mountainside and bring them to Mitchell.
					if(CanQuest(c,83)) break;
					return QuestCode.Q120224(c,QuestID);
				case 120225:
					//Give Grace the perfume made by Mitchell.
					if(CanQuest(c,83)) break;
					return QuestCode.Q120225(c,QuestID);
				case 120226:
					//Defeat 30 Dark Carefree Beasts on the Henan Moutainside then go back and tell Jeremy.
					if(CanQuest(c,84)) break;
					return QuestCode.Q120226(c,QuestID);
				case 120227:
					//Ask Isaac about the reason why the Dark Carefree Beast went mad for Jeremy.
					if(CanQuest(c,84)) break;
					return QuestCode.Q120227(c,QuestID);
				case 120228:
					//Go to Henan Mountain and tell Jeremy Isaac\'s warning.
					if(CanQuest(c,84)) break;
					return QuestCode.Q120228(c,QuestID);
				case 120229:
					//Ask Marlon about how to repair the armor for Kelly.
					if(CanQuest(c,85)) break;
					return QuestCode.Q120229(c,QuestID);
				case 120230:
					//Catch 85 Skyish Beasts on the Henan Mountainside and bring them to Marlon.
					if(CanQuest(c,85)) break;
					return QuestCode.Q120230(c,QuestID);
				case 120231:
					//Give the armor that fixed by Markon to Kelly.
					if(CanQuest(c,85)) break;
					return QuestCode.Q120231(c,QuestID);
				case 120232:
					//Ask Jonas about the way of making magic gloves for Nate.
					if(CanQuest(c,86)) break;
					return QuestCode.Q120232(c,QuestID);
				case 120233:
					//Catch 85 Bubble Beasts on the Henan Mountainside and bring them to Jonas.
					if(CanQuest(c,86)) break;
					return QuestCode.Q120233(c,QuestID);
				case 120234:
					//Give the magic gloves that made by Jonas to Nate.
					if(CanQuest(c,86)) break;
					return QuestCode.Q120234(c,QuestID);
				case 120235:
					//Ask Jared about the way to treat red rash for Grace.
					if(CanQuest(c,87)) break;
					return QuestCode.Q120235(c,QuestID);
				case 120236:
					//Catch 85 Skyish Beasts on the Henan Mountainside and bring them to Jared.
					if(CanQuest(c,87)) break;
					return QuestCode.Q120236(c,QuestID);
				case 120237:
					//Give Grace the perfume made by Jared.
					if(CanQuest(c,87)) break;
					return QuestCode.Q120237(c,QuestID);
				case 120238:
					//Kill 85 Carefree Beasts on the Henan Mountainside then go back and report to Jeremy.
					if(CanQuest(c,88)) break;
					return QuestCode.Q120238(c,QuestID);
				case 120239:
					//Kill 85 Spirit Dragons on the Henan Mountainside then go back and report to Jeremy.
					if(CanQuest(c,88)) break;
					return QuestCode.Q120239(c,QuestID);
				case 120240:
					//Kill 30 Dark Carefree Beasts on the Henan Moutainside then go back and tell Jeremy.
					if(CanQuest(c,88)) break;
					return QuestCode.Q120240(c,QuestID);
				case 120241:
					//Catch 85 Spirit Dragons on the Henan Mountainside and bring them to Jared.
					if(CanQuest(c,89)) break;
					return QuestCode.Q120241(c,QuestID);
				case 120242:
					//Give Mitchell Jared\'s Dragon Scale.
					if(CanQuest(c,89)) break;
					return QuestCode.Q120242(c,QuestID);
				case 120243:
					//Give Jared the Dragon Scale Shield made by Mitchell.
					if(CanQuest(c,89)) break;
					return QuestCode.Q120243(c,QuestID);
				case 129001:
					//Ask General Mandel the origin of Zodiac Wings.
					if(CanQuest(c,25)) break;
					return QuestCode.Q129001(c,QuestID);
				case 129002:
					//Kill the man of specified constellation to get starsoul with specified attribute. When the total fusion level of the attribute constellation reaches lv.4, star wings will be unlocked.
					if(CanQuest(c,25)) break;
					return QuestCode.Q129002(c,QuestID);
				case 129004:
					//Top up once and get your reward from Edith.
					if(CanQuest(c,22)) break;
					return QuestCode.Q129004(c,QuestID);
				case 129011:
					//Find Edith for Charles.
					if(CanQuest(c,25)) break;
					return QuestCode.Q129011(c,QuestID);
				case 129016:
					//Go to City of Genesis, upgrade your level at Stargazer Goya.
					if(CanQuest(c,27)) break;
					return QuestCode.Q129016(c,QuestID);
				case 129017:
					//Enter Stargazer\'s Tower, defeat one Puppet Man·Green and one Puppet Mage·Green, then find Goya to complete the quest.
					if(CanQuest(c,27)) break;
					return QuestCode.Q129017(c,QuestID);
				case 129019:
					//Enter Zodiac Dream1, defeat Little Suslik*2 and Green Gulu*2, then find Jason to complete the quest.
					if(CanQuest(c,30)) break;
					return QuestCode.Q129019(c,QuestID);
				case 130001:
					//Enter Dawn Pier, kill Meister Warlock*4, Meister Guard*4, Blade Master·Gudark*1, then report to Jeff.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130001(c,QuestID);
				case 130002:
					//Enter Sky City, kill Sky Crocodile*6, Cloud Dragon*6, Sky Mask*6, Faux· Emohill*1, then report to Beryl.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130002(c,QuestID);
				case 130003:
					//Go to 4 God Temple, kill 5 Priest of Fear, 5 Priest of Envy, 1 Priest of Greed, 1 Oracle of Pride, and then report to Blanche.
					if(CanQuest(c,34)) break;
					return QuestCode.Q130003(c,QuestID);
				case 130005:
					//Go to Blade Hill, defeat 4 Sword\'s Slaves, 4 Spirit Beasts, 1 Sword!$Starry Sky, 1 Sword!$Moonlight, then report to Aubrey.
					if(CanQuest(c,40)) break;
					return QuestCode.Q130005(c,QuestID);
				case 130006:
					//Go to Holy Land, defeat 5 Battle Spirit, 5 Sage Mentors, 1 Mentor!$Swift, 1 Shine\'s Father, then report to Adonis.
					if(CanQuest(c,46)) break;
					return QuestCode.Q130006(c,QuestID);
				case 130007:
					//Go to Holy Fire Origin, defeat 5 Life Element, 5 Death Element, 1 War God\'s Image, 1 War God\'s Image, then report to Barton.
					if(CanQuest(c,52)) break;
					return QuestCode.Q130007(c,QuestID);
				case 130009:
					//Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
					if(CanQuest(c,28)) break;
					return QuestCode.Q130009(c,QuestID);
				case 130010:
					//Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
					if(CanQuest(c,28)) break;
					return QuestCode.Q130010(c,QuestID);
				case 130011:
					//Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
					if(CanQuest(c,28)) break;
					return QuestCode.Q130011(c,QuestID);
				case 130022:
					//Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
					if(CanQuest(c,31)) break;
					return QuestCode.Q130022(c,QuestID);
				case 130023:
					//Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
					if(CanQuest(c,31)) break;
					return QuestCode.Q130023(c,QuestID);
				case 130024:
					//Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
					if(CanQuest(c,31)) break;
					return QuestCode.Q130024(c,QuestID);
				case 130054:
					//Kill 30 Toothy Gerbil in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130054(c,QuestID);
				case 130055:
					//Kill 30 Toxic Scorpions in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130055(c,QuestID);
				case 130056:
					//Kill 30 Rattlesnakes in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130056(c,QuestID);
				case 130057:
					//Kill 10 Swantony in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130057(c,QuestID);
				case 130058:
					//Kill 40 Dire Wolf in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130058(c,QuestID);
				case 130059:
					//Kill 40 Toothy Gerbil in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130059(c,QuestID);
				case 130060:
					//Kill 10 Benson in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130060(c,QuestID);
				case 130061:
					//Kill 50 Sand Fire Lizards in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130061(c,QuestID);
				case 130062:
					//Kill 50 Trade Wind Foxes in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130062(c,QuestID);
				case 130063:
					//Kill 10 Swantony in Darksand and then tell Lune Oasis\'s Chester.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130063(c,QuestID);
				case 130073:
					//Defeat 30 Toothy Gerbil in Darksand and then tell Darksand\'s Lyle.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130073(c,QuestID);
				case 130074:
					//Defeat 30 Dire Wolves in Darksand and then tell Darksand\'s Lyle.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130074(c,QuestID);
				case 130075:
					//Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130075(c,QuestID);
				case 130076:
					//Defeat 40 Toxic Scorpions in Darksand and then tell Darksand\'s Lyle.
					if(CanQuest(c,35)) break;
					return QuestCode.Q130076(c,QuestID);
				case 130077:
					//Defeat 40 Bactrian Camels in Darksand and then tell Darksand\'s Lyle.
					if(CanQuest(c,35)) break;
					return QuestCode.Q130077(c,QuestID);
				case 130078:
					//Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
					if(CanQuest(c,35)) break;
					return QuestCode.Q130078(c,QuestID);
				case 130079:
					//Defeat 50 Rattlesnakes in Darksand and then tell Darksand\'s Lyle.
					if(CanQuest(c,38)) break;
					return QuestCode.Q130079(c,QuestID);
				case 130080:
					//Defeat 50 Trade Wind Fox in Darksand and then tell Darksand\'s Lyle.
					if(CanQuest(c,38)) break;
					return QuestCode.Q130080(c,QuestID);
				case 130081:
					//Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
					if(CanQuest(c,38)) break;
					return QuestCode.Q130081(c,QuestID);
				case 130082:
					//Kill 30 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130082(c,QuestID);
				case 130083:
					//Kill 30 Man-eating Trees in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130083(c,QuestID);
				case 130084:
					//Kill 30 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130084(c,QuestID);
				case 130085:
					//Kill 10 Baird in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130085(c,QuestID);
				case 130086:
					//Kill 40 Wraith Spiders in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130086(c,QuestID);
				case 130087:
					//Kill 40 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130087(c,QuestID);
				case 130088:
					//Kill 10 Archer in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130088(c,QuestID);
				case 130089:
					//Kill 50 Mud Monsters in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130089(c,QuestID);
				case 130090:
					//Kill 50 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130090(c,QuestID);
				case 130091:
					//Kill 10 Baird in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130091(c,QuestID);
				case 130101:
					//Defeat 30 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130101(c,QuestID);
				case 130102:
					//Defeat 30 Wraith Spiders in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130102(c,QuestID);
				case 130103:
					//Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(CanQuest(c,41)) break;
					return QuestCode.Q130103(c,QuestID);
				case 130104:
					//Defeat 40 Man-eating Tree in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(CanQuest(c,45)) break;
					return QuestCode.Q130104(c,QuestID);
				case 130105:
					//Defeat 40 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(CanQuest(c,45)) break;
					return QuestCode.Q130105(c,QuestID);
				case 130106:
					//Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(CanQuest(c,45)) break;
					return QuestCode.Q130106(c,QuestID);
				case 130107:
					//Defeat 50 Mud Monsters in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(CanQuest(c,48)) break;
					return QuestCode.Q130107(c,QuestID);
				case 130108:
					//Defeat 50 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(CanQuest(c,48)) break;
					return QuestCode.Q130108(c,QuestID);
				case 130109:
					//Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(CanQuest(c,48)) break;
					return QuestCode.Q130109(c,QuestID);
				case 130110:
					//Enter Dawn Pier, kill Meister Swordsman*4, Head Warlock Karl*1, Lead Guard Danton*1, then go to City of Genesis and tell Burton.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130110(c,QuestID);
				case 130111:
					//Enter Sky City, kill Kamaitachi*6, Cloud Elf*6, Head Sky Crocodile*1, Cloud Elf King*1, then go to City of Genesis and tell Burton.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130111(c,QuestID);
				case 130112:
					//Go to 4 God Temple, kill 5 Priest of Pride, 5 Bishop of Greed, 1 Oracle of Envy, 1 Oracle of Terror, then go back to the City of Genesis and tell Larry.
					if(CanQuest(c,34)) break;
					return QuestCode.Q130112(c,QuestID);
				case 130114:
					//Go to Blade Hill, Defeat 4 Sword\'s Spirit, 4 Fierce Beast, 1 Scabbard!$Chaos, then go back to the City of Genesis and tell Larry.
					if(CanQuest(c,40)) break;
					return QuestCode.Q130114(c,QuestID);
				case 130115:
					//Go to Holy Land, Defeat 5 Element Spirit, 5 Killer Mentors, 1 Mentor!$Fearless, then go back to the City of Genesis and tell Larry.
					if(CanQuest(c,46)) break;
					return QuestCode.Q130115(c,QuestID);
				case 130116:
					//Go to Holy Fire Origin, defeat 5 Light Element, 5 Dark Element, 1 War God\'s Image, 1 Wisdom God\'s Image, then go back to the City of Genesis and tell Larry.
					if(CanQuest(c,52)) break;
					return QuestCode.Q130116(c,QuestID);
				case 130117:
					//Attack Dragon Cave and then report to Quenton.
					if(CanQuest(c,31)) break;
					return QuestCode.Q130117(c,QuestID);
				case 130118:
					//Attack Dragon Cave and then report to Quenton.
					if(CanQuest(c,37)) break;
					return QuestCode.Q130118(c,QuestID);
				case 130119:
					//Attack Dragon Cave and then report to Quenton.
					if(CanQuest(c,47)) break;
					return QuestCode.Q130119(c,QuestID);
				case 130120:
					//Complete Stargazer\'s Tower, then report to Stargazer Goya.
					if(CanQuest(c,31)) break;
					return QuestCode.Q130120(c,QuestID);
				case 130121:
					//Complete Stargazer\'s Tower, then report to Stargazer Goya.
					if(CanQuest(c,36)) break;
					return QuestCode.Q130121(c,QuestID);
				case 130122:
					//Complete Stargazer\'s Tower, then report to Stargazer Goya.
					if(CanQuest(c,46)) break;
					return QuestCode.Q130122(c,QuestID);
				case 130123:
					//Kill 30 Venom Monsters in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130123(c,QuestID);
				case 130124:
					//Kill 30 Short-wing Rats in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130124(c,QuestID);
				case 130125:
					//Kill 30 Medusa in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130125(c,QuestID);
				case 130126:
					//Kill 10 Olive in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130126(c,QuestID);
				case 130127:
					//Kill 40 Short-wing Rats in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130127(c,QuestID);
				case 130128:
					//Kill 40 Mugger Crocodiles in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130128(c,QuestID);
				case 130129:
					//Kill 10 Giant Carrion in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130129(c,QuestID);
				case 130130:
					//Kill 50 Carrion in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130130(c,QuestID);
				case 130131:
					//Kill 50 Medusa in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130131(c,QuestID);
				case 130132:
					//Kill 10 Olive in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130132(c,QuestID);
				case 130136:
					//Defeat 30 Medusa in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130136(c,QuestID);
				case 130137:
					//Defeat 30 Mugger Crocodiles in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130137(c,QuestID);
				case 130138:
					//Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(CanQuest(c,51)) break;
					return QuestCode.Q130138(c,QuestID);
				case 130139:
					//Defeat 40 Venom Monsters in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(CanQuest(c,55)) break;
					return QuestCode.Q130139(c,QuestID);
				case 130140:
					//Defeat 40 Medusa in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(CanQuest(c,55)) break;
					return QuestCode.Q130140(c,QuestID);
				case 130141:
					//Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(CanQuest(c,55)) break;
					return QuestCode.Q130141(c,QuestID);
				case 130142:
					//Defeat 50 Short-wing Rats in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(CanQuest(c,58)) break;
					return QuestCode.Q130142(c,QuestID);
				case 130143:
					//Defeat 50 Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(CanQuest(c,58)) break;
					return QuestCode.Q130143(c,QuestID);
				case 130144:
					//Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(CanQuest(c,58)) break;
					return QuestCode.Q130144(c,QuestID);
				case 130145:
					//Kill 30 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130145(c,QuestID);
				case 130146:
					//Kill 30 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130146(c,QuestID);
				case 130147:
					//Kill 30 Canyon Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130147(c,QuestID);
				case 130148:
					//Kill 10 Shadow Assassins in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130148(c,QuestID);
				case 130149:
					//Kill 40 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130149(c,QuestID);
				case 130150:
					//Kill 40 Stone Lizards in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130150(c,QuestID);
				case 130151:
					//Kill 10 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130151(c,QuestID);
				case 130152:
					//Kill 50 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130152(c,QuestID);
				case 130153:
					//Kill 50 Canyon Eagles in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130153(c,QuestID);
				case 130154:
					//Kill 10 Shadow Assassins in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130154(c,QuestID);
				case 130155:
					//Kill 30 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130155(c,QuestID);
				case 130156:
					//Kill 30 Darkwind Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(CanQuest(c,61)) break;
					return QuestCode.Q130156(c,QuestID);
				case 130157:
					//Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood。
					if(CanQuest(c,61)) break;
					return QuestCode.Q130157(c,QuestID);
				case 130158:
					//Kill 40 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(CanQuest(c,65)) break;
					return QuestCode.Q130158(c,QuestID);
				case 130159:
					//Kill 40 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(CanQuest(c,65)) break;
					return QuestCode.Q130159(c,QuestID);
				case 130160:
					//Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(CanQuest(c,65)) break;
					return QuestCode.Q130160(c,QuestID);
				case 130161:
					//Kill 50 Stone Lizards in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(CanQuest(c,68)) break;
					return QuestCode.Q130161(c,QuestID);
				case 130162:
					//Kill 50 Canyon Eagles in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(CanQuest(c,68)) break;
					return QuestCode.Q130162(c,QuestID);
				case 130163:
					//Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(CanQuest(c,68)) break;
					return QuestCode.Q130163(c,QuestID);
				case 130164:
					//Enter Starsoul instance, kill Ghost Sage·Borg, then go to see Morton.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130164(c,QuestID);
				case 130165:
					//Enter Starsoul instance, use 5 dream points, then go to see Charles.
					if(CanQuest(c,30)) break;
					return QuestCode.Q130165(c,QuestID);
				case 130166:
					//Enter Pharmacy, kill 3 Mana Potion Tyro, 3 HP Potion Tyro, 1 Druggist Kein, then report to Druggist Elo.
					if(CanQuest(c,62)) break;
					return QuestCode.Q130166(c,QuestID);
				case 130167:
					//Enter Pharmacy, kill 3 STR Potion Tyro, 3 DEF Potion Tyro, 1 Druggist Luyer, then back to City of Genesis and tell Burton.
					if(CanQuest(c,62)) break;
					return QuestCode.Q130167(c,QuestID);
				case 130168:
					//Kill 30 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130168(c,QuestID);
				case 130169:
					//Kill 30 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130169(c,QuestID);
				case 130170:
					//Kill 30 Berserk Warriors in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130170(c,QuestID);
				case 130171:
					//Kill 10 Head Berserks in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130171(c,QuestID);
				case 130172:
					//Kill 40 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130172(c,QuestID);
				case 130173:
					//Kill 40 Foggy Spiders in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130173(c,QuestID);
				case 130174:
					//Kill 10 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130174(c,QuestID);
				case 130175:
					//Kill 50 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130175(c,QuestID);
				case 130176:
					//Kill 50 Dawn Elves in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130176(c,QuestID);
				case 130177:
					//Kill 10 Head Berserks in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130177(c,QuestID);
				case 130178:
					//Kill 30 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130178(c,QuestID);
				case 130179:
					//Kill 30 Berserk Warriors in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130179(c,QuestID);
				case 130180:
					//Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(CanQuest(c,71)) break;
					return QuestCode.Q130180(c,QuestID);
				case 130181:
					//Kill 40 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(CanQuest(c,75)) break;
					return QuestCode.Q130181(c,QuestID);
				case 130182:
					//Kill 40 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(CanQuest(c,75)) break;
					return QuestCode.Q130182(c,QuestID);
				case 130183:
					//Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(CanQuest(c,75)) break;
					return QuestCode.Q130183(c,QuestID);
				case 130184:
					//Kill 50 Foggy Spiders in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(CanQuest(c,78)) break;
					return QuestCode.Q130184(c,QuestID);
				case 130185:
					//Kill 50 Dawn Elves in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(CanQuest(c,78)) break;
					return QuestCode.Q130185(c,QuestID);
				case 130186:
					//Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(CanQuest(c,78)) break;
					return QuestCode.Q130186(c,QuestID);
				case 130188:
					//Enter Candy Shop, kill 3 Chocolate Guards, 3 Milk Guards, 1 Tooth Decay King, then report to Alchemist Nami.
					if(CanQuest(c,72)) break;
					return QuestCode.Q130188(c,QuestID);
				case 130189:
					//Enter Candy Shop, kill 3 Mango Milktea Guards, 3 Strawberry Milktea Guards, 1 Biscuit Princess, then back to City of Genesis and tell Burton.
					if(CanQuest(c,72)) break;
					return QuestCode.Q130189(c,QuestID);
				case 130190:
					//Kill 30 Spirit Dragons on the Henan Mountainside then go back and report to Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130190(c,QuestID);
				case 130191:
					//Kill 30 Carefree Beasts on the Henan Mountainside then go back and report to Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130191(c,QuestID);
				case 130192:
					//Kill 30 Lost Acolytes on the Henan Mountainside then go back and report to Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130192(c,QuestID);
				case 130193:
					//Kill 10 Dark Carefree Beasts on the Henan Moutainside then go back and tell Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130193(c,QuestID);
				case 130194:
					//Kill 40 Spirit Dragons on the Henan Mountainside then go back and tell Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130194(c,QuestID);
				case 130195:
					//Kill 40 Bubble Beasts on the Henan Mountainside then go back and tell Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130195(c,QuestID);
				case 130196:
					//Kill 10 Guarder Sissi on the Henan Mountainside then go back and tell Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130196(c,QuestID);
				case 130197:
					//Kill 50 Carefree Beasts on the Henan Mountainside then go back and tell Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130197(c,QuestID);
				case 130198:
					//Kill 50 Skyish Beasts on the Henan Mountainside then go back and tell Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130198(c,QuestID);
				case 130199:
					//Kill 10 Dark Carefree Beasts on the Henan Moutainside then go back and tell Herman.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130199(c,QuestID);
				case 130200:
					//Defeat 30 Carefree Beasts on the Henan Mountainside then go back and report to Mitchell.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130200(c,QuestID);
				case 130201:
					//Defeat 30 Lost Acolytes on the Henan Mountainside then go back and report to Mitchell.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130201(c,QuestID);
				case 130202:
					//Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
					if(CanQuest(c,81)) break;
					return QuestCode.Q130202(c,QuestID);
				case 130203:
					//Defeat 40 Spirit Dragons on the Henan Mountainside then go back and tell Mitchell.
					if(CanQuest(c,85)) break;
					return QuestCode.Q130203(c,QuestID);
				case 130204:
					//Defeat 40 Carefree Beasts on the Henan Mountainside then go back and report to Mitchell.
					if(CanQuest(c,85)) break;
					return QuestCode.Q130204(c,QuestID);
				case 130205:
					//Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
					if(CanQuest(c,85)) break;
					return QuestCode.Q130205(c,QuestID);
				case 130206:
					//Defeat 50 Bubble Beasts on the Henan Mountainside then go back and tell  Mitchell.
					if(CanQuest(c,88)) break;
					return QuestCode.Q130206(c,QuestID);
				case 130207:
					//Defeat 50 Skyish Beasts on the Henan Mountainside then go back and tell Mitchell
					if(CanQuest(c,88)) break;
					return QuestCode.Q130207(c,QuestID);
				case 130208:
					//Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
					if(CanQuest(c,88)) break;
					return QuestCode.Q130208(c,QuestID);
				case 130209:
					//Enter the toy factory, kill 3 Raw Material Buyers, 3 Lost Secretaries and 1 Fallen Earl Charlie then report to Lord Terry .
					if(CanQuest(c,82)) break;
					return QuestCode.Q130209(c,QuestID);
				case 130210:
					//Enter the toy factory, kill 3 QA Inspectors, 3 Lost Guards，and 1 Dark Witch Avri, then go back to City of Genesis and report to Larry.
					if(CanQuest(c,82)) break;
					return QuestCode.Q130210(c,QuestID);
				case 140102:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(CanQuest(c,31)) break;
					return QuestCode.Q140102(c,QuestID);
				case 140103:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(CanQuest(c,36)) break;
					return QuestCode.Q140103(c,QuestID);
				case 140104:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(CanQuest(c,41)) break;
					return QuestCode.Q140104(c,QuestID);
				case 140105:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(CanQuest(c,46)) break;
					return QuestCode.Q140105(c,QuestID);
				case 140106:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(CanQuest(c,51)) break;
					return QuestCode.Q140106(c,QuestID);
				case 140107:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(CanQuest(c,56)) break;
					return QuestCode.Q140107(c,QuestID);
				case 140108:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(CanQuest(c,61)) break;
					return QuestCode.Q140108(c,QuestID);
				case 140109:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(CanQuest(c,66)) break;
					return QuestCode.Q140109(c,QuestID);
				case 140206:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140206(c,QuestID);
				case 140207:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140207(c,QuestID);
				case 140208:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140208(c,QuestID);
				case 140209:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140209(c,QuestID);
				case 140211:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140211(c,QuestID);
				case 140212:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140212(c,QuestID);
				case 140213:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140213(c,QuestID);
				case 140214:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140214(c,QuestID);
				case 140216:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140216(c,QuestID);
				case 140217:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140217(c,QuestID);
				case 140218:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140218(c,QuestID);
				case 140219:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140219(c,QuestID);
				case 140221:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140221(c,QuestID);
				case 140222:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140222(c,QuestID);
				case 140223:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140223(c,QuestID);
				case 140224:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140224(c,QuestID);
				case 140225:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140225(c,QuestID);
				case 140226:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140226(c,QuestID);
				case 140227:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140227(c,QuestID);
				case 140228:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140228(c,QuestID);
				case 140229:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140229(c,QuestID);
				case 140230:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140230(c,QuestID);
				case 140231:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140231(c,QuestID);
				case 140232:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140232(c,QuestID);
				case 140233:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140233(c,QuestID);
				case 140234:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140234(c,QuestID);
				case 140235:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140235(c,QuestID);
				case 140236:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140236(c,QuestID);
				case 140237:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140237(c,QuestID);
				case 140238:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140238(c,QuestID);
				case 140239:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140239(c,QuestID);
				case 140240:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140240(c,QuestID);
				case 140309:
					//Defeat 50 Toothy Gerbils, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140309(c,QuestID);
				case 140310:
					//Defeat 50 Bactrian Camels, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140310(c,QuestID);
				case 140311:
					//Defeat 50 Rattlesnakes, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140311(c,QuestID);
				case 140312:
					//Defeat 50 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140312(c,QuestID);
				case 140313:
					//Defeat 50 Trade Wind Foxes, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140313(c,QuestID);
				case 140314:
					//Defeat 50 Toxic Scorpions, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140314(c,QuestID);
				case 140315:
					//Defeat 50 Sand Fire Lizards, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140315(c,QuestID);
				case 140316:
					//Collect 10 Darkthorn Cactus, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140316(c,QuestID);
				case 140317:
					//Collect 10 Buckthorn Grass, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140317(c,QuestID);
				case 140318:
					//Collect 10 Buckthorn Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140318(c,QuestID);
				case 140319:
					//Collect 10 Darksand Essences, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140319(c,QuestID);
				case 140322:
					//Defeat 60 Toothy Gerbils, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140322(c,QuestID);
				case 140323:
					//Defeat 60 Bactrian Camels, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140323(c,QuestID);
				case 140324:
					//Defeat 60 Rattlesnakes, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140324(c,QuestID);
				case 140325:
					//Defeat 60 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140325(c,QuestID);
				case 140326:
					//Defeat 60 Trade Wind Foxes, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140326(c,QuestID);
				case 140327:
					//Defeat 60 Toxic Scorpions, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140327(c,QuestID);
				case 140328:
					//Defeat 60 Sand Fire Lizards, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140328(c,QuestID);
				case 140329:
					//Collect 10 Darkthorn Cactus, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140329(c,QuestID);
				case 140330:
					//Collect 10 Buckthorn Grass, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140330(c,QuestID);
				case 140331:
					//Collect 10 Buckthorn Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140331(c,QuestID);
				case 140332:
					//Collect 10 Darksand Essences, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140332(c,QuestID);
				case 140335:
					//Defeat 70 Giant Jaw Ants, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140335(c,QuestID);
				case 140336:
					//Defeat 70 Mud Monsters, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140336(c,QuestID);
				case 140337:
					//Defeat 70 Man-eating Trees, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140337(c,QuestID);
				case 140338:
					//Defeat 70 Phantom Monkeys, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140338(c,QuestID);
				case 140339:
					//Defeat 70 Wraith Spiders, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140339(c,QuestID);
				case 140340:
					//Collect 10 Delusion Herbs, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140340(c,QuestID);
				case 140341:
					//Collect 10 Vampire Vines, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140341(c,QuestID);
				case 140342:
					//Collect 10 Luminous Grass, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140342(c,QuestID);
				case 140343:
					//Collect 10 Water Mana Spar, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140343(c,QuestID);
				case 140346:
					//Defeat 80 Giant Jaw Ants, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140346(c,QuestID);
				case 140347:
					//Defeat 80 Mud Monsters, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140347(c,QuestID);
				case 140348:
					//Defeat 80 Man-eating Trees, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140348(c,QuestID);
				case 140349:
					//Defeat 80 Phantom Monkeys, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140349(c,QuestID);
				case 140350:
					//Defeat 80 Wraith Spiders, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140350(c,QuestID);
				case 140351:
					//Collect 10 Delusion Herbs, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140351(c,QuestID);
				case 140352:
					//Collect 10 Vampire Vines, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140352(c,QuestID);
				case 140353:
					//Collect 10 Luminous Grass, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140353(c,QuestID);
				case 140354:
					//Collect 10 Water Mana Spar, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140354(c,QuestID);
				case 140355:
					//Defeat 90 Venom Monsters, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140355(c,QuestID);
				case 140356:
					//Defeat 90 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140356(c,QuestID);
				case 140357:
					//Defeat 90 Medusa, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140357(c,QuestID);
				case 140358:
					//Defeat 90 Mugger Crocodiles, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140358(c,QuestID);
				case 140359:
					//Defeat 90 Carrion, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140359(c,QuestID);
				case 140360:
					//Collect 10 Fluorescent Herbs, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140360(c,QuestID);
				case 140361:
					//Collect 10 Rotten Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140361(c,QuestID);
				case 140362:
					//Collect 10 Greenbell Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140362(c,QuestID);
				case 140363:
					//Defeat 100 Venom Monsters, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140363(c,QuestID);
				case 140364:
					//Defeat 100 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140364(c,QuestID);
				case 140365:
					//Defeat 100 Medusa, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140365(c,QuestID);
				case 140366:
					//Defeat 100 Mugger Crocodiles, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140366(c,QuestID);
				case 140367:
					//Defeat 100 Carrion, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140367(c,QuestID);
				case 140368:
					//Collect 10 Fluorescent Herbs, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140368(c,QuestID);
				case 140369:
					//Collect 10 Rotten Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140369(c,QuestID);
				case 140370:
					//Collect 10 Greenbell Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140370(c,QuestID);
				case 140371:
					//Defeat 110 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140371(c,QuestID);
				case 140372:
					//Defeat 110 Darkwind Hunters, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140372(c,QuestID);
				case 140373:
					//Defeat 110 Canyon Centaurs, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140373(c,QuestID);
				case 140374:
					//Defeat 110 Stone Lizards, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140374(c,QuestID);
				case 140375:
					//Defeat 110 Canyon Eagles, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140375(c,QuestID);
				case 140376:
					//Collect 10 Cruor Grasses, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140376(c,QuestID);
				case 140377:
					//Collect 10 Hyacinths, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140377(c,QuestID);
				case 140378:
					//Defeat 120 Darkwind Wolves, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140378(c,QuestID);
				case 140379:
					//Defeat 120 Darkwind Hunters, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140379(c,QuestID);
				case 140380:
					//Defeat 120 Canyon Centaurs, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140380(c,QuestID);
				case 140381:
					//Defeat 120 Stone Lizards, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140381(c,QuestID);
				case 140382:
					//Defeat 120 Canyon Eagles, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140382(c,QuestID);
				case 140383:
					//Collect 10 Cruor Grasses, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140383(c,QuestID);
				case 140384:
					//Collect 10 Hyacinths, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140384(c,QuestID);
				case 140406:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140406(c,QuestID);
				case 140407:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140407(c,QuestID);
				case 140408:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140408(c,QuestID);
				case 140409:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140409(c,QuestID);
				case 140411:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140411(c,QuestID);
				case 140412:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140412(c,QuestID);
				case 140413:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140413(c,QuestID);
				case 140414:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140414(c,QuestID);
				case 140416:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140416(c,QuestID);
				case 140417:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140417(c,QuestID);
				case 140418:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140418(c,QuestID);
				case 140419:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140419(c,QuestID);
				case 140421:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140421(c,QuestID);
				case 140422:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140422(c,QuestID);
				case 140423:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140423(c,QuestID);
				case 140424:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140424(c,QuestID);
				case 140425:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140425(c,QuestID);
				case 140426:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140426(c,QuestID);
				case 140427:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140427(c,QuestID);
				case 140428:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140428(c,QuestID);
				case 140429:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140429(c,QuestID);
				case 140430:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140430(c,QuestID);
				case 140431:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140431(c,QuestID);
				case 140432:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140432(c,QuestID);
				case 140433:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140433(c,QuestID);
				case 140434:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140434(c,QuestID);
				case 140435:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140435(c,QuestID);
				case 140436:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140436(c,QuestID);
				case 140437:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140437(c,QuestID);
				case 140438:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140438(c,QuestID);
				case 140439:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140439(c,QuestID);
				case 140440:
					//Ask Scarce about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140440(c,QuestID);
				case 140502:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140502(c,QuestID);
				case 140503:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140503(c,QuestID);
				case 140504:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140504(c,QuestID);
				case 140505:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140505(c,QuestID);
				case 140506:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140506(c,QuestID);
				case 140507:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140507(c,QuestID);
				case 140508:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140508(c,QuestID);
				case 140509:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140509(c,QuestID);
				case 140609:
					//Defeat 50 Toothy Gerbils, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140609(c,QuestID);
				case 140610:
					//Defeat 50 Bactrian Camels, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140610(c,QuestID);
				case 140611:
					//Defeat 50 Rattlesnakes, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140611(c,QuestID);
				case 140612:
					//Defeat 50 Dire Wolves, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140612(c,QuestID);
				case 140613:
					//Defeat 50 Trade Wind Foxes, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140613(c,QuestID);
				case 140614:
					//Defeat 50 Toxic Scorpions, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140614(c,QuestID);
				case 140615:
					//Defeat 50 Sand Fire Lizards, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140615(c,QuestID);
				case 140616:
					//Collect 10 Darkthorn Cactuses, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140616(c,QuestID);
				case 140617:
					//Collect 10 Buckthorn Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140617(c,QuestID);
				case 140618:
					//Collect 10 Buckthorn Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140618(c,QuestID);
				case 140619:
					//Collect 10 Darksand Essences, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140619(c,QuestID);
				case 140622:
					//Defeat 60 Toothy Gerbils, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140622(c,QuestID);
				case 140623:
					//Defeat 60 Bactrian Camels, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140623(c,QuestID);
				case 140624:
					//Defeat 60 Rattlesnakes, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140624(c,QuestID);
				case 140625:
					//Defeat 60 Dire Wolves, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140625(c,QuestID);
				case 140626:
					//Defeat 60 Trade Wind Foxes, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140626(c,QuestID);
				case 140627:
					//Defeat 60 Toxic Scorpions, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140627(c,QuestID);
				case 140628:
					//Defeat 60 Sand Fire Lizards, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140628(c,QuestID);
				case 140629:
					//Collect 10 Darkthorn Cactuses, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140629(c,QuestID);
				case 140630:
					//Collect 10 Buckthorn Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140630(c,QuestID);
				case 140631:
					//Collect 10 Buckthorn Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140631(c,QuestID);
				case 140632:
					//Collect 10 Darksand Essences, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140632(c,QuestID);
				case 140635:
					//Defeat 70 Giant Jaw Ants, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140635(c,QuestID);
				case 140636:
					//Defeat 70 Mud Monsters, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140636(c,QuestID);
				case 140637:
					//Defeat 70 Man-eating Trees, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140637(c,QuestID);
				case 140638:
					//Defeat 70 Phantom Monkeys, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140638(c,QuestID);
				case 140639:
					//Defeat 70 Wraith Spiders, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140639(c,QuestID);
				case 140640:
					//Collect 10 Delusion Herbs, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140640(c,QuestID);
				case 140641:
					//Collect 10 Vampire Vines, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140641(c,QuestID);
				case 140642:
					//Collect 10 Luminous Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140642(c,QuestID);
				case 140643:
					//Collect 10 Water Mana Spars, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140643(c,QuestID);
				case 140646:
					//Defeat 80 Giant Jaw Ants, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140646(c,QuestID);
				case 140647:
					//Defeat 80 Mud Monsters, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140647(c,QuestID);
				case 140648:
					//Defeat 80 Man-eating Trees, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140648(c,QuestID);
				case 140649:
					//Defeat 80 Phantom Monkeys, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140649(c,QuestID);
				case 140650:
					//Defeat 80 Wraith Spiders, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140650(c,QuestID);
				case 140651:
					//Collect 10 Delusion Herbs, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140651(c,QuestID);
				case 140652:
					//Collect 10 Vampire Vines, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140652(c,QuestID);
				case 140653:
					//Collect 10 Luminous Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140653(c,QuestID);
				case 140654:
					//Collect 10 Water Mana Spars, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140654(c,QuestID);
				case 140655:
					//Defeat 90 Venom Monsters, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140655(c,QuestID);
				case 140656:
					//Defeat 90 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140656(c,QuestID);
				case 140657:
					//Defeat 90 Medusa, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140657(c,QuestID);
				case 140658:
					//Defeat 90 Mugger Crocodiles, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140658(c,QuestID);
				case 140659:
					//Defeat 90 Carrions, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140659(c,QuestID);
				case 140660:
					//Collect 10 Fluorescent Herbs, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140660(c,QuestID);
				case 140661:
					//Collect 10 Rotten Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140661(c,QuestID);
				case 140662:
					//Defeat 100 Venom Monsters, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140662(c,QuestID);
				case 140663:
					//Defeat 100 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140663(c,QuestID);
				case 140664:
					//Defeat 100 Medusa, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140664(c,QuestID);
				case 140665:
					//Defeat 100 Mugger Crocodiles, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140665(c,QuestID);
				case 140666:
					//Defeat 100 Carrions, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140666(c,QuestID);
				case 140667:
					//Collect 10 Fluorescent Herbs, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140667(c,QuestID);
				case 140668:
					//Collect 10 Rotten Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140668(c,QuestID);
				case 140669:
					//Collect 10 Greenbell Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140669(c,QuestID);
				case 140670:
					//Defeat 110 Darkwind Wolves, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140670(c,QuestID);
				case 140671:
					//Defeat 110 Darkwind Hunters, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140671(c,QuestID);
				case 140672:
					//Defeat 110 Canyon Centaurs, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140672(c,QuestID);
				case 140673:
					//Defeat 110 Stone Lizards, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140673(c,QuestID);
				case 140674:
					//Defeat 110 Canyon Eagles, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140674(c,QuestID);
				case 140675:
					//Collect 10 Cruor Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140675(c,QuestID);
				case 140676:
					//Collect 10 Hyacinths, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140676(c,QuestID);
				case 140677:
					//Defeat 120 Darkwind Wolves, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140677(c,QuestID);
				case 140678:
					//Defeat 120 Darkwind Hunters, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140678(c,QuestID);
				case 140679:
					//Defeat 120 Canyon Centaurs, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140679(c,QuestID);
				case 140680:
					//Defeat 120 Stone Lizards, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140680(c,QuestID);
				case 140681:
					//Defeat 120 Canyon Eagles, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140681(c,QuestID);
				case 140682:
					//Collect 10 Cruor Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140682(c,QuestID);
				case 140683:
					//Collect 10 Hyacinths, then go to City of Rage, ask Cliff about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140683(c,QuestID);
				case 140706:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140706(c,QuestID);
				case 140707:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140707(c,QuestID);
				case 140708:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140708(c,QuestID);
				case 140709:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140709(c,QuestID);
				case 140711:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140711(c,QuestID);
				case 140712:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140712(c,QuestID);
				case 140713:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140713(c,QuestID);
				case 140714:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140714(c,QuestID);
				case 140716:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140716(c,QuestID);
				case 140717:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140717(c,QuestID);
				case 140718:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140718(c,QuestID);
				case 140719:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140719(c,QuestID);
				case 140721:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140721(c,QuestID);
				case 140722:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140722(c,QuestID);
				case 140723:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140723(c,QuestID);
				case 140724:
					//Go to Glory City, ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140724(c,QuestID);
				case 140725:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140725(c,QuestID);
				case 140726:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140726(c,QuestID);
				case 140727:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140727(c,QuestID);
				case 140728:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140728(c,QuestID);
				case 140729:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140729(c,QuestID);
				case 140730:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140730(c,QuestID);
				case 140731:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140731(c,QuestID);
				case 140732:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140732(c,QuestID);
				case 140733:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140733(c,QuestID);
				case 140734:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140734(c,QuestID);
				case 140735:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140735(c,QuestID);
				case 140736:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140736(c,QuestID);
				case 140737:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140737(c,QuestID);
				case 140738:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140738(c,QuestID);
				case 140739:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140739(c,QuestID);
				case 140740:
					//Ask Kon about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140740(c,QuestID);
				case 140806:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140806(c,QuestID);
				case 140807:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140807(c,QuestID);
				case 140808:
					//Go to Glory City, ask Minny about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140808(c,QuestID);
				case 140809:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140809(c,QuestID);
				case 140811:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140811(c,QuestID);
				case 140812:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140812(c,QuestID);
				case 140813:
					//Go to Glory City, ask Minny about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140813(c,QuestID);
				case 140814:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140814(c,QuestID);
				case 140816:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140816(c,QuestID);
				case 140817:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140817(c,QuestID);
				case 140818:
					//Go to Glory City, ask Minny about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140818(c,QuestID);
				case 140819:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140819(c,QuestID);
				case 140821:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140821(c,QuestID);
				case 140822:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140822(c,QuestID);
				case 140823:
					//Go to Glory City, ask Minny about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140823(c,QuestID);
				case 140824:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140824(c,QuestID);
				case 140825:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140825(c,QuestID);
				case 140826:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140826(c,QuestID);
				case 140827:
					//Go to Glory City, ask Minny about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140827(c,QuestID);
				case 140828:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140828(c,QuestID);
				case 140829:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140829(c,QuestID);
				case 140830:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140830(c,QuestID);
				case 140831:
					//Go to Glory City, ask Minny about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140831(c,QuestID);
				case 140832:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140832(c,QuestID);
				case 140833:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140833(c,QuestID);
				case 140834:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140834(c,QuestID);
				case 140835:
					//Go to Glory City, ask Minny about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140835(c,QuestID);
				case 140836:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140836(c,QuestID);
				case 140837:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140837(c,QuestID);
				case 140838:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140838(c,QuestID);
				case 140839:
					//Go to Glory City, ask Minny about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140839(c,QuestID);
				case 140840:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140840(c,QuestID);
				case 140903:
					//Defeat 15 Swantony, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140903(c,QuestID);
				case 140904:
					//Defeat 15 Benson, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140904(c,QuestID);
				case 140905:
					//Defeat 15 Swantony, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140905(c,QuestID);
				case 140906:
					//Defeat 15 Benson, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140906(c,QuestID);
				case 140907:
					//Defeat 15 Baird, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140907(c,QuestID);
				case 140908:
					//Defeat 15 Archer, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140908(c,QuestID);
				case 140909:
					//Defeat 15 Baird, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140909(c,QuestID);
				case 140910:
					//Defeat 15 Archer, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140910(c,QuestID);
				case 140911:
					//Defeat 15 Olive, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140911(c,QuestID);
				case 140912:
					//Defeat 15 Giant Carrion, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140912(c,QuestID);
				case 140913:
					//Defeat 15 Olive, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140913(c,QuestID);
				case 140914:
					//Defeat 15 Giant Carrion, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140914(c,QuestID);
				case 140915:
					//Defeat 15 Shadow Assassins, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140915(c,QuestID);
				case 140916:
					//Defeat 15 Head Centaurs, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140916(c,QuestID);
				case 140917:
					//Defeat 15 Shadow Assassins, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140917(c,QuestID);
				case 140918:
					//Defeat 15 Head Centaurs, then go to City of Rage, ask Marie about the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q140918(c,QuestID);
				case 141002:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q141002(c,QuestID);
				case 141003:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q141003(c,QuestID);
				case 141004:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q141004(c,QuestID);
				case 141005:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q141005(c,QuestID);
				case 141006:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q141006(c,QuestID);
				case 141007:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q141007(c,QuestID);
				case 141008:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q141008(c,QuestID);
				case 141009:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(CanQuest(c,200)) break;
					return QuestCode.Q141009(c,QuestID);
				case 150001:
					//Accept Zodiac Temple\'s order, kill any monster*20 at Lune Oasis.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150001(c,QuestID);
				case 150002:
					//Accept Zodiac Temple\'s order, kill any monster*40 at Lune Oasis.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150002(c,QuestID);
				case 150003:
					//Accept Zodiac Temple\'s order, kill any monster*60 at Lune Oasis.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150003(c,QuestID);
				case 150004:
					//Accept Zodiac Temple\'s order, kill any monster*80 at Lune Oasis.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150004(c,QuestID);
				case 150005:
					//Accept Zodiac Temple\'s order, kill any monster*100 at Lune Oasis.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150005(c,QuestID);
				case 150006:
					//Accept Zodiac Temple\'s order, kill any monster*30 at Darksand.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150006(c,QuestID);
				case 150007:
					//Accept Zodiac Temple\'s order, kill any monster*60 at Darksand.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150007(c,QuestID);
				case 150008:
					//Accept Zodiac Temple\'s order, kill any monster*90 at Darksand.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150008(c,QuestID);
				case 150009:
					//Accept Zodiac Temple\'s order, kill any monster*120 at Darksand.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150009(c,QuestID);
				case 150010:
					//Accept Zodiac Temple\'s order, any monster*150 at Darksand.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150010(c,QuestID);
				case 150011:
					//Accept Zodiac Temple\'s order, kill any monster*50 in Vine Rainforest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150011(c,QuestID);
				case 150012:
					//Accept Zodiac Temple\'s order, kill any monster*100 in Vine Rainforest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150012(c,QuestID);
				case 150013:
					//Accept Zodiac Temple\'s order, kill any monster*150 in Vine Rainforest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150013(c,QuestID);
				case 150014:
					//Accept Zodiac Temple\'s order, kill any monster*200 in Vine Rainforest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150014(c,QuestID);
				case 150015:
					//Accept Zodiac Temple\'s order, kill any monster*250 in Vine Rainforest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150015(c,QuestID);
				case 150016:
					//Accept Zodiac Temple\'s order, kill any monster*50 in Redcloud Marsh.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150016(c,QuestID);
				case 150017:
					//Accept Zodiac Temple\'s order,kill any monster*100 in Redcloud Marsh.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150017(c,QuestID);
				case 150018:
					//Accept Zodiac Temple\'s order, kill any monster*150 in Redcloud Marsh.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150018(c,QuestID);
				case 150019:
					//Accept Zodiac Temple\'s order, kill any monster*200 in Redcloud Marsh.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150019(c,QuestID);
				case 150020:
					//Accept Zodiac Temple\'s order, kill any monster*250 in Redcloud Marsh.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150020(c,QuestID);
				case 150021:
					//Accept Zodiac Temple\'s order, kill any monster*50 in Darkwind Canyon.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150021(c,QuestID);
				case 150022:
					//Accept Zodiac Temple\'s order, kill any monster*100 in Darkwind Canyon.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150022(c,QuestID);
				case 150023:
					//Accept Zodiac Temple\'s order, kill any monster*150 in Darkwind Canyon.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150023(c,QuestID);
				case 150024:
					//Accept Zodiac Temple\'s order, kill any monster*200 in Darkwind Canyon.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150024(c,QuestID);
				case 150025:
					//Accept Zodiac Temple\'s order, kill any monster*250 in Darkwind Canyon.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150025(c,QuestID);
				case 150026:
					//Accept Zodiac Temple\'s order, kill any monster*50 in Foggy Forest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150026(c,QuestID);
				case 150027:
					//Accept Zodiac Temple\'s order, kill any monster*100 in Foggy Forest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150027(c,QuestID);
				case 150028:
					//Accept Zodiac Temple\'s order, kill any monster*150 in Foggy Forest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150028(c,QuestID);
				case 150029:
					//Accept Zodiac Temple\'s order, kill any monster*200 in Foggy Forest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150029(c,QuestID);
				case 150030:
					//Accept Zodiac Temple\'s order, kill any monster*250 in Foggy Forest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150030(c,QuestID);
				case 150031:
					//Accept Zodiac Temple\'s order, any monster*300 at Darksand Land.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150031(c,QuestID);
				case 150032:
					//Accept Zodiac Temple\'s order, kill any monster*500 in Vine Rainforest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150032(c,QuestID);
				case 150033:
					//Accept Zodiac Temple\'s order, kill any monster*500 in Redcloud Marsh.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150033(c,QuestID);
				case 150034:
					//Accept Zodiac Temple\'s order, kill any monster*500 in Darkwind Canyon.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150034(c,QuestID);
				case 150035:
					//Accept Zodiac Temple\'s order, kill any monster*500 in Foggy Forest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150035(c,QuestID);
				case 150036:
					//Accept Zodiac Temple\'s order, collect 20 Darksand Essences from Darksand Land.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150036(c,QuestID);
				case 150037:
					//Accept Zodiac Temple\'s order, collect 20 Water Mana Spars from Vine Rainforest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150037(c,QuestID);
				case 150038:
					//Accept Zodiac Temple\'s order, collect 20 Greenbell Flowers from Redcloud Marsh.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150038(c,QuestID);
				case 150039:
					//Accept Zodiac Temple\'s order, collect 20 Hyacinths from Darkwind Canyon.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150039(c,QuestID);
				case 150040:
					//Accept Zodiac Temple\'s order, collect 20 Hyacinths from Foggy Forest.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150040(c,QuestID);
				case 150041:
					//Accept Zodiac Temple\'s order, kill any monster*50 at Henan Mountainside.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150041(c,QuestID);
				case 150042:
					//Accept Zodiac Temple\'s order, kill any monster*100 at Henan Mountainside.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150042(c,QuestID);
				case 150043:
					//Accept Zodiac Temple\'s order, kill any monster*150 at Henan Mountainside.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150043(c,QuestID);
				case 150044:
					//Accept Zodiac Temple\'s order, kill any monster*200 at Henan Mountainside.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150044(c,QuestID);
				case 150045:
					//Accept Zodiac Temple\'s order, kill any monster*250 at Henan Mountainside.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150045(c,QuestID);
				case 150046:
					//Accept Zodiac Temple\'s order, kill any monster*500 at Henan Mountainside.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150046(c,QuestID);
				case 150047:
					//Accept Zodiac Temple\'s order, collect 20 Despair Herbs at Henan Mountainside.
					if(CanQuest(c,200)) break;
					return QuestCode.Q150047(c,QuestID);
			}

			return 0;
		}
	}
}
