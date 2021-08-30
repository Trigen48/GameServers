using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainbowServer.proto.rpc;
namespace RainbowServer.Handler
{
    internal static class RpcCommand
    {
        internal static void ParseCommand(ref ConnectionInfo c, ref Rpc req, ref RpcAck res)
        {
            switch (req.name)
            {
                case "ActivityCfg":
                    RpcCommands.onActivityCfg(ref c, ref req, ref res);
                    break;
                case "ActivityGetInfo":
                    RpcCommands.onActivityGetInfo(ref c, ref req, ref res);
                    break;
                case "ActivityShowBtn":
                    RpcCommands.onActivityShowBtn(ref c, ref req, ref res);
                    break;
                case "ActivityUpdateCfg":
                    RpcCommands.onActivityUpdateCfg(ref c, ref req, ref res);
                    break;
                case "ActivityUpdateData":
                    RpcCommands.onActivityUpdateData(ref c, ref req, ref res);
                    break;
                case "ActivityUpdateNum":
                    RpcCommands.onActivityUpdateNum(ref c, ref req, ref res);
                    break;
                case "ActivityUpdateQuestChain":
                    RpcCommands.onActivityUpdateQuestChain(ref c, ref req, ref res);
                    break;
                case "ActyRewds":
                    RpcCommands.onActyRewds(ref c, ref req, ref res);
                    break;
                case "ActyRewdUnit":
                    RpcCommands.onActyRewdUnit(ref c, ref req, ref res);
                    break;
                case "AddBossRushTimes":
                    RpcCommands.onAddBossRushTimes(ref c, ref req, ref res);
                    break;
                case "AddFamilyWorshipMoney":
                    RpcCommands.onAddFamilyWorshipMoney(ref c, ref req, ref res);
                    break;
                case "AddItem":
                    RpcCommands.onAddItem(ref c, ref req, ref res);
                    break;
                case "AddPet":
                    RpcCommands.onAddPet(ref c, ref req, ref res);
                    break;
                case "AddPetExp":
                    RpcCommands.onAddPetExp(ref c, ref req, ref res);
                    break;
                case "AddPushItemInfo":
                    RpcCommands.onAddPushItemInfo(ref c, ref req, ref res);
                    break;
                case "AdvancedEnchant":
                    RpcCommands.onAdvancedEnchant(ref c, ref req, ref res);
                    break;
                case "AstrologyRpc":
                    RpcCommands.onAstrologyRpc(ref c, ref req, ref res);
                    break;
                case "AstrologyRpcAck":
                    RpcCommands.onAstrologyRpcAck(ref c, ref req, ref res);
                    break;
                case "AutoVechile":
                    RpcCommands.onAutoVechile(ref c, ref req, ref res);
                    break;
                case "BackwardBossRushLevel":
                    RpcCommands.onBackwardBossRushLevel(ref c, ref req, ref res);
                    break;
                case "BagItemInfo":
                    RpcCommands.onBagItemInfo(ref c, ref req, ref res);
                    break;
                case "BagItemPropInfo":
                    RpcCommands.onBagItemPropInfo(ref c, ref req, ref res);
                    break;
                case "BatchBuyItem":
                    RpcCommands.onBatchBuyItem(ref c, ref req, ref res);
                    break;
                case "BatchSellItem":
                    RpcCommands.onBatchSellItem(ref c, ref req, ref res);
                    break;
                case "Beautician":
                    RpcCommands.onBeautician(ref c, ref req, ref res);
                    break;
                case "BellOperate":
                    RpcCommands.onBellOperate(ref c, ref req, ref res);
                    break;
                case "BlessParty":
                    RpcCommands.onBlessParty(ref c, ref req, ref res);
                    break;
                case "BuyItem":
                    RpcCommands.onBuyItem(ref c, ref req, ref res);
                    break;
                case "BuyMysticStoreItem":
                    RpcCommands.onBuyMysticStoreItem(ref c, ref req, ref res);
                    break;
                case "BuyMysticStoreItemAck":
                    RpcCommands.onBuyMysticStoreItemAck(ref c, ref req, ref res);
                    break;
                case "BuyNewMysticBusinessItem":
                    RpcCommands.onBuyNewMysticBusinessItem(ref c, ref req, ref res);
                    break;
                case "BuyNewMysticBusinessItemAck":
                    RpcCommands.onBuyNewMysticBusinessItemAck(ref c, ref req, ref res);
                    break;
                case "BuyNewMysticStoreItem":
                    RpcCommands.onBuyNewMysticStoreItem(ref c, ref req, ref res);
                    break;
                case "BuyNewMysticStoreItemAck":
                    RpcCommands.onBuyNewMysticStoreItemAck(ref c, ref req, ref res);
                    break;
                case "BuyPushItem":
                    RpcCommands.onBuyPushItem(ref c, ref req, ref res);
                    break;
                case "CanShowMysticBusiness":
                    RpcCommands.onCanShowMysticBusiness(ref c, ref req, ref res);
                    break;
                case "CaressPet":
                    RpcCommands.onCaressPet(ref c, ref req, ref res);
                    break;
                case "CatGardenOp":
                    RpcCommands.onCatGardenOp(ref c, ref req, ref res);
                    break;
                case "ChangeEquipment":
                    RpcCommands.onChangeEquipment(ref c, ref req, ref res);
                    break;
                case "ChangeGenderReq":
                    RpcCommands.onChangeGenderReq(ref c, ref req, ref res);
                    break;
                case "ChangeMountEquipment":
                    RpcCommands.onChangeMountEquipment(ref c, ref req, ref res);
                    break;
                case "ChangePetName":
                    RpcCommands.onChangePetName(ref c, ref req, ref res);
                    break;
                case "ChargeGiftMessge":
                    RpcCommands.onChargeGiftMessge(ref c, ref req, ref res);
                    break;
                case "ChargeLifeCrystalReq":
                    RpcCommands.onChargeLifeCrystalReq(ref c, ref req, ref res);
                    break;
                case "ChargeLifeCrystalResp":
                    RpcCommands.onChargeLifeCrystalResp(ref c, ref req, ref res);
                    break;
                case "CheckNewMysticBusinessCanShow":
                    RpcCommands.onCheckNewMysticBusinessCanShow(ref c, ref req, ref res);
                    break;
                case "CheckNewMysticBusinessItem":
                    RpcCommands.onCheckNewMysticBusinessItem(ref c, ref req, ref res);
                    break;
                case "CheckNewMysticBusinessItemAck":
                    RpcCommands.onCheckNewMysticBusinessItemAck(ref c, ref req, ref res);
                    break;
                case "CheckNewMysticBusinessItemInfo":
                    RpcCommands.onCheckNewMysticBusinessItemInfo(ref c, ref req, ref res);
                    break;
                case "CheckNewMysticStoreItem":
                    RpcCommands.onCheckNewMysticStoreItem(ref c, ref req, ref res);
                    break;
                case "CheckNewMysticStoreItemAck":
                    RpcCommands.onCheckNewMysticStoreItemAck(ref c, ref req, ref res);
                    break;
                case "CoMarketOpRpc":
                    RpcCommands.onCoMarketOpRpc(ref c, ref req, ref res);
                    break;
                case "Consume":
                    RpcCommands.onConsume(ref c, ref req, ref res);
                    break;
                case "DailyRightsReq":
                    RpcCommands.onDailyRightsReq(ref c, ref req, ref res);
                    break;
                case "DailyRightsResp":
                    RpcCommands.onDailyRightsResp(ref c, ref req, ref res);
                    break;
                case "DecomposeEquip":
                    RpcCommands.onDecomposeEquip(ref c, ref req, ref res);
                    break;
                case "DesignationOp":
                    RpcCommands.onDesignationOp(ref c, ref req, ref res);
                    break;
                case "DiabetesMoveBox":
                    RpcCommands.onDiabetesMoveBox(ref c, ref req, ref res);
                    break;
                case "DiabetesOp":
                    RpcCommands.onDiabetesOp(ref c, ref req, ref res);
                    break;
                case "DoActivityXchg":
                    RpcCommands.onDoActivityXchg(ref c, ref req, ref res);
                    break;
                case "DoDailyRefresh":
                    RpcCommands.onDoDailyRefresh(ref c, ref req, ref res);
                    break;
                case "DoFamilyWorship":
                    RpcCommands.onDoFamilyWorship(ref c, ref req, ref res);
                    break;
                case "DoItemTurnin":
                    RpcCommands.onDoItemTurnin(ref c, ref req, ref res);
                    break;
                case "DoItemXchg":
                    RpcCommands.onDoItemXchg(ref c, ref req, ref res);
                    break;
                case "DoMagicDarts":
                    RpcCommands.onDoMagicDarts(ref c, ref req, ref res);
                    break;
                case "DoTurntableDraw":
                    RpcCommands.onDoTurntableDraw(ref c, ref req, ref res);
                    break;
                case "DragonSoulOp":
                    RpcCommands.onDragonSoulOp(ref c, ref req, ref res);
                    break;
                case "Enchant":
                    RpcCommands.onEnchant(ref c, ref req, ref res);
                    break;
                case "EquipDegreeUp":
                    RpcCommands.onEquipDegreeUp(ref c, ref req, ref res);
                    break;
                case "EquipmentConvert":
                    RpcCommands.onEquipmentConvert(ref c, ref req, ref res);
                    break;
                case "EquipOnInfo":
                    RpcCommands.onEquipOnInfo(ref c, ref req, ref res);
                    break;
                case "EquiponPreDisplay":
                    RpcCommands.onEquiponPreDisplay(ref c, ref req, ref res);
                    break;
                case "ExplorationRpc":
                    RpcCommands.onExplorationRpc(ref c, ref req, ref res);
                    break;
                case "ExplorationRpcAck":
                    RpcCommands.onExplorationRpcAck(ref c, ref req, ref res);
                    break;
                case "FeedPet":
                    RpcCommands.onFeedPet(ref c, ref req, ref res);
                    break;
                case "FestivalGiftInfo":
                    RpcCommands.onFestivalGiftInfo(ref c, ref req, ref res);
                    break;
                case "FetchLevelGiftResult":
                    RpcCommands.onFetchLevelGiftResult(ref c, ref req, ref res);
                    break;
                case "FightBossRushCard":
                    RpcCommands.onFightBossRushCard(ref c, ref req, ref res);
                    break;
                case "FODisplay":
                    RpcCommands.onFODisplay(ref c, ref req, ref res);
                    break;
                case "ForgeEquip":
                    RpcCommands.onForgeEquip(ref c, ref req, ref res);
                    break;
                case "ForgeMountEquip":
                    RpcCommands.onForgeMountEquip(ref c, ref req, ref res);
                    break;
                case "ForwardBossRushLevel":
                    RpcCommands.onForwardBossRushLevel(ref c, ref req, ref res);
                    break;
                case "FreePet":
                    RpcCommands.onFreePet(ref c, ref req, ref res);
                    break;
                case "GainNewbieGift":
                    RpcCommands.onGainNewbieGift(ref c, ref req, ref res);
                    break;
                case "GatherGameObj":
                    RpcCommands.onGatherGameObj(ref c, ref req, ref res);
                    break;
                case "GatherStart":
                    RpcCommands.onGatherStart(ref c, ref req, ref res);
                    break;
                case "GatherStop":
                    RpcCommands.onGatherStop(ref c, ref req, ref res);
                    break;
                case "GemSocketRpc":
                    RpcCommands.onGemSocketRpc(ref c, ref req, ref res);
                    break;
                case "GetActivityXchgCfg":
                    RpcCommands.onGetActivityXchgCfg(ref c, ref req, ref res);
                    break;
                case "GetActyItem":
                    RpcCommands.onGetActyItem(ref c, ref req, ref res);
                    break;
                case "GetActyItemResult":
                    RpcCommands.onGetActyItemResult(ref c, ref req, ref res);
                    break;
                case "GetActyRewdInfo":
                    RpcCommands.onGetActyRewdInfo(ref c, ref req, ref res);
                    break;
                case "GetAllPushItemInfos":
                    RpcCommands.onGetAllPushItemInfos(ref c, ref req, ref res);
                    break;
                case "GetBossRushAward":
                    RpcCommands.onGetBossRushAward(ref c, ref req, ref res);
                    break;
                case "GetBossRushDailyAward":
                    RpcCommands.onGetBossRushDailyAward(ref c, ref req, ref res);
                    break;
                case "GetBossRushFinalAward":
                    RpcCommands.onGetBossRushFinalAward(ref c, ref req, ref res);
                    break;
                case "GetBossRushInfo":
                    RpcCommands.onGetBossRushInfo(ref c, ref req, ref res);
                    break;
                case "GetDailyPayReward":
                    RpcCommands.onGetDailyPayReward(ref c, ref req, ref res);
                    break;
                case "GetDiabetes":
                    RpcCommands.onGetDiabetes(ref c, ref req, ref res);
                    break;
                case "GetDropItem":
                    RpcCommands.onGetDropItem(ref c, ref req, ref res);
                    break;
                case "GetDropItems":
                    RpcCommands.onGetDropItems(ref c, ref req, ref res);
                    break;
                case "GetFamilyWorshipData":
                    RpcCommands.onGetFamilyWorshipData(ref c, ref req, ref res);
                    break;
                case "GetFestival":
                    RpcCommands.onGetFestival(ref c, ref req, ref res);
                    break;
                case "GetFestivalReult":
                    RpcCommands.onGetFestivalReult(ref c, ref req, ref res);
                    break;
                case "GetFixedPayActGift":
                    RpcCommands.onGetFixedPayActGift(ref c, ref req, ref res);
                    break;
                case "GetFixedPayActGiftAck":
                    RpcCommands.onGetFixedPayActGiftAck(ref c, ref req, ref res);
                    break;
                case "GetFixedPayActInfo":
                    RpcCommands.onGetFixedPayActInfo(ref c, ref req, ref res);
                    break;
                case "GetItemXchgCfg":
                    RpcCommands.onGetItemXchgCfg(ref c, ref req, ref res);
                    break;
                case "GetLevelGiftInfo":
                    RpcCommands.onGetLevelGiftInfo(ref c, ref req, ref res);
                    break;
                case "GetLimitItemRemain":
                    RpcCommands.onGetLimitItemRemain(ref c, ref req, ref res);
                    break;
                case "GetLimitItemRemainAck":
                    RpcCommands.onGetLimitItemRemainAck(ref c, ref req, ref res);
                    break;
                case "GetLoopQuestRewards":
                    RpcCommands.onGetLoopQuestRewards(ref c, ref req, ref res);
                    break;
                case "GetMagicDartsData":
                    RpcCommands.onGetMagicDartsData(ref c, ref req, ref res);
                    break;
                case "getMagicsuitUpReq":
                    RpcCommands.ongetMagicsuitUpReq(ref c, ref req, ref res);
                    break;
                case "getMagicsuitUpResp":
                    RpcCommands.ongetMagicsuitUpResp(ref c, ref req, ref res);
                    break;
                case "GetMonthFeedbackGiftReq":
                    RpcCommands.onGetMonthFeedbackGiftReq(ref c, ref req, ref res);
                    break;
                case "GetMonthFeedbackGiftResp":
                    RpcCommands.onGetMonthFeedbackGiftResp(ref c, ref req, ref res);
                    break;
                case "GetMonthFeedbackInfo":
                    RpcCommands.onGetMonthFeedbackInfo(ref c, ref req, ref res);
                    break;
                case "GetNewMysticBusinessItemList":
                    RpcCommands.onGetNewMysticBusinessItemList(ref c, ref req, ref res);
                    break;
                case "GetNewMysticBusinessItemListAck":
                    RpcCommands.onGetNewMysticBusinessItemListAck(ref c, ref req, ref res);
                    break;
                case "GetNewMysticStoreItemList":
                    RpcCommands.onGetNewMysticStoreItemList(ref c, ref req, ref res);
                    break;
                case "GetOpenServerTime":
                    RpcCommands.onGetOpenServerTime(ref c, ref req, ref res);
                    break;
                case "GetPartyBlessingData":
                    RpcCommands.onGetPartyBlessingData(ref c, ref req, ref res);
                    break;
                case "GetPartyBlessingReward":
                    RpcCommands.onGetPartyBlessingReward(ref c, ref req, ref res);
                    break;
                case "GetServerTime":
                    RpcCommands.onGetServerTime(ref c, ref req, ref res);
                    break;
                case "GetServerTimeDebug":
                    RpcCommands.onGetServerTimeDebug(ref c, ref req, ref res);
                    break;
                case "GetSignInfo":
                    RpcCommands.onGetSignInfo(ref c, ref req, ref res);
                    break;
                case "GetSignItems":
                    RpcCommands.onGetSignItems(ref c, ref req, ref res);
                    break;
                case "GetSignItemsReult":
                    RpcCommands.onGetSignItemsReult(ref c, ref req, ref res);
                    break;
                case "GetStoreItemList":
                    RpcCommands.onGetStoreItemList(ref c, ref req, ref res);
                    break;
                case "GetTurntableDrawData":
                    RpcCommands.onGetTurntableDrawData(ref c, ref req, ref res);
                    break;
                case "GodshipOp":
                    RpcCommands.onGodshipOp(ref c, ref req, ref res);
                    break;
                case "GrowingFundOp":
                    RpcCommands.onGrowingFundOp(ref c, ref req, ref res);
                    break;
                case "GuidePickupSword":
                    RpcCommands.onGuidePickupSword(ref c, ref req, ref res);
                    break;
                case "GuideSetXpFull":
                    RpcCommands.onGuideSetXpFull(ref c, ref req, ref res);
                    break;
                case "InviteeEnterGame":
                    RpcCommands.onInviteeEnterGame(ref c, ref req, ref res);
                    break;
                case "IsNewMysticBusinessItemCanBuy":
                    RpcCommands.onIsNewMysticBusinessItemCanBuy(ref c, ref req, ref res);
                    break;
                case "IsNewMysticBusinessItemCanBuyAck":
                    RpcCommands.onIsNewMysticBusinessItemCanBuyAck(ref c, ref req, ref res);
                    break;
                case "IsNewMysticStoreCanPurchase":
                    RpcCommands.onIsNewMysticStoreCanPurchase(ref c, ref req, ref res);
                    break;
                case "IsNewMysticStoreCanPurchaseAck":
                    RpcCommands.onIsNewMysticStoreCanPurchaseAck(ref c, ref req, ref res);
                    break;
                case "IsNewMysticStoreFreeRefresh":
                    RpcCommands.onIsNewMysticStoreFreeRefresh(ref c, ref req, ref res);
                    break;
                case "IsNewMysticStoreFreeRefreshAck":
                    RpcCommands.onIsNewMysticStoreFreeRefreshAck(ref c, ref req, ref res);
                    break;
                case "ItemCell":
                    RpcCommands.onItemCell(ref c, ref req, ref res);
                    break;
                case "ItemXchgCfg":
                    RpcCommands.onItemXchgCfg(ref c, ref req, ref res);
                    break;
                case "ItemXchgItem":
                    RpcCommands.onItemXchgItem(ref c, ref req, ref res);
                    break;
                case "L2pwdAuth":
                    RpcCommands.onL2pwdAuth(ref c, ref req, ref res);
                    break;
                case "L2pwdRpc":
                    RpcCommands.onL2pwdRpc(ref c, ref req, ref res);
                    break;
                case "L2pwdUpdate":
                    RpcCommands.onL2pwdUpdate(ref c, ref req, ref res);
                    break;
                case "LearnPetSkill":
                    RpcCommands.onLearnPetSkill(ref c, ref req, ref res);
                    break;
                case "LearnPetSkillResult":
                    RpcCommands.onLearnPetSkillResult(ref c, ref req, ref res);
                    break;
                case "LevelBuyOp":
                    RpcCommands.onLevelBuyOp(ref c, ref req, ref res);
                    break;
                case "LevelGiftInfo":
                    RpcCommands.onLevelGiftInfo(ref c, ref req, ref res);
                    break;
                case "LevelGiftUnit":
                    RpcCommands.onLevelGiftUnit(ref c, ref req, ref res);
                    break;
                case "LevelupSendItem":
                    RpcCommands.onLevelupSendItem(ref c, ref req, ref res);
                    break;
                case "LimitItemInfo":
                    RpcCommands.onLimitItemInfo(ref c, ref req, ref res);
                    break;
                case "MagicDartsCfg":
                    RpcCommands.onMagicDartsCfg(ref c, ref req, ref res);
                    break;
                case "MagicSuit":
                    RpcCommands.onMagicSuit(ref c, ref req, ref res);
                    break;
                case "MagicSuitInfo":
                    RpcCommands.onMagicSuitInfo(ref c, ref req, ref res);
                    break;
                case "MagicsuitUpRise":
                    RpcCommands.onMagicsuitUpRise(ref c, ref req, ref res);
                    break;
                case "MagicsuitUpRiseAck":
                    RpcCommands.onMagicsuitUpRiseAck(ref c, ref req, ref res);
                    break;
                case "MicroGiftReq":
                    RpcCommands.onMicroGiftReq(ref c, ref req, ref res);
                    break;
                case "MicroGiftRet":
                    RpcCommands.onMicroGiftRet(ref c, ref req, ref res);
                    break;
                case "MonthFeedbackData":
                    RpcCommands.onMonthFeedbackData(ref c, ref req, ref res);
                    break;
                case "MonthFeedbackGiftInfo":
                    RpcCommands.onMonthFeedbackGiftInfo(ref c, ref req, ref res);
                    break;
                case "MonthFeedbackGiftUnit":
                    RpcCommands.onMonthFeedbackGiftUnit(ref c, ref req, ref res);
                    break;
                case "MountBless":
                    RpcCommands.onMountBless(ref c, ref req, ref res);
                    break;
                case "MountCard":
                    RpcCommands.onMountCard(ref c, ref req, ref res);
                    break;
                case "MountLevelUp":
                    RpcCommands.onMountLevelUp(ref c, ref req, ref res);
                    break;
                case "MultiGift":
                    RpcCommands.onMultiGift(ref c, ref req, ref res);
                    break;
                case "NeedCharge":
                    RpcCommands.onNeedCharge(ref c, ref req, ref res);
                    break;
                case "NewMysticStoreCheckItemInfo":
                    RpcCommands.onNewMysticStoreCheckItemInfo(ref c, ref req, ref res);
                    break;
                case "NewMysticStoreZeroReset":
                    RpcCommands.onNewMysticStoreZeroReset(ref c, ref req, ref res);
                    break;
                case "OffLine1V1Req":
                    RpcCommands.onOffLine1V1Req(ref c, ref req, ref res);
                    break;
                case "OffLine1V1Resp":
                    RpcCommands.onOffLine1V1Resp(ref c, ref req, ref res);
                    break;
                case "OffLineItem":
                    RpcCommands.onOffLineItem(ref c, ref req, ref res);
                    break;
                case "OpenBossRushCard":
                    RpcCommands.onOpenBossRushCard(ref c, ref req, ref res);
                    break;
                case "PayGift":
                    RpcCommands.onPayGift(ref c, ref req, ref res);
                    break;
                case "PersonReborn":
                    RpcCommands.onPersonReborn(ref c, ref req, ref res);
                    break;
                case "PetBookUpdate":
                    RpcCommands.onPetBookUpdate(ref c, ref req, ref res);
                    break;
                case "PetImprove":
                    RpcCommands.onPetImprove(ref c, ref req, ref res);
                    break;
                case "PetImproveResult":
                    RpcCommands.onPetImproveResult(ref c, ref req, ref res);
                    break;
                case "PetInherit":
                    RpcCommands.onPetInherit(ref c, ref req, ref res);
                    break;
                case "PetInheritResult":
                    RpcCommands.onPetInheritResult(ref c, ref req, ref res);
                    break;
                case "PetLock":
                    RpcCommands.onPetLock(ref c, ref req, ref res);
                    break;
                case "PetSpriteReq":
                    RpcCommands.onPetSpriteReq(ref c, ref req, ref res);
                    break;
                case "PetSpriteRsp":
                    RpcCommands.onPetSpriteRsp(ref c, ref req, ref res);
                    break;
                case "PickupDropItem":
                    RpcCommands.onPickupDropItem(ref c, ref req, ref res);
                    break;
                case "PiggyBankRequest":
                    RpcCommands.onPiggyBankRequest(ref c, ref req, ref res);
                    break;
                case "PlatStateReq":
                    RpcCommands.onPlatStateReq(ref c, ref req, ref res);
                    break;
                case "PlatStateResp":
                    RpcCommands.onPlatStateResp(ref c, ref req, ref res);
                    break;
                case "ProfessionTransfer":
                    RpcCommands.onProfessionTransfer(ref c, ref req, ref res);
                    break;
                case "ProfessionTransferAgain":
                    RpcCommands.onProfessionTransferAgain(ref c, ref req, ref res);
                    break;
                case "PushGift":
                    RpcCommands.onPushGift(ref c, ref req, ref res);
                    break;
                case "PushItemInfo":
                    RpcCommands.onPushItemInfo(ref c, ref req, ref res);
                    break;
                case "QQFriendRecallReq":
                    RpcCommands.onQQFriendRecallReq(ref c, ref req, ref res);
                    break;
                case "QueryDailyGift":
                    RpcCommands.onQueryDailyGift(ref c, ref req, ref res);
                    break;
                case "QueryDailyGiftReult":
                    RpcCommands.onQueryDailyGiftReult(ref c, ref req, ref res);
                    break;
                case "QueryInviteGift":
                    RpcCommands.onQueryInviteGift(ref c, ref req, ref res);
                    break;
                case "QueryInviteGiftReult":
                    RpcCommands.onQueryInviteGiftReult(ref c, ref req, ref res);
                    break;
                case "QueryItemsResult":
                    RpcCommands.onQueryItemsResult(ref c, ref req, ref res);
                    break;
                case "QuestRpc":
                    RpcCommands.onQuestRpc(ref c, ref req, ref res);
                    break;
                case "QuestRpcAck":
                    RpcCommands.onQuestRpcAck(ref c, ref req, ref res);
                    break;
                case "Refine":
                    RpcCommands.onRefine(ref c, ref req, ref res);
                    break;
                case "RefineTransfer":
                    RpcCommands.onRefineTransfer(ref c, ref req, ref res);
                    break;
                case "RefreshMysticStore":
                    RpcCommands.onRefreshMysticStore(ref c, ref req, ref res);
                    break;
                case "RefreshMysticStoreAck":
                    RpcCommands.onRefreshMysticStoreAck(ref c, ref req, ref res);
                    break;
                case "RefreshNewMysticBusinessItem":
                    RpcCommands.onRefreshNewMysticBusinessItem(ref c, ref req, ref res);
                    break;
                case "RefreshNewMysticBusinessItemAck":
                    RpcCommands.onRefreshNewMysticBusinessItemAck(ref c, ref req, ref res);
                    break;
                case "RefreshNewMysticStoreItem":
                    RpcCommands.onRefreshNewMysticStoreItem(ref c, ref req, ref res);
                    break;
                case "RefreshNewMysticStoreItemAck":
                    RpcCommands.onRefreshNewMysticStoreItemAck(ref c, ref req, ref res);
                    break;
                case "Regain":
                    RpcCommands.onRegain(ref c, ref req, ref res);
                    break;
                case "RegainChange":
                    RpcCommands.onRegainChange(ref c, ref req, ref res);
                    break;
                case "ResetBossRushCard":
                    RpcCommands.onResetBossRushCard(ref c, ref req, ref res);
                    break;
                case "Rpc":
                    RpcCommands.onRpc(ref c, ref req, ref res);
                    break;
                case "RpcAck":
                    RpcCommands.onRpcAck(ref c, ref req, ref res);
                    break;
                case "Run":
                    RpcCommands.onRun(ref c, ref req, ref res);
                    break;
                case "SaveEnchantProps":
                    RpcCommands.onSaveEnchantProps(ref c, ref req, ref res);
                    break;
                case "SellItem":
                    RpcCommands.onSellItem(ref c, ref req, ref res);
                    break;
                case "SetChatBubbleType":
                    RpcCommands.onSetChatBubbleType(ref c, ref req, ref res);
                    break;
                case "SetDailyInviteGift":
                    RpcCommands.onSetDailyInviteGift(ref c, ref req, ref res);
                    break;
                case "SetDailyInviteGiftResult":
                    RpcCommands.onSetDailyInviteGiftResult(ref c, ref req, ref res);
                    break;
                case "SetHpHealThreshold":
                    RpcCommands.onSetHpHealThreshold(ref c, ref req, ref res);
                    break;
                case "SetMpHealThreshold":
                    RpcCommands.onSetMpHealThreshold(ref c, ref req, ref res);
                    break;
                case "SetPartyBlessingData":
                    RpcCommands.onSetPartyBlessingData(ref c, ref req, ref res);
                    break;
                case "SetPetSlotNum":
                    RpcCommands.onSetPetSlotNum(ref c, ref req, ref res);
                    break;
                case "ShareStory":
                    RpcCommands.onShareStory(ref c, ref req, ref res);
                    break;
                case "ShopBuyItem":
                    RpcCommands.onShopBuyItem(ref c, ref req, ref res);
                    break;
                case "SignConuConfig":
                    RpcCommands.onSignConuConfig(ref c, ref req, ref res);
                    break;
                case "SignIn":
                    RpcCommands.onSignIn(ref c, ref req, ref res);
                    break;
                case "SignInResult":
                    RpcCommands.onSignInResult(ref c, ref req, ref res);
                    break;
                case "SignTotConfig":
                    RpcCommands.onSignTotConfig(ref c, ref req, ref res);
                    break;
                case "SignUnit":
                    RpcCommands.onSignUnit(ref c, ref req, ref res);
                    break;
                case "SignUserData":
                    RpcCommands.onSignUserData(ref c, ref req, ref res);
                    break;
                case "SortBag":
                    RpcCommands.onSortBag(ref c, ref req, ref res);
                    break;
                case "SortStore":
                    RpcCommands.onSortStore(ref c, ref req, ref res);
                    break;
                case "SplitItem":
                    RpcCommands.onSplitItem(ref c, ref req, ref res);
                    break;
                case "StoreItem":
                    RpcCommands.onStoreItem(ref c, ref req, ref res);
                    break;
                case "StoreMoney":
                    RpcCommands.onStoreMoney(ref c, ref req, ref res);
                    break;
                case "TencentVipReq":
                    RpcCommands.onTencentVipReq(ref c, ref req, ref res);
                    break;
                case "TencentVipResp":
                    RpcCommands.onTencentVipResp(ref c, ref req, ref res);
                    break;
                case "ThrownItem":
                    RpcCommands.onThrownItem(ref c, ref req, ref res);
                    break;
                case "TowerBuyItem":
                    RpcCommands.onTowerBuyItem(ref c, ref req, ref res);
                    break;
                case "TransferEnchantProps":
                    RpcCommands.onTransferEnchantProps(ref c, ref req, ref res);
                    break;
                case "TransferLoverReq":
                    RpcCommands.onTransferLoverReq(ref c, ref req, ref res);
                    break;
                case "Transport":
                    RpcCommands.onTransport(ref c, ref req, ref res);
                    break;
                case "TriggerDailyPay":
                    RpcCommands.onTriggerDailyPay(ref c, ref req, ref res);
                    break;
                case "TryDailyRefresh":
                    RpcCommands.onTryDailyRefresh(ref c, ref req, ref res);
                    break;
                case "TurntableDrawCfg":
                    RpcCommands.onTurntableDrawCfg(ref c, ref req, ref res);
                    break;
                case "Unlock":
                    RpcCommands.onUnlock(ref c, ref req, ref res);
                    break;
                case "UpdateActivityDgnTimes":
                    RpcCommands.onUpdateActivityDgnTimes(ref c, ref req, ref res);
                    break;
                case "UpdateBagItem":
                    RpcCommands.onUpdateBagItem(ref c, ref req, ref res);
                    break;
                case "UpdateBagItemProp":
                    RpcCommands.onUpdateBagItemProp(ref c, ref req, ref res);
                    break;
                case "UpdateBagSlotNum":
                    RpcCommands.onUpdateBagSlotNum(ref c, ref req, ref res);
                    break;
                case "UpdateBindCrystal":
                    RpcCommands.onUpdateBindCrystal(ref c, ref req, ref res);
                    break;
                case "UpdateContinuousLogin":
                    RpcCommands.onUpdateContinuousLogin(ref c, ref req, ref res);
                    break;
                case "UpdateCryStal":
                    RpcCommands.onUpdateCryStal(ref c, ref req, ref res);
                    break;
                case "UpdateDailyPayData":
                    RpcCommands.onUpdateDailyPayData(ref c, ref req, ref res);
                    break;
                case "UpdateEquipOn":
                    RpcCommands.onUpdateEquipOn(ref c, ref req, ref res);
                    break;
                case "UpdateFamilyContri":
                    RpcCommands.onUpdateFamilyContri(ref c, ref req, ref res);
                    break;
                case "UpdateHonorPoints":
                    RpcCommands.onUpdateHonorPoints(ref c, ref req, ref res);
                    break;
                case "UpdateMachinariumDgnTimes":
                    RpcCommands.onUpdateMachinariumDgnTimes(ref c, ref req, ref res);
                    break;
                case "UpdateManorBonus":
                    RpcCommands.onUpdateManorBonus(ref c, ref req, ref res);
                    break;
                case "UpdateMoney":
                    RpcCommands.onUpdateMoney(ref c, ref req, ref res);
                    break;
                case "UpdateMountEquipOn":
                    RpcCommands.onUpdateMountEquipOn(ref c, ref req, ref res);
                    break;
                case "UpdateMultiDgnTimes":
                    RpcCommands.onUpdateMultiDgnTimes(ref c, ref req, ref res);
                    break;
                case "updateNewbieLoginNum":
                    RpcCommands.onupdateNewbieLoginNum(ref c, ref req, ref res);
                    break;
                case "UpdatePetCombatPower":
                    RpcCommands.onUpdatePetCombatPower(ref c, ref req, ref res);
                    break;
                case "UpdatePriesthoodBonus":
                    RpcCommands.onUpdatePriesthoodBonus(ref c, ref req, ref res);
                    break;
                case "UpdateQuartz":
                    RpcCommands.onUpdateQuartz(ref c, ref req, ref res);
                    break;
                case "UpdateQuestCtrl":
                    RpcCommands.onUpdateQuestCtrl(ref c, ref req, ref res);
                    break;
                case "UpdateQuestData":
                    RpcCommands.onUpdateQuestData(ref c, ref req, ref res);
                    break;
                case "UpdateQuestObjNum":
                    RpcCommands.onUpdateQuestObjNum(ref c, ref req, ref res);
                    break;
                case "UpdateSeabedBonus":
                    RpcCommands.onUpdateSeabedBonus(ref c, ref req, ref res);
                    break;
                case "UpdateThreeDiabetesBonus":
                    RpcCommands.onUpdateThreeDiabetesBonus(ref c, ref req, ref res);
                    break;
                case "UpdateVitaRecTime":
                    RpcCommands.onUpdateVitaRecTime(ref c, ref req, ref res);
                    break;
                case "UpFixedPayActInfo":
                    RpcCommands.onUpFixedPayActInfo(ref c, ref req, ref res);
                    break;
                case "UseItem":
                    RpcCommands.onUseItem(ref c, ref req, ref res);
                    break;
                case "UseNpc":
                    RpcCommands.onUseNpc(ref c, ref req, ref res);
                    break;
                case "UsePillReq":
                    RpcCommands.onUsePillReq(ref c, ref req, ref res);
                    break;
                case "UsePillResp":
                    RpcCommands.onUsePillResp(ref c, ref req, ref res);
                    break;
                case "VipExtraReq":
                    RpcCommands.onVipExtraReq(ref c, ref req, ref res);
                    break;
                case "VipExtraResp":
                    RpcCommands.onVipExtraResp(ref c, ref req, ref res);
                    break;
                case "VitaRec":
                    RpcCommands.onVitaRec(ref c, ref req, ref res);
                    break;
                case "WingCardAdd":
                    RpcCommands.onWingCardAdd(ref c, ref req, ref res);
                    break;
                case "WingCardGetList":
                    RpcCommands.onWingCardGetList(ref c, ref req, ref res);
                    break;
                case "WingDisplay":
                    RpcCommands.onWingDisplay(ref c, ref req, ref res);
                    break;
                case "WingEquipOn":
                    RpcCommands.onWingEquipOn(ref c, ref req, ref res);
                    break;
                case "WingLevelUpReq":
                    RpcCommands.onWingLevelUpReq(ref c, ref req, ref res);
                    break;
                case "WingLevelUpResp":
                    RpcCommands.onWingLevelUpResp(ref c, ref req, ref res);
                    break;
                case "XchgTurntableDrawItem":
                    RpcCommands.onXchgTurntableDrawItem(ref c, ref req, ref res);
                    break;
                case "XOCashUpReq":
                    RpcCommands.onXOCashUpReq(ref c, ref req, ref res);
                    break;
                case "XOCashUpResp":
                    RpcCommands.onXOCashUpResp(ref c, ref req, ref res);
                    break;


            }


        }
    }
}
