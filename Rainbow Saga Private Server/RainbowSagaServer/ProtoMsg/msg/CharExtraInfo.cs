using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CharExtraInfo
	{

		[ProtoMember(1)]
		public ItemInventory bEquip{ get; set; }

		[ProtoMember(2)]
		public ItemInventory bConsume{ get; set; }

		[ProtoMember(3)]
		public ItemInventory bMaterial{ get; set; }

		[ProtoMember(4)]
		public ItemInventory bHomestead{ get; set; }

		[ProtoMember(5)]
		public ItemInventory bGem{ get; set; }

		[ProtoMember(6)]
		public ItemInventory bStore{ get; set; }

		[ProtoMember(17)]
		public ItemInventory bTask{ get; set; }

		[ProtoMember(7)]
		public SkillList bSkill{ get; set; }

		[ProtoMember(8)]
		public PetList bPet{ get; set; }

		[ProtoMember(9)]
		public QuestList bQuest{ get; set; }

		[ProtoMember(10)]
		public System bSystem{ get; set; }

		[ProtoMember(12)]
		public DgnData bDgndata{ get; set; }

		[ProtoMember(13)]
		public AbilityList bAbility{ get; set; }

		[ProtoMember(14)]
		public Buff bBuff{ get; set; }

		[ProtoMember(15)]
		public VariableList bVarlist{ get; set; }

		[ProtoMember(16)]
		public NewGuid newguidMark{ get; set; }

		[ProtoMember(18)]
		public OffLineProp bOffLineProp{ get; set; }

		[ProtoMember(19)]
		public KillMobsInfo bKillMobsInfo{ get; set; }

		[ProtoMember(20)]
		public SignData bSigndata{ get; set; }

		[ProtoMember(21)]
		public ActivityValue bAcivityValue{ get; set; }

		[ProtoMember(22)]
		public FestivalItem bFestivaleItems{ get; set; }

		[ProtoMember(26)]
		public QuestInfo bQuestInfo{ get; set; }

		[ProtoMember(27)]
		public OnlineAFK bOnlineAFK{ get; set; }

		[ProtoMember(28)]
		public LevelGiftRecord bLevelGiftRecord{ get; set; }

		[ProtoMember(30)]
		public WBSBuffInfo bWbsbuffInfo{ get; set; }

		[ProtoMember(31)]
		public PartyBlessingData bPartyBlessing{ get; set; }

		[ProtoMember(32)]
		public NewbieGift bNewbieGift{ get; set; }

		[ProtoMember(33)]
		public ExplorationInfo bExploration{ get; set; }

		[ProtoMember(34)]
		public WorldMapInfo bWorldmap{ get; set; }

		[ProtoMember(35)]
		public ActivityInfo bActivity{ get; set; }

		[ProtoMember(36)]
		public ArenaInfo bArena{ get; set; }

		[ProtoMember(37)]
		public VIPInfo bVip{ get; set; }

		[ProtoMember(38)]
		public Qzone bQzone{ get; set; }

		[ProtoMember(39)]
		public EnchantProps bEnchantProps{ get; set; }

		[ProtoMember(40)]
		public PiggyBank bPiggyBank{ get; set; }

		[ProtoMember(41)]
		public int bRecoverEnergy{ get; set; }

		[ProtoMember(42)]
		public MicroGift bMicroGift{ get; set; }

		[ProtoMember(43)]
		public ChargeGifts bChargeGifts{ get; set; }

		[ProtoMember(44)]
		public MopUpInfo bMopup{ get; set; }

		[ProtoMember(45)]
		public OffLine1V1Info bOffline1V1Info{ get; set; }

		[ProtoMember(46)]
		public GainNum bGainNum{ get; set; }

		[ProtoMember(47)]
		public RegainNum bRegainNum{ get; set; }

		[ProtoMember(48)]
		public BossRushInfo bBossRush{ get; set; }

		[ProtoMember(49)]
		public TurntableDrawData bTurntabledraw{ get; set; }

		[ProtoMember(50)]
		public ItemOwnNum bItemOwnNum{ get; set; }

		[ProtoMember(51)]
		public LevelBuy bLevelBuy{ get; set; }

		[ProtoMember(52)]
		public CatGarden bCatGarden{ get; set; }

		[ProtoMember(53)]
		public Bell bBell{ get; set; }

		[ProtoMember(54)]
		public PromptRecord bPromptRecord{ get; set; }

		[ProtoMember(55)]
		public LimitItemBuyList bLimitItemBuy{ get; set; }

		[ProtoMember(56)]
		public WingInfo bWing{ get; set; }

		[ProtoMember(57)]
		public XOInfo bXoInfo{ get; set; }

		[ProtoMember(58)]
		public AstrologyData bAstrology{ get; set; }

		[ProtoMember(59)]
		public Designation bDesignation{ get; set; }

		[ProtoMember(60)]
		public DailyRightsInfo bRightsInfo{ get; set; }

		[ProtoMember(61)]
		public MountInfo bMount{ get; set; }

		[ProtoMember(62)]
		public FmlyPet bFmlyPet{ get; set; }

		[ProtoMember(63)]
		public Pills bPills{ get; set; }

		[ProtoMember(64)]
		public FixedPayActivity bFixedPay{ get; set; }

		[ProtoMember(65)]
		public MultiPayActivity bMultiPay{ get; set; }

		[ProtoMember(66)]
		public NewServerBenefit bNewServerBenefit{ get; set; }

		[ProtoMember(67)]
		public TencentVipInfo bTencentVip{ get; set; }

		[ProtoMember(68)]
		public VipExtraInfo bVipExtra{ get; set; }

		[ProtoMember(69)]
		public MonthFeedback bMonthFeedback{ get; set; }

		[ProtoMember(70)]
		public PushItemInfos bPushItem{ get; set; }

		[ProtoMember(71)]
		public ChargeBonusInfo bBonusInfo{ get; set; }

		[ProtoMember(72)]
		public GrowingFund bGrowingFund{ get; set; }

		[ProtoMember(73)]
		public MagicDartsData bMagicdarts{ get; set; }

		[ProtoMember(74)]
		public ConsumeInfo bConsumeInfo{ get; set; }

		[ProtoMember(75)]
		public MysticStoreInfo bMysticStore{ get; set; }

		[ProtoMember(76)]
		public KillerModeInfo bKillerMode{ get; set; }

		[ProtoMember(77)]
		public OpenServerBenefit bOpenBenefit{ get; set; }

		[ProtoMember(78)]
		public FamilyWorshipData bFamilyworship{ get; set; }

		[ProtoMember(79)]
		public OpenTestGift bOpenTest{ get; set; }

		[ProtoMember(80)]
		public ConsumeBonusInfo bConsumeBonus{ get; set; }

		[ProtoMember(81)]
		public GodshipInfo bGodshipInfo{ get; set; }

		[ProtoMember(82)]
		public DailyPayData bDailypay{ get; set; }

		[ProtoMember(83)]
		public NewMysticStoreInfo bNewMysticStore{ get; set; }

		[ProtoMember(84)]
		public NewMysticBusinessInfo bNewMysticBusiness{ get; set; }

		[ProtoMember(85)]
		public FamilyInfo bFmlyInfo{ get; set; }

		[ProtoMember(86)]
		public TencentFriendRecall bTencentFrndrecall{ get; set; }

		[ProtoMember(87)]
		public DragonSoul bDragonSoul{ get; set; }

		[ProtoMember(88)]
		public ReachActValue bReachAct{ get; set; }

		[ProtoMember(89)]
		public Seabed bSeabed{ get; set; }

		[ProtoMember(90)]
		public FamilyCrystalDonate bFamilyCrystalDonate{ get; set; }

		[ProtoMember(91)]
		public ContinuousLogin bContinuousLogin{ get; set; }

		[ProtoMember(92)]
		public MentorInfo mentorinfo{ get; set; }

		[ProtoMember(93)]
		public MarriageData marriageInfo{ get; set; }

		[ProtoMember(94)]
		public L2pwdData bL2Pwd{ get; set; }

		[ProtoMember(95)]
		public MountDgnInfo bMountDgn{ get; set; }

		[ProtoMember(96)]
		public CharPersonReborn reborn{ get; set; }

		[ProtoMember(97)]
		public MagicsuitUp bMagicsuitup{ get; set; }

		[ProtoMember(98)]
		public ThreeDiabetes bThreeDiabetes{ get; set; }

		[ProtoMember(99)]
		public TripleInfo bTripleInfo{ get; set; }


		internal CharExtraInfo()
		{
			this.bEquip = new ItemInventory();
			this.bConsume = new ItemInventory();
			this.bMaterial = new ItemInventory();
			this.bHomestead = new ItemInventory();
			this.bGem = new ItemInventory();
			this.bStore = new ItemInventory();
			this.bTask = new ItemInventory();
			this.bSkill = new SkillList();
			this.bPet = new PetList();
			this.bQuest = new QuestList();
			this.bSystem = new System();
			this.bDgndata = new DgnData();
			this.bAbility = new AbilityList();
			this.bBuff = new Buff();
			this.bVarlist = new VariableList();
			this.newguidMark = new NewGuid();
			this.bOffLineProp = new OffLineProp();
			this.bKillMobsInfo = new KillMobsInfo();
			this.bSigndata = new SignData();
			this.bAcivityValue = new ActivityValue();
			this.bFestivaleItems = new FestivalItem();
			this.bQuestInfo = new QuestInfo();
			this.bOnlineAFK = new OnlineAFK();
			this.bLevelGiftRecord = new LevelGiftRecord();
			this.bWbsbuffInfo = new WBSBuffInfo();
			this.bPartyBlessing = new PartyBlessingData();
			this.bNewbieGift = new NewbieGift();
			this.bExploration = new ExplorationInfo();
			this.bWorldmap = new WorldMapInfo();
			this.bActivity = new ActivityInfo();
			this.bArena = new ArenaInfo();
			this.bVip = new VIPInfo();
			this.bQzone = new Qzone();
			this.bEnchantProps = new EnchantProps();
			this.bPiggyBank = new PiggyBank();
			this.bRecoverEnergy = 0;
			this.bMicroGift = new MicroGift();
			this.bChargeGifts = new ChargeGifts();
			this.bMopup = new MopUpInfo();
			this.bOffline1V1Info = new OffLine1V1Info();
			this.bGainNum = new GainNum();
			this.bRegainNum = new RegainNum();
			this.bBossRush = new BossRushInfo();
			this.bTurntabledraw = new TurntableDrawData();
			this.bItemOwnNum = new ItemOwnNum();
			this.bLevelBuy = new LevelBuy();
			this.bCatGarden = new CatGarden();
			this.bBell = new Bell();
			this.bPromptRecord = new PromptRecord();
			this.bLimitItemBuy = new LimitItemBuyList();
			this.bWing = new WingInfo();
			this.bXoInfo = new XOInfo();
			this.bAstrology = new AstrologyData();
			this.bDesignation = new Designation();
			this.bRightsInfo = new DailyRightsInfo();
			this.bMount = new MountInfo();
			this.bFmlyPet = new FmlyPet();
			this.bPills = new Pills();
			this.bFixedPay = new FixedPayActivity();
			this.bMultiPay = new MultiPayActivity();
			this.bNewServerBenefit = new NewServerBenefit();
			this.bTencentVip = new TencentVipInfo();
			this.bVipExtra = new VipExtraInfo();
			this.bMonthFeedback = new MonthFeedback();
			this.bPushItem = new PushItemInfos();
			this.bBonusInfo = new ChargeBonusInfo();
			this.bGrowingFund = new GrowingFund();
			this.bMagicdarts = new MagicDartsData();
			this.bConsumeInfo = new ConsumeInfo();
			this.bMysticStore = new MysticStoreInfo();
			this.bKillerMode = new KillerModeInfo();
			this.bOpenBenefit = new OpenServerBenefit();
			this.bFamilyworship = new FamilyWorshipData();
			this.bOpenTest = new OpenTestGift();
			this.bConsumeBonus = new ConsumeBonusInfo();
			this.bGodshipInfo = new GodshipInfo();
			this.bDailypay = new DailyPayData();
			this.bNewMysticStore = new NewMysticStoreInfo();
			this.bNewMysticBusiness = new NewMysticBusinessInfo();
			this.bFmlyInfo = new FamilyInfo();
			this.bTencentFrndrecall = new TencentFriendRecall();
			this.bDragonSoul = new DragonSoul();
			this.bReachAct = new ReachActValue();
			this.bSeabed = new Seabed();
			this.bFamilyCrystalDonate = new FamilyCrystalDonate();
			this.bContinuousLogin = new ContinuousLogin();
			this.mentorinfo = new MentorInfo();
			this.marriageInfo = new MarriageData();
			this.bL2Pwd = new L2pwdData();
			this.bMountDgn = new MountDgnInfo();
			this.reborn = new CharPersonReborn();
			this.bMagicsuitup = new MagicsuitUp();
			this.bThreeDiabetes = new ThreeDiabetes();
			this.bTripleInfo = new TripleInfo();
		}

	}

}
