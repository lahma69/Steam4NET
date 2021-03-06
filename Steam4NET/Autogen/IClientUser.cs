// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct ClientAppInfo
	{
		public Int32 m_iPadding;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct COffline_OfflineLogonTicket
	{
		public Int32 m_iPadding;
	};
	
	[InterfaceVersion("CLIENTUSER_INTERFACE_VERSION001")]
	public interface IClientUser
	{
		[VTableSlot(0)]
		Int32 GetHSteamUser();
		[VTableSlot(1)]
		void LogOn(CSteamID steamID);
		[VTableSlot(2)]
		void LogOnWithPassword(string pchLogin, string pchPassword);
		[VTableSlot(3)]
		void LogOnAndCreateNewSteamAccountIfNeeded();
		[VTableSlot(4)]
		Int32 VerifyOfflineLogon();
		[VTableSlot(5)]
		void LogOff();
		[VTableSlot(6)]
		bool BLoggedOn();
		[VTableSlot(7)]
		ELogonState GetLogonState();
		[VTableSlot(8)]
		bool BConnected();
		[VTableSlot(9)]
		bool BTryingToLogin();
		[VTableSlot(10)]
		CSteamID GetSteamID();
		[VTableSlot(11)]
		CSteamID GetConsoleSteamID();
		[VTableSlot(12)]
		UInt32 GetClientInstanceID();
		[VTableSlot(13)]
		bool IsVACBanned(UInt32 nGameID);
		[VTableSlot(14)]
		bool SetEmail(string pchEmail);
		[VTableSlot(15)]
		bool SetConfigString(ERegistrySubTree eRegistrySubTree, string pchKey, string pchValue);
		[VTableSlot(16)]
		bool GetConfigString(ERegistrySubTree eRegistrySubTree, string pchKey, StringBuilder pchValue, Int32 cbValue);
		[VTableSlot(17)]
		bool SetConfigInt(ERegistrySubTree eRegistrySubTree, string pchKey, Int32 iValue);
		[VTableSlot(18)]
		bool GetConfigInt(ERegistrySubTree eRegistrySubTree, string pchKey, ref Int32 pValue);
		[VTableSlot(19)]
		bool DeleteConfigKey(ERegistrySubTree eRegistrySubTree, string pchKey);
		[VTableSlot(20)]
		bool GetConfigStoreKeyName(ERegistrySubTree eRegistrySubTree, string pchKey, StringBuilder pchStoreName, Int32 cbStoreName);
		[VTableSlot(21)]
		Int32 InitiateGameConnection(Byte[] pOutputBlob, Int32 cbBlobMax, CSteamID steamIDGS, CGameID gameID, UInt32 unIPServer, UInt16 usPortServer, bool bSecure);
		[VTableSlot(22)]
		Int32 InitiateGameConnectionOld(Byte[] pOutputBlob, Int32 cbBlobMax, CSteamID steamIDGS, CGameID gameID, UInt32 unIPServer, UInt16 usPortServer, bool bSecure, Byte[] pvSteam2GetEncryptionKey, Int32 cbSteam2GetEncryptionKey);
		[VTableSlot(23)]
		void TerminateGameConnection(UInt32 unIPServer, UInt16 usPortServer);
		[VTableSlot(24)]
		bool TerminateAppMultiStep(UInt32 arg0, UInt32 arg1);
		[VTableSlot(25)]
		void SetSelfAsPrimaryChatDestination();
		[VTableSlot(26)]
		bool IsPrimaryChatDestination();
		[VTableSlot(27)]
		void RequestLegacyCDKey(UInt32 iAppID);
		[VTableSlot(28)]
		bool AckGuestPass(string pchGuestPassCode);
		[VTableSlot(29)]
		bool RedeemGuestPass(string pchGuestPassCode);
		[VTableSlot(30)]
		UInt32 GetGuestPassToGiveCount();
		[VTableSlot(31)]
		UInt32 GetGuestPassToRedeemCount();
		[VTableSlot(32)]
		bool GetGuestPassToGiveInfo(UInt32 nPassIndex, ref UInt64 pgidGuestPassID, ref UInt32 pnPackageID, ref UInt32 pRTime32Created, ref UInt32 pRTime32Expiration, ref UInt32 pRTime32Sent, ref UInt32 pRTime32Redeemed, StringBuilder pchRecipientAddress, Int32 cRecipientAddressSize);
		[VTableSlot(33)]
		Int32 GetGuestPassToGiveOut(UInt32 arg0);
		[VTableSlot(34)]
		Int32 GetGuestPassToRedeem(UInt32 arg0);
		[VTableSlot(35)]
		bool GetGuestPassToRedeemInfo(UInt32 nPassIndex, ref UInt64 pgidGuestPassID, ref UInt32 pnPackageID, ref UInt32 pRTime32Created, ref UInt32 pRTime32Expiration, ref UInt32 pRTime32Sent, ref UInt32 pRTime32Redeemed);
		[VTableSlot(36)]
		bool GetGuestPassToRedeemSenderName(UInt32 nPassIndex, StringBuilder pchSenderName, Int32 cSenderNameSize);
		[VTableSlot(37)]
		Int32 GetNumAppsInGuestPassesToRedeem();
		[VTableSlot(38)]
		Int32 GetAppsInGuestPassesToRedeem(ref UInt32 arg0, UInt32 arg1);
		[VTableSlot(39)]
		UInt64 RequestStoreAuthURL(string arg0);
		[VTableSlot(40)]
		bool SetLanguage(string pchLanguage);
		[VTableSlot(41)]
		void TrackAppUsageEvent(CGameID gameID, Int32 eAppUsageEvent, string pchExtraInfo);
		[VTableSlot(42)]
		Int32 RaiseConnectionPriority(EConnectionPriority eConnectionPriority);
		[VTableSlot(43)]
		void ResetConnectionPriority(Int32 hRaiseConnectionPriorityPrev);
		[VTableSlot(44)]
		bool BHasCachedCredentials(string pchUnk);
		[VTableSlot(45)]
		bool SetAccountNameForCachedCredentialLogin(string pchAccountName, bool bUnk);
		[VTableSlot(46)]
		bool GetCurrentWebAuthToken(StringBuilder pchBuffer, Int32 cubBuffer, StringBuilder pchBuffer2, Int32 cubBuffer2);
		[VTableSlot(47)]
		UInt64 RequestWebAuthToken();
		[VTableSlot(48)]
		void SetLoginInformation(string pchAccountName, string pchPassword, bool bRememberPassword);
		[VTableSlot(49)]
		void SetTwoFactorCode(string arg0);
		[VTableSlot(50)]
		void ClearAllLoginInformation();
		[VTableSlot(51)]
		bool GetLanguage(StringBuilder pchLanguage, Int32 cbLanguage);
		[VTableSlot(52)]
		bool BIsCyberCafe();
		[VTableSlot(53)]
		bool BIsAcademicAccount();
		[VTableSlot(54)]
		bool BIsPortal2EducationAccount();
		[VTableSlot(55)]
		bool BIsAlienwareDemoAccount();
		[VTableSlot(56)]
		void CreateAccount(string pchAccountName, string pchNewPassword, string pchNewEmail, Int32 iQuestion, string pchNewQuestion, string pchNewAnswer);
		[VTableSlot(57)]
		UInt64 ResetPassword(string pchAccountName, string pchOldPassword, string pchNewPassword, string pchValidationCode, string pchAnswer, string pchUnk);
		[VTableSlot(58)]
		EResult ValidatePasswordResetCodeAndSendSms(string arg0, string arg1);
		[VTableSlot(59)]
		void TrackNatTraversalStat(ref CNatTraversalStat pNatStat);
		[VTableSlot(60)]
		void TrackSteamUsageEvent(ESteamUsageEvent eSteamUsageEvent, Byte[] pubKV, UInt32 cubKV);
		[VTableSlot(61)]
		void TrackSteamGUIUsage(string arg0);
		[VTableSlot(62)]
		void SetComputerInUse();
		[VTableSlot(63)]
		bool BIsGameRunning(CGameID gameID);
		[VTableSlot(64)]
		bool BIsGameWindowReady(CGameID gameID);
		[VTableSlot(65)]
		bool BUpdateAppOwnershipTicket(UInt32 nAppID, bool bOnlyUpdateIfStale, bool bIsDepot);
		[VTableSlot(66)]
		bool RequestCustomBinary(string pszAbsolutePath, UInt32 nAppID, bool bForceUpdate, bool bAppLaunchRequest);
		[VTableSlot(67)]
		EResult GetCustomBinariesState(UInt32 unAppID, ref Int64 iUnk1, ref Int64 iUnk2);
		[VTableSlot(68)]
		EResult RequestCustomBinaries(UInt32 unAppID, bool arg1, bool arg2, ref UInt32 arg3);
		[VTableSlot(69)]
		void SetCellID(UInt32 cellID);
		[VTableSlot(70)]
		string GetUserBaseFolder();
		[VTableSlot(71)]
		bool GetUserDataFolder(CGameID gameID, StringBuilder pchBuffer, Int32 cubBuffer);
		[VTableSlot(72)]
		bool GetUserConfigFolder(StringBuilder pchBuffer, Int32 cubBuffer);
		[VTableSlot(73)]
		bool GetAccountName(StringBuilder pchAccountName, UInt32 cb);
		[VTableSlot(74)]
		bool GetAccountName(CSteamID userID, StringBuilder pchAccountName, UInt32 cb);
		[VTableSlot(75)]
		bool IsPasswordRemembered();
		[VTableSlot(76)]
		void CheckoutSiteLicenseSeat(UInt32 uUnk);
		[VTableSlot(77)]
		void GetAvailableSeats(UInt32 uUnk);
		[VTableSlot(78)]
		string GetAssociatedSiteName();
		[VTableSlot(79)]
		bool BIsRunningInCafe();
		[VTableSlot(80)]
		bool RequiresLegacyCDKey(UInt32 nAppID, ref bool pbUnk);
		[VTableSlot(81)]
		bool GetLegacyCDKey(UInt32 nAppID, StringBuilder pchKeyData, Int32 cbKeyData);
		[VTableSlot(82)]
		bool SetLegacyCDKey(UInt32 nAppID, string pchKeyData);
		[VTableSlot(83)]
		bool WriteLegacyCDKey(UInt32 nAppID);
		[VTableSlot(84)]
		void RemoveLegacyCDKey(UInt32 nAppID);
		[VTableSlot(85)]
		void RequestLegacyCDKeyFromApp(UInt32 nMainAppID, UInt32 nDLCAppID, UInt32 uUnk);
		[VTableSlot(86)]
		bool BIsAnyGameRunning();
		[VTableSlot(87)]
		void TestAvailablePassword(Byte[] pubDigestPassword, Int32 cubDigestPassword);
		[VTableSlot(88)]
		void GetSteamGuardDetails();
		[VTableSlot(89)]
		void GetTwoFactorDetails();
		[VTableSlot(90)]
		bool BHasTwoFactor();
		[VTableSlot(91)]
		void RecoverAuthenticator(string arg0, string arg1, string arg2, string arg3, string arg4);
		[VTableSlot(92)]
		void ChangePassword(string pchOldPassword, string pchNewPassword);
		[VTableSlot(93)]
		bool GetEmail(StringBuilder pchEmail, Int32 cchEmail, ref bool pbValidated);
		[VTableSlot(94)]
		void RequestForgottenPasswordEmail(string pchAccountName, string pchTriedPassword);
		[VTableSlot(95)]
		void RequestAccountResetDetails(string arg0, string arg1);
		[VTableSlot(96)]
		void FindAccountsByEmailAddress(string pchEmailAddress);
		[VTableSlot(97)]
		void FindAccountsByCdKey(string pchCdKey);
		[VTableSlot(98)]
		void GetNumAccountsWithEmailAddress(string pchEmailAddress);
		[VTableSlot(99)]
		void IsAccountNameInUse(string pchAccountName);
		[VTableSlot(100)]
		void Test_FakeConnectionTimeout();
		[VTableSlot(101)]
		bool RunInstallScript(UInt32 pAppIDs, string pchUnk, bool bUninstall);
		[VTableSlot(102)]
		UInt32 IsInstallScriptRunning();
		[VTableSlot(103)]
		bool GetInstallScriptState(StringBuilder pchDescription, UInt32 cchDescription, ref UInt32 punNumSteps, ref UInt32 punCurrStep);
		[VTableSlot(104)]
		bool SpawnProcess(string lpApplicationName, string lpCommandLine, UInt32 dwCreationFlags, string lpCurrentDirectory, CGameID gameID, string pchGameName, UInt32 uUnk, UInt32 uUnk2);
		[VTableSlot(105)]
		UInt32 GetAppOwnershipTicketLength(UInt32 nAppID);
		[VTableSlot(106)]
		UInt32 GetAppOwnershipTicketData(UInt32 nAppID, Byte[] pvBuffer, UInt32 cbBufferLength);
		[VTableSlot(107)]
		UInt32 GetAppOwnershipTicketExtendedData(UInt32 nAppID, Byte[] pvBuffer, UInt32 cbBufferLength, ref UInt32 piAppId, ref UInt32 piSteamId, ref UInt32 piSignature, ref UInt32 pcbSignature);
		[VTableSlot(108)]
		Int32 GetMarketingMessageCount();
		[VTableSlot(109)]
		bool GetMarketingMessage(Int32 cMarketingMessage, ref UInt64 gidMarketingMessageID, StringBuilder pubMsgUrl, Int32 cubMessageUrl, ref EMarketingMessageFlags eMarketingMssageFlags);
		[VTableSlot(110)]
		UInt32 GetAuthSessionTicket(Byte[] pMyAuthTicket, Int32 cbMaxMyAuthTicket, ref UInt32 pcbAuthTicket);
		[VTableSlot(111)]
		EBeginAuthSessionResult BeginAuthSession(Byte[] pTheirAuthTicket, Int32 cbTicket, CSteamID steamID);
		[VTableSlot(112)]
		void EndAuthSession(CSteamID steamID);
		[VTableSlot(113)]
		void CancelAuthTicket(UInt32 hAuthTicket);
		[VTableSlot(114)]
		EUserHasLicenseForAppResult IsUserSubscribedAppInTicket(CSteamID steamID, UInt32 appID);
		[VTableSlot(115)]
		void AdvertiseGame(CGameID gameID, CSteamID steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer);
		[VTableSlot(116)]
		UInt64 RequestEncryptedAppTicket(Byte[] pUserData, Int32 cbUserData);
		[VTableSlot(117)]
		bool GetEncryptedAppTicket(Byte[] pTicket, Int32 cbMaxTicket, ref UInt32 pcbTicket);
		[VTableSlot(118)]
		Int32 GetGameBadgeLevel(Int32 nSeries, bool bFoil);
		[VTableSlot(119)]
		Int32 GetPlayerSteamLevel();
		[VTableSlot(120)]
		void SetAccountLimited(bool bAccountLimited);
		[VTableSlot(121)]
		bool BIsAccountLimited();
		[VTableSlot(122)]
		void SetAccountCommunityBanned(bool bBanned);
		[VTableSlot(123)]
		bool BIsAccountCommunityBanned();
		[VTableSlot(124)]
		void SetLimitedAccountCanInviteFriends(bool bCanInviteFriends);
		[VTableSlot(125)]
		bool BLimitedAccountCanInviteFriends();
		[VTableSlot(126)]
		void SendValidationEmail();
		[VTableSlot(127)]
		bool BGameConnectTokensAvailable();
		[VTableSlot(128)]
		Int32 NumGamesRunning();
		[VTableSlot(129)]
		CGameID GetRunningGameID(Int32 iGame);
		[VTableSlot(130)]
		Int32 GetRunningGamePID(Int32 arg0);
		[VTableSlot(131)]
		UInt32 GetAccountSecurityPolicyFlags();
		[VTableSlot(132)]
		void RequestPasswordChangeEmail(string arg0, Int32 arg1);
		[VTableSlot(133)]
		void ChangePasswordWithCode(string pchOldPassword, string pchCode, string pchNewPassword);
		[VTableSlot(134)]
		void RequestEmailChange(string arg0, string arg1);
		[VTableSlot(135)]
		void ChangeEmailWithCode(string arg0, string arg1, string arg2, string arg3, string arg4);
		[VTableSlot(136)]
		void SetClientStat(EClientStat eStat, Int64 llValue, UInt32 nAppID, UInt32 nDepotID, UInt32 nCellID);
		[VTableSlot(137)]
		void VerifyPassword(string pchPassword);
		[VTableSlot(138)]
		bool BSupportUser();
		[VTableSlot(139)]
		bool BNeedsSSANextSteamLogon();
		[VTableSlot(140)]
		void ClearNeedsSSANextSteamLogon();
		[VTableSlot(141)]
		bool BIsAppOverlayEnabled(CGameID gameID);
		[VTableSlot(142)]
		bool BOverlayIgnoreChildProcesses(CGameID arg0);
		[VTableSlot(143)]
		bool BIsBehindNAT();
		[VTableSlot(144)]
		UInt32 GetMicroTxnAppID(UInt64 gidTransID);
		[VTableSlot(145)]
		UInt64 GetMicroTxnOrderID(UInt64 gidTransID);
		[VTableSlot(146)]
		bool BGetMicroTxnPrice(UInt64 gidTransID, ref CAmount pamtTotal, ref CAmount pamtTax, ref bool pbVat, ref CAmount pUnk);
		[VTableSlot(147)]
		Int32 GetMicroTxnLineItemCount(UInt64 gidTransID);
		[VTableSlot(148)]
		bool BGetMicroTxnLineItem(UInt64 gidTransID, UInt32 unLineItem, ref CAmount pamt, ref UInt32 punQuantity, StringBuilder pchDescription, UInt32 cubDescriptionLength, ref Int32 pRecurringTimeUnit, Byte[] pRecurringFrequency, ref CAmount pRecurringAmount, ref bool pbUnk);
		[VTableSlot(149)]
		bool BIsSandboxMicroTxn(UInt64 gidTransID, ref bool pbSandbox);
		[VTableSlot(150)]
		bool BMicroTxnRequiresCachedPmtMethod(UInt64 gidTransID, ref bool pbRequired);
		[VTableSlot(151)]
		UInt64 AuthorizeMicroTxn(UInt64 gidTransID, EMicroTxnAuthResponse eMicroTxnAuthResponse);
		[VTableSlot(152)]
		bool BGetWalletBalance(ref bool pbHasWallet, ref CAmount pamtBalance, ref CAmount pamtPending);
		[VTableSlot(153)]
		UInt64 RequestMicroTxnInfo(UInt64 gidTransID);
		[VTableSlot(154)]
		bool BMicroTxnRefundable(UInt64 gidTransID);
		[VTableSlot(155)]
		bool BGetAppMinutesPlayed(UInt32 nAppId, ref Int32 pnForever, ref Int32 pnLastTwoWeeks);
		[VTableSlot(156)]
		UInt32 GetAppLastPlayedTime(UInt32 nAppId);
		[VTableSlot(157)]
		UInt32 GetAppUpdateDisabledSecondsRemaining(UInt32 arg0);
		[VTableSlot(158)]
		bool BGetGuideURL(UInt32 uAppID, StringBuilder pchURL, UInt32 cchURL);
		[VTableSlot(159)]
		bool BPromptToVerifyEmail();
		[VTableSlot(160)]
		bool BPromptToChangePassword();
		[VTableSlot(161)]
		bool BAccountExtraSecurity();
		[VTableSlot(162)]
		bool BAccountShouldShowLockUI();
		[VTableSlot(163)]
		Int32 GetCountAuthedComputers();
		[VTableSlot(164)]
		bool BSteamGuardNewMachineNotification();
		[VTableSlot(165)]
		UInt32 GetSteamGuardEnabledTime();
		[VTableSlot(166)]
		bool GetSteamGuardHistoryEntry(Int32 iEntryIndex, ref UInt32 puTimestamp, ref UInt32 puIP, ref bool pbIsRemembered, StringBuilder pchGeolocInfo, Int32 cchGeolocInfo, StringBuilder pchUnk, Int32 cbUnk);
		[VTableSlot(167)]
		void SetSteamGuardNewMachineDialogResponse(bool bIsApproved, bool bIsWizardComplete);
		[VTableSlot(168)]
		void SetPhoneIsVerified(bool arg0);
		[VTableSlot(169)]
		bool BIsPhoneVerified();
		[VTableSlot(170)]
		void SetPhoneIsIdentifying(bool arg0);
		[VTableSlot(171)]
		bool BIsPhoneIdentifying();
		[VTableSlot(172)]
		void SetPhoneIsRequiringVerification(bool arg0);
		[VTableSlot(173)]
		bool BIsPhoneRequiringVerification();
		[VTableSlot(174)]
		void ChangeTwoFactorAuthOptions(Int32 eOption);
		[VTableSlot(175)]
		void Set2ndFactorAuthCode(string pchAuthCode, bool bDontRememberComputer);
		[VTableSlot(176)]
		void SetUserMachineName(string pchMachineName);
		[VTableSlot(177)]
		bool GetUserMachineName(StringBuilder pchMachineName, Int32 cbMachineName);
		[VTableSlot(178)]
		bool GetEmailDomainFromLogonFailure(StringBuilder pchEmailDomain, Int32 cbEmailDomain);
		[VTableSlot(179)]
		bool BIsSubscribedApp(UInt32 nAppId);
		[VTableSlot(180)]
		UInt32 GetSubscribedApps(ref UInt32 arg0, UInt32 arg1, bool arg2);
		[VTableSlot(181)]
		UInt64 RegisterActivationCode(string pchActivationCode);
		[VTableSlot(182)]
		void AckSystemIM(UInt64 arg0);
		[VTableSlot(183)]
		UInt64 RequestSpecialSurvey(UInt32 uSurveyId);
		[VTableSlot(184)]
		UInt64 SendSpecialSurveyResponse(UInt32 uSurveyId, Byte[] pubData, UInt32 cubData);
		[VTableSlot(185)]
		void RequestNotifications();
		[VTableSlot(186)]
		bool GetAppOwnershipInfo(UInt32 unAppId, ref UInt32 pRTime32Created, ref UInt32 unk, StringBuilder pchCountry);
		[VTableSlot(187)]
		void SendGameWebCallback(UInt32 unAppId, string szData);
		[VTableSlot(188)]
		void StopStreaming(bool arg0, Int32 arg1);
		[VTableSlot(189)]
		bool BIsStreamingUIToRemoteDevice();
		[VTableSlot(190)]
		bool BIsCurrentlyNVStreaming();
		[VTableSlot(191)]
		void RequestStopNVStreaming();
		[VTableSlot(192)]
		void OnBigPictureStreamingResult(bool arg0, Byte[] arg1);
		[VTableSlot(193)]
		void OnBigPictureStreamingDone();
		[VTableSlot(194)]
		void OnBigPictureStreamRestarting();
		[VTableSlot(195)]
		void LockParentalLock();
		[VTableSlot(196)]
		bool UnlockParentalLock(string pchUnk);
		[VTableSlot(197)]
		bool BIsParentalLockEnabled();
		[VTableSlot(198)]
		bool BIsParentalLockLocked();
		[VTableSlot(199)]
		void BlockApp(UInt32 unAppID);
		[VTableSlot(200)]
		void UnblockApp(UInt32 unAppID);
		[VTableSlot(201)]
		bool BIsAppBlocked(UInt32 unAppID);
		[VTableSlot(202)]
		bool BIsAppInBlockList(UInt32 unAppID);
		[VTableSlot(203)]
		void BlockFeature(EParentalFeature eParentalFeature);
		[VTableSlot(204)]
		void UnblockFeature(EParentalFeature eParentalFeature);
		[VTableSlot(205)]
		bool BIsFeatureBlocked(EParentalFeature eParentalFeature);
		[VTableSlot(206)]
		bool BIsFeatureInBlockList(EParentalFeature eParentalFeature);
		[VTableSlot(207)]
		UInt32 GetParentalUnlockTime();
		[VTableSlot(208)]
		bool BGetRecoveryEmail(StringBuilder arg0, Int32 arg1);
		[VTableSlot(209)]
		void RequestParentalRecoveryEmail();
		[VTableSlot(210)]
		bool BGetSerializedParentalSettings(ref CUtlBuffer pBuffer);
		[VTableSlot(211)]
		bool BSetParentalSettings(ref CUtlBuffer pBuffer);
		[VTableSlot(212)]
		bool BDisableParentalSettings();
		[VTableSlot(213)]
		bool BGetParentalWebToken(ref CUtlBuffer arg0, ref CUtlBuffer arg1);
		[VTableSlot(214)]
		bool BCanLogonOfflineMode();
		[VTableSlot(215)]
		EResult LogOnOfflineMode();
		[VTableSlot(216)]
		EResult ValidateOfflineLogonTicket(string pchUnk);
		[VTableSlot(217)]
		bool BGetOfflineLogonTicket(string pchUnk, ref COffline_OfflineLogonTicket pTicket);
		[VTableSlot(218)]
		void UploadLocalClientLogs();
		[VTableSlot(219)]
		void SetAsyncNotificationEnabled(UInt32 arg0, bool arg1);
		[VTableSlot(220)]
		bool BIsOtherSessionPlaying(ref UInt32 arg0);
		[VTableSlot(221)]
		bool BKickOtherPlayingSession();
		[VTableSlot(222)]
		void PerformAccountRecoveryUpload();
		[VTableSlot(223)]
		bool BIsAccountLockedDown();
		[VTableSlot(224)]
		void RemoveAppTag(CGameID arg0, string arg1);
		[VTableSlot(225)]
		void AddAppTag(CGameID arg0, string arg1);
		[VTableSlot(226)]
		void SetAppHidden(CGameID arg0, bool arg1);
		[VTableSlot(227)]
		UInt64 RequestAccountLinkInfo();
	};
}
