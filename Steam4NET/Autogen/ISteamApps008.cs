// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("STEAMAPPS_INTERFACE_VERSION008")]
	public interface ISteamApps008
	{
		[VTableSlot(0)]
		bool BIsSubscribed();
		[VTableSlot(1)]
		bool BIsLowViolence();
		[VTableSlot(2)]
		bool BIsCybercafe();
		[VTableSlot(3)]
		bool BIsVACBanned();
		[VTableSlot(4)]
		string GetCurrentGameLanguage();
		[VTableSlot(5)]
		string GetAvailableGameLanguages();
		[VTableSlot(6)]
		bool BIsSubscribedApp(UInt32 nAppID);
		[VTableSlot(7)]
		bool BIsDlcInstalled(UInt32 nAppID);
		[VTableSlot(8)]
		UInt32 GetEarliestPurchaseUnixTime(UInt32 nAppID);
		[VTableSlot(9)]
		bool BIsSubscribedFromFreeWeekend();
		[VTableSlot(10)]
		Int32 GetDLCCount();
		[VTableSlot(11)]
		bool BGetDLCDataByIndex(Int32 iDLC, ref UInt32 pAppID, ref bool pbAvailable, StringBuilder pchName, Int32 cchNameBufferSize);
		[VTableSlot(12)]
		void InstallDLC(UInt32 nAppID);
		[VTableSlot(13)]
		void UninstallDLC(UInt32 nAppID);
		[VTableSlot(14)]
		void RequestAppProofOfPurchaseKey(UInt32 nAppID);
		[VTableSlot(15)]
		bool GetCurrentBetaName(StringBuilder pchName, Int32 cchNameBufferSize);
		[VTableSlot(16)]
		bool MarkContentCorrupt(bool bMissingFilesOnly);
		[VTableSlot(17)]
		UInt32 GetInstalledDepots(UInt32 appID, ref UInt32 pvecDepots, UInt32 cMaxDepots);
		[VTableSlot(18)]
		UInt32 GetAppInstallDir(UInt32 appID, StringBuilder pchFolder, UInt32 cchFolderBufferSize);
		[VTableSlot(19)]
		bool BIsAppInstalled(UInt32 appID);
		[VTableSlot(20)]
		CSteamID GetAppOwner();
		[VTableSlot(21)]
		string GetLaunchQueryParam(string pchKey);
		[VTableSlot(22)]
		bool GetDlcDownloadProgress(UInt32 arg0, ref UInt64 arg1, ref UInt64 arg2);
		[VTableSlot(23)]
		Int32 GetAppBuildId();
		[VTableSlot(24)]
		void RequestAllProofOfPurchaseKeys();
		[VTableSlot(25)]
		UInt64 GetFileDetails(string pchFileName);
	};
}