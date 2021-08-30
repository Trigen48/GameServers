				case MessageConsts.GetZoneListID:
					LoginZoneMessageListener.GetZoneListID(c);
					break;

				case MessageConsts.EnterZoneRequestID:
					LoginZoneMessageListener.EnterZoneRequestID(c);
					break;

				case MessageConsts.LoginPhaseID:
					ChooseCharStage.LoginPhaseID(c);
					break;

				case MessageConsts.EnableCharRequestID:
					ChooseCharStage.EnableCharRequestID(c);
					break;

				case MessageConsts.DisableCharRequestID:
					ChooseCharStage.DisableCharRequestID(c);
					break;

				case MessageConsts.CreateCharRequestID:
					CreateCharStage.CreateCharRequestID(c);
					break;

				case MessageConsts.LoadingDurationsID:
					Fun.LoadingDurationsID(c);
					break;

				case MessageConsts.GetTowerInfoReqID:
					Fun.GetTowerInfoReqID(c);
					break;

				case MessageConsts.CurrentInActivityRespID:
					Fun.CurrentInActivityRespID(c);
					break;

				case MessageConsts.AntiCheatReportID:
					Scenario.AntiCheatReportID(c);
					break;

				case MessageConsts.TGWHeartbeatID:
					Scenario.TGWHeartbeatID(c);
					break;

				case MessageConsts.BellInfoRequestID:
					BellCtrl.BellInfoRequestID(c);
					break;

				case MessageConsts.RankListRequestID:
					ConsumeRankCtrl.RankListRequestID(c);
					break;

				case MessageConsts.DartLogReqID:
					MagicDartsCtrl.DartLogReqID(c);
					break;

				case MessageConsts.GetLimitItemRemainReqID:
					NewYearGiftCtrl.GetLimitItemRemainReqID(c);
					break;

				case MessageConsts.BuyLimitItemRequestID:
					NewYearGiftCtrl.BuyLimitItemRequestID(c);
					break;

				case MessageConsts.FmyActGetInfoReqID:
					ChristmasTreeCtrl.FmyActGetInfoReqID(c);
					break;

				case MessageConsts.FmyActBuyTicketReqID:
					ChristmasTreeCtrl.FmyActBuyTicketReqID(c);
					break;

				case MessageConsts.FmyActBuyHeatReqID:
					ChristmasTreeCtrl.FmyActBuyHeatReqID(c);
					break;

				case MessageConsts.ChatID:
					ChatManager.ChatID(c);
					break;

				case MessageConsts.VechileSyncActionID:
					GameConsole.VechileSyncActionID(c);
					break;

				case MessageConsts.DeliveryInfoReqID:
					DeliveryCtrl.DeliveryInfoReqID(c);
					break;

				case MessageConsts.RefreshCarReqID:
					DeliveryCtrl.RefreshCarReqID(c);
					break;

				case MessageConsts.StartDeliveryID:
					DeliveryCtrl.StartDeliveryID(c);
					break;

				case MessageConsts.GetDeliveryRewardReqID:
					DeliveryCtrl.GetDeliveryRewardReqID(c);
					break;

				case MessageConsts.RobCarReqID:
					DeliveryCtrl.RobCarReqID(c);
					break;

				case MessageConsts.RobCarSelectID:
					DeliveryCtrl.RobCarSelectID(c);
					break;

				case MessageConsts.EnterDungeonID:
					DragonSoulManager.EnterDungeonID(c);
					break;

				case MessageConsts.FamilyWorshipMemberListReqID:
					FamilyWorshipCtrl.FamilyWorshipMemberListReqID(c);
					break;

				case MessageConsts.OnlineAFKRequestID:
					AFKCtrl.OnlineAFKRequestID(c);
					break;

				case MessageConsts.GetOfflineAFKAwardID:
					AFKCtrl.GetOfflineAFKAwardID(c);
					break;

				case MessageConsts.FunctionOpenNotifyID:
					AFKCtrl.FunctionOpenNotifyID(c);
					break;

				case MessageConsts.LeadSetMarkMessageRequestID:
					LeadManager.LeadSetMarkMessageRequestID(c);
					break;

				case MessageConsts.GetCommodityInfoReqID:
					MallCommon.GetCommodityInfoReqID(c);
					break;

				case MessageConsts.BuyCommodityItemRequestID:
					MallCommon.BuyCommodityItemRequestID(c);
					break;

				case MessageConsts.GotoDungeonEntryID:
					TransportManager.GotoDungeonEntryID(c);
					break;

				case MessageConsts.MentorGetLogsReqID:
					MentorCtrl.MentorGetLogsReqID(c);
					break;

				case MessageConsts.MentorGetInfoReqID:
					MentorCtrl.MentorGetInfoReqID(c);
					break;

				case MessageConsts.MentorGetListReqID:
					MentorCtrl.MentorGetListReqID(c);
					break;

				case MessageConsts.MentorApplyReqID:
					MentorCtrl.MentorApplyReqID(c);
					break;

				case MessageConsts.MentorAcceptReqID:
					MentorCtrl.MentorAcceptReqID(c);
					break;

				case MessageConsts.MentorQuitReqID:
					MentorCtrl.MentorQuitReqID(c);
					break;

				case MessageConsts.MentorFireReqID:
					MentorCtrl.MentorFireReqID(c);
					break;

				case MessageConsts.MentorGuideReqID:
					MentorCtrl.MentorGuideReqID(c);
					break;

				case MessageConsts.MentorReportReqID:
					MentorCtrl.MentorReportReqID(c);
					break;

				case MessageConsts.MentorObtainReqID:
					MentorCtrl.MentorObtainReqID(c);
					break;

				case MessageConsts.MentorModifyTextReqID:
					MentorCtrl.MentorModifyTextReqID(c);
					break;

				case MessageConsts.GetTimeLimitDgnListReqID:
					DungeonMessageListener.GetTimeLimitDgnListReqID(c);
					break;

				case MessageConsts.GetGroupInfoReqID:
					GroupMessageListener.GetGroupInfoReqID(c);
					break;

				case MessageConsts.HeartbeatID:
					SceneMessageListener.HeartbeatID(c);
					break;

				case MessageConsts.LogoutAckID:
					SystemMessageListener.LogoutAckID(c);
					break;

				case MessageConsts.GetMopupConsumeInfoReqID:
					DungeonLootCtrl.GetMopupConsumeInfoReqID(c);
					break;

				case MessageConsts.StartBatchMopupReqID:
					DungeonLootCtrl.StartBatchMopupReqID(c);
					break;

				case MessageConsts.AccelerateMopupID:
					DungeonLootCtrl.AccelerateMopupID(c);
					break;

				case MessageConsts.CancelMopupID:
					DungeonLootCtrl.CancelMopupID(c);
					break;

				case MessageConsts.SyncActionID:
					PacketSender.SyncActionID(c);
					break;

				case MessageConsts.SyncPetActionID:
					PacketSender.SyncPetActionID(c);
					break;

				case MessageConsts.SkillStartID:
					PacketSender.SkillStartID(c);
					break;

				case MessageConsts.OperateReactorID:
					PacketSender.OperateReactorID(c);
					break;

				case MessageConsts.ChangeSceneRequestID:
					PacketSender.ChangeSceneRequestID(c);
					break;

				case MessageConsts.TeleportRequestID:
					PacketSender.TeleportRequestID(c);
					break;

				case MessageConsts.ChangeSceneAckID:
					PacketSender.ChangeSceneAckID(c);
					break;

				case MessageConsts.EnterZoneAckID:
					PacketSender.EnterZoneAckID(c);
					break;

				case MessageConsts.SwitchZoneRequestID:
					PacketSender.SwitchZoneRequestID(c);
					break;

				case MessageConsts.PetJoinBattleRequestID:
					PacketSender.PetJoinBattleRequestID(c);
					break;

				case MessageConsts.PetDismissRequestID:
					PacketSender.PetDismissRequestID(c);
					break;

				case MessageConsts.PetRespawnRequestID:
					PacketSender.PetRespawnRequestID(c);
					break;

				case MessageConsts.PetListRequestID:
					PacketSender.PetListRequestID(c);
					break;

				case MessageConsts.ValidateCharNameRequestID:
					PacketSender.ValidateCharNameRequestID(c);
					break;

				case MessageConsts.GetNpcVisibleID:
					NpcManager.GetNpcVisibleID(c);
					break;

				case MessageConsts.TransferProfessionID:
					NpcManager.TransferProfessionID(c);
					break;

				case MessageConsts.GetOneTouchBodyEventID:
					NpcManager.GetOneTouchBodyEventID(c);
					break;

				case MessageConsts.GetOneTouchBodyInFieldEventID:
					NpcManager.GetOneTouchBodyInFieldEventID(c);
					break;

				case MessageConsts.GetLuckyDrawDataReqID:
					LuckyDrawCtrl.GetLuckyDrawDataReqID(c);
					break;

				case MessageConsts.LuckyDrawReqID:
					LuckyDrawCtrl.LuckyDrawReqID(c);
					break;

				case MessageConsts.LuckyDrawGetAwardReqID:
					LuckyDrawCtrl.LuckyDrawGetAwardReqID(c);
					break;

				case MessageConsts.PetBookRequestID:
					PetBookCtrl.PetBookRequestID(c);
					break;

				case MessageConsts.AttachSpritePetID:
					PetCtrl.AttachSpritePetID(c);
					break;

				case MessageConsts.RemoveSpritePetID:
					PetCtrl.RemoveSpritePetID(c);
					break;

				case MessageConsts.SetPetHpHealThresholdID:
					PetCtrl.SetPetHpHealThresholdID(c);
					break;

				case MessageConsts.SetPetFullHealID:
					PetCtrl.SetPetFullHealID(c);
					break;

				case MessageConsts.UpgradeSkillID:
					Skill.UpgradeSkillID(c);
					break;

				case MessageConsts.SetStoryMobPosID:
					MoveMobAction.SetStoryMobPosID(c);
					break;

				case MessageConsts.HideStoryObjectID:
					PickupSwordAction.HideStoryObjectID(c);
					break;

				case MessageConsts.ShowStoryObjectID:
					ShowObjectAction.ShowStoryObjectID(c);
					break;

				case MessageConsts.SetStoryProgressActionID:
					StoryAction.SetStoryProgressActionID(c);
					break;

				case MessageConsts.TimeSyncRequestID:
					GameClock.TimeSyncRequestID(c);
					break;

				case MessageConsts.CdKeyOpID:
					ActivityController.CdKeyOpID(c);
					break;

				case MessageConsts.LeaveArenaHallID:
					ArenaController.LeaveArenaHallID(c);
					break;

				case MessageConsts.EnterArenaHallID:
					ArenaController.EnterArenaHallID(c);
					break;

				case MessageConsts.ArenaRankListRequestID:
					ArenaController.ArenaRankListRequestID(c);
					break;

				case MessageConsts.ArenaTeamOperateID:
					ArenaController.ArenaTeamOperateID(c);
					break;

				case MessageConsts.GroupMemberJoinArenaResponseID:
					ArenaController.GroupMemberJoinArenaResponseID(c);
					break;

				case MessageConsts.CleanArenaDefeatsRequestID:
					ArenaController.CleanArenaDefeatsRequestID(c);
					break;

				case MessageConsts.GetChargeBonusInfoReqID:
					BonousXchgCtrl.GetChargeBonusInfoReqID(c);
					break;

				case MessageConsts.GetConsumeBonusInfoReqID:
					BonousXchgCtrl.GetConsumeBonusInfoReqID(c);
					break;

				case MessageConsts.RebornInBossRushDgnReqID:
					BossRushController.RebornInBossRushDgnReqID(c);
					break;

				case MessageConsts.GetChargeRewardReqID:
					ChargeBonusCtrl.GetChargeRewardReqID(c);
					break;

				case MessageConsts.GetChargeDragonReqID:
					ChargeDragonCtrl.GetChargeDragonReqID(c);
					break;

				case MessageConsts.GetMergeChargeReqID:
					ChargePresentWindowCtrl.GetMergeChargeReqID(c);
					break;

				case MessageConsts.GetMultiChargeRewardReqID:
					ChargePresentWindowCtrl.GetMultiChargeRewardReqID(c);
					break;

				case MessageConsts.UpdatePreferencesRequestID:
					ChatController.UpdatePreferencesRequestID(c);
					break;

				case MessageConsts.CoMarketOpID:
					CoMarketCtrl.CoMarketOpID(c);
					break;

				case MessageConsts.GetActivityPayInfoResID:
					ConsumeStageCtrl.GetActivityPayInfoResID(c);
					break;

				case MessageConsts.GetActivityPayGiftResID:
					ConsumeStageCtrl.GetActivityPayGiftResID(c);
					break;

				case MessageConsts.SetAutoPlayInfoID:
					DailyMustCtrl.SetAutoPlayInfoID(c);
					break;

				case MessageConsts.ClearAutoPlayInfoID:
					DailyMustCtrl.ClearAutoPlayInfoID(c);
					break;

				case MessageConsts.GetAutoPlayInfoReqID:
					DailyMustCtrl.GetAutoPlayInfoReqID(c);
					break;

				case MessageConsts.GetActivityStatusReqID:
					DailyMustCtrl.GetActivityStatusReqID(c);
					break;

				case MessageConsts.GetTowerMopInfoReqID:
					DailyMustCtrl.GetTowerMopInfoReqID(c);
					break;

				case MessageConsts.Fight1v1ReqID:
					DuelCtrl.Fight1v1ReqID(c);
					break;

				case MessageConsts.Fight1v1AckID:
					DuelCtrl.Fight1v1AckID(c);
					break;

				case MessageConsts.KillerModeReqID:
					DuelCtrl.KillerModeReqID(c);
					break;

				case MessageConsts.GetDgnInfoOfAreaMapReqID:
					DungeonController.GetDgnInfoOfAreaMapReqID(c);
					break;

				case MessageConsts.GetCharEnergyID:
					DungeonController.GetCharEnergyID(c);
					break;

				case MessageConsts.AddCharEnergyID:
					DungeonController.AddCharEnergyID(c);
					break;

				case MessageConsts.GetDungeonEnergyUsedID:
					DungeonController.GetDungeonEnergyUsedID(c);
					break;

				case MessageConsts.GetDngAreaPassAwardReqID:
					DungeonController.GetDngAreaPassAwardReqID(c);
					break;

				case MessageConsts.NotifyStoryFinishID:
					DungeonController.NotifyStoryFinishID(c);
					break;

				case MessageConsts.HaveExistedDungeonID:
					DungeonController.HaveExistedDungeonID(c);
					break;

				case MessageConsts.GetTimeLimitDgnAwardReqID:
					DungeonController.GetTimeLimitDgnAwardReqID(c);
					break;

				case MessageConsts.DgnCureID:
					DungeonController.DgnCureID(c);
					break;

				case MessageConsts.ChooseDungeonCardID:
					DungeonController.ChooseDungeonCardID(c);
					break;

				case MessageConsts.UpdateCheckPointID:
					DungeonController.UpdateCheckPointID(c);
					break;

				case MessageConsts.HitTransportAreaID:
					DungeonController.HitTransportAreaID(c);
					break;

				case MessageConsts.SeabedOpID:
					DungeonController.SeabedOpID(c);
					break;

				case MessageConsts.LeaveDungeonID:
					DungeonController.LeaveDungeonID(c);
					break;

				case MessageConsts.AddToGrpDgnQueueReqID:
					DungeonController.AddToGrpDgnQueueReqID(c);
					break;

				case MessageConsts.LeaveGrpDgnQueueReqID:
					DungeonController.LeaveGrpDgnQueueReqID(c);
					break;

				case MessageConsts.GetGrpDgnQueueInfoReqID:
					DungeonController.GetGrpDgnQueueInfoReqID(c);
					break;

				case MessageConsts.QueryDgnActiveInfoReqID:
					DungeonController.QueryDgnActiveInfoReqID(c);
					break;

				case MessageConsts.GrpDgnPrepareConfirmAckID:
					DungeonController.GrpDgnPrepareConfirmAckID(c);
					break;

				case MessageConsts.GrpDgnApplyConfirmAckID:
					DungeonController.GrpDgnApplyConfirmAckID(c);
					break;

				case MessageConsts.AddActivityTicketReqID:
					DungeonController.AddActivityTicketReqID(c);
					break;

				case MessageConsts.QuickAddToGrpDgnReqID:
					DungeonController.QuickAddToGrpDgnReqID(c);
					break;

				case MessageConsts.GetFamilyIDID:
					FamilyController.GetFamilyIDID(c);
					break;

				case MessageConsts.GetFamilyNameID:
					FamilyController.GetFamilyNameID(c);
					break;

				case MessageConsts.GetFamilyBriefID:
					FamilyController.GetFamilyBriefID(c);
					break;

				case MessageConsts.GetFamilyMembersID:
					FamilyController.GetFamilyMembersID(c);
					break;

				case MessageConsts.GetFamilyRankListID:
					FamilyController.GetFamilyRankListID(c);
					break;

				case MessageConsts.GetFamilyNewsID:
					FamilyController.GetFamilyNewsID(c);
					break;

				case MessageConsts.GetFamilyApplicantsID:
					FamilyController.GetFamilyApplicantsID(c);
					break;

				case MessageConsts.GetFamilyApplyRecordID:
					FamilyController.GetFamilyApplyRecordID(c);
					break;

				case MessageConsts.GetFamilyLogsID:
					FamilyController.GetFamilyLogsID(c);
					break;

				case MessageConsts.DonateMoneyToFamilyReqID:
					FamilyController.DonateMoneyToFamilyReqID(c);
					break;

				case MessageConsts.DonateCrystalToFamilyReqID:
					FamilyController.DonateCrystalToFamilyReqID(c);
					break;

				case MessageConsts.ClearFamilyUpgradeCDReqID:
					FamilyController.ClearFamilyUpgradeCDReqID(c);
					break;

				case MessageConsts.GetFamilyPetInfoReqID:
					FamilyController.GetFamilyPetInfoReqID(c);
					break;

				case MessageConsts.UpgradeFamilyLevelReqID:
					FamilyController.UpgradeFamilyLevelReqID(c);
					break;

				case MessageConsts.UpgradeFmlySkillLvlReqID:
					FamilyController.UpgradeFmlySkillLvlReqID(c);
					break;

				case MessageConsts.UpgradeFmlyShopLvlReqID:
					FamilyController.UpgradeFmlyShopLvlReqID(c);
					break;

				case MessageConsts.ChangeFamilyPetNameReqID:
					FamilyController.ChangeFamilyPetNameReqID(c);
					break;

				case MessageConsts.FeedFamilyPetReqID:
					FamilyController.FeedFamilyPetReqID(c);
					break;

				case MessageConsts.UpgradeFamilySkillID:
					FamilyController.UpgradeFamilySkillID(c);
					break;

				case MessageConsts.GetFamilyPetDgnHistoryReqID:
					FamilyController.GetFamilyPetDgnHistoryReqID(c);
					break;

				case MessageConsts.GetFamilyListID:
					FamilyController.GetFamilyListID(c);
					break;

				case MessageConsts.InviteToFamilyAckID:
					FamilyController.InviteToFamilyAckID(c);
					break;

				case MessageConsts.CreateFamilyReqID:
					FamilyController.CreateFamilyReqID(c);
					break;

				case MessageConsts.CheckFamilyNameID:
					FamilyController.CheckFamilyNameID(c);
					break;

				case MessageConsts.JoinFamilyReqID:
					FamilyController.JoinFamilyReqID(c);
					break;

				case MessageConsts.CancelFamilyApplyID:
					FamilyController.CancelFamilyApplyID(c);
					break;

				case MessageConsts.JoinFamilyAckID:
					FamilyController.JoinFamilyAckID(c);
					break;

				case MessageConsts.DestroyFamilyReqID:
					FamilyController.DestroyFamilyReqID(c);
					break;

				case MessageConsts.ModifyFamilyInfoID:
					FamilyController.ModifyFamilyInfoID(c);
					break;

				case MessageConsts.ModifyFamilyNoticeID:
					FamilyController.ModifyFamilyNoticeID(c);
					break;

				case MessageConsts.LeaveFamilyID:
					FamilyController.LeaveFamilyID(c);
					break;

				case MessageConsts.HandoverFamilyID:
					FamilyController.HandoverFamilyID(c);
					break;

				case MessageConsts.ApplyForFamilyLeaderID:
					FamilyController.ApplyForFamilyLeaderID(c);
					break;

				case MessageConsts.DenyApplyForFamilyLeaderID:
					FamilyController.DenyApplyForFamilyLeaderID(c);
					break;

				case MessageConsts.KickFamilyMemberID:
					FamilyController.KickFamilyMemberID(c);
					break;

				case MessageConsts.PromoteFamilyEldersID:
					FamilyController.PromoteFamilyEldersID(c);
					break;

				case MessageConsts.DemoteFamilyEldersID:
					FamilyController.DemoteFamilyEldersID(c);
					break;

				case MessageConsts.AllowFamilyTalkID:
					FamilyController.AllowFamilyTalkID(c);
					break;

				case MessageConsts.ForbidFamilyTalkID:
					FamilyController.ForbidFamilyTalkID(c);
					break;

				case MessageConsts.InviteToFamilyReqID:
					FamilyController.InviteToFamilyReqID(c);
					break;

				case MessageConsts.EnterFamilyPetDgnReqID:
					FamilyController.EnterFamilyPetDgnReqID(c);
					break;

				case MessageConsts.EnterFamilyBaseDgnID:
					FamilyController.EnterFamilyBaseDgnID(c);
					break;

				case MessageConsts.ScheduleFamilyPetDgnReqID:
					FamilyController.ScheduleFamilyPetDgnReqID(c);
					break;

				case MessageConsts.FamilyManorEnterReqID:
					FamilyManorCtrl.FamilyManorEnterReqID(c);
					break;

				case MessageConsts.GetFamilyManorInfoReqID:
					FamilyManorCtrl.GetFamilyManorInfoReqID(c);
					break;

				case MessageConsts.GetFamilyManorDailyReqID:
					FamilyManorCtrl.GetFamilyManorDailyReqID(c);
					break;

				case MessageConsts.GetManorMemberReqID:
					FamilyManorCtrl.GetManorMemberReqID(c);
					break;

				case MessageConsts.DispatchBoxReqID:
					FamilyManorCtrl.DispatchBoxReqID(c);
					break;

				case MessageConsts.NofityExpiredEquipID:
					FashionDeadLineCtrl.NofityExpiredEquipID(c);
					break;

				case MessageConsts.CharRankDetailRequestID:
					ForgeRankComponent.CharRankDetailRequestID(c);
					break;

				case MessageConsts.SearchFriendID:
					FriendController.SearchFriendID(c);
					break;

				case MessageConsts.AddFriendID:
					FriendController.AddFriendID(c);
					break;

				case MessageConsts.AddFriendAckID:
					FriendController.AddFriendAckID(c);
					break;

				case MessageConsts.GetFriendListID:
					FriendController.GetFriendListID(c);
					break;

				case MessageConsts.GetTempFriendListID:
					FriendController.GetTempFriendListID(c);
					break;

				case MessageConsts.GetBlackListID:
					FriendController.GetBlackListID(c);
					break;

				case MessageConsts.GetReqListID:
					FriendController.GetReqListID(c);
					break;

				case MessageConsts.AddToBlacklistID:
					FriendController.AddToBlacklistID(c);
					break;

				case MessageConsts.DelFriendID:
					FriendController.DelFriendID(c);
					break;

				case MessageConsts.DelFromBlacklistID:
					FriendController.DelFromBlacklistID(c);
					break;

				case MessageConsts.DelTempFriendID:
					FriendController.DelTempFriendID(c);
					break;

				case MessageConsts.GrpInviteConfirmRespID:
					GroupController.GrpInviteConfirmRespID(c);
					break;

				case MessageConsts.CreateGroupReqID:
					GroupController.CreateGroupReqID(c);
					break;

				case MessageConsts.GetNearbyGroupsReqID:
					GroupController.GetNearbyGroupsReqID(c);
					break;

				case MessageConsts.RequestToJoinGroupID:
					GroupController.RequestToJoinGroupID(c);
					break;

				case MessageConsts.GetGroupApplicantsID:
					GroupController.GetGroupApplicantsID(c);
					break;

				case MessageConsts.ApplicantConfirmRespID:
					GroupController.ApplicantConfirmRespID(c);
					break;

				case MessageConsts.LeaveGroupReqID:
					GroupController.LeaveGroupReqID(c);
					break;

				case MessageConsts.KickOutGroupReqID:
					GroupController.KickOutGroupReqID(c);
					break;

				case MessageConsts.AssignLeaderReqID:
					GroupController.AssignLeaderReqID(c);
					break;

				case MessageConsts.InviteToJoinGroupID:
					GroupController.InviteToJoinGroupID(c);
					break;

				case MessageConsts.GroupSettingID:
					GroupController.GroupSettingID(c);
					break;

				case MessageConsts.EnterToMachinariumDgnReqID:
					MachinariumCtrl.EnterToMachinariumDgnReqID(c);
					break;

				case MessageConsts.BuyMachinariumDgnTimesReqID:
					MachinariumCtrl.BuyMachinariumDgnTimesReqID(c);
					break;

				case MessageConsts.GetMachinariumDgnTimesReqID:
					MachinariumCtrl.GetMachinariumDgnTimesReqID(c);
					break;

				case MessageConsts.GetMailDetailID:
					MailController.GetMailDetailID(c);
					break;

				case MessageConsts.GetMailListID:
					MailController.GetMailListID(c);
					break;

				case MessageConsts.SendMailC2SID:
					MailController.SendMailC2SID(c);
					break;

				case MessageConsts.DeleteMailID:
					MailController.DeleteMailID(c);
					break;

				case MessageConsts.FetchMailAttachmentID:
					MailController.FetchMailAttachmentID(c);
					break;

				case MessageConsts.MallCommodityListRequestID:
					MallCtrl.MallCommodityListRequestID(c);
					break;

				case MessageConsts.UpdateCrystalBalanceID:
					MallCtrl.UpdateCrystalBalanceID(c);
					break;

				case MessageConsts.MallCommoditySetRequestID:
					MallCtrl.MallCommoditySetRequestID(c);
					break;

				case MessageConsts.RingLevelupReqID:
					MarriageCtrl.RingLevelupReqID(c);
					break;

				case MessageConsts.GetMarriageReqID:
					MarriageCtrl.GetMarriageReqID(c);
					break;

				case MessageConsts.SendFlowersReqID:
					MarriageCtrl.SendFlowersReqID(c);
					break;

				case MessageConsts.DivorceReqID:
					MarriageCtrl.DivorceReqID(c);
					break;

				case MessageConsts.DivorceCancelReqID:
					MarriageCtrl.DivorceCancelReqID(c);
					break;

				case MessageConsts.SingleApplyDivorceReqID:
					MarriageCtrl.SingleApplyDivorceReqID(c);
					break;

				case MessageConsts.SingleForceDivorceReqID:
					MarriageCtrl.SingleForceDivorceReqID(c);
					break;

				case MessageConsts.RegisterMarriageReqID:
					MarriageCtrl.RegisterMarriageReqID(c);
					break;

				case MessageConsts.RegisterMarriageConfirmRespID:
					MarriageCtrl.RegisterMarriageConfirmRespID(c);
					break;

				case MessageConsts.DivorceConfirmRespID:
					MarriageCtrl.DivorceConfirmRespID(c);
					break;

				case MessageConsts.DivorceCancelConfirmRespID:
					MarriageCtrl.DivorceCancelConfirmRespID(c);
					break;

				case MessageConsts.EnterMountDgnReqID:
					MountDgnCtrl.EnterMountDgnReqID(c);
					break;

				case MessageConsts.MountDgnGiftReqID:
					MountDgnCtrl.MountDgnGiftReqID(c);
					break;

				case MessageConsts.GetMountDgnStateReqID:
					MountDgnCtrl.GetMountDgnStateReqID(c);
					break;

				case MessageConsts.MountDgnGiftID:
					MountDgnCtrl.MountDgnGiftID(c);
					break;

				case MessageConsts.GetPlayerGVGStatusReqID:
					MultiGroupClashController.GetPlayerGVGStatusReqID(c);
					break;

				case MessageConsts.AddToGVGDgnQueueReqID:
					MultiGroupClashController.AddToGVGDgnQueueReqID(c);
					break;

				case MessageConsts.LeaveGVGDgnQueueReqID:
					MultiGroupClashController.LeaveGVGDgnQueueReqID(c);
					break;

				case MessageConsts.OffLine1V1RecordReqID:
					OffLinePvpCtrl.OffLine1V1RecordReqID(c);
					break;

				case MessageConsts.OffLine1V1WorldRankReqID:
					OffLinePvpCtrl.OffLine1V1WorldRankReqID(c);
					break;

				case MessageConsts.OffLine1V1OppInfoReqID:
					OffLinePvpCtrl.OffLine1V1OppInfoReqID(c);
					break;

				case MessageConsts.FetchNewServerGiftReqID:
					PropagateController.FetchNewServerGiftReqID(c);
					break;

				case MessageConsts.FetchOpenServerGiftReqID:
					PropagateController.FetchOpenServerGiftReqID(c);
					break;

				case MessageConsts.FetchOpenTestGiftReqID:
					PropagateController.FetchOpenTestGiftReqID(c);
					break;

				case MessageConsts.SetRebornOptionID:
					SceneController.SetRebornOptionID(c);
					break;

				case MessageConsts.GetStoryProgressID:
					StoryController.GetStoryProgressID(c);
					break;

				case MessageConsts.GetHiddenStoryObjectsID:
					StoryController.GetHiddenStoryObjectsID(c);
					break;

				case MessageConsts.SetStoryProgressID:
					StoryController.SetStoryProgressID(c);
					break;

				case MessageConsts.EnterStoryModeID:
					StoryController.EnterStoryModeID(c);
					break;

				case MessageConsts.ExitStoryModeID:
					StoryController.ExitStoryModeID(c);
					break;

				case MessageConsts.SetStoryMobStatusID:
					StoryController.SetStoryMobStatusID(c);
					break;

				case MessageConsts.GetRecentClassCDgnReqID:
					SystemController.GetRecentClassCDgnReqID(c);
					break;

				case MessageConsts.GetEliteRecentClassCDgnReqID:
					SystemController.GetEliteRecentClassCDgnReqID(c);
					break;

				case MessageConsts.UpdateSystemSetRequestID:
					SystemController.UpdateSystemSetRequestID(c);
					break;

				case MessageConsts.QueryRealNameAuthID:
					SystemController.QueryRealNameAuthID(c);
					break;

				case MessageConsts.GetTowerRankReqID:
					TowerDungeonController.GetTowerRankReqID(c);
					break;

				case MessageConsts.GetTowerFirstPlayersReqID:
					TowerDungeonController.GetTowerFirstPlayersReqID(c);
					break;

				case MessageConsts.EnterTowerReqID:
					TowerDungeonController.EnterTowerReqID(c);
					break;

				case MessageConsts.RebornInTowerReqID:
					TowerDungeonController.RebornInTowerReqID(c);
					break;

				case MessageConsts.ResetTowerReqID:
					TowerDungeonController.ResetTowerReqID(c);
					break;

				case MessageConsts.VipAwardReqID:
					VipMainController.VipAwardReqID(c);
					break;

				case MessageConsts.UseWeddingInvationRequestID:
					WeddingCtrl.UseWeddingInvationRequestID(c);
					break;

				case MessageConsts.WeddingMsgID:
					WeddingCtrl.WeddingMsgID(c);
					break;

				case MessageConsts.OrdainWeddingReqID:
					WeddingCtrl.OrdainWeddingReqID(c);
					break;

				case MessageConsts.GetMyOrdainInfoReqID:
					WeddingCtrl.GetMyOrdainInfoReqID(c);
					break;

				case MessageConsts.GetOrdainWeddingListReqID:
					WeddingCtrl.GetOrdainWeddingListReqID(c);
					break;

				case MessageConsts.SendInvitationReqID:
					WeddingCtrl.SendInvitationReqID(c);
					break;

				case MessageConsts.OrdainWeddingConfirmRespID:
					WeddingCtrl.OrdainWeddingConfirmRespID(c);
					break;

				case MessageConsts.GetBossStatsID:
					WildBossController.GetBossStatsID(c);
					break;

				case MessageConsts.EnterWorldBossDungeonID:
					WorldBossController.EnterWorldBossDungeonID(c);
					break;

				case MessageConsts.WorldBossStrengthenReqID:
					WorldBossController.WorldBossStrengthenReqID(c);
					break;

				case MessageConsts.GetWorldBossActiveInfoID:
					WorldBossController.GetWorldBossActiveInfoID(c);
					break;

				case MessageConsts.GetLimitTimeSaleStateReqID:
					WorldLimitBuyCtrl.GetLimitTimeSaleStateReqID(c);
					break;

				case MessageConsts.LimitTimeSaleItemListReqID:
					WorldLimitBuyCtrl.LimitTimeSaleItemListReqID(c);
					break;

				case MessageConsts.XoEnterDgnID:
					XOContestCtrl.XoEnterDgnID(c);
					break;

				case MessageConsts.XoInfoReqID:
					XOContestCtrl.XoInfoReqID(c);
					break;

				case MessageConsts.ZoneBossInfoReqID:
					ZoneBossCtrl.ZoneBossInfoReqID(c);
					break;

				case MessageConsts.GetCharInfoRequestID:
					EtcPropsViewCtrl.GetCharInfoRequestID(c);
					break;

				case MessageConsts.ClientErrorMsgInfoID:
					Shell.ClientErrorMsgInfoID(c);
					break;

				case MessageConsts.LoadingResStatisticsID:
					Shell.LoadingResStatisticsID(c);
					break;

				case MessageConsts.QueryCharInfoRequestID:
					LoginMessageListener.QueryCharInfoRequestID(c);
					break;

				case MessageConsts.LoginRequestID:
					LoginMessageListener.LoginRequestID(c);
					break;

				case MessageConsts.EncryptInfoRequestID:
					FunSocket.EncryptInfoRequestID(c);
					break;

