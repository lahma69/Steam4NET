// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public enum EAppState : int
	{
		k_EAppStateInvalid = 0,
		k_EAppStateUninstalled = 1,
		k_EAppStateUpdateRequired = 2,
		k_EAppStateFullyInstalled = 4,
		k_EAppStateUpdateQueued = 8,
		k_EAppStateUpdateOptional = 16,
		k_EAppStateFilesMissing = 32,
		k_EAppStateSharedOnly = 64,
		k_EAppStateFilesCorrupt = 128,
		k_EAppStateUpdateRunning = 256,
		k_EAppStateUpdatePaused = 512,
		k_EAppStateUpdateStarted = 1024,
		k_EAppStateUninstalling = 2048,
		k_EAppStateBackupRunning = 4096,
		k_EAppStateAppRunning = 8192,
		k_EAppStateComponentInUse = 16384,
		k_EAppStateMovingFolder = 32768,
	};
	
	public enum EAppUpdateState : int
	{
		k_EAppUpdateStateNone = 0,
		k_EAppUpdateStateRunning = 1,
		k_EAppUpdateStateReconfiguring = 2,
		k_EAppUpdateStateValidating = 4,
		k_EAppUpdateStateAddingFiles = 8,
		k_EAppUpdateStatePreallocating = 16,
		k_EAppUpdateStateDownloading = 32,
		k_EAppUpdateStateStaging = 64,
		k_EAppUpdateStateVerifying = 128,
		k_EAppUpdateStateCommitting = 256,
		k_EAppUpdateStateStopping = 512,
	};
	
	public enum EAppEvent : int
	{
		k_EAppEventDownloadComplete = 2,
	};
	
	public enum EAppInfoSection : int
	{
		k_EAppInfoSectionUnknown = 0,
		k_EAppInfoSectionAll = 1,
		k_EAppInfoSectionCommon = 2,
		k_EAppInfoSectionExtended = 3,
		k_EAppInfoSectionConfig = 4,
		k_EAppInfoSectionStats = 5,
		k_EAppInfoSectionInstall = 6,
		k_EAppInfoSectionDepots = 7,
		k_EAppInfoSectionVac = 8,
		k_EAppInfoSectionDrm = 9,
		k_EAppInfoSectionUfs = 10,
		k_EAppInfoSectionOgg = 11,
		k_EAppInfoSectionItems = 12,
		k_EAppInfoSectionPolicies = 13,
		k_EAppInfoSectionSysreqs = 14,
		k_EAppInfoSectionCommunity = 15,
		k_EAppInfoSectionStore = 16,
	};
	
	public enum EAppType : int
	{
		k_EAppTypeDepotonly = -2147483648,
		k_EAppTypeInvalid = 0,
		k_EAppTypeGame = 1,
		k_EAppTypeApplication = 2,
		k_EAppTypeTool = 4,
		k_EAppTypeDemo = 8,
		k_EAppTypeMedia = 16,
		k_EAppTypeDlc = 32,
		k_EAppTypeGuide = 64,
		k_EAppTypeDriver = 128,
		k_EAppTypeConfig = 256,
		k_EAppTypeHardware = 512,
		k_EAppTypeFranchise = 1024,
		k_EAppTypeVideo = 2048,
		k_EAppTypePlugin = 4096,
		k_EAppTypeMusic = 8192,
		k_EAppTypeSeries = 16384,
		k_EAppTypeComic = 32768,
		k_EAppTypeShortcut = 1073741824,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct AppUpdateInfo_s
	{
		public UInt32 m_timeUpdateStart;
		public UInt32 m_uUnk1;
		public UInt64 m_unBytesToDownload;
		public UInt64 m_unBytesDownloaded;
		public UInt64 m_unBytesToProcess;
		public UInt64 m_unBytesProcessed;
		public Int32 m_unEstimatedSecondsRemaining;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
		public string m_cUnk;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct DownloadStats_s
	{
		public UInt32 m_unCurrentConnections;
		public UInt32 m_unBandwidthUsage;
		public UInt64 m_unTotalBytesDownload;
	};
	
	public enum EAppDownloadPriority : int
	{
		k_EAppDownloadPriorityNone = 0,
		k_EAppDownloadPriorityFirst = 1,
		k_EAppDownloadPriorityUp = 2,
		k_EAppDownloadPriorityDown = 3,
		k_EAppDownloadPriorityLast = 4,
		k_EAppDownloadPriorityPaused = 5,
	};
	
	public enum EAppUpdateError : int
	{
		k_EAppUpdateErrorNoError = 0,
		k_EAppUpdateErrorUnspecifiedError = 1,
		k_EAppUpdateErrorPaused = 2,
		k_EAppUpdateErrorCanceled = 3,
		k_EAppUpdateErrorSuspended = 4,
		k_EAppUpdateErrorNoSubscription = 5,
		k_EAppUpdateErrorNoConnection = 6,
		k_EAppUpdateErrorConnectionTimeout = 7,
		k_EAppUpdateErrorMissingDecryptionKey = 8,
		k_EAppUpdateErrorMissingConfiguration = 9,
		k_EAppUpdateErrorDiskReadFailure = 10,
		k_EAppUpdateErrorDiskWriteFailure = 11,
		k_EAppUpdateErrorNotEnoughDiskSpace = 12,
		k_EAppUpdateErrorCorruptGameFiles = 13,
		k_EAppUpdateErrorWaitingForDisk = 14,
		k_EAppUpdateErrorInvalidInstallPath = 15,
		k_EAppUpdateErrorApplicationRunning = 16,
		k_EAppUpdateErrorDependencyFailure = 17,
		k_EAppUpdateErrorNotInstalled = 18,
		k_EAppUpdateErrorUpdateRequired = 19,
		k_EAppUpdateErrorStillBusy = 20,
		k_EAppUpdateErrorNoConnectionToContentServers = 21,
		k_EAppUpdateErrorInvalidApplicationConfiguration = 22,
		k_EAppUpdateErrorInvalidContentConfiguration = 23,
		k_EAppUpdateErrorManifestUnavailable = 24,
		k_EAppUpdateErrorNotReleased = 25,
		k_EAppUpdateErrorRegionRestricted = 26,
		k_EAppUpdateErrorCorruptDepotCache = 27,
		k_EAppUpdateErrorMissingExecutable = 28,
		k_EAppUpdateErrorInvalidPlatform = 29,
		k_EAppUpdateErrorInvalidFileSystem = 30,
		k_EAppUpdateErrorCorruptUpdateFiles = 31,
		k_EAppUpdateErrorDownloadDisabled = 32,
		k_EAppUpdateErrorSharedLibraryLocked = 33,
		k_EAppUpdateErrorPurchasePending = 34,
		k_EAppUpdateErrorOtherSessionPlaying = 35,
		k_EAppUpdateErrorCorruptDownload = 36,
		k_EAppUpdateErrorCorruptDisk = 37,
		k_EAppUpdateErrorMissingFilePermissions = 38,
		k_EAppUpdateErrorFileLocked = 39,
		k_EAppUpdateErrorContentUnavailable = 40,
		k_EAppUpdateErrorRequires64bitOperatingSystem = 41,
		k_EAppUpdateErrorMissingUpdateFiles = 42,
		k_EAppUpdateErrorNotEnoughDiskQuota = 43,
		k_EAppUpdateErrorSiteLicenseLocked = 44,
		k_EAppUpdateErrorParentalControlBlocked = 45,
		k_EAppUpdateErrorCreateProcessFailed = 46,
		k_EAppUpdateErrorSteamClientOutOfDate = 47,
	};
	
	public enum ERegisterActivactionCodeResult : int
	{
		k_ERegisterActivactionCodeResultOK = 0,
		k_ERegisterActivactionCodeResultFail = 1,
		k_ERegisterActivactionCodeResultAlreadyRegistered = 2,
		k_ERegisterActivactionCodeResultTimeout = 3,
		k_ERegisterActivactionCodeAlreadyOwned = 4,
	};
	
	public enum EAppOwnershipFlags : int
	{
		k_EAppOwnershipFlagsNone = 0,
		k_EAppOwnershipFlagsOwnsLicense = 1,
		k_EAppOwnershipFlagsFreeLicense = 2,
		k_EAppOwnershipFlagsRegionRestricted = 4,
		k_EAppOwnershipFlagsLowViolence = 8,
		k_EAppOwnershipFlagsInvalidPlatform = 16,
		k_EAppOwnershipFlagsSharedLicense = 32,
		k_EAppOwnershipFlagsFreeWeekend = 64,
		k_EAppOwnershipFlagsRetail = 128,
		k_EAppOwnershipFlagsLockedLicense = 256,
		k_EAppOwnershipFlagsPending = 512,
		k_EAppOwnershipFlagsExpired = 1024,
		k_EAppOwnershipFlagsPermanent = 2048,
		k_EAppOwnershipFlagsRecurring = 4096,
		k_EAppOwnershipFlagsCanceled = 8192,
		k_EAppOwnershipFlagsAutoGrant = 16384,
	};
	
	public enum EAppReleaseState : int
	{
		k_EAppReleaseStateUnknown = 0,
		k_EAppReleaseStateUnavailable = 1,
		k_EAppReleaseStatePrerelease = 2,
		k_EAppReleaseStatePreloadonly = 3,
		k_EAppReleaseStateReleased = 4,
	};
	
	public enum EAppAutoUpdateBehavior : int
	{
		k_EAppAutoUpdateBehaviorDefault = 0,
		k_EAppAutoUpdateBehaviorDisabled = 1,
		k_EAppAutoUpdateBehaviorHighPriority = 2,
	};
	
	public enum EAppAllowDownloadsWhileRunningBehavior : int
	{
	};
	
	public enum EAppDownloadQueuePlacement : int
	{
		k_EAppDownloadQueuePlacementNone = 0,
		k_EAppDownloadQueuePlacementFirst = 1,
		k_EAppDownloadQueuePlacementUserInitiated = 2,
		k_EAppDownloadQueuePlacementUp = 3,
		k_EAppDownloadQueuePlacementDown = 4,
		k_EAppDownloadQueuePlacementLast = 5,
		k_EAppDownloadQueuePlacementPaused = 6,
	};
	
	public enum ELanguage : int
	{
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct SHADigestWrapper_t
	{
		public UInt32 A;
		public UInt32 B;
		public UInt32 C;
		public UInt32 D;
		public UInt32 E;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1001)]
	public struct AppInfoChanged_t
	{
		public const int k_iCallback = 1001;
		public UInt32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1002)]
	public struct RequestAppCallbacksComplete_t
	{
		public const int k_iCallback = 1002;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1003)]
	public struct AppInfoUpdateComplete_t
	{
		public const int k_iCallback = 1003;
		public EResult m_EResult;
		public UInt32 m_cAppsUpdated;
		public UInt32 m_cPackagesUpdated;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1004)]
	public struct AppEventTriggered_t
	{
		public const int k_iCallback = 1004;
		public UInt32 m_nAppID;
		public EAppEvent m_eAppEvent;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1005)]
	public struct DlcInstalled_t
	{
		public const int k_iCallback = 1005;
		public UInt32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1006)]
	public struct AppEventStateChange_t
	{
		public const int k_iCallback = 1006;
		public UInt32 m_nAppID;
		public UInt32 m_eOldState;
		public UInt32 m_eNewState;
		public EAppUpdateError m_eAppError;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1007)]
	public struct AppValidationComplete_t
	{
		public const int k_iCallback = 1007;
		public UInt32 m_nAppID;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bFinished;
		public UInt64 m_TotalBytesValidated;
		public UInt64 m_TotalBytesFailed;
		public UInt32 m_TotalFilesValidated;
		public UInt32 m_TotalFilesFailed;
		public UInt32 m_TotalFilesFailedCEGFiles;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1008)]
	public struct RegisterActivationCodeResponse_t
	{
		public const int k_iCallback = 1008;
		public ERegisterActivactionCodeResult m_eResult;
		public UInt32 m_unPackageRegistered;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1009)]
	public struct DownloadScheduleChanged_t
	{
		public const int k_iCallback = 1009;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bDownloadEnabled;
		public UInt32 m_nTotalAppsScheduled;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public UInt32[] m_rgunAppSchedule;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1010)]
	public struct AppUpdateStateChange_t
	{
		public const int k_iCallback = 1010;
		public UInt32 m_nAppID;
		public UInt32 m_eOldState;
		public UInt32 m_eNewState;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1011)]
	public struct AppLaunchTenFootOverlay_t
	{
		public const int k_iCallback = 1011;
		public GameID_t m_GameID;
		public UInt64 m_nPid;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCanShareSurfaces;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1012)]
	public struct AppBackupStatus_t
	{
		public const int k_iCallback = 1012;
		public UInt32 m_nAppID;
		public EResult m_eResult;
		public UInt64 m_unBytesToProcess;
		public UInt64 m_unBytesProcessed;
		public UInt64 m_unTotalBytesWritten;
		public UInt64 m_unBytesFailed;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1013)]
	public struct RequestAppProofOfPurchaseKeyResponse_t
	{
		public const int k_iCallback = 1013;
		public EResult m_eResult;
		public UInt32 m_nAppID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchKey;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1016)]
	public struct AppAutoUpdateBehaviorChanged_t
	{
		public const int k_iCallback = 1016;
		public UInt32 m_nAppID;
		public EAppAutoUpdateBehavior m_eNewBehavior;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1017)]
	public struct AppInfoUpdateProgress_t
	{
		public const int k_iCallback = 1017;
		public UInt32 m_cAppsRequested;
		public UInt32 m_cAppsUpdated;
		public UInt32 m_cPackagesRequested;
		public UInt32 m_cPackagesUpdated;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1018)]
	public struct AppUpdateStopped_t
	{
		public const int k_iCallback = 1018;
		public UInt32 m_nAppID;
		public AppUpdateInfo_s m_UpdateState;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1019)]
	public struct AppConfigChanged_t
	{
		public const int k_iCallback = 1019;
		public UInt32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1020)]
	public struct CheckAppBetaPasswordResponse_t
	{
		public const int k_iCallback = 1020;
		public UInt32 m_nAppID;
		public EResult m_eResult;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_szBetaName;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1025)]
	public struct AppUpdateProgress_t
	{
		public const int k_iCallback = 1025;
		public UInt32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(1027)]
	public struct AppLaunchResult_t
	{
		public const int k_iCallback = 1027;
		public GameID_t m_GameID;
		public EAppUpdateError m_eAppError;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		public string m_szErrorDetail;
	};
	
}
