using System;
using System.Collections.Generic;

namespace GameServer
{
	internal static class QuestAccept
	{
		internal static byte Parse(ConnectionInfo c,int QuestID)
		{
			switch(QuestID)
			{
				case 100001:
					//Ask Star Sage Halmir what to do next.
					if(QuestCommand.CanQuest(c,1)) break;
					return QuestCode.A100001(c,QuestID);
				case 100002:
					//Find Star Protector Stone, get a gift box from him.
					if(QuestCommand.CanQuest(c,2)) break;
					return QuestCode.A100002(c,QuestID);
				case 100003:
					//Equip weapon, then go to see Star Warrior Sophie.
					if(QuestCommand.CanQuest(c,3)) break;
					return QuestCode.A100003(c,QuestID);
				case 100005:
					//Learn skill, then look for Zodiac Instructor Darcy.
					if(QuestCommand.CanQuest(c,4)) break;
					return QuestCode.A100005(c,QuestID);
				case 100007:
					//Ask Virgo Kerry for a cloth.
					if(QuestCommand.CanQuest(c,5)) break;
					return QuestCode.A100007(c,QuestID);
				case 100009:
					//Find Zodiac Priest Moville outside of Zodiac Academy and finish his requirement.
					if(QuestCommand.CanQuest(c,5)) break;
					return QuestCode.A100009(c,QuestID);
				case 100010:
					//Kill Beedas at the outside of Zodiac Academy and then report to Zodiac Priest Moville.
					if(QuestCommand.CanQuest(c,6)) break;
					return QuestCode.A100010(c,QuestID);
				case 100012:
					//Ask Zodiac Priest Lily for the opportunity of getting next proof.
					if(QuestCommand.CanQuest(c,7)) break;
					return QuestCode.A100012(c,QuestID);
				case 100013:
					//Kill 1 Vampire Bat outside of Zodiac Academy and then report to Zodiac Priest Lily.
					if(QuestCommand.CanQuest(c,7)) break;
					return QuestCode.A100013(c,QuestID);
				case 100014:
					//Kill 1 Hiram outside of Zodiac Academy and then report to Zodiac Priest Lily.
					if(QuestCommand.CanQuest(c,7)) break;
					return QuestCode.A100014(c,QuestID);
				case 100015:
					//Get the last proof from Zodiac Officiant Roger, and match constellations.
					if(QuestCommand.CanQuest(c,8)) break;
					return QuestCode.A100015(c,QuestID);
				case 100016:
					//Kill 1 Treant outside of Zodiac Academy, then report to Zodiac Officiant Roger.
					if(QuestCommand.CanQuest(c,8)) break;
					return QuestCode.A100016(c,QuestID);
				case 100017:
					//Learn new skill with the guidance of Zodiac Instructor Barral.
					if(QuestCommand.CanQuest(c,8)) break;
					return QuestCode.A100017(c,QuestID);
				case 100020:
					//Ask Star Warlock Ekland to activate the Zodiac Medal.
					if(QuestCommand.CanQuest(c,9)) break;
					return QuestCode.A100020(c,QuestID);
				case 100023:
					//Go go Empire Capital, Contact Oracle.
					if(QuestCommand.CanQuest(c,10)) break;
					return QuestCode.A100023(c,QuestID);
				case 100024:
					//Go go Empire Capital, Contact Oracle.
					if(QuestCommand.CanQuest(c,10)) break;
					return QuestCode.A100024(c,QuestID);
				case 100025:
					//Go go Empire Capital, Contact Oracle.
					if(QuestCommand.CanQuest(c,10)) break;
					return QuestCode.A100025(c,QuestID);
				case 100026:
					//Choose a faction.
					if(QuestCommand.CanQuest(c,10)) break;
					return QuestCode.A100026(c,QuestID);
				case 110016:
					//Collect 1 Aquamarine Grass from Sunshine Cliff and give it to Allen.
					if(QuestCommand.CanQuest(c,14)) break;
					return QuestCode.A110016(c,QuestID);
				case 110017:
					//Ask Cecil about how to clean the bloodstain on the secret letter.
					if(QuestCommand.CanQuest(c,14)) break;
					return QuestCode.A110017(c,QuestID);
				case 110020:
					//Tekk Allen the method of cleaning bloodstain.
					if(QuestCommand.CanQuest(c,15)) break;
					return QuestCode.A110020(c,QuestID);
				case 110021:
					//Kill 4 Gold Wire Snakes at Sunshine Cliff, collect their venom and bring it back to Allen.
					if(QuestCommand.CanQuest(c,15)) break;
					return QuestCode.A110021(c,QuestID);
				case 110022:
					//Contact Bernice and do whatever she tells you.
					if(QuestCommand.CanQuest(c,15)) break;
					return QuestCode.A110022(c,QuestID);
				case 110024:
					//Kill 4 Troll Spiders at Sunshine Cliff, clear the way to Emma.
					if(QuestCommand.CanQuest(c,16)) break;
					return QuestCode.A110024(c,QuestID);
				case 110025:
					//Contact Sunshine Cliff\'s Emma.
					if(QuestCommand.CanQuest(c,16)) break;
					return QuestCode.A110025(c,QuestID);
				case 110027:
					//Collect 1 Mandela Tulip at Sunshine Cliff and give it to Emma.
					if(QuestCommand.CanQuest(c,16)) break;
					return QuestCode.A110027(c,QuestID);
				case 110028:
					//Tell Bernice the identity of the victim who\'s confirmed by Emma.
					if(QuestCommand.CanQuest(c,16)) break;
					return QuestCode.A110028(c,QuestID);
				case 110029:
					//Contact Sunshine Cliff\'s Barlow.
					if(QuestCommand.CanQuest(c,17)) break;
					return QuestCode.A110029(c,QuestID);
				case 110030:
					//Capture 4 Forest Bears at Sunshine Cliff, bring them back to Barlow.
					if(QuestCommand.CanQuest(c,17)) break;
					return QuestCode.A110030(c,QuestID);
				case 110032:
					//Collect 1 Phosphate Rock from Sunshine Cliff, bring it back to Barlow to make Phosphate Powder.
					if(QuestCommand.CanQuest(c,17)) break;
					return QuestCode.A110032(c,QuestID);
				case 110033:
					//Go to Sunshine Cliff, contact Janet.
					if(QuestCommand.CanQuest(c,17)) break;
					return QuestCode.A110033(c,QuestID);
				case 110035:
					//Collect 1 Death Flower from Sunshine Cliff and give it to Janet.
					if(QuestCommand.CanQuest(c,18)) break;
					return QuestCode.A110035(c,QuestID);
				case 110036:
					//Visit awakening Donald.
					if(QuestCommand.CanQuest(c,18)) break;
					return QuestCode.A110036(c,QuestID);
				case 110038:
					//Capture 4 Thunderhawk from Sunshine Cliff, bring them back to Donald.
					if(QuestCommand.CanQuest(c,18)) break;
					return QuestCode.A110038(c,QuestID);
				case 110039:
					//Ask Janet to help you extract information from Thunderhawk\'s eyes.
					if(QuestCommand.CanQuest(c,19)) break;
					return QuestCode.A110039(c,QuestID);
				case 110040:
					//Tell Donald the analysis made by Janet, let him make the final decision.
					if(QuestCommand.CanQuest(c,19)) break;
					return QuestCode.A110040(c,QuestID);
				case 110041:
					//Defeat Alva at Sunshine Cliff and report to Donald.
					if(QuestCommand.CanQuest(c,19)) break;
					return QuestCode.A110041(c,QuestID);
				case 110045:
					//Ask Edith about the information collected.
					if(QuestCommand.CanQuest(c,21)) break;
					return QuestCode.A110045(c,QuestID);
				case 110048:
					//Capture 5 Rubble Rat in Rubble Wasteland, bring them back to Edith.
					if(QuestCommand.CanQuest(c,21)) break;
					return QuestCode.A110048(c,QuestID);
				case 110049:
					//Bring the paper and ask Herbert what information he has gathered.
					if(QuestCommand.CanQuest(c,22)) break;
					return QuestCode.A110049(c,QuestID);
				case 110050:
					//Ask Joshua for the other half o the information.
					if(QuestCommand.CanQuest(c,22)) break;
					return QuestCode.A110050(c,QuestID);
				case 110051:
					//Tell Edith the information collected by Herbert and Joshua.
					if(QuestCommand.CanQuest(c,22)) break;
					return QuestCode.A110051(c,QuestID);
				case 110058:
					//Ask Leonard for the information he has gathered.
					if(QuestCommand.CanQuest(c,22)) break;
					return QuestCode.A110058(c,QuestID);
				case 110059:
					//Capture 8 Mottle Snakes in Rubble Wasteland and bring them back to Leonard.
					if(QuestCommand.CanQuest(c,22)) break;
					return QuestCode.A110059(c,QuestID);
				case 110060:
					//Ask Moore for the other half of the information.
					if(QuestCommand.CanQuest(c,23)) break;
					return QuestCode.A110060(c,QuestID);
				case 110061:
					//Listen to Moore tell how he lost the information.
					if(QuestCommand.CanQuest(c,23)) break;
					return QuestCode.A110061(c,QuestID);
				case 110062:
					//Catch Erica in Rubble Wasteland, get the lost half of information and take it to Moore.
					if(QuestCommand.CanQuest(c,23)) break;
					return QuestCode.A110062(c,QuestID);
				case 110063:
					//Bring the information collected by Leonard and Moore to Edith.
					if(QuestCommand.CanQuest(c,23)) break;
					return QuestCode.A110063(c,QuestID);
				case 110064:
					//Find Jason in Lune Oasis, tell him Edith\'s instructions.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A110064(c,QuestID);
				case 110089:
					//Contact Lune Oasis\'s Aldrich.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A110089(c,QuestID);
				case 110090:
					//Find Andy according to Aldrich\'s instruction, follow Andy\'s instruction.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A110090(c,QuestID);
				case 110091:
					//Ask Benedict for the investigation report.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A110091(c,QuestID);
				case 110092:
					//Bring Benedict\'s magic paper to Andy.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A110092(c,QuestID);
				case 110093:
					//Kill 15 Toothy Gerbils in Darksand Land and then report to Andy.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A110093(c,QuestID);
				case 110094:
					//Collect 4 Darkthorn Cactus in Darksand Land and bring them back to Edwina.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A110094(c,QuestID);
				case 110095:
					//Help Edwina to ask Andy when can they get normal water supply again.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A110095(c,QuestID);
				case 110096:
					//Find Chester, help Andy ask about Chester\'s findings.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A110096(c,QuestID);
				case 110097:
					//Bring Chester\'s investigation report to Andy.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A110097(c,QuestID);
				case 110098:
					//Capture 20 Rattlesnakes in Darksand Land and bring them back to Andy.
					if(QuestCommand.CanQuest(c,32)) break;
					return QuestCode.A110098(c,QuestID);
				case 110099:
					//Follow Andy\'s instruction to find Claude, asking him about how to increase the number of Rattlesnakes.
					if(QuestCommand.CanQuest(c,32)) break;
					return QuestCode.A110099(c,QuestID);
				case 110100:
					//Capture 20 Dire Wolves in Darksand Land and bring them back to Claude.
					if(QuestCommand.CanQuest(c,32)) break;
					return QuestCode.A110100(c,QuestID);
				case 110101:
					//Go to Darksand Land, talk to Claude\'s student Nelson.
					if(QuestCommand.CanQuest(c,33)) break;
					return QuestCode.A110101(c,QuestID);
				case 110102:
					//Collect 4 Buckthorn Grasses from Darksand Land and take them to Nelson.
					if(QuestCommand.CanQuest(c,33)) break;
					return QuestCode.A110102(c,QuestID);
				case 110103:
					//According to Nelson\'s request, ask Willa for some hairs.
					if(QuestCommand.CanQuest(c,33)) break;
					return QuestCode.A110103(c,QuestID);
				case 110104:
					//Kill Swantony in Darksand, seize back Willa\'s ring.
					if(QuestCommand.CanQuest(c,34)) break;
					return QuestCode.A110104(c,QuestID);
				case 110105:
					//Give Willa the ring and ask her for some hairs again.
					if(QuestCommand.CanQuest(c,34)) break;
					return QuestCode.A110105(c,QuestID);
				case 110106:
					//Bring Willa\'s hair back to Nelson.
					if(QuestCommand.CanQuest(c,34)) break;
					return QuestCode.A110106(c,QuestID);
				case 110107:
					//Give Claude materials collected by Nelson.
					if(QuestCommand.CanQuest(c,35)) break;
					return QuestCode.A110107(c,QuestID);
				case 110108:
					//Capture 35 Toothy Gerbils from Darksand Land and bring them back to Claude.
					if(QuestCommand.CanQuest(c,35)) break;
					return QuestCode.A110108(c,QuestID);
				case 110109:
					//Bring the woman from the Darksand Land to Andy.
					if(QuestCommand.CanQuest(c,35)) break;
					return QuestCode.A110109(c,QuestID);
				case 110110:
					//As Andy asked, Tell Ingrid to heal the mysterious woman as soon as possible.
					if(QuestCommand.CanQuest(c,36)) break;
					return QuestCode.A110110(c,QuestID);
				case 110111:
					//Ask Darksand Land\'s Miles for some Styptic.
					if(QuestCommand.CanQuest(c,36)) break;
					return QuestCode.A110111(c,QuestID);
				case 110112:
					//Collect 4 Buckthorn Flowers in Darksand Land and take them to Miles.
					if(QuestCommand.CanQuest(c,36)) break;
					return QuestCode.A110112(c,QuestID);
				case 110113:
					//Give Ingrid the Styptic made by Miles.
					if(QuestCommand.CanQuest(c,36)) break;
					return QuestCode.A110113(c,QuestID);
				case 110114:
					//Help Colin to ask Cornell for Benson\'s whereabouts.
					if(QuestCommand.CanQuest(c,37)) break;
					return QuestCode.A110114(c,QuestID);
				case 110115:
					//Tell Andy about Benson\'s missing and the lost data.
					if(QuestCommand.CanQuest(c,37)) break;
					return QuestCode.A110115(c,QuestID);
				case 110116:
					//Find Esther, let her to get the mysterious woman\'s testimony.
					if(QuestCommand.CanQuest(c,37)) break;
					return QuestCode.A110116(c,QuestID);
				case 110117:
					//Catch 35 Bactrian Camels in Darksand Land and take them to Esther.
					if(QuestCommand.CanQuest(c,37)) break;
					return QuestCode.A110117(c,QuestID);
				case 110118:
					//Find Lyle in Darksand Land, tell him Andy\'s instructions.
					if(QuestCommand.CanQuest(c,38)) break;
					return QuestCode.A110118(c,QuestID);
				case 110119:
					//Ask Julian to think some ways to find Benson.
					if(QuestCommand.CanQuest(c,38)) break;
					return QuestCode.A110119(c,QuestID);
				case 110120:
					//Catch 35 Trade Wind Foxes in Darksand Land and take them back to Julian.
					if(QuestCommand.CanQuest(c,38)) break;
					return QuestCode.A110120(c,QuestID);
				case 110121:
					//Arrest Benson in Darksand Land and take him to Lyle.
					if(QuestCommand.CanQuest(c,39)) break;
					return QuestCode.A110121(c,QuestID);
				case 110122:
					//Ask Ogden about the origin of the badge.
					if(QuestCommand.CanQuest(c,39)) break;
					return QuestCode.A110122(c,QuestID);
				case 110123:
					//Report to Andy about how to deal with Benson.
					if(QuestCommand.CanQuest(c,39)) break;
					return QuestCode.A110123(c,QuestID);
				case 110124:
					//Go to Tramp Camp, contact Duke.
					if(QuestCommand.CanQuest(c,40)) break;
					return QuestCode.A110124(c,QuestID);
				case 110125:
					//Go to see Edgar, ask to join the tramp guild.
					if(QuestCommand.CanQuest(c,40)) break;
					return QuestCode.A110125(c,QuestID);
				case 110126:
					//Catch 40 Phantom Monkeys from Vine Rainforest and take them to Edgar.
					if(QuestCommand.CanQuest(c,40)) break;
					return QuestCode.A110126(c,QuestID);
				case 110127:
					//Register at Hoare and accept his test.
					if(QuestCommand.CanQuest(c,40)) break;
					return QuestCode.A110127(c,QuestID);
				case 110128:
					//Kill 40 Man-eating Trees in Vine Rainforest and report to Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A110128(c,QuestID);
				case 110129:
					//Follow Hoare\'s instruction to meet Ansel.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A110129(c,QuestID);
				case 110130:
					//Tell Duke Ansel\'s requirement for the alliance.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A110130(c,QuestID);
				case 110131:
					//Tell Ansel Duke\'s reply.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A110131(c,QuestID);
				case 110132:
					//Find Monlisa, ask her to brew one Vow Potion.
					if(QuestCommand.CanQuest(c,42)) break;
					return QuestCode.A110132(c,QuestID);
				case 110133:
					//Collect 5 Delusion Herbs in Vine Rainforest and give them to Monlisa.
					if(QuestCommand.CanQuest(c,42)) break;
					return QuestCode.A110133(c,QuestID);
				case 110134:
					//Take Vow Potion to Ansel and drink it in front of him.
					if(QuestCommand.CanQuest(c,42)) break;
					return QuestCode.A110134(c,QuestID);
				case 110135:
					//Ask Elder Levi to make one Eye of Truth.
					if(QuestCommand.CanQuest(c,43)) break;
					return QuestCode.A110135(c,QuestID);
				case 110136:
					//Kill 40 Wraith Spiders in Vine Rainforest, take their eyes to Levi.
					if(QuestCommand.CanQuest(c,43)) break;
					return QuestCode.A110136(c,QuestID);
				case 110137:
					//Find Ansel, see what request he has.
					if(QuestCommand.CanQuest(c,43)) break;
					return QuestCode.A110137(c,QuestID);
				case 110138:
					//Ask Joyce for Tramp\'s headscarf.
					if(QuestCommand.CanQuest(c,44)) break;
					return QuestCode.A110138(c,QuestID);
				case 110139:
					//Kill Baird in Vine Rainforest, take back the stolen Tramp\'s headscarf.
					if(QuestCommand.CanQuest(c,44)) break;
					return QuestCode.A110139(c,QuestID);
				case 110140:
					//Take Tramp\'s headscarf and report to Ansel.
					if(QuestCommand.CanQuest(c,44)) break;
					return QuestCode.A110140(c,QuestID);
				case 110141:
					//Ask Monlisa to make one Mystic Potion.
					if(QuestCommand.CanQuest(c,45)) break;
					return QuestCode.A110141(c,QuestID);
				case 110142:
					//Collect 5 Vampire Vines in Vine Rainforest and tale them back to Monlisa.
					if(QuestCommand.CanQuest(c,45)) break;
					return QuestCode.A110142(c,QuestID);
				case 110143:
					//Listen to Ansel talk about the use of Mystic Potion.
					if(QuestCommand.CanQuest(c,45)) break;
					return QuestCode.A110143(c,QuestID);
				case 110144:
					//Find Jerome in Vine Rainforest, capture Archer with him.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A110144(c,QuestID);
				case 110145:
					//Ask Kyle if he can remove the giant stone which blocks the way.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A110145(c,QuestID);
				case 110146:
					//Catch 45 Giant Jaw Ants in Vine Rainforest and take them to Kyle.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A110146(c,QuestID);
				case 110147:
					//Ask Thera if she can find out the disappeared trace.
					if(QuestCommand.CanQuest(c,47)) break;
					return QuestCode.A110147(c,QuestID);
				case 110148:
					//Ask Winnie to make some Revealing Potion.
					if(QuestCommand.CanQuest(c,47)) break;
					return QuestCode.A110148(c,QuestID);
				case 110149:
					//Collect 5 Luminous Grasses in Vine Rainforest and take them back to Winnie.
					if(QuestCommand.CanQuest(c,47)) break;
					return QuestCode.A110149(c,QuestID);
				case 110150:
					//Catch Archer in Vine Rainforest and take him to Jerome.
					if(QuestCommand.CanQuest(c,48)) break;
					return QuestCode.A110150(c,QuestID);
				case 110151:
					//Take Archer to Tramp Camp\'s Ansel.
					if(QuestCommand.CanQuest(c,48)) break;
					return QuestCode.A110151(c,QuestID);
				case 110152:
					//Take Archer to Morris.
					if(QuestCommand.CanQuest(c,48)) break;
					return QuestCode.A110152(c,QuestID);
				case 110153:
					//Catch 45 Mud Monsters in Vine Rainforest and take them to Morris.
					if(QuestCommand.CanQuest(c,49)) break;
					return QuestCode.A110153(c,QuestID);
				case 110154:
					//Take Archer from Morris to Ansel.
					if(QuestCommand.CanQuest(c,49)) break;
					return QuestCode.A110154(c,QuestID);
				case 110155:
					//Tell Duke that Archer was poisoned to death.
					if(QuestCommand.CanQuest(c,49)) break;
					return QuestCode.A110155(c,QuestID);
				case 110156:
					//Go to Pearl Village, meet Colby dispatched by Duke.
					if(QuestCommand.CanQuest(c,50)) break;
					return QuestCode.A110156(c,QuestID);
				case 110157:
					//Visit Ashbur, ask him about where to find the Blade.
					if(QuestCommand.CanQuest(c,50)) break;
					return QuestCode.A110157(c,QuestID);
				case 110158:
					//Tell Mabel about what the Village Head said.
					if(QuestCommand.CanQuest(c,50)) break;
					return QuestCode.A110158(c,QuestID);
				case 110159:
					//Kill 50 Venom Monsters in Redcloud Marsh and then go back and tell Mabel.
					if(QuestCommand.CanQuest(c,50)) break;
					return QuestCode.A110159(c,QuestID);
				case 110160:
					//Take the red material to Raymond, ask him to analyze its component.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A110160(c,QuestID);
				case 110161:
					//Kill 50 Venom Monsters in Redcloud Marsh, collect the red materials for Raymond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A110161(c,QuestID);
				case 110162:
					//Tell Mabel about Raymond\'s finding.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A110162(c,QuestID);
				case 110163:
					//Find Vermal in Redcloud Marsh, ask him if anything unusual has happened.
					if(QuestCommand.CanQuest(c,52)) break;
					return QuestCode.A110163(c,QuestID);
				case 110164:
					//Give Simona the data collected by Vermal, ask here to make a comprehensive analysis.
					if(QuestCommand.CanQuest(c,52)) break;
					return QuestCode.A110164(c,QuestID);
				case 110165:
					//Catch 50 Short-wing Rats in Redcloud Marsh and take them to Simona.
					if(QuestCommand.CanQuest(c,52)) break;
					return QuestCode.A110165(c,QuestID);
				case 110166:
					//Ask Raymond about the solution.
					if(QuestCommand.CanQuest(c,53)) break;
					return QuestCode.A110166(c,QuestID);
				case 110167:
					//Catch 50 Medusa in Redcloud Marsh and take back to Raymond.
					if(QuestCommand.CanQuest(c,53)) break;
					return QuestCode.A110167(c,QuestID);
				case 110168:
					//Collect 6 Fluorescent Herbs in Redcloud Marsh and take them to Raymond.
					if(QuestCommand.CanQuest(c,53)) break;
					return QuestCode.A110168(c,QuestID);
				case 110169:
					//Take Simona\'s analysis report to Vermal.
					if(QuestCommand.CanQuest(c,54)) break;
					return QuestCode.A110169(c,QuestID);
				case 110170:
					//Take Simona\'s analysis report to Mabel.
					if(QuestCommand.CanQuest(c,54)) break;
					return QuestCode.A110170(c,QuestID);
				case 110171:
					//Kill 50 Mugger Crocodiles in Redcloud Marsh and then to to tell Mabel.
					if(QuestCommand.CanQuest(c,54)) break;
					return QuestCode.A110171(c,QuestID);
				case 110172:
					//Defeat Olive in Redcloud Marsh and then to to tell Mabel.
					if(QuestCommand.CanQuest(c,55)) break;
					return QuestCode.A110172(c,QuestID);
				case 110173:
					//Take the mysterious woman back to village, ask village head Ashbur if he can find out any clues.
					if(QuestCommand.CanQuest(c,55)) break;
					return QuestCode.A110173(c,QuestID);
				case 110174:
					//Ask Olive about the whereabout of the village head\'s son.
					if(QuestCommand.CanQuest(c,55)) break;
					return QuestCode.A110174(c,QuestID);
				case 110175:
					//Take Olive to Nicolas for treatment.
					if(QuestCommand.CanQuest(c,56)) break;
					return QuestCode.A110175(c,QuestID);
				case 110176:
					//Catch 55 Medusa in Redcloud Marsh and take them to Nicolas.
					if(QuestCommand.CanQuest(c,56)) break;
					return QuestCode.A110176(c,QuestID);
				case 110177:
					//Talk with Olive.
					if(QuestCommand.CanQuest(c,56)) break;
					return QuestCode.A110177(c,QuestID);
				case 110178:
					//Ask Raymond to extract some nectar from Rotten Flower.
					if(QuestCommand.CanQuest(c,57)) break;
					return QuestCode.A110178(c,QuestID);
				case 110179:
					//Collect 6 Rotten Flowers in Redcloud Marsh and take them to Raymond.
					if(QuestCommand.CanQuest(c,57)) break;
					return QuestCode.A110179(c,QuestID);
				case 110180:
					//Take the Rotten Flower to Olive.
					if(QuestCommand.CanQuest(c,57)) break;
					return QuestCode.A110180(c,QuestID);
				case 110181:
					//Ask Olive about the whereabouts of the murderer.
					if(QuestCommand.CanQuest(c,58)) break;
					return QuestCode.A110181(c,QuestID);
				case 110182:
					//Go to Redcloud Marsh, ask Blair to help to find out the mark Olive left.
					if(QuestCommand.CanQuest(c,58)) break;
					return QuestCode.A110182(c,QuestID);
				case 110183:
					//Kill 55 Carrions in Redcloud Marsh and then tell Blair.
					if(QuestCommand.CanQuest(c,58)) break;
					return QuestCode.A110183(c,QuestID);
				case 110184:
					//Destroy Giant Carrion in Redcloud Marsh, take back the box and then tell Blair.
					if(QuestCommand.CanQuest(c,59)) break;
					return QuestCode.A110184(c,QuestID);
				case 110185:
					//Go to Pearl Village, take the box to Colby.
					if(QuestCommand.CanQuest(c,59)) break;
					return QuestCode.A110185(c,QuestID);
				case 110186:
					//Take the box to Gregory to identify.
					if(QuestCommand.CanQuest(c,59)) break;
					return QuestCode.A110186(c,QuestID);
				case 110187:
					//Find Colby, let him make the final decision.
					if(QuestCommand.CanQuest(c,59)) break;
					return QuestCode.A110187(c,QuestID);
				case 110188:
					//Go to the Lost City to meet Mario.
					if(QuestCommand.CanQuest(c,60)) break;
					return QuestCode.A110188(c,QuestID);
				case 110189:
					//Find Amos, ask him about the progress of excavation.
					if(QuestCommand.CanQuest(c,60)) break;
					return QuestCode.A110189(c,QuestID);
				case 110190:
					//Catch 60 Darkwind Wolves in Darkwind Canyon and bring them back to Amos.
					if(QuestCommand.CanQuest(c,60)) break;
					return QuestCode.A110190(c,QuestID);
				case 110191:
					//Tell Veronica about Amos\' request.
					if(QuestCommand.CanQuest(c,60)) break;
					return QuestCode.A110191(c,QuestID);
				case 110192:
					//Take Haemin extracted by Veronica to Amos.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A110192(c,QuestID);
				case 110193:
					//Catch 60 Darkwind Hunters in Darkwind Canyon and bring them back to Amos.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A110193(c,QuestID);
				case 110194:
					//See Veronica, tell her Amos\' requirement and promise.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A110194(c,QuestID);
				case 110195:
					//Take Haemin extracted by Veronica to Amos.
					if(QuestCommand.CanQuest(c,62)) break;
					return QuestCode.A110195(c,QuestID);
				case 110196:
					//Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Amos.
					if(QuestCommand.CanQuest(c,62)) break;
					return QuestCode.A110196(c,QuestID);
				case 110197:
					//See Jeffrey, ask him to come to Amos and discuss the reason of Lost City\'s decline.
					if(QuestCommand.CanQuest(c,62)) break;
					return QuestCode.A110197(c,QuestID);
				case 110198:
					//Ask Mario about the negligence of duty.
					if(QuestCommand.CanQuest(c,62)) break;
					return QuestCode.A110198(c,QuestID);
				case 110199:
					//Ask Omar to save Amos as soon as possible.
					if(QuestCommand.CanQuest(c,63)) break;
					return QuestCode.A110199(c,QuestID);
				case 110200:
					//Collect 6 Cruor Grasses in Darkwind Canyon and bring them back to Omar.
					if(QuestCommand.CanQuest(c,63)) break;
					return QuestCode.A110200(c,QuestID);
				case 110201:
					//Ask Veronica to make purer Antidotes.
					if(QuestCommand.CanQuest(c,63)) break;
					return QuestCode.A110201(c,QuestID);
				case 110202:
					//See Omar, give him Veronica\'s Antidotes.
					if(QuestCommand.CanQuest(c,64)) break;
					return QuestCode.A110202(c,QuestID);
				case 110203:
					//Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Omar.
					if(QuestCommand.CanQuest(c,64)) break;
					return QuestCode.A110203(c,QuestID);
				case 110204:
					//Bring Alger the list of materials needed for holding Soul Ritual.
					if(QuestCommand.CanQuest(c,64)) break;
					return QuestCode.A110204(c,QuestID);
				case 110205:
					//Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Alger.
					if(QuestCommand.CanQuest(c,65)) break;
					return QuestCode.A110205(c,QuestID);
				case 110206:
					//Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Alger.
					if(QuestCommand.CanQuest(c,65)) break;
					return QuestCode.A110206(c,QuestID);
				case 110207:
					//Catch 25 Canyon Eagles, 25 Stone Lizards, 25 Canyon Centaurs in Darkwind Canyon and bring them back to Alger.
					if(QuestCommand.CanQuest(c,65)) break;
					return QuestCode.A110207(c,QuestID);
				case 110208:
					//Bring materials collected by Alger to Omar.
					if(QuestCommand.CanQuest(c,66)) break;
					return QuestCode.A110208(c,QuestID);
				case 110209:
					//Ask Amos about the assassination.
					if(QuestCommand.CanQuest(c,66)) break;
					return QuestCode.A110209(c,QuestID);
				case 110210:
					//Ask Theodore to catch the assassin.
					if(QuestCommand.CanQuest(c,66)) break;
					return QuestCode.A110210(c,QuestID);
				case 110211:
					//Find Angelo in Darkwind Canyon, asking him to catch the assassin as soon as possible.
					if(QuestCommand.CanQuest(c,66)) break;
					return QuestCode.A110211(c,QuestID);
				case 110212:
					//Kill 1 Shadow Assassin in Darkwind Canyon and bring him back to Angelo.
					if(QuestCommand.CanQuest(c,66)) break;
					return QuestCode.A110212(c,QuestID);
				case 110213:
					//Ask Tiffany how to restore Amos\' memory.
					if(QuestCommand.CanQuest(c,67)) break;
					return QuestCode.A110213(c,QuestID);
				case 110214:
					//Collect 6 Hyacinth from Darkwind Canyon and bring them back to Tiffany.
					if(QuestCommand.CanQuest(c,67)) break;
					return QuestCode.A110214(c,QuestID);
				case 110215:
					//Bring the Potion of Time made by Tiffany to Amos.
					if(QuestCommand.CanQuest(c,67)) break;
					return QuestCode.A110215(c,QuestID);
				case 110216:
					//Tell Mario what Amos has found, ask him to report that to the capital.
					if(QuestCommand.CanQuest(c,68)) break;
					return QuestCode.A110216(c,QuestID);
				case 110217:
					//Find Stanley, ask him to summon the souls of the dead assassin.
					if(QuestCommand.CanQuest(c,68)) break;
					return QuestCode.A110217(c,QuestID);
				case 110218:
					//Catch 65 Canyon Centaurs in Darkwind Canyon and bring them back to Stanley.
					if(QuestCommand.CanQuest(c,68)) break;
					return QuestCode.A110218(c,QuestID);
				case 110219:
					//Tell Mario about Stanley\'s finding.
					if(QuestCommand.CanQuest(c,69)) break;
					return QuestCode.A110219(c,QuestID);
				case 110220:
					//Catch 3 Head Centaurs in Darkwind Canyon and bring them back to Mario.
					if(QuestCommand.CanQuest(c,69)) break;
					return QuestCode.A110220(c,QuestID);
				case 110221:
					//Enter Dark Castle, contact Burnell.
					if(QuestCommand.CanQuest(c,70)) break;
					return QuestCode.A110221(c,QuestID);
				case 110222:
					//Ask Jabman about the dagger.
					if(QuestCommand.CanQuest(c,70)) break;
					return QuestCode.A110222(c,QuestID);
				case 110223:
					//Kill 70 Foggy Bears in Foggy Forest and then tell Jabman.
					if(QuestCommand.CanQuest(c,70)) break;
					return QuestCode.A110223(c,QuestID);
				case 110224:
					//Kill 70 Foggy Vampires in Foggy Forest and then tell Jabman.
					if(QuestCommand.CanQuest(c,70)) break;
					return QuestCode.A110224(c,QuestID);
				case 110225:
					//Find Claymond, ask him what usual things have happened recently.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A110225(c,QuestID);
				case 110226:
					//Find Xaviera, asking her to try to find some Light of Life.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A110226(c,QuestID);
				case 110227:
					//Kill 70 Berserk Warriors in Foggy Forest and then find Xaviera.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A110227(c,QuestID);
				case 110228:
					//Find Hiddrick, asking him where the World Tree\'s seed is.
					if(QuestCommand.CanQuest(c,72)) break;
					return QuestCode.A110228(c,QuestID);
				case 110229:
					//Ask Jabman for Tree of Life\'s seed.
					if(QuestCommand.CanQuest(c,72)) break;
					return QuestCode.A110229(c,QuestID);
				case 110230:
					//Kill 70 Dawn Elves in Foggy Forest and then find Jabman.
					if(QuestCommand.CanQuest(c,72)) break;
					return QuestCode.A110230(c,QuestID);
				case 110231:
					//Bring the Light of Life to Claymond.
					if(QuestCommand.CanQuest(c,73)) break;
					return QuestCode.A110231(c,QuestID);
				case 110232:
					//Ask Cyril about the history of Dark Castle.
					if(QuestCommand.CanQuest(c,73)) break;
					return QuestCode.A110232(c,QuestID);
				case 110233:
					//Find Zelene, listen to him talk about what happened next.
					if(QuestCommand.CanQuest(c,73)) break;
					return QuestCode.A110233(c,QuestID);
				case 110234:
					//Find Claymond, listen to him talk about what happened next.
					if(QuestCommand.CanQuest(c,73)) break;
					return QuestCode.A110234(c,QuestID);
				case 110235:
					//Kill 70 Berserk Warriors in Foggy Forest, then go back and tell Claymond.
					if(QuestCommand.CanQuest(c,74)) break;
					return QuestCode.A110235(c,QuestID);
				case 110236:
					//Kill 70 Dawn Elves in Foggy Forest, then go back and tell Claymond.
					if(QuestCommand.CanQuest(c,74)) break;
					return QuestCode.A110236(c,QuestID);
				case 110237:
					//Collect 6 Foggy Roses in Foggy Forest and bring them back to Claymond.
					if(QuestCommand.CanQuest(c,74)) break;
					return QuestCode.A110237(c,QuestID);
				case 110238:
					//Tell Cesar about Claymond\'s instructions.
					if(QuestCommand.CanQuest(c,75)) break;
					return QuestCode.A110238(c,QuestID);
				case 110239:
					//Ask Yuna who\'s been to Seal Room recently.
					if(QuestCommand.CanQuest(c,75)) break;
					return QuestCode.A110239(c,QuestID);
				case 110240:
					//Catch 75 Foggy Spiders in Foggy Forest and bring them back to Yuna.
					if(QuestCommand.CanQuest(c,75)) break;
					return QuestCode.A110240(c,QuestID);
				case 110241:
					//Find Dark in Foggy Forest and ask him about Riel\'s trend.
					if(QuestCommand.CanQuest(c,76)) break;
					return QuestCode.A110241(c,QuestID);
				case 110242:
					//Catch 75 Dawn Elves in Foggy Forest and bring them back to Dark.
					if(QuestCommand.CanQuest(c,76)) break;
					return QuestCode.A110242(c,QuestID);
				case 110243:
					//Tell Dark Castle\'s Claymond the information Dark has learnt.
					if(QuestCommand.CanQuest(c,76)) break;
					return QuestCode.A110243(c,QuestID);
				case 110244:
					//Go to Foggy Forest Wind Rider Rita， Blade of Light。
					if(QuestCommand.CanQuest(c,77)) break;
					return QuestCode.A110244(c,QuestID);
				case 110245:
					//Ask Jabman if there\'s any remedy.
					if(QuestCommand.CanQuest(c,77)) break;
					return QuestCode.A110245(c,QuestID);
				case 110246:
					//Find Candice, tell her Jabman\'s demand.
					if(QuestCommand.CanQuest(c,77)) break;
					return QuestCode.A110246(c,QuestID);
				case 110247:
					//Collect 6 Blood Mosses in Foggy Forest and bring them back to Candice.
					if(QuestCommand.CanQuest(c,78)) break;
					return QuestCode.A110247(c,QuestID);
				case 110248:
					//Bring Deadsoul Potion mae by Candice to Parker.
					if(QuestCommand.CanQuest(c,78)) break;
					return QuestCode.A110248(c,QuestID);
				case 110249:
					//Catch 75 Berserk Warriors in Foggy Forest and bring them back to Parker.
					if(QuestCommand.CanQuest(c,78)) break;
					return QuestCode.A110249(c,QuestID);
				case 110250:
					//Bring the Chaos Crystal extracted by Candice to Jabman.
					if(QuestCommand.CanQuest(c,79)) break;
					return QuestCode.A110250(c,QuestID);
				case 110251:
					//Kill 5 Head Berserks in Foggy Forest and then tell Jabman.
					if(QuestCommand.CanQuest(c,79)) break;
					return QuestCode.A110251(c,QuestID);
				case 110252:
					//Find Burnell, tell him about Jabman\'s words.
					if(QuestCommand.CanQuest(c,79)) break;
					return QuestCode.A110252(c,QuestID);
				case 110253:
					//Go to Henan Mountain, contact Burnell.
					if(QuestCommand.CanQuest(c,80)) break;
					return QuestCode.A110253(c,QuestID);
				case 110254:
					//Ask Herman about what to do next for Harold.
					if(QuestCommand.CanQuest(c,80)) break;
					return QuestCode.A110254(c,QuestID);
				case 110255:
					//Find Sigrid and ask him to save the unconscious advance agent.
					if(QuestCommand.CanQuest(c,80)) break;
					return QuestCode.A110255(c,QuestID);
				case 110256:
					//Catch 80 Carefree Beasts in the Henan Mountainside, and bring them to Sigrid.
					if(QuestCommand.CanQuest(c,80)) break;
					return QuestCode.A110256(c,QuestID);
				case 110257:
					//Find Jeremy and ask him about the way to remove the Blessing Mark of Lord of Oracle
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A110257(c,QuestID);
				case 110258:
					//Tell Sigrid Jeremy\'s words.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A110258(c,QuestID);
				case 110259:
					//Collect 6 Despair Herbs on the Henan Mountainside and give them to Sigrid.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A110259(c,QuestID);
				case 110260:
					//Bring the advance agent that saved by Sigrid to Herman.
					if(QuestCommand.CanQuest(c,82)) break;
					return QuestCode.A110260(c,QuestID);
				case 110261:
					//Catch 80 Spirit Dragons on the Henan Mountainside, and bring them to Herman.
					if(QuestCommand.CanQuest(c,82)) break;
					return QuestCode.A110261(c,QuestID);
				case 110262:
					//Find Kelly and ask her to break the Circle of Memory Sealing.
					if(QuestCommand.CanQuest(c,82)) break;
					return QuestCode.A110262(c,QuestID);
				case 110263:
					//Find Sigrid and ask her for a Imaging Restore Potion.
					if(QuestCommand.CanQuest(c,83)) break;
					return QuestCode.A110263(c,QuestID);
				case 110264:
					//Catch 80 Spirit Dragons on the Henan Mountainside, and bring them to Sigrid.
					if(QuestCommand.CanQuest(c,83)) break;
					return QuestCode.A110264(c,QuestID);
				case 110265:
					//Find Renee and ask her to refine the Magic Elements in the Spirit Dragons.
					if(QuestCommand.CanQuest(c,83)) break;
					return QuestCode.A110265(c,QuestID);
				case 110266:
					//Give the refined Magic Elements to Sigrid.
					if(QuestCommand.CanQuest(c,84)) break;
					return QuestCode.A110266(c,QuestID);
				case 110267:
					//Find Eunice and ask her about the way of increasing the density of the Magic Elements.
					if(QuestCommand.CanQuest(c,84)) break;
					return QuestCode.A110267(c,QuestID);
				case 110268:
					//Collect 6 Silver Mines on the Henan Mountainside and give them to Eunice.
					if(QuestCommand.CanQuest(c,84)) break;
					return QuestCode.A110268(c,QuestID);
				case 110269:
					//Give the refined Silver Mine to Sigrid.
					if(QuestCommand.CanQuest(c,84)) break;
					return QuestCode.A110269(c,QuestID);
				case 110270:
					//Give the configured Imaging Restore Potion to Sigrid.
					if(QuestCommand.CanQuest(c,85)) break;
					return QuestCode.A110270(c,QuestID);
				case 110271:
					//Kill 85 Lost Acolytes on the Henan Mountainside then go back and tell tell Kelly.
					if(QuestCommand.CanQuest(c,85)) break;
					return QuestCode.A110271(c,QuestID);
				case 110272:
					//Tell Herman Kelly\'s discovery.
					if(QuestCommand.CanQuest(c,85)) break;
					return QuestCode.A110272(c,QuestID);
				case 110273:
					//Tell Mitchell Herman\'s request.
					if(QuestCommand.CanQuest(c,86)) break;
					return QuestCode.A110273(c,QuestID);
				case 110274:
					//Tell Eunice Mitchell\'s request.
					if(QuestCommand.CanQuest(c,86)) break;
					return QuestCode.A110274(c,QuestID);
				case 110275:
					//Catch 50 Carefree Beasts and 50 Bubble Beasts on Henan Mountainside and bring them to Eunice.
					if(QuestCommand.CanQuest(c,86)) break;
					return QuestCode.A110275(c,QuestID);
				case 110276:
					//Tell Mitchell Eunice\'s discovery.
					if(QuestCommand.CanQuest(c,87)) break;
					return QuestCode.A110276(c,QuestID);
				case 110277:
					//Catch 85 Bubble Beasts on Henan Mountainside and bring them to Mitchell.
					if(QuestCommand.CanQuest(c,87)) break;
					return QuestCode.A110277(c,QuestID);
				case 110278:
					//Give the Track Potion made by Mitchell to Herman.
					if(QuestCommand.CanQuest(c,87)) break;
					return QuestCode.A110278(c,QuestID);
				case 110279:
					//Defeat the Guarder Sissi on the Henan Mountainside then go back and tell Herman.
					if(QuestCommand.CanQuest(c,88)) break;
					return QuestCode.A110279(c,QuestID);
				case 110280:
					//Ask Jared about the way to defeat Guarder Sissi for Herman.
					if(QuestCommand.CanQuest(c,88)) break;
					return QuestCode.A110280(c,QuestID);
				case 110281:
					//Catch 50 Skyish Beasts and 50 Dark Carefree Beast on the Henan Mountainside then bring them to Jared.
					if(QuestCommand.CanQuest(c,88)) break;
					return QuestCode.A110281(c,QuestID);
				case 110282:
					//Kill 10 Guarder Sissi on the Henan Mountainside then go back and tell Jared.
					if(QuestCommand.CanQuest(c,89)) break;
					return QuestCode.A110282(c,QuestID);
				case 110283:
					//Tell Herman Jared\'s suggestion.
					if(QuestCommand.CanQuest(c,89)) break;
					return QuestCode.A110283(c,QuestID);
				case 110284:
					//Go to Peak of the World and contact Herman.
					if(QuestCommand.CanQuest(c,90)) break;
					return QuestCode.A110284(c,QuestID);
				case 111001:
					//Find Old Blacksmith, get the gift from the Old Blacksmith.
					if(QuestCommand.CanQuest(c,11)) break;
					return QuestCode.A111001(c,QuestID);
				case 111004:
					//Learn new skill from Warrior Leader.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A111004(c,QuestID);
				case 111006:
					//Get a better weapon from the Warrior Leader.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A111006(c,QuestID);
				case 111008:
					//Ask Grocer for some Teleport Scrolls.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A111008(c,QuestID);
				case 111010:
					//Get a better magic cloth from the Tailor.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A111010(c,QuestID);
				case 111011:
					//Go to see the Stargazer and get to know your horoscopes.
					if(QuestCommand.CanQuest(c,13)) break;
					return QuestCode.A111011(c,QuestID);
				case 111012:
					//See the Preparatory Officer, let him arrange the following things.
					if(QuestCommand.CanQuest(c,13)) break;
					return QuestCode.A111012(c,QuestID);
				case 111015:
					//Go to Sunshine Cliff, meet Allen.
					if(QuestCommand.CanQuest(c,14)) break;
					return QuestCode.A111015(c,QuestID);
				case 111044:
					//Go to the City of Genesis and contact Grover.
					if(QuestCommand.CanQuest(c,20)) break;
					return QuestCode.A111044(c,QuestID);
				case 112001:
					//Find Old Blacksmith, get the gift from the Old Blacksmith.
					if(QuestCommand.CanQuest(c,11)) break;
					return QuestCode.A112001(c,QuestID);
				case 112004:
					//Learn new skill from Warrior Leader.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A112004(c,QuestID);
				case 112006:
					//Get a better weapon from the Warrior Leader.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A112006(c,QuestID);
				case 112008:
					//Ask Grocer for some Teleport Scrolls.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A112008(c,QuestID);
				case 112010:
					//Get a better magic cloth from the Tailor.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A112010(c,QuestID);
				case 112011:
					//Go to see the Stargazer and get to know your horoscopes.
					if(QuestCommand.CanQuest(c,13)) break;
					return QuestCode.A112011(c,QuestID);
				case 112012:
					//See the Preparatory Officer, let him arrange the following things.
					if(QuestCommand.CanQuest(c,13)) break;
					return QuestCode.A112012(c,QuestID);
				case 112015:
					//Go to Sunshine Cliff, meet Allen.
					if(QuestCommand.CanQuest(c,14)) break;
					return QuestCode.A112015(c,QuestID);
				case 113001:
					//Find Old Blacksmith, get the gift from the Old Blacksmith.
					if(QuestCommand.CanQuest(c,11)) break;
					return QuestCode.A113001(c,QuestID);
				case 113004:
					//Learn new skill from Warrior Leader.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A113004(c,QuestID);
				case 113006:
					//Get a better weapon from the Warrior Leader.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A113006(c,QuestID);
				case 113008:
					//Ask Grocer for some Teleport Scrolls.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A113008(c,QuestID);
				case 113010:
					//Get a better magic cloth from the Tailor.
					if(QuestCommand.CanQuest(c,12)) break;
					return QuestCode.A113010(c,QuestID);
				case 113011:
					//Go to see the Stargazer and get to know your horoscopes.
					if(QuestCommand.CanQuest(c,13)) break;
					return QuestCode.A113011(c,QuestID);
				case 113012:
					//See the Preparatory Officer, let him arrange the following things.
					if(QuestCommand.CanQuest(c,13)) break;
					return QuestCode.A113012(c,QuestID);
				case 113015:
					//Go to Sunshine Cliff, meet Allen.
					if(QuestCommand.CanQuest(c,14)) break;
					return QuestCode.A113015(c,QuestID);
				case 119001:
					//Ask Ernest for the weapon Grover has prepared.
					if(QuestCommand.CanQuest(c,20)) break;
					return QuestCode.A119001(c,QuestID);
				case 119002:
					//Ask Larry about the whole thing.
					if(QuestCommand.CanQuest(c,21)) break;
					return QuestCode.A119002(c,QuestID);
				case 119003:
					//Kill Mentor Quentin at Dawn Pier, then tell this news to Jeff.
					if(QuestCommand.CanQuest(c,21)) break;
					return QuestCode.A119003(c,QuestID);
				case 119004:
					//Get VIP Trial Card from Larry.
					if(QuestCommand.CanQuest(c,21)) break;
					return QuestCode.A119004(c,QuestID);
				case 119005:
					//Try zodiac transformation under Grover\'s guidance.
					if(QuestCommand.CanQuest(c,20)) break;
					return QuestCode.A119005(c,QuestID);
				case 119006:
					//Find Goya and finish her request.
					if(QuestCommand.CanQuest(c,20)) break;
					return QuestCode.A119006(c,QuestID);
				case 119007:
					//Tell Spendo about Donald\'s news.
					if(QuestCommand.CanQuest(c,19)) break;
					return QuestCode.A119007(c,QuestID);
				case 119009:
					//Synthesize one Armor Shred with Magic Seed, then go to see Herbert.
					if(QuestCommand.CanQuest(c,26)) break;
					return QuestCode.A119009(c,QuestID);
				case 119010:
					//Synthesize one Ice Enchant with Magic Seed, then go to see Herbert.
					if(QuestCommand.CanQuest(c,26)) break;
					return QuestCode.A119010(c,QuestID);
				case 119011:
					//Synthesize one Death Inspire with Magic Seed, then go to see Herbert.
					if(QuestCommand.CanQuest(c,26)) break;
					return QuestCode.A119011(c,QuestID);
				case 119012:
					//Find Feig, buy one HP Potion B and talk to him.
					if(QuestCommand.CanQuest(c,26)) break;
					return QuestCode.A119012(c,QuestID);
				case 119013:
					//Enter Sky City, kill 4 Cloud Elves, then go to see Beryl.
					if(QuestCommand.CanQuest(c,26)) break;
					return QuestCode.A119013(c,QuestID);
				case 119014:
					//Go to City of Genesis, find Morton and listen to his instructions.
					if(QuestCommand.CanQuest(c,27)) break;
					return QuestCode.A119014(c,QuestID);
				case 119016:
					//Find Edith, ask her how to make money.
					if(QuestCommand.CanQuest(c,28)) break;
					return QuestCode.A119016(c,QuestID);
				case 119017:
					//Complete Escort Supplies once, then go to see Edith.
					if(QuestCommand.CanQuest(c,28)) break;
					return QuestCode.A119017(c,QuestID);
				case 119018:
					//Enter Dragon Cave, kill 5 Bronze Drakes, and then find Quenton.
					if(QuestCommand.CanQuest(c,29)) break;
					return QuestCode.A119018(c,QuestID);
				case 119020:
					//Collect 2 Dusk Dew in Lune Oasis, and then find Pine.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A119020(c,QuestID);
				case 119021:
					//Kill 8 Moonlight Beasts in Lune Oasis, then find Ralph.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A119021(c,QuestID);
				case 119022:
					//Kill 8 Gangtooth Spiders in Lune Oasis, then find Gemma.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A119022(c,QuestID);
				case 119023:
					//Kill 8 Desert Lizards in Lune Oasis, then find Claude.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A119023(c,QuestID);
				case 119024:
					//Kill 8 Desert Arks in Lune Oasis, then find Claude.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A119024(c,QuestID);
				case 119025:
					//Find Jason in Lune Oasis, listen to his command.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A119025(c,QuestID);
				case 120004:
					//Add 1 friend and find Leonard to finish the quest.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A120004(c,QuestID);
				case 120022:
					//Join a guild and find Edith to complete the task.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A120022(c,QuestID);
				case 120027:
					//Ask Cleveland how to take a leave successfully.
					if(QuestCommand.CanQuest(c,23)) break;
					return QuestCode.A120027(c,QuestID);
				case 120028:
					//Persuade Curtis to agree the work shift with Edith.
					if(QuestCommand.CanQuest(c,23)) break;
					return QuestCode.A120028(c,QuestID);
				case 120029:
					//Catch 8 Fire Bats at Rubble Wasteland and take them back to Curtis.
					if(QuestCommand.CanQuest(c,23)) break;
					return QuestCode.A120029(c,QuestID);
				case 120030:
					//Kill 5 Stone Ants at Rubble Wasteland and then tell Curtis.
					if(QuestCommand.CanQuest(c,24)) break;
					return QuestCode.A120030(c,QuestID);
				case 120031:
					//Take Dulcie the weapon enhanced by Curtis.
					if(QuestCommand.CanQuest(c,24)) break;
					return QuestCode.A120031(c,QuestID);
				case 120035:
					//Kill 8 The Decayed at Rubble Wasteland and then tell Dulcie.
					if(QuestCommand.CanQuest(c,24)) break;
					return QuestCode.A120035(c,QuestID);
				case 120036:
					//Go to see Elroy, ask the reason of Treant\'s attack for Dulcie.
					if(QuestCommand.CanQuest(c,24)) break;
					return QuestCode.A120036(c,QuestID);
				case 120037:
					//Catch 5 Wind Weasels at Rubble Wasteland and take back to Moore.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A120037(c,QuestID);
				case 120038:
					//Help Elroy to find Magee and find out if there\'s some way to restore the magic array on the sword.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A120038(c,QuestID);
				case 120039:
					//Catch 5 Tarantulas at Rubble Wasteland and take back to Ralph.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A120039(c,QuestID);
				case 120040:
					//Take the sword enchanted by Magee to Beryl.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A120040(c,QuestID);
				case 120058:
					//Kill 15 Toothy Gerbil at Darksand Land and report to Andy.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A120058(c,QuestID);
				case 120059:
					//Ask Ingrid how to heal rheumatism for Colin.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A120059(c,QuestID);
				case 120060:
					//Catch 30 Toxic Scorpions at Darksand Land and take back to Ingrid.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A120060(c,QuestID);
				case 120061:
					//Ask Benedict about how to get food.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A120061(c,QuestID);
				case 120062:
					//Tell Andy Benedict\'s suggestion.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A120062(c,QuestID);
				case 120063:
					//Catch 20 Toothy Gerbils at Darksand Land and take them back to Andy.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A120063(c,QuestID);
				case 120064:
					//Ask Claude to detoxify for Chester\'s wife.
					if(QuestCommand.CanQuest(c,32)) break;
					return QuestCode.A120064(c,QuestID);
				case 120065:
					//Catch 20 Toxic Scorpions at Darksand Land, take them to Claude to make antidotes.
					if(QuestCommand.CanQuest(c,32)) break;
					return QuestCode.A120065(c,QuestID);
				case 120066:
					//Take Claude\'s antidotes to Chester.
					if(QuestCommand.CanQuest(c,32)) break;
					return QuestCode.A120066(c,QuestID);
				case 120067:
					//Ask Claude about salary increase.
					if(QuestCommand.CanQuest(c,32)) break;
					return QuestCode.A120067(c,QuestID);
				case 120068:
					//Tell Nelson Claude\'s promise.
					if(QuestCommand.CanQuest(c,32)) break;
					return QuestCode.A120068(c,QuestID);
				case 120069:
					//Ask Colin to derust weapon.
					if(QuestCommand.CanQuest(c,33)) break;
					return QuestCode.A120069(c,QuestID);
				case 120070:
					//Collect 4 Darksand Essence at Darksand Land and take back to Colin.
					if(QuestCommand.CanQuest(c,33)) break;
					return QuestCode.A120070(c,QuestID);
				case 120071:
					//Take the weapon reforged by Colin to Esther.
					if(QuestCommand.CanQuest(c,33)) break;
					return QuestCode.A120071(c,QuestID);
				case 120072:
					//Kill 30 Dire Wolves at Darksand Land and report to Andy.
					if(QuestCommand.CanQuest(c,34)) break;
					return QuestCode.A120072(c,QuestID);
				case 120073:
					//Ask Claude how to let Rattlesnakes quiet down at night
					if(QuestCommand.CanQuest(c,34)) break;
					return QuestCode.A120073(c,QuestID);
				case 120074:
					//Tell Lyle Claude\'s method.
					if(QuestCommand.CanQuest(c,34)) break;
					return QuestCode.A120074(c,QuestID);
				case 120075:
					//Catch 30 Toothy Gerbils at Darksand Land and take them back to Lyle.
					if(QuestCommand.CanQuest(c,34)) break;
					return QuestCode.A120075(c,QuestID);
				case 120076:
					//Catch 35 Toxic Scorpions at Darksand Land and take them back to Julian.
					if(QuestCommand.CanQuest(c,35)) break;
					return QuestCode.A120076(c,QuestID);
				case 120077:
					//Catch 35 Dire Wolves at Darksand Land and take them back to Julian.
					if(QuestCommand.CanQuest(c,35)) break;
					return QuestCode.A120077(c,QuestID);
				case 120078:
					//Catch 35 Bactrian Camels at Darksand Land and take them back to Julian.
					if(QuestCommand.CanQuest(c,35)) break;
					return QuestCode.A120078(c,QuestID);
				case 120079:
					//Catch 35 Bactrian Camels at Darksand Land and take them back to Andy.
					if(QuestCommand.CanQuest(c,36)) break;
					return QuestCode.A120079(c,QuestID);
				case 120080:
					//Ask Julian how to get fuels.
					if(QuestCommand.CanQuest(c,36)) break;
					return QuestCode.A120080(c,QuestID);
				case 120081:
					//Catch 35 Sand Fire Lizard at Darksand Land and take back to Julian.
					if(QuestCommand.CanQuest(c,36)) break;
					return QuestCode.A120081(c,QuestID);
				case 120085:
					//Catch 35 Dire Wolves at Darksand Land and take them back to Nelson.
					if(QuestCommand.CanQuest(c,38)) break;
					return QuestCode.A120085(c,QuestID);
				case 120086:
					//Tell Willa that Nelson has done what she asks.
					if(QuestCommand.CanQuest(c,38)) break;
					return QuestCode.A120086(c,QuestID);
				case 120087:
					//Catch 35 Trade Wind Fox at Darksand Land and take back to Cornell.
					if(QuestCommand.CanQuest(c,37)) break;
					return QuestCode.A120087(c,QuestID);
				case 120088:
					//Take Lyle and his broken arm to Ingrid.
					if(QuestCommand.CanQuest(c,39)) break;
					return QuestCode.A120088(c,QuestID);
				case 120089:
					//Catch 35 Sand Fire Lizards at Darksand Land and take them to Ingrid.
					if(QuestCommand.CanQuest(c,39)) break;
					return QuestCode.A120089(c,QuestID);
				case 120090:
					//Kill 35 Toxic Scorpions at Darksand Land and report to Andy.
					if(QuestCommand.CanQuest(c,39)) break;
					return QuestCode.A120090(c,QuestID);
				case 120091:
					//Ask Edgar to take out some bananas from the Inventory.
					if(QuestCommand.CanQuest(c,40)) break;
					return QuestCode.A120091(c,QuestID);
				case 120092:
					//Ask Joyce to get bananas before sunset.
					if(QuestCommand.CanQuest(c,40)) break;
					return QuestCode.A120092(c,QuestID);
				case 120093:
					//Catch 40 Phantom Monkeys in Vine Rainforest and take back to Joyce.
					if(QuestCommand.CanQuest(c,40)) break;
					return QuestCode.A120093(c,QuestID);
				case 120094:
					//Catch 40 Phantom Monkeys in Vine Rainforest and then tell Shalom.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A120094(c,QuestID);
				case 120095:
					//Find Leopold in Vine Rainforest and investigate the missing man with him.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A120095(c,QuestID);
				case 120096:
					//Catch 40 Man-eating Trees in Vine Rainforest and take back to Leopold.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A120096(c,QuestID);
				case 120097:
					//Report to Edgar the investigation result.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A120097(c,QuestID);
				case 120098:
					//Ask Monlisa how to prevent food from mouldiness.
					if(QuestCommand.CanQuest(c,42)) break;
					return QuestCode.A120098(c,QuestID);
				case 120099:
					//Catch 40 Man-eating Trees in Vine Rainforest and take back to Monlisa.
					if(QuestCommand.CanQuest(c,42)) break;
					return QuestCode.A120099(c,QuestID);
				case 120100:
					//Kill 40 Wraith Spiders in Vine Rainforest and then tell Laurie.
					if(QuestCommand.CanQuest(c,42)) break;
					return QuestCode.A120100(c,QuestID);
				case 120101:
					//Catch 40 Wraith Spiders in Vine Rainforest and take back to Thera.
					if(QuestCommand.CanQuest(c,43)) break;
					return QuestCode.A120101(c,QuestID);
				case 120102:
					//Ask Winnie how to deal with spider\'s thread.
					if(QuestCommand.CanQuest(c,43)) break;
					return QuestCode.A120102(c,QuestID);
				case 120103:
					//Take Wraith\'s Spider Thread to Thera.
					if(QuestCommand.CanQuest(c,43)) break;
					return QuestCode.A120103(c,QuestID);
				case 120104:
					//Catch 40 Wraith Spiders in Vine Rainforest and take back to Shalom.
					if(QuestCommand.CanQuest(c,44)) break;
					return QuestCode.A120104(c,QuestID);
				case 120105:
					//Ask Monlisa to help Shalom extract Wraith Spider\'s poison.
					if(QuestCommand.CanQuest(c,44)) break;
					return QuestCode.A120105(c,QuestID);
				case 120106:
					//Ask Shalom why she need to extract the poison.
					if(QuestCommand.CanQuest(c,44)) break;
					return QuestCode.A120106(c,QuestID);
				case 120107:
					//Tell Joyce Hoare\'s task.
					if(QuestCommand.CanQuest(c,45)) break;
					return QuestCode.A120107(c,QuestID);
				case 120108:
					//Catch 45 Giant Jaw Ants in Vine Rainforest and take back to Joyce.
					if(QuestCommand.CanQuest(c,45)) break;
					return QuestCode.A120108(c,QuestID);
				case 120109:
					//Catch 45 Mud Monsters in Vine Rainforest and take back to Levi.
					if(QuestCommand.CanQuest(c,45)) break;
					return QuestCode.A120109(c,QuestID);
				case 120110:
					//Ask Levi to repair the broken magic test crystal.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A120110(c,QuestID);
				case 120111:
					//Collect 5 Water Mana Spar in Vine Rainforest and take them back to Levi.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A120111(c,QuestID);
				case 120112:
					//Take the repaired Test Crystal to Hoare.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A120112(c,QuestID);
				case 120113:
					//Kill 15 Wraith Spiders, 15 Man-eating Trees, 15 Mud Monsters in Vine Rainforest and report to Ansel.
					if(QuestCommand.CanQuest(c,47)) break;
					return QuestCode.A120113(c,QuestID);
				case 120114:
					//Kill 45 Mud Monsters in Vine Rainforest and then tell Leopold.
					if(QuestCommand.CanQuest(c,47)) break;
					return QuestCode.A120114(c,QuestID);
				case 120115:
					//Ask Monlisa how to heal rheumatism.
					if(QuestCommand.CanQuest(c,48)) break;
					return QuestCode.A120115(c,QuestID);
				case 120116:
					//Catch 45 Giant Jaw Ants in Vine Rainforest and take them to Monlisa.
					if(QuestCommand.CanQuest(c,48)) break;
					return QuestCode.A120116(c,QuestID);
				case 120117:
					//Tell Levi Monlisa\'s treatment.
					if(QuestCommand.CanQuest(c,48)) break;
					return QuestCode.A120117(c,QuestID);
				case 120118:
					//Tell Levi Ansel\'s instructions.
					if(QuestCommand.CanQuest(c,49)) break;
					return QuestCode.A120118(c,QuestID);
				case 120119:
					//Catch 45 Mud Monsters in Vine Rainforest and take back to Levi.
					if(QuestCommand.CanQuest(c,49)) break;
					return QuestCode.A120119(c,QuestID);
				case 120120:
					//Ask Hyman to give Weisz a good weapon to pay the debt of gratitude.
					if(QuestCommand.CanQuest(c,50)) break;
					return QuestCode.A120120(c,QuestID);
				case 120121:
					//Ask Raymond how to get Curare Wood.
					if(QuestCommand.CanQuest(c,50)) break;
					return QuestCode.A120121(c,QuestID);
				case 120122:
					//Catch 50 Venom Monsters in Redcloud Marsh and take back to Raymond.
					if(QuestCommand.CanQuest(c,50)) break;
					return QuestCode.A120122(c,QuestID);
				case 120123:
					//Take Raymond\'s Corrosion Potion to Hyman.
					if(QuestCommand.CanQuest(c,50)) break;
					return QuestCode.A120123(c,QuestID);
				case 120124:
					//Take Hyman\'s weapon to Weisz.
					if(QuestCommand.CanQuest(c,50)) break;
					return QuestCode.A120124(c,QuestID);
				case 120125:
					//Catch 50 Venom Monsters in Redcloud Marsh and take back to Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A120125(c,QuestID);
				case 120126:
					//Ask Rodney to get a Venom Monster with wings.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A120126(c,QuestID);
				case 120127:
					//Catch 50 Short-wing Rats in Redcloud Marsh and take back to Rodney.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A120127(c,QuestID);
				case 120128:
					//Take Rodney\'s Venom Monster to Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A120128(c,QuestID);
				case 120129:
					//Tell Nicolas that Weisz has absorbed miasma in the village and ask him to solve this.
					if(QuestCommand.CanQuest(c,52)) break;
					return QuestCode.A120129(c,QuestID);
				case 120130:
					//Kill 50 Medusa in Redcloud Marsh and take their eyes to Nicolas.
					if(QuestCommand.CanQuest(c,52)) break;
					return QuestCode.A120130(c,QuestID);
				case 120131:
					//Catch 50 Venom Monsters in Redcloud Marsh and take back to Vermal.
					if(QuestCommand.CanQuest(c,52)) break;
					return QuestCode.A120131(c,QuestID);
				case 120132:
					//Catch 50 Medusa in Redcloud Marsh and take back to Raymond.
					if(QuestCommand.CanQuest(c,53)) break;
					return QuestCode.A120132(c,QuestID);
				case 120133:
					//Ask Simona to analyze the crystal crumble.
					if(QuestCommand.CanQuest(c,53)) break;
					return QuestCode.A120133(c,QuestID);
				case 120134:
					//Tell Raymond Simona\'s analysis result.
					if(QuestCommand.CanQuest(c,53)) break;
					return QuestCode.A120134(c,QuestID);
				case 120135:
					//Tell Raymond that Serena needs a bottle of colorant.
					if(QuestCommand.CanQuest(c,54)) break;
					return QuestCode.A120135(c,QuestID);
				case 120136:
					//Catch 20 Venom Monsters, 20 Medusa and 20 Mugger Crocodiles in Redcloud Marsh and take back to Raymond.
					if(QuestCommand.CanQuest(c,54)) break;
					return QuestCode.A120136(c,QuestID);
				case 120137:
					//Collect 6 Greenbell Flowers in Redcloud Marsh and take back to Raymond.
					if(QuestCommand.CanQuest(c,54)) break;
					return QuestCode.A120137(c,QuestID);
				case 120138:
					//Tell Bertram the news that his brother is murdered.
					if(QuestCommand.CanQuest(c,55)) break;
					return QuestCode.A120138(c,QuestID);
				case 120139:
					//Kill 55 Carrion in Redcloud Marsh and then tell Bertram.
					if(QuestCommand.CanQuest(c,55)) break;
					return QuestCode.A120139(c,QuestID);
				case 120140:
					//Kill 5 Giant Carrion in Redcloud Marsh and then tell Bertram.
					if(QuestCommand.CanQuest(c,55)) break;
					return QuestCode.A120140(c,QuestID);
				case 120141:
					//Kill 55 Carrion in Redcloud Marsh and then tell Serena.
					if(QuestCommand.CanQuest(c,56)) break;
					return QuestCode.A120141(c,QuestID);
				case 120142:
					//Ask Rodney where to find the stones to build house.
					if(QuestCommand.CanQuest(c,56)) break;
					return QuestCode.A120142(c,QuestID);
				case 120143:
					//Catch 55 Short-wing Rats in Redcloud Marsh and take back to Rodney.
					if(QuestCommand.CanQuest(c,56)) break;
					return QuestCode.A120143(c,QuestID);
				case 120144:
					//Tell Blair Osmond\'s requirement and conditions.
					if(QuestCommand.CanQuest(c,57)) break;
					return QuestCode.A120144(c,QuestID);
				case 120145:
					//Catch 55 Mugger Crocodiles in Redcloud Marsh and take back to Blair.
					if(QuestCommand.CanQuest(c,57)) break;
					return QuestCode.A120145(c,QuestID);
				case 120146:
					//Catch 55 Short-wing Rats in Redcloud Marsh and take back to Blair.
					if(QuestCommand.CanQuest(c,57)) break;
					return QuestCode.A120146(c,QuestID);
				case 120147:
					//Tell Mabel Osmond\'s task and ask her to find out the truth asap.
					if(QuestCommand.CanQuest(c,58)) break;
					return QuestCode.A120147(c,QuestID);
				case 120148:
					//Tell Osmond Mabel\'s findings.
					if(QuestCommand.CanQuest(c,58)) break;
					return QuestCode.A120148(c,QuestID);
				case 120149:
					//Kill 55 Carrion in Redcloud Marsh and then tell Osmond.
					if(QuestCommand.CanQuest(c,58)) break;
					return QuestCode.A120149(c,QuestID);
				case 120150:
					//Help Weisz to ask Serena the materials for making quality leather bag.
					if(QuestCommand.CanQuest(c,59)) break;
					return QuestCode.A120150(c,QuestID);
				case 120151:
					//Tell Weisz Serena\'s advice.
					if(QuestCommand.CanQuest(c,59)) break;
					return QuestCode.A120151(c,QuestID);
				case 120152:
					//Kill 55 Mugger Crocodiles in Redcloud Marsh and take the crocodile skin to Weisz.
					if(QuestCommand.CanQuest(c,59)) break;
					return QuestCode.A120152(c,QuestID);
				case 120153:
					//Ask Angelo the where Atwood is.
					if(QuestCommand.CanQuest(c,60)) break;
					return QuestCode.A120153(c,QuestID);
				case 120154:
					//Ask Omar to make some potions that can remove petrification.
					if(QuestCommand.CanQuest(c,60)) break;
					return QuestCode.A120154(c,QuestID);
				case 120155:
					//Catch 60 Stone Lizards in Darkwind Canyon and bring them back to Omar.
					if(QuestCommand.CanQuest(c,60)) break;
					return QuestCode.A120155(c,QuestID);
				case 120156:
					//Kill 60 Darkwind Wolves in Darkwind Canyon and then tell Bertha.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A120156(c,QuestID);
				case 120157:
					//Find Morgan, ask him to identify the thing Bertha just dug out.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A120157(c,QuestID);
				case 120158:
					//Catch 60 Canyon Centaurs in Darkwind Canyon and bring them back to Morgan.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A120158(c,QuestID);
				case 120159:
					//Ask Atwood about being smashed.
					if(QuestCommand.CanQuest(c,62)) break;
					return QuestCode.A120159(c,QuestID);
				case 120160:
					//Ask Bella what kind of beast Black Dot is.
					if(QuestCommand.CanQuest(c,62)) break;
					return QuestCode.A120160(c,QuestID);
				case 120161:
					//Kill 60 Canyon Eagles in Darkwind Canyon and then tell Bella.
					if(QuestCommand.CanQuest(c,62)) break;
					return QuestCode.A120161(c,QuestID);
				case 120162:
					//Ask Angelo why Canyon Eagle attacked human.
					if(QuestCommand.CanQuest(c,63)) break;
					return QuestCode.A120162(c,QuestID);
				case 120163:
					//Kill 60 Canyon Centaurs in Darkwind Canyon and then tell Angelo.
					if(QuestCommand.CanQuest(c,63)) break;
					return QuestCode.A120163(c,QuestID);
				case 120164:
					//Ask Omar if there\'s anything that can help Jeffrey to sleep.
					if(QuestCommand.CanQuest(c,63)) break;
					return QuestCode.A120164(c,QuestID);
				case 120165:
					//Catch 60 Stone Lizards in Darkwind Canyon and bring them back to Omar.
					if(QuestCommand.CanQuest(c,63)) break;
					return QuestCode.A120165(c,QuestID);
				case 120166:
					//Ask Bertha what kind of pact with beast she wants.
					if(QuestCommand.CanQuest(c,64)) break;
					return QuestCode.A120166(c,QuestID);
				case 120167:
					//Tell Theodore Bertha\'s decision.
					if(QuestCommand.CanQuest(c,64)) break;
					return QuestCode.A120167(c,QuestID);
				case 120168:
					//Catch 60 Darkwind Hunters in Darkwind Canyon and bring them back to Theodore.
					if(QuestCommand.CanQuest(c,64)) break;
					return QuestCode.A120168(c,QuestID);
				case 120169:
					//Ask Jeffrey if there\'s a way to calm down the wolves in the canyon.
					if(QuestCommand.CanQuest(c,65)) break;
					return QuestCode.A120169(c,QuestID);
				case 120170:
					//Kill 65 Darkwind Wolves in Darkwind Canyon and then report to Jeffrey.
					if(QuestCommand.CanQuest(c,65)) break;
					return QuestCode.A120170(c,QuestID);
				case 120171:
					//Tell Angelo about Jeffrey\'s warning, asking him not to confront the werewolves directly.
					if(QuestCommand.CanQuest(c,65)) break;
					return QuestCode.A120171(c,QuestID);
				case 120172:
					//Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Veronica.
					if(QuestCommand.CanQuest(c,66)) break;
					return QuestCode.A120172(c,QuestID);
				case 120173:
					//Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Veronica.
					if(QuestCommand.CanQuest(c,66)) break;
					return QuestCode.A120173(c,QuestID);
				case 120174:
					//Catch 65 Darkwind Eagles in Darkwind Canyon and bring them back to Veronica.
					if(QuestCommand.CanQuest(c,66)) break;
					return QuestCode.A120174(c,QuestID);
				case 120175:
					//Ask Alger about how to deal with Canyon Centaur.
					if(QuestCommand.CanQuest(c,67)) break;
					return QuestCode.A120175(c,QuestID);
				case 120176:
					//Kill 3 Head Centaurs in Darkwind Canyon and then tell Alger.
					if(QuestCommand.CanQuest(c,67)) break;
					return QuestCode.A120176(c,QuestID);
				case 120177:
					//Kill 65 Canyon Centaurs in Darkwind Canyon and then tell Alger.
					if(QuestCommand.CanQuest(c,67)) break;
					return QuestCode.A120177(c,QuestID);
				case 120178:
					//Catch 65 Darkwind Wolves in Darkwind Canyon and bring them back to Omar.
					if(QuestCommand.CanQuest(c,68)) break;
					return QuestCode.A120178(c,QuestID);
				case 120179:
					//Catch 65 Darkwind Hunters in Darkwind Canyon and bring them back to Omar.
					if(QuestCommand.CanQuest(c,68)) break;
					return QuestCode.A120179(c,QuestID);
				case 120180:
					//Catch 65 Stone Lizards in Darkwind Canyon and bring them back to Omar.
					if(QuestCommand.CanQuest(c,68)) break;
					return QuestCode.A120180(c,QuestID);
				case 120181:
					//Ask Omar if there\'s a way to make a potion that contains wind element.
					if(QuestCommand.CanQuest(c,69)) break;
					return QuestCode.A120181(c,QuestID);
				case 120182:
					//Catch 65 Canyon Eagles in Darkwind Canyon and bring them back to Omar.
					if(QuestCommand.CanQuest(c,69)) break;
					return QuestCode.A120182(c,QuestID);
				case 120183:
					//Bring the wind crystal stone made by Omar to Amos.
					if(QuestCommand.CanQuest(c,69)) break;
					return QuestCode.A120183(c,QuestID);
				case 120184:
					//Ask Gavin whether beasts to be used in this year\'s Beast\'s Festival are ready.
					if(QuestCommand.CanQuest(c,70)) break;
					return QuestCode.A120184(c,QuestID);
				case 120185:
					//Kill 70 Foggy Vampires in Foggy Forest and bring them back to Francis.
					if(QuestCommand.CanQuest(c,70)) break;
					return QuestCode.A120185(c,QuestID);
				case 120186:
					//Bring the Foggy Vampire trained by Gavin to Francis.
					if(QuestCommand.CanQuest(c,70)) break;
					return QuestCode.A120186(c,QuestID);
				case 120187:
					//Help Cesar to ask Xaviera if she received the gift.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A120187(c,QuestID);
				case 120188:
					//Kill 70 Foggy Bears in Foggy Forest and then tell Xaviera.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A120188(c,QuestID);
				case 120189:
					//Collect 6 Foggy Roses in Foggy Forest and bring them back to Xaviera.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A120189(c,QuestID);
				case 120190:
					//Kill 70 Foggy Spiders in Foggy Forest and bring them back to Cyril.
					if(QuestCommand.CanQuest(c,72)) break;
					return QuestCode.A120190(c,QuestID);
				case 120191:
					//Bring the fried spider leg made by Cyril to Claire.
					if(QuestCommand.CanQuest(c,72)) break;
					return QuestCode.A120191(c,QuestID);
				case 120192:
					//Catch 70 Foggy Bears in Foggy Forest and bring them back to Claire.
					if(QuestCommand.CanQuest(c,72)) break;
					return QuestCode.A120192(c,QuestID);
				case 120193:
					//Ask Jabman to make a Promotion Test for you.
					if(QuestCommand.CanQuest(c,73)) break;
					return QuestCode.A120193(c,QuestID);
				case 120194:
					//Kill 70 Foggy Vampires in Foggy Forest and them tell Jabman.
					if(QuestCommand.CanQuest(c,73)) break;
					return QuestCode.A120194(c,QuestID);
				case 120195:
					//Kill 5 Head Berserks in Foggy Forest and then tell Jabman.
					if(QuestCommand.CanQuest(c,73)) break;
					return QuestCode.A120195(c,QuestID);
				case 120196:
					//Kill 70 Dawn Elves in Foggy Forest and then tell Gavin.
					if(QuestCommand.CanQuest(c,74)) break;
					return QuestCode.A120196(c,QuestID);
				case 120197:
					//Tell Dark Castle\'s Jabman about Gavin\'s finding.
					if(QuestCommand.CanQuest(c,74)) break;
					return QuestCode.A120197(c,QuestID);
				case 120198:
					//Kill 70 Berserk Warriors in Foggy Forest and then tell Teddy.
					if(QuestCommand.CanQuest(c,74)) break;
					return QuestCode.A120198(c,QuestID);
				case 120199:
					//Go to Dark Castle and ask Inquiry how to solve the problem of too cold to sleep.
					if(QuestCommand.CanQuest(c,75)) break;
					return QuestCode.A120199(c,QuestID);
				case 120200:
					//Kill 75 Foggy Spiders in Foggy Forest and bring them back to Zelene.
					if(QuestCommand.CanQuest(c,75)) break;
					return QuestCode.A120200(c,QuestID);
				case 120201:
					//Bring the cobweb extracted by Zelene to Candice.
					if(QuestCommand.CanQuest(c,75)) break;
					return QuestCode.A120201(c,QuestID);
				case 120202:
					//Ask Gavin for a batch of magic scrolls.
					if(QuestCommand.CanQuest(c,76)) break;
					return QuestCode.A120202(c,QuestID);
				case 120203:
					//Catch 75 Foggy Bears in Foggy Forest and bring them back to Gavin.
					if(QuestCommand.CanQuest(c,76)) break;
					return QuestCode.A120203(c,QuestID);
				case 120204:
					//Bring the foggy bear fur made by Gavin to Yuna.
					if(QuestCommand.CanQuest(c,76)) break;
					return QuestCode.A120204(c,QuestID);
				case 120205:
					//Catch 75 Berserk Warriors in Foggy Forest and bring them back to Parker.
					if(QuestCommand.CanQuest(c,77)) break;
					return QuestCode.A120205(c,QuestID);
				case 120206:
					//Catch 5 Head Berserks in Foggy Forest and bring them back to Parker.
					if(QuestCommand.CanQuest(c,77)) break;
					return QuestCode.A120206(c,QuestID);
				case 120207:
					//Tell Claymond about Parker\'s finding.
					if(QuestCommand.CanQuest(c,77)) break;
					return QuestCode.A120207(c,QuestID);
				case 120208:
					//Tell Dark about Jabman\'s instructions.
					if(QuestCommand.CanQuest(c,78)) break;
					return QuestCode.A120208(c,QuestID);
				case 120209:
					//Catch 3000 Foggy Vampires in Foggy Forest and bring them back to Dark.
					if(QuestCommand.CanQuest(c,78)) break;
					return QuestCode.A120209(c,QuestID);
				case 120210:
					//Tell Jabman that Dark is training Foggy Vampire.
					if(QuestCommand.CanQuest(c,78)) break;
					return QuestCode.A120210(c,QuestID);
				case 120211:
					//Ask Jabman how to break through the magic barrier.
					if(QuestCommand.CanQuest(c,79)) break;
					return QuestCode.A120211(c,QuestID);
				case 120212:
					//Catch 75 Foggy Spiders in Foggy Forest and bring them back to Jabman.
					if(QuestCommand.CanQuest(c,79)) break;
					return QuestCode.A120212(c,QuestID);
				case 120213:
					//Bring the Foggy Spider trained by Jabman to Gavin.
					if(QuestCommand.CanQuest(c,79)) break;
					return QuestCode.A120213(c,QuestID);
				case 120214:
					//Help Isaac to ask Jonas if he had any new findings.
					if(QuestCommand.CanQuest(c,80)) break;
					return QuestCode.A120214(c,QuestID);
				case 120215:
					//Catch 80 Lost Acolytes on the Henan Mountainside and bring them to Jonas.
					if(QuestCommand.CanQuest(c,80)) break;
					return QuestCode.A120215(c,QuestID);
				case 120216:
					//Go to Henan Mountain and tell Isaac Jonas\'s discovery.
					if(QuestCommand.CanQuest(c,80)) break;
					return QuestCode.A120216(c,QuestID);
				case 120217:
					//Follow Marlon\'s order and go to Henan Mountainside to find Nate.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A120217(c,QuestID);
				case 120218:
					//Catch 80 Carefree Beasts on the Henan Mountainside and bring them to Nate.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A120218(c,QuestID);
				case 120219:
					//Give Marlon the Carefree Beast\'s Blood that collected by Nade.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A120219(c,QuestID);
				case 120220:
					//Ask Lance about the way of making Crystal for Kim.
					if(QuestCommand.CanQuest(c,82)) break;
					return QuestCode.A120220(c,QuestID);
				case 120221:
					//Catch 80 Spirit Dragons on the Henan Mountainside and bring them to Lance.
					if(QuestCommand.CanQuest(c,82)) break;
					return QuestCode.A120221(c,QuestID);
				case 120222:
					//Give Kim the Crystal made by Lance.
					if(QuestCommand.CanQuest(c,82)) break;
					return QuestCode.A120222(c,QuestID);
				case 120223:
					//Ask Mitchell about the way of keeping scent for Grace.
					if(QuestCommand.CanQuest(c,83)) break;
					return QuestCode.A120223(c,QuestID);
				case 120224:
					//Catch 80 Carefree Beasts on the Henan Mountainside and bring them to Mitchell.
					if(QuestCommand.CanQuest(c,83)) break;
					return QuestCode.A120224(c,QuestID);
				case 120225:
					//Give Grace the perfume made by Mitchell.
					if(QuestCommand.CanQuest(c,83)) break;
					return QuestCode.A120225(c,QuestID);
				case 120226:
					//Defeat 30 Dark Carefree Beasts on the Henan Moutainside then go back and tell Jeremy.
					if(QuestCommand.CanQuest(c,84)) break;
					return QuestCode.A120226(c,QuestID);
				case 120227:
					//Ask Isaac about the reason why the Dark Carefree Beast went mad for Jeremy.
					if(QuestCommand.CanQuest(c,84)) break;
					return QuestCode.A120227(c,QuestID);
				case 120228:
					//Go to Henan Mountain and tell Jeremy Isaac\'s warning.
					if(QuestCommand.CanQuest(c,84)) break;
					return QuestCode.A120228(c,QuestID);
				case 120229:
					//Ask Marlon about how to repair the armor for Kelly.
					if(QuestCommand.CanQuest(c,85)) break;
					return QuestCode.A120229(c,QuestID);
				case 120230:
					//Catch 85 Skyish Beasts on the Henan Mountainside and bring them to Marlon.
					if(QuestCommand.CanQuest(c,85)) break;
					return QuestCode.A120230(c,QuestID);
				case 120231:
					//Give the armor that fixed by Markon to Kelly.
					if(QuestCommand.CanQuest(c,85)) break;
					return QuestCode.A120231(c,QuestID);
				case 120232:
					//Ask Jonas about the way of making magic gloves for Nate.
					if(QuestCommand.CanQuest(c,86)) break;
					return QuestCode.A120232(c,QuestID);
				case 120233:
					//Catch 85 Bubble Beasts on the Henan Mountainside and bring them to Jonas.
					if(QuestCommand.CanQuest(c,86)) break;
					return QuestCode.A120233(c,QuestID);
				case 120234:
					//Give the magic gloves that made by Jonas to Nate.
					if(QuestCommand.CanQuest(c,86)) break;
					return QuestCode.A120234(c,QuestID);
				case 120235:
					//Ask Jared about the way to treat red rash for Grace.
					if(QuestCommand.CanQuest(c,87)) break;
					return QuestCode.A120235(c,QuestID);
				case 120236:
					//Catch 85 Skyish Beasts on the Henan Mountainside and bring them to Jared.
					if(QuestCommand.CanQuest(c,87)) break;
					return QuestCode.A120236(c,QuestID);
				case 120237:
					//Give Grace the perfume made by Jared.
					if(QuestCommand.CanQuest(c,87)) break;
					return QuestCode.A120237(c,QuestID);
				case 120238:
					//Kill 85 Carefree Beasts on the Henan Mountainside then go back and report to Jeremy.
					if(QuestCommand.CanQuest(c,88)) break;
					return QuestCode.A120238(c,QuestID);
				case 120239:
					//Kill 85 Spirit Dragons on the Henan Mountainside then go back and report to Jeremy.
					if(QuestCommand.CanQuest(c,88)) break;
					return QuestCode.A120239(c,QuestID);
				case 120240:
					//Kill 30 Dark Carefree Beasts on the Henan Moutainside then go back and tell Jeremy.
					if(QuestCommand.CanQuest(c,88)) break;
					return QuestCode.A120240(c,QuestID);
				case 120241:
					//Catch 85 Spirit Dragons on the Henan Mountainside and bring them to Jared.
					if(QuestCommand.CanQuest(c,89)) break;
					return QuestCode.A120241(c,QuestID);
				case 120242:
					//Give Mitchell Jared\'s Dragon Scale.
					if(QuestCommand.CanQuest(c,89)) break;
					return QuestCode.A120242(c,QuestID);
				case 120243:
					//Give Jared the Dragon Scale Shield made by Mitchell.
					if(QuestCommand.CanQuest(c,89)) break;
					return QuestCode.A120243(c,QuestID);
				case 129001:
					//Ask General Mandel the origin of Zodiac Wings.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A129001(c,QuestID);
				case 129002:
					//Kill the man of specified constellation to get starsoul with specified attribute. When the total fusion level of the attribute constellation reaches lv.4, star wings will be unlocked.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A129002(c,QuestID);
				case 129004:
					//Top up once and get your reward from Edith.
					if(QuestCommand.CanQuest(c,22)) break;
					return QuestCode.A129004(c,QuestID);
				case 129011:
					//Find Edith for Charles.
					if(QuestCommand.CanQuest(c,25)) break;
					return QuestCode.A129011(c,QuestID);
				case 129016:
					//Go to City of Genesis, upgrade your level at Stargazer Goya.
					if(QuestCommand.CanQuest(c,27)) break;
					return QuestCode.A129016(c,QuestID);
				case 129017:
					//Enter Stargazer\'s Tower, defeat one Puppet Man·Green and one Puppet Mage·Green, then find Goya to complete the quest.
					if(QuestCommand.CanQuest(c,27)) break;
					return QuestCode.A129017(c,QuestID);
				case 129019:
					//Enter Zodiac Dream1, defeat Little Suslik*2 and Green Gulu*2, then find Jason to complete the quest.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A129019(c,QuestID);
				case 130001:
					//Enter Dawn Pier, kill Meister Warlock*4, Meister Guard*4, Blade Master·Gudark*1, then report to Jeff.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130001(c,QuestID);
				case 130002:
					//Enter Sky City, kill Sky Crocodile*6, Cloud Dragon*6, Sky Mask*6, Faux· Emohill*1, then report to Beryl.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130002(c,QuestID);
				case 130003:
					//Go to 4 God Temple, kill 5 Priest of Fear, 5 Priest of Envy, 1 Priest of Greed, 1 Oracle of Pride, and then report to Blanche.
					if(QuestCommand.CanQuest(c,34)) break;
					return QuestCode.A130003(c,QuestID);
				case 130005:
					//Go to Blade Hill, defeat 4 Sword\'s Slaves, 4 Spirit Beasts, 1 Sword!$Starry Sky, 1 Sword!$Moonlight, then report to Aubrey.
					if(QuestCommand.CanQuest(c,40)) break;
					return QuestCode.A130005(c,QuestID);
				case 130006:
					//Go to Holy Land, defeat 5 Battle Spirit, 5 Sage Mentors, 1 Mentor!$Swift, 1 Shine\'s Father, then report to Adonis.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A130006(c,QuestID);
				case 130007:
					//Go to Holy Fire Origin, defeat 5 Life Element, 5 Death Element, 1 War God\'s Image, 1 War God\'s Image, then report to Barton.
					if(QuestCommand.CanQuest(c,52)) break;
					return QuestCode.A130007(c,QuestID);
				case 130009:
					//Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
					if(QuestCommand.CanQuest(c,28)) break;
					return QuestCode.A130009(c,QuestID);
				case 130010:
					//Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
					if(QuestCommand.CanQuest(c,28)) break;
					return QuestCode.A130010(c,QuestID);
				case 130011:
					//Transport supplies through City of Genesis and Land of Trial, and then take them to the Empire\'s Supply Officer.
					if(QuestCommand.CanQuest(c,28)) break;
					return QuestCode.A130011(c,QuestID);
				case 130022:
					//Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A130022(c,QuestID);
				case 130023:
					//Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A130023(c,QuestID);
				case 130024:
					//Defeat a player of the opponent country, then go to City of Genesis to find General Mandel.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A130024(c,QuestID);
				case 130054:
					//Kill 30 Toothy Gerbil in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130054(c,QuestID);
				case 130055:
					//Kill 30 Toxic Scorpions in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130055(c,QuestID);
				case 130056:
					//Kill 30 Rattlesnakes in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130056(c,QuestID);
				case 130057:
					//Kill 10 Swantony in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130057(c,QuestID);
				case 130058:
					//Kill 40 Dire Wolf in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130058(c,QuestID);
				case 130059:
					//Kill 40 Toothy Gerbil in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130059(c,QuestID);
				case 130060:
					//Kill 10 Benson in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130060(c,QuestID);
				case 130061:
					//Kill 50 Sand Fire Lizards in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130061(c,QuestID);
				case 130062:
					//Kill 50 Trade Wind Foxes in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130062(c,QuestID);
				case 130063:
					//Kill 10 Swantony in Darksand and then tell Lune Oasis\'s Chester.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130063(c,QuestID);
				case 130073:
					//Defeat 30 Toothy Gerbil in Darksand and then tell Darksand\'s Lyle.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130073(c,QuestID);
				case 130074:
					//Defeat 30 Dire Wolves in Darksand and then tell Darksand\'s Lyle.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130074(c,QuestID);
				case 130075:
					//Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130075(c,QuestID);
				case 130076:
					//Defeat 40 Toxic Scorpions in Darksand and then tell Darksand\'s Lyle.
					if(QuestCommand.CanQuest(c,35)) break;
					return QuestCode.A130076(c,QuestID);
				case 130077:
					//Defeat 40 Bactrian Camels in Darksand and then tell Darksand\'s Lyle.
					if(QuestCommand.CanQuest(c,35)) break;
					return QuestCode.A130077(c,QuestID);
				case 130078:
					//Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
					if(QuestCommand.CanQuest(c,35)) break;
					return QuestCode.A130078(c,QuestID);
				case 130079:
					//Defeat 50 Rattlesnakes in Darksand and then tell Darksand\'s Lyle.
					if(QuestCommand.CanQuest(c,38)) break;
					return QuestCode.A130079(c,QuestID);
				case 130080:
					//Defeat 50 Trade Wind Fox in Darksand and then tell Darksand\'s Lyle.
					if(QuestCommand.CanQuest(c,38)) break;
					return QuestCode.A130080(c,QuestID);
				case 130081:
					//Defeat 5 Swantony and 5 Benson in Darksand and then tell Darksand\'s Lyle.
					if(QuestCommand.CanQuest(c,38)) break;
					return QuestCode.A130081(c,QuestID);
				case 130082:
					//Kill 30 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130082(c,QuestID);
				case 130083:
					//Kill 30 Man-eating Trees in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130083(c,QuestID);
				case 130084:
					//Kill 30 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130084(c,QuestID);
				case 130085:
					//Kill 10 Baird in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130085(c,QuestID);
				case 130086:
					//Kill 40 Wraith Spiders in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130086(c,QuestID);
				case 130087:
					//Kill 40 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130087(c,QuestID);
				case 130088:
					//Kill 10 Archer in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130088(c,QuestID);
				case 130089:
					//Kill 50 Mud Monsters in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130089(c,QuestID);
				case 130090:
					//Kill 50 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130090(c,QuestID);
				case 130091:
					//Kill 10 Baird in Vine Rainforest and then tell Tramp Camp\'s Hoare.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130091(c,QuestID);
				case 130101:
					//Defeat 30 Phantom Monkeys in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130101(c,QuestID);
				case 130102:
					//Defeat 30 Wraith Spiders in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130102(c,QuestID);
				case 130103:
					//Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A130103(c,QuestID);
				case 130104:
					//Defeat 40 Man-eating Tree in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(QuestCommand.CanQuest(c,45)) break;
					return QuestCode.A130104(c,QuestID);
				case 130105:
					//Defeat 40 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(QuestCommand.CanQuest(c,45)) break;
					return QuestCode.A130105(c,QuestID);
				case 130106:
					//Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(QuestCommand.CanQuest(c,45)) break;
					return QuestCode.A130106(c,QuestID);
				case 130107:
					//Defeat 50 Mud Monsters in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(QuestCommand.CanQuest(c,48)) break;
					return QuestCode.A130107(c,QuestID);
				case 130108:
					//Defeat 50 Giant Jaw Ants in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(QuestCommand.CanQuest(c,48)) break;
					return QuestCode.A130108(c,QuestID);
				case 130109:
					//Defeat 5 Baird and 5 Archer in Vine Rainforest and then tell Tramp Camp\'s Levi.
					if(QuestCommand.CanQuest(c,48)) break;
					return QuestCode.A130109(c,QuestID);
				case 130110:
					//Enter Dawn Pier, kill Meister Swordsman*4, Head Warlock Karl*1, Lead Guard Danton*1, then go to City of Genesis and tell Burton.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130110(c,QuestID);
				case 130111:
					//Enter Sky City, kill Kamaitachi*6, Cloud Elf*6, Head Sky Crocodile*1, Cloud Elf King*1, then go to City of Genesis and tell Burton.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130111(c,QuestID);
				case 130112:
					//Go to 4 God Temple, kill 5 Priest of Pride, 5 Bishop of Greed, 1 Oracle of Envy, 1 Oracle of Terror, then go back to the City of Genesis and tell Larry.
					if(QuestCommand.CanQuest(c,34)) break;
					return QuestCode.A130112(c,QuestID);
				case 130114:
					//Go to Blade Hill, Defeat 4 Sword\'s Spirit, 4 Fierce Beast, 1 Scabbard!$Chaos, then go back to the City of Genesis and tell Larry.
					if(QuestCommand.CanQuest(c,40)) break;
					return QuestCode.A130114(c,QuestID);
				case 130115:
					//Go to Holy Land, Defeat 5 Element Spirit, 5 Killer Mentors, 1 Mentor!$Fearless, then go back to the City of Genesis and tell Larry.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A130115(c,QuestID);
				case 130116:
					//Go to Holy Fire Origin, defeat 5 Light Element, 5 Dark Element, 1 War God\'s Image, 1 Wisdom God\'s Image, then go back to the City of Genesis and tell Larry.
					if(QuestCommand.CanQuest(c,52)) break;
					return QuestCode.A130116(c,QuestID);
				case 130117:
					//Attack Dragon Cave and then report to Quenton.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A130117(c,QuestID);
				case 130118:
					//Attack Dragon Cave and then report to Quenton.
					if(QuestCommand.CanQuest(c,37)) break;
					return QuestCode.A130118(c,QuestID);
				case 130119:
					//Attack Dragon Cave and then report to Quenton.
					if(QuestCommand.CanQuest(c,47)) break;
					return QuestCode.A130119(c,QuestID);
				case 130120:
					//Complete Stargazer\'s Tower, then report to Stargazer Goya.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A130120(c,QuestID);
				case 130121:
					//Complete Stargazer\'s Tower, then report to Stargazer Goya.
					if(QuestCommand.CanQuest(c,36)) break;
					return QuestCode.A130121(c,QuestID);
				case 130122:
					//Complete Stargazer\'s Tower, then report to Stargazer Goya.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A130122(c,QuestID);
				case 130123:
					//Kill 30 Venom Monsters in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130123(c,QuestID);
				case 130124:
					//Kill 30 Short-wing Rats in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130124(c,QuestID);
				case 130125:
					//Kill 30 Medusa in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130125(c,QuestID);
				case 130126:
					//Kill 10 Olive in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130126(c,QuestID);
				case 130127:
					//Kill 40 Short-wing Rats in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130127(c,QuestID);
				case 130128:
					//Kill 40 Mugger Crocodiles in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130128(c,QuestID);
				case 130129:
					//Kill 10 Giant Carrion in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130129(c,QuestID);
				case 130130:
					//Kill 50 Carrion in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130130(c,QuestID);
				case 130131:
					//Kill 50 Medusa in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130131(c,QuestID);
				case 130132:
					//Kill 10 Olive in Redcloud Marsh and then tell Pearl Village\'s Osmond.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130132(c,QuestID);
				case 130136:
					//Defeat 30 Medusa in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130136(c,QuestID);
				case 130137:
					//Defeat 30 Mugger Crocodiles in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130137(c,QuestID);
				case 130138:
					//Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A130138(c,QuestID);
				case 130139:
					//Defeat 40 Venom Monsters in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(QuestCommand.CanQuest(c,55)) break;
					return QuestCode.A130139(c,QuestID);
				case 130140:
					//Defeat 40 Medusa in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(QuestCommand.CanQuest(c,55)) break;
					return QuestCode.A130140(c,QuestID);
				case 130141:
					//Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(QuestCommand.CanQuest(c,55)) break;
					return QuestCode.A130141(c,QuestID);
				case 130142:
					//Defeat 50 Short-wing Rats in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(QuestCommand.CanQuest(c,58)) break;
					return QuestCode.A130142(c,QuestID);
				case 130143:
					//Defeat 50 Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(QuestCommand.CanQuest(c,58)) break;
					return QuestCode.A130143(c,QuestID);
				case 130144:
					//Defeat 5 Olive and 5 Giant Carrion in Redcloud Marsh and then tell Redcloud Marsh\'s Simona.
					if(QuestCommand.CanQuest(c,58)) break;
					return QuestCode.A130144(c,QuestID);
				case 130145:
					//Kill 30 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130145(c,QuestID);
				case 130146:
					//Kill 30 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130146(c,QuestID);
				case 130147:
					//Kill 30 Canyon Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130147(c,QuestID);
				case 130148:
					//Kill 10 Shadow Assassins in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130148(c,QuestID);
				case 130149:
					//Kill 40 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130149(c,QuestID);
				case 130150:
					//Kill 40 Stone Lizards in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130150(c,QuestID);
				case 130151:
					//Kill 10 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130151(c,QuestID);
				case 130152:
					//Kill 50 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130152(c,QuestID);
				case 130153:
					//Kill 50 Canyon Eagles in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130153(c,QuestID);
				case 130154:
					//Kill 10 Shadow Assassins in Darkwind Canyon and then tell Darkwind Canyon\'s Angelo.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130154(c,QuestID);
				case 130155:
					//Kill 30 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130155(c,QuestID);
				case 130156:
					//Kill 30 Darkwind Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130156(c,QuestID);
				case 130157:
					//Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood。
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A130157(c,QuestID);
				case 130158:
					//Kill 40 Darkwind Wolves in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(QuestCommand.CanQuest(c,65)) break;
					return QuestCode.A130158(c,QuestID);
				case 130159:
					//Kill 40 Darkwind Hunters in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(QuestCommand.CanQuest(c,65)) break;
					return QuestCode.A130159(c,QuestID);
				case 130160:
					//Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(QuestCommand.CanQuest(c,65)) break;
					return QuestCode.A130160(c,QuestID);
				case 130161:
					//Kill 50 Stone Lizards in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(QuestCommand.CanQuest(c,68)) break;
					return QuestCode.A130161(c,QuestID);
				case 130162:
					//Kill 50 Canyon Eagles in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(QuestCommand.CanQuest(c,68)) break;
					return QuestCode.A130162(c,QuestID);
				case 130163:
					//Defeat 5 Shadow Assassins and 5 Head Centaurs in Darkwind Canyon and then tell Darkwind Canyon\'s Atwood.
					if(QuestCommand.CanQuest(c,68)) break;
					return QuestCode.A130163(c,QuestID);
				case 130164:
					//Enter Starsoul instance, kill Ghost Sage·Borg, then go to see Morton.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130164(c,QuestID);
				case 130165:
					//Enter Starsoul instance, use 5 dream points, then go to see Charles.
					if(QuestCommand.CanQuest(c,30)) break;
					return QuestCode.A130165(c,QuestID);
				case 130166:
					//Enter Pharmacy, kill 3 Mana Potion Tyro, 3 HP Potion Tyro, 1 Druggist Kein, then report to Druggist Elo.
					if(QuestCommand.CanQuest(c,62)) break;
					return QuestCode.A130166(c,QuestID);
				case 130167:
					//Enter Pharmacy, kill 3 STR Potion Tyro, 3 DEF Potion Tyro, 1 Druggist Luyer, then back to City of Genesis and tell Burton.
					if(QuestCommand.CanQuest(c,62)) break;
					return QuestCode.A130167(c,QuestID);
				case 130168:
					//Kill 30 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130168(c,QuestID);
				case 130169:
					//Kill 30 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130169(c,QuestID);
				case 130170:
					//Kill 30 Berserk Warriors in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130170(c,QuestID);
				case 130171:
					//Kill 10 Head Berserks in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130171(c,QuestID);
				case 130172:
					//Kill 40 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130172(c,QuestID);
				case 130173:
					//Kill 40 Foggy Spiders in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130173(c,QuestID);
				case 130174:
					//Kill 10 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130174(c,QuestID);
				case 130175:
					//Kill 50 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130175(c,QuestID);
				case 130176:
					//Kill 50 Dawn Elves in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130176(c,QuestID);
				case 130177:
					//Kill 10 Head Berserks in Foggy Forest and then tell Foggy Forest\'s Gavin.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130177(c,QuestID);
				case 130178:
					//Kill 30 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130178(c,QuestID);
				case 130179:
					//Kill 30 Berserk Warriors in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130179(c,QuestID);
				case 130180:
					//Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(QuestCommand.CanQuest(c,71)) break;
					return QuestCode.A130180(c,QuestID);
				case 130181:
					//Kill 40 Foggy Bears in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(QuestCommand.CanQuest(c,75)) break;
					return QuestCode.A130181(c,QuestID);
				case 130182:
					//Kill 40 Foggy Vampires in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(QuestCommand.CanQuest(c,75)) break;
					return QuestCode.A130182(c,QuestID);
				case 130183:
					//Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(QuestCommand.CanQuest(c,75)) break;
					return QuestCode.A130183(c,QuestID);
				case 130184:
					//Kill 50 Foggy Spiders in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(QuestCommand.CanQuest(c,78)) break;
					return QuestCode.A130184(c,QuestID);
				case 130185:
					//Kill 50 Dawn Elves in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(QuestCommand.CanQuest(c,78)) break;
					return QuestCode.A130185(c,QuestID);
				case 130186:
					//Kill 5 Head Berserks and 5 Wind Rider Rita in Foggy Forest and then tell Foggy Forest\'s Dark.
					if(QuestCommand.CanQuest(c,78)) break;
					return QuestCode.A130186(c,QuestID);
				case 130188:
					//Enter Candy Shop, kill 3 Chocolate Guards, 3 Milk Guards, 1 Tooth Decay King, then report to Alchemist Nami.
					if(QuestCommand.CanQuest(c,72)) break;
					return QuestCode.A130188(c,QuestID);
				case 130189:
					//Enter Candy Shop, kill 3 Mango Milktea Guards, 3 Strawberry Milktea Guards, 1 Biscuit Princess, then back to City of Genesis and tell Burton.
					if(QuestCommand.CanQuest(c,72)) break;
					return QuestCode.A130189(c,QuestID);
				case 130190:
					//Kill 30 Spirit Dragons on the Henan Mountainside then go back and report to Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130190(c,QuestID);
				case 130191:
					//Kill 30 Carefree Beasts on the Henan Mountainside then go back and report to Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130191(c,QuestID);
				case 130192:
					//Kill 30 Lost Acolytes on the Henan Mountainside then go back and report to Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130192(c,QuestID);
				case 130193:
					//Kill 10 Dark Carefree Beasts on the Henan Moutainside then go back and tell Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130193(c,QuestID);
				case 130194:
					//Kill 40 Spirit Dragons on the Henan Mountainside then go back and tell Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130194(c,QuestID);
				case 130195:
					//Kill 40 Bubble Beasts on the Henan Mountainside then go back and tell Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130195(c,QuestID);
				case 130196:
					//Kill 10 Guarder Sissi on the Henan Mountainside then go back and tell Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130196(c,QuestID);
				case 130197:
					//Kill 50 Carefree Beasts on the Henan Mountainside then go back and tell Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130197(c,QuestID);
				case 130198:
					//Kill 50 Skyish Beasts on the Henan Mountainside then go back and tell Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130198(c,QuestID);
				case 130199:
					//Kill 10 Dark Carefree Beasts on the Henan Moutainside then go back and tell Herman.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130199(c,QuestID);
				case 130200:
					//Defeat 30 Carefree Beasts on the Henan Mountainside then go back and report to Mitchell.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130200(c,QuestID);
				case 130201:
					//Defeat 30 Lost Acolytes on the Henan Mountainside then go back and report to Mitchell.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130201(c,QuestID);
				case 130202:
					//Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
					if(QuestCommand.CanQuest(c,81)) break;
					return QuestCode.A130202(c,QuestID);
				case 130203:
					//Defeat 40 Spirit Dragons on the Henan Mountainside then go back and tell Mitchell.
					if(QuestCommand.CanQuest(c,85)) break;
					return QuestCode.A130203(c,QuestID);
				case 130204:
					//Defeat 40 Carefree Beasts on the Henan Mountainside then go back and report to Mitchell.
					if(QuestCommand.CanQuest(c,85)) break;
					return QuestCode.A130204(c,QuestID);
				case 130205:
					//Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
					if(QuestCommand.CanQuest(c,85)) break;
					return QuestCode.A130205(c,QuestID);
				case 130206:
					//Defeat 50 Bubble Beasts on the Henan Mountainside then go back and tell  Mitchell.
					if(QuestCommand.CanQuest(c,88)) break;
					return QuestCode.A130206(c,QuestID);
				case 130207:
					//Defeat 50 Skyish Beasts on the Henan Mountainside then go back and tell Mitchell
					if(QuestCommand.CanQuest(c,88)) break;
					return QuestCode.A130207(c,QuestID);
				case 130208:
					//Defeat 5 Dark Carefree Beasts and 5 Guarder Sissi on the Henan Moutainside then go back and tell Mitchell.
					if(QuestCommand.CanQuest(c,88)) break;
					return QuestCode.A130208(c,QuestID);
				case 130209:
					//Enter the toy factory, kill 3 Raw Material Buyers, 3 Lost Secretaries and 1 Fallen Earl Charlie then report to Lord Terry .
					if(QuestCommand.CanQuest(c,82)) break;
					return QuestCode.A130209(c,QuestID);
				case 130210:
					//Enter the toy factory, kill 3 QA Inspectors, 3 Lost Guards，and 1 Dark Witch Avri, then go back to City of Genesis and report to Larry.
					if(QuestCommand.CanQuest(c,82)) break;
					return QuestCode.A130210(c,QuestID);
				case 140102:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(QuestCommand.CanQuest(c,31)) break;
					return QuestCode.A140102(c,QuestID);
				case 140103:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(QuestCommand.CanQuest(c,36)) break;
					return QuestCode.A140103(c,QuestID);
				case 140104:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(QuestCommand.CanQuest(c,41)) break;
					return QuestCode.A140104(c,QuestID);
				case 140105:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(QuestCommand.CanQuest(c,46)) break;
					return QuestCode.A140105(c,QuestID);
				case 140106:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(QuestCommand.CanQuest(c,51)) break;
					return QuestCode.A140106(c,QuestID);
				case 140107:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(QuestCommand.CanQuest(c,56)) break;
					return QuestCode.A140107(c,QuestID);
				case 140108:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(QuestCommand.CanQuest(c,61)) break;
					return QuestCode.A140108(c,QuestID);
				case 140109:
					//Go to City of Genesis, ask Earl Kleist about the origin of the world.
					if(QuestCommand.CanQuest(c,66)) break;
					return QuestCode.A140109(c,QuestID);
				case 140206:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140206(c,QuestID);
				case 140207:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140207(c,QuestID);
				case 140208:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140208(c,QuestID);
				case 140209:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140209(c,QuestID);
				case 140211:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140211(c,QuestID);
				case 140212:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140212(c,QuestID);
				case 140213:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140213(c,QuestID);
				case 140214:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140214(c,QuestID);
				case 140216:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140216(c,QuestID);
				case 140217:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140217(c,QuestID);
				case 140218:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140218(c,QuestID);
				case 140219:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140219(c,QuestID);
				case 140221:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140221(c,QuestID);
				case 140222:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140222(c,QuestID);
				case 140223:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140223(c,QuestID);
				case 140224:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140224(c,QuestID);
				case 140225:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140225(c,QuestID);
				case 140226:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140226(c,QuestID);
				case 140227:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140227(c,QuestID);
				case 140228:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140228(c,QuestID);
				case 140229:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140229(c,QuestID);
				case 140230:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140230(c,QuestID);
				case 140231:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140231(c,QuestID);
				case 140232:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140232(c,QuestID);
				case 140233:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140233(c,QuestID);
				case 140234:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140234(c,QuestID);
				case 140235:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140235(c,QuestID);
				case 140236:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140236(c,QuestID);
				case 140237:
					//Go to City of Genesis, ask General Alston about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140237(c,QuestID);
				case 140238:
					//Go to Glory City, ask Haglos about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140238(c,QuestID);
				case 140239:
					//Go to City of Rage, ask Berger about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140239(c,QuestID);
				case 140240:
					//Go to City of Trees, ask Makhlou about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140240(c,QuestID);
				case 140309:
					//Defeat 50 Toothy Gerbils, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140309(c,QuestID);
				case 140310:
					//Defeat 50 Bactrian Camels, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140310(c,QuestID);
				case 140311:
					//Defeat 50 Rattlesnakes, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140311(c,QuestID);
				case 140312:
					//Defeat 50 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140312(c,QuestID);
				case 140313:
					//Defeat 50 Trade Wind Foxes, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140313(c,QuestID);
				case 140314:
					//Defeat 50 Toxic Scorpions, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140314(c,QuestID);
				case 140315:
					//Defeat 50 Sand Fire Lizards, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140315(c,QuestID);
				case 140316:
					//Collect 10 Darkthorn Cactus, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140316(c,QuestID);
				case 140317:
					//Collect 10 Buckthorn Grass, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140317(c,QuestID);
				case 140318:
					//Collect 10 Buckthorn Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140318(c,QuestID);
				case 140319:
					//Collect 10 Darksand Essences, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140319(c,QuestID);
				case 140322:
					//Defeat 60 Toothy Gerbils, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140322(c,QuestID);
				case 140323:
					//Defeat 60 Bactrian Camels, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140323(c,QuestID);
				case 140324:
					//Defeat 60 Rattlesnakes, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140324(c,QuestID);
				case 140325:
					//Defeat 60 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140325(c,QuestID);
				case 140326:
					//Defeat 60 Trade Wind Foxes, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140326(c,QuestID);
				case 140327:
					//Defeat 60 Toxic Scorpions, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140327(c,QuestID);
				case 140328:
					//Defeat 60 Sand Fire Lizards, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140328(c,QuestID);
				case 140329:
					//Collect 10 Darkthorn Cactus, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140329(c,QuestID);
				case 140330:
					//Collect 10 Buckthorn Grass, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140330(c,QuestID);
				case 140331:
					//Collect 10 Buckthorn Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140331(c,QuestID);
				case 140332:
					//Collect 10 Darksand Essences, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140332(c,QuestID);
				case 140335:
					//Defeat 70 Giant Jaw Ants, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140335(c,QuestID);
				case 140336:
					//Defeat 70 Mud Monsters, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140336(c,QuestID);
				case 140337:
					//Defeat 70 Man-eating Trees, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140337(c,QuestID);
				case 140338:
					//Defeat 70 Phantom Monkeys, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140338(c,QuestID);
				case 140339:
					//Defeat 70 Wraith Spiders, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140339(c,QuestID);
				case 140340:
					//Collect 10 Delusion Herbs, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140340(c,QuestID);
				case 140341:
					//Collect 10 Vampire Vines, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140341(c,QuestID);
				case 140342:
					//Collect 10 Luminous Grass, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140342(c,QuestID);
				case 140343:
					//Collect 10 Water Mana Spar, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140343(c,QuestID);
				case 140346:
					//Defeat 80 Giant Jaw Ants, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140346(c,QuestID);
				case 140347:
					//Defeat 80 Mud Monsters, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140347(c,QuestID);
				case 140348:
					//Defeat 80 Man-eating Trees, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140348(c,QuestID);
				case 140349:
					//Defeat 80 Phantom Monkeys, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140349(c,QuestID);
				case 140350:
					//Defeat 80 Wraith Spiders, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140350(c,QuestID);
				case 140351:
					//Collect 10 Delusion Herbs, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140351(c,QuestID);
				case 140352:
					//Collect 10 Vampire Vines, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140352(c,QuestID);
				case 140353:
					//Collect 10 Luminous Grass, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140353(c,QuestID);
				case 140354:
					//Collect 10 Water Mana Spar, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140354(c,QuestID);
				case 140355:
					//Defeat 90 Venom Monsters, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140355(c,QuestID);
				case 140356:
					//Defeat 90 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140356(c,QuestID);
				case 140357:
					//Defeat 90 Medusa, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140357(c,QuestID);
				case 140358:
					//Defeat 90 Mugger Crocodiles, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140358(c,QuestID);
				case 140359:
					//Defeat 90 Carrion, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140359(c,QuestID);
				case 140360:
					//Collect 10 Fluorescent Herbs, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140360(c,QuestID);
				case 140361:
					//Collect 10 Rotten Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140361(c,QuestID);
				case 140362:
					//Collect 10 Greenbell Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140362(c,QuestID);
				case 140363:
					//Defeat 100 Venom Monsters, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140363(c,QuestID);
				case 140364:
					//Defeat 100 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140364(c,QuestID);
				case 140365:
					//Defeat 100 Medusa, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140365(c,QuestID);
				case 140366:
					//Defeat 100 Mugger Crocodiles, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140366(c,QuestID);
				case 140367:
					//Defeat 100 Carrion, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140367(c,QuestID);
				case 140368:
					//Collect 10 Fluorescent Herbs, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140368(c,QuestID);
				case 140369:
					//Collect 10 Rotten Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140369(c,QuestID);
				case 140370:
					//Collect 10 Greenbell Flowers, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140370(c,QuestID);
				case 140371:
					//Defeat 110 Dire Wolves, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140371(c,QuestID);
				case 140372:
					//Defeat 110 Darkwind Hunters, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140372(c,QuestID);
				case 140373:
					//Defeat 110 Canyon Centaurs, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140373(c,QuestID);
				case 140374:
					//Defeat 110 Stone Lizards, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140374(c,QuestID);
				case 140375:
					//Defeat 110 Canyon Eagles, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140375(c,QuestID);
				case 140376:
					//Collect 10 Cruor Grasses, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140376(c,QuestID);
				case 140377:
					//Collect 10 Hyacinths, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140377(c,QuestID);
				case 140378:
					//Defeat 120 Darkwind Wolves, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140378(c,QuestID);
				case 140379:
					//Defeat 120 Darkwind Hunters, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140379(c,QuestID);
				case 140380:
					//Defeat 120 Canyon Centaurs, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140380(c,QuestID);
				case 140381:
					//Defeat 120 Stone Lizards, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140381(c,QuestID);
				case 140382:
					//Defeat 120 Canyon Eagles, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140382(c,QuestID);
				case 140383:
					//Collect 10 Cruor Grasses, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140383(c,QuestID);
				case 140384:
					//Collect 10 Hyacinths, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140384(c,QuestID);
				case 140406:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140406(c,QuestID);
				case 140407:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140407(c,QuestID);
				case 140408:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140408(c,QuestID);
				case 140409:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140409(c,QuestID);
				case 140411:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140411(c,QuestID);
				case 140412:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140412(c,QuestID);
				case 140413:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140413(c,QuestID);
				case 140414:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140414(c,QuestID);
				case 140416:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140416(c,QuestID);
				case 140417:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140417(c,QuestID);
				case 140418:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140418(c,QuestID);
				case 140419:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140419(c,QuestID);
				case 140421:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140421(c,QuestID);
				case 140422:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140422(c,QuestID);
				case 140423:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140423(c,QuestID);
				case 140424:
					//Go to City of Trees, ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140424(c,QuestID);
				case 140425:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140425(c,QuestID);
				case 140426:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140426(c,QuestID);
				case 140427:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140427(c,QuestID);
				case 140428:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140428(c,QuestID);
				case 140429:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140429(c,QuestID);
				case 140430:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140430(c,QuestID);
				case 140431:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140431(c,QuestID);
				case 140432:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140432(c,QuestID);
				case 140433:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140433(c,QuestID);
				case 140434:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140434(c,QuestID);
				case 140435:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140435(c,QuestID);
				case 140436:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140436(c,QuestID);
				case 140437:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140437(c,QuestID);
				case 140438:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140438(c,QuestID);
				case 140439:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140439(c,QuestID);
				case 140440:
					//Ask Scarce about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140440(c,QuestID);
				case 140502:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140502(c,QuestID);
				case 140503:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140503(c,QuestID);
				case 140504:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140504(c,QuestID);
				case 140505:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140505(c,QuestID);
				case 140506:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140506(c,QuestID);
				case 140507:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140507(c,QuestID);
				case 140508:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140508(c,QuestID);
				case 140509:
					//Go to City of Genesis, ask Dempsey about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140509(c,QuestID);
				case 140609:
					//Defeat 50 Toothy Gerbils, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140609(c,QuestID);
				case 140610:
					//Defeat 50 Bactrian Camels, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140610(c,QuestID);
				case 140611:
					//Defeat 50 Rattlesnakes, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140611(c,QuestID);
				case 140612:
					//Defeat 50 Dire Wolves, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140612(c,QuestID);
				case 140613:
					//Defeat 50 Trade Wind Foxes, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140613(c,QuestID);
				case 140614:
					//Defeat 50 Toxic Scorpions, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140614(c,QuestID);
				case 140615:
					//Defeat 50 Sand Fire Lizards, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140615(c,QuestID);
				case 140616:
					//Collect 10 Darkthorn Cactuses, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140616(c,QuestID);
				case 140617:
					//Collect 10 Buckthorn Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140617(c,QuestID);
				case 140618:
					//Collect 10 Buckthorn Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140618(c,QuestID);
				case 140619:
					//Collect 10 Darksand Essences, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140619(c,QuestID);
				case 140622:
					//Defeat 60 Toothy Gerbils, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140622(c,QuestID);
				case 140623:
					//Defeat 60 Bactrian Camels, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140623(c,QuestID);
				case 140624:
					//Defeat 60 Rattlesnakes, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140624(c,QuestID);
				case 140625:
					//Defeat 60 Dire Wolves, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140625(c,QuestID);
				case 140626:
					//Defeat 60 Trade Wind Foxes, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140626(c,QuestID);
				case 140627:
					//Defeat 60 Toxic Scorpions, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140627(c,QuestID);
				case 140628:
					//Defeat 60 Sand Fire Lizards, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140628(c,QuestID);
				case 140629:
					//Collect 10 Darkthorn Cactuses, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140629(c,QuestID);
				case 140630:
					//Collect 10 Buckthorn Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140630(c,QuestID);
				case 140631:
					//Collect 10 Buckthorn Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140631(c,QuestID);
				case 140632:
					//Collect 10 Darksand Essences, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140632(c,QuestID);
				case 140635:
					//Defeat 70 Giant Jaw Ants, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140635(c,QuestID);
				case 140636:
					//Defeat 70 Mud Monsters, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140636(c,QuestID);
				case 140637:
					//Defeat 70 Man-eating Trees, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140637(c,QuestID);
				case 140638:
					//Defeat 70 Phantom Monkeys, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140638(c,QuestID);
				case 140639:
					//Defeat 70 Wraith Spiders, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140639(c,QuestID);
				case 140640:
					//Collect 10 Delusion Herbs, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140640(c,QuestID);
				case 140641:
					//Collect 10 Vampire Vines, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140641(c,QuestID);
				case 140642:
					//Collect 10 Luminous Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140642(c,QuestID);
				case 140643:
					//Collect 10 Water Mana Spars, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140643(c,QuestID);
				case 140646:
					//Defeat 80 Giant Jaw Ants, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140646(c,QuestID);
				case 140647:
					//Defeat 80 Mud Monsters, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140647(c,QuestID);
				case 140648:
					//Defeat 80 Man-eating Trees, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140648(c,QuestID);
				case 140649:
					//Defeat 80 Phantom Monkeys, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140649(c,QuestID);
				case 140650:
					//Defeat 80 Wraith Spiders, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140650(c,QuestID);
				case 140651:
					//Collect 10 Delusion Herbs, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140651(c,QuestID);
				case 140652:
					//Collect 10 Vampire Vines, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140652(c,QuestID);
				case 140653:
					//Collect 10 Luminous Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140653(c,QuestID);
				case 140654:
					//Collect 10 Water Mana Spars, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140654(c,QuestID);
				case 140655:
					//Defeat 90 Venom Monsters, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140655(c,QuestID);
				case 140656:
					//Defeat 90 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140656(c,QuestID);
				case 140657:
					//Defeat 90 Medusa, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140657(c,QuestID);
				case 140658:
					//Defeat 90 Mugger Crocodiles, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140658(c,QuestID);
				case 140659:
					//Defeat 90 Carrions, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140659(c,QuestID);
				case 140660:
					//Collect 10 Fluorescent Herbs, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140660(c,QuestID);
				case 140661:
					//Collect 10 Rotten Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140661(c,QuestID);
				case 140662:
					//Defeat 100 Venom Monsters, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140662(c,QuestID);
				case 140663:
					//Defeat 100 Short-wing Rats, then go to Glory City, ask Yehar about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140663(c,QuestID);
				case 140664:
					//Defeat 100 Medusa, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140664(c,QuestID);
				case 140665:
					//Defeat 100 Mugger Crocodiles, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140665(c,QuestID);
				case 140666:
					//Defeat 100 Carrions, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140666(c,QuestID);
				case 140667:
					//Collect 10 Fluorescent Herbs, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140667(c,QuestID);
				case 140668:
					//Collect 10 Rotten Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140668(c,QuestID);
				case 140669:
					//Collect 10 Greenbell Flowers, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140669(c,QuestID);
				case 140670:
					//Defeat 110 Darkwind Wolves, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140670(c,QuestID);
				case 140671:
					//Defeat 110 Darkwind Hunters, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140671(c,QuestID);
				case 140672:
					//Defeat 110 Canyon Centaurs, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140672(c,QuestID);
				case 140673:
					//Defeat 110 Stone Lizards, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140673(c,QuestID);
				case 140674:
					//Defeat 110 Canyon Eagles, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140674(c,QuestID);
				case 140675:
					//Collect 10 Cruor Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140675(c,QuestID);
				case 140676:
					//Collect 10 Hyacinths, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140676(c,QuestID);
				case 140677:
					//Defeat 120 Darkwind Wolves, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140677(c,QuestID);
				case 140678:
					//Defeat 120 Darkwind Hunters, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140678(c,QuestID);
				case 140679:
					//Defeat 120 Canyon Centaurs, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140679(c,QuestID);
				case 140680:
					//Defeat 120 Stone Lizards, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140680(c,QuestID);
				case 140681:
					//Defeat 120 Canyon Eagles, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140681(c,QuestID);
				case 140682:
					//Collect 10 Cruor Grasses, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140682(c,QuestID);
				case 140683:
					//Collect 10 Hyacinths, then go to City of Rage, ask Cliff about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140683(c,QuestID);
				case 140706:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140706(c,QuestID);
				case 140707:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140707(c,QuestID);
				case 140708:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140708(c,QuestID);
				case 140709:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140709(c,QuestID);
				case 140711:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140711(c,QuestID);
				case 140712:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140712(c,QuestID);
				case 140713:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140713(c,QuestID);
				case 140714:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140714(c,QuestID);
				case 140716:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140716(c,QuestID);
				case 140717:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140717(c,QuestID);
				case 140718:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140718(c,QuestID);
				case 140719:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140719(c,QuestID);
				case 140721:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140721(c,QuestID);
				case 140722:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140722(c,QuestID);
				case 140723:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140723(c,QuestID);
				case 140724:
					//Go to Glory City, ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140724(c,QuestID);
				case 140725:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140725(c,QuestID);
				case 140726:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140726(c,QuestID);
				case 140727:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140727(c,QuestID);
				case 140728:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140728(c,QuestID);
				case 140729:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140729(c,QuestID);
				case 140730:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140730(c,QuestID);
				case 140731:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140731(c,QuestID);
				case 140732:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140732(c,QuestID);
				case 140733:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140733(c,QuestID);
				case 140734:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140734(c,QuestID);
				case 140735:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140735(c,QuestID);
				case 140736:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140736(c,QuestID);
				case 140737:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140737(c,QuestID);
				case 140738:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140738(c,QuestID);
				case 140739:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140739(c,QuestID);
				case 140740:
					//Ask Kon about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140740(c,QuestID);
				case 140806:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140806(c,QuestID);
				case 140807:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140807(c,QuestID);
				case 140808:
					//Go to Glory City, ask Minny about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140808(c,QuestID);
				case 140809:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140809(c,QuestID);
				case 140811:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140811(c,QuestID);
				case 140812:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140812(c,QuestID);
				case 140813:
					//Go to Glory City, ask Minny about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140813(c,QuestID);
				case 140814:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140814(c,QuestID);
				case 140816:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140816(c,QuestID);
				case 140817:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140817(c,QuestID);
				case 140818:
					//Go to Glory City, ask Minny about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140818(c,QuestID);
				case 140819:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140819(c,QuestID);
				case 140821:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140821(c,QuestID);
				case 140822:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140822(c,QuestID);
				case 140823:
					//Go to Glory City, ask Minny about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140823(c,QuestID);
				case 140824:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140824(c,QuestID);
				case 140825:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140825(c,QuestID);
				case 140826:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140826(c,QuestID);
				case 140827:
					//Go to Glory City, ask Minny about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140827(c,QuestID);
				case 140828:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140828(c,QuestID);
				case 140829:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140829(c,QuestID);
				case 140830:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140830(c,QuestID);
				case 140831:
					//Go to Glory City, ask Minny about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140831(c,QuestID);
				case 140832:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140832(c,QuestID);
				case 140833:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140833(c,QuestID);
				case 140834:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140834(c,QuestID);
				case 140835:
					//Go to Glory City, ask Minny about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140835(c,QuestID);
				case 140836:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140836(c,QuestID);
				case 140837:
					//Go to City of Trees, ask Nana about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140837(c,QuestID);
				case 140838:
					//Go to City of Rage, ask Amelia about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140838(c,QuestID);
				case 140839:
					//Go to Glory City, ask Minny about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140839(c,QuestID);
				case 140840:
					//Go to City of Genesis, ask Eugene about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140840(c,QuestID);
				case 140903:
					//Defeat 15 Swantony, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140903(c,QuestID);
				case 140904:
					//Defeat 15 Benson, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140904(c,QuestID);
				case 140905:
					//Defeat 15 Swantony, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140905(c,QuestID);
				case 140906:
					//Defeat 15 Benson, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140906(c,QuestID);
				case 140907:
					//Defeat 15 Baird, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140907(c,QuestID);
				case 140908:
					//Defeat 15 Archer, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140908(c,QuestID);
				case 140909:
					//Defeat 15 Baird, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140909(c,QuestID);
				case 140910:
					//Defeat 15 Archer, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140910(c,QuestID);
				case 140911:
					//Defeat 15 Olive, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140911(c,QuestID);
				case 140912:
					//Defeat 15 Giant Carrion, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140912(c,QuestID);
				case 140913:
					//Defeat 15 Olive, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140913(c,QuestID);
				case 140914:
					//Defeat 15 Giant Carrion, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140914(c,QuestID);
				case 140915:
					//Defeat 15 Shadow Assassins, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140915(c,QuestID);
				case 140916:
					//Defeat 15 Head Centaurs, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140916(c,QuestID);
				case 140917:
					//Defeat 15 Shadow Assassins, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140917(c,QuestID);
				case 140918:
					//Defeat 15 Head Centaurs, then go to City of Rage, ask Marie about the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A140918(c,QuestID);
				case 141002:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A141002(c,QuestID);
				case 141003:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A141003(c,QuestID);
				case 141004:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A141004(c,QuestID);
				case 141005:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A141005(c,QuestID);
				case 141006:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A141006(c,QuestID);
				case 141007:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A141007(c,QuestID);
				case 141008:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A141008(c,QuestID);
				case 141009:
					//Find Doreen and tell her that you\'ve known the origin of the world.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A141009(c,QuestID);
				case 150001:
					//Accept Zodiac Temple\'s order, kill any monster*20 at Lune Oasis.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150001(c,QuestID);
				case 150002:
					//Accept Zodiac Temple\'s order, kill any monster*40 at Lune Oasis.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150002(c,QuestID);
				case 150003:
					//Accept Zodiac Temple\'s order, kill any monster*60 at Lune Oasis.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150003(c,QuestID);
				case 150004:
					//Accept Zodiac Temple\'s order, kill any monster*80 at Lune Oasis.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150004(c,QuestID);
				case 150005:
					//Accept Zodiac Temple\'s order, kill any monster*100 at Lune Oasis.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150005(c,QuestID);
				case 150006:
					//Accept Zodiac Temple\'s order, kill any monster*30 at Darksand.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150006(c,QuestID);
				case 150007:
					//Accept Zodiac Temple\'s order, kill any monster*60 at Darksand.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150007(c,QuestID);
				case 150008:
					//Accept Zodiac Temple\'s order, kill any monster*90 at Darksand.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150008(c,QuestID);
				case 150009:
					//Accept Zodiac Temple\'s order, kill any monster*120 at Darksand.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150009(c,QuestID);
				case 150010:
					//Accept Zodiac Temple\'s order, any monster*150 at Darksand.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150010(c,QuestID);
				case 150011:
					//Accept Zodiac Temple\'s order, kill any monster*50 in Vine Rainforest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150011(c,QuestID);
				case 150012:
					//Accept Zodiac Temple\'s order, kill any monster*100 in Vine Rainforest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150012(c,QuestID);
				case 150013:
					//Accept Zodiac Temple\'s order, kill any monster*150 in Vine Rainforest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150013(c,QuestID);
				case 150014:
					//Accept Zodiac Temple\'s order, kill any monster*200 in Vine Rainforest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150014(c,QuestID);
				case 150015:
					//Accept Zodiac Temple\'s order, kill any monster*250 in Vine Rainforest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150015(c,QuestID);
				case 150016:
					//Accept Zodiac Temple\'s order, kill any monster*50 in Redcloud Marsh.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150016(c,QuestID);
				case 150017:
					//Accept Zodiac Temple\'s order,kill any monster*100 in Redcloud Marsh.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150017(c,QuestID);
				case 150018:
					//Accept Zodiac Temple\'s order, kill any monster*150 in Redcloud Marsh.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150018(c,QuestID);
				case 150019:
					//Accept Zodiac Temple\'s order, kill any monster*200 in Redcloud Marsh.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150019(c,QuestID);
				case 150020:
					//Accept Zodiac Temple\'s order, kill any monster*250 in Redcloud Marsh.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150020(c,QuestID);
				case 150021:
					//Accept Zodiac Temple\'s order, kill any monster*50 in Darkwind Canyon.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150021(c,QuestID);
				case 150022:
					//Accept Zodiac Temple\'s order, kill any monster*100 in Darkwind Canyon.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150022(c,QuestID);
				case 150023:
					//Accept Zodiac Temple\'s order, kill any monster*150 in Darkwind Canyon.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150023(c,QuestID);
				case 150024:
					//Accept Zodiac Temple\'s order, kill any monster*200 in Darkwind Canyon.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150024(c,QuestID);
				case 150025:
					//Accept Zodiac Temple\'s order, kill any monster*250 in Darkwind Canyon.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150025(c,QuestID);
				case 150026:
					//Accept Zodiac Temple\'s order, kill any monster*50 in Foggy Forest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150026(c,QuestID);
				case 150027:
					//Accept Zodiac Temple\'s order, kill any monster*100 in Foggy Forest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150027(c,QuestID);
				case 150028:
					//Accept Zodiac Temple\'s order, kill any monster*150 in Foggy Forest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150028(c,QuestID);
				case 150029:
					//Accept Zodiac Temple\'s order, kill any monster*200 in Foggy Forest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150029(c,QuestID);
				case 150030:
					//Accept Zodiac Temple\'s order, kill any monster*250 in Foggy Forest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150030(c,QuestID);
				case 150031:
					//Accept Zodiac Temple\'s order, any monster*300 at Darksand Land.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150031(c,QuestID);
				case 150032:
					//Accept Zodiac Temple\'s order, kill any monster*500 in Vine Rainforest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150032(c,QuestID);
				case 150033:
					//Accept Zodiac Temple\'s order, kill any monster*500 in Redcloud Marsh.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150033(c,QuestID);
				case 150034:
					//Accept Zodiac Temple\'s order, kill any monster*500 in Darkwind Canyon.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150034(c,QuestID);
				case 150035:
					//Accept Zodiac Temple\'s order, kill any monster*500 in Foggy Forest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150035(c,QuestID);
				case 150036:
					//Accept Zodiac Temple\'s order, collect 20 Darksand Essences from Darksand Land.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150036(c,QuestID);
				case 150037:
					//Accept Zodiac Temple\'s order, collect 20 Water Mana Spars from Vine Rainforest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150037(c,QuestID);
				case 150038:
					//Accept Zodiac Temple\'s order, collect 20 Greenbell Flowers from Redcloud Marsh.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150038(c,QuestID);
				case 150039:
					//Accept Zodiac Temple\'s order, collect 20 Hyacinths from Darkwind Canyon.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150039(c,QuestID);
				case 150040:
					//Accept Zodiac Temple\'s order, collect 20 Hyacinths from Foggy Forest.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150040(c,QuestID);
				case 150041:
					//Accept Zodiac Temple\'s order, kill any monster*50 at Henan Mountainside.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150041(c,QuestID);
				case 150042:
					//Accept Zodiac Temple\'s order, kill any monster*100 at Henan Mountainside.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150042(c,QuestID);
				case 150043:
					//Accept Zodiac Temple\'s order, kill any monster*150 at Henan Mountainside.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150043(c,QuestID);
				case 150044:
					//Accept Zodiac Temple\'s order, kill any monster*200 at Henan Mountainside.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150044(c,QuestID);
				case 150045:
					//Accept Zodiac Temple\'s order, kill any monster*250 at Henan Mountainside.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150045(c,QuestID);
				case 150046:
					//Accept Zodiac Temple\'s order, kill any monster*500 at Henan Mountainside.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150046(c,QuestID);
				case 150047:
					//Accept Zodiac Temple\'s order, collect 20 Despair Herbs at Henan Mountainside.
					if(QuestCommand.CanQuest(c,200)) break;
					return QuestCode.A150047(c,QuestID);
			}

			return 0;
		}
	}
}
