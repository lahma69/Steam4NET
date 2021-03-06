// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("CLIENTAPPMANAGER_INTERFACE_VERSION001")]
	public interface IClientAppManager
	{
		[VTableSlot(0)]
		EAppUpdateError InstallApp(UInt32 unAppID, Int32 iBaseFolder, bool bLegacy);
		[VTableSlot(1)]
		EAppUpdateError UninstallApp(UInt32 unAppID, bool bComplete);
		[VTableSlot(2)]
		EAppUpdateError LaunchApp(CGameID gameID, UInt32 uLaunchOption, string pszUserArgs);
		[VTableSlot(3)]
		bool ShutdownApp(UInt32 unAppID, bool bForce);
		[VTableSlot(4)]
		EAppState GetAppInstallState(UInt32 unAppID);
		[VTableSlot(5)]
		UInt32 GetAppBuildID(UInt32 unAppID);
		[VTableSlot(6)]
		Int32 GetCurrentAppSizeOnDisk(UInt32 unAppID);
		[VTableSlot(7)]
		UInt64 GetRequiredAppsSizeOnDisk(ref UInt32 unAppIDs, Int32 iUnk);
		[VTableSlot(8)]
		UInt64 GetAppInstallDir(UInt32 unAppID, StringBuilder pchPath, UInt32 cchPath);
		[VTableSlot(9)]
		bool IsAppDlcInstalled(UInt32 unAppID, UInt32 unDLCAppID);
		[VTableSlot(10)]
		bool GetDlcDownloadProgress(UInt32 unAppID, UInt32 unDLCAppID, ref UInt64 lluUnk1, ref UInt64 lluUnk2);
		[VTableSlot(11)]
		UInt32 GetNumInstalledApps();
		[VTableSlot(12)]
		UInt32 GetInstalledApps(ref UInt32 punAppIDs, UInt32 cAppIDsMax);
		[VTableSlot(13)]
		UInt32 GetAppDependency(UInt32 unAppID);
		[VTableSlot(14)]
		UInt32 GetDependentApps(UInt32 unAppID, ref UInt32 punAppIDs, Int32 cAppIDsMax);
		[VTableSlot(15)]
		UInt32 GetUpdateInfo(UInt32 unAppID, ref AppUpdateInfo_s pUpdateInfo);
		[VTableSlot(16)]
		Int32 GetAppConfigValue(UInt32 unAppID, string pchKey, StringBuilder pchValue, Int32 cchValueMax);
		[VTableSlot(17)]
		bool SetAppConfigValue(UInt32 unAppID, string pchKey, string pchValue);
		[VTableSlot(18)]
		bool BIsAppUpToDate(UInt32 unAppID);
		[VTableSlot(19)]
		UInt32 GetAvailableLaunchOptions(UInt32 unAppID, ref UInt32 puOptions, UInt32 cuOptionsMax);
		[VTableSlot(20)]
		UInt32 GetAvailableLanguages(UInt32 unAppID, bool arg1, StringBuilder pchLanguages, UInt32 cchLanguagesMax);
		[VTableSlot(21)]
		bool BIsDlcEnabled(UInt32 unAppID, UInt32 arg1, ref bool arg2);
		[VTableSlot(22)]
		void SetDlcEnabled(UInt32 unAppID, UInt32 arg1, bool arg2);
		[VTableSlot(23)]
		bool StartValidatingApp(UInt32 unAppID);
		[VTableSlot(24)]
		bool CancelValidation(UInt32 unAppID);
		[VTableSlot(25)]
		bool MarkContentCorrupt(UInt32 unAppID, bool bCorrupt);
		[VTableSlot(26)]
		UInt32 GetInstalledDepots(UInt32 unAppID, ref UInt32 puDepots, UInt32 cuDepotsMax);
		[VTableSlot(27)]
		Int32 GetFileDetails(UInt32 unAppID, string pchUnk);
		[VTableSlot(28)]
		Int32 VerifySignedFiles(UInt32 unAppID);
		[VTableSlot(29)]
		Int32 GetAvailableBetas(UInt32 unAppID, ref Int32 iunk1, StringBuilder arg2, Int32 iunk2);
		[VTableSlot(30)]
		bool CheckBetaPassword(UInt32 unAppID, string arg1);
		[VTableSlot(31)]
		bool BHasCachedBetaPassword(UInt32 unAppID, string cszBetaKey);
		[VTableSlot(32)]
		bool SetDownloadingEnabled(bool arg0);
		[VTableSlot(33)]
		bool BIsDownloadingEnabled();
		[VTableSlot(34)]
		bool GetDownloadStats(ref DownloadStats_s pDownloadStats);
		[VTableSlot(35)]
		UInt32 GetDownloadingAppID();
		[VTableSlot(36)]
		bool GetAutoUpdateTimeRestrictionEnabled();
		[VTableSlot(37)]
		void SetAutoUpdateTimeRestrictionEnabled(bool arg0);
		[VTableSlot(38)]
		bool GetAutoUpdateTimeRestrictionHours(ref Int32 piUnk1, ref Int32 piUnk2);
		[VTableSlot(39)]
		bool SetAutoUpdateTimeRestrictionStartHour(Int32 iUnk);
		[VTableSlot(40)]
		bool SetAutoUpdateTimeRestrictionEndHour(Int32 iUnk);
		[VTableSlot(41)]
		EAppAutoUpdateBehavior GetAppAutoUpdateBehavior(UInt32 unAppID);
		[VTableSlot(42)]
		bool SetAppAutoUpdateBehavior(UInt32 unAppID, EAppAutoUpdateBehavior eAppAutoUpdateBehavior);
		[VTableSlot(43)]
		bool SetAppAllowDownloadsWhileRunningBehavior(UInt32 unAppID, EAppAllowDownloadsWhileRunningBehavior eAppAllowDownloadsWhileRunningBehavior);
		[VTableSlot(44)]
		EAppAllowDownloadsWhileRunningBehavior GetAppAllowDownloadsWhileRunningBehavior(UInt32 unAppID);
		[VTableSlot(45)]
		void SetAllowDownloadsWhileAnyAppRunning(bool bAllowDownloadsWhileAnyAppRunning);
		[VTableSlot(46)]
		bool BAllowDownloadsWhileAnyAppRunning();
		[VTableSlot(47)]
		bool ChangeAppDownloadQueuePlacement(UInt32 unAppID, EAppDownloadQueuePlacement eAppDownloadQueuePlacement);
		[VTableSlot(48)]
		Int32 GetAppDownloadQueueIndex(UInt32 unAppID);
		[VTableSlot(49)]
		Int32 GetAppAutoUpdateDelayedUntilTime(UInt32 unAppID);
		[VTableSlot(50)]
		bool BHasLocalContentServer();
		[VTableSlot(51)]
		bool BuildBackup(UInt32 unAppID, UInt64 ullMaxFileSize, string cszBackupPath);
		[VTableSlot(52)]
		bool BuildInstaller(string cszProjectFile, string cszBackupPath, string arg2, string arg3);
		[VTableSlot(53)]
		bool CancelBackup();
		[VTableSlot(54)]
		EAppUpdateError RestoreApp(UInt32 unAppID, Int32 iBaseFolder, string cszBackupPath);
		[VTableSlot(55)]
		bool CanMoveApp(UInt32 unAppID);
		[VTableSlot(56)]
		Int32 MoveApp(UInt32 unAppID, Int32 unk);
		[VTableSlot(57)]
		bool GetMoveAppProgress(UInt32 unAppID, ref UInt64 unk_1, ref UInt64 unk_2, ref UInt32 unk_3);
		[VTableSlot(58)]
		bool CancelMoveApp(UInt32 unAppID);
		[VTableSlot(59)]
		bool BNeedsFile(UInt32 unAppID, string cszFilePath, UInt64 ullFileSize, UInt32 uUnk);
		[VTableSlot(60)]
		bool BAddFileOnDisk(UInt32 unAppID, string cszFilePath, UInt64 ullFileSize, UInt32 uUnk, SHADigestWrapper_t ubSha1);
		[VTableSlot(61)]
		UInt32 FinishAddingFiles(UInt32 unAppID);
		[VTableSlot(62)]
		bool GetAppStateInfo(UInt32 unAppID, ref EAppReleaseState peReleaseState, ref EAppOwnershipFlags peOwnershipFlags, ref EAppState peAppState, ref CSteamID pSteamID, ref UInt32 uUnk1, ref UInt32 uUnk2);
		[VTableSlot(63)]
		bool BIsAvailableOnPlatform(UInt32 uUnk, string pUnk);
		[VTableSlot(64)]
		Int32 GetNumInstallBaseFolders();
		[VTableSlot(65)]
		Int32 GetInstallBaseFolder(Int32 iBaseFolder, StringBuilder pchPath, Int32 cbPath);
		[VTableSlot(66)]
		Int32 AddInstallBaseFolder(string szPath);
		[VTableSlot(67)]
		bool RemoveInstallBaseFolder(Int32 iBaseFolder);
		[VTableSlot(68)]
		UInt64 GetFreeDiskSpace(Int32 iBaseFolder);
		[VTableSlot(69)]
		bool BGetDiskSpaceStats(Int32 iBaseFolder, ref UInt64 arg1, ref UInt64 arg2);
		[VTableSlot(70)]
		Int32 GetAppInstallBaseFolder(Int32 iBaseFolder);
		[VTableSlot(71)]
		void ForceInstallDirOverride(string cszPath);
		[VTableSlot(72)]
		bool SetDownloadThrottleRateKbps(Int32 iRate, bool arg1);
		[VTableSlot(73)]
		Int32 GetDownloadThrottleRateKbps(bool arg0);
		[VTableSlot(74)]
		void SuspendDownloadThrottling(bool bSuspend);
		[VTableSlot(75)]
		void SetThrottleDownloadsWhileStreaming(bool arg0);
		[VTableSlot(76)]
		bool BThrottleDownloadsWhileStreaming();
		[VTableSlot(77)]
		string GetLaunchQueryParam(UInt32 unAppID, string pchKey);
		[VTableSlot(78)]
		void BeginLaunchQueryParams(UInt32 unAppId);
		[VTableSlot(79)]
		void SetLaunchQueryParam(UInt32 unAppId, string pchKey, string pchValue);
		[VTableSlot(80)]
		bool CommitLaunchQueryParams(UInt32 unAppId);
		[VTableSlot(81)]
		void AddContentLogLine(string arg0);
		[VTableSlot(82)]
		bool GetSystemIconFile(UInt32 unAppId, StringBuilder arg1, Int32 arg2);
	};
}
