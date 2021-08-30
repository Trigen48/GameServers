DROP TABLE IF EXISTS DailyShop;
DROP TABLE IF EXISTS quest_accept;
DROP TABLE IF EXISTS quest_task;
DROP TABLE IF EXISTS quest;
DROP TABLE IF EXISTS premium;
DROP TABLE IF EXISTS iteminfo;
DROP TABLE IF EXISTS server;
DROP TABLE IF EXISTS happyclaim;
DROP TABLE IF EXISTS zodiacgoal;
DROP TABLE IF EXISTS codevoucher;
DROP TABLE IF EXISTS buff;
DROP TABLE IF EXISTS starmap;
DROP TABLE IF EXISTS combat;
DROP TABLE IF EXISTS guildapply;
DROP TABLE IF EXISTS guildmember;
DROP TABLE IF EXISTS guild;
DROP TABLE IF EXISTS ranktype;
DROP TABLE IF EXISTS ranking;
DROP TABLE IF EXISTS bagitem_logtype;
DROP TABLE IF EXISTS bagitem_log;
DROP TABLE IF EXISTS bagitem;
DROP TABLE IF EXISTS bag;
DROP TABLE IF EXISTS vip;
DROP TABLE IF EXISTS title;
DROP TABLE IF EXISTS skill;
DROP TABLE IF EXISTS shortcut;
DROP TABLE IF EXISTS reward;
DROP TABLE IF EXISTS pet;
DROP TABLE IF EXISTS mountitem;
DROP TABLE IF EXISTS mount;
DROP TABLE IF EXISTS medal;
DROP TABLE IF EXISTS mail;
DROP TABLE IF EXISTS luckywheel_log;
DROP TABLE IF EXISTS luckywheel;
DROP TABLE IF EXISTS horoscope;
DROP TABLE IF EXISTS friend;
DROP TABLE IF EXISTS friendtype;
DROP TABLE IF EXISTS friendgroup;
DROP TABLE IF EXISTS escort;
DROP TABLE IF EXISTS autofight;
DROP TABLE IF EXISTS active;
DROP TABLE IF EXISTS role;
DROP TABLE IF EXISTS constellation;
DROP TABLE IF EXISTS account;

DROP PROCEDURE IF EXISTS UpdateRankCombat;
DROP PROCEDURE IF EXISTS UpdateRankLevel;
DROP PROCEDURE IF EXISTS UpdateRankWealth;
DROP PROCEDURE IF EXISTS UpdateRankPrestige;
DROP PROCEDURE IF EXISTS UpdateBagItemOrder;


DELIMITER //
CREATE PROCEDURE UpdateRankCombat()
    MODIFIES SQL DATA
BEGIN
    SET @rnk:=0; INSERT INTO ranking(rankno,roleid,nobility,rankvalue,rtypeid)
    SELECT (@rnk:=@rnk+1) rankno,combat.roleid,role.nobility, combat.combatpower rankvalue,1 FROM combat,role WHERE role.roleid=combat.roleid order by combatpower desc LIMIT 100;

END//
DELIMITER ;

DELIMITER //
CREATE PROCEDURE UpdateRankLevel()
    MODIFIES SQL DATA
BEGIN

	SET @rnk:=0; INSERT INTO ranking(rankno,roleid,nobility,rankvalue,rtypeid)
	SELECT (@rnk:=@rnk+1) rankno,roleid,nobility, lvl rankvalue,2 FROM role order by lvl desc LIMIT 100;

END//
DELIMITER ;

DELIMITER //
CREATE PROCEDURE UpdateRankWealth()
    MODIFIES SQL DATA
BEGIN

    SET @rnk:=0; INSERT INTO ranking(rankno,roleid,nobility,rankvalue,rtypeid)
    SELECT (@rnk:=@rnk+1) rankno,bag.roleid,role.nobility, bag.gold rankvalue,3 FROM bag,role WHERE role.roleid=bag.roleid order by gold desc LIMIT 100;

END//
DELIMITER ;

DELIMITER //
CREATE PROCEDURE UpdateRankPrestige()
    MODIFIES SQL DATA
BEGIN

	SET @rnk:=0; INSERT INTO ranking(rankno,roleid,nobility,rankvalue,rtypeid)
	SELECT (@rnk:=@rnk+1) rankno,roleid,nobility, prestige rankvalue,5 FROM role order by prestige desc LIMIT 100;

END//
DELIMITER ;

DELIMITER //
CREATE PROCEDURE UpdateBagItemOrder(IN iroleid INT)
    MODIFIES SQL DATA
BEGIN

SET @slot:=0;
UPDATE bagitem SET slot= @slot:= (@slot+1) WHERE roleid=iroleid AND bagtype=4 ORDER BY typec,bind,countc DESC;

END//
DELIMITER ;


CREATE TABLE account
(
  accid 				INT 				PRIMARY KEY AUTO_INCREMENT,
  accname 				VARCHAR(20) 		NOT NULL,
  accpass 				CHAR(32) 			NOT NULL,
  accdate 				DATETIME 			NOT NULL DEFAULT CURRENT_TIMESTAMP,
  accdatelast 			DATETIME 			NOT NULL DEFAULT CURRENT_TIMESTAMP,
  accstatus 			TINYINT 			DEFAULT '1',
  tokens 				INT 				DEFAULT '0',
  acclockdate 			DATETIME 			DEFAULT NULL
);

INSERT INTO account (accname, accpass, accdate, accdatelast, accstatus, tokens, acclockdate) VALUES
('trigen','',  '2016-08-30 00:17:26', '2016-08-30 00:17:26', 1, 10, NULL);

CREATE TABLE constellation
(
	starsign			TINYINT				NOT NULL,
	starpartner			TINYINT				NOT NULL,
	starmatch			TINYINT				NOT NULL DEFAULT 1,
	PRIMARY KEY(starsign,starpartner)
);


INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(1,1,4),(1,2,2),(1,3,4),(1,4,2),(1,5,5),(1,6,1),(1,7,3),(1,8,3),(1,9,5),(1,10,3),(1,11,4),(1,12,1);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(2,1,2),(2,2,5),(2,3,1),(2,4,4),(2,5,3),(2,6,5),(2,7,3),(2,8,3),(2,9,1),(2,10,5),(2,11,2),(2,12,4);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(3,1,4),(3,2,1),(3,3,5),(3,4,1),(3,5,4),(3,6,2),(3,7,5),(3,8,1),(3,9,3),(3,10,2),(3,11,5),(3,12,1);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(4,1,2),(4,2,4),(4,3,1),(4,4,5),(4,5,3),(4,6,4),(4,7,1),(4,8,5),(4,9,2),(4,10,4),(4,11,2),(4,12,5);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(5,1,5),(5,2,3),(5,3,4),(5,4,3),(5,5,5),(5,6,1),(5,7,4),(5,8,3),(5,9,5),(5,10,2),(5,11,2),(5,12,3);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(6,1,1),(6,2,5),(6,3,2),(6,4,4),(6,5,1),(6,6,5),(6,7,2),(6,8,4),(6,9,1),(6,10,5),(6,11,2),(6,12,2);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(7,1,3),(7,2,3),(7,3,5),(7,4,1),(7,5,4),(7,6,2),(7,7,5),(7,8,2),(7,9,4),(7,10,2),(7,11,5),(7,12,3);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(8,1,3),(8,2,3),(8,3,1),(8,4,5),(8,5,3),(8,6,4),(8,7,2),(8,8,5),(8,9,2),(8,10,4),(8,11,2),(8,12,5);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(9,1,5),(9,2,1),(9,3,3),(9,4,2),(9,5,5),(9,6,1),(9,7,4),(9,8,2),(9,9,5),(9,10,1),(9,11,4),(9,12,2);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(10,1,3),(10,2,5),(10,3,2),(10,4,4),(10,5,2),(10,6,5),(10,7,2),(10,8,4),(10,9,1),(10,10,5),(10,11,2),(10,12,4);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(11,1,4),(11,2,2),(11,3,5),(11,4,2),(11,5,2),(11,6,2),(11,7,5),(11,8,2),(11,9,4),(11,10,2),(11,11,5),(11,12,3);

INSERT INTO constellation(starsign,starpartner,starmatch)
 VALUES(12,1,1),(12,2,4),(12,3,1),(12,4,5),(12,5,3),(12,6,2),(12,7,3),(12,8,5),(12,9,2),(12,10,4),(12,11,3),(12,12,5);




CREATE TABLE role (
  roleid 				INT 				PRIMARY KEY AUTO_INCREMENT,
  sex 					TINYINT 			DEFAULT '1',
  lvl 					TINYINT 			DEFAULT '1',
  career 				TINYINT 			DEFAULT '1',
  faction 				TINYINT 			DEFAULT '0',
  constellation 		TINYINT 			DEFAULT '1',
  CHARname 				VARCHAR(20)		 	NOT NULL,
  weapon_id				INT					DEFAULT 0,
  armor_id				INT					DEFAULT 0,
  rolestatus 			TINYINT 			DEFAULT '0',
  trial 				INT 				DEFAULT '0',
  honor 				INT 				DEFAULT '0',
  guildpoINT 			INT 				DEFAULT '0',
  prestige 				INT 				DEFAULT '0',
  nobility 				TINYINT 			DEFAULT '0',
  sinc 					SMALLINT 			DEFAULT '0',
  CHARm 				INT 				DEFAULT '0',
  mateid 				INT 				DEFAULT '0',
  Expc 					INT 				DEFAULT '0',
  ExpcLim 				INT 				DEFAULT '26',
  speed 				SMALLINT 			DEFAULT '160',
  ranger 				TINYINT 			DEFAULT '1',
  atkspeed 				SMALLINT 			DEFAULT '1000',
  pkmode 				TINYINT 			DEFAULT '1',
  pktime 				INT 				DEFAULT '0',
  mapid 				INT 				DEFAULT '100',
  mapx 					SMALLINT 			DEFAULT '43',
  mapy 					SMALLINT 			DEFAULT '90',
  regtime 				INT 				DEFAULT '0',
  isonline				BIT					DEFAULT 0,
  isgm					BIT					DEFAULT 0,
  titleid 				SMALLINT 			DEFAULT '0',
  accid 				INT 				NOT NULL,
  
  CONSTRAINT role_accid_fk FOREIGN KEY (accid) REFERENCES account(accid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE,
  
  CONSTRAINT role_constellation_fk FOREIGN KEY(constellation) REFERENCES constellation(starsign)
);

CREATE TABLE active (
  roleid 		INT 	PRIMARY KEY,
  ActMonth 		TINYINT 	NOT NULL DEFAULT '1',
  SignIn 		VARCHAR(62) DEFAULT '',
  Claims 		VARCHAR(60) DEFAULT '',
  TopupClaim 	TINYINT 	DEFAULT '0',
  ZodiacClaim 	TINYINT 	DEFAULT '0',
  ActDay 		TINYINT 	NOT NULL DEFAULT '1',
  ActivePoINT 	TINYINT 	DEFAULT '0',
  DayClaim 		TINYINT 	DEFAULT '0',
  LastPlay 		INT 	DEFAULT '0',
  isBattleField TINYINT 	DEFAULT '0',
  
  CONSTRAINT active_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);

CREATE TABLE autofight (
  roleid 	INT 	PRIMARY KEY,
  hp 		TINYINT 	DEFAULT '80',
  mp 		TINYINT 	DEFAULT '80',
  joy 		TINYINT 	DEFAULT '80',
  config 	CHAR(42) 	DEFAULT '110001111111111111100110000000000000000000',
  
  CONSTRAINT autofight_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);

CREATE TABLE escort (
  roleid 		INT 	PRIMARY KEY,
  estate 		TINYINT 	DEFAULT '0',
  quality 		TINYINT 	DEFAULT '5',
  refresh 		TINYINT 	DEFAULT '5',
  ecount 		TINYINT 	DEFAULT '0',
  firsttime 	TINYINT 	DEFAULT '1',
  endtime 		INT 	DEFAULT '0',
  
  
  CONSTRAINT escort_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE ON 
  UPDATE CASCADE
);

CREATE TABLE friendgroup
(
	roleid		INT			NOT NULL,
	fgroupid 	TINYINT 	NOT NULL,
	PRIMARY KEY(roleid,fgroupid),
	
	fgroupdesc VARCHAR(15) DEFAULT NULL,
	CONSTRAINT friendgroup_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
	ON DELETE CASCADE 
	ON UPDATE CASCADE
);

CREATE TABLE friendtype (

  ftypeid 	TINYINT 	PRIMARY KEY,
  ftypedesc VARCHAR(15) DEFAULT NULL
);

INSERT INTO friendtype(ftypeid,ftypedesc)
VALUES (1,'Friend'),(2,'Black Listed'),(3,'Enemy'),(4,'Enemy hidden');

CREATE TABLE friend (
  roleid 		INT 	NOT NULL,
  friendid 		INT 	NOT NULL,
  INTimacy 		INT 	DEFAULT 0,
  ftypeid 		TINYINT DEFAULT 1,
  fgroupid		TINYINT	DEFAULT 1,
  
  PRIMARY KEY (roleid,friendid),
  
  CONSTRAINT friend_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE,
  
  CONSTRAINT friend_friendid_fk FOREIGN KEY (friendid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE,
  
  CONSTRAINT friend_ftypeid_fk FOREIGN KEY (ftypeid) REFERENCES friendtype(ftypeid)
);


CREATE TABLE horoscope (
  roleid 	INT 	PRIMARY KEY,
  tries 	TINYINT 	DEFAULT 3,
  type1 	TINYINT 	DEFAULT 0,
  star1 	TINYINT 	DEFAULT 0,
  bonus1 	SMALLINT DEFAULT 0,
  type2 	TINYINT 	DEFAULT 0,
  star2 	TINYINT 	DEFAULT 0,
  bonus2 	SMALLINT DEFAULT 0,
  type3 	TINYINT 	DEFAULT 0,
  star3 	TINYINT 	DEFAULT 0,
  bonus3 	SMALLINT DEFAULT 0,
  luck 		TINYINT 	DEFAULT 0,
  
  CONSTRAINT horoscope_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);


CREATE TABLE luckywheel (
  roleid 	INT 	PRIMARY KEY,
  Claim 	TINYINT 	DEFAULT '0',
  Prize 	INT 	DEFAULT '0',
  bind 		TINYINT 	DEFAULT '2',
  CONSTRAINT luckywheel_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);
	  
CREATE TABLE luckywheel_log
(
	luckyid		INT			PRIMARY KEY AUTO_INCREMENT,
	itemtype	INT			NOT NULL,
	typec		TINYINT		NOT NULL DEFAULT 1,
	countc		TINYINT 	NOT NULL DEFAULT 1,
	windate		INT			NOT NULL,
	roleid		INT			NOT NULL,
	
  CONSTRAINT luckywheel_log_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);

CREATE TABLE mail (
  mailid INT PRIMARY KEY AUTO_INCREMENT,
  mailtype TINYINT DEFAULT '0',
  mailstatus TINYINT DEFAULT '2',
  mailtime INT DEFAULT '0',
  hasitem TINYINT DEFAULT '0',
  sender VARCHAR(20) DEFAULT '',
  title VARCHAR(50) DEFAULT '',
  mailmsg VARCHAR(100) DEFAULT '',
  itemid INT DEFAULT '0',
  itemtype INT DEFAULT '1',
  itemnum INT DEFAULT '0',
  gold INT DEFAULT '0',
  bgold INT DEFAULT '0',
  crystal INT DEFAULT '0',
  bcrystal INT DEFAULT '0',
  claimed BIT(1) DEFAULT b'0',
  roleid INT DEFAULT '0',
  
  CONSTRAINT mail_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);



CREATE TABLE medal (
  roleid INT PRIMARY KEY,
  medallvl TINYINT DEFAULT '0',
  starsoul INT DEFAULT '0',
  firelvl TINYINT DEFAULT '0',
  firesoul INT DEFAULT '0',
  firefail INT DEFAULT '0',
  waterlvl TINYINT DEFAULT '0',
  watersoul INT DEFAULT '0',
  waterfail INT DEFAULT '0',
  windlvl TINYINT DEFAULT '0',
  windsoul INT DEFAULT '0',
  windfail INT DEFAULT '0',
  earthlvl TINYINT DEFAULT '0',
  earthsoul INT DEFAULT '0',
  earthfail INT DEFAULT '0',
  
  CONSTRAINT medal_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);

CREATE TABLE mount (
  roleid 		INT PRIMARY KEY,
  mountlvl 		TINYINT DEFAULT 0,
  mountexp 		INT 	DEFAULT 0,
  mountstar 	TINYINT DEFAULT 0,
  mountstarexp 	INT 	DEFAULT 0,
  mounttime 	INT 	DEFAULT 0,
  mountstart 	INT 	DEFAULT 0,
  mountstate 	TINYINT DEFAULT 0,
  imountclaimed	BIT		DEFAULT 0,
  fact 			TINYINT DEFAULT 0,
  
  CONSTRAINT mount_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);

CREATE TABLE mountitem (
  roleid INT NOT NULL,
  mounttype INT NOT NULL DEFAULT '0',
  selected TINYINT NOT NULL DEFAULT '0',
  mounttime INT DEFAULT '0',
  PRIMARY KEY (roleid,mounttype),
  
  CONSTRAINT mountitem_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);

CREATE TABLE pet (
  petid INT PRIMARY KEY AUTO_INCREMENT,
  career TINYINT DEFAULT '1',
  name VARCHAR(50) DEFAULT '',
  RenameCount SMALLINT DEFAULT '0',
  lvl SMALLINT DEFAULT '1',
  quality SMALLINT DEFAULT '0',
  str_base SMALLINT DEFAULT '0',
  INTl_base SMALLINT DEFAULT '0',
  agi_base SMALLINT DEFAULT '0',
  str_new SMALLINT DEFAULT '0',
  INTl_new SMALLINT DEFAULT '0',
  agi_new SMALLINT DEFAULT '0',
  joy SMALLINT DEFAULT '1000',
  isActive SMALLINT DEFAULT '0',
  w_fightPos SMALLINT DEFAULT '0',
  Joy_lim SMALLINT DEFAULT '1000',
  PetType INT DEFAULT '0',
  starLv INT DEFAULT '0',
  Luck INT DEFAULT '0',
  expc INT DEFAULT '0',
  expc_lim INT DEFAULT '0',
  Skill_Slots SMALLINT DEFAULT '0',
  z15_specialSkillId INT DEFAULT '0',
  skillsb varbinary(73) DEFAULT 0x00,
  roleid INT NOT NULL,
  
  CONSTRAINT pet_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);

CREATE TABLE reward (
  roleid INT PRIMARY KEY,
  rewardphase TINYINT DEFAULT '1',
  phase TINYINT DEFAULT '1',
  remain SMALLINT DEFAULT '30',
  
  CONSTRAINT reward_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);

CREATE TABLE shortcut (
  roleid INT NOT NULL,
  slotid TINYINT NOT NULL DEFAULT '0',
  itemid INT DEFAULT '0',
  itype TINYINT DEFAULT NULL,
  PRIMARY KEY (roleid,slotid),
  
  CONSTRAINT shortcut_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);


CREATE TABLE skill (
  roleid INT NOT NULL,
  skillid INT NOT NULL,
  skilllvl TINYINT DEFAULT '1',
  skilltime INT DEFAULT '0',
  skilluse SMALLINT DEFAULT '20',
  skilltype TINYINT DEFAULT '0',
  PRIMARY KEY (roleid,skillid),
  
  CONSTRAINT skill_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE
  ON UPDATE CASCADE
);



CREATE TABLE title (
  roleid INT NOT NULL,
  titleid SMALLINT NOT NULL,
  expire INT DEFAULT NULL,
  PRIMARY KEY (titleid,roleid),
  
  CONSTRAINT title_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE
);

CREATE TABLE vip(
  roleid 		INT PRIMARY KEY,
  viplvl 		TINYINT DEFAULT '0',
  vipexp 		INT DEFAULT '0',
  vipexpire 	INT DEFAULT '0',
  vippack 		BIT(1) DEFAULT b'0',
  vipbuff 		BIT(1) DEFAULT b'0',
  vipclaim 		binary(15) DEFAULT 0x000000000000000000000000000000,
  
  CONSTRAINT vip_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE 
 );
 
 CREATE TABLE bag(
  roleid	INT		PRIMARY KEY,
  gold		INT 	DEFAULT 0,
  bgold		INT 	DEFAULT 0,
  crystal	INT 	DEFAULT 0,
  bcrystal	INT 	DEFAULT 0,
  bcount	BINARY(6) DEFAULT NULL,
  
  CONSTRAINT bag_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE 
 );
 
CREATE TABLE bagitem(
  itemid		INT PRIMARY KEY AUTO_INCREMENT,

  typec 		INT 		DEFAULT 0,
  slot 			TINYINT 	DEFAULT 0,
  countc 		TINYINT 	DEFAULT 0,
  str 			TINYINT 	DEFAULT 0,
  bind 			TINYINT 	DEFAULT 0,
  overtime 		INT 		DEFAULT 0,
  overtimetype	TINYINT		DEFAULT 0,
  basestats 	VARBINARY(36) 	DEFAULT 0x00,
  extrastats 	VARBINARY(36) 	DEFAULT 0x00,
  gems 			VARBINARY(13) 	DEFAULT 0x00,
  gemcount 		TINYINT 	DEFAULT 0,
  color 		TINYINT 	DEFAULT 0,
  lvl 			TINYINT 	DEFAULT 0,
  luck 			TINYINT 	DEFAULT 0,
  durability	TINYINT		DEFAULT 100,
  
  pricetype		TINYINT		DEFAULT 0,
  price			INT			DEFAULT 1,  
  
  isbusiness	TINYINT		DEFAULT 0,
  issell		TINYINT		DEFAULT 0,
  isdiscard		TINYINT		DEFAULT 0,
  setid			TINYINT		DEFAULT 0,
  setno			TINYINT		DEFAULT 0,
  
  bagtype		TINYINT		DEFAULT 4,

  roleid		INT 		NOT NULL,
  CONSTRAINT bagitem_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE 
  );
  
CREATE TABLE bagitem_log(
  itemid		INT,

  typec 		INT 		DEFAULT 0,
  slot 			TINYINT 	DEFAULT 0,
  countc 		TINYINT 	DEFAULT 0,
  str 			TINYINT 	DEFAULT 0,
  bind 			TINYINT 	DEFAULT 0,
  overtime 		INT 		DEFAULT 0,
  overtimetype	TINYINT		DEFAULT 0,
  basestats 	VARBINARY(36) 	DEFAULT 0x00,
  extrastats 	VARBINARY(36) 	DEFAULT 0x00,
  gems 			VARBINARY(13) 	DEFAULT 0x00,
  gemcount 		TINYINT 	DEFAULT 0,
  color 		TINYINT 	DEFAULT 0,
  lvl 			TINYINT 	DEFAULT 0,
  luck 			TINYINT 	DEFAULT 0,
  durability	TINYINT		DEFAULT 100,
  bagtype		TINYINT		DEFAULT 4,
  logtype		TINYINT		DEFAULT 1,
  pricetype		TINYINT		DEFAULT 3,
  price			INT			DEFAULT 1,
   
  isbusiness	TINYINT		DEFAULT 0,
  issell		TINYINT		DEFAULT 0,
  isdiscard		TINYINT		DEFAULT 0,
  setid			TINYINT		DEFAULT 0,
  setno			TINYINT		DEFAULT 0,
  
  itemdate		datetime 	DEFAULT CURRENT_TIMESTAMP,
  
  roleid		INT 		NOT NULL,
  CONSTRAINT bagitem_log_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
  ON DELETE CASCADE 
  ON UPDATE CASCADE 
  );
  
CREATE TABLE bagitem_logtype
(
	logtype		TINYINT PRIMARY KEY,
	logdesc		VARCHAR(50) NOT NULL
);

INSERT INTO bagitem_logtype(logtype,logdesc)
VALUES(1,'Item lost on move')
,(2,'Item lost on count')
,(3,'Item lost on add')
,(4,'Item remove error')
,(5,'Item Lost on purchase')
,(6,'');


CREATE TABLE ranking
(
	rankno		SMALLINT	NOT NULL DEFAULT 1,
	roleid		INT 		NOT NULL,
    rtypeid		TINYINT		DEFAULT 1,	
	
	nobility	TINYINT,
	rankvalue	INT,

	
	primary key(rankno,roleid,rtypeid),
	CONSTRAINT ranking_roleid FOREIGN KEY(roleid) REFERENCES role(roleid)
	ON DELETE CASCADE
    ON UPDATE CASCADE
);
  
CREATE TABLE ranktype
(
	rtypeid	TINYINT PRIMARY KEY,
	rtypedec VARCHAR(20)
);

INSERT INTO ranktype(rtypeid,rtypedec) 
VALUES	(1,'Combat power rank'),
		(2,'Level Rank'),
		(3,'Wealth Rank'),
		(4,'Honor Rank'),
		(5,'Prestige rank');
		
CREATE TABLE guild
(
	guildid			INT primary key auto_increment,
	gname			VARCHAR(20) NOT NULL,
	tenet			VARCHAR(20) DEFAULT '',
	announce		VARCHAR(20) DEFAULT '',
	initiatorid		INT NOT NULL,
	
	chiefid			INT NOT NULL,
	deputy1			INT DEFAULT 0,
	deputy2			INT DEFAULT 0,
	deputycount		TINYINT DEFAULT 0,
	faction			TINYINT DEFAULT 0,
	guildlevel		TINYINT DEFAULT 1,
	reputation		smallINT DEFAULT 0,
	money			INT DEFAULT 0,
	contribution	INT DEFAULT 0,
	
	createdtime		INT DEFAULT 0,
	contributemax	INT DEFAULT 0,
	shoplevel		TINYINT DEFAULT 1,
	memberlimit		smallINT DEFAULT 10,
	IsOverlord		BIT DEFAULT FALSE,
	
	CONSTRAINT guild_roleid_fk FOREIGN KEY(chiefid) REFERENCES role(roleid)
	ON DELETE CASCADE
    ON UPDATE CASCADE
);

CREATE TABLE guildmember
(
	guildid				INT 		NOT NULL,
	roleid				INT 		NOT NULL,
	guildtitle			VARCHAR(20) DEFAULT '',
	memberrank			TINYINT 	DEFAULT 4,
	declaration			VARCHAR(20) DEFAULT '',
	commentc			VARCHAR(20) DEFAULT '',
	claimbenefit		BIT 		DEFAULT FALSE,
	contributiontoday	SMALLINT	DEFAULT 0,
	contributionlast	INT			DEFAULT 0,
	contributiontotal	INT			DEFAULT 0,
	
	PRIMARY KEY(guildid,roleid),
	CONSTRAINT guildmembers_roleid_fk FOREIGN KEY(roleid) REFERENCES role(roleid)
	ON DELETE CASCADE
    ON UPDATE CASCADE,
	CONSTRAINT guildmembers_guildid_fk FOREIGN KEY(guildid) REFERENCES guild(guildid)
	ON DELETE CASCADE
    ON UPDATE CASCADE
);

CREATE TABLE guildapply
(
	guildid					INT 				NOT NULL,
	roleid					INT 				NOT NULL,
	applydate				INT 				NOT NULL,
	
	PRIMARY KEY(guildid,roleid),
	
	CONSTRAINT 	guildapply_roleid_fk FOREIGN KEY(roleid) REFERENCES role(roleid)
	ON DELETE 	CASCADE
    ON UPDATE 	CASCADE,
	
	CONSTRAINT 	guildapply_guildid_fk FOREIGN KEY(guildid) REFERENCES guild(guildid)
	ON DELETE 	CASCADE
    ON UPDATE 	CASCADE
);		

CREATE TABLE combat
(
	roleid					INT					PRIMARY KEY,
	hp						INT 				DEFAULT 0,
	mp						INT 				DEFAULT 0,
	combatpower				INT 				DEFAULT 0,
  
	CONSTRAINT combat_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
	ON DELETE CASCADE 
	ON UPDATE CASCADE 
);

CREATE TABLE starmap
(
	roleid					INT					PRIMARY KEY,
	curindex				TINYINT				DEFAULT 1,
	curpos					TINYINT				DEFAULT 0,
	nextpos					TINYINT 			DEFAULT 0,

	timeleft				INT					DEFAULT 0,
	INTeract				TINYINT 			DEFAULT 3,
	passive					TINYINT				DEFAULT 3,

	CONSTRAINT starmap_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
	ON DELETE CASCADE 
	ON UPDATE CASCADE 
);

CREATE TABLE buff
(
	buffid					INT				NOT NULL,
	roleid					INT				NOT NULL,
	starttime				INT				DEFAULT 0,
	endtime					INT				DEFAULT 0,
	buffvalue				INT				DEFAULT 0,
	bufftype				TINYINT			DEFAULT 1,
	
	PRIMARY KEY(buffid,roleid),
	
	CONSTRAINT buff_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
	ON DELETE CASCADE 
	ON UPDATE CASCADE 
);

CREATE TABLE codevoucher
(
	codeid					CHAR(8)				NOT NULL,
	roleid					INT					NOT NULL,
	
	PRIMARY KEY(codeid,roleid),
	
	CONSTRAINT codevoucher_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
	ON DELETE CASCADE 
	ON UPDATE CASCADE 
);

CREATE TABLE zodiacgoal
(
	roleid					INT 				PRIMARY KEY,
	zvalue					BINARY(30) 			DEFAULT 0x000000000000000000000000000000000000000000000000000000000000,
	
	CONSTRAINT zodiacgoal_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
	ON DELETE CASCADE 
	ON UPDATE CASCADE 
);

CREATE TABLE happyclaim
(
	roleid					INT					PRIMARY KEY,
	mclaim					BINARY(8)			DEFAULT 0x0000000000000000,
	rclaim					BINARY(8)			DEFAULT 0x0000000000000000,
	
	CONSTRAINT happyclaim_roleid_fk FOREIGN KEY (roleid) REFERENCES role(roleid) 
	ON DELETE CASCADE 
	ON UPDATE CASCADE 
);

CREATE TABLE server
(
	srvid					INT					PRIMARY KEY,
	srvDesc					VARCHAR(10)			NOT NULL,
	srvver					INT					NOT NULL DEFAULT 1
	
);

INSERT INTO server(srvid,srvdesc,srvver)
VALUES (1,"s1",5);

CREATE TABLE iteminfo
(
	itemid					INT					PRIMARY KEY,
	name					VARCHAR(60)			DEFAULT '',
	typei					TINYINT				DEFAULT 0,
	subtypei				TINYINT 			DEFAULT 0,
	quality					TINYINT 			DEFAULT 0,
	career					TINYINT 			DEFAULT 0,
	lvl						TINYINT				DEFAULT 0
);

CREATE TABLE premium
(
	roleid 					INT 			PRIMARY KEY,
	chance 					BINARY(12) 			DEFAULT 0x000000000000000000000000,
	discount 				BINARY(3) 			DEFAULT 0x000000,
	marketc 				INT 			DEFAULT 0,
	shopc 					INT 			DEFAULT 0,
	gearc 					VARBINARY(75) 		DEFAULT 0x000000,

	CONSTRAINT premium_roleid_fk FOREIGN KEY (roleid) REFERENCES role (roleid) 
	ON DELETE CASCADE 
	ON UPDATE CASCADE
);

CREATE TABLE quest
(
	roleid 					INT					PRIMARY KEY,	
	questdata				VARCHAR(8500)		NOT NULL DEFAULT '',

	CONSTRAINT quest_roleid_fk FOREIGN KEY (roleid) REFERENCES role (roleid) 
	ON DELETE CASCADE 
	ON UPDATE CASCADE
);

CREATE TABLE DailyShop
(
	dayshopid				INT					PRIMARY KEY,
	dayint					TINYINT				NOT NULL,
	dayshopdata				VARCHAR(1000)		NOT NULL
);

