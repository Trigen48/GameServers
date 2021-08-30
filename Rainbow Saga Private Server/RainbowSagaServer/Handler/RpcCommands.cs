using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.rpc;


namespace RainbowServer.Handler
{

    internal static class RpcCommands
    {

        internal static void onActivityCfg(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ActivityCfg");
            Console.WriteLine("RpcCommand.ActivityCfg No Command");

        }

        internal static void onActivityGetInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ActivityGetInfo");
            ActivityGetInfo req = new ActivityGetInfo();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onActivityShowBtn(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ActivityShowBtn");
            ActivityShowBtn req = new ActivityShowBtn();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onActivityUpdateCfg(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ActivityUpdateCfg");
            ActivityUpdateCfg req = new ActivityUpdateCfg();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onActivityUpdateData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ActivityUpdateData");
            ActivityUpdateData req = new ActivityUpdateData();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onActivityUpdateNum(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ActivityUpdateNum");
            ActivityUpdateNum req = new ActivityUpdateNum();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onActivityUpdateQuestChain(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ActivityUpdateQuestChain");
            ActivityUpdateQuestChain req = new ActivityUpdateQuestChain();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onActyRewds(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ActyRewds");
            ActyRewds req = new ActyRewds();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onActyRewdUnit(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ActyRewdUnit");
            Console.WriteLine("RpcCommand.ActyRewdUnit No Command");

        }

        internal static void onAddBossRushTimes(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AddBossRushTimes");
            AddBossRushTimes req = new AddBossRushTimes();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onAddFamilyWorshipMoney(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AddFamilyWorshipMoney");
            AddFamilyWorshipMoney req = new AddFamilyWorshipMoney();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onAddItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AddItem");
            AddItem req = new AddItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onAddPet(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AddPet");
            AddPet req = new AddPet();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onAddPetExp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AddPetExp");
            AddPetExp req = new AddPetExp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onAddPushItemInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AddPushItemInfo");
            Console.WriteLine("RpcCommand.AddPushItemInfo No Command");

        }

        internal static void onAdvancedEnchant(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AdvancedEnchant");
            AdvancedEnchant req = new AdvancedEnchant();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onAstrologyRpc(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AstrologyRpc");
            Console.WriteLine("RpcCommand.AstrologyRpc No Command");

        }

        internal static void onAstrologyRpcAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AstrologyRpcAck");
            AstrologyRpcAck req = new AstrologyRpcAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onAutoVechile(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.AutoVechile");
            Console.WriteLine("RpcCommand.AutoVechile No Command");

        }

        internal static void onBackwardBossRushLevel(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BackwardBossRushLevel");
            BackwardBossRushLevel req = new BackwardBossRushLevel();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onBagItemInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BagItemInfo");
            Console.WriteLine("RpcCommand.BagItemInfo No Command");

        }

        internal static void onBagItemPropInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BagItemPropInfo");
            Console.WriteLine("RpcCommand.BagItemPropInfo No Command");

        }

        internal static void onBatchBuyItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BatchBuyItem");
            BatchBuyItem req = new BatchBuyItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onBatchSellItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BatchSellItem");
            BatchSellItem req = new BatchSellItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onBeautician(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.Beautician");
            Beautician req = new Beautician();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onBellOperate(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BellOperate");
            BellOperate req = new BellOperate();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onBlessParty(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BlessParty");
            Console.WriteLine("RpcCommand.BlessParty No Command");

        }

        internal static void onBuyItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BuyItem");
            BuyItem req = new BuyItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onBuyMysticStoreItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BuyMysticStoreItem");
            Console.WriteLine("RpcCommand.BuyMysticStoreItem No Command");

        }

        internal static void onBuyMysticStoreItemAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BuyMysticStoreItemAck");
            BuyMysticStoreItemAck req = new BuyMysticStoreItemAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onBuyNewMysticBusinessItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BuyNewMysticBusinessItem");
            Console.WriteLine("RpcCommand.BuyNewMysticBusinessItem No Command");

        }

        internal static void onBuyNewMysticBusinessItemAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BuyNewMysticBusinessItemAck");
            BuyNewMysticBusinessItemAck req = new BuyNewMysticBusinessItemAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onBuyNewMysticStoreItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BuyNewMysticStoreItem");
            Console.WriteLine("RpcCommand.BuyNewMysticStoreItem No Command");

        }

        internal static void onBuyNewMysticStoreItemAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BuyNewMysticStoreItemAck");
            BuyNewMysticStoreItemAck req = new BuyNewMysticStoreItemAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onBuyPushItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.BuyPushItem");
            BuyPushItem req = new BuyPushItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onCanShowMysticBusiness(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CanShowMysticBusiness");
            CanShowMysticBusiness req = new CanShowMysticBusiness();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onCaressPet(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CaressPet");
            CaressPet req = new CaressPet();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onCatGardenOp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CatGardenOp");
            CatGardenOp req = new CatGardenOp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onChangeEquipment(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ChangeEquipment");
            ChangeEquipment req = new ChangeEquipment();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onChangeGenderReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ChangeGenderReq");
            ChangeGenderReq req = new ChangeGenderReq();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onChangeMountEquipment(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ChangeMountEquipment");
            Console.WriteLine("RpcCommand.ChangeMountEquipment No Command");

        }

        internal static void onChangePetName(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ChangePetName");
            ChangePetName req = new ChangePetName();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onChargeGiftMessge(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ChargeGiftMessge");
            ChargeGiftMessge req = new ChargeGiftMessge();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onChargeLifeCrystalReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ChargeLifeCrystalReq");
            Console.WriteLine("RpcCommand.ChargeLifeCrystalReq No Command");

        }

        internal static void onChargeLifeCrystalResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ChargeLifeCrystalResp");
            ChargeLifeCrystalResp req = new ChargeLifeCrystalResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onCheckNewMysticBusinessCanShow(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CheckNewMysticBusinessCanShow");
            Console.WriteLine("RpcCommand.CheckNewMysticBusinessCanShow No Command");

        }

        internal static void onCheckNewMysticBusinessItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CheckNewMysticBusinessItem");
            Console.WriteLine("RpcCommand.CheckNewMysticBusinessItem No Command");

        }

        internal static void onCheckNewMysticBusinessItemAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CheckNewMysticBusinessItemAck");
            CheckNewMysticBusinessItemAck req = new CheckNewMysticBusinessItemAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onCheckNewMysticBusinessItemInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CheckNewMysticBusinessItemInfo");
            Console.WriteLine("RpcCommand.CheckNewMysticBusinessItemInfo No Command");

        }

        internal static void onCheckNewMysticStoreItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CheckNewMysticStoreItem");
            Console.WriteLine("RpcCommand.CheckNewMysticStoreItem No Command");

        }

        internal static void onCheckNewMysticStoreItemAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CheckNewMysticStoreItemAck");
            CheckNewMysticStoreItemAck req = new CheckNewMysticStoreItemAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onCoMarketOpRpc(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.CoMarketOpRpc");
            CoMarketOpRpc req = new CoMarketOpRpc();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onConsume(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.Consume");
            Consume req = new Consume();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDailyRightsReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DailyRightsReq");
            Console.WriteLine("RpcCommand.DailyRightsReq No Command");

        }

        internal static void onDailyRightsResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DailyRightsResp");
            DailyRightsResp req = new DailyRightsResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDecomposeEquip(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DecomposeEquip");
            Console.WriteLine("RpcCommand.DecomposeEquip No Command");

        }

        internal static void onDesignationOp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DesignationOp");
            DesignationOp req = new DesignationOp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDiabetesMoveBox(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DiabetesMoveBox");
            DiabetesMoveBox req = new DiabetesMoveBox();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDiabetesOp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DiabetesOp");
            Console.WriteLine("RpcCommand.DiabetesOp No Command");

        }

        internal static void onDoActivityXchg(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DoActivityXchg");
            DoActivityXchg req = new DoActivityXchg();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDoDailyRefresh(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DoDailyRefresh");
            DoDailyRefresh req = new DoDailyRefresh();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDoFamilyWorship(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DoFamilyWorship");
            DoFamilyWorship req = new DoFamilyWorship();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDoItemTurnin(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DoItemTurnin");
            Console.WriteLine("RpcCommand.DoItemTurnin No Command");

        }

        internal static void onDoItemXchg(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DoItemXchg");
            DoItemXchg req = new DoItemXchg();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDoMagicDarts(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DoMagicDarts");
            DoMagicDarts req = new DoMagicDarts();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDoTurntableDraw(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DoTurntableDraw");
            DoTurntableDraw req = new DoTurntableDraw();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onDragonSoulOp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.DragonSoulOp");
            DragonSoulOp req = new DragonSoulOp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onEnchant(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.Enchant");
            Enchant req = new Enchant();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onEquipDegreeUp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.EquipDegreeUp");
            EquipDegreeUp req = new EquipDegreeUp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onEquipmentConvert(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.EquipmentConvert");
            EquipmentConvert req = new EquipmentConvert();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onEquipOnInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.EquipOnInfo");
            Console.WriteLine("RpcCommand.EquipOnInfo No Command");

        }

        internal static void onEquiponPreDisplay(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.EquiponPreDisplay");
            EquiponPreDisplay req = new EquiponPreDisplay();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onExplorationRpc(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ExplorationRpc");
            Console.WriteLine("RpcCommand.ExplorationRpc No Command");

        }

        internal static void onExplorationRpcAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ExplorationRpcAck");
            ExplorationRpcAck req = new ExplorationRpcAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onFeedPet(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.FeedPet");
            FeedPet req = new FeedPet();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onFestivalGiftInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.FestivalGiftInfo");
            FestivalGiftInfo req = new FestivalGiftInfo();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onFetchLevelGiftResult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.FetchLevelGiftResult");
            FetchLevelGiftResult req = new FetchLevelGiftResult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onFightBossRushCard(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.FightBossRushCard");
            Console.WriteLine("RpcCommand.FightBossRushCard No Command");

        }

        internal static void onFODisplay(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.FODisplay");
            FODisplay req = new FODisplay();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onForgeEquip(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ForgeEquip");
            ForgeEquip req = new ForgeEquip();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onForgeMountEquip(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ForgeMountEquip");
            ForgeMountEquip req = new ForgeMountEquip();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onForwardBossRushLevel(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ForwardBossRushLevel");
            ForwardBossRushLevel req = new ForwardBossRushLevel();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onFreePet(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.FreePet");
            FreePet req = new FreePet();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGainNewbieGift(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GainNewbieGift");
            GainNewbieGift req = new GainNewbieGift();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGatherGameObj(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GatherGameObj");
            GatherGameObj req = new GatherGameObj();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGatherStart(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GatherStart");
            GatherStart req = new GatherStart();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGatherStop(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GatherStop");
            Console.WriteLine("RpcCommand.GatherStop No Command");

        }

        internal static void onGemSocketRpc(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GemSocketRpc");
            GemSocketRpc req = new GemSocketRpc();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetActivityXchgCfg(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetActivityXchgCfg");
            GetActivityXchgCfg req = new GetActivityXchgCfg();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetActyItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetActyItem");
            Console.WriteLine("RpcCommand.GetActyItem No Command");

        }

        internal static void onGetActyItemResult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetActyItemResult");
            GetActyItemResult req = new GetActyItemResult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetActyRewdInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetActyRewdInfo");
            Console.WriteLine("RpcCommand.GetActyRewdInfo No Command");

        }

        internal static void onGetAllPushItemInfos(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetAllPushItemInfos");
            Console.WriteLine("RpcCommand.GetAllPushItemInfos No Command");

        }

        internal static void onGetBossRushAward(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetBossRushAward");
            Console.WriteLine("RpcCommand.GetBossRushAward No Command");

        }

        internal static void onGetBossRushDailyAward(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetBossRushDailyAward");
            Console.WriteLine("RpcCommand.GetBossRushDailyAward No Command");

        }

        internal static void onGetBossRushFinalAward(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetBossRushFinalAward");
            Console.WriteLine("RpcCommand.GetBossRushFinalAward No Command");

        }

        internal static void onGetBossRushInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetBossRushInfo");
            GetBossRushInfo req = new GetBossRushInfo();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetDailyPayReward(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetDailyPayReward");
            GetDailyPayReward req = new GetDailyPayReward();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetDiabetes(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetDiabetes");
            GetDiabetes req = new GetDiabetes();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetDropItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetDropItem");
            Console.WriteLine("RpcCommand.GetDropItem No Command");

        }

        internal static void onGetDropItems(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetDropItems");
            GetDropItems req = new GetDropItems();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetFamilyWorshipData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetFamilyWorshipData");
            GetFamilyWorshipData req = new GetFamilyWorshipData();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetFestival(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetFestival");
            Console.WriteLine("RpcCommand.GetFestival No Command");

        }

        internal static void onGetFestivalReult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetFestivalReult");
            GetFestivalReult req = new GetFestivalReult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetFixedPayActGift(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetFixedPayActGift");
            Console.WriteLine("RpcCommand.GetFixedPayActGift No Command");

        }

        internal static void onGetFixedPayActGiftAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetFixedPayActGiftAck");
            GetFixedPayActGiftAck req = new GetFixedPayActGiftAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetFixedPayActInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetFixedPayActInfo");
            Console.WriteLine("RpcCommand.GetFixedPayActInfo No Command");

        }

        internal static void onGetItemXchgCfg(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetItemXchgCfg");
            GetItemXchgCfg req = new GetItemXchgCfg();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetLevelGiftInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetLevelGiftInfo");
            Console.WriteLine("RpcCommand.GetLevelGiftInfo No Command");

        }

        internal static void onGetLimitItemRemain(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetLimitItemRemain");
            Console.WriteLine("RpcCommand.GetLimitItemRemain No Command");

        }

        internal static void onGetLimitItemRemainAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetLimitItemRemainAck");
            GetLimitItemRemainAck req = new GetLimitItemRemainAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetLoopQuestRewards(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetLoopQuestRewards");
            GetLoopQuestRewards req = new GetLoopQuestRewards();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetMagicDartsData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetMagicDartsData");
            GetMagicDartsData req = new GetMagicDartsData();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void ongetMagicsuitUpReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.getMagicsuitUpReq");
            Console.WriteLine("RpcCommand.getMagicsuitUpReq No Command");

        }

        internal static void ongetMagicsuitUpResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.getMagicsuitUpResp");
            getMagicsuitUpResp req = new getMagicsuitUpResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetMonthFeedbackGiftReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetMonthFeedbackGiftReq");
            Console.WriteLine("RpcCommand.GetMonthFeedbackGiftReq No Command");

        }

        internal static void onGetMonthFeedbackGiftResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetMonthFeedbackGiftResp");
            GetMonthFeedbackGiftResp req = new GetMonthFeedbackGiftResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetMonthFeedbackInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetMonthFeedbackInfo");
            Console.WriteLine("RpcCommand.GetMonthFeedbackInfo No Command");

        }

        internal static void onGetNewMysticBusinessItemList(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetNewMysticBusinessItemList");
            Console.WriteLine("RpcCommand.GetNewMysticBusinessItemList No Command");

        }

        internal static void onGetNewMysticBusinessItemListAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetNewMysticBusinessItemListAck");
            GetNewMysticBusinessItemListAck req = new GetNewMysticBusinessItemListAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetNewMysticStoreItemList(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetNewMysticStoreItemList");
            Console.WriteLine("RpcCommand.GetNewMysticStoreItemList No Command");

        }

        internal static void onGetOpenServerTime(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetOpenServerTime");
            GetOpenServerTime req = new GetOpenServerTime();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetPartyBlessingData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetPartyBlessingData");
            Console.WriteLine("RpcCommand.GetPartyBlessingData No Command");

        }

        internal static void onGetPartyBlessingReward(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetPartyBlessingReward");
            Console.WriteLine("RpcCommand.GetPartyBlessingReward No Command");

        }

        internal static void onGetServerTime(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetServerTime");
            GetServerTime req = new GetServerTime();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetServerTimeDebug(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetServerTimeDebug");
            GetServerTimeDebug req = new GetServerTimeDebug();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetSignInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetSignInfo");
            Console.WriteLine("RpcCommand.GetSignInfo No Command");

        }

        internal static void onGetSignItems(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetSignItems");
            Console.WriteLine("RpcCommand.GetSignItems No Command");

        }

        internal static void onGetSignItemsReult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetSignItemsReult");
            GetSignItemsReult req = new GetSignItemsReult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGetStoreItemList(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetStoreItemList");
            Console.WriteLine("RpcCommand.GetStoreItemList No Command");

        }

        internal static void onGetTurntableDrawData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GetTurntableDrawData");
            GetTurntableDrawData req = new GetTurntableDrawData();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGodshipOp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GodshipOp");
            GodshipOp req = new GodshipOp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGrowingFundOp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GrowingFundOp");
            GrowingFundOp req = new GrowingFundOp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGuidePickupSword(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GuidePickupSword");
            GuidePickupSword req = new GuidePickupSword();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onGuideSetXpFull(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.GuideSetXpFull");
            Console.WriteLine("RpcCommand.GuideSetXpFull No Command");

        }

        internal static void onInviteeEnterGame(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.InviteeEnterGame");
            InviteeEnterGame req = new InviteeEnterGame();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onIsNewMysticBusinessItemCanBuy(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.IsNewMysticBusinessItemCanBuy");
            Console.WriteLine("RpcCommand.IsNewMysticBusinessItemCanBuy No Command");

        }

        internal static void onIsNewMysticBusinessItemCanBuyAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.IsNewMysticBusinessItemCanBuyAck");
            IsNewMysticBusinessItemCanBuyAck req = new IsNewMysticBusinessItemCanBuyAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onIsNewMysticStoreCanPurchase(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.IsNewMysticStoreCanPurchase");
            Console.WriteLine("RpcCommand.IsNewMysticStoreCanPurchase No Command");

        }

        internal static void onIsNewMysticStoreCanPurchaseAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.IsNewMysticStoreCanPurchaseAck");
            IsNewMysticStoreCanPurchaseAck req = new IsNewMysticStoreCanPurchaseAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onIsNewMysticStoreFreeRefresh(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.IsNewMysticStoreFreeRefresh");
            Console.WriteLine("RpcCommand.IsNewMysticStoreFreeRefresh No Command");

        }

        internal static void onIsNewMysticStoreFreeRefreshAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.IsNewMysticStoreFreeRefreshAck");
            IsNewMysticStoreFreeRefreshAck req = new IsNewMysticStoreFreeRefreshAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onItemCell(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ItemCell");
            Console.WriteLine("RpcCommand.ItemCell No Command");

        }

        internal static void onItemXchgCfg(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ItemXchgCfg");
            Console.WriteLine("RpcCommand.ItemXchgCfg No Command");

        }

        internal static void onItemXchgItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ItemXchgItem");
            Console.WriteLine("RpcCommand.ItemXchgItem No Command");

        }

        internal static void onL2pwdAuth(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.L2pwdAuth");
            L2pwdAuth req = new L2pwdAuth();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onL2pwdRpc(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.L2pwdRpc");
            Console.WriteLine("RpcCommand.L2pwdRpc No Command");

        }

        internal static void onL2pwdUpdate(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.L2pwdUpdate");
            L2pwdUpdate req = new L2pwdUpdate();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onLearnPetSkill(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.LearnPetSkill");
            Console.WriteLine("RpcCommand.LearnPetSkill No Command");

        }

        internal static void onLearnPetSkillResult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.LearnPetSkillResult");
            LearnPetSkillResult req = new LearnPetSkillResult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onLevelBuyOp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.LevelBuyOp");
            LevelBuyOp req = new LevelBuyOp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onLevelGiftInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.LevelGiftInfo");
            LevelGiftInfo req = new LevelGiftInfo();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onLevelGiftUnit(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.LevelGiftUnit");
            Console.WriteLine("RpcCommand.LevelGiftUnit No Command");

        }

        internal static void onLevelupSendItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.LevelupSendItem");
            LevelupSendItem req = new LevelupSendItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onLimitItemInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.LimitItemInfo");
            Console.WriteLine("RpcCommand.LimitItemInfo No Command");

        }

        internal static void onMagicDartsCfg(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MagicDartsCfg");
            Console.WriteLine("RpcCommand.MagicDartsCfg No Command");

        }

        internal static void onMagicSuit(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MagicSuit");
            MagicSuit req = new MagicSuit();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onMagicSuitInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MagicSuitInfo");
            Console.WriteLine("RpcCommand.MagicSuitInfo No Command");

        }

        internal static void onMagicsuitUpRise(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MagicsuitUpRise");
            Console.WriteLine("RpcCommand.MagicsuitUpRise No Command");

        }

        internal static void onMagicsuitUpRiseAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MagicsuitUpRiseAck");
            MagicsuitUpRiseAck req = new MagicsuitUpRiseAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onMicroGiftReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MicroGiftReq");
            MicroGiftReq req = new MicroGiftReq();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onMicroGiftRet(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MicroGiftRet");
            MicroGiftRet req = new MicroGiftRet();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onMonthFeedbackData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MonthFeedbackData");
            MonthFeedbackData req = new MonthFeedbackData();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onMonthFeedbackGiftInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MonthFeedbackGiftInfo");
            MonthFeedbackGiftInfo req = new MonthFeedbackGiftInfo();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onMonthFeedbackGiftUnit(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MonthFeedbackGiftUnit");
            Console.WriteLine("RpcCommand.MonthFeedbackGiftUnit No Command");

        }

        internal static void onMountBless(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MountBless");
            MountBless req = new MountBless();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onMountCard(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MountCard");
            MountCard req = new MountCard();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onMountLevelUp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MountLevelUp");
            MountLevelUp req = new MountLevelUp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onMultiGift(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.MultiGift");
            MultiGift req = new MultiGift();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onNeedCharge(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.NeedCharge");
            NeedCharge req = new NeedCharge();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onNewMysticStoreCheckItemInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.NewMysticStoreCheckItemInfo");
            Console.WriteLine("RpcCommand.NewMysticStoreCheckItemInfo No Command");

        }

        internal static void onNewMysticStoreZeroReset(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.NewMysticStoreZeroReset");
            NewMysticStoreZeroReset req = new NewMysticStoreZeroReset();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onOffLine1V1Req(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.OffLine1V1Req");
            Console.WriteLine("RpcCommand.OffLine1V1Req No Command");

        }

        internal static void onOffLine1V1Resp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.OffLine1V1Resp");
            OffLine1V1Resp req = new OffLine1V1Resp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onOffLineItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.OffLineItem");
            Console.WriteLine("RpcCommand.OffLineItem No Command");

        }

        internal static void onOpenBossRushCard(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.OpenBossRushCard");
            OpenBossRushCard req = new OpenBossRushCard();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPayGift(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PayGift");
            PayGift req = new PayGift();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPersonReborn(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PersonReborn");
            Console.WriteLine("RpcCommand.PersonReborn No Command");

        }

        internal static void onPetBookUpdate(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PetBookUpdate");
            PetBookUpdate req = new PetBookUpdate();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPetImprove(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PetImprove");
            Console.WriteLine("RpcCommand.PetImprove No Command");

        }

        internal static void onPetImproveResult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PetImproveResult");
            PetImproveResult req = new PetImproveResult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPetInherit(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PetInherit");
            Console.WriteLine("RpcCommand.PetInherit No Command");

        }

        internal static void onPetInheritResult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PetInheritResult");
            PetInheritResult req = new PetInheritResult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPetLock(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PetLock");
            PetLock req = new PetLock();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPetSpriteReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PetSpriteReq");
            Console.WriteLine("RpcCommand.PetSpriteReq No Command");

        }

        internal static void onPetSpriteRsp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PetSpriteRsp");
            PetSpriteRsp req = new PetSpriteRsp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPickupDropItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PickupDropItem");
            PickupDropItem req = new PickupDropItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPiggyBankRequest(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PiggyBankRequest");
            PiggyBankRequest req = new PiggyBankRequest();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPlatStateReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PlatStateReq");
            Console.WriteLine("RpcCommand.PlatStateReq No Command");

        }

        internal static void onPlatStateResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PlatStateResp");
            PlatStateResp req = new PlatStateResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onProfessionTransfer(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ProfessionTransfer");
            ProfessionTransfer req = new ProfessionTransfer();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onProfessionTransferAgain(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ProfessionTransferAgain");
            ProfessionTransferAgain req = new ProfessionTransferAgain();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onPushGift(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PushGift");
            Console.WriteLine("RpcCommand.PushGift No Command");

        }

        internal static void onPushItemInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.PushItemInfo");
            PushItemInfo req = new PushItemInfo();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onQQFriendRecallReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.QQFriendRecallReq");
            Console.WriteLine("RpcCommand.QQFriendRecallReq No Command");

        }

        internal static void onQueryDailyGift(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.QueryDailyGift");
            Console.WriteLine("RpcCommand.QueryDailyGift No Command");

        }

        internal static void onQueryDailyGiftReult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.QueryDailyGiftReult");
            QueryDailyGiftReult req = new QueryDailyGiftReult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onQueryInviteGift(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.QueryInviteGift");
            QueryInviteGift req = new QueryInviteGift();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onQueryInviteGiftReult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.QueryInviteGiftReult");
            QueryInviteGiftReult req = new QueryInviteGiftReult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onQueryItemsResult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.QueryItemsResult");
            QueryItemsResult req = new QueryItemsResult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onQuestRpc(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.QuestRpc");
            Console.WriteLine("RpcCommand.QuestRpc No Command");

        }

        internal static void onQuestRpcAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.QuestRpcAck");
            QuestRpcAck req = new QuestRpcAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onRefine(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.Refine");
            Refine req = new Refine();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onRefineTransfer(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.RefineTransfer");
            RefineTransfer req = new RefineTransfer();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onRefreshMysticStore(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.RefreshMysticStore");
            Console.WriteLine("RpcCommand.RefreshMysticStore No Command");

        }

        internal static void onRefreshMysticStoreAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.RefreshMysticStoreAck");
            RefreshMysticStoreAck req = new RefreshMysticStoreAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onRefreshNewMysticBusinessItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.RefreshNewMysticBusinessItem");
            Console.WriteLine("RpcCommand.RefreshNewMysticBusinessItem No Command");

        }

        internal static void onRefreshNewMysticBusinessItemAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.RefreshNewMysticBusinessItemAck");
            RefreshNewMysticBusinessItemAck req = new RefreshNewMysticBusinessItemAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onRefreshNewMysticStoreItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.RefreshNewMysticStoreItem");
            Console.WriteLine("RpcCommand.RefreshNewMysticStoreItem No Command");

        }

        internal static void onRefreshNewMysticStoreItemAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.RefreshNewMysticStoreItemAck");
            RefreshNewMysticStoreItemAck req = new RefreshNewMysticStoreItemAck();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onRegain(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.Regain");
            Regain req = new Regain();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onRegainChange(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.RegainChange");
            RegainChange req = new RegainChange();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onResetBossRushCard(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ResetBossRushCard");
            ResetBossRushCard req = new ResetBossRushCard();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onRpc(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.Rpc");
            Console.WriteLine("RpcCommand.Rpc No Command");

        }

        internal static void onRpcAck(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.RpcAck");
            Console.WriteLine("RpcCommand.RpcAck No Command");

        }

        internal static void onRun(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.Run");
            Console.WriteLine("RpcCommand.Run No Command");

        }

        internal static void onSaveEnchantProps(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SaveEnchantProps");
            SaveEnchantProps req = new SaveEnchantProps();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSellItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SellItem");
            SellItem req = new SellItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSetChatBubbleType(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SetChatBubbleType");
            Console.WriteLine("RpcCommand.SetChatBubbleType No Command");

        }

        internal static void onSetDailyInviteGift(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SetDailyInviteGift");
            Console.WriteLine("RpcCommand.SetDailyInviteGift No Command");

        }

        internal static void onSetDailyInviteGiftResult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SetDailyInviteGiftResult");
            SetDailyInviteGiftResult req = new SetDailyInviteGiftResult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSetHpHealThreshold(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SetHpHealThreshold");
            Console.WriteLine("RpcCommand.SetHpHealThreshold No Command");

        }

        internal static void onSetMpHealThreshold(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SetMpHealThreshold");
            Console.WriteLine("RpcCommand.SetMpHealThreshold No Command");

        }

        internal static void onSetPartyBlessingData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SetPartyBlessingData");
            SetPartyBlessingData req = new SetPartyBlessingData();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSetPetSlotNum(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SetPetSlotNum");
            SetPetSlotNum req = new SetPetSlotNum();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onShareStory(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ShareStory");
            ShareStory req = new ShareStory();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onShopBuyItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ShopBuyItem");
            ShopBuyItem req = new ShopBuyItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSignConuConfig(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SignConuConfig");
            SignConuConfig req = new SignConuConfig();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSignIn(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SignIn");
            Console.WriteLine("RpcCommand.SignIn No Command");

        }

        internal static void onSignInResult(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SignInResult");
            SignInResult req = new SignInResult();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSignTotConfig(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SignTotConfig");
            SignTotConfig req = new SignTotConfig();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSignUnit(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SignUnit");
            Console.WriteLine("RpcCommand.SignUnit No Command");

        }

        internal static void onSignUserData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SignUserData");
            SignUserData req = new SignUserData();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSortBag(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SortBag");
            SortBag req = new SortBag();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSortStore(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SortStore");
            SortStore req = new SortStore();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onSplitItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.SplitItem");
            SplitItem req = new SplitItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onStoreItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.StoreItem");
            StoreItem req = new StoreItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onStoreMoney(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.StoreMoney");
            StoreMoney req = new StoreMoney();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onTencentVipReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.TencentVipReq");
            Console.WriteLine("RpcCommand.TencentVipReq No Command");

        }

        internal static void onTencentVipResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.TencentVipResp");
            TencentVipResp req = new TencentVipResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onThrownItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.ThrownItem");
            ThrownItem req = new ThrownItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onTowerBuyItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.TowerBuyItem");
            TowerBuyItem req = new TowerBuyItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onTransferEnchantProps(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.TransferEnchantProps");
            TransferEnchantProps req = new TransferEnchantProps();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onTransferLoverReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.TransferLoverReq");
            Console.WriteLine("RpcCommand.TransferLoverReq No Command");

        }

        internal static void onTransport(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.Transport");
            Transport req = new Transport();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onTriggerDailyPay(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.TriggerDailyPay");
            Console.WriteLine("RpcCommand.TriggerDailyPay No Command");

        }

        internal static void onTryDailyRefresh(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.TryDailyRefresh");
            Console.WriteLine("RpcCommand.TryDailyRefresh No Command");

        }

        internal static void onTurntableDrawCfg(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.TurntableDrawCfg");
            Console.WriteLine("RpcCommand.TurntableDrawCfg No Command");

        }

        internal static void onUnlock(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.Unlock");
            Unlock req = new Unlock();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateActivityDgnTimes(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateActivityDgnTimes");
            UpdateActivityDgnTimes req = new UpdateActivityDgnTimes();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateBagItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateBagItem");
            UpdateBagItem req = new UpdateBagItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateBagItemProp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateBagItemProp");
            UpdateBagItemProp req = new UpdateBagItemProp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateBagSlotNum(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateBagSlotNum");
            UpdateBagSlotNum req = new UpdateBagSlotNum();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateBindCrystal(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateBindCrystal");
            UpdateBindCrystal req = new UpdateBindCrystal();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateContinuousLogin(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateContinuousLogin");
            UpdateContinuousLogin req = new UpdateContinuousLogin();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateCryStal(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateCryStal");
            UpdateCryStal req = new UpdateCryStal();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateDailyPayData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateDailyPayData");
            UpdateDailyPayData req = new UpdateDailyPayData();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateEquipOn(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateEquipOn");
            UpdateEquipOn req = new UpdateEquipOn();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateFamilyContri(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateFamilyContri");
            UpdateFamilyContri req = new UpdateFamilyContri();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateHonorPoints(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateHonorPoints");
            UpdateHonorPoints req = new UpdateHonorPoints();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateMachinariumDgnTimes(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateMachinariumDgnTimes");
            UpdateMachinariumDgnTimes req = new UpdateMachinariumDgnTimes();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateManorBonus(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateManorBonus");
            UpdateManorBonus req = new UpdateManorBonus();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateMoney(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateMoney");
            UpdateMoney req = new UpdateMoney();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateMountEquipOn(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateMountEquipOn");
            UpdateMountEquipOn req = new UpdateMountEquipOn();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateMultiDgnTimes(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateMultiDgnTimes");
            UpdateMultiDgnTimes req = new UpdateMultiDgnTimes();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onupdateNewbieLoginNum(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.updateNewbieLoginNum");
            updateNewbieLoginNum req = new updateNewbieLoginNum();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdatePetCombatPower(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdatePetCombatPower");
            UpdatePetCombatPower req = new UpdatePetCombatPower();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdatePriesthoodBonus(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdatePriesthoodBonus");
            UpdatePriesthoodBonus req = new UpdatePriesthoodBonus();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateQuartz(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateQuartz");
            UpdateQuartz req = new UpdateQuartz();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateQuestCtrl(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateQuestCtrl");
            UpdateQuestCtrl req = new UpdateQuestCtrl();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateQuestData(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateQuestData");
            UpdateQuestData req = new UpdateQuestData();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateQuestObjNum(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateQuestObjNum");
            UpdateQuestObjNum req = new UpdateQuestObjNum();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateSeabedBonus(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateSeabedBonus");
            UpdateSeabedBonus req = new UpdateSeabedBonus();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateThreeDiabetesBonus(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateThreeDiabetesBonus");
            UpdateThreeDiabetesBonus req = new UpdateThreeDiabetesBonus();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpdateVitaRecTime(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpdateVitaRecTime");
            UpdateVitaRecTime req = new UpdateVitaRecTime();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUpFixedPayActInfo(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UpFixedPayActInfo");
            UpFixedPayActInfo req = new UpFixedPayActInfo();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUseItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UseItem");
            UseItem req = new UseItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUseNpc(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UseNpc");
            UseNpc req = new UseNpc();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onUsePillReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UsePillReq");
            Console.WriteLine("RpcCommand.UsePillReq No Command");

        }

        internal static void onUsePillResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.UsePillResp");
            UsePillResp req = new UsePillResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onVipExtraReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.VipExtraReq");
            Console.WriteLine("RpcCommand.VipExtraReq No Command");

        }

        internal static void onVipExtraResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.VipExtraResp");
            VipExtraResp req = new VipExtraResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onVitaRec(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.VitaRec");
            VitaRec req = new VitaRec();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onWingCardAdd(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.WingCardAdd");
            WingCardAdd req = new WingCardAdd();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onWingCardGetList(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.WingCardGetList");
            WingCardGetList req = new WingCardGetList();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onWingDisplay(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.WingDisplay");
            WingDisplay req = new WingDisplay();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onWingEquipOn(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.WingEquipOn");
            WingEquipOn req = new WingEquipOn();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onWingLevelUpReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.WingLevelUpReq");
            WingLevelUpReq req = new WingLevelUpReq();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onWingLevelUpResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.WingLevelUpResp");
            WingLevelUpResp req = new WingLevelUpResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onXchgTurntableDrawItem(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.XchgTurntableDrawItem");
            XchgTurntableDrawItem req = new XchgTurntableDrawItem();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }

        internal static void onXOCashUpReq(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.XOCashUpReq");
            Console.WriteLine("RpcCommand.XOCashUpReq No Command");

        }

        internal static void onXOCashUpResp(ref ConnectionInfo c, ref Rpc inmsg, ref RpcAck outmsg)
        {

            Console.WriteLine("RpcCommand.XOCashUpResp");
            XOCashUpResp req = new XOCashUpResp();
            ByteTool.LoadProto(inmsg.message, ref req);
            inmsg = null;



            outmsg.message = ByteTool.GetProto(ref req);
            req = null;

        }


    }

}
